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
        Dim DateTimeInterval1 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radScheduler1
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        Me.radScheduler1.AccessibleInterval = DateTimeInterval1
        Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.MultiDay
        Me.radScheduler1.AppointmentTitleFormat = Nothing
        Me.radScheduler1.BackColor = System.Drawing.Color.White
        Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.radScheduler1.DataSource = Nothing
        Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.radScheduler1.HeaderFormat = "MMMM dd"
        Me.radScheduler1.Location = New System.Drawing.Point(15, 15)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.radScheduler1.Size = New System.Drawing.Size(514, 363)
        Me.radScheduler1.TabIndex = 2
        Me.radScheduler1.Text = "radScheduler1"
        Me.radScheduler1.ThemeName = "Desert"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 393)
        Me.Controls.Add(Me.radScheduler1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "RadForm1"
        Me.Padding = New System.Windows.Forms.Padding(15)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadScheduler"
        Me.ThemeName = "Desert"
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
End Class
