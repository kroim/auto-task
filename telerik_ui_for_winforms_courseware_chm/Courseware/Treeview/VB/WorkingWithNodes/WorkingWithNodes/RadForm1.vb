Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' add nodes using RadTreeNode constructor
        Dim rootNode As RadTreeNode = New RadTreeNode("Root")
        radTreeView1.Nodes.Add(rootNode)

        ' add nodes using Nodes Add() method only
        rootNode.Nodes.Add("Child Node 1")
        rootNode.Nodes.Add("Child Node 2")
        rootNode.Nodes.Add("Child Node 3")
        Dim childNode4 As RadTreeNode = rootNode.Nodes.Add("Child Node 4")
        rootNode.Nodes.Add("Child Node 5")

        childNode4.Nodes.Add("Child Node 4 A")
        childNode4.Nodes.Add("Child Node 4 B")
        childNode4.Nodes.Add("Child Node 4 C")

        radTreeView1.ExpandAll()
    End Sub

    Private Sub btnReorder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReorder.Click
        ' move selected node to the end of the list
        ' Note: Parent and Index properties are deprecated only for "getters"
        If (Not radTreeView1.SelectedNode Is Nothing) AndAlso (Not radTreeView1.SelectedNode.Parent Is Nothing) Then
            Dim nodes As RadTreeNodeCollection = radTreeView1.SelectedNode.Parent.Nodes
            nodes.Move(radTreeView1.SelectedNode.Index, nodes.Count - 1)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        radTreeView1.Filter = CommandBarTextBox1.Text
    End Sub

    Private Sub cbMultiSelect_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles tbMultiSelect.ToggleStateChanged
        radTreeView1.MultiSelect = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
    End Sub

    Private Sub btnSelectedNodes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectedNodes.Click, btnSelectedNodes.Click
        ' color the background of all selected nodes
        For Each node As RadTreeNode In radTreeView1.SelectedNodes
            node.BackColor = Color.AliceBlue
            node.BackColor2 = Color.LightBlue
        Next node
    End Sub
End Class
