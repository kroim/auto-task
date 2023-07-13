Public Class SelfReferencing

    Private Sub SelfReferencing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
        radTreeView1.DataSource = Me.nwindDataSet.Employees
        radTreeView1.DisplayMember = "Title"
        radTreeView1.ChildMember = "EmployeeID"
        radTreeView1.ParentMember = "ReportsTo"
    End Sub
End Class