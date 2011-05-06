using System;
using Indexers.Model;
using Interfaces;

namespace Indexers
{
    [Serializable]
    public class Peer : IPeer, IEquatable<IPeer>
    {
        public static Peer Self { get; set; } 

        private readonly string _name;
        private readonly IIndexer _searchEngine;
        private readonly IPeerContainer _peerContainer;

        public Peer(string name)
        {
            _name = name;
            _peerContainer = new PeerContainer();
            _searchEngine = new LocalIndexer(new MusicDatabase());
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

        public bool Equals(IPeer peer)
        {
            if (peer == null) return false;
            return peer.Name.Equals(Name);
        }

        public override bool Equals(object other)
        {
            IPeer peer = other as Peer;
            if (peer == null) return false; 
            return peer.Name.Equals(Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        #endregion
    }
}