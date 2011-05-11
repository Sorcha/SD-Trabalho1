using System;
using System.Collections.Generic;
using Interfaces;
using System.Linq;

namespace Indexers
{
    public class PeerContainer : MarshalByRefObject, IPeerContainer
    {
        private readonly List<IPeer> _container = new List<IPeer>();

        public IPeer this[string name]
        {
            get
            {
                return _container.Where(p => p.Name.Equals(name)).SingleOrDefault();
            }
        }

        #region Implementation of IPeerContainer

        public IPeer[] GetAvailablePeers()
        {
            return _container.ToArray();
        }

        public IPeer GetPeer()
        {
            return Peer.Self;
        }

        public bool RemovePeer(IPeer p)
        {
            if (_container.Contains(p))
            {
                _container.Remove(p);
                return true;
            }
            return false;
        }

        #endregion

        public void Add(IPeer peer)
        {
            if(!_container.Contains(peer))
            {
                _container.Add(peer);
                foreach (var peer1 in peer.PeerContainer.GetAvailablePeers())
                {
                    _container.Add(peer1);
                }
            }
            
        }

        public IEnumerable<IPeer> GetAll()
        {
            return _container;
        }

        public void Synchronize()
        {
            foreach (var peer in _container)
            {
                foreach (var peer1 in peer.PeerContainer.GetAvailablePeers())
                {
                    Add(peer1);
                }
            }
        }
    }
}