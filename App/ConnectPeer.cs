using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;
using Indexers;
using Interfaces;

namespace App
{
    public partial class ConnectPeer : Form
    {
        public ConnectPeer()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var peerContainer =
                (IPeerContainer)Activator.GetObject(typeof(IPeerContainer), peerAddress.Text);

            var peer = peerContainer.GetPeer();

            var container = (Peer.Self.PeerContainer as PeerContainer);
            if (container != null) container.Add(peer);

            Form thisForm = this;
            Form form = new MusicWindow();
            form.Show();
            form.Closed += new EventHandler((se, ev) => thisForm.Close());
            Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Peer.Self = new Peer(peerName.Text);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PeerContainer),
                peerName.Text,
                WellKnownObjectMode.Singleton);
            
            register.Enabled = false;
        }

        private void ConnectPeer_Load(object sender, EventArgs e)
        {
            this.Text += string.Format(": {0}", ConfigurationManager.AppSettings["port"]);
        }
    }
}
