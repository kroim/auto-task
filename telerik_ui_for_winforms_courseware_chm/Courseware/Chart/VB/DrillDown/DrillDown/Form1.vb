Imports Telerik.Charting

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.revenueTableAdapter.FillByYear(Me.chartDataSet.Revenue)

        ' remove the second, unused series
        radChart1.Series.RemoveAt(1)

        radChart1.ChartTitle.TextBlock.Text = "Years"

        radChart1.PlotArea.XAxis.IsZeroBased = False
        radChart1.PlotArea.XAxis.AutoScale = False
        radChart1.PlotArea.XAxis.MinValue = 2003
        radChart1.PlotArea.XAxis.MaxValue = 2005
        'attach the datasource to the chart            
        radChart1.DataManager.DataSource = Me.chartDataSet.Revenue
        radChart1.Series(0).DataYColumn = "Revenue"
        radChart1.Series(0).DataXColumn = "Year"
        radChart1.Series(0).Name = "Years"
    End Sub

    'stores the currently selected year        
    Private _year As Integer

    Private Sub radChart1_Click(ByVal sender As Object, ByVal args As Telerik.Charting.ChartClickEventArgs) Handles radChart1.Click
        If TypeOf args.Element.ActiveRegion.Parent Is ChartSeriesItem AndAlso (TryCast(args.Element.ActiveRegion.Parent, ChartSeriesItem)).Parent.Name = "Years" Then
            radChart1.ChartTitle.TextBlock.Text = "Quarters"
            'a bar representing the revenue for a year was clicked                
            _year = (TryCast(args.Element, ChartSeriesItem)).Index + 2003
            'fill revenue values for the year whose bar was clicked                
            revenueTableAdapter.FillByQuarter(Me.chartDataSet.Revenue, _year)
            'setup chart properties with appopriate axis labels                
            radChart1.PlotArea.XAxis.DataLabelsColumn = "Quarter"
            radChart1.Series(0).Clear()
            radChart1.Series(0).DataYColumn = "Revenue"
            radChart1.Series(0).Name = "Quarters"
            radChart1.DataBind()
        ElseIf TypeOf args.Element Is ChartSeriesItem AndAlso (TryCast(args.Element, ChartSeriesItem)).Parent.Name = "Quarters" Then
            radChart1.ChartTitle.TextBlock.Text = "Months"
            'a bar representing the revenue for a year was clicked                
            Dim quarter As Integer = (TryCast(args.Element, ChartSeriesItem)).Index + 1
            'fill revenue values for the year whose bar was clicked                
            revenueTableAdapter.FillByMonth(Me.chartDataSet.Revenue, _year, quarter)
            'setup chart properties with appopriate axis labels                
            radChart1.PlotArea.XAxis.DataLabelsColumn = "Month"
            radChart1.Series(0).Clear()
            radChart1.Series(0).DataYColumn = "Revenue"
            radChart1.Series(0).Name = "Months"
            radChart1.DataBind()
            'Detach Click event handler for the innermost chart 
            'Telerik.WinControls.UI.RadChart.ChartClickEventHandler       
            RemoveHandler radChart1.Click, AddressOf radChart1_Click
        End If
    End Sub
End Class
