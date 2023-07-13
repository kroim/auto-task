<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditNodes
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
        Dim RadTreeNode1 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode2 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode3 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode4 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.White
        Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.radTreeView1.Name = "radTreeView1"
        RadTreeNode1.Expanded = True
        RadTreeNode2.Text = "To Do List"
        RadTreeNode3.Text = "New Budget"
        RadTreeNode4.Text = "Project Proposal Template"
        RadTreeNode1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {RadTreeNode2, RadTreeNode3, RadTreeNode4})
        RadTreeNode1.Text = "My Documents"
        Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {RadTreeNode1})
        Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radTreeView1.Size = New System.Drawing.Size(298, 278)
        Me.radTreeView1.TabIndex = 2
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ThemeName = "Aqua"
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 252)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(298, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
        Me.radStatusStrip1.Text = "radStatusStrip1"
        Me.radStatusStrip1.ThemeName = "Aqua"
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.radStatusStrip1.SetSpring(Me.lblStatus, False)
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'EditNodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 278)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Controls.Add(Me.radTreeView1)
        Me.Name = "EditNodes"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "EditNodes"
        Me.ThemeName = "Aqua"
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Private WithEvents radTreeView1 As Telerik.WinControls.UI.RadTreeView

End Class
