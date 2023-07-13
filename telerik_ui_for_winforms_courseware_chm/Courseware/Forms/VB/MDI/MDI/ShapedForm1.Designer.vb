<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShapedForm1
    Inherits Telerik.WinControls.UI.ShapedForm

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
        Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.roundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.ellipseShape1 = New Telerik.WinControls.EllipseShape()
        CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radTitleBar1
        ' 
        Me.radTitleBar1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.radTitleBar1.Location = New System.Drawing.Point(81, 24)
        Me.radTitleBar1.Name = "radTitleBar1"
        ' 
        ' 
        ' 
        Me.radTitleBar1.RootElement.ApplyShapeToControl = True
        Me.radTitleBar1.RootElement.Shape = Me.roundRectShapeTitle
        Me.radTitleBar1.Size = New System.Drawing.Size(148, 23)
        Me.radTitleBar1.TabIndex = 0
        Me.radTitleBar1.TabStop = False
        Me.radTitleBar1.Text = "ShapedForm1"
        ' 
        ' roundRectShapeTitle
        ' 
        Me.roundRectShapeTitle.BottomLeftRounded = False
        Me.roundRectShapeTitle.BottomRightRounded = False
        ' 
        ' ShapedForm1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 310)
        Me.Controls.Add(Me.radTitleBar1)
        Me.Name = "ShapedForm1"
        Me.Shape = Me.ellipseShape1
        Me.Text = "ShapedForm1"
        CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents roundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Friend WithEvents ellipseShape1 As Telerik.WinControls.EllipseShape
End Class
