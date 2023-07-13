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
        Dim ChartSeries1 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement4 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement5 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement6 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim ChartSeries2 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement7 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement8 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement9 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Me.radChart1 = New Telerik.WinControls.UI.RadChart
        Me.revenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chartDataSet = New DrillDown.ChartDataSet
        Me.revenueTableAdapter = New DrillDown.ChartDataSetTableAdapters.RevenueTableAdapter
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.revenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radChart1
        '
        Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.radChart1.Appearance.Border.Width = 5.0!
        GradientElement1.Color = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(179, Byte), Integer))
        GradientElement2.Color = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(254, Byte), Integer))
        GradientElement2.Position = 0.5!
        GradientElement3.Color = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(179, Byte), Integer))
        GradientElement3.Position = 1.0!
        Me.radChart1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement1, GradientElement2, GradientElement3})
        Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        Me.radChart1.AutoLayout = True
        Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = ChartMargins1
        Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.radChart1.ChartTitle.TextBlock.Text = "Drill Down"
        Me.radChart1.DataSource = Me.revenueBindingSource
        Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.Legend.Appearance.Dimensions.Margins = ChartMargins2
        Me.radChart1.Legend.Appearance.FillStyle.GammaCorrection = False
        Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.Legend.Appearance.Visible = False
        Me.radChart1.Legend.TextBlock.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
        Me.radChart1.Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.LightSkyBlue
        Me.radChart1.Legend.Visible = False
        Me.radChart1.Location = New System.Drawing.Point(12, 12)
        Me.radChart1.Name = "radChart1"
        Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.radChart1.PlotArea.Appearance.Dimensions.Margins = ChartMargins3
        Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent
        Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0.0!
        Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        ChartPaddings1.Bottom = CType(resources.GetObject("ChartPaddings1.Bottom"), Telerik.Charting.Styles.Unit)
        Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Dimensions.Paddings = ChartPaddings1
        Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.LightSkyBlue
        Me.radChart1.PlotArea.XAxis.MinValue = 1
        Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Width = 0.0!
        Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.LightSkyBlue
        Me.radChart1.PlotArea.YAxis.MaxValue = 100
        Me.radChart1.PlotArea.YAxis.Step = 10
        GradientElement4.Color = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        GradientElement5.Color = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer))
        GradientElement5.Position = 0.5!
        GradientElement6.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        GradientElement6.Position = 1.0!
        ChartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement4, GradientElement5, GradientElement6})
        ChartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
        ChartSeries1.Name = "Series 1"
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
        Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() {ChartSeries1, ChartSeries2})
        Me.radChart1.Size = New System.Drawing.Size(400, 300)
        Me.radChart1.Skin = "DeepBlue"
        Me.radChart1.TabIndex = 0
        '
        'revenueBindingSource
        '
        Me.revenueBindingSource.DataMember = "Revenue"
        Me.revenueBindingSource.DataSource = Me.chartDataSet
        '
        'chartDataSet
        '
        Me.chartDataSet.DataSetName = "ChartDataSet"
        Me.chartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'revenueTableAdapter
        '
        Me.revenueTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 321)
        Me.Controls.Add(Me.radChart1)
        Me.Name = "Form1"
        Me.Text = "RadChart"
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.revenueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents radChart1 As Telerik.WinControls.UI.RadChart
    Private chartDataSet As ChartDataSet
    Private revenueBindingSource As System.Windows.Forms.BindingSource
    Private revenueTableAdapter As DrillDown.ChartDataSetTableAdapters.RevenueTableAdapter

End Class
