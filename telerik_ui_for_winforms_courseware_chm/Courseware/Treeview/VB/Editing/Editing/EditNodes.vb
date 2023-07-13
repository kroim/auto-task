Imports Telerik.WinControls
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class EditNodes

    Private Sub EditNodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radTreeView1.AllowEdit = True
    End Sub

    Private _oldNodeText As String

    Private Sub radTreeView1_Editing(ByVal sender As Object, ByVal e As TreeNodeEditingEventArgs) Handles radTreeView1.Editing
        _oldNodeText = e.Node.Text

        ' disallow editing root nodes.
        If e.Node.Level = 0 Then
            e.Cancel = True
            lblStatus.Text = "You cannot edit a root node"
        End If
    End Sub

    Private Sub radTreeView1_ValueValidating(ByVal sender As Object, ByVal e As TreeNodeValidatingEventArgs) Handles radTreeView1.ValueValidating
        Dim newNodeText As String = TryCast(radTreeView1.ActiveEditor.Value, String)

        ' disallow blank entries
        If newNodeText.Equals(String.Empty) Then
            e.Cancel = True
            lblStatus.Text = "Cannot be blank - Enter a new value"
        End If
    End Sub

    Private Sub radTreeView1_Edited(ByVal sender As Object, ByVal e As TreeNodeEditedEventArgs) Handles radTreeView1.Edited
        ' display text before and after editing
        Dim newNodeText As String = e.Node.Text

        If (Not _oldNodeText.Equals(newNodeText)) Then
            lblStatus.Text = String.Format("Node text has changed from {0} to {1}", _oldNodeText, newNodeText)
        End If
    End Sub

    Private Sub radTreeView1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles radTreeView1.MouseDoubleClick
        ' edit double-clicked node
        Dim node As RadTreeNode = radTreeView1.GetNodeAt(e.X, e.Y)
        If Not node Is Nothing Then
            node.BeginEdit()
        End If
    End Sub
End Class
