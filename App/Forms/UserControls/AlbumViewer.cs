using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interfaces.Model;
using Logic.Model;

namespace App
{
    public partial class AlbumViewer : UserControl
    {
        private IAlbum _album;
        public AlbumViewer(IAlbum album)
        {
            InitializeComponent();
            _album = album;

            albumName.Text = _album.Name;
            musicList.Items.AddRange(_album.GetAllMusics().Select(p=>p.Name).ToArray());
        }

        private void MusicListSelectedIndexChanged(object sender, EventArgs e)
        {
            if(musicList.SelectedItem != null && !musicList.SelectedItem.Equals(""))
            {
                foreach (Control control in musicViewer.Controls)
                {
                    musicViewer.Controls.Remove(control);
                }

                musicViewer.Controls.Add(new MusicViewer(_album[((ListBox)sender).SelectedItem.ToString()]));    
            }
        }
    }
}
