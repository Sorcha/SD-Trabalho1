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

        //[XmlAttribute]
        public readonly List<string> Artists = new List<string>();

        public IEnumerable<string> GetArtists()
        {
            return Artists;
        }

        public void AddArtist(string artist)
        {
            if (!Artists.Contains(artist))
                Artists.Add(artist);
            else
                throw new AlreadyExistingArtistException();
        }

        public void RemoveArtist(string artist)
        {
            Artists.Remove(artist);
        }
    }

    public class AlreadyExistingArtistException : Exception
    {
    }
}