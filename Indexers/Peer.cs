using System;
using Indexers.Model;
using Interfaces;

namespace Indexers
{
    [Serializable]
    public class Peer : IPeer
    {
        public static Peer Self { get; set; } 

        private readonly string _name;
        private readonly IIndexer _searchEngine;
        private readonly IPeerContainer _peerContainer;
        private readonly MusicDatabase _database;

        public Peer(string name, MusicDatabase database)
        {
            _database = database;
            _name = name;
            _peerContainer = new PeerContainer();
            _searchEngine = new LocalIndexer(_database, _peerContainer);
        }

        #region Implementation of IPeer

        public string Name
        {
            get { return _name; }
        }

        public IIndexer SearchEngine
        {
            get { return _searchEngine; }
        }

        public IPeerContainer PeerContainer
        {
            get { return _peerContainer; }
        }

        #endregion
    }
}