<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XMLSerialize
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
        Me.RadTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnSave = New Telerik.WinControls.UI.CommandBarButton
        Me.btnLoad = New Telerik.WinControls.UI.CommandBarButton
        Me.tbNodeText = New Telerik.WinControls.UI.CommandBarTextBox
        Me.btnAddSibling = New Telerik.WinControls.UI.CommandBarButton
        Me.btnAddChild = New Telerik.WinControls.UI.CommandBarButton
        Me.btnDeleteNode = New Telerik.WinControls.UI.CommandBarButton
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTreeView1
        '
        Me.RadTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadTreeView1.Location = New System.Drawing.Point(0, 72)
        Me.RadTreeView1.Name = "RadTreeView1"
        Me.RadTreeView1.Size = New System.Drawing.Size(412, 330)
        Me.RadTreeView1.TabIndex = 0
        Me.RadTreeView1.Text = "RadTreeView1"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(412, 72)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnSave, Me.btnLoad, Me.tbNodeText, Me.btnAddSibling, Me.btnAddChild, Me.btnDeleteNode})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = "Save"
        Me.btnSave.AccessibleName = "Save"
        Me.btnSave.DisplayName = "CommandBarButton1"
        Me.btnSave.DrawText = True
        Me.btnSave.Image = Global.Databinding.My.Resources.Resources._3_5_Disk_Drive
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnSave.VisibleInOverflowMenu = True
        '
        'btnLoad
        '
        Me.btnLoad.AccessibleDescription = "Load"
        Me.btnLoad.AccessibleName = "Load"
        Me.btnLoad.DisplayName = "CommandBarButton2"
        Me.btnLoad.DrawText = True
        Me.btnLoad.Image = Global.Databinding.My.Resources.Resources.Folder_Open
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Text = "Load"
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLoad.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnLoad.VisibleInOverflowMenu = True
        '
        'tbNodeText
        '
        Me.tbNodeText.AccessibleDescription = "CommandBarTextBox1"
        Me.tbNodeText.AccessibleName = "CommandBarTextBox1"
        Me.tbNodeText.DisplayName = "CommandBarTextBox1"
        Me.tbNodeText.MinSize = New System.Drawing.Size(100, 0)
        Me.tbNodeText.Name = "tbNodeText"
        Me.tbNodeText.Text = ""
        Me.tbNodeText.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.tbNodeText.VisibleInOverflowMenu = True
        '
        'btnAddSibling
        '
        Me.btnAddSibling.AccessibleDescription = "Add Sibling"
        Me.btnAddSibling.AccessibleName = "Add Sibling"
        Me.btnAddSibling.DisplayName = "CommandBarButton3"
        Me.btnAddSibling.DrawText = True
        Me.btnAddSibling.Image = Nothing
        Me.btnAddSibling.Name = "btnAddSibling"
        Me.btnAddSibling.Text = "Add Sibling"
        Me.btnAddSibling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddSibling.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnAddSibling.VisibleInOverflowMenu = True
        '
        'btnAddChild
        '
        Me.btnAddChild.AccessibleDescription = "Add Child"
        Me.btnAddChild.AccessibleName = "Add Child"
        Me.btnAddChild.DisplayName = "CommandBarButton4"
        Me.btnAddChild.DrawText = True
        Me.btnAddChild.Image = Nothing
        Me.btnAddChild.Name = "btnAddChild"
        Me.btnAddChild.Text = "Add Child"
        Me.btnAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddChild.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnAddChild.VisibleInOverflowMenu = True
        '
        'btnDeleteNode
        '
        Me.btnDeleteNode.AccessibleDescription = "Delete Node"
        Me.btnDeleteNode.AccessibleName = "Delete Node"
        Me.btnDeleteNode.DisplayName = "CommandBarButton5"
        Me.btnDeleteNode.DrawText = True
        Me.btnDeleteNode.Image = Nothing
        Me.btnDeleteNode.Name = "btnDeleteNode"
        Me.btnDeleteNode.Text = "Delete Node"
        Me.btnDeleteNode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteNode.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnDeleteNode.VisibleInOverflowMenu = True
        '
        'XMLSerialize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 402)
        Me.Controls.Add(Me.RadTreeView1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "XMLSerialize"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "XMLSerialize"
        Me.ThemeName = "ControlDefault"
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadTreeView1 As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnLoad As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents tbNodeText As Telerik.WinControls.UI.CommandBarTextBox
    Friend WithEvents btnAddSibling As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnAddChild As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnDeleteNode As Telerik.WinControls.UI.CommandBarButton

End Class
