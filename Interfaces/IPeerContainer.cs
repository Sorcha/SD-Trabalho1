namespace Interfaces
{
    public interface IPeerContainer
    {
        IPeer this[string name] { get; set; }

        IPeer[] GetAvailablePeers();

        IPeer GetPeer();
    }
}