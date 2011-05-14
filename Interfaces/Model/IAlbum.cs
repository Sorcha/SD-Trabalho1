namespace Interfaces.Model
{
    public interface IAlbum
    {
        string Name { get; set; }
        IMusic[] GetAllMusics();
        IMusic this[string toString] { get; }
    }
}