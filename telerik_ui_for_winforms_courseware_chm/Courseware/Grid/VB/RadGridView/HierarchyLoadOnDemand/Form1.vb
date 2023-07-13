Imports Telerik.WinControls.UI

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProductModelTableAdapter.Fill(Me.AdventureWorksDataSet.ProductModel)
        Me.ProductTableAdapter.Fill(Me.AdventureWorksDataSet.Product)

        Me.RadGridView1.DataSource = ProductModelBindingSource

        Dim childTemplate As GridViewTemplate = CreateChildTemplate()
        Me.RadGridView1.Templates.Add(childTemplate)

        childTemplate.HierarchyDataProvider = New GridViewEventDataProvider(childTemplate)
        AddHandler RadGridView1.RowSourceNeeded, AddressOf radGridView1_RowSourceNeeded

    End Sub

    Private Function CreateChildTemplate() As GridViewTemplate
        Dim template As New GridViewTemplate()
        template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Dim namecolumn As New GridViewTextBoxColumn("Name")
        Dim productNumberColumn As New GridViewTextBoxColumn("ProductNumber")
        Dim colorColumn As New GridViewTextBoxColumn("Color")
        Dim listPriceColumn As New GridViewDecimalColumn("ListPrice")
        Dim sizeColumn As New GridViewTextBoxColumn("Size")
        Dim weightColumn As New GridViewDecimalColumn("Weight")
        Dim discontinuedColumn As New GridViewDateTimeColumn("DiscontinuedDate")
        template.Columns.AddRange(namecolumn, productNumberColumn, colorColumn, listPriceColumn, sizeColumn, weightColumn, discontinuedColumn)

        Return template
    End Function

    Private Sub radGridView1_RowSourceNeeded(ByVal sender As Object, ByVal e As GridViewRowSourceNeededEventArgs)
        Dim rowView As DataRowView = TryCast(e.ParentRow.DataBoundItem, DataRowView)
        Dim rows() As DataRow = rowView.Row.GetChildRows("ProductModel_Product")

        For Each dataRow As DataRow In rows
            Dim row As GridViewRowInfo = e.Template.Rows.NewRow()
            row.Cells("Name").Value = dataRow("Name")
            row.Cells("ProductNumber").Value = dataRow("ProductNumber")
            row.Cells("Color").Value = dataRow("Color")
            row.Cells("ListPrice").Value = dataRow("ListPrice")
            row.Cells("Size").Value = dataRow("Size")
            row.Cells("Weight").Value = dataRow("Weight")
            row.Cells("DiscontinuedDate").Value = dataRow("DiscontinuedDate")

            e.SourceCollection.Add(row)
        Next dataRow
    End Sub
End Class
