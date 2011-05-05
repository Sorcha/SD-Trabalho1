using System;
using System.Collections.Generic;

namespace Indexers.Model
{
    [Serializable]
    public class Album
    {
        public string Name { get; internal set; }

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
            throw new AlreadyExistingMusicException();
        }
    }

    public class AlreadyExistingMusicException : Exception
    {
    }
}