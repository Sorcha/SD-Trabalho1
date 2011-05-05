using System;
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

        public LocalIndexer(MusicDatabase data, IPeerContainer container)
        {
            _dataBase = data;
        }

        public Uri SearchFor(ISearchCriteria criteria)
        {
            if (_dataBase.HasAlbum(criteria.Value))
            {

            }
            else
            {
                foreach (var availablePeer in _containerPeers.GetAvailablePeers())
                {
                    availablePeer.SearchEngine.SearchFor(criteria);
                }    
            }

        }

        public string Ping()
        {
            return "K";
        }

        #endregion
    }
}