using System;
using System.Windows.Forms;
using App.Forms;
using Logic.Model;

namespace App
{
    public partial class MusicDatabaseViewer : Form
    {
        private readonly MusicDatabase _database;
        public MusicDatabaseViewer(MusicDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        private void AlbunsListSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Control control in albumViewer.Controls)
            {
                albumViewer.Controls.Remove(control);
            }

            albumViewer.Controls.Add(new AlbumViewer(_database.GetAlbum(((ListBox) sender).SelectedItem.ToString())));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var createAlbum = new CreateAlbumForm();
            createAlbum.Closing += (p, t) => _database.StoreAlbum(createAlbum.Album);
            createAlbum.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
