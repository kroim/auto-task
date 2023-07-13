Imports BindingToServices.ServiceReference1

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim client As Service1Client = New Service1Client()
        radListControl1.DataSource = client.GetList()
        radListControl1.DisplayMember = "StringValue"
    End Sub
End Class
