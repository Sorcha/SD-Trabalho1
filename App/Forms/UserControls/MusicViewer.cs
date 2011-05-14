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
    public partial class MusicViewer : UserControl
    {
        private IMusic _music;
        public MusicViewer(IMusic music)
        {
            InitializeComponent();
            _music = music;

            artistsList.Items.AddRange(_music.GetArtists().ToArray());
            musicName.Text = _music.Name;
        }
    }
}
