using System;
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

        public Peer(string name)
        {
            _name = name;
            _peerContainer = new PeerContainer();
            _searchEngine = new LocalIndexer();
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