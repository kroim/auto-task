<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DragAndDropForm
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
        Me.grdLowerRight = New Telerik.WinControls.UI.RadGridView
        Me.tvTopRight = New Telerik.WinControls.UI.RadTreeView
        Me.tvLeft = New Telerik.WinControls.UI.RadTreeView
        Me.radToolStripElement1 = New Telerik.WinControls.UI.RadToolStripElement
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnAllowDragDrop = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.btnFeedback = New Telerik.WinControls.UI.CommandBarToggleButton
        CType(Me.grdLowerRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLowerRight.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tvTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tvLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        Me.ToolWindow2.SuspendLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdLowerRight
        '
        Me.grdLowerRight.BackColor = System.Drawing.SystemColors.ControlDark
        Me.grdLowerRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdLowerRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLowerRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grdLowerRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLowerRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grdLowerRight.Location = New System.Drawing.Point(0, 0)
        '
        'grdLowerRight
        '
        Me.grdLowerRight.MasterTemplate.AllowAddNewRow = False
        Me.grdLowerRight.MasterTemplate.AllowColumnChooser = False
        Me.grdLowerRight.MasterTemplate.AllowColumnReorder = False
        Me.grdLowerRight.MasterTemplate.AllowDeleteRow = False
        Me.grdLowerRight.MasterTemplate.AllowEditRow = False
        Me.grdLowerRight.MasterTemplate.EnableGrouping = False
        Me.grdLowerRight.MasterTemplate.EnableSorting = False
        Me.grdLowerRight.MasterTemplate.ShowFilteringRow = False
        Me.grdLowerRight.Name = "grdLowerRight"
        Me.grdLowerRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grdLowerRight.Size = New System.Drawing.Size(198, 223)
        Me.grdLowerRight.TabIndex = 0
        Me.grdLowerRight.Text = "radGridViewPreview"
        Me.grdLowerRight.ThemeName = "Telerik"
        CType(Me.grdLowerRight.GetChildAt(0), Telerik.WinControls.UI.RadGridViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'tvTopRight
        '
        Me.tvTopRight.AllowDrop = True
        Me.tvTopRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tvTopRight.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.tvTopRight.Location = New System.Drawing.Point(0, 30)
        Me.tvTopRight.Name = "tvTopRight"
        Me.tvTopRight.Size = New System.Drawing.Size(198, 195)
        Me.tvTopRight.TabIndex = 0
        Me.tvTopRight.Text = "radTreeView1"
        CType(Me.tvTopRight.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).DrawFill = True
        CType(Me.tvTopRight.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer))
        CType(Me.tvTopRight.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.tvTopRight.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.tvTopRight.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        '
        'tvLeft
        '
        Me.tvLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tvLeft.DisplayMember = "FullName"
        Me.tvLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvLeft.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.tvLeft.Location = New System.Drawing.Point(0, 0)
        Me.tvLeft.Name = "tvLeft"
        Me.tvLeft.ParentMember = "ReportsTo"
        Me.tvLeft.Size = New System.Drawing.Size(186, 446)
        Me.tvLeft.TabIndex = 0
        Me.tvLeft.Text = "radTreeView1"
        Me.tvLeft.ValueMember = "EmployeeID"
        CType(Me.tvLeft.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).DrawFill = True
        CType(Me.tvLeft.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer))
        CType(Me.tvLeft.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.tvLeft.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.tvLeft.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).GradientAngle = 180.0!
        CType(Me.tvLeft.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        '
        'radToolStripElement1
        '
        Me.radToolStripElement1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.radToolStripElement1.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.radToolStripElement1.MinSize = New System.Drawing.Size(0, 21)
        Me.radToolStripElement1.Name = "radToolStripElement1"
        Me.radToolStripElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow1
        Me.RadDock1.CausesValidation = False
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Controls.Add(Me.RadSplitContainer1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 30)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDock1.Size = New System.Drawing.Size(412, 468)
        Me.RadDock1.SplitterWidth = 4
        Me.RadDock1.TabIndex = 1
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.tvLeft)
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 6)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(186, 446)
        Me.DocumentWindow1.Text = "DocumentWindow1"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(5, 5)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.Size = New System.Drawing.Size(198, 458)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = False
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(198, 458)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        Me.DocumentTabStrip1.TabStripVisible = False
        '
        'RadSplitContainer1
        '
        Me.RadSplitContainer1.CausesValidation = False
        Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip1)
        Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip2)
        Me.RadSplitContainer1.IsCleanUpTarget = True
        Me.RadSplitContainer1.Location = New System.Drawing.Point(207, 5)
        Me.RadSplitContainer1.Name = "RadSplitContainer1"
        Me.RadSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(200, 458)
        Me.RadSplitContainer1.SplitterWidth = 4
        Me.RadSplitContainer1.TabIndex = 1
        Me.RadSplitContainer1.TabStop = False
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CaptionVisible = False
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(200, 227)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        Me.ToolTabStrip1.TabStripVisible = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Controls.Add(Me.TextBox1)
        Me.ToolWindow1.Controls.Add(Me.tvTopRight)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 2)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(198, 223)
        Me.ToolWindow1.Text = "toolWindow1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.CaptionVisible = False
        Me.ToolTabStrip2.CausesValidation = False
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(0, 231)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(200, 227)
        Me.ToolTabStrip2.TabIndex = 0
        Me.ToolTabStrip2.TabStop = False
        Me.ToolTabStrip2.TabStripVisible = False
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Controls.Add(Me.grdLowerRight)
        Me.ToolWindow2.Location = New System.Drawing.Point(1, 2)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.Size = New System.Drawing.Size(198, 223)
        Me.ToolWindow2.Text = "toolWindow2"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(412, 30)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnAllowDragDrop, Me.btnFeedback})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnAllowDragDrop
        '
        Me.btnAllowDragDrop.AccessibleDescription = "AllowDragDrop"
        Me.btnAllowDragDrop.AccessibleName = "AllowDragDrop"
        Me.btnAllowDragDrop.DisplayName = "CommandBarToggleButton1"
        Me.btnAllowDragDrop.DrawText = True
        Me.btnAllowDragDrop.Image = Nothing
        Me.btnAllowDragDrop.Name = "btnAllowDragDrop"
        Me.btnAllowDragDrop.Text = "AllowDragDrop"
        Me.btnAllowDragDrop.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnAllowDragDrop.VisibleInOverflowMenu = True
        '
        'btnFeedback
        '
        Me.btnFeedback.AccessibleDescription = "Feedback"
        Me.btnFeedback.AccessibleName = "Feedback"
        Me.btnFeedback.DisplayName = "CommandBarToggleButton2"
        Me.btnFeedback.DrawText = True
        Me.btnFeedback.Image = Nothing
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnFeedback.VisibleInOverflowMenu = True
        '
        'DragAndDropForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 498)
        Me.Controls.Add(Me.RadDock1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "DragAndDropForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Drag And Drop"
        Me.ThemeName = "Telerik"
        CType(Me.grdLowerRight.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLowerRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tvTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tvLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        Me.ToolWindow1.PerformLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        Me.ToolWindow2.ResumeLayout(False)
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radToolStripElement1 As Telerik.WinControls.UI.RadToolStripElement
    Private grdLowerRight As Telerik.WinControls.UI.RadGridView
    Private WithEvents tvTopRight As Telerik.WinControls.UI.RadTreeView
    Private tvLeft As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnAllowDragDrop As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents btnFeedback As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
