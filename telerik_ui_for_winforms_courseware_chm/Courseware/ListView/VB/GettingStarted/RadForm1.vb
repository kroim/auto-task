Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub listViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listViewButton.Click
        RadListView1.ViewType = ListViewType.ListView
        RadListView1.AllowArbitraryItemHeight = True
    End Sub

    Private Sub detailsViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detailsViewButton.Click
        RadListView1.ViewType = ListViewType.DetailsView
        RadListView1.AllowArbitraryItemHeight = True
    End Sub

    Private Sub iconsViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconsViewButton.Click
        RadListView1.ViewType = ListViewType.IconsView
        RadListView1.AllowArbitraryItemWidth = True
    End Sub
End Class
