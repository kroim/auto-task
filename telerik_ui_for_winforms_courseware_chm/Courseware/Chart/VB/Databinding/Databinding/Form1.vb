Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'furnitureDataSet.Products' table. You can move, or remove it, as needed.
        Me.productsTableAdapter1.Fill(Me.furnitureDataSet1.Products)
        radChart2.Series(0).Appearance.ShowLabelConnectors = True
        radChart2.SeriesOrientation = Telerik.Charting.ChartSeriesOrientation.Vertical
        radChart2.IntelligentLabelsEnabled = True
        radChart2.Series(0).DataXColumn = "ExtendedPrice"
        radChart2.Series(0).DataYColumn = "TotalQuantity"
        radChart2.PlotArea.YAxis.AxisLabel.TextBlock.Text = "Quantity"
        radChart2.PlotArea.YAxis.AxisLabel.Visible = True
        radChart2.PlotArea.XAxis.AxisLabel.TextBlock.Text = "Extended Price"
        radChart2.PlotArea.XAxis.AxisLabel.Visible = True
    End Sub

    Private Sub radChart1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Charting.ChartItemDataBoundEventArgs) Handles radChart2.ItemDataBound
        Dim qty As Integer = Convert.ToInt32((TryCast(e.DataItem, DataRowView))("TotalQuantity"))
        Dim quantityLabel As String = String.Empty
        Select Case qty
            Case 1, 2
                quantityLabel = "Few"
            Case 3
                quantityLabel = "Some"
            Case 4, 5
                quantityLabel = "Lots!"
        End Select

        Dim price As Double = Convert.ToDouble((TryCast(e.DataItem, DataRowView))("ExtendedPrice"))
        Dim priceLabel As String = String.Empty
        If price < 2000 Then
            priceLabel = "cheap"
        ElseIf price < 10000 Then
            priceLabel = "reasonable"
        Else
            priceLabel = "expensive"
        End If

        e.SeriesItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Ariel", 12, System.Drawing.FontStyle.Bold)
        e.SeriesItem.Label.TextBlock.Text = quantityLabel & ", " & priceLabel
    End Sub
End Class
