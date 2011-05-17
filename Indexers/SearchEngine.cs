using System;
using System.Net;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;
using Interfaces;
using Interfaces.Model;
using Logic.Model;

namespace Logic
{
    public class SearchEngine : MarshalByRefObject, ISearchEngine
    {
        public override object InitializeLifetimeService()
        {
            var lease = base.InitializeLifetimeService() as ILease; 
            if (lease != null && lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromDays(1);
                lease.SponsorshipTimeout = TimeSpan.Zero;
                lease.RenewOnCallTime = TimeSpan.FromMinutes(30);
            }
            return lease;
        }

        private readonly IIndexer<ISearchCriteria> _localIndexer;

        public SearchEngine(MusicDatabase database, ReceiveResponse callback)
        {
            _localIndexer = new LocalIndexer(database);
            Callback = callback;
            Database = database;
        }

        #region Implementation of ISearchEngine

        public void StartSearching(ISearchCriteria criteria)
        {
            IRequest request = new Request(criteria, Callback);

            StartSearching(request);
        }

        public void StartSearching(IRequest request)
        {
            bool found = false;
            request.DecrementDepth();
            Uri localPath = _localIndexer.SearchFor(request.SearchCriteria);
            if (request.Depth != 0 && localPath == null)
            {
                new RemoteIndexer().SearchFor(request);
            }
            else
            {
                try
                {
                    found = true;
                    request.Callback(request, localPath);
                }
                catch(WebException)
                {
                    Peer.Self.PeerContainer.RemovePeer(request.Requester);
                }
                catch(RemotingException)
                {
                    Peer.Self.PeerContainer.RemovePeer(request.Requester);
                }
            }
            if(!request.Requester.Equals(Peer.Self))
                Logger.Report(request, found);
        }
        
        public ReceiveResponse Callback { get; private set; }

        public IMusicDatabase Database { get; private set; }

        #endregion
    }
}