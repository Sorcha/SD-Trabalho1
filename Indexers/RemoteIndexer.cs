using System;
using System.Collections.Generic;
using Interfaces;

namespace Logic
{
    delegate void SearchDelegate(IRequest criteria);

    public class RemoteIndexer : IIndexer<IRequest>
    {
        public Uri SearchFor(IRequest criteria)
        {
            IEnumerable<IPeer> peers = Peer.Self.PeerContainer.GetAvailablePeers();
            foreach (var peer in peers)
            {
                SearchDelegate del = peer.SearchEngine.StartSearching;
                del.BeginInvoke(criteria, null, null);
            }
            return null;
        }
    }
}
