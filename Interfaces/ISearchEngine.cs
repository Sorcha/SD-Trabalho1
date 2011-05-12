using System;

namespace Interfaces
{
    public interface ISearchEngine
    {
        void StartSearching(ISearchCriteria criteria);

        void StartSearching(IRequest request);
    }
}