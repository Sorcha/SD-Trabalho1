using System.Collections.Generic;

namespace Interfaces
{
    public interface IPeerContainer
    {
        IPeer this[string name] { get; }

        IPeer[] GetAvailablePeers();

        IPeer GetPeer();

        bool RemovePeer(IPeer p);

        void Add(IPeer p);

        void Synchronize();

        IEnumerable<IPeer> GetAll();
    }
}