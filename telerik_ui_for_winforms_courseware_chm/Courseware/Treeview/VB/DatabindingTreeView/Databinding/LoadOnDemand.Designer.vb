Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadOnDemand
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
        Dim RadTreeNode1 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode2 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode3 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode4 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode5 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode6 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode7 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode8 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode9 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode10 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode11 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
        Dim RadTreeNode12 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode
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
        Me.radTreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.radTreeView1.Name = "radTreeView1"
        RadTreeNode1.Text = "Current Temperature"
        RadTreeNode2.Text = "High Temperature"
        RadTreeNode3.Text = "Low Temperature"
        RadTreeNode4.Text = "Wind Chill Factor"
        RadTreeNode5.Text = "Barometric Pressure"
        RadTreeNode6.Text = "Relative Humidity"
        RadTreeNode7.Text = "Dewpoint"
        RadTreeNode8.Text = "Wind Speed"
        RadTreeNode9.Text = "Wind Direction"
        RadTreeNode10.Text = "Peak Wind Gust"
        RadTreeNode11.Text = "Precipitation Today"
        RadTreeNode12.Text = "Precipitation To Date"
        Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() {RadTreeNode1, RadTreeNode2, RadTreeNode3, RadTreeNode4, RadTreeNode5, RadTreeNode6, RadTreeNode7, RadTreeNode8, RadTreeNode9, RadTreeNode10, RadTreeNode11, RadTreeNode12})
        Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radTreeView1.Size = New System.Drawing.Size(285, 338)
        Me.radTreeView1.TabIndex = 3
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ThemeName = "ControlDefault"
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 338)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(285, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
        Me.radStatusStrip1.Text = "radStatusStrip1"
        Me.radStatusStrip1.ThemeName = "ControlDefault"
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.radStatusStrip1.SetSpring(Me.lblStatus, False)
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'LoadOnDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 364)
        Me.Controls.Add(Me.radTreeView1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Name = "LoadOnDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "LoadOnDemand"
        Me.ThemeName = "ControlDefault"
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private WithEvents radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
End Class
