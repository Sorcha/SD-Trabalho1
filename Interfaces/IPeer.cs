using System;


namespace Interfaces
{
    public interface IPeer
    {
        string Name { get; }
        Uri UrlPeer { get; }
        IIndexer SearchEngine { get; }

        IPeerContainer PeerContainer { get; }
    }
}
