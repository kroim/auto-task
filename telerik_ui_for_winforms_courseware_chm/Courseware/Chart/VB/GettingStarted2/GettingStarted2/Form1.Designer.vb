Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GradientElement1 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement2 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement3 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim ChartMargins1 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
        Dim ChartMargins2 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
        Dim ChartMargins3 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
        Dim ChartPaddings1 As Telerik.Charting.Styles.ChartPaddings = New Telerik.Charting.Styles.ChartPaddings
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartAxisItem1 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartAxisItem2 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartAxisItem3 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartAxisItem4 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartAxisItem5 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartAxisItem6 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartAxisItem7 As Telerik.Charting.ChartAxisItem = New Telerik.Charting.ChartAxisItem
        Dim ChartSeries1 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement4 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement5 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement6 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Me.radChart1 = New Telerik.WinControls.UI.RadChart
        Me.salesByCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nwindDataSet1 = New GettingStarted2.NwindDataSet
        Me.sales_by_CategoryTableAdapter = New GettingStarted2.NwindDataSetTableAdapters.Sales_by_CategoryTableAdapter
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salesByCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radChart1
        '
        Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.radChart1.Appearance.Border.Width = 5.0!
        GradientElement1.Color = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(0, Byte), Integer))
        GradientElement2.Color = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(36, Byte), Integer))
        GradientElement2.Position = 0.5!
        GradientElement3.Color = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(0, Byte), Integer))
        GradientElement3.Position = 1.0!
        Me.radChart1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement1, GradientElement2, GradientElement3})
        Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        Me.radChart1.AutoLayout = True
        Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = ChartMargins1
        Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.radChart1.ChartTitle.TextBlock.Text = "Sales By Category"
        Me.radChart1.DataSource = Me.salesByCategoryBindingSource
        Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.Legend.Appearance.Dimensions.Margins = ChartMargins2
        Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.Legend.Appearance.Visible = False
        Me.radChart1.Legend.TextBlock.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
        Me.radChart1.Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.radChart1.Legend.Visible = False
        Me.radChart1.Location = New System.Drawing.Point(13, 13)
        Me.radChart1.Name = "radChart1"
        Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.Appearance.Dimensions.Margins = ChartMargins3
        Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent
        Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0.0!
        Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.PlotArea.XAxis.AutoScale = False
        ChartPaddings1.Bottom = CType(resources.GetObject("ChartPaddings1.Bottom"), Telerik.Charting.Styles.Unit)
        Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Dimensions.Paddings = ChartPaddings1
        Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.RotationAngle = 270.0!
        Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.DataLabelsColumn = "CategoryName"
        ChartAxisItem1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ChartAxisItem2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ChartAxisItem3.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ChartAxisItem4.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ChartAxisItem5.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ChartAxisItem6.Value = New Decimal(New Integer() {6, 0, 0, 0})
        ChartAxisItem7.Value = New Decimal(New Integer() {7, 0, 0, 0})
        Me.radChart1.PlotArea.XAxis.Items.AddRange(New Telerik.Charting.ChartAxisItem() {ChartAxisItem1, ChartAxisItem2, ChartAxisItem3, ChartAxisItem4, ChartAxisItem5, ChartAxisItem6, ChartAxisItem7})
        Me.radChart1.PlotArea.XAxis.MinValue = 1
        Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.RotationAngle = 40.0!
        Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Width = 0.0!
        Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.PlotArea.YAxis.AxisLabel.Appearance.RotationAngle = 0.0!
        Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.MaxValue = 90
        Me.radChart1.PlotArea.YAxis.Step = 10
        Me.radChart1.PlotArea.YAxis2.AxisLabel.Appearance.RotationAngle = 0.0!
        GradientElement4.Color = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        GradientElement5.Color = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer))
        GradientElement5.Position = 0.5!
        GradientElement6.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        GradientElement6.Position = 1.0!
        ChartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement4, GradientElement5, GradientElement6})
        ChartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        ChartSeries1.DataYColumn = "ProductSales"
        ChartSeries1.Name = "ProductSales"
        Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() {ChartSeries1})
        Me.radChart1.SeriesOrientation = Telerik.Charting.ChartSeriesOrientation.Horizontal
        Me.radChart1.Size = New System.Drawing.Size(400, 300)
        Me.radChart1.Skin = "DeepGreen"
        Me.radChart1.TabIndex = 0
        '
        'salesByCategoryBindingSource
        '
        Me.salesByCategoryBindingSource.DataMember = "Sales by Category"
        Me.salesByCategoryBindingSource.DataSource = Me.nwindDataSet1
        '
        'nwindDataSet1
        '
        Me.nwindDataSet1.DataSetName = "NwindDataSet1"
        Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sales_by_CategoryTableAdapter
        '
        Me.sales_by_CategoryTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 329)
        Me.Controls.Add(Me.radChart1)
        Me.Name = "Form1"
        Me.Text = "RadChart"
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salesByCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radChart1 As Telerik.WinControls.UI.RadChart
    Private nwindDataSet1 As NwindDataSet
    Private salesByCategoryBindingSource As System.Windows.Forms.BindingSource
    Private sales_by_CategoryTableAdapter As GettingStarted2.NwindDataSetTableAdapters.Sales_by_CategoryTableAdapter

End Class
