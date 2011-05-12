using System;
using Interfaces;
using Logic.Model;

namespace Logic
{
    [Serializable]
    public class Peer : MarshalByRefObject, IPeer
    {
        public static Peer Self { get; set; } 

        public Peer(string name, MusicDatabase database)
        {
            Name = name;
            PeerContainer = new PeerContainer();
            SearchEngine = new SearchEngine();
            LocalIndexer = new LocalIndexer(database);
        }

        #region Implementation of IPeer

        public string Name { get; private set; }

        public ISearchEngine SearchEngine { get; private set; }

        public IIndexer<ISearchCriteria> LocalIndexer { get; private set; }

        public IPeerContainer PeerContainer { get; private set; }

        public ReceiveResponse ResponseCallback { get; set; }

        #endregion
    }
}