using System;
using Interfaces;
using Logic.Model;

namespace Logic
{
    [Serializable]
    public class Peer : IPeer
    {
        public static Peer Self { get; set; } 

        public Peer(string name, MusicDatabase database, ReceiveResponse responseCallback)
        {
            Name = name;
            PeerContainer = new PeerContainer();
            SearchEngine = new SearchEngine(database, responseCallback);
        }

        #region Implementation of IPeer

        public string Name { get; private set; }

        public ISearchEngine SearchEngine { get; private set; }
        
        public IPeerContainer PeerContainer { get; private set; }

        #endregion

        public override bool Equals(object obj)
        {
            if(obj is IPeer)
            {
                IPeer peer = obj as IPeer;
                return peer.Name.Equals(this.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}