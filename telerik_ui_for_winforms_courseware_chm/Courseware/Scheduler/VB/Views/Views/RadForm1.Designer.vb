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
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.ddActiveViewType = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.ddRange = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.ddCount = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel
        Me.CommandBarLabel2 = New Telerik.WinControls.UI.CommandBarLabel
        Me.CommandBarLabel3 = New Telerik.WinControls.UI.CommandBarLabel
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
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 403)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(837, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 0
        Me.radStatusStrip1.Text = "radStatusStrip1"
        Me.radStatusStrip1.ThemeName = "Desert"
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
        DateTimeInterval1.End = New Date(CType(0, Long))
        Me.radScheduler1.AccessibleInterval = DateTimeInterval1
        Me.radScheduler1.AppointmentTitleFormat = Nothing
        Me.radScheduler1.BackColor = System.Drawing.Color.White
        Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.radScheduler1.DataSource = Nothing
        Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.radScheduler1.HeaderFormat = "MMMM dd"
        Me.radScheduler1.Location = New System.Drawing.Point(0, 30)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        '
        '
        '
        Me.radScheduler1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.radScheduler1.Size = New System.Drawing.Size(837, 373)
        Me.radScheduler1.TabIndex = 2
        Me.radScheduler1.Text = "radScheduler1"
        Me.radScheduler1.ThemeName = "Desert"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(837, 30)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        Me.RadCommandBar1.ThemeName = "Desert"
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel1, Me.ddActiveViewType, Me.CommandBarLabel2, Me.ddRange, Me.CommandBarLabel3, Me.ddCount})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'ddActiveViewType
        '
        Me.ddActiveViewType.DisplayName = "CommandBarDropDownList1"
        Me.ddActiveViewType.Name = "ddActiveViewType"
        Me.ddActiveViewType.Text = ""
        Me.ddActiveViewType.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.ddActiveViewType.VisibleInOverflowMenu = True
        '
        'ddRange
        '
        Me.ddRange.DisplayName = "CommandBarDropDownList2"
        Me.ddRange.Name = "ddRange"
        Me.ddRange.Text = ""
        Me.ddRange.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.ddRange.VisibleInOverflowMenu = True
        '
        'ddCount
        '
        Me.ddCount.DisplayName = "CommandBarDropDownList3"
        Me.ddCount.Name = "ddCount"
        Me.ddCount.Text = ""
        Me.ddCount.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.ddCount.VisibleInOverflowMenu = True
        '
        'CommandBarLabel1
        '
        Me.CommandBarLabel1.AccessibleDescription = "View Types:"
        Me.CommandBarLabel1.AccessibleName = "View Types:"
        Me.CommandBarLabel1.DisplayName = "CommandBarLabel1"
        Me.CommandBarLabel1.Name = "CommandBarLabel1"
        Me.CommandBarLabel1.Text = "View Types:"
        Me.CommandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel1.VisibleInOverflowMenu = True
        '
        'CommandBarLabel2
        '
        Me.CommandBarLabel2.AccessibleDescription = "Scale Range: "
        Me.CommandBarLabel2.AccessibleName = "Scale Range: "
        Me.CommandBarLabel2.DisplayName = "CommandBarLabel2"
        Me.CommandBarLabel2.Name = "CommandBarLabel2"
        Me.CommandBarLabel2.Text = "Scale Range: "
        Me.CommandBarLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel2.VisibleInOverflowMenu = True
        '
        'CommandBarLabel3
        '
        Me.CommandBarLabel3.AccessibleDescription = "Count: "
        Me.CommandBarLabel3.AccessibleName = "Count: "
        Me.CommandBarLabel3.DisplayName = "CommandBarLabel3"
        Me.CommandBarLabel3.Name = "CommandBarLabel3"
        Me.CommandBarLabel3.Text = "Count: "
        Me.CommandBarLabel3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel3.VisibleInOverflowMenu = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 429)
        Me.Controls.Add(Me.radScheduler1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadScheduler"
        Me.ThemeName = "Desert"
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private WithEvents radScheduler1 As Telerik.WinControls.UI.RadScheduler
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents ddActiveViewType As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents ddRange As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents ddCount As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents CommandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarLabel2 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarLabel3 As Telerik.WinControls.UI.CommandBarLabel
End Class
