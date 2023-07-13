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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        Me.office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement
        Me.radSplitButtonElement1 = New Telerik.WinControls.UI.RadSplitButtonElement
        Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem
        Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement
        Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement
        Me.btnBuild = New Telerik.WinControls.UI.RadButton
        Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar
        Me.telerikTheme1 = New Telerik.WinControls.Themes.TelerikTheme
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radLabel1
        '
        Me.radLabel1.BackColor = System.Drawing.Color.Transparent
        Me.radLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.radLabel1.Location = New System.Drawing.Point(17, 111)
        Me.radLabel1.Name = "radLabel1"
        '
        '
        '
        Me.radLabel1.RootElement.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.radLabel1.Size = New System.Drawing.Size(163, 14)
        Me.radLabel1.TabIndex = 0
        Me.radLabel1.Text = "Building MFG part X7712-78. . ."
        CType(Me.radLabel1.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Building MFG part X7712-78. . ."
        CType(Me.radLabel1.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchHorizontally = False
        CType(Me.radLabel1.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchVertically = False
        CType(Me.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'radTrackBar1
        '
        Me.radTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.radTrackBar1.Location = New System.Drawing.Point(12, 32)
        Me.radTrackBar1.Maximum = 100
        Me.radTrackBar1.Name = "radTrackBar1"
        Me.radTrackBar1.Size = New System.Drawing.Size(361, 20)
        Me.radTrackBar1.SlideAreaWidth = 2
        Me.radTrackBar1.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke
        Me.radTrackBar1.SliderAreaColor2 = System.Drawing.Color.DarkGray
        Me.radTrackBar1.TabIndex = 2
        Me.radTrackBar1.Text = "radTrackBar1"
        Me.radTrackBar1.TickFrequency = 5
        Me.radTrackBar1.TicksColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.radTrackBar1.Value = 20
        '
        'radLabel2
        '
        Me.radLabel2.BackColor = System.Drawing.Color.Transparent
        Me.radLabel2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.radLabel2.Location = New System.Drawing.Point(12, 12)
        Me.radLabel2.Name = "radLabel2"
        '
        '
        '
        Me.radLabel2.RootElement.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.radLabel2.Size = New System.Drawing.Size(86, 14)
        Me.radLabel2.TabIndex = 3
        Me.radLabel2.Text = "Number of Units"
        CType(Me.radLabel2.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Number of Units"
        CType(Me.radLabel2.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchHorizontally = False
        CType(Me.radLabel2.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).StretchVertically = False
        CType(Me.radLabel2.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.ImageList = Me.imageList1
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElement1, Me.radSplitButtonElement1, Me.radCheckBoxElement1, Me.radProgressBarElement1})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 197)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(402, 44)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 4
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "preferences.png")
        Me.imageList1.Images.SetKeyName(1, "Printer.png")
        '
        'radButtonElement1
        '
        Me.radButtonElement1.CanFocus = True
        Me.radButtonElement1.Image = CType(resources.GetObject("radButtonElement1.Image"), System.Drawing.Image)
        Me.radButtonElement1.ImageKey = "preferences.png"
        Me.radButtonElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radButtonElement1.Name = "radButtonElement1"
        Me.radButtonElement1.Padding = New System.Windows.Forms.Padding(5)
        Me.radStatusStrip1.SetSpring(Me.radButtonElement1, False)
        Me.radButtonElement1.Text = "Build"
        Me.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'radSplitButtonElement1
        '
        Me.radSplitButtonElement1.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
        Me.radSplitButtonElement1.DefaultItem = Nothing
        Me.radSplitButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
        Me.radSplitButtonElement1.ExpandArrowButton = False
        Me.radSplitButtonElement1.HasTwoColumnDropDown = False
        Me.radSplitButtonElement1.Image = CType(resources.GetObject("radSplitButtonElement1.Image"), System.Drawing.Image)
        Me.radSplitButtonElement1.ImageKey = "Printer.png"
        Me.radSplitButtonElement1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3})
        Me.radSplitButtonElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radSplitButtonElement1.Name = "radSplitButtonElement1"
        Me.radStatusStrip1.SetSpring(Me.radSplitButtonElement1, False)
        Me.radSplitButtonElement1.Text = "Print"
        Me.radSplitButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'radMenuItem1
        '
        Me.radMenuItem1.Name = "radMenuItem1"
        Me.radMenuItem1.Text = "Printer Setup"
        '
        'radMenuItem2
        '
        Me.radMenuItem2.Name = "radMenuItem2"
        Me.radMenuItem2.Text = "Print Preview"
        '
        'radMenuItem3
        '
        Me.radMenuItem3.Name = "radMenuItem3"
        Me.radMenuItem3.Text = "Print"
        '
        'radCheckBoxElement1
        '
        Me.radCheckBoxElement1.CanFocus = True
        Me.radCheckBoxElement1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.radCheckBoxElement1.ToggleState = True
        Me.radCheckBoxElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
        Me.radCheckBoxElement1.ShowBorder = False
        Me.radStatusStrip1.SetSpring(Me.radCheckBoxElement1, False)
        Me.radCheckBoxElement1.Text = "Confirmation Email?"
        Me.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        CType(Me.radCheckBoxElement1.GetChildAt(1).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'radProgressBarElement1
        '
        Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.radProgressBarElement1.ClipDrawing = True
        Me.radProgressBarElement1.DefaultSize = New System.Drawing.Size(130, 16)
        Me.radProgressBarElement1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.radProgressBarElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radProgressBarElement1.Name = "radProgressBarElement1"
        Me.radStatusStrip1.SetSpring(Me.radProgressBarElement1, False)
        Me.radProgressBarElement1.Text = "part X7712-78. . ."
        Me.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radProgressBarElement1.Value1 = 20
        ' CType(Me.radProgressBarElement1.GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        '
        'btnBuild
        '
        Me.btnBuild.AllowShowFocusCues = True
        Me.btnBuild.Location = New System.Drawing.Point(276, 111)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(97, 31)
        Me.btnBuild.TabIndex = 5
        Me.btnBuild.Text = "Build"
        Me.btnBuild.ThemeName = "Office2007Black"
        Me.btnBuild.Visible = False
        '
        'radProgressBar1
        '
        Me.radProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.radProgressBar1.Dash = False
        Me.radProgressBar1.Location = New System.Drawing.Point(17, 161)
        Me.radProgressBar1.Name = "radProgressBar1"
        Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
        Me.radProgressBar1.SeparatorWidth = 4
        Me.radProgressBar1.ShowProgressIndicators = True
        Me.radProgressBar1.Size = New System.Drawing.Size(356, 30)
        Me.radProgressBar1.StepWidth = 13
        Me.radProgressBar1.TabIndex = 6
        Me.radProgressBar1.Text = "23%"
        Me.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radProgressBar1.Value1 = 23
        Me.radProgressBar1.Visible = False
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 241)
        Me.Controls.Add(Me.radProgressBar1)
        Me.Controls.Add(Me.btnBuild)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radTrackBar1)
        Me.Controls.Add(Me.radLabel1)
        Me.Name = "RadForm1"
        Me.Text = "Build Stage"
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Private office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Private imageList1 As System.Windows.Forms.ImageList
    Private radSplitButtonElement1 As Telerik.WinControls.UI.RadSplitButtonElement
    Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
    Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
    Private radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Private btnBuild As Telerik.WinControls.UI.RadButton
    Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Private telerikTheme1 As Telerik.WinControls.Themes.TelerikTheme
End Class
