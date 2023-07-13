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
        Me.components = New System.ComponentModel.Container
        Dim RadTreeNode1 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode2 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode3 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Me.radPanel1 = New Telerik.WinControls.UI.RadPanel
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.radBreadCrumb1 = New Telerik.WinControls.UI.RadBreadCrumb
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        Me.radContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPanel1.SuspendLayout()
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radBreadCrumb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPanel1
        '
        Me.radPanel1.Controls.Add(Me.radTreeView1)
        Me.radPanel1.Controls.Add(Me.radBreadCrumb1)
        Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radPanel1.Location = New System.Drawing.Point(0, 0)
        Me.radPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.radPanel1.Name = "radPanel1"
        Me.radPanel1.Padding = New System.Windows.Forms.Padding(3)
        '
        '
        '
        Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(3)
        Me.radPanel1.Size = New System.Drawing.Size(362, 333)
        Me.radPanel1.TabIndex = 0
        CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(3)
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer))
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(223, Byte), Integer))
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 50.0!
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
        Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radTreeView1.FullRowSelect = False
        Me.radTreeView1.Location = New System.Drawing.Point(3, 39)
        Me.radTreeView1.Name = "radTreeView1"
        RadTreeNode1.Name = "Email Contacts"
        RadTreeNode1.Text = "Email Contacts"
        RadTreeNode2.Name = "Lists"
        RadTreeNode2.Text = "Lists"
        RadTreeNode3.Name = "Reports"
        RadTreeNode3.Text = "Reports"
        Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {RadTreeNode1, RadTreeNode2, RadTreeNode3})
        Me.radTreeView1.Padding = New System.Windows.Forms.Padding(5)
        Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.radTreeView1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.radTreeView1.Size = New System.Drawing.Size(356, 291)
        Me.radTreeView1.TabIndex = 2
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ThemeName = "Office2007Silver"
        '
        'radBreadCrumb1
        '
        Me.radBreadCrumb1.BackColor = System.Drawing.Color.Transparent
        Me.radBreadCrumb1.DefaultTreeView = Me.radTreeView1
        Me.radBreadCrumb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radBreadCrumb1.Location = New System.Drawing.Point(3, 3)
        Me.radBreadCrumb1.Name = "radBreadCrumb1"
        Me.radBreadCrumb1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.radBreadCrumb1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.radBreadCrumb1.Size = New System.Drawing.Size(356, 36)
        Me.radBreadCrumb1.TabIndex = 1
        Me.radBreadCrumb1.Text = "radBreadCrumb1"
        Me.radBreadCrumb1.ThemeName = "Office2007Black"
        '
        'radContextMenu1
        '
        Me.radContextMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
        '
        'radMenuItem1
        '
        Me.radMenuItem1.AccessibleDescription = "Open"
        Me.radMenuItem1.AccessibleName = "Open"
        Me.radMenuItem1.Image = Global.GettingStarted.My.Resources.Resources.Folder_Open
        Me.radMenuItem1.Name = "radMenuItem1"
        Me.radMenuItem1.Text = "Open"
        Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuItem2
        '
        Me.radMenuItem2.AccessibleDescription = "Print"
        Me.radMenuItem2.AccessibleName = "Print"
        Me.radMenuItem2.Image = Global.GettingStarted.My.Resources.Resources.Printer
        Me.radMenuItem2.Name = "radMenuItem2"
        Me.radMenuItem2.Text = "Print"
        Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuItem3
        '
        Me.radMenuItem3.AccessibleDescription = "Archive"
        Me.radMenuItem3.AccessibleName = "Archive"
        Me.radMenuItem3.Image = Global.GettingStarted.My.Resources.Resources.Journal
        Me.radMenuItem3.Name = "radMenuItem3"
        Me.radMenuItem3.Text = "Archive"
        Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 333)
        Me.Controls.Add(Me.radPanel1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "TreeView"
        Me.ThemeName = "Office2007Silver"
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPanel1.ResumeLayout(False)
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radBreadCrumb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radPanel1 As Telerik.WinControls.UI.RadPanel
    Private radBreadCrumb1 As Telerik.WinControls.UI.RadBreadCrumb
    Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Private radContextMenu1 As Telerik.WinControls.UI.RadContextMenu
    Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem

End Class
