Imports Telerik.WinControls.UI

Public Class CheckBoxes
    Private Sub CheckBoxes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' display checkboxes next to nodes
        radTreeView1.CheckBoxes = True

        ' create a root node and set its CheckType to None 
        Dim root As New RadTreeNode("Options")
        root.Expanded = True
        root.CheckType = CheckType.None

        ' create three nodes with radio buttons and select the second node
        Dim node1 As New RadTreeNode("Minimal")
        node1.CheckType = CheckType.RadioButton

        Dim node2 As New RadTreeNode("Install All")
        node2.CheckType = CheckType.RadioButton
        node2.CheckState = Telerik.WinControls.Enumerations.ToggleState.[On]

        Dim node3 As New RadTreeNode("Custom")
        node3.CheckType = CheckType.RadioButton

        ' add a checkbox node and select it
        Dim node4 As New RadTreeNode("Include Extras")
        node4.CheckType = CheckType.CheckBox
        node4.CheckState = Telerik.WinControls.Enumerations.ToggleState.[On]

        ' add nodes to the root node
        root.Nodes.Add(node1)
        root.Nodes.Add(node2)
        root.Nodes.Add(node3)
        root.Nodes.Add(node4)

        ' add root to the treeview nodes
        radTreeView1.Nodes.Add(root)
    End Sub
End Class
