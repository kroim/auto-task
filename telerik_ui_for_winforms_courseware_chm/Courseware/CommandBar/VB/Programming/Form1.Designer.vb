<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSave = New Telerik.WinControls.UI.RadButton
        Me.btnLoad = New Telerik.WinControls.UI.RadButton
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(72, 97)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 24)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Layout"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(72, 139)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(130, 24)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load Layout"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form1"
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnLoad As Telerik.WinControls.UI.RadButton

End Class
