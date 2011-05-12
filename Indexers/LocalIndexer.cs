using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using Indexers.Model;
using Interfaces;

namespace Indexers
{
    internal delegate Uri SearchPeer(ISearchCriteria c, int depth);

    [Serializable]
    public class SearchCriteria : ISearchCriteria
    {
        #region Implementation of ISearchCriteria

        public SearchType Type { get; internal set; }

        public string Value { get; internal set; }

        #endregion

        public SearchCriteria(SearchType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    public class LocalIndexer : IIndexer
    {
        #region Implementation of IIndexer

        private readonly MusicDatabase _dataBase;

        public LocalIndexer(MusicDatabase data)
        {
            _dataBase = data;

        }

        public Uri SearchFor(ISearchCriteria criteria, int depth)
        {
            if (_dataBase.HasAlbum(criteria.Value))
            {
                return new Uri("http://test.com");
            }

            if (depth == 0)
            {
                return null;
            }

            depth -= _containerPeers.GetAvailablePeers().Length;
            foreach (var availablePeer in _containerPeers.GetAvailablePeers())
            {
               try
               {
                   
                   //return availablePeer.SearchEngine.SearchFor(criteria);
                   SearchPeer p = availablePeer.SearchEngine.SearchFor;
                   p.BeginInvoke(criteria,depth, CallBackSearch, null);
                    
               }
               catch (RemotingException)
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
                
            }catch (RemotingException)
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