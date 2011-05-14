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

        private void AddMusicClick(object sender, EventArgs e)
        {
            var createMusicForm = new CreateMusicForm();
            createMusicForm.Closing += (p, t) => {
                                                     if (createMusicForm.Music != null)
                                                     {
                                                         Album.StoreMusic(createMusicForm.Music);
                                                         musicList.Items.Add(createMusicForm.Music.Name);
                                                     }
            };
            createMusicForm.Show(this);
        }

        private void RemoveMusicClick(object sender, EventArgs e)
        {
            string selectedMusic = musicList.SelectedItem.ToString();
            Album.RemoveMusic(selectedMusic);
            musicList.Items.Remove(selectedMusic);
        }

        private void AlbumNameTextChanged(object sender, EventArgs e)
        {
            Album.Name = albumName.Text;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void musicList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
