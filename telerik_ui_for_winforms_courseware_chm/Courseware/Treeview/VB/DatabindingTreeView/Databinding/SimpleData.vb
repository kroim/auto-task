Public Class SimpleData

    Private Sub SimpleData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
        radTreeView1.DisplayMember = "LastName"
        radTreeView1.DataSource = Me.nwindDataSet.Employees
    End Sub
End Class
