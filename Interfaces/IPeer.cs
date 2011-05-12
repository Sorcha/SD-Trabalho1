using System;


namespace Interfaces
{
    public interface IPeer
    {
        string Name { get; }
        IIndexer SearchEngine { get; }
        IPeerContainer PeerContainer { get; }
    }
}
