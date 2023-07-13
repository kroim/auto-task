Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "Office2007Silver"

        Dim node As RadTreeNode = radTreeView1.Nodes("Email Contacts").Nodes.Add("Bob Tony")
        node.Selected = True
        radTreeView1.Nodes("Email Contacts").Nodes.Add("Sue Winchell")
        radTreeView1.Nodes("Email Contacts").Nodes.Add("Lui Sang")
        radTreeView1.Nodes("Lists").Nodes.Add("Priorities")
        radTreeView1.Nodes("Lists").Nodes.Add("Opportunities")
        radTreeView1.Nodes("Lists").Nodes.Add("Issues")
        node = radTreeView1.Nodes("Reports").Nodes.Add("June Sales")
        node.ContextMenu = radContextMenu1
        node = radTreeView1.Nodes("Reports").Nodes.Add("July Sales")
        node.ContextMenu = radContextMenu1
        node = radTreeView1.Nodes("Reports").Nodes.Add("First Quarter Summary")
        node.ContextMenu = radContextMenu1
        node = radTreeView1.Nodes("Reports").Nodes.Add("Second Quarter Summary")
        node.ContextMenu = radContextMenu1
    End Sub
End Class
