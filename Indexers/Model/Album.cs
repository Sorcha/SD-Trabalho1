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

        //[XmlAttribute]
        public readonly List<Music> Musics = new List<Music>(); 

        public IMusic this[string musicName]
        {
            get
            {
                if (HasMusic(musicName))
                    return Musics.Where(p => p.Name.Equals(musicName)).SingleOrDefault(); 
                return null;
            }
        }

        public bool HasMusic(string musicName)
        {
            return Musics.Where(p => p.Name.Equals(musicName)).Count() != 0;
        }

        public void StoreMusic(Music music)
        {
            if(!HasMusic(music.Name))
                Musics.Add(music);
            else
                throw new AlreadyExistingMusicException();
        }

        public void RemoveMusic(string name)
        {
            var music = this[name];
           Musics.Remove((Music)music);
        }

        public IEnumerable<IMusic> GetAllMusics()
        {
            return Musics;
        }
    }

    public class AlreadyExistingMusicException : Exception
    {
    }
}