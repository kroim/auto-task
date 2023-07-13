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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.ilIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.radMenu1 = New Telerik.WinControls.UI.RadMenu
        Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem
        Me.miOpen = New Telerik.WinControls.UI.RadMenuItem
        Me.miClose = New Telerik.WinControls.UI.RadMenuItem
        Me.miExit = New Telerik.WinControls.UI.RadMenuItem
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel
        Me.lblDetail = New Telerik.WinControls.UI.RadLabel
        Me.tvReflection = New Telerik.WinControls.UI.RadTreeView
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.lblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tvReflection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ilIcons
        '
        Me.ilIcons.ImageStream = CType(resources.GetObject("ilIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilIcons.TransparentColor = System.Drawing.Color.Fuchsia
        Me.ilIcons.Images.SetKeyName(0, "library")
        Me.ilIcons.Images.SetKeyName(1, "class")
        Me.ilIcons.Images.SetKeyName(2, "property")
        Me.ilIcons.Images.SetKeyName(3, "method")
        '
        'radMenu1
        '
        Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem1})
        Me.radMenu1.Location = New System.Drawing.Point(0, 0)
        Me.radMenu1.Name = "radMenu1"
        Me.radMenu1.Size = New System.Drawing.Size(499, 20)
        Me.radMenu1.TabIndex = 0
        Me.radMenu1.Text = "radMenu1"
        '
        'radMenuItem1
        '
        Me.radMenuItem1.AccessibleDescription = "File"
        Me.radMenuItem1.AccessibleName = "File"
        Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miOpen, Me.miClose, Me.miExit})
        Me.radMenuItem1.Name = "radMenuItem1"
        Me.radMenuItem1.Text = "File"
        Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miOpen
        '
        Me.miOpen.AccessibleDescription = "Open"
        Me.miOpen.AccessibleName = "Open"
        Me.miOpen.Name = "miOpen"
        Me.miOpen.Text = "Open"
        Me.miOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miClose
        '
        Me.miClose.AccessibleDescription = "Close"
        Me.miClose.AccessibleName = "Close"
        Me.miClose.Name = "miClose"
        Me.miClose.Text = "Close"
        Me.miClose.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miExit
        '
        Me.miExit.AccessibleDescription = "Exit"
        Me.miExit.AccessibleName = "Exit"
        Me.miExit.Name = "miExit"
        Me.miExit.Text = "Exit"
        Me.miExit.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(499, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.radStatusStrip1.SetSpring(Me.lblStatus, False)
        Me.lblStatus.Text = ""
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.tvReflection)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 20)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(499, 400)
        Me.RadPanel1.TabIndex = 2
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.SystemColors.Info
        Me.RadPanel2.Controls.Add(Me.lblDetail)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel2.Location = New System.Drawing.Point(0, 426)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(499, 89)
        Me.RadPanel2.TabIndex = 3
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = False
        Me.lblDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetail.Location = New System.Drawing.Point(0, 0)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        '
        '
        '
        Me.lblDetail.RootElement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblDetail.Size = New System.Drawing.Size(499, 89)
        Me.lblDetail.TabIndex = 0
        '
        'tvReflection
        '
        Me.tvReflection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvReflection.Location = New System.Drawing.Point(0, 0)
        Me.tvReflection.Name = "tvReflection"
        Me.tvReflection.Size = New System.Drawing.Size(499, 400)
        Me.tvReflection.TabIndex = 0
        Me.tvReflection.Text = "RadTreeView1"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 541)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Controls.Add(Me.radMenu1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "TreeView"
        Me.ThemeName = "ControlDefault"
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.lblDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tvReflection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private ilIcons As System.Windows.Forms.ImageList
    Private radMenu1 As Telerik.WinControls.UI.RadMenu
    Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miOpen As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miClose As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miExit As Telerik.WinControls.UI.RadMenuItem
    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents lblStatus As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblDetail As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tvReflection As Telerik.WinControls.UI.RadTreeView

End Class
