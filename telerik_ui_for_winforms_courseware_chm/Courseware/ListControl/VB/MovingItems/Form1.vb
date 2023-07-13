Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1
    Private _dragRectangle As Rectangle = Rectangle.Empty
    Private _currentItem As RadListDataItem

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        lcLeft.SelectionMode = SelectionMode.MultiExtended
        lcLeft.AllowDrop = True

        lcRight.SelectionMode = SelectionMode.MultiExtended
        lcRight.AllowDrop = True
    End Sub

    Private Sub lcLeft_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcLeft.MouseDown
        ' get the listcontrol that items are being dragged from
        Dim sourceListControl As RadListControl = TryCast(sender, RadListControl)

        ' get the list box item directly under the mouse 
        Dim element As RadElement = sourceListControl.ElementTree.GetElementAtPoint(e.Location)
        Dim visualItem As RadListVisualItem = TryCast(element, RadListVisualItem)
        If visualItem IsNot Nothing Then
            _currentItem = visualItem.Data
            ' create a "drag rectangle" with mouse in center
            Dim dragPoint As New Point(e.X - (SystemInformation.DragSize.Width / 2), e.Y - (SystemInformation.DragSize.Height / 2))
            _dragRectangle = New Rectangle(dragPoint, SystemInformation.DragSize)
        End If
    End Sub

    Private Sub lcLeft_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcLeft.MouseMove
        Dim sourceListControl As RadListControl = TryCast(sender, RadListControl)
        ' we have at least one item to drop
        If _currentItem IsNot Nothing Then
            ' we have moved outside the rectangle, so start the drag drop
            If Not _dragRectangle.Contains(e.X, e.Y) Then
                sourceListControl.DoDragDrop(sourceListControl, DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub lcLeft_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcLeft.MouseUp
        ' we're no longer dragging, so clear these temporary variables
        _dragRectangle = Rectangle.Empty
        _currentItem = Nothing
    End Sub

    Private Sub lcRight_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles lcRight.DragEnter
        ' verify that the drag contains the RadListControl and that 
        ' we're not dragging onto the same list control.
        If e.Data.GetDataPresent(GetType(RadListControl)) Then
            Dim sourceListControl As RadListControl = DirectCast(e.Data.GetData(GetType(RadListControl)), RadListControl)
            If sourceListControl IsNot sender Then
                e.Effect = DragDropEffects.Move
            End If
        End If
    End Sub

    Private Sub lcRight_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles lcRight.DragDrop
        ' get a reference to the source list control, 
        ' and move the items. 
        Dim sourceListControl As RadListControl = DirectCast(e.Data.GetData(GetType(RadListControl)), RadListControl)
        If _currentItem.Selected = False Then
            _currentItem.Selected = True
        End If
        MoveItems(sourceListControl, TryCast(sender, RadListControl))
        _dragRectangle = Rectangle.Empty
        _currentItem = Nothing
    End Sub

    Private Sub MoveItems(ByVal source As RadListControl, ByVal target As RadListControl)

        Dim itemsToMove As New List(Of RadListDataItem)()
        For Each item As RadListDataItem In source.SelectedItems
            itemsToMove.Add(item)
        Next

        For Each item As RadListDataItem In itemsToMove
            target.Items.Add(item)
        Next
    End Sub
End Class
