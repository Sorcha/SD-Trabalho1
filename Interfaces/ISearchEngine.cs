using System;
using Interfaces.Model;

namespace Interfaces
{
    public delegate void ReceiveResponse(IRequest request, Uri response);
    
    public interface ISearchEngine
    {
        void StartSearching(ISearchCriteria criteria);

        void StartSearching(IRequest request);

        ReceiveResponse Callback { get; }

        IMusicDatabase Database { get; }
    }
}
