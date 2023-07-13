<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim ChartSeries1 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement4 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement5 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement6 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim ChartSeries2 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement7 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement8 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement9 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Me.radChart2 = New Telerik.WinControls.UI.RadChart
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.furnitureDataSet1 = New Databinding.FurnitureDataSet
        Me.productsTableAdapter1 = New Databinding.FurnitureDataSetTableAdapters.ProductsTableAdapter
        CType(Me.radChart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.furnitureDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radChart2
        '
        Me.radChart2.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.radChart2.Appearance.Border.Width = 5.0!
        GradientElement1.Color = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        GradientElement2.Color = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        GradientElement2.Position = 0.5!
        GradientElement3.Color = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        GradientElement3.Position = 1.0!
        Me.radChart2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement1, GradientElement2, GradientElement3})
        Me.radChart2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        Me.radChart2.AutoLayout = True
        Me.radChart2.ChartTitle.Appearance.Dimensions.Margins = ChartMargins1
        Me.radChart2.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
        Me.radChart2.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart2.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.radChart2.DataSource = Me.bindingSource1
        Me.radChart2.DefaultType = Telerik.Charting.ChartSeriesType.Point
        Me.radChart2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radChart2.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.Legend.Appearance.Dimensions.Margins = ChartMargins2
        Me.radChart2.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart2.Legend.Appearance.Visible = False
        Me.radChart2.Legend.TextBlock.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
        Me.radChart2.Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.radChart2.Legend.Visible = False
        Me.radChart2.Location = New System.Drawing.Point(0, 0)
        Me.radChart2.Name = "radChart2"
        Me.radChart2.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.Appearance.Dimensions.Margins = ChartMargins3
        Me.radChart2.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent
        Me.radChart2.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0.0!
        Me.radChart2.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        ChartPaddings1.Bottom = CType(resources.GetObject("ChartPaddings1.Bottom"), Telerik.Charting.Styles.Unit)
        Me.radChart2.PlotArea.XAxis.AxisLabel.Appearance.Dimensions.Paddings = ChartPaddings1
        Me.radChart2.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.radChart2.PlotArea.XAxis.MinValue = 1
        Me.radChart2.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.Width = 0.0!
        Me.radChart2.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart2.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart2.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.radChart2.PlotArea.YAxis.MaxValue = 100
        Me.radChart2.PlotArea.YAxis.Step = 10
        GradientElement4.Color = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        GradientElement5.Color = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer))
        GradientElement5.Position = 0.5!
        GradientElement6.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        GradientElement6.Position = 1.0!
        ChartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement4, GradientElement5, GradientElement6})
        ChartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        ChartSeries1.DataXColumn = "ExtendedPrice"
        ChartSeries1.Name = "Series 1"
        ChartSeries1.Type = Telerik.Charting.ChartSeriesType.Point
        ChartSeries2.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        GradientElement7.Color = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(78, Byte), Integer))
        GradientElement8.Color = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(27, Byte), Integer))
        GradientElement8.Position = 0.5!
        GradientElement9.Color = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(3, Byte), Integer))
        GradientElement9.Position = 1.0!
        ChartSeries2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement7, GradientElement8, GradientElement9})
        ChartSeries2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        ChartSeries2.Name = "Series 2"
        ChartSeries2.Type = Telerik.Charting.ChartSeriesType.Point
        Me.radChart2.Series.AddRange(New Telerik.Charting.ChartSeries() {ChartSeries1, ChartSeries2})
        Me.radChart2.Size = New System.Drawing.Size(524, 426)
        Me.radChart2.Skin = "DeepGray"
        Me.radChart2.TabIndex = 0
        '
        'bindingSource1
        '
        Me.bindingSource1.DataMember = "Products"
        Me.bindingSource1.DataSource = Me.furnitureDataSet1
        '
        'furnitureDataSet1
        '
        Me.furnitureDataSet1.DataSetName = "FurnitureDataSet"
        Me.furnitureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'productsTableAdapter1
        '
        Me.productsTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(524, 426)
        Me.Controls.Add(Me.radChart2)
        Me.Name = "Form1"
        CType(Me.radChart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.furnitureDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents radChart2 As Telerik.WinControls.UI.RadChart
    Private furnitureDataSet1 As FurnitureDataSet
    Private bindingSource1 As System.Windows.Forms.BindingSource
    Private productsTableAdapter1 As Databinding.FurnitureDataSetTableAdapters.ProductsTableAdapter

End Class
