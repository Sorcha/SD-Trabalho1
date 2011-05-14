namespace Interfaces
{
    public interface IRequest
    {
        string Identifier { get; }
        int Depth { get; }
        ISearchCriteria SearchCriteria { get; }
        IPeer Requester { get; }
        ReceiveResponse Callback { get; }

        int DecrementDepth();
    }
}