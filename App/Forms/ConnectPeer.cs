using System;
using System.Configuration;
using System.Runtime.Remoting;
using System.Windows.Forms;
using App.Forms.UserControls;
using Logic;

namespace App.Forms
{
    public partial class ConnectPeer : Form
    {
        private readonly MusicWindow _form = new MusicWindow();
        private readonly AddPeerControl _addPeerControl;
    
        public ConnectPeer()
        {
            _addPeerControl = new AddPeerControl(AfterConnectAction);
            InitializeComponent();
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
            _addPeerControl.Enabled = true;
        }

        private void AfterConnectAction()
        {
            Form thisForm = this;
            _form.Show();
            _form.Closed += (_, p) =>
                                {
                                    thisForm.Close();
                                    _form.PeerHunter.Interrupt();
                                };
            Hide();
        }

        private void ConnectPeerLoad(object sender, EventArgs e)
        {
            Text += string.Format(": {0}", ConfigurationManager.AppSettings["port"]);
            _addPeerControl.Dock = DockStyle.Fill;
            addPeerPanel.Controls.Add(_addPeerControl);
        }
    }
}
