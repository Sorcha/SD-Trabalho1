using System;

namespace Interfaces
{
    public interface ISearchEngine
    {
        Uri StartSearching(ISearchCriteria criteria);

        Uri StartSearching(ISearchCriteria criteria, int depth);
    }
}