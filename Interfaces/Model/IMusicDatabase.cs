using System.Collections.Generic;

namespace Interfaces.Model
{
    public interface IMusicDatabase
    {
        IAlbum GetAlbum(string toString);
        void StoreAlbum(IAlbum album);
        void RemoveAlbum(string selectedAlbum);
        void Save(string fileName);
        IEnumerable<IAlbum> GetAllAlbums();
    }
}