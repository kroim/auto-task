using System;
using Telerik.WinControls.UI;

namespace Databinding
{
    public partial class RelatedData : RadForm
    {
        public RelatedData()
        {
            InitializeComponent();
        }

        private void RelatedData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicCollectionDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this.musicCollectionDataSet.Songs);
            // TODO: This line of code loads data into the 'musicCollectionDataSet.Artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicCollectionDataSet.Artists);
            // TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);
          
           this.radTreeView1.DataSource = this.artistsBindingSource;
           this.radTreeView1.DisplayMember = "ArtistName";
           radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID");
           radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID");
        }
    }
}
