using System;
using Interfaces;
using Logic.Model;

namespace Logic
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

    public class LocalIndexer : IIndexer<ISearchCriteria>
    {
        #region Implementation of IIndexer

        private readonly MusicDatabase _dataBase;

        public LocalIndexer(MusicDatabase data)
        {
            _dataBase = data;
        }

        public Uri SearchFor(ISearchCriteria criteria)
        {
            if (_dataBase.HasAlbum(criteria.Value))
            {
                return new Uri("http://test.com");
            }

           return null;
        }

        #endregion
    }
}