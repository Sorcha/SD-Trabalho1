using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using Indexers.Model;
using Interfaces;

namespace Indexers
{
    internal delegate Uri SearchPeer(ISearchCriteria c);

    [Serializable]
    public class SearchCriteria : ISearchCriteria
    {
        #region Implementation of ISearchCriteria

        public SearchType Type { get; internal set; }

        public string Value { get; internal set; }

        public int CountOfNrPeer
        {
            get; set; }

        #endregion

        public SearchCriteria(SearchType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    public class LocalIndexer : MarshalByRefObject, IIndexer
    {
        #region Implementation of IIndexer

        private readonly MusicDatabase _dataBase;
        private readonly IPeerContainer _containerPeers;

        public LocalIndexer(MusicDatabase data,  IPeerContainer containerPeers)
        {
            _dataBase = data;
            _containerPeers = containerPeers;
        }

        public Uri SearchFor(ISearchCriteria criteria)
        {
            if (_dataBase.HasAlbum(criteria.Value))
            {
                return Peer.Self.UrlPeer;
            }

            if (criteria.CountOfNrPeer == 0)
            {
                return null;
            }

            criteria.CountOfNrPeer -= _containerPeers.GetAvailablePeers().Length;
            foreach (var availablePeer in _containerPeers.GetAvailablePeers())
            {
               
               try
               {
                   
                   //return availablePeer.SearchEngine.SearchFor(criteria);
                   SearchPeer p = availablePeer.SearchEngine.SearchFor;
                   p.BeginInvoke(criteria, CallBackSearch, null);
                    
               }
               catch (RemotingException e)
               {
                   _containerPeers.RemovePeer(availablePeer);
               }
           }
           return null;
        }

        public void CallBackSearch(IAsyncResult result)
        {
            var p = (AsyncResult)result.AsyncState;
            SearchPeer searchPeer = (SearchPeer) p.AsyncDelegate; 


            try
            {
                Uri music = searchPeer.EndInvoke(result);
                if (music != null)
                {
                    
                }
                
            }catch (RemotingException e)
            {
                
            }

            
        }

        public string Ping()
        {
            return "K";
        }

        #endregion
    }
}