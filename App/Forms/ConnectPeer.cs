using System;
using System.Configuration;
using System.Net;
using System.Runtime.Remoting;
using System.Windows.Forms;
using App.Forms;
using Interfaces;
using Logic;

namespace App
{
    public partial class ConnectPeer : Form
    {
        private readonly MusicWindow _form = new MusicWindow();
            
        public ConnectPeer()
        {
            InitializeComponent();
        }

        private void ConnectClick(object sender, EventArgs e)
        {
            try
            {
                var peerContainer =
                    (IPeerContainer)Activator.GetObject(typeof(IPeerContainer), peerAddress.Text);

                var peer = peerContainer.GetPeer();

                var container = (Peer.Self.PeerContainer as PeerContainer);
                if (container != null) container.Add(peer);

                Form thisForm = this;
                _form.Show(thisForm);
                _form.Closed += (se, ev) =>
                                Application.Exit();
                Hide();   
            }
            catch(WebException)
            {
                
            }
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            Peer.Self = PeerFactory.CreateInstance(peerName.Text, _form.ShowResponse);
          
            
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PeerContainer),
                peerName.Text,
                WellKnownObjectMode.Singleton);
            _form.Text = peerName.Text;
            
            register.Enabled = false;
            peerName.Enabled = false;
            connect.Enabled = true;
        }

        private void ConnectPeerLoad(object sender, EventArgs e)
        {
            Text += string.Format(": {0}", ConfigurationManager.AppSettings["port"]);
        }
    }
}
