namespace Interfaces
{
    public interface IPeerContainer
    {
        IPeer this[string name] { get; }

        IPeer[] GetAvailablePeers();

        IPeer GetPeer();
    }
}