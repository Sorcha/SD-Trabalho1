using System;
using System.Windows.Forms;
using Logic.Model;

namespace App.Forms
{
    public partial class CreateAlbumForm : Form
    {
        public Album Album { get; set; }

        public CreateAlbumForm()
        {
            InitializeComponent();
            Album = new Album();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var createMusicForm = new CreateMusicForm();
            createMusicForm.Closing += (p, t) => {
                                                     if (createMusicForm.Music != null)
                                                         Album.StoreMusic(createMusicForm.Music);
            };
            createMusicForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedMusic = musicList.SelectedItem.ToString();
            Album.RemoveMusic(selectedMusic);
            musicList.Items.Remove(selectedMusic);
        }

        private void albumName_TextChanged(object sender, EventArgs e)
        {
            Album.Name = albumName.Text;
        }
    }
}
