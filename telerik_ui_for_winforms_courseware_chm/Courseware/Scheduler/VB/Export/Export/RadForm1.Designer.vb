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
        Dim DateTimeInterval2 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnExport = New Telerik.WinControls.UI.CommandBarButton
        Me.btnImport = New Telerik.WinControls.UI.CommandBarButton
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(5, 248)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(288, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 2
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.radStatusStrip1.SetSpring(Me.lblStatus, False)
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radScheduler1
        '
        DateTimeInterval2.End = New Date(CType(0, Long))
        DateTimeInterval2.Start = New Date(CType(0, Long))
        Me.radScheduler1.AccessibleInterval = DateTimeInterval2
        Me.radScheduler1.AppointmentTitleFormat = Nothing
        Me.radScheduler1.BackColor = System.Drawing.Color.White
        Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.radScheduler1.DataSource = Nothing
        Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.radScheduler1.HeaderFormat = "dd dddd"
        Me.radScheduler1.Location = New System.Drawing.Point(5, 60)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.Size = New System.Drawing.Size(288, 188)
        Me.radScheduler1.TabIndex = 3
        Me.radScheduler1.Text = "radScheduler1"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(5, 5)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(288, 55)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnExport, Me.btnImport})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnExport
        '
        Me.btnExport.AccessibleDescription = "Export"
        Me.btnExport.AccessibleName = "Export"
        Me.btnExport.DisplayName = "CommandBarButton1"
        Me.btnExport.DrawText = True
        Me.btnExport.Image = Nothing
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Text = "Export"
        Me.btnExport.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnExport.VisibleInOverflowMenu = True
        '
        'btnImport
        '
        Me.btnImport.AccessibleDescription = "Import"
        Me.btnImport.AccessibleName = "Import"
        Me.btnImport.DisplayName = "CommandBarButton2"
        Me.btnImport.DrawText = True
        Me.btnImport.Image = Nothing
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Text = "Import"
        Me.btnImport.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnImport.VisibleInOverflowMenu = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 279)
        Me.Controls.Add(Me.radScheduler1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "RadForm1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadScheduler"
        Me.ThemeName = "ControlDefault"
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnImport As Telerik.WinControls.UI.CommandBarButton
End Class
