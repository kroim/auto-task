Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radChart1.AutoLayout = True

        ' Create the series and assign the ChartSeriesType
        radChart1.Series.Clear()
        Dim chartSeries As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries("Average Temperatures", Telerik.Charting.ChartSeriesType.Bar)

        ' Define the items in the series
        chartSeries.AddItem(5)
        chartSeries.AddItem(1)
        chartSeries.AddItem(-1)
        chartSeries.AddItem(-5)
        chartSeries.AddItem(-7)

        ' add an empty item
        Dim isEmpty As Boolean = True
        Dim item As Telerik.Charting.ChartSeriesItem = New Telerik.Charting.ChartSeriesItem(isEmpty)
        chartSeries.AddItem(item)

        chartSeries.AddItem(-3)

        ' Add the series to the chart, chart to page.
        radChart1.Series.Add(chartSeries)
    End Sub
End Class
