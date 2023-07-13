Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim entities As New NorthwindEntities()
        Dim query = From suppliers In entities.Suppliers.Include("Products") Select suppliers

        Me.RadGridView1.DataSource = query.ToList()
        Me.RadGridView1.AutoGenerateHierarchy = True
    End Sub
End Class
