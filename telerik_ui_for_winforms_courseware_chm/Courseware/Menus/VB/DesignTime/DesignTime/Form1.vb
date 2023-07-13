Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        radMenu1.MenuElement.Children(1).Visibility = ElementVisibility.Hidden
        radMenu1.Items(0).Children(0).Visibility = ElementVisibility.Hidden
    End Sub
End Class
