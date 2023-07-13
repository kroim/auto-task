<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBoxes
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
        Me.RadTreeView1 = New Telerik.WinControls.UI.RadTreeView
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTreeView1
        '
        Me.RadTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.RadTreeView1.Name = "RadTreeView1"
        Me.RadTreeView1.Size = New System.Drawing.Size(298, 282)
        Me.RadTreeView1.TabIndex = 0
        Me.RadTreeView1.Text = "RadTreeView1"
        '
        'CheckBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 282)
        Me.Controls.Add(Me.RadTreeView1)
        Me.Name = "CheckBoxes"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "CheckBoxes"
        Me.ThemeName = "ControlDefault"
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadTreeView1 As Telerik.WinControls.UI.RadTreeView


End Class
