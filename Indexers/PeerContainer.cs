using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;
using Interfaces;
using System.Linq;

namespace Logic
{
    public class PeerContainer : MarshalByRefObject, IPeerContainer
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }

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
            lock(this)
            {
                if (!_container.Contains(peer) && !peer.Equals(Peer.Self))
                {
                    var lease = RemotingServices.GetLifetimeService((MarshalByRefObject) peer) as ILease;
                    if (lease != null) lease.Register(new SearchEngineSponsor());

                    _container.Add(peer);
                    try
                    {
                        foreach (var peer1 in peer.PeerContainer.GetAvailablePeers())
                        {
                            Add(peer1);
                        }
                    }
                    catch(RemotingException)
                    {
                        _container.Remove(peer);
                    }
                    catch (WebException)
                    {
                        _container.Remove(peer);
                    }
                }
            }
        }

        public void Add(Uri peerUri)
        {
            lock(this)
            {
                var peerContainer =
                        (IPeerContainer)Activator.GetObject(typeof(IPeerContainer), peerUri.ToString());

                var peer = peerContainer.GetPeer();

                Add(peer);
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
            
            lock(this)
            {
                foreach (var peer in _container)
                {
                    try
                    {
                        newPeer.AddRange(peer.PeerContainer.GetAvailablePeers());
                    }
                    catch (RemotingException)
                    {
                        toRemove.Add(peer);
                    }
                    catch (WebException)
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
}