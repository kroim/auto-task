Imports Telerik.WinControls.UI

Public Class XMLSerialize
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim dialog As SaveFileDialog = New SaveFileDialog()
        dialog.Filter = "XML Files|*.xml"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RadTreeView1.SaveXML(dialog.FileName)
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "XML Files|*.xml"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RadTreeView1.LoadXML(dialog.FileName)
        End If
    End Sub

    Private Sub btnAddSibling_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddSibling.Click
        ' get the sibling level nodes collection and add to it
        Dim nodes As RadTreeNodeCollection = Nothing
        If (RadTreeView1.SelectedNode Is Nothing) OrElse (RadTreeView1.SelectedNode.Parent Is Nothing) Then
            nodes = RadTreeView1.Nodes
        Else
            nodes = RadTreeView1.SelectedNode.Parent.Nodes
        End If
        Dim node As New RadTreeNode(tbNodeText.Text)
        nodes.Add(node)
        RadTreeView1.BringIntoView(node)


    End Sub

    Private Sub btnAddChild_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddChild.Click
        ' add a node directly to the selected node
        If Not RadTreeView1.SelectedNode Is Nothing Then
            Dim node As New RadTreeNode(tbNodeText.Text)
            RadTreeView1.SelectedNode.Nodes.Add(node)
            RadTreeView1.BringIntoView(node)
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteNode.Click
        ' delete the selected node
        If Not RadTreeView1.SelectedNode Is Nothing Then
            RadTreeView1.SelectedNode.Remove()
        End If
    End Sub

End Class