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
        Me.ddlDrives = New Telerik.WinControls.UI.RadDropDownList
        Me.lblStatus = New Telerik.WinControls.UI.RadLabel
        Me.lcFiles = New Telerik.WinControls.UI.RadListControl
        CType(Me.ddlDrives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddlDrives
        '
        Me.ddlDrives.Location = New System.Drawing.Point(16, 12)
        Me.ddlDrives.Name = "ddlDrives"
        Me.ddlDrives.ShowImageInEditorArea = True
        Me.ddlDrives.Size = New System.Drawing.Size(397, 20)
        Me.ddlDrives.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Location = New System.Drawing.Point(0, 328)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(61, 16)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "RadLabel1"
        '
        'lcFiles
        '
        Me.lcFiles.CaseSensitiveSort = True
        Me.lcFiles.ItemHeight = 18
        Me.lcFiles.Location = New System.Drawing.Point(16, 38)
        Me.lcFiles.Name = "lcFiles"
        Me.lcFiles.Size = New System.Drawing.Size(396, 277)
        Me.lcFiles.TabIndex = 3
        Me.lcFiles.Text = "RadListControl1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 344)
        Me.Controls.Add(Me.lcFiles)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ddlDrives)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ddlDrives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ddlDrives As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblStatus As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lcFiles As Telerik.WinControls.UI.RadListControl

End Class
