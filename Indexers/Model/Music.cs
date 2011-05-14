using System;
using System.Collections.Generic;
using Interfaces.Model;

namespace Logic.Model
{
    [Serializable]
    public class Music : IMusic
    {
        public string Name { get; set; }

        private readonly List<string> _artists = new List<string>();

        public IEnumerable<string> GetArtists()
        {
            return _artists;
        }

        public void AddArtist(string artist)
        {
            if(!_artists.Contains(artist))
                _artists.Add(artist);
            else
                throw new AlreadyExistingArtistException();
        }

        public void RemoveArtist(string artist)
        {
            _artists.Remove(artist);
        }
    }

    public class AlreadyExistingArtistException : Exception
    {
    }
}