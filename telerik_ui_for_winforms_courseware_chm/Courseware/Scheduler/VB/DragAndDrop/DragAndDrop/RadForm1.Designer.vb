<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.radPanel1 = New Telerik.WinControls.UI.RadPanel
        Me.lcClasses = New Telerik.WinControls.UI.RadListControl
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPanel1.SuspendLayout()
        CType(Me.lcClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPanel1
        '
        Me.radPanel1.BackColor = System.Drawing.Color.Transparent
        Me.radPanel1.Controls.Add(Me.lcClasses)
        Me.radPanel1.Controls.Add(Me.radLabel1)
        Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.radPanel1.Location = New System.Drawing.Point(384, 10)
        Me.radPanel1.Name = "radPanel1"
        Me.radPanel1.Padding = New System.Windows.Forms.Padding(3)
        '
        '
        '
        Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(3)
        Me.radPanel1.Size = New System.Drawing.Size(214, 342)
        Me.radPanel1.TabIndex = 1
        Me.radPanel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.radPanel1.ThemeName = "ControlDefault"
        CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(3)
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.[Auto]
        '
        'lcClasses
        '
        Me.lcClasses.CaseSensitiveSort = True
        Me.lcClasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcClasses.ItemHeight = 18
        Me.lcClasses.Location = New System.Drawing.Point(3, 19)
        Me.lcClasses.Name = "lcClasses"
        Me.lcClasses.Size = New System.Drawing.Size(208, 320)
        Me.lcClasses.TabIndex = 1
        '
        'radLabel1
        '
        Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.radLabel1.Location = New System.Drawing.Point(3, 3)
        Me.radLabel1.Name = "radLabel1"
        '
        '
        '
        Me.radLabel1.RootElement.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.radLabel1.Size = New System.Drawing.Size(102, 16)
        Me.radLabel1.TabIndex = 0
        Me.radLabel1.Text = "Aavailable Classes"
        '
        'radScheduler1
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        Me.radScheduler1.AccessibleInterval = DateTimeInterval1
        Me.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month
        Me.radScheduler1.AllowDrop = True
        Me.radScheduler1.AppointmentTitleFormat = Nothing
        Me.radScheduler1.BackColor = System.Drawing.Color.White
        Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.radScheduler1.DataSource = Nothing
        Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.radScheduler1.HeaderFormat = "MMMM dd"
        Me.radScheduler1.Location = New System.Drawing.Point(10, 10)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.radScheduler1.Size = New System.Drawing.Size(374, 342)
        Me.radScheduler1.TabIndex = 2
        Me.radScheduler1.Text = "radScheduler1"
        Me.radScheduler1.ThemeName = "ControlDefault"
        CType(Me.radScheduler1.GetChildAt(0), Telerik.WinControls.UI.RadSchedulerElement).Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 362)
        Me.Controls.Add(Me.radScheduler1)
        Me.Controls.Add(Me.radPanel1)
        Me.Name = "RadForm1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadScheduler"
        Me.ThemeName = "ControlDefault"
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPanel1.ResumeLayout(False)
        Me.radPanel1.PerformLayout()
        CType(Me.lcClasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radPanel1 As Telerik.WinControls.UI.RadPanel
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
    Private WithEvents lcClasses As Telerik.WinControls.UI.RadListControl
End Class
