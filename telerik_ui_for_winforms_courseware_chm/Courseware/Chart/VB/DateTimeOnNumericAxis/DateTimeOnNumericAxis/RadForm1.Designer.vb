Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
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
        Dim Corners1 As Telerik.Charting.Styles.Corners = New Telerik.Charting.Styles.Corners
        Dim ChartMargins1 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
        Dim ChartSeries1 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement1 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement2 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement3 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim ChartSeries2 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement4 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement5 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement6 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Me.radChart1 = New Telerik.WinControls.UI.RadChart
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radChart1
        '
        Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radChart1.AutoLayout = True
        Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.radChart1.ChartTitle.TextBlock.Text = "Time Line"
        Me.radChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
        Corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
        Corners1.RoundSize = 6
        Corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
        Corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
        Me.radChart1.Legend.Appearance.Corners = Corners1
        Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.radChart1.Legend.Appearance.Visible = False
        Me.radChart1.Legend.Visible = False
        Me.radChart1.Location = New System.Drawing.Point(3, 3)
        Me.radChart1.Name = "radChart1"
        Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.Appearance.Dimensions.Margins = ChartMargins1
        Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent
        Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Width = 0.0!
        Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.MinValue = 1
        Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.AxisLabel.Appearance.Visible = True
        Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.AxisLabel.Visible = True
        Me.radChart1.PlotArea.YAxis.MaxValue = 100
        Me.radChart1.PlotArea.YAxis.Step = 10
        ChartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(40, Byte), Integer))
        GradientElement1.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(119, Byte), Integer))
        GradientElement2.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(82, Byte), Integer))
        GradientElement2.Position = 0.5!
        GradientElement3.Color = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(44, Byte), Integer))
        GradientElement3.Position = 1.0!
        ChartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement1, GradientElement2, GradientElement3})
        ChartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(119, Byte), Integer))
        ChartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(56, Byte), Integer))
        ChartSeries1.Name = "Series 1"
        ChartSeries2.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(192, Byte), Integer))
        GradientElement4.Color = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        GradientElement5.Color = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(220, Byte), Integer))
        GradientElement5.Position = 0.5!
        GradientElement6.Color = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer))
        GradientElement6.Position = 1.0!
        ChartSeries2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement4, GradientElement5, GradientElement6})
        ChartSeries2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(56, Byte), Integer))
        ChartSeries2.Name = "Series 2"
        Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() {ChartSeries1, ChartSeries2})
        Me.radChart1.Size = New System.Drawing.Size(292, 279)
        Me.radChart1.Skin = "LightBlue"
        Me.radChart1.TabIndex = 0
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 285)
        Me.Controls.Add(Me.radChart1)
        Me.Name = "RadForm1"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "Chart"
        Me.ThemeName = "Office2007Silver"
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radChart1 As Telerik.WinControls.UI.RadChart
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme

End Class
