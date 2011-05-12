﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.Model;

namespace App
{
    public partial class AlbumViewer : UserControl
    {
        private Album _album;
        public AlbumViewer(Album album)
        {
            InitializeComponent();
            _album = album;

            albumName.Text = _album.Name;
            musicList.Items.AddRange(_album.GetAllMusics());
        }

        private void musicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in musicViewer.Controls)
            {
                musicViewer.Controls.Remove(control);
            }

            musicViewer.Controls.Add(new MusicViewer(_album[((ListBox)sender).SelectedItem.ToString()]));
        }
    }
}