Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Enumerations
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Public Class Programmingh
    Public Sub New()
        InitializeComponent()

        AddHandler Me.RadListView1.ItemDataBound, AddressOf radListView1_ItemDataBound
        AddHandler Me.RadListView1.VisualItemFormatting, AddressOf radListView1_VisualItemFormatting
        AddHandler Me.RadListView1.ViewTypeChanged, AddressOf radListView1_ViewTypeChanged
        AddHandler Me.RadListView1.CellFormatting, AddressOf radListView1_CellFormatting
        AddHandler Me.RadListView1.ColumnCreating, AddressOf radListView1_ColumnCreating

        Me.RadListView1.AllowEdit = False
        Me.RadListView1.AllowRemove = False
        Me.RadListView1.DataSource = Me.SongsDataTableBindingSource
        Me.RadListView1.DisplayMember = "SongName"
        Me.RadListView1.ValueMember = "SongID"

        Me.RadListView1.ViewType = ListViewType.IconsView
    End Sub

    Private Sub ListViewGettingStarted_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicCollectionDataSet._SongsDataTable' table. You can move, or remove it, as needed.
        Me.SongsDataTableTableAdapter.Fill(Me.MusicCollectionDataSet.SongsDataTable)

    End Sub

    Private Sub SetupDetailsView()
        Me.RadListView1.AllowArbitraryItemHeight = True
    End Sub

    Private Sub SetupIconsView()
        Me.RadListView1.ItemSize = New Size(200, 64)
        Me.RadListView1.ItemSpacing = 5
        Me.RadListView1.AllowArbitraryItemHeight = True
    End Sub

    Private Sub SetupSimpleListView()
        Me.RadListView1.AllowArbitraryItemHeight = True
    End Sub

    Private Sub radListView1_ViewTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case RadListView1.ViewType
            Case ListViewType.ListView
                SetupSimpleListView()
                Exit Select
            Case ListViewType.IconsView
                SetupIconsView()
                Exit Select
            Case ListViewType.DetailsView
                SetupDetailsView()
                Exit Select
        End Select
    End Sub

    Private Sub radListView1_ColumnCreating(ByVal sender As Object, ByVal e As ListViewColumnCreatingEventArgs)
        If e.Column.FieldName = "SongID" OrElse e.Column.FieldName = "Image" Then
            e.Column.Visible = False
        End If

        If e.Column.FieldName = "SongName" Then
            e.Column.HeaderText = "Song Title"
        End If

        If e.Column.FieldName = "ArtistName" Then
            e.Column.HeaderText = "Artist"
        End If

        If e.Column.FieldName = "AlbumName" Then
            e.Column.HeaderText = "Album"
        End If
    End Sub

    Private Sub radListView1_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)
        If e.CellElement.Image IsNot Nothing Then
            e.CellElement.Image = e.CellElement.Image.GetThumbnailImage(32, 32, Nothing, IntPtr.Zero)
        End If
    End Sub

    Private Sub radListView1_VisualItemFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemEventArgs)
        If e.VisualItem.Data.Image IsNot Nothing Then
            e.VisualItem.Image = e.VisualItem.Data.Image.GetThumbnailImage(32, 32, Nothing, IntPtr.Zero)
            e.VisualItem.Layout.RightPart.Margin = New Windows.Forms.Padding(2, 0, 0, 0)
        End If

        If Me.RadListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView AndAlso e.VisualItem.Data.DataBoundItem IsNot Nothing Then
            Dim albumName As String = DirectCast(DirectCast(e.VisualItem.Data.DataBoundItem, System.Data.DataRowView).Row, MusicCollectionDataSet.SongsDataTableRow).AlbumName
            Dim artisName As String = DirectCast(DirectCast(e.VisualItem.Data.DataBoundItem, System.Data.DataRowView).Row, MusicCollectionDataSet.SongsDataTableRow).ArtistName
            Dim songName As String = DirectCast(DirectCast(e.VisualItem.Data.DataBoundItem, System.Data.DataRowView).Row, MusicCollectionDataSet.SongsDataTableRow).SongName
            e.VisualItem.Text = "<html> " + songName + "<br><span style=""color:#999999""> " + artisName + "<br> " + albumName + "</span>"
        End If
    End Sub

    Private Sub radListView1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs)
        Dim row As DataRowView = TryCast(e.Item.DataBoundItem, DataRowView)
        Dim songRow As MusicCollectionDataSet.SongsDataTableRow = TryCast(row.Row, MusicCollectionDataSet.SongsDataTableRow)
        e.Item.Image = Image.FromStream(New MemoryStream(songRow.Image), False, False)
    End Sub

    Private updatingToggleState As Boolean = False

    Private Sub ViewToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles commandBarToggleButtonTiles.ToggleStateChanged, commandBarToggleButtonList.ToggleStateChanged, commandBarToggleButtonDetails.ToggleStateChanged
        If updatingToggleState Then
            Return
        End If

        Me.updatingToggleState = True

        If Me.commandBarToggleButtonDetails IsNot sender Then
            Me.commandBarToggleButtonDetails.ToggleState = ToggleState.Off
        End If

        If Me.commandBarToggleButtonList IsNot sender Then
            Me.commandBarToggleButtonList.ToggleState = ToggleState.Off
        End If

        If Me.commandBarToggleButtonTiles IsNot sender Then
            Me.commandBarToggleButtonTiles.ToggleState = ToggleState.Off
        End If

        Me.updatingToggleState = False

        If Me.commandBarToggleButtonDetails.ToggleState = ToggleState.[On] Then
            Me.RadListView1.ViewType = ListViewType.DetailsView
        End If

        If Me.commandBarToggleButtonList.ToggleState = ToggleState.[On] Then
            Me.RadListView1.ViewType = ListViewType.ListView
        End If

        If Me.commandBarToggleButtonTiles.ToggleState = ToggleState.[On] Then
            Me.RadListView1.ViewType = ListViewType.IconsView
        End If

    End Sub

    Private Sub ViewToggleButton_ToggleStateChanging(ByVal sender As Object, ByVal args As StateChangingEventArgs) Handles commandBarToggleButtonTiles.ToggleStateChanging, commandBarToggleButtonList.ToggleStateChanging, commandBarToggleButtonDetails.ToggleStateChanging
        If Not updatingToggleState AndAlso args.OldValue = ToggleState.[On] Then
            args.Cancel = True
        End If
    End Sub

    Private Sub commandBarDropDownSort_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles commandBarDropDownSort.SelectedIndexChanged
        Me.RadListView1.SortDescriptors.Clear()
        Select Case Me.commandBarDropDownSort.Text
            Case "Song Name"
                Me.RadListView1.SortDescriptors.Add(New SortDescriptor("SongName", ListSortDirection.Ascending))
                Me.RadListView1.EnableSorting = True
                Exit Select
            Case "Album"
                Me.RadListView1.SortDescriptors.Add(New SortDescriptor("AlbumName", ListSortDirection.Ascending))
                Me.RadListView1.EnableSorting = True
                Exit Select
            Case "Artist"
                Me.RadListView1.SortDescriptors.Add(New SortDescriptor("ArtistName", ListSortDirection.Ascending))
                Me.RadListView1.EnableSorting = True
                Exit Select
        End Select
    End Sub

    Private Sub commandBarDropDownGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles commandBarDropDownGroup.SelectedIndexChanged
        Me.RadListView1.GroupDescriptors.Clear()
        Select Case Me.commandBarDropDownGroup.Text
            Case "None"
                Me.RadListView1.EnableGrouping = False
                Me.RadListView1.ShowGroups = False
                Exit Select
            Case "Album"
                Me.RadListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() {New SortDescriptor("AlbumName", ListSortDirection.Ascending)}))
                Me.RadListView1.EnableGrouping = True
                Me.RadListView1.ShowGroups = True
                Exit Select
            Case "Artist"
                Me.RadListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() {New SortDescriptor("ArtistName", ListSortDirection.Ascending)}))
                Me.RadListView1.EnableGrouping = True
                Me.RadListView1.ShowGroups = True
                Exit Select
        End Select
    End Sub

    Private Sub commandBarTextBoxFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles commandBarTextBoxFilter.TextChanged
        Me.RadListView1.FilterDescriptors.Clear()

        If [String].IsNullOrEmpty(Me.commandBarTextBoxFilter.Text) Then
            Me.RadListView1.EnableFiltering = False
        Else
            Me.RadListView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.[Or]
            Me.RadListView1.FilterDescriptors.Add("SongName", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
            Me.RadListView1.FilterDescriptors.Add("AlbumName", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
            Me.RadListView1.FilterDescriptors.Add("ArtistName", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
            Me.RadListView1.EnableFiltering = True
        End If
    End Sub

End Class