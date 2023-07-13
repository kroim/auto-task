Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Populate the generic list of Sales
        Dim sales As List(Of Sales) = New List(Of Sales)()
        sales.Add(New Sales(2011, 1, 5))
        sales.Add(New Sales(2011, 2, 2))
        sales.Add(New Sales(2011, 3, 3))
        sales.Add(New Sales(2011, 4, 1))
        sales.Add(New Sales(2012, 1, 4))
        sales.Add(New Sales(2012, 2, 3))
        sales.Add(New Sales(2012, 3, 8))
        sales.Add(New Sales(2012, 4, 2))

        ' Setup the chart appearance and title
        radChart1.Skin = "DeepBlue"
        radChart1.ChartTitle.TextBlock.Text = "Sales Grouped by Quarter"

        ' Remove the default series
        radChart1.Series.Clear()
        ' Create and add a new Bar series type
        Dim chartSeries As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries("Sales", Telerik.Charting.ChartSeriesType.Bar)
        radChart1.Series.Add(chartSeries)

        ' Set the grouping properties
        radChart1.DataGroupColumn = "Year"
        radChart1.Legend.Appearance.GroupNameFormat = "#NAME: #VALUE"

        ' bind the chart last to include the preceding property
        ' settings.
        radChart1.DataSource = sales
        'radChart1.DataBind();
    End Sub

    Public Class Sales
        Dim year As Integer
        Dim quarter As Integer
        Dim value As Integer

        Public Sub New(ByVal year As Integer, ByVal quarter As Integer, ByVal value As Double)
            Me.year = year
            Me.quarter = quarter
            Me.value = value
        End Sub

        Public Property YearProp() As Integer
            Get
                Return year
            End Get
            Set(ByVal value As Integer)
                year = value
            End Set
        End Property

        Public Property QuarterProp() As Integer
            Get
                Return quarter
            End Get
            Set(ByVal value As Integer)
                quarter = value
            End Set
        End Property

        Public Property ValueProp() As Integer
            Get
                Return value
            End Get
            Set(ByVal value As Integer)
                value = value
            End Set
        End Property

    End Class
End Class

