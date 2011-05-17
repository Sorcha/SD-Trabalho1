using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
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
                IAsyncResult result = del.BeginInvoke(criteria, null, null);
                
                if(result.IsCompleted)
                {
                    try
                    {
                        del.EndInvoke(result);
                    }
                    catch (WebException)
                    {
                        Peer.Self.PeerContainer.RemovePeer(peer);
                    }
                    catch (RemotingException)
                    {
                        Peer.Self.PeerContainer.RemovePeer(peer);
                    }
                }
            }
            return null;
        }
    }
}
