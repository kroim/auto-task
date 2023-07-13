Imports Telerik.Charting.Styles

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Make a little room for the labels by removing the legend, 
        ' setting AutoLayout true to automatically use the extra space.
        ' Also make both axis labels visible and rotate the YAxis label 45 degrees
        radChart1.AutoLayout = True
        radChart1.Legend.Visible = False
        radChart1.PlotArea.YAxis.AxisLabel.Visible = True
        radChart1.PlotArea.YAxis.Appearance.LabelAppearance.RotationAngle = 45
        radChart1.PlotArea.XAxis.AxisLabel.Visible = True

        Dim today As DateTime = DateTime.Today

        ' Setup chart orientation 
        radChart1.SeriesOrientation = Telerik.Charting.ChartSeriesOrientation.Horizontal

        ' Setup XAxis 
        radChart1.PlotArea.XAxis.AutoScale = False
        radChart1.PlotArea.XAxis.Appearance.ValueFormat = ChartValueFormat.ShortDate
        radChart1.PlotArea.XAxis.AddRange(today.ToOADate(), today.AddDays(10).ToOADate(), 1)

        ' Setup YAxis 
        radChart1.PlotArea.YAxis.AutoScale = False
        radChart1.PlotArea.YAxis.Appearance.ValueFormat = ChartValueFormat.ShortTime
        radChart1.PlotArea.YAxis.AddRange(today.AddHours(7).ToOADate(), today.AddHours(18).ToOADate(), 1.0R / 24.0R)

        ' Setup Series 
        radChart1.Series(0).Type = Telerik.Charting.ChartSeriesType.Gantt
        radChart1.Series(0).DataXColumn = "X"
        radChart1.Series(0).DataXColumn2 = "X2"
        radChart1.Series(0).DataYColumn = "Y"
        radChart1.Series(0).DataYColumn2 = "Y2"

        ' Data Bind 
        radChart1.Series(0).Appearance.LabelAppearance.Visible = False
        radChart1.DataSource = GetDataTable()
        radChart1.DataBind()
    End Sub

    ' generate a four column table with sample
    ' date and time data stored as doubles
    Private Function GetDataTable() As DataTable
        Dim input As Double(,) = New Double(2, 1) {{8, 12}, {9, 14}, {13, 18.5}}

        Dim table As DataTable = New DataTable()
        table.Columns.Add("X", GetType(Double))
        table.Columns.Add("X2", GetType(Double))
        table.Columns.Add("Y", GetType(Double))
        table.Columns.Add("Y2", GetType(Double))

        Dim start As DateTime = DateTime.Today

        For i As Integer = 0 To 2
            Dim row As DataRow = table.NewRow()

            ' convert all dates and times to OLE Automation dates
            ' which are stored as doubles
            row("X") = start.AddDays(i).ToOADate()
            row("X2") = start.AddDays(i + 1).ToOADate()
            row("Y") = start.AddHours(input(i, 0)).ToOADate()
            row("Y2") = start.AddHours(input(i, 1)).ToOADate()

            table.Rows.Add(row)
        Next i

        Return table
    End Function
End Class
