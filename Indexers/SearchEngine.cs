using System;
using Interfaces;

namespace Logic
{
    public class SearchEngine : MarshalByRefObject, ISearchEngine
    {
        #region Implementation of ISearchEngine

        public Uri StartSearching(ISearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Uri StartSearching(ISearchCriteria criteria, int depth)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}