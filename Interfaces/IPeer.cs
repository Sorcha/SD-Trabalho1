using System;


namespace Interfaces
{
    public interface IPeer
    {
        string Name { get; }
        ISearchEngine SearchEngine { get; }
        IPeerContainer PeerContainer { get; }
     }
}
