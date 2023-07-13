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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarButton1 = New Telerik.WinControls.UI.CommandBarButton
        Me.CommandBarButton2 = New Telerik.WinControls.UI.CommandBarButton
        Me.CommandBarButton3 = New Telerik.WinControls.UI.CommandBarButton
        Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarDropDownButton1 = New Telerik.WinControls.UI.CommandBarDropDownButton
        Me.CommandBarToggleButton1 = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.CommandBarDropDownList1 = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement3 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarButton4 = New Telerik.WinControls.UI.CommandBarButton
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1, Me.CommandBarRowElement2})
        Me.RadCommandBar1.Size = New System.Drawing.Size(834, 105)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1, Me.CommandBarStripElement2})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarButton1, Me.CommandBarButton2, Me.CommandBarButton3})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'CommandBarButton1
        '
        Me.CommandBarButton1.AccessibleDescription = "CommandBarButton1"
        Me.CommandBarButton1.AccessibleName = "CommandBarButton1"
        Me.CommandBarButton1.DisplayName = "CommandBarButton1"
        Me.CommandBarButton1.Image = Global.Introduction.My.Resources.Resources._New
        Me.CommandBarButton1.Name = "CommandBarButton1"
        Me.CommandBarButton1.Text = "CommandBarButton1"
        Me.CommandBarButton1.ToolTipText = "Create New File"
        Me.CommandBarButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarButton1.VisibleInOverflowMenu = True
        '
        'CommandBarButton2
        '
        Me.CommandBarButton2.AccessibleDescription = "CommandBarButton2"
        Me.CommandBarButton2.AccessibleName = "CommandBarButton2"
        Me.CommandBarButton2.DisplayName = "CommandBarButton2"
        Me.CommandBarButton2.Image = Global.Introduction.My.Resources.Resources.Open
        Me.CommandBarButton2.Name = "CommandBarButton2"
        Me.CommandBarButton2.Text = "CommandBarButton2"
        Me.CommandBarButton2.ToolTipText = "Open file"
        Me.CommandBarButton2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarButton2.VisibleInOverflowMenu = True
        '
        'CommandBarButton3
        '
        Me.CommandBarButton3.AccessibleDescription = "CommandBarButton3"
        Me.CommandBarButton3.AccessibleName = "CommandBarButton3"
        Me.CommandBarButton3.DisplayName = "CommandBarButton3"
        Me.CommandBarButton3.Image = Global.Introduction.My.Resources.Resources.Save
        Me.CommandBarButton3.Name = "CommandBarButton3"
        Me.CommandBarButton3.Text = "CommandBarButton3"
        Me.CommandBarButton3.ToolTipText = "Save file"
        Me.CommandBarButton3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarButton3.VisibleInOverflowMenu = True
        '
        'CommandBarStripElement2
        '
        Me.CommandBarStripElement2.DisplayName = "CommandBarStripElement2"
        Me.CommandBarStripElement2.EnableFloating = True
        Me.CommandBarStripElement2.FloatingForm = Nothing
        Me.CommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarDropDownButton1, Me.CommandBarToggleButton1, Me.CommandBarDropDownList1})
        Me.CommandBarStripElement2.Name = "CommandBarStripElement2"
        Me.CommandBarStripElement2.Text = ""
        '
        'CommandBarDropDownButton1
        '
        Me.CommandBarDropDownButton1.AccessibleDescription = "CommandBarDropDownButton1"
        Me.CommandBarDropDownButton1.AccessibleName = "CommandBarDropDownButton1"
        Me.CommandBarDropDownButton1.DisplayName = "CommandBarDropDownButton1"
        Me.CommandBarDropDownButton1.Image = Global.Introduction.My.Resources.Resources.Printer
        Me.CommandBarDropDownButton1.Name = "CommandBarDropDownButton1"
        Me.CommandBarDropDownButton1.Text = "CommandBarDropDownButton1"
        Me.CommandBarDropDownButton1.ToolTipText = "Print"
        Me.CommandBarDropDownButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarDropDownButton1.VisibleInOverflowMenu = True
        '
        'CommandBarToggleButton1
        '
        Me.CommandBarToggleButton1.AccessibleDescription = "Two sided print"
        Me.CommandBarToggleButton1.AccessibleName = "Two sided print"
        Me.CommandBarToggleButton1.DisplayName = "CommandBarToggleButton1"
        Me.CommandBarToggleButton1.DrawText = True
        Me.CommandBarToggleButton1.Image = Nothing
        Me.CommandBarToggleButton1.Name = "CommandBarToggleButton1"
        Me.CommandBarToggleButton1.Text = "Two sided print"
        Me.CommandBarToggleButton1.ToolTipText = "Two sided print"
        Me.CommandBarToggleButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarToggleButton1.VisibleInOverflowMenu = True
        '
        'CommandBarDropDownList1
        '
        Me.CommandBarDropDownList1.AccessibleDescription = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.AccessibleName = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.DisplayName = "CommandBarDropDownList1"
        RadListDataItem1.Text = "8.5 x 11"
        RadListDataItem1.TextWrap = True
        Me.CommandBarDropDownList1.Items.Add(RadListDataItem1)
        Me.CommandBarDropDownList1.Name = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.Text = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.ToolTipText = "Size"
        Me.CommandBarDropDownList1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarDropDownList1.VisibleInOverflowMenu = True
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.DisplayName = Nothing
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement3})
        '
        'CommandBarStripElement3
        '
        Me.CommandBarStripElement3.DisplayName = "CommandBarStripElement3"
        Me.CommandBarStripElement3.FloatingForm = Nothing
        Me.CommandBarStripElement3.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarButton4})
        Me.CommandBarStripElement3.Name = "CommandBarStripElement3"
        Me.CommandBarStripElement3.Text = ""
        '
        'CommandBarButton4
        '
        Me.CommandBarButton4.AccessibleDescription = "CommandBarButton4"
        Me.CommandBarButton4.AccessibleName = "CommandBarButton4"
        Me.CommandBarButton4.DisplayName = "CommandBarButton4"
        Me.CommandBarButton4.Image = Global.Introduction.My.Resources.Resources.Help
        Me.CommandBarButton4.Name = "CommandBarButton4"
        Me.CommandBarButton4.Text = "CommandBarButton4"
        Me.CommandBarButton4.ToolTipText = "Help"
        Me.CommandBarButton4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarButton4.VisibleInOverflowMenu = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 262)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarButton1 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarButton2 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarButton3 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarDropDownButton1 As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents CommandBarToggleButton1 As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents CommandBarDropDownList1 As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement3 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarButton4 As Telerik.WinControls.UI.CommandBarButton

End Class
