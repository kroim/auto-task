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
        Me.lcAll = New Telerik.WinControls.UI.RadListControl
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler
        Me.lcAfter10 = New Telerik.WinControls.UI.RadListControl
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        CType(Me.lcAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAfter10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcAll
        '
        Me.lcAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcAll.Location = New System.Drawing.Point(467, 36)
        Me.lcAll.Name = "lbAll"
        Me.lcAll.Size = New System.Drawing.Size(194, 162)
        Me.lcAll.TabIndex = 0
        Me.lcAll.ThemeName = "ControlDefault"
        '
        'radScheduler1
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        Me.radScheduler1.AccessibleInterval = DateTimeInterval1
        Me.radScheduler1.AppointmentTitleFormat = Nothing
        Me.radScheduler1.BackColor = System.Drawing.Color.White
        Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.radScheduler1.DataSource = Nothing
        Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.radScheduler1.HeaderFormat = "MMMM dd"
        Me.radScheduler1.Location = New System.Drawing.Point(12, 12)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.radScheduler1.Size = New System.Drawing.Size(435, 518)
        Me.radScheduler1.TabIndex = 1
        Me.radScheduler1.Text = "radScheduler1"
        Me.radScheduler1.ThemeName = "ControlDefault"
        '
        'lcAfter10
        '
        Me.lcAfter10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcAfter10.Location = New System.Drawing.Point(467, 224)
        Me.lcAfter10.Name = "lbAfter10"
        Me.lcAfter10.Size = New System.Drawing.Size(194, 173)
        Me.lcAfter10.TabIndex = 2
        Me.lcAfter10.ThemeName = "ControlDefault"
        '
        'radLabel1
        '
        Me.radLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.radLabel1.Location = New System.Drawing.Point(468, 12)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(89, 16)
        Me.radLabel1.TabIndex = 3
        Me.radLabel1.Text = "All Occurences"
        Me.radLabel1.ThemeName = "ControlDefault"
        '
        'radLabel2
        '
        Me.radLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.radLabel2.Location = New System.Drawing.Point(468, 204)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(66, 16)
        Me.radLabel2.TabIndex = 4
        Me.radLabel2.Text = "After 10AM"
        Me.radLabel2.ThemeName = "ControlDefault"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 542)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.lcAfter10)
        Me.Controls.Add(Me.radScheduler1)
        Me.Controls.Add(Me.lcAll)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadScheduler"
        Me.ThemeName = "ControlDefault"
        CType(Me.lcAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAfter10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private lcAll As Telerik.WinControls.UI.RadListControl
    Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
    Private lcAfter10 As Telerik.WinControls.UI.RadListControl
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel

End Class
