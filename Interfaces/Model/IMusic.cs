using System.Collections.Generic;

namespace Interfaces.Model
{
    public interface IMusic
    {
        string Name { get; set; }
        IEnumerable<string> GetArtists();
    }
}