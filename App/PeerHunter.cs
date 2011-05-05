using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Indexers;

namespace App
{
    class PeerHunter
    {
        private int _timeBetweenSearches = 5000; //In ms
        private const int IncrementAfterSearch = 2;
        private const int MaxTimeBetweenSearches = 20*60*60*1000;

        public void Hunt()
        {
            do
            {
                var container =
                    Peer.Self.PeerContainer as PeerContainer;

                if (container != null) 
                    container.Synchronize();
                else
                    throw new InvalidProgramException(); //Can't be null.

                Thread.Sleep(_timeBetweenSearches);

                if (_timeBetweenSearches < MaxTimeBetweenSearches)
                    _timeBetweenSearches += _timeBetweenSearches*IncrementAfterSearch;
            } while (true);
        }
    }
}
