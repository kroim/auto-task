Imports Telerik.WinControls

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)

        ThemeResolutionService.ApplicationThemeName = "Desert"
    End Sub
End Class
