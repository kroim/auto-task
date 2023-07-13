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
        Me.ddbImages = New Telerik.WinControls.UI.RadDropDownButton
        Me.sbSizeMode = New Telerik.WinControls.UI.RadSplitButton
        Me.btnSizeModeNormal = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.btnSizeModeStretch = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.btnSizeModeAutoSize = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.btnSizeModeCenterImage = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.btnSizeModeZoom = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.radPanel1 = New Telerik.WinControls.UI.RadPanel
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.cbFlip = New Telerik.WinControls.UI.RadCheckBox
        Me.cbVerticalFlip = New Telerik.WinControls.UI.RadCheckBox
        Me.rbRotate = New Telerik.WinControls.UI.RadRepeatButton
        Me.cbHorizontalFlip = New Telerik.WinControls.UI.RadCheckBox
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rbFixed3D = New Telerik.WinControls.UI.RadRadioButton
        Me.rbFixedSingle = New Telerik.WinControls.UI.RadRadioButton
        Me.rbNone = New Telerik.WinControls.UI.RadRadioButton
        Me.tbBackgroundColor = New Telerik.WinControls.UI.RadToggleButton
        Me.btnLoad = New Telerik.WinControls.UI.RadButton
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        CType(Me.ddbImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbSizeMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPanel1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.cbFlip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbVerticalFlip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHorizontalFlip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.rbFixed3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbFixedSingle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbNone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBackgroundColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddbImages
        '
        Me.ddbImages.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
        Me.ddbImages.Location = New System.Drawing.Point(325, 10)
        Me.ddbImages.Name = "ddbImages"
        Me.ddbImages.Size = New System.Drawing.Size(143, 24)
        Me.ddbImages.TabIndex = 4
        Me.ddbImages.Text = "Choose Images"
        Me.ddbImages.ThemeName = "ControlDefault"
        '
        'sbSizeMode
        '
        Me.sbSizeMode.DefaultItem = Nothing
        Me.sbSizeMode.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnSizeModeNormal, Me.btnSizeModeStretch, Me.btnSizeModeAutoSize, Me.btnSizeModeCenterImage, Me.btnSizeModeZoom})
        Me.sbSizeMode.Location = New System.Drawing.Point(541, 13)
        Me.sbSizeMode.Name = "sbSizeMode"
        Me.sbSizeMode.Size = New System.Drawing.Size(130, 24)
        Me.sbSizeMode.TabIndex = 6
        Me.sbSizeMode.Text = "Choose a Size Mode"
        Me.sbSizeMode.ThemeName = "ControlDefault"
        '
        'btnSizeModeNormal
        '
        '
        '
        '
        Me.btnSizeModeNormal.ButtonElement.Class = "RadMenuButtonElement"
        Me.btnSizeModeNormal.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSizeModeNormal.Name = "btnSizeModeNormal"
        Me.btnSizeModeNormal.Tag = "0"
        Me.btnSizeModeNormal.Text = "Normal"
        CType(Me.btnSizeModeNormal.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnSizeModeNormal.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'btnSizeModeStretch
        '
        '
        '
        '
        Me.btnSizeModeStretch.ButtonElement.Class = "RadMenuButtonElement"
        Me.btnSizeModeStretch.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSizeModeStretch.Name = "btnSizeModeStretch"
        Me.btnSizeModeStretch.Tag = "1"
        Me.btnSizeModeStretch.Text = "Stretch Image"
        CType(Me.btnSizeModeStretch.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnSizeModeStretch.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'btnSizeModeAutoSize
        '
        '
        '
        '
        Me.btnSizeModeAutoSize.ButtonElement.Class = "RadMenuButtonElement"
        Me.btnSizeModeAutoSize.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSizeModeAutoSize.Name = "btnSizeModeAutoSize"
        Me.btnSizeModeAutoSize.Tag = "2"
        Me.btnSizeModeAutoSize.Text = "AutoSize"
        CType(Me.btnSizeModeAutoSize.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnSizeModeAutoSize.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'btnSizeModeCenterImage
        '
        '
        '
        '
        Me.btnSizeModeCenterImage.ButtonElement.Class = "RadMenuButtonElement"
        Me.btnSizeModeCenterImage.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSizeModeCenterImage.Name = "btnSizeModeCenterImage"
        Me.btnSizeModeCenterImage.Tag = "3"
        Me.btnSizeModeCenterImage.Text = "Center Image"
        CType(Me.btnSizeModeCenterImage.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnSizeModeCenterImage.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'btnSizeModeZoom
        '
        '
        '
        '
        Me.btnSizeModeZoom.ButtonElement.Class = "RadMenuButtonElement"
        Me.btnSizeModeZoom.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSizeModeZoom.Name = "btnSizeModeZoom"
        Me.btnSizeModeZoom.Tag = "4"
        Me.btnSizeModeZoom.Text = "Zoom"
        CType(Me.btnSizeModeZoom.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnSizeModeZoom.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png"
        '
        'radPanel1
        '
        Me.radPanel1.BackColor = System.Drawing.Color.Transparent
        Me.radPanel1.Controls.Add(Me.groupBox2)
        Me.radPanel1.Controls.Add(Me.radLabel2)
        Me.radPanel1.Controls.Add(Me.radLabel1)
        Me.radPanel1.Controls.Add(Me.groupBox1)
        Me.radPanel1.Controls.Add(Me.sbSizeMode)
        Me.radPanel1.Controls.Add(Me.tbBackgroundColor)
        Me.radPanel1.Controls.Add(Me.ddbImages)
        Me.radPanel1.Controls.Add(Me.btnLoad)
        Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radPanel1.Location = New System.Drawing.Point(0, 0)
        Me.radPanel1.Name = "radPanel1"
        Me.radPanel1.Size = New System.Drawing.Size(683, 126)
        Me.radPanel1.TabIndex = 9
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cbFlip)
        Me.groupBox2.Controls.Add(Me.cbVerticalFlip)
        Me.groupBox2.Controls.Add(Me.rbRotate)
        Me.groupBox2.Controls.Add(Me.cbHorizontalFlip)
        Me.groupBox2.Location = New System.Drawing.Point(266, 45)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(405, 57)
        Me.groupBox2.TabIndex = 19
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Image Rotation"
        '
        'cbFlip
        '
        Me.cbFlip.AllowShowFocusCues = True
        Me.cbFlip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbFlip.Location = New System.Drawing.Point(142, 21)
        Me.cbFlip.Name = "cbFlip"
        Me.cbFlip.Size = New System.Drawing.Size(37, 14)
        Me.cbFlip.TabIndex = 22
        Me.cbFlip.Text = "Flip"
        Me.cbFlip.ThemeName = "ControlDefault"
        '
        'cbVerticalFlip
        '
        Me.cbVerticalFlip.AllowShowFocusCues = True
        Me.cbVerticalFlip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbVerticalFlip.Location = New System.Drawing.Point(298, 21)
        Me.cbVerticalFlip.Name = "cbVerticalFlip"
        Me.cbVerticalFlip.Size = New System.Drawing.Size(77, 14)
        Me.cbVerticalFlip.TabIndex = 21
        Me.cbVerticalFlip.Text = "Vertical Flip"
        Me.cbVerticalFlip.ThemeName = "ControlDefault"
        '
        'rbRotate
        '
        Me.rbRotate.AllowShowFocusCues = True
        Me.rbRotate.Interval = 1000
        Me.rbRotate.Location = New System.Drawing.Point(20, 18)
        Me.rbRotate.Name = "rbRotate"
        Me.rbRotate.Size = New System.Drawing.Size(100, 23)
        Me.rbRotate.TabIndex = 20
        Me.rbRotate.Text = "Rotate"
        Me.rbRotate.ThemeName = "ControlDefault"
        '
        'cbHorizontalFlip
        '
        Me.cbHorizontalFlip.AllowShowFocusCues = True
        Me.cbHorizontalFlip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbHorizontalFlip.Location = New System.Drawing.Point(190, 21)
        Me.cbHorizontalFlip.Name = "cbHorizontalFlip"
        Me.cbHorizontalFlip.Size = New System.Drawing.Size(91, 14)
        Me.cbHorizontalFlip.TabIndex = 19
        Me.cbHorizontalFlip.Text = "Horizontal Flip"
        Me.cbHorizontalFlip.ThemeName = "ControlDefault"
        '
        'radLabel2
        '
        Me.radLabel2.Location = New System.Drawing.Point(275, 13)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(44, 14)
        Me.radLabel2.TabIndex = 16
        Me.radLabel2.Text = "Images:"
        '
        'radLabel1
        '
        Me.radLabel1.Location = New System.Drawing.Point(474, 11)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(61, 14)
        Me.radLabel1.TabIndex = 15
        Me.radLabel1.Text = "Size Mode:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rbFixed3D)
        Me.groupBox1.Controls.Add(Me.rbFixedSingle)
        Me.groupBox1.Controls.Add(Me.rbNone)
        Me.groupBox1.Location = New System.Drawing.Point(12, 45)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(247, 57)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Border Style"
        '
        'rbFixed3D
        '
        Me.rbFixed3D.AllowShowFocusCues = True
        Me.rbFixed3D.IsChecked = True
        Me.rbFixed3D.Location = New System.Drawing.Point(167, 21)
        Me.rbFixed3D.Name = "rbFixed3D"
        Me.rbFixed3D.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbFixed3D.Size = New System.Drawing.Size(62, 16)
        Me.rbFixed3D.TabIndex = 16
        Me.rbFixed3D.Tag = "2"
        Me.rbFixed3D.Text = "Fixed3D"
        Me.rbFixed3D.ThemeName = "ControlDefault"
        Me.rbFixed3D.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rbFixedSingle
        '
        Me.rbFixedSingle.AllowShowFocusCues = True
        Me.rbFixedSingle.Location = New System.Drawing.Point(68, 21)
        Me.rbFixedSingle.Name = "rbFixedSingle"
        Me.rbFixedSingle.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbFixedSingle.Size = New System.Drawing.Size(83, 16)
        Me.rbFixedSingle.TabIndex = 15
        Me.rbFixedSingle.Tag = "1"
        Me.rbFixedSingle.Text = "Fixed Single"
        Me.rbFixedSingle.ThemeName = "ControlDefault"
        '
        'rbNone
        '
        Me.rbNone.AllowShowFocusCues = True
        Me.rbNone.Location = New System.Drawing.Point(6, 21)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbNone.Size = New System.Drawing.Size(47, 16)
        Me.rbNone.TabIndex = 14
        Me.rbNone.Tag = "0"
        Me.rbNone.Text = "None"
        Me.rbNone.ThemeName = "ControlDefault"
        '
        'tbBackgroundColor
        '
        Me.tbBackgroundColor.AllowShowFocusCues = True
        Me.tbBackgroundColor.Location = New System.Drawing.Point(103, 12)
        Me.tbBackgroundColor.Name = "tbBackgroundColor"
        Me.tbBackgroundColor.Size = New System.Drawing.Size(156, 23)
        Me.tbBackgroundColor.TabIndex = 11
        Me.tbBackgroundColor.Text = "Contrast Background"
        Me.tbBackgroundColor.ThemeName = "ControlDefault"
        '
        'btnLoad
        '
        Me.btnLoad.AllowShowFocusCues = True
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.Location = New System.Drawing.Point(12, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.Text = "Load"
        Me.btnLoad.ThemeName = "ControlDefault"
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox1.Location = New System.Drawing.Point(12, 132)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(659, 318)
        Me.pictureBox1.TabIndex = 10
        Me.pictureBox1.TabStop = False
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 462)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.radPanel1)
        Me.Name = "RadForm1"
        Me.Text = "Buttons"
        Me.ThemeName = "ControlDefault"
        CType(Me.ddbImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbSizeMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPanel1.ResumeLayout(False)
        Me.radPanel1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.cbFlip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbVerticalFlip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRotate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHorizontalFlip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.rbFixed3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbFixedSingle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbNone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBackgroundColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents ddbImages As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents sbSizeMode As Telerik.WinControls.UI.RadSplitButton
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents radPanel1 As Telerik.WinControls.UI.RadPanel
    Private WithEvents btnLoad As Telerik.WinControls.UI.RadButton
    Friend WithEvents tbBackgroundColor As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFixed3D As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbFixedSingle As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbNone As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
    Private WithEvents btnSizeModeNormal As Telerik.WinControls.UI.RadMenuButtonItem
    Friend WithEvents btnSizeModeStretch As Telerik.WinControls.UI.RadMenuButtonItem
    Friend WithEvents btnSizeModeAutoSize As Telerik.WinControls.UI.RadMenuButtonItem
    Friend WithEvents btnSizeModeCenterImage As Telerik.WinControls.UI.RadMenuButtonItem
    Friend WithEvents btnSizeModeZoom As Telerik.WinControls.UI.RadMenuButtonItem
    Friend WithEvents radLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFlip As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbVerticalFlip As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rbRotate As Telerik.WinControls.UI.RadRepeatButton
    Friend WithEvents cbHorizontalFlip As Telerik.WinControls.UI.RadCheckBox

End Class
