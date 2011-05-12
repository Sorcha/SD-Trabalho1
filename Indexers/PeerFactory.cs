using System.Configuration;
using Interfaces;
using Logic.Model;

namespace Logic
{
    public class PeerFactory
    {
        public static Peer CreateInstance(string name, ReceiveResponse response)
        {
            return new Peer(name, MusicDatabase.Load(ConfigurationManager.AppSettings["DATABASE_FILE"])) { ResponseCallback = response };
        }
    }
}