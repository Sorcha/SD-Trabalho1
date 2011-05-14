using System.Collections.Generic;

namespace Interfaces.Model
{
    public interface IAlbum
    {
        string Name { get; set; }
        IEnumerable<IMusic> GetAllMusics();
        IMusic this[string toString] { get; }
    }
}