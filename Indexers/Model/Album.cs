using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.Model
{
    [Serializable]
    public class Album
    {
        public string Name { get; set; }

        private Dictionary<string, Music> _music = new Dictionary<string, Music>(); 

        public Music this[string musicName]
        {
            get
            {
                if (_music.ContainsKey(musicName)) 
                    return _music[musicName]; 
                return null;
            }
        }

        public void StoreMusic(Music music)
        {
            if(!_music.ContainsKey(music.Name))
                _music.Add(music.Name, music);
            else
                throw new AlreadyExistingMusicException();
        }

        public void RemoveMusic(string name)
        {
            var music = _music.Where(m => m.Value.Name.Equals(name)).Select(p => p.Key).Single();
            _music.Remove(music);
        }

        public Music[] GetAllMusics()
        {
            return _music.Values.ToArray();
        }
    }

    public class AlreadyExistingMusicException : Exception
    {
    }
}