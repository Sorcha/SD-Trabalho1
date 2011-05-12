using System;


namespace Interfaces
{
    public delegate void ReceiveResponse(IRequest request, Uri response);

    public interface IPeer
    {
        string Name { get; }
        ISearchEngine SearchEngine { get; }
        IIndexer<ISearchCriteria> LocalIndexer { get; }
        IPeerContainer PeerContainer { get; }

        ReceiveResponse ResponseCallback { get; }
     }
}
