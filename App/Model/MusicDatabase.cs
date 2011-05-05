using System;
using System.Collections.Generic;

namespace App.Model
{
    public class MusicDatabase
    {
        private Dictionary<string, Album> _albuns = new Dictionary<string, Album>();

        public bool HasAlbum(string albumName)
        {
            return _albuns.ContainsKey(albumName);
        }

        public Album GetAlbum(string albumName)
        {
            if(HasAlbum(albumName))
                return _albuns[albumName];
            return null;
        }

        public void StoreAlbum(Album album)
        {
            if(!HasAlbum(album.Name))
                _albuns.Add(album.Name, album);
            throw new AlreadyExistingAlbumException();
        }
    }

    public class AlreadyExistingAlbumException : Exception
    {
    }
}