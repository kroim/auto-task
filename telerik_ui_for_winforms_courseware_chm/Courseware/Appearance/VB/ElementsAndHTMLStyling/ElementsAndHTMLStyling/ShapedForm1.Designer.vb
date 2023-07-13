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
        Me.components = New System.ComponentModel.Container
        Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar
        Me.roundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.roundRectShapeForm = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.radPanel1 = New Telerik.WinControls.UI.RadPanel
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement
        Me.lblTitle = New Telerik.WinControls.UI.RadLabel
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPanel1.SuspendLayout()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radTitleBar1
        '
        Me.radTitleBar1.Text = " Reservation Desk"
        Me.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radTitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.radTitleBar1.Name = "radTitleBar1"
        '
        '
        '
        Me.radTitleBar1.RootElement.ApplyShapeToControl = True
        Me.radTitleBar1.RootElement.Shape = Me.roundRectShapeTitle
        Me.radTitleBar1.Size = New System.Drawing.Size(320, 30)
        Me.radTitleBar1.TabIndex = 0
        Me.radTitleBar1.TabStop = False
        Me.radTitleBar1.Text = " Reservation Desk"
        CType(Me.radTitleBar1.GetChildAt(0), Telerik.WinControls.UI.RadTitleBarElement).Text = " Reservation Desk"
        CType(Me.radTitleBar1.GetChildAt(0), Telerik.WinControls.UI.RadTitleBarElement).Font = New System.Drawing.Font("Narkisim", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(228, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(232, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(186, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(216, Byte), Integer))
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'roundRectShapeTitle
        '
        Me.roundRectShapeTitle.BottomLeftRounded = False
        Me.roundRectShapeTitle.BottomRightRounded = False
        '
        'radPanel1
        '
        Me.radPanel1.Controls.Add(Me.radStatusStrip1)
        Me.radPanel1.Controls.Add(Me.lblTitle)
        Me.radPanel1.Controls.Add(Me.pictureBox1)
        Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radPanel1.Location = New System.Drawing.Point(0, 30)
        Me.radPanel1.Name = "radPanel1"
        Me.radPanel1.Size = New System.Drawing.Size(320, 182)
        Me.radPanel1.TabIndex = 1
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(230, Byte), Integer))
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 2
        CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement1})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 160)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(320, 22)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 6
        Me.radStatusStrip1.Text = "radStatusStrip1"
        CType(Me.radStatusStrip1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusStrip1"
        CType(Me.radStatusStrip1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.radStatusStrip1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Font = New System.Drawing.Font("Narkisim", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.radStatusStrip1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Padding = New System.Windows.Forms.Padding(2)
        CType(Me.radStatusStrip1.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).MinSize = New System.Drawing.Size(0, 19)
        CType(Me.radStatusStrip1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(235, Byte), Integer))
        CType(Me.radStatusStrip1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'radLabelElement1
        '
        Me.radLabelElement1.AccessibleDescription = "3/5/2009 6:53 PM"
        Me.radLabelElement1.AccessibleName = "3/5/2009 6:53 PM"
        Me.radLabelElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radLabelElement1.Name = "radLabelElement1"
        Me.radStatusStrip1.SetSpring(Me.radLabelElement1, False)
        Me.radLabelElement1.Text = "3/5/2009 6:53 PM"
        Me.radLabelElement1.TextWrap = True
        Me.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(121, 15)
        Me.lblTitle.Name = "lblTitle"
        '
        '
        '
        Me.lblTitle.RootElement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblTitle.Size = New System.Drawing.Size(2, 2)
        Me.lblTitle.TabIndex = 5
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ElementsAndHTMLStyling.My.Resources.Resources.Dock
        Me.pictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(103, 75)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'ShapedForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 212)
        Me.Controls.Add(Me.radPanel1)
        Me.Controls.Add(Me.radTitleBar1)
        Me.Name = "ShapedForm1"
        Me.Shape = Me.roundRectShapeForm
        Me.Text = " Reservation Desk"
        CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPanel1.ResumeLayout(False)
        Me.radPanel1.PerformLayout()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Private roundRectShapeForm As Telerik.WinControls.RoundRectShape
    Private roundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Private radPanel1 As Telerik.WinControls.UI.RadPanel
    Private lblTitle As Telerik.WinControls.UI.RadLabel
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement

End Class
