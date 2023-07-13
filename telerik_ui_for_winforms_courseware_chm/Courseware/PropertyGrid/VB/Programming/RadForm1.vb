Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class RadForm1
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        RadPropertyGrid1.SelectedObject = New PropertyGridElement()

        RadPropertyGrid1.ToolbarVisible = True

        Dim clearFiltering As New RadButtonElement()
        clearFiltering.Text = "Clear"
        clearFiltering.MinSize = New System.Drawing.Size(25, 22)
        clearFiltering.StretchHorizontally = False
        RadPropertyGrid1.PropertyGridElement.ToolbarElement.Children.Add(clearFiltering)
        AddHandler clearFiltering.Click, AddressOf clearFiltering_Click


        RadPropertyGrid1.BeginEditMode = RadPropertyGridBeginEditModes.BeginEditOnClick

        RadPropertyGrid1.SelectedGridItem = RadPropertyGrid1.Items("Alignment")
        RadPropertyGrid1.PropertyGridElement.PropertyTableElement.ScrollToItem(RadPropertyGrid1.Items("Alignment"))

        AddHandler RadPropertyGrid1.ItemFormatting, AddressOf radPropertyGrid1_ItemFormatting
        AddHandler RadPropertyGrid1.PropertyValidating, AddressOf radPropertyGrid1_PropertyValidating

    End Sub

    Private Sub radPropertyGrid1_PropertyValidating(ByVal sender As Object, ByVal e As PropertyValidatingEventArgs)
        Dim item As PropertyGridItem = TryCast(e.Item, PropertyGridItem)

        If item.PropertyType Is GetType(String) Then
            If String.IsNullOrEmpty(e.NewValue.ToString()) Then
                item.ErrorMessage = "String value must not be an empty string!"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub clearFiltering_Click(ByVal sender As Object, ByVal e As EventArgs)
        RadPropertyGrid1.PropertyGridElement.ToolbarElement.SearchTextBoxElement.Text = ""
    End Sub

    Private Sub radPropertyGrid1_ItemFormatting(ByVal sender As Object, ByVal e As PropertyGridItemFormattingEventArgs)
        'set the back color of all child items to yellow
        If e.Item.Level > 0 Then
            e.VisualElement.BackColor = Color.Yellow
        Else
            e.VisualElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        'set the backcolor of items with value True to LightGreen and with value equal to False to Red
        Dim item As PropertyGridItem = TryCast(e.Item, PropertyGridItem)
        If item IsNot Nothing AndAlso item.Value IsNot Nothing Then
            If item.Value.ToString() = "True" Then
                e.VisualElement.BackColor = Color.LightGreen
            ElseIf item.Value.ToString() = "False" Then
                e.VisualElement.BackColor = Color.Red
            End If
        Else
            e.VisualElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub sortButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        RadPropertyGrid1.EnableSorting = True
        Dim sort As New SortDescriptor("FormattedValue", ListSortDirection.Ascending)
        RadPropertyGrid1.SortDescriptors.Add(sort)
    End Sub

    Private Sub groupButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        RadPropertyGrid1.EnableGrouping = True
        Dim group As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("Category", ListSortDirection.Ascending)})
        RadPropertyGrid1.GroupDescriptors.Add(group)
    End Sub

    Private Sub filterButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim filter As New FilterDescriptor("Name", FilterOperator.Contains, "size")
        RadPropertyGrid1.FilterDescriptors.Add(filter)
    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        RadPropertyGrid1.SortDescriptors.Clear()
        RadPropertyGrid1.FilterDescriptors.Clear()
        RadPropertyGrid1.GroupDescriptors.Clear()
    End Sub
End Class
