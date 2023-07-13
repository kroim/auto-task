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
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnReorder = New Telerik.WinControls.UI.CommandBarButton
        Me.CommandBarTextBox1 = New Telerik.WinControls.UI.CommandBarTextBox
        Me.btnSearch = New Telerik.WinControls.UI.CommandBarButton
        Me.btnSelectedNodes = New Telerik.WinControls.UI.CommandBarButton
        Me.tbMultiSelect = New Telerik.WinControls.UI.CommandBarToggleButton
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radTreeView1.Location = New System.Drawing.Point(0, 30)
        Me.radTreeView1.Name = "radTreeView1"
        Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radTreeView1.Size = New System.Drawing.Size(402, 262)
        Me.radTreeView1.TabIndex = 3
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ThemeName = "ControlDefault"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(402, 30)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnReorder, Me.CommandBarTextBox1, Me.btnSearch, Me.btnSelectedNodes, Me.tbMultiSelect})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnReorder
        '
        Me.btnReorder.AccessibleDescription = "Reorder"
        Me.btnReorder.AccessibleName = "Reorder"
        Me.btnReorder.DisplayName = "CommandBarButton1"
        Me.btnReorder.DrawText = True
        Me.btnReorder.Image = Nothing
        Me.btnReorder.Name = "btnReorder"
        Me.btnReorder.Text = "Reorder"
        Me.btnReorder.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnReorder.VisibleInOverflowMenu = True
        '
        'CommandBarTextBox1
        '
        Me.CommandBarTextBox1.DisplayName = "CommandBarTextBox1"
        Me.CommandBarTextBox1.MinSize = New System.Drawing.Size(120, 0)
        Me.CommandBarTextBox1.Name = "CommandBarTextBox1"
        Me.CommandBarTextBox1.Text = ""
        Me.CommandBarTextBox1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarTextBox1.VisibleInOverflowMenu = True
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleDescription = "Search"
        Me.btnSearch.AccessibleName = "Search"
        Me.btnSearch.DisplayName = "CommandBarButton2"
        Me.btnSearch.DrawText = True
        Me.btnSearch.Image = Nothing
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnSearch.VisibleInOverflowMenu = True
        '
        'btnSelectedNodes
        '
        Me.btnSelectedNodes.AccessibleDescription = "Selected Nodes"
        Me.btnSelectedNodes.AccessibleName = "Selected Nodes"
        Me.btnSelectedNodes.DisplayName = "CommandBarButton3"
        Me.btnSelectedNodes.DrawText = True
        Me.btnSelectedNodes.Image = Nothing
        Me.btnSelectedNodes.Name = "btnSelectedNodes"
        Me.btnSelectedNodes.Text = "Selected Nodes"
        Me.btnSelectedNodes.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnSelectedNodes.VisibleInOverflowMenu = True
        '
        'tbMultiSelect
        '
        Me.tbMultiSelect.AccessibleDescription = "Multiple Select"
        Me.tbMultiSelect.AccessibleName = "Multiple Select"
        Me.tbMultiSelect.DisplayName = "CommandBarToggleButton1"
        Me.tbMultiSelect.DrawText = True
        Me.tbMultiSelect.Image = Nothing
        Me.tbMultiSelect.Name = "tbMultiSelect"
        Me.tbMultiSelect.Text = "Multiple Select"
        Me.tbMultiSelect.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.tbMultiSelect.VisibleInOverflowMenu = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 292)
        Me.Controls.Add(Me.radTreeView1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        Me.ThemeName = "ControlDefault"
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnReorder As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarTextBox1 As Telerik.WinControls.UI.CommandBarTextBox
    Friend WithEvents btnSearch As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnSelectedNodes As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents tbMultiSelect As Telerik.WinControls.UI.CommandBarToggleButton

End Class
