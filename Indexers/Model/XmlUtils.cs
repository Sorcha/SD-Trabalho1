using System;
using System.IO;
using System.Xml.Serialization;

namespace Indexers.Model
{
    public class XmlUtils
    {

        public MusicDatabase DeserializeMyCollection(string fileName)
        {
            MusicDatabase dataBase = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(MusicDatabase), new Type[] { typeof(Music), typeof(Album) });
                FileStream stream = new FileStream(fileName, FileMode.Open);
                dataBase = (MusicDatabase)xs.Deserialize(stream);
                stream.Close();
            }
            catch (Exception ex)
            {
                
            }
            return dataBase;
        }
    }
}
