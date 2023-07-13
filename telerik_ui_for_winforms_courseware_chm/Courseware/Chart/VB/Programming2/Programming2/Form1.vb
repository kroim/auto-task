Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Configure the Legend and Chart Title labeling
        radChart1.Legend.Appearance.Position.Auto = False
        radChart1.Legend.Appearance.Position.X = 220
        radChart1.Legend.Appearance.Position.Y = 50
        radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.TopLeft
        radChart1.ChartTitle.TextBlock.Text = "Weekly Forecast"

        ' Configure the PlotArea
        radChart1.PlotArea.Appearance.Dimensions.Margins.Right = Telerik.Charting.Styles.Unit.Percentage(10)
        radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
        radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.LightSkyBlue

        ' Configure the XAxis
        radChart1.PlotArea.XAxis.AutoScale = False
        radChart1.PlotArea.XAxis.AddRange(1, 7, 1)
        radChart1.PlotArea.XAxis(0).TextBlock.Text = "Mon"
        radChart1.PlotArea.XAxis(1).TextBlock.Text = "Tue"
        radChart1.PlotArea.XAxis(2).TextBlock.Text = "Wed"
        radChart1.PlotArea.XAxis(3).TextBlock.Text = "Thu"
        radChart1.PlotArea.XAxis(4).TextBlock.Text = "Fri"
        radChart1.PlotArea.XAxis(5).TextBlock.Text = "Sat"
        radChart1.PlotArea.XAxis(6).TextBlock.Text = "Sun"

        ' Configure the YAxis
        radChart1.PlotArea.YAxis.AxisMode = Telerik.Charting.ChartYAxisMode.Extended
        radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Text = "Temperature C"

        ' Create the series and assign the ChartSeriesType
        radChart1.Series.Clear()
        Dim chartSeries As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries("Average Temperatures", Telerik.Charting.ChartSeriesType.Bar)
        chartSeries.Appearance.FillStyle.MainColor = System.Drawing.Color.Honeydew
        chartSeries.Appearance.FillStyle.SecondColor = System.Drawing.Color.Green

        ' Define the items in the series
        chartSeries.AddItem(5)
        chartSeries.AddItem(1)
        chartSeries.AddItem(-1)
        chartSeries.AddItem(-5)
        chartSeries.AddItem(-7)
        chartSeries.AddItem(-3)
        chartSeries.AddItem(-1)

        radChart1.Series.Add(chartSeries)

        ' Create a second series and assign the ChartSeriesType
        Dim chartSeries2 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries("Maximum Temperatures", Telerik.Charting.ChartSeriesType.Line)
        chartSeries2.Appearance.LabelAppearance.Visible = False
        chartSeries2.Appearance.LineSeriesAppearance.Color = System.Drawing.Color.Red

        ' Define the items in the series
        chartSeries2.AddItem(11)
        chartSeries2.AddItem(4)
        chartSeries2.AddItem(0)
        chartSeries2.AddItem(-4)
        chartSeries2.AddItem(-7)
        chartSeries2.AddItem(0)
        chartSeries2.AddItem(5)

        radChart1.Series.Add(chartSeries2)

        ' visually enhance the data points
        chartSeries2.Appearance.PointMark.Dimensions.Width = 5
        chartSeries2.Appearance.PointMark.Dimensions.Height = 5
        chartSeries2.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.Black
        chartSeries2.Appearance.PointMark.Visible = True

        ' Create a third series and assign the ChartSeriesType
        Dim chartSeries3 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries("Minimum Temperatures", Telerik.Charting.ChartSeriesType.Bubble)
        chartSeries3.Appearance.LabelAppearance.Visible = False
        chartSeries3.Appearance.FillStyle.MainColor = System.Drawing.Color.Blue
        chartSeries3.Appearance.FillStyle.SecondColor = System.Drawing.Color.Aqua

        ' Define the items in the series
        chartSeries3.AddItem(1)
        chartSeries3.AddItem(0)
        chartSeries3.AddItem(-5)
        chartSeries3.AddItem(-7)
        chartSeries3.AddItem(-11)
        chartSeries3.AddItem(-8)
        chartSeries3.AddItem(-6)

        radChart1.Series.Add(chartSeries3)

        ' visually enhance the data points
        chartSeries3.Appearance.PointMark.Dimensions.Width = 5
        chartSeries3.Appearance.PointMark.Dimensions.Height = 5
        chartSeries3.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.Black
        chartSeries3.Appearance.PointMark.Visible = True
    End Sub
End Class
