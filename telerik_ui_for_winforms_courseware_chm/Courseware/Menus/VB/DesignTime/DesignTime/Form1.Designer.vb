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
        Me.components = New System.ComponentModel.Container()
        Me.radContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager()
        Me.radContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPanel1.SuspendLayout()
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radPanel1
        ' 
        Me.radPanel1.BackgroundImage = Global.DesignTime.My.Resources.DescriptionBackground
        Me.radPanel1.Controls.Add(Me.radMenu1)
        Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radPanel1.Location = New System.Drawing.Point(0, 0)
        Me.radPanel1.Name = "radPanel1"
        Me.radPanel1.Size = New System.Drawing.Size(402, 54)
        Me.radPanel1.TabIndex = 1
        ' 
        ' radMenu1
        ' 
        Me.radMenu1.BackColor = System.Drawing.Color.Transparent
        Me.radMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem1})
        Me.radMenu1.Location = New System.Drawing.Point(12, 12)
        Me.radMenu1.Name = "radMenu1"
        Me.radMenu1.Size = New System.Drawing.Size(378, 22)
        Me.radMenu1.TabIndex = 1
        Me.radMenu1.Text = "radMenu1"
        ' 
        ' radMenuItem1
        ' 
        Me.radMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.radMenuItem1.Class = ""
        Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem2, Me.radMenuItem3})
        Me.radMenuItem1.Name = "radMenuItem1"
        Me.radMenuItem1.Text = "File"
        ' 
        ' radMenuItem2
        ' 
        Me.radMenuItem2.Name = "radMenuItem2"
        Me.radMenuItem2.Text = "New"
        ' 
        ' radMenuItem3
        ' 
        Me.radMenuItem3.Name = "radMenuItem3"
        Me.radMenuItem3.Text = "Open"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 318)
        Me.Controls.Add(Me.radPanel1)
        Me.Name = "Form1"
        Me.Text = "Menus"
        '			Me.Load += New System.EventHandler(Me.Form1_Load);
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPanel1.ResumeLayout(False)
        Me.radPanel1.PerformLayout()
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
    Private radContextMenu1 As Telerik.WinControls.UI.RadContextMenu
    Private radPanel1 As Telerik.WinControls.UI.RadPanel
    Private radMenu1 As Telerik.WinControls.UI.RadMenu
    Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem

End Class
