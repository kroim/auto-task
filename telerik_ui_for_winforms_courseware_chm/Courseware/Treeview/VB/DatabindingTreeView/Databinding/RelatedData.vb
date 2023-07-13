Imports Telerik.WinControls.UI

Public Class RelatedData

    Private Sub RelatedData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'musicCollectionDataSet.Songs' table. You can move, or remove it, as needed.
        Me.songsTableAdapter.Fill(Me.musicCollectionDataSet.Songs)
        ' TODO: This line of code loads data into the 'musicCollectionDataSet.Artists' table. You can move, or remove it, as needed.
        Me.artistsTableAdapter.Fill(Me.musicCollectionDataSet.Artists)
        ' TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
        Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)


        Me.radTreeView1.DataSource = Me.artistsBindingSource
        Me.radTreeView1.DisplayMember = "ArtistName"
        radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID")
        radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID")
    End Sub
End Class