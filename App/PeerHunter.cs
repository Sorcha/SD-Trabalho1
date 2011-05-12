using System;
using System.Threading;
using Logic;

namespace App
{
    internal delegate void Callback();

    class PeerHunter
    {
        private int _timeBetweenSearches = 5000; //In ms
        private const int IncrementAfterSearch = 2;
        private const int MaxTimeBetweenSearches = 20*60*60*1000;
        private readonly Callback _callback;

        public PeerHunter(Callback callback)
        {
            _callback = callback;
        }

        public void Hunt()
        {
            do
            {
                var container =
                    Peer.Self.PeerContainer as PeerContainer;

                if (container != null)
                {
                    container.Synchronize();
                    _callback();
                }
                else
                    throw new InvalidProgramException(); //Can't be null.

                Thread.Sleep(_timeBetweenSearches);

                if (_timeBetweenSearches < MaxTimeBetweenSearches)
                    _timeBetweenSearches += _timeBetweenSearches*IncrementAfterSearch;
            } while (true);
        }
    }
}
