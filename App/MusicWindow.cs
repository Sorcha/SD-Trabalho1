using System;
using System.Threading;
using System.Windows.Forms;
using Indexers;
using Logic;

namespace App
{
    public partial class MusicWindow : Form
    {
        private readonly SynchronizationContext _guiContext;
        public MusicWindow()
        {
            InitializeComponent();
            _guiContext = SynchronizationContext.Current;
        }

        private void MusicWindowLoad(object sender, EventArgs e)
        {
            UpdateAvailablePeers();

            var thread = new Thread(new PeerHunter(UpdateAvailablePeers).Hunt);
            thread.Start();
        }


        public void UpdateAvailablePeers()
        {
            _guiContext.Post(_ => {
                var peers = Peer.Self.PeerContainer.GetAvailablePeers();
            
                availablePeersList.Items.Clear();

                foreach (var peer in peers)
                {
                    availablePeersList.Items.Add(peer.Name);
                }

            },null);
        }
    }
}
