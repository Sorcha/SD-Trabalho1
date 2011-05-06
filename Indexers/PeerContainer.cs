using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting;
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

        #endregion

        public void Add(IPeer peer)
        {
            if(!_container.Contains(peer))
            {
                _container.Add(peer);
                foreach (var peer1 in peer.PeerContainer.GetAvailablePeers())
                {
                    Add(peer1);
                }
            }
            
        }

        public IEnumerable<IPeer> GetAll()
        {
            return _container;
        }

        public void Synchronize()
        {
            List<IPeer> newPeer = new List<IPeer>();
            List<IPeer> toRemove = new List<IPeer>();
            foreach (var peer in _container)
            {
                try
                {
                    foreach (var peer1 in peer.PeerContainer.GetAvailablePeers())
                    {
                        newPeer.Add(peer1);
                    }
                }
                catch(WebException e)
                {
                    toRemove.Add(peer);
                }
            }

            foreach(var peer in newPeer)
            {
                Add(peer);
            }

            foreach (var peer in toRemove)
            {
                _container.Remove(peer);
            }
        }
    }
}