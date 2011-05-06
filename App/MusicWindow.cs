﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Indexers;

namespace App
{
    public partial class MusicWindow : Form
    {
        private SynchronizationContext _guiContext;
        public MusicWindow()
        {
            InitializeComponent();
            _guiContext = SynchronizationContext.Current;
        }

        private void MusicWindow_Load(object sender, EventArgs e)
        {
            UpdateAvailablePeers();

            Thread thread = new Thread(new PeerHunter(UpdateAvailablePeers).Hunt);
            thread.Start();
        }


        public void UpdateAvailablePeers()
        {
            _guiContext.Post((_)=> {
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
