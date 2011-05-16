using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App.Forms.UserControls;
using Action = App.Forms.UserControls.Action;

namespace App.Forms
{
    public partial class AddNewPeerForm : Form
    {
        private readonly Action _postAdd;

        public AddNewPeerForm(Action postAdd)
        {
            InitializeComponent();
            _postAdd = postAdd;
        }

        private void AddNewPeerFormLoad(object sender, EventArgs e)
        {
            AddPeerControl control = new AddPeerControl(() =>
                                                            {
                                                                Close();
                                                                _postAdd();
                                                            }, true) {Dock = DockStyle.Fill};

            addPeerPanel.Controls.Add(control);
        }
    }
}
