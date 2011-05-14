﻿using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using App.Forms;
using Interfaces;
using Logic;
using Logic.Model;

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

        public void ShowResponse(IRequest request, Uri response)
        {
            
        }

        private void ViewDatabaseToolStripMenuItemClick(object sender, EventArgs e)
        {
            var databaseViewer = new MusicDatabaseViewer(Peer.Self.Database, ConfigurationManager.AppSettings["DATABASE_FILE"]);
            databaseViewer.Show(this);
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
