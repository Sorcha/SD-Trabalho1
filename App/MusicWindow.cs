using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indexers;

namespace App
{
    public partial class MusicWindow : Form
    {
        public MusicWindow()
        {
            InitializeComponent();
        }

        private void MusicWindow_Load(object sender, EventArgs e)
        {
            var peers = Peer.Self.PeerContainer.GetAvailablePeers();
            
            foreach(var peer in peers)
            {
                availablePeersList.Items.Add(peer.Name);

                foreach(var p in peer.PeerContainer.GetAvailablePeers())
                {
                    availablePeersList.Items.Add(p.Name);
                }
            }
        }
    }
}
