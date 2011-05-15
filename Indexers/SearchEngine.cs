using System;
using Interfaces;
using Interfaces.Model;
using Logic.Model;

namespace Logic
{
    public class SearchEngine : MarshalByRefObject, ISearchEngine
    {
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
            bool found;
            request.DecrementDepth();
            Uri localPath = _localIndexer.SearchFor(request.SearchCriteria);
            if (request.Depth != 0 && localPath == null)
            {
                new RemoteIndexer().SearchFor(request);
                found = false;
            }
            else
            {
                request.Callback(request, localPath);
                found = true;
            }
            if(!request.Requester.Equals(Peer.Self))
                Logger.Report(request, found);
        }
        
        public ReceiveResponse Callback { get; private set; }

        public IMusicDatabase Database { get; private set; }

        #endregion

    }
}