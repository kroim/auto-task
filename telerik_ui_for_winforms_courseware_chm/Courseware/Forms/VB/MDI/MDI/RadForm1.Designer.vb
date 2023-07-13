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
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        Me.aquaTheme1 = New Telerik.WinControls.Themes.AquaTheme
        Me.office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnNew = New Telerik.WinControls.UI.CommandBarButton
        Me.btnDelete = New Telerik.WinControls.UI.CommandBarButton
        Me.CommandBarDropDownList1 = New Telerik.WinControls.UI.CommandBarDropDownList
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 406)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(598, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 0
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.radStatusStrip1.SetSpring(Me.lblStatus, True)
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "New.ico")
        Me.imageList1.Images.SetKeyName(1, "delete.ico")
        Me.imageList1.Images.SetKeyName(2, "TileWindowsHorizontallyHS.png")
        Me.imageList1.Images.SetKeyName(3, "WindowsHS.png")
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(598, 56)
        Me.RadCommandBar1.TabIndex = 1
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnNew, Me.btnDelete, Me.CommandBarDropDownList1})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnNew
        '
        Me.btnNew.AccessibleDescription = "New"
        Me.btnNew.AccessibleName = "New"
        Me.btnNew.DisplayName = "CommandBarButton1"
        Me.btnNew.DrawText = True
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Text = "New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnNew.VisibleInOverflowMenu = True
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleDescription = "Delete"
        Me.btnDelete.AccessibleName = "Delete"
        Me.btnDelete.DisplayName = "CommandBarButton2"
        Me.btnDelete.DrawText = True
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnDelete.VisibleInOverflowMenu = True
        '
        'CommandBarDropDownList1
        '
        Me.CommandBarDropDownList1.DisplayName = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.Name = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.Text = ""
        Me.CommandBarDropDownList1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarDropDownList1.VisibleInOverflowMenu = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 432)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MDI Parent"
        Me.ThemeName = "ControlDefault"
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private imageList1 As System.Windows.Forms.ImageList
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Private aquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Private office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnNew As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarDropDownList1 As Telerik.WinControls.UI.CommandBarDropDownList

End Class
