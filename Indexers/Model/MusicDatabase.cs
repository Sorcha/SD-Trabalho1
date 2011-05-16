using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Interfaces;
using Interfaces.Model;

namespace Logic.Model
{
    [Serializable]
    public class MusicDatabase : IMusicDatabase
    {
        //[XmlAttribute]
        public readonly List<Album> Albums = new List<Album>();

        private MusicDatabase()
        {
            
        }

        public bool HasAlbum(string albumName)
        {
            return Albums.Where(p => p.Name.Equals(albumName)).Count() != 0;
        }

        public IAlbum GetAlbum(string albumName)
        {
            if(HasAlbum(albumName))
                return Albums.Where(p => p.Name.Equals(albumName)).SingleOrDefault();
            return null;
        }

        public void StoreAlbum(IAlbum album)
        {
            if(!HasAlbum(album.Name))
                Albums.Add((Album)album);
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

        public IEnumerable<IAlbum> GetAllAlbums()
        {
            return Albums;
        }

        public void RemoveAlbum(string albumName)
        {
            var album = GetAlbum(albumName);
           // Albums.Remove(album);
        }
    }

    public class AlreadyExistingAlbumException : Exception
    {
    }
}