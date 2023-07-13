Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.sales_by_CategoryTableAdapter.Fill(Me.nwindDataSet1.Sales_by_Category)
    End Sub
End Class
