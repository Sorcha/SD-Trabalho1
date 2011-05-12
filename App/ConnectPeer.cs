using System;
using System.Configuration;
using System.Runtime.Remoting;
using System.Windows.Forms;
using Indexers;
using Interfaces;
using Logic;

namespace App
{
    public partial class ConnectPeer : Form
    {
        public ConnectPeer()
        {
            InitializeComponent();
        }

        private void ConnectClick(object sender, EventArgs e)
        {
            var peerContainer =
                (IPeerContainer)Activator.GetObject(typeof(IPeerContainer), peerAddress.Text);

            var peer = peerContainer.GetPeer();

            var container = (Peer.Self.PeerContainer as PeerContainer);
            if (container != null) container.Add(peer);

            Form thisForm = this;
            Form form = new MusicWindow();
            form.Show();
            form.Closed += (se, ev) => thisForm.Close();
            Hide();
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            Peer.Self = PeerFactory.CreateInstance(peerName.Text);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PeerContainer),
                peerName.Text,
                WellKnownObjectMode.Singleton);
            
            register.Enabled = false;
        }

        private void ConnectPeerLoad(object sender, EventArgs e)
        {
            Text += string.Format(": {0}", ConfigurationManager.AppSettings["port"]);
        }
    }
}
