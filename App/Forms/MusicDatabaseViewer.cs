using System;
using System.Linq;
using System.Windows.Forms;
using Interfaces;
using Interfaces.Model;
using Logic.Model;

namespace App.Forms
{
    public partial class MusicDatabaseViewer : Form
    {
        private readonly IMusicDatabase _database;
        private readonly string _fileName;

        public MusicDatabaseViewer(IMusicDatabase database)
        {
            InitializeComponent();
            _database = database;

            albunsList.Items.AddRange(_database.GetAllAlbums().Select(p => p.Name).ToArray());
        }

        public MusicDatabaseViewer(IMusicDatabase database, string fileName) : this(database)
        {
            _fileName = fileName;
        }

        private void AlbunsListSelectedIndexChanged(object sender, EventArgs e)
        {
            if(albunsList.SelectedItem != null && !albunsList.SelectedItem.Equals(""))
            {
                foreach (Control control in albumViewer.Controls)
                {
                    albumViewer.Controls.Remove(control);
                }

                albumViewer.Controls.Add(new AlbumViewer(_database.GetAlbum(((ListBox)sender).SelectedItem.ToString())));
            }
        }

        private void AddAlbumClick(object sender, EventArgs e)
        {
            var createAlbum = new CreateAlbumForm();
            createAlbum.Closing += (p, t) => { 
                                                if(createAlbum.Album != null)
                                                {
                                                    _database.StoreAlbum(createAlbum.Album);
                                                    albunsList.Items.Add(createAlbum.Album.Name);
                                                }
                                              };
            createAlbum.Show(this);
        }

        private void RemoveAlbumClick(object sender, EventArgs e)
        {
            string selectedAlbum = albunsList.SelectedItem.ToString();
            _database.RemoveAlbum(selectedAlbum);
            albunsList.Items.Remove(selectedAlbum);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            string fileName = null;
            if(_fileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Music Database Files (*.msdb)|*.msdb";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                   fileName = dialog.FileName;
                }
            }
            else
            {
                fileName = _fileName;
            }

            if(fileName != null)
            {
                _database.Save(fileName);
                Close();
            }
        }
    }
}
