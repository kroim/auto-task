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
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem
        Me.RadMenuItem3 = New Telerik.WinControls.UI.RadMenuItem
        Me.RadMenuItem4 = New Telerik.WinControls.UI.RadMenuItem
        Me.RadMenuItem5 = New Telerik.WinControls.UI.RadMenuItem
        Me.RadMenuItem6 = New Telerik.WinControls.UI.RadMenuItem
        Me.RadMenuItem7 = New Telerik.WinControls.UI.RadMenuItem
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItem2, Me.RadMenuItem3})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Size = New System.Drawing.Size(284, 20)
        Me.RadMenu1.TabIndex = 0
        Me.RadMenu1.Text = "RadMenu1"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.AccessibleDescription = "Item 1"
        Me.RadMenuItem1.AccessibleName = "Item 1"
        Me.RadMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem4, Me.RadMenuItem5})
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "Item 1"
        Me.RadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem2
        '
        Me.RadMenuItem2.AccessibleDescription = "Item 2"
        Me.RadMenuItem2.AccessibleName = "Item 2"
        Me.RadMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem6})
        Me.RadMenuItem2.Name = "RadMenuItem2"
        Me.RadMenuItem2.Text = "Item 2"
        Me.RadMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem3
        '
        Me.RadMenuItem3.AccessibleDescription = "Item 3"
        Me.RadMenuItem3.AccessibleName = "Item 3"
        Me.RadMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem7})
        Me.RadMenuItem3.Name = "RadMenuItem3"
        Me.RadMenuItem3.Text = "Item 3"
        Me.RadMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem4
        '
        Me.RadMenuItem4.AccessibleDescription = "Sub menu item 1"
        Me.RadMenuItem4.AccessibleName = "Sub menu item 1"
        Me.RadMenuItem4.Name = "RadMenuItem4"
        Me.RadMenuItem4.Text = "Sub menu item 1"
        Me.RadMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem5
        '
        Me.RadMenuItem5.AccessibleDescription = "Sub menu item 2"
        Me.RadMenuItem5.AccessibleName = "Sub menu item 2"
        Me.RadMenuItem5.Name = "RadMenuItem5"
        Me.RadMenuItem5.Text = "Sub menu item 2"
        Me.RadMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem6
        '
        Me.RadMenuItem6.AccessibleDescription = "Sub menu item 1"
        Me.RadMenuItem6.AccessibleName = "Sub menu item 1"
        Me.RadMenuItem6.Name = "RadMenuItem6"
        Me.RadMenuItem6.Text = "Sub menu item 1"
        Me.RadMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem7
        '
        Me.RadMenuItem7.AccessibleDescription = "Sub menu item 1"
        Me.RadMenuItem7.AccessibleName = "Sub menu item 1"
        Me.RadMenuItem7.Name = "RadMenuItem7"
        Me.RadMenuItem7.Text = "Sub menu item 1"
        Me.RadMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RadMenu1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem3 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem4 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem5 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem6 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem7 As Telerik.WinControls.UI.RadMenuItem

End Class
