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
        Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.miFile = New Telerik.WinControls.UI.RadMenuItem()
        Me.miNew = New Telerik.WinControls.UI.RadMenuItem()
        Me.miOpen = New Telerik.WinControls.UI.RadMenuItem()
        Me.miSave = New Telerik.WinControls.UI.RadMenuItem()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radMenu1
        ' 
        Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miFile})
        Me.radMenu1.Location = New System.Drawing.Point(0, 0)
        Me.radMenu1.Name = "radMenu1"
        Me.radMenu1.Size = New System.Drawing.Size(284, 22)
        Me.radMenu1.TabIndex = 0
        Me.radMenu1.Text = "radMenu1"
        ' 
        ' miFile
        ' 
        Me.miFile.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miNew, Me.miOpen, Me.miSave})
        Me.miFile.Name = "miFile"
        Me.miFile.Tag = "999"
        Me.miFile.Text = "File"
        ' 
        ' miNew
        ' 
        Me.miNew.Name = "miNew"
        Me.miNew.Tag = "111"
        Me.miNew.Text = "New"
        ' 
        ' miOpen
        ' 
        Me.miOpen.Name = "miOpen"
        Me.miOpen.Tag = "222"
        Me.miOpen.Text = "Open"
        ' 
        ' miSave
        ' 
        Me.miSave.Name = "miSave"
        Me.miSave.Tag = "333"
        Me.miSave.Text = "Save"
        ' 
        ' btnGo
        ' 
        Me.btnGo.Location = New System.Drawing.Point(102, 129)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        '	  Me.btnGo.Click += New System.EventHandler(Me.btnGo_Click);
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.radMenu1)
        Me.Name = "Form1"
        Me.Text = "Menus"
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radMenu1 As Telerik.WinControls.UI.RadMenu
    Private miFile As Telerik.WinControls.UI.RadMenuItem
    Private miNew As Telerik.WinControls.UI.RadMenuItem
    Private miOpen As Telerik.WinControls.UI.RadMenuItem
    Private miSave As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents btnGo As Telerik.WinControls.UI.RadButton

End Class
