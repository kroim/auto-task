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
        Dim chartSeries1 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries()
        Dim chartSeries2 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries()
        Me.radChart1 = New Telerik.WinControls.UI.RadChart()
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radChart1
        ' 
        Me.radChart1.Location = New System.Drawing.Point(12, 12)
        Me.radChart1.Name = "radChart1"
        Me.radChart1.PlotArea.XAxis.MinValue = 1
        Me.radChart1.PlotArea.YAxis.MaxValue = 100
        Me.radChart1.PlotArea.YAxis.Step = 10
        chartSeries1.Name = "Series 1"
        chartSeries2.Name = "Series 2"
        Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() {chartSeries1, chartSeries2})
        Me.radChart1.Size = New System.Drawing.Size(400, 300)
        Me.radChart1.TabIndex = 0
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 322)
        Me.Controls.Add(Me.radChart1)
        Me.Name = "Form1"
        Me.Text = "RadChart"
        '	  Me.Load += New System.EventHandler(Me.Form1_Load);
        CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radChart1 As Telerik.WinControls.UI.RadChart

End Class
