using System;
using Interfaces;

namespace Indexers
{
    [Serializable]
    public class SearchCriteria : ISearchCriteria
    {
        #region Implementation of ISearchCriteria
        
        public SearchType Type
        {
            get { throw new NotImplementedException(); }
        }

        public string Value
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }

    public class LocalIndexer : MarshalByRefObject, IIndexer
    {
        #region Implementation of IIndexer

        public Uri SearchFor(ISearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public string Ping()
        {
            return "K";
        }

        #endregion
    }
}