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
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        Me.RadToggleButton1 = New Telerik.WinControls.UI.RadToggleButton
        Me.RadRadioButton1 = New Telerik.WinControls.UI.RadRadioButton
        Me.RadSplitButton1 = New Telerik.WinControls.UI.RadSplitButton
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSplitButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(75, 38)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(130, 24)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "RadButton1"
        '
        'RadToggleButton1
        '
        Me.RadToggleButton1.Location = New System.Drawing.Point(75, 170)
        Me.RadToggleButton1.Name = "RadToggleButton1"
        Me.RadToggleButton1.Size = New System.Drawing.Size(100, 23)
        Me.RadToggleButton1.TabIndex = 1
        Me.RadToggleButton1.Text = "RadToggleButton1"
        '
        'RadRadioButton1
        '
        Me.RadRadioButton1.Location = New System.Drawing.Point(75, 84)
        Me.RadRadioButton1.Name = "RadRadioButton1"
        Me.RadRadioButton1.Size = New System.Drawing.Size(110, 18)
        Me.RadRadioButton1.TabIndex = 2
        Me.RadRadioButton1.Text = "RadRadioButton1"
        '
        'RadSplitButton1
        '
        Me.RadSplitButton1.DefaultItem = Nothing
        Me.RadSplitButton1.Location = New System.Drawing.Point(75, 123)
        Me.RadSplitButton1.Name = "RadSplitButton1"
        Me.RadSplitButton1.Size = New System.Drawing.Size(136, 30)
        Me.RadSplitButton1.TabIndex = 3
        Me.RadSplitButton1.Text = "RadSplitButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 265)
        Me.Controls.Add(Me.RadSplitButton1)
        Me.Controls.Add(Me.RadRadioButton1)
        Me.Controls.Add(Me.RadToggleButton1)
        Me.Controls.Add(Me.RadButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSplitButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadToggleButton1 As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents RadRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadSplitButton1 As Telerik.WinControls.UI.RadSplitButton

End Class
