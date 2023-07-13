<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnLoad = New Telerik.WinControls.UI.CommandBarButton
        Me.btnSave = New Telerik.WinControls.UI.CommandBarButton
        Me.btnLayout = New Telerik.WinControls.UI.CommandBarButton
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock
        Me.DocumentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer
        Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer
        Me.RadSplitContainer3 = New Telerik.WinControls.UI.RadSplitContainer
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow4 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer1.SuspendLayout()
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer2.SuspendLayout()
        CType(Me.RadSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer3.SuspendLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip3.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip4.SuspendLayout()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(757, 54)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnLoad, Me.btnSave, Me.btnLayout})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnLoad
        '
        Me.btnLoad.AccessibleDescription = "Load"
        Me.btnLoad.AccessibleName = "Load"
        Me.btnLoad.DisplayName = "CommandBarButton1"
        Me.btnLoad.DrawText = True
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Text = "Load"
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLoad.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnLoad.VisibleInOverflowMenu = True
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = "Save"
        Me.btnSave.AccessibleName = "Save"
        Me.btnSave.DisplayName = "CommandBarButton2"
        Me.btnSave.DrawText = True
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnSave.VisibleInOverflowMenu = True
        '
        'btnLayout
        '
        Me.btnLayout.AccessibleDescription = "Change layout"
        Me.btnLayout.AccessibleName = "Change layout"
        Me.btnLayout.DisplayName = "CommandBarButton3"
        Me.btnLayout.DrawText = True
        Me.btnLayout.Image = CType(resources.GetObject("btnLayout.Image"), System.Drawing.Image)
        Me.btnLayout.Name = "btnLayout"
        Me.btnLayout.Text = "Change layout"
        Me.btnLayout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLayout.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnLayout.VisibleInOverflowMenu = True
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow3
        Me.RadDock1.CausesValidation = False
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Controls.Add(Me.RadSplitContainer1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 54)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDock1.Size = New System.Drawing.Size(757, 486)
        Me.RadDock1.SplitterWidth = 4
        Me.RadDock1.TabIndex = 1
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'DocumentWindow2
        '
        Me.DocumentWindow2.Location = New System.Drawing.Point(6, 30)
        Me.DocumentWindow2.Name = "DocumentWindow2"
        Me.DocumentWindow2.Size = New System.Drawing.Size(327, 236)
        Me.DocumentWindow2.Text = "documentWindow2"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(200, 476)
        Me.ToolTabStrip1.TabIndex = 0
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(198, 450)
        Me.ToolWindow1.Text = "toolWindow1"
        '
        'RadSplitContainer1
        '
        Me.RadSplitContainer1.CausesValidation = False
        Me.RadSplitContainer1.Controls.Add(Me.RadSplitContainer2)
        Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip4)
        Me.RadSplitContainer1.IsCleanUpTarget = True
        Me.RadSplitContainer1.Location = New System.Drawing.Point(209, 5)
        Me.RadSplitContainer1.Name = "RadSplitContainer1"
        Me.RadSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(543, 476)
        Me.RadSplitContainer1.SplitterWidth = 4
        Me.RadSplitContainer1.TabIndex = 0
        Me.RadSplitContainer1.TabStop = False
        '
        'RadSplitContainer2
        '
        Me.RadSplitContainer2.CausesValidation = False
        Me.RadSplitContainer2.Controls.Add(Me.RadSplitContainer3)
        Me.RadSplitContainer2.Controls.Add(Me.DocumentContainer1)
        Me.RadSplitContainer2.IsCleanUpTarget = True
        Me.RadSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.RadSplitContainer2.Name = "RadSplitContainer2"
        '
        '
        '
        Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer2.Size = New System.Drawing.Size(543, 272)
        Me.RadSplitContainer2.SplitterWidth = 4
        Me.RadSplitContainer2.TabIndex = 0
        Me.RadSplitContainer2.TabStop = False
        '
        'RadSplitContainer3
        '
        Me.RadSplitContainer3.Controls.Add(Me.ToolTabStrip2)
        Me.RadSplitContainer3.Controls.Add(Me.ToolTabStrip3)
        Me.RadSplitContainer3.IsCleanUpTarget = True
        Me.RadSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.RadSplitContainer3.Name = "RadSplitContainer3"
        Me.RadSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadSplitContainer3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer3.Size = New System.Drawing.Size(200, 272)
        Me.RadSplitContainer3.SplitterWidth = 4
        Me.RadSplitContainer3.TabIndex = 2
        Me.RadSplitContainer3.TabStop = False
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(200, 134)
        Me.ToolTabStrip2.TabIndex = 0
        Me.ToolTabStrip2.TabStop = False
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.Size = New System.Drawing.Size(198, 108)
        Me.ToolWindow2.Text = "toolWindow2"
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.Controls.Add(Me.ToolWindow3)
        Me.ToolTabStrip3.Location = New System.Drawing.Point(0, 138)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip3.SelectedIndex = 0
        Me.ToolTabStrip3.Size = New System.Drawing.Size(200, 134)
        Me.ToolTabStrip3.TabIndex = 0
        Me.ToolTabStrip3.TabStop = False
        '
        'ToolWindow3
        '
        Me.ToolWindow3.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow3.Name = "ToolWindow3"
        Me.ToolWindow3.Size = New System.Drawing.Size(198, 108)
        Me.ToolWindow3.Text = "toolWindow3"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.CausesValidation = False
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(204, 0)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.Size = New System.Drawing.Size(339, 272)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = False
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.CausesValidation = False
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow2)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 1
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(339, 272)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 30)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(327, 236)
        Me.DocumentWindow1.Text = "documentWindow1"
        '
        'ToolTabStrip4
        '
        Me.ToolTabStrip4.Controls.Add(Me.ToolWindow4)
        Me.ToolTabStrip4.Location = New System.Drawing.Point(0, 276)
        Me.ToolTabStrip4.Name = "ToolTabStrip4"
        '
        '
        '
        Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip4.SelectedIndex = 0
        Me.ToolTabStrip4.Size = New System.Drawing.Size(543, 200)
        Me.ToolTabStrip4.TabIndex = 3
        Me.ToolTabStrip4.TabStop = False
        '
        'ToolWindow4
        '
        Me.ToolWindow4.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow4.Name = "ToolWindow4"
        Me.ToolWindow4.Size = New System.Drawing.Size(541, 174)
        Me.ToolWindow4.Text = "toolWindow4"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.AutoSize = True
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.RadStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(757, 26)
        Me.RadStatusStrip1.TabIndex = 0
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.RadStatusStrip1.SetSpring(Me.lblStatus, False)
        Me.lblStatus.Text = ""
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 540)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadDock1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer1.ResumeLayout(False)
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer2.ResumeLayout(False)
        CType(Me.RadSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer3.ResumeLayout(False)
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip3.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip4.ResumeLayout(False)
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnLoad As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnLayout As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents RadSplitContainer3 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow4 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents lblStatus As Telerik.WinControls.UI.RadLabelElement

End Class
