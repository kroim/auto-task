Imports Telerik.WinControls.UI
Imports System.Drawing.Text
Imports System.Text
Imports Telerik.WinControls

Public Class RadForm1
    Inherits RadForm

    Public Sub New()

        InitializeComponent()

        Dim families As FontFamily() = New InstalledFontCollection().Families
        For Each family As FontFamily In families
            Dim itemToAdd As New RadListDataItem(family.Name)
            RadListControl1.Items.Add(itemToAdd)
        Next

        RadListControl1.Items.Insert(0, New RadListDataItem("put me at the top of the list"))

        RadListControl1.Items.AddRange(New RadListDataItem() {New RadListDataItem("One"), New RadListDataItem("Two"), New RadListDataItem("Three")})

        Dim item As New RadListDataItem("Telerik")
        item.Image = Image.FromFile("C:\Program Files (x86)\Telerik\RadControls for WinForms Q1 2011\Examples\QuickStart\Resources\telerikLOGO.png")
        item.TextImageRelation = TextImageRelation.ImageAboveText
        item.TextAlignment = ContentAlignment.BottomCenter
        RadListControl1.Items.Add(item)

        Dim item1 As New RadListDataItem("RadControls for WinForms")
        item1.TextAlignment = ContentAlignment.MiddleLeft
        RadListControl1.Items.Add(item1)

        Dim item2 As New RadListDataItem("Q1 2011")
        item2.TextAlignment = ContentAlignment.MiddleRight
        RadListControl1.Items.Add(item2)

        RadListControl1.AutoSizeItems = True

        RadListControl1.SelectionMode = SelectionMode.MultiExtended

    End Sub

    Private Sub btnLocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocate.Click
        Dim index As Integer = RadListControl1.FindString("Courier New")
        Dim item As RadListDataItem = RadListControl1.Items(index)
        If item IsNot Nothing Then
            RadListControl1.ListElement.ScrollToItem(item)
            RadListControl1.SelectedItem = item
        End If
    End Sub

    Private Sub Sort_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rbNone.ToggleStateChanged, rbAscending.ToggleStateChanged, rbDescending.ToggleStateChanged
        If sender Is rbNone Then
            RadListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
        ElseIf sender Is rbAscending Then
            RadListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
        ElseIf sender Is rbDescending Then
            RadListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending
        End If
    End Sub

    Private Sub btnShowSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSelected.Click
        Dim builder As New StringBuilder()
        For Each item As RadListDataItem In RadListControl1.SelectedItems
            builder.Append(item.Text)
            builder.Append(Environment.NewLine)
        Next
        RadMessageBox.SetThemeName(Me.ThemeName)
        RadMessageBox.Show(builder.ToString(), "Your Selections")
    End Sub
End Class
