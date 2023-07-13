Imports System.ComponentModel

Partial Public Class Form1
    Private products As New BindingList(Of Product)()

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' assign the datasource the Product type
        bindingSource1.DataSource = Me.products

        ' bind the list control
        lbProducts.DisplayMember = "Description"
        lbProducts.ValueMember = "ID"
        lbProducts.DataSource = bindingSource1

        ' bind text box and spin editor
        tbDescription.DataBindings.Add("Text", bindingSource1, "Description")
        seID.DataBindings.Add("Value", bindingSource1, "ID")

        AddHandler Me.bindingNavigatorAddNewItem.Click, AddressOf bindingNavigatorAddNewItem_Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        ' update the UI
        bindingSource1.ResetBindings(False)
    End Sub

    Private Sub bindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        ' look through existing products and get the maximum ID.
        Dim maxID As Integer = 0
        For Each product As Product In Me.products
            maxID = Math.Max(maxID, product.ID)
        Next

        Dim lastProduct As Product = Me.products(Me.products.Count - 1)
        lastProduct.ID = System.Threading.Interlocked.Increment(maxID)
        lastProduct.Description = "New Product " & maxID.ToString()
    End Sub
End Class
