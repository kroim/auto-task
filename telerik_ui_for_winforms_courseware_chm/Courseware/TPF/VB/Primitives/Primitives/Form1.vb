Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radPanel1.Padding = New Padding(10)
        radPanel1.PanelElement.Children.Add(New MyElement())
    End Sub
End Class
