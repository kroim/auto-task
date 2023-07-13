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
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnRadForm = New Telerik.WinControls.UI.CommandBarButton
        Me.btnShapedForm = New Telerik.WinControls.UI.CommandBarButton
        Me.btnRadRibbonBar = New Telerik.WinControls.UI.CommandBarButton
        Me.btnRadAboutBox = New Telerik.WinControls.UI.CommandBarButton
        Me.btnMessageBox = New Telerik.WinControls.UI.CommandBarButton
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 265)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(528, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
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
        'radCommandBar1
        '
        Me.radCommandBar1.AutoSize = True
        Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.radCommandBar1.Name = "radCommandBar1"
        Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.radCommandBar1.Size = New System.Drawing.Size(528, 95)
        Me.radCommandBar1.TabIndex = 2
        Me.radCommandBar1.Text = "RadCommandBar1"
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnRadForm, Me.btnShapedForm, Me.btnRadRibbonBar, Me.btnRadAboutBox, Me.btnMessageBox})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnRadForm
        '
        Me.btnRadForm.AccessibleDescription = "RadForm"
        Me.btnRadForm.AccessibleName = "RadForm"
        Me.btnRadForm.DisplayName = "CommandBarButton1"
        Me.btnRadForm.DrawText = True
        Me.btnRadForm.Image = Global.GettingStarted.My.Resources.Resources.Generic_Application
        Me.btnRadForm.Name = "btnRadForm"
        Me.btnRadForm.Text = "RadForm"
        Me.btnRadForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRadForm.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnRadForm.VisibleInOverflowMenu = True
        '
        'btnShapedForm
        '
        Me.btnShapedForm.AccessibleDescription = "ShapedForm"
        Me.btnShapedForm.AccessibleName = "ShapedForm"
        Me.btnShapedForm.DisplayName = "CommandBarButton2"
        Me.btnShapedForm.DrawText = True
        Me.btnShapedForm.Image = Global.GettingStarted.My.Resources.Resources.Generic_Application
        Me.btnShapedForm.Name = "btnShapedForm"
        Me.btnShapedForm.Text = "ShapedForm"
        Me.btnShapedForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShapedForm.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnShapedForm.VisibleInOverflowMenu = True
        '
        'btnRadRibbonBar
        '
        Me.btnRadRibbonBar.AccessibleDescription = "RadRibbonBar"
        Me.btnRadRibbonBar.AccessibleName = "RadRibbonBar"
        Me.btnRadRibbonBar.DisplayName = "CommandBarButton3"
        Me.btnRadRibbonBar.DrawText = True
        Me.btnRadRibbonBar.Image = Global.GettingStarted.My.Resources.Resources.Generic_Application
        Me.btnRadRibbonBar.Name = "btnRadRibbonBar"
        Me.btnRadRibbonBar.Text = "RadRibbonBar"
        Me.btnRadRibbonBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRadRibbonBar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnRadRibbonBar.VisibleInOverflowMenu = True
        '
        'btnRadAboutBox
        '
        Me.btnRadAboutBox.AccessibleDescription = "CommandBarButton4"
        Me.btnRadAboutBox.AccessibleName = "CommandBarButton4"
        Me.btnRadAboutBox.DisplayName = "CommandBarButton4"
        Me.btnRadAboutBox.DrawText = True
        Me.btnRadAboutBox.Image = Global.GettingStarted.My.Resources.Resources.Generic_Application
        Me.btnRadAboutBox.Name = "btnRadAboutBox"
        Me.btnRadAboutBox.Text = "RadAboutBox"
        Me.btnRadAboutBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRadAboutBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnRadAboutBox.VisibleInOverflowMenu = True
        '
        'btnMessageBox
        '
        Me.btnMessageBox.AccessibleDescription = "RadMessageBox"
        Me.btnMessageBox.AccessibleName = "RadMessageBox"
        Me.btnMessageBox.DisplayName = "CommandBarButton1"
        Me.btnMessageBox.DrawText = True
        Me.btnMessageBox.Image = Global.GettingStarted.My.Resources.Resources.Generic_Application
        Me.btnMessageBox.Name = "btnMessageBox"
        Me.btnMessageBox.Text = "RadMessageBox"
        Me.btnMessageBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMessageBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnMessageBox.VisibleInOverflowMenu = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 291)
        Me.Controls.Add(Me.radCommandBar1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Forms"
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnRadForm As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnShapedForm As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnRadRibbonBar As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnRadAboutBox As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents btnMessageBox As Telerik.WinControls.UI.CommandBarButton

End Class
