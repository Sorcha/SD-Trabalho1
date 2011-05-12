namespace Interfaces
{
    public interface IRequest
    {
        string Identifier { get; }
        int Depth { get; }
        ISearchCriteria SearchCriteria { get; }
        IPeer Requester { get; }

        int DecrementDepth();
    }
}