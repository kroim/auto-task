Imports System.ComponentModel

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim products As BindingList(Of Product) = New BindingList(Of Product)()
        products.Add(New Product(1, "Coffee", 1.4))
        products.Add(New Product(2, "Latte", 2.4))
        products.Add(New Product(3, "Mocha", 2.7))
        products.Add(New Product(4, "Expresso", 2.5))
        products.Add(New Product(5, "Tea", 1.3))
        products.Add(New Product(6, "Chai", 1.5))
        products.Add(New Product(7, "Cafe au Lait", 1.5))

        Dim productQuery As IEnumerable(Of Product) = From product _
        In products _
        Where product.Description.StartsWith("C") _
        Where product.Price > 1.49 _
        Order By product.Description _
        Select product

        radListControl1.DataSource = New BindingSource(productQuery, "")
        radListControl1.ValueMember = "ID"
        radListControl1.DisplayMember = "Description"
    End Sub
End Class
