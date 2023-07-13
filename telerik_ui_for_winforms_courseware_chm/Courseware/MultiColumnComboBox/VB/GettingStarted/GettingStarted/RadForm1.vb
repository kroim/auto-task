Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)

        ' get a reference to the combo box element
        Dim combo As RadMultiColumnComboBoxElement = radMultiColumnComboBox1.MultiColumnComboBoxElement

        ' hide the ID column
        combo.Columns("ID").IsVisible = False

        ' size all the columns except "Photo"
        For Each column As GridViewDataColumn In combo.Columns
            If (Not column.Name.Equals("Photo")) Then
                column.BestFit()
            End If
        Next column

        'set the image layout in the "Photo" column
        DirectCast(combo.EditorControl.Columns("Photo"), GridViewImageColumn).ImageLayout = ImageLayout.Stretch

        ' set initial drop down width
        combo.DropDownWidth = 265
        combo.DropDownHeight = 315
    End Sub
End Class
