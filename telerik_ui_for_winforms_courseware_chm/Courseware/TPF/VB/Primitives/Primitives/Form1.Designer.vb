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
        Me.radPanel1 = New Telerik.WinControls.UI.RadPanel
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPanel1
        '
        Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radPanel1.Location = New System.Drawing.Point(0, 0)
        Me.radPanel1.Name = "radPanel1"
        Me.radPanel1.Size = New System.Drawing.Size(218, 353)
        Me.radPanel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 353)
        Me.Controls.Add(Me.radPanel1)
        Me.Name = "Form1"
        Me.Text = "Primitives"
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radPanel1 As Telerik.WinControls.UI.RadPanel

End Class
