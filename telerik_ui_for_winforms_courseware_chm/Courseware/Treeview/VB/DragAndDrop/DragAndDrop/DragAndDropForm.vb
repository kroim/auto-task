Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class DragAndDropForm

    Private Sub DragAndDropForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 19
            tvLeft.Nodes.Add("Node " & i)
        Next

        ' configure treeview and hook up events
        tvLeft.ExpandAll()
        AddHandler tvLeft.TreeViewElement.DragDropService.PreviewDragDrop, AddressOf DragDropService_PreviewDragDrop
        AddHandler tvLeft.TreeViewElement.DragDropService.PreviewDragOver, AddressOf DragDropService_PreviewDragOver

        ' create columns and configure grid
        Dim nameColumn As New GridViewTextBoxColumn("Name")
        grdLowerRight.Columns.Add(nameColumn)
        grdLowerRight.AllowRowReorder = True
        grdLowerRight.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        Dim gridDragDropService As RadDragDropService = grdLowerRight.GridViewElement.GetService(Of RadDragDropService)()
        AddHandler gridDragDropService.PreviewDragDrop, AddressOf gridDragDropService_PreviewDragDrop
        AddHandler gridDragDropService.PreviewDragOver, AddressOf gridDragDropService_PreviewDragOver

    End Sub

#Region "treeview to gridview and vice versa"
    Private Sub gridDragDropService_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
        'if the drop target is TreeNodeElement enable dropping
        Dim nodeElement As TreeNodeElement = TryCast(e.HitTarget, TreeNodeElement)
        If nodeElement IsNot Nothing Then
            e.CanDrop = True
        End If
    End Sub

    Private Sub gridDragDropService_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
        Dim rowElement As GridDataRowElement = TryCast(e.DragInstance, GridDataRowElement)
        Dim nodeElement As TreeNodeElement = TryCast(e.HitTarget, TreeNodeElement)

        If nodeElement IsNot Nothing Then
            'insert the node at the place under the currently hovered node
            tvLeft.Nodes.Insert(nodeElement.Data.Index, New RadTreeNode(grdLowerRight.CurrentCell.Text))

            'remove the dragged row from RadGridView
            grdLowerRight.Rows.Remove(rowElement.Data)
            e.Handled = True
        End If
    End Sub

    Private Sub DragDropService_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
        Dim tableElement As GridTableElement = TryCast(e.HitTarget, GridTableElement)
        Dim dataRow As GridDataRowElement = TryCast(e.HitTarget, GridDataRowElement)

        Trace.WriteLine(e.HitTarget)
        'if dragged in RadGridView or over a data row in RadGridView, enable dropping
        If tableElement IsNot Nothing OrElse dataRow IsNot Nothing Then
            e.CanDrop = True
        End If
    End Sub

    Private Sub DragDropService_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
        Dim tableElement As GridTableElement = TryCast(e.HitTarget, GridTableElement)
        Dim dataRow As GridDataRowElement = TryCast(e.HitTarget, GridDataRowElement)
        Dim nodeElement As TreeNodeElement = TryCast(e.DragInstance, TreeNodeElement)

        'if dragged over RadGridView add new row to the Rows collection with the node data
        If tableElement IsNot Nothing Then
            tableElement.ViewTemplate.Rows.Add(nodeElement.Data.Text)
            tvLeft.Nodes.Remove(nodeElement.Data)
            e.Handled = True
            'if dragged over a row, insert new row with the node data at the hovered row place 
        ElseIf dataRow IsNot Nothing Then
            Dim rowInfo As GridViewRowInfo = dataRow.ViewTemplate.Rows.NewRow()
            rowInfo.Cells(0).Value = nodeElement.Data.Text
            dataRow.ViewTemplate.Rows.Insert(dataRow.RowInfo.Index, rowInfo)
            tvLeft.Nodes.Remove(nodeElement.Data)
            e.Handled = True
        End If
    End Sub
#End Region

#Region "toggle button event handlers"
    Private Sub btnAllowDragDrop_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles btnAllowDragDrop.ToggleStateChanged
        tvLeft.AllowDragDrop = Convert.ToBoolean(args.ToggleState)
        tvTopRight.AllowDragDrop = Convert.ToBoolean(args.ToggleState)
    End Sub

    Private Sub btnFeedback_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles btnFeedback.ToggleStateChanged
        tvLeft.ShowDragHint = Convert.ToBoolean(args.ToggleState)
        tvLeft.ShowDropHint = Convert.ToBoolean(args.ToggleState)
    End Sub
#End Region

#Region "standard text box to treeview"
    Private Sub TextBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
        TextBox1.DoDragDrop(TextBox1.Text, DragDropEffects.Copy Or DragDropEffects.Move)
    End Sub

    Private Sub tvTopRight_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvTopRight.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub tvTopRight_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvTopRight.DragDrop
        Dim p As Point = tvTopRight.PointToClient(New Point(e.X, e.Y))
        Dim hoverNode As RadTreeNode = tvTopRight.GetNodeAt(p.X, p.Y)

        If hoverNode Is Nothing Then
            tvTopRight.Nodes.Add(e.Data.GetData(DataFormats.Text).ToString())
            Return
        End If
        hoverNode.Nodes.Add(e.Data.GetData(DataFormats.Text).ToString())
    End Sub
#End Region
End Class
