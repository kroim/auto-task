Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits RadForm

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
        Dim CarouselEllipsePath2 As Telerik.WinControls.UI.CarouselEllipsePath = New Telerik.WinControls.UI.CarouselEllipsePath
        Me.RadCarousel1 = New Telerik.WinControls.UI.RadCarousel
        CType(Me.RadCarousel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCarousel1
        '
        CarouselEllipsePath2.Center = New Telerik.WinControls.UI.Point3D(50, 50, 0)
        CarouselEllipsePath2.FinalAngle = -100
        CarouselEllipsePath2.InitialAngle = -90
        CarouselEllipsePath2.U = New Telerik.WinControls.UI.Point3D(-20, -17, -50)
        CarouselEllipsePath2.V = New Telerik.WinControls.UI.Point3D(30, -25, -60)
        CarouselEllipsePath2.ZScale = 500
        Me.RadCarousel1.CarouselPath = CarouselEllipsePath2
        Me.RadCarousel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCarousel1.Location = New System.Drawing.Point(0, 0)
        Me.RadCarousel1.Name = "RadCarousel1"
        Me.RadCarousel1.SelectedIndex = 0
        Me.RadCarousel1.Size = New System.Drawing.Size(478, 434)
        Me.RadCarousel1.TabIndex = 0
        Me.RadCarousel1.Text = "RadCarousel1"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 434)
        Me.Controls.Add(Me.RadCarousel1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form1"
        CType(Me.RadCarousel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadCarousel1 As Telerik.WinControls.UI.RadCarousel

End Class
