using System.Configuration;
using Indexers;
using Indexers.Model;

namespace Logic
{
    public class PeerFactory
    {
        public static Peer CreateInstance(string name)
        {
            return new Peer(name, MusicDatabase.Load(ConfigurationManager.AppSettings["DATABASE_FILE"]));
        }
    }
}