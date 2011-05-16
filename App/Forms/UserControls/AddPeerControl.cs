using System;
using System.Net;
using System.Windows.Forms;
using Logic;

namespace App.Forms.UserControls
{
    public delegate void Action();

    public partial class AddPeerControl : UserControl
    {
        private Action _clickAction;
        
        public AddPeerControl(Action clickAction)
        {
            InitializeComponent();
            connect.Enabled = false;
            _clickAction = clickAction;
        }

        public AddPeerControl(Action clickAction, bool enabled)
        {
            InitializeComponent();
            connect.Enabled = enabled;
            _clickAction = clickAction;
        }

        public new bool Enabled { get { return connect.Enabled; } set { connect.Enabled = value; } }
        
        private void ConnectClick(object sender, EventArgs e)
        {
            try
            {
                var container = Peer.Self.PeerContainer;
                if (container != null)
                    container.Add(new Uri(peerAddress.Text));

                _clickAction();
            }
            catch (WebException)
            {

            }
        }
    }
}
