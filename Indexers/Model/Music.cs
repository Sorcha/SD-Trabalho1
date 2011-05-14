using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Interfaces.Model;

namespace Logic.Model
{
    [Serializable]
    public class Music : IMusic
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
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