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

            set
            {
                if (value == null) throw new ArgumentNullException("value");
                _container.Add(value);
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
    }
}