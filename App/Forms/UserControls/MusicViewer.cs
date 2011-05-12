using System;
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
    public partial class MusicViewer : UserControl
    {
        private Music _music;
        public MusicViewer(Music music)
        {
            InitializeComponent();
            _music = music;

            artistsList.Items.AddRange(_music.GetArtists().ToArray());
            musicName.Text = _music.Name;
        }
    }
}
