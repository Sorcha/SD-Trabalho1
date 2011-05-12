using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.Model;

namespace App.Forms
{
    public partial class CreateMusicForm : Form
    {
        public Music Music { get; private set; }

        public CreateMusicForm()
        {
            InitializeComponent();
            Music = new Music();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addArtistPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Music.AddArtist(artistName.Text);
            artistsList.Items.Add(artistName.Text);
            
            artistName.Text = "";
            addArtistPanel.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            Music.Name = name.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedArtist = artistsList.SelectedItem.ToString();
            Music.RemoveArtist(selectedArtist);
            artistsList.Items.Remove(selectedArtist);
        }
    }
}
