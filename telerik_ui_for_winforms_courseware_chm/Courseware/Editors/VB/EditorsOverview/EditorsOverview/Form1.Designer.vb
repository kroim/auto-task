Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label6 = New System.Windows.Forms.Label
        Me.btnAddMask = New Telerik.WinControls.UI.RadButton
        Me.lblValue = New System.Windows.Forms.Label
        Me.cbMasks = New Telerik.WinControls.UI.RadDropDownList
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.cbMaskType = New Telerik.WinControls.UI.RadDropDownList
        Me.label2 = New System.Windows.Forms.Label
        Me.meDemo = New Telerik.WinControls.UI.RadMaskedEditBox
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.btnUseContainer = New Telerik.WinControls.UI.RadButton
        Me.tbContainer = New Telerik.WinControls.UI.RadTextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.tbMultiLine = New Telerik.WinControls.UI.RadTextBox
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.radDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker
        Me.groupBox4 = New System.Windows.Forms.GroupBox
        Me.btnChangeColor = New Telerik.WinControls.UI.RadButton
        Me.pnlColor = New Telerik.WinControls.UI.RadPanel
        Me.radColorDialog1 = New Telerik.WinControls.RadColorDialog
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog
        Me.groupBox5 = New System.Windows.Forms.GroupBox
        Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar
        Me.lblSpin = New Telerik.WinControls.UI.RadLabel
        Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor
        Me.groupBox1.SuspendLayout()
        CType(Me.btnAddMask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaskType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meDemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.btnUseContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMultiLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        CType(Me.btnChangeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox5.SuspendLayout()
        CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.btnAddMask)
        Me.groupBox1.Controls.Add(Me.lblValue)
        Me.groupBox1.Controls.Add(Me.cbMasks)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.cbMaskType)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.meDemo)
        Me.groupBox1.Location = New System.Drawing.Point(12, 225)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(327, 190)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Masks"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(45, 77)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 13)
        Me.label6.TabIndex = 19
        Me.label6.Text = "Value:"
        '
        'btnAddMask
        '
        Me.btnAddMask.AllowShowFocusCues = True
        Me.btnAddMask.Location = New System.Drawing.Point(270, 151)
        Me.btnAddMask.Name = "btnAddMask"
        Me.btnAddMask.Size = New System.Drawing.Size(40, 19)
        Me.btnAddMask.TabIndex = 17
        Me.btnAddMask.Text = "Add"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(88, 77)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(0, 13)
        Me.lblValue.TabIndex = 16
        '
        'cbMasks
        '
        Me.cbMasks.Location = New System.Drawing.Point(91, 151)
        Me.cbMasks.Name = "cbMasks"
        '
        '
        '
        Me.cbMasks.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.cbMasks.Size = New System.Drawing.Size(173, 19)
        Me.cbMasks.TabIndex = 14
        Me.cbMasks.Text = "radComboBox2"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(41, 151)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(41, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Masks:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(22, 111)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 13)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Mask Type:"
        '
        'cbMaskType
        '
        Me.cbMaskType.Location = New System.Drawing.Point(91, 111)
        Me.cbMaskType.Name = "cbMaskType"
        '
        '
        '
        Me.cbMaskType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.cbMaskType.Size = New System.Drawing.Size(173, 19)
        Me.cbMaskType.TabIndex = 11
        Me.cbMaskType.Text = "radComboBox1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(69, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Masked Edit:"
        '
        'meDemo
        '
        Me.meDemo.Culture = Nothing
        Me.meDemo.Location = New System.Drawing.Point(91, 46)
        Me.meDemo.Mask = "P"
        Me.meDemo.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.meDemo.Name = "meDemo"
        Me.meDemo.Size = New System.Drawing.Size(219, 20)
        Me.meDemo.TabIndex = 9
        Me.meDemo.Text = "0.00 %"
        Me.meDemo.Value = "0"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Transparent
        Me.groupBox2.Controls.Add(Me.btnUseContainer)
        Me.groupBox2.Controls.Add(Me.tbContainer)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.tbMultiLine)
        Me.groupBox2.Location = New System.Drawing.Point(12, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(327, 195)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Text Box"
        '
        'btnUseContainer
        '
        Me.btnUseContainer.AllowShowFocusCues = True
        Me.btnUseContainer.Location = New System.Drawing.Point(133, 155)
        Me.btnUseContainer.Name = "btnUseContainer"
        Me.btnUseContainer.Size = New System.Drawing.Size(146, 23)
        Me.btnUseContainer.TabIndex = 10
        Me.btnUseContainer.Text = "Use Container"
        '
        'tbContainer
        '
        Me.tbContainer.Location = New System.Drawing.Point(84, 131)
        Me.tbContainer.Name = "tbContainer"
        Me.tbContainer.Size = New System.Drawing.Size(195, 18)
        Me.tbContainer.TabIndex = 9
        CType(Me.tbContainer.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 131)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Container:"
        '
        'tbMultiLine
        '
        Me.tbMultiLine.AutoCompleteCustomSource.AddRange(New String() {"Mr.", "Mrs.", "Ms."})
        Me.tbMultiLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbMultiLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.tbMultiLine.Location = New System.Drawing.Point(19, 19)
        Me.tbMultiLine.Multiline = True
        Me.tbMultiLine.Name = "tbMultiLine"
        '
        '
        '
        Me.tbMultiLine.RootElement.StretchVertically = True
        Me.tbMultiLine.Size = New System.Drawing.Size(260, 105)
        Me.tbMultiLine.TabIndex = 7
        Me.tbMultiLine.WordWrap = False
        '
        'groupBox3
        '
        Me.groupBox3.BackColor = System.Drawing.Color.Transparent
        Me.groupBox3.Controls.Add(Me.radDateTimePicker1)
        Me.groupBox3.Location = New System.Drawing.Point(356, 12)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(327, 87)
        Me.groupBox3.TabIndex = 11
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Date Time Picker"
        '
        'radDateTimePicker1
        '
        Me.radDateTimePicker1.AutoSize = True
        Me.radDateTimePicker1.Checked = True
        Me.radDateTimePicker1.CustomFormat = "yyyy MMMM dd h:m:s tt"
        Me.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.radDateTimePicker1.Location = New System.Drawing.Point(16, 20)
        Me.radDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.radDateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.radDateTimePicker1.Name = "radDateTimePicker1"
        Me.radDateTimePicker1.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.radDateTimePicker1.Size = New System.Drawing.Size(192, 22)
        Me.radDateTimePicker1.TabIndex = 0
        Me.radDateTimePicker1.Text = "radDateTimePicker1"
        Me.radDateTimePicker1.Value = New Date(2008, 12, 30, 11, 45, 56, 271)
        '
        'groupBox4
        '
        Me.groupBox4.BackColor = System.Drawing.Color.Transparent
        Me.groupBox4.Controls.Add(Me.btnChangeColor)
        Me.groupBox4.Controls.Add(Me.pnlColor)
        Me.groupBox4.Location = New System.Drawing.Point(356, 225)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(327, 195)
        Me.groupBox4.TabIndex = 12
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Color Dialog"
        '
        'btnChangeColor
        '
        Me.btnChangeColor.AllowShowFocusCues = True
        Me.btnChangeColor.Location = New System.Drawing.Point(222, 157)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(87, 19)
        Me.btnChangeColor.TabIndex = 18
        Me.btnChangeColor.Text = "Change Color"
        '
        'pnlColor
        '
        Me.pnlColor.BackColor = System.Drawing.Color.White
        Me.pnlColor.Location = New System.Drawing.Point(18, 26)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(291, 125)
        Me.pnlColor.TabIndex = 0
        '
        'radColorDialog1
        '
        Me.radColorDialog1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0, 1, 1)
        '
        'groupBox5
        '
        Me.groupBox5.BackColor = System.Drawing.Color.Transparent
        Me.groupBox5.Controls.Add(Me.radProgressBar1)
        Me.groupBox5.Controls.Add(Me.lblSpin)
        Me.groupBox5.Controls.Add(Me.radSpinEditor1)
        Me.groupBox5.Location = New System.Drawing.Point(356, 120)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(327, 87)
        Me.groupBox5.TabIndex = 12
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Spin Editor"
        '
        'radProgressBar1
        '
        Me.radProgressBar1.Dash = False
        Me.radProgressBar1.Location = New System.Drawing.Point(106, 47)
        Me.radProgressBar1.Name = "radProgressBar1"
        Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
        Me.radProgressBar1.SeparatorWidth = 4
        Me.radProgressBar1.Size = New System.Drawing.Size(203, 30)
        Me.radProgressBar1.StepWidth = 13
        Me.radProgressBar1.TabIndex = 2
        Me.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpin
        '
        Me.lblSpin.Location = New System.Drawing.Point(106, 19)
        Me.lblSpin.Name = "lblSpin"
        Me.lblSpin.Size = New System.Drawing.Size(55, 14)
        Me.lblSpin.TabIndex = 1
        Me.lblSpin.Text = "radLabel1"
        '
        'radSpinEditor1
        '
        Me.radSpinEditor1.BackColor = System.Drawing.Color.White
        Me.radSpinEditor1.Location = New System.Drawing.Point(18, 21)
        Me.radSpinEditor1.Name = "radSpinEditor1"
        '
        '
        '
        Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radSpinEditor1.ShowBorder = True
        Me.radSpinEditor1.Size = New System.Drawing.Size(60, 20)
        Me.radSpinEditor1.TabIndex = 0
        Me.radSpinEditor1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 432)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "Editors"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.btnAddMask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaskType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meDemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.btnUseContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMultiLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.radDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        CType(Me.btnChangeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cbMaskType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents meDemo As Telerik.WinControls.UI.RadMaskedEditBox
    Private WithEvents cbMasks As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Private WithEvents btnAddMask As Telerik.WinControls.UI.RadButton
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUseContainer As Telerik.WinControls.UI.RadButton
    Friend WithEvents tbContainer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents tbMultiLine As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private pnlColor As Telerik.WinControls.UI.RadPanel
    Friend WithEvents radColorDialog1 As Telerik.WinControls.RadColorDialog
    Private WithEvents btnChangeColor As Telerik.WinControls.UI.RadButton
    Friend WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSpin As Telerik.WinControls.UI.RadLabel
    Private WithEvents radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents radProgressBar1 As Telerik.WinControls.UI.RadProgressBar

End Class
