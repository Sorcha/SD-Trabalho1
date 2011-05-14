using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Interfaces.Model;

namespace Logic.Model
{
    [Serializable]
    public class Album : IAlbum
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        private readonly List<IMusic> _music = new List<IMusic>(); 

        public IMusic this[string musicName]
        {
            get
            {
                if (HasMusic(musicName))
                    return _music.Where(p => p.Name.Equals(musicName)).SingleOrDefault(); 
                return null;
            }
        }

        public bool HasMusic(string musicName)
        {
            return _music.Where(p => p.Name.Equals(musicName)).Count() != 0;
        }

        public void StoreMusic(Music music)
        {
            if(!HasMusic(music.Name))
                _music.Add(music);
            else
                throw new AlreadyExistingMusicException();
        }

        public void RemoveMusic(string name)
        {
            var music = this[name];
            _music.Remove(music);
        }

        public IEnumerable<IMusic> GetAllMusics()
        {
            return _music;
        }
    }

    public class AlreadyExistingMusicException : Exception
    {
    }
}