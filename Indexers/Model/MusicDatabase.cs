using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Logic.Model
{
    [Serializable]
    public class MusicDatabase
    {
        private readonly Dictionary<string, Album> _albuns = new Dictionary<string, Album>();

        private MusicDatabase()
        {
            
        }

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
            else
                throw new AlreadyExistingAlbumException();
        }

        public static MusicDatabase Load(string fileName)
        {
            MusicDatabase dataBase = null;
            try
            {
                var xs = new XmlSerializer(typeof(MusicDatabase), new Type[] { typeof(Music), typeof(Album) });
                var stream = new FileStream(fileName, FileMode.Open);
                dataBase = (MusicDatabase)xs.Deserialize(stream);
                stream.Close();
            }
            catch (Exception)
            {
                return new MusicDatabase();
            }
            return dataBase;
        }

        public void Save(string fileName)
        {
            try
            {
                var xs = new XmlSerializer(typeof(MusicDatabase), new Type[] { typeof(Music), typeof(Album) });
                var stream = new FileStream(fileName, FileMode.Create);
                xs.Serialize(stream, this);
                stream.Close();
            }
            catch (Exception)
            {

            }
        }

        public void RemoveAlbum(string albumName)
        {
            var album = _albuns.Where(m => m.Value.Name.Equals(albumName)).Select(p => p.Key).Single();
            _albuns.Remove(album);
        }
    }

    public class AlreadyExistingAlbumException : Exception
    {
    }
}