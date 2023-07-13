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
        Dim Corners3 As Telerik.Charting.Styles.Corners = New Telerik.Charting.Styles.Corners
        Dim ChartMargins3 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
        Dim Corners4 As Telerik.Charting.Styles.Corners = New Telerik.Charting.Styles.Corners
        Dim ChartMargins4 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
        Dim ChartSeries2 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
        Dim GradientElement4 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement5 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim GradientElement6 As Telerik.Charting.GradientElement = New Telerik.Charting.GradientElement
        Dim ChartSeriesItem5 As Telerik.Charting.ChartSeriesItem = New Telerik.Charting.ChartSeriesItem
        Dim ChartSeriesItem6 As Telerik.Charting.ChartSeriesItem = New Telerik.Charting.ChartSeriesItem
        Dim ChartSeriesItem7 As Telerik.Charting.ChartSeriesItem = New Telerik.Charting.ChartSeriesItem
        Dim ChartSeriesItem8 As Telerik.Charting.ChartSeriesItem = New Telerik.Charting.ChartSeriesItem
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        Me.radChart1 = New Telerik.WinControls.UI.RadChart
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radChart1
        '
        Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(174, Byte), Integer))
        Corners3.BottomLeft = Telerik.Charting.Styles.CornerType.Round
        Corners3.BottomRight = Telerik.Charting.Styles.CornerType.Round
        Corners3.RoundSize = 8
        Corners3.TopLeft = Telerik.Charting.Styles.CornerType.Round
        Corners3.TopRight = Telerik.Charting.Styles.CornerType.Round
        Me.radChart1.Appearance.Corners = Corners3
        Me.radChart1.Appearance.FillStyle.FillSettings.BackgroundImage = "{chart}"
        Me.radChart1.Appearance.FillStyle.FillSettings.ImageDrawMode = Telerik.Charting.Styles.ImageDrawMode.Flip
        Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Image
        Me.radChart1.AutoLayout = True
        Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Georgia", 24.0!)
        Me.radChart1.ChartTitle.TextBlock.Text = "Category Sales"
        Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.Transparent
        Me.radChart1.Legend.Appearance.Dimensions.Margins = ChartMargins3
        Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent
        Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.radChart1.Legend.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.TopRight
        Me.radChart1.Location = New System.Drawing.Point(12, 12)
        Me.radChart1.Name = "radChart1"
        Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(167, Byte), Integer))
        Corners4.BottomLeft = Telerik.Charting.Styles.CornerType.Round
        Corners4.BottomRight = Telerik.Charting.Styles.CornerType.Round
        Corners4.RoundSize = 7
        Corners4.TopLeft = Telerik.Charting.Styles.CornerType.Round
        Corners4.TopRight = Telerik.Charting.Styles.CornerType.Round
        Me.radChart1.PlotArea.Appearance.Corners = Corners4
        Me.radChart1.PlotArea.Appearance.Dimensions.Margins = ChartMargins4
        Me.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid
        Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.Transparent
        Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.radChart1.PlotArea.XAxis.MaxValue = 4
        Me.radChart1.PlotArea.XAxis.MinValue = 1
        Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.Transparent
        Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.radChart1.PlotArea.YAxis.MaxValue = 12000
        Me.radChart1.PlotArea.YAxis.Step = 1000
        ChartSeries2.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(58, Byte), Integer))
        GradientElement4.Color = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(152, Byte), Integer))
        GradientElement5.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(123, Byte), Integer))
        GradientElement5.Position = 0.5!
        GradientElement6.Color = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(84, Byte), Integer))
        GradientElement6.Position = 1.0!
        ChartSeries2.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() {GradientElement4, GradientElement5, GradientElement6})
        ChartSeries2.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
        ChartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(155, Byte), Integer))
        ChartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        ChartSeries2.DefaultLabelValue = "#ITEM"
        ChartSeriesItem5.Name = "Beverages"
        ChartSeriesItem5.YValue = 10000
        ChartSeriesItem6.Name = "Produce"
        ChartSeriesItem6.YValue = 7500
        ChartSeriesItem7.Name = "Poultry"
        ChartSeriesItem7.YValue = 9000
        ChartSeriesItem8.Name = "Grains"
        ChartSeriesItem8.YValue = 11200
        ChartSeries2.Items.AddRange(New Telerik.Charting.ChartSeriesItem() {ChartSeriesItem5, ChartSeriesItem6, ChartSeriesItem7, ChartSeriesItem8})
        ChartSeries2.Name = "Sales"
        Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() {ChartSeries2})
        Me.radChart1.Size = New System.Drawing.Size(500, 400)
        Me.radChart1.Skin = "Wood"
        Me.radChart1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 431)
        Me.Controls.Add(Me.radChart1)
        Me.Name = "Form1"
        Me.Text = "RadChart"
        Me.ThemeName = "Desert"
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radChart1 As Telerik.WinControls.UI.RadChart
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
End Class
