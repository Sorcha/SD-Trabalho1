using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using Interfaces;
using Logic;

namespace App.Forms
{
    public partial class MusicWindow : Form
    {
        private readonly SynchronizationContext _guiContext;
        public MusicWindow()
        {
            InitializeComponent();
            _guiContext = SynchronizationContext.Current;
        }

        private void MusicWindowLoad(object sender, EventArgs e)
        {
            Logger.CreateLogger(ShowLog);
            
            UpdateAvailablePeers();

            var thread = new Thread(new PeerHunter(UpdateAvailablePeers).Hunt);
            thread.Start();
        }

        private void ShowLog(IRequest request, bool found)
        {
            remoteRequests.Items.Add(string.Format("{0} - {1} : {2} | {3}", request.Requester.Name,
                request.SearchCriteria.Type, request.SearchCriteria.Value, (found ? "" : "Not ") + "Found"));
        }

        public void UpdateAvailablePeers()
        {
            _guiContext.Post(_ => {
                var peers = Peer.Self.PeerContainer.GetAvailablePeers();
            
                availablePeersList.Items.Clear();

                foreach (var peer in peers)
                {
                    availablePeersList.Items.Add(peer.Name);
                }

            },null);
        }

        public void ShowResponse(IRequest request, Uri response)
        {
            _guiContext.Post(_ =>
                                 {
                                     foreach (TabPage source in responsesTab.TabPages)
                                     {
                                         if (source.Text.Equals(request.SearchCriteria.Value))
                                         {
                                             ListBox list;
                                             if (source.Controls.Count == 0)
                                             {
                                                 list = new ListBox {Dock = DockStyle.Fill};
                                                 source.Controls.Add(list);
                                             }
                                             else
                                                list = source.Controls[0] as ListBox;

                                             if (list != null)
                                             {
                                                 list.Items.Add(response);
                                             }
                                             break;
                                         }
                                     }
                                 }, null);
            
        }

        private void ViewDatabaseToolStripMenuItemClick(object sender, EventArgs e)
        {
            var databaseViewer = new MusicDatabaseViewer(Peer.Self.SearchEngine.Database, ConfigurationManager.AppSettings["DATABASE_FILE"]);
            databaseViewer.Show(this);
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            responsesTab.TabPages.Add(new TabPage(searchTB.Text));
            Peer.Self.SearchEngine.StartSearching(new SearchCriteria(SearchType.Album, searchTB.Text));
            searchTB.Text = "";
        }
    }
}
