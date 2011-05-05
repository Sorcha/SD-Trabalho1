using System;
using System.Collections.Generic;

namespace Indexers.Model
{
    [Serializable]
    public class Music
    {
        public string Name { get; set; }

        private List<string> _artists = new List<string>();

        public IEnumerable<string> GetArtists()
        {
            return _artists;
        }

        public void AddArtist(string artist)
        {
            if(!_artists.Contains(artist))
                _artists.Add(artist);
            throw new AlreadyExistingArtistException();
        }
    }

    public class AlreadyExistingArtistException : Exception
    {
    }
}