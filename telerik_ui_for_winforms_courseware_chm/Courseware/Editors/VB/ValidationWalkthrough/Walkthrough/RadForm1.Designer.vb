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
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        Me.gbGiftOptions = New System.Windows.Forms.GroupBox
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.tbNote = New Telerik.WinControls.UI.RadTextBox
        Me.btnChooseColor = New Telerik.WinControls.UI.RadButton
        Me.cbGiftWrap = New Telerik.WinControls.UI.RadCheckBox
        Me.gbShipTo = New System.Windows.Forms.GroupBox
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.tbName = New Telerik.WinControls.UI.RadTextBox
        Me.meState = New Telerik.WinControls.UI.RadMaskedEditBox
        Me.meZip = New Telerik.WinControls.UI.RadMaskedEditBox
        Me.tbCity = New Telerik.WinControls.UI.RadTextBox
        Me.tbAddress = New Telerik.WinControls.UI.RadTextBox
        Me.radLabel10 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel8 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel7 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel9 = New Telerik.WinControls.UI.RadLabel
        Me.gbDelivery = New System.Windows.Forms.GroupBox
        Me.radLabel6 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel
        Me.dtDeliver = New Telerik.WinControls.UI.RadDateTimePicker
        Me.radLabel5 = New Telerik.WinControls.UI.RadLabel
        Me.seDeliver = New Telerik.WinControls.UI.RadSpinEditor
        Me.btnPlaceOrder = New Telerik.WinControls.UI.RadButton
        Me.radColorDialog1 = New Telerik.WinControls.RadColorDialog
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbGiftOptions.SuspendLayout()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChooseColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGiftWrap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbShipTo.SuspendLayout()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDelivery.SuspendLayout()
        CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDeliver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDeliver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlaceOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbGiftOptions
        '
        Me.gbGiftOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGiftOptions.BackColor = System.Drawing.Color.Transparent
        Me.gbGiftOptions.Controls.Add(Me.radLabel2)
        Me.gbGiftOptions.Controls.Add(Me.tbNote)
        Me.gbGiftOptions.Controls.Add(Me.btnChooseColor)
        Me.gbGiftOptions.Controls.Add(Me.cbGiftWrap)
        Me.gbGiftOptions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbGiftOptions.Location = New System.Drawing.Point(317, 149)
        Me.gbGiftOptions.Name = "gbGiftOptions"
        Me.gbGiftOptions.Size = New System.Drawing.Size(283, 117)
        Me.gbGiftOptions.TabIndex = 2
        Me.gbGiftOptions.TabStop = False
        Me.gbGiftOptions.Text = "Gift Options"
        '
        'radLabel2
        '
        Me.radLabel2.BackColor = System.Drawing.Color.Transparent
        Me.radLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel2.Location = New System.Drawing.Point(23, 47)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(31, 14)
        Me.radLabel2.TabIndex = 22
        Me.radLabel2.Text = "Note:"
        '
        'tbNote
        '
        Me.tbNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tbNote.Enabled = False
        Me.tbNote.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbNote.Location = New System.Drawing.Point(60, 47)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        '
        '
        '
        Me.tbNote.RootElement.StretchVertically = True
        Me.tbNote.RootElement.ToolTipText = "Enter a note for your gift"
        Me.tbNote.Size = New System.Drawing.Size(199, 52)
        Me.tbNote.TabIndex = 21
        Me.tbNote.Tag = "Gift wrap note"
        '
        'btnChooseColor
        '
        Me.btnChooseColor.AllowShowFocusCues = True
        Me.btnChooseColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChooseColor.Enabled = False
        Me.btnChooseColor.Location = New System.Drawing.Point(142, 18)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(117, 23)
        Me.btnChooseColor.TabIndex = 20
        Me.btnChooseColor.Tag = "Choose wrap color"
        Me.btnChooseColor.Text = "Choose Wrap Color"
        Me.btnChooseColor.ThemeName = "Office2007Silver"
        '
        'cbGiftWrap
        '
        Me.cbGiftWrap.AllowShowFocusCues = True
        Me.cbGiftWrap.BackColor = System.Drawing.Color.Transparent
        Me.cbGiftWrap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbGiftWrap.Location = New System.Drawing.Point(60, 20)
        Me.cbGiftWrap.Name = "cbGiftWrap"
        '
        '
        '
        Me.cbGiftWrap.RootElement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbGiftWrap.Size = New System.Drawing.Size(76, 17)
        Me.cbGiftWrap.TabIndex = 19
        Me.cbGiftWrap.Tag = "Gift Wrap"
        Me.cbGiftWrap.Text = "Gift Wrap?"
        Me.cbGiftWrap.ThemeName = "Office2007Silver"
        '
        'gbShipTo
        '
        Me.gbShipTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbShipTo.BackColor = System.Drawing.Color.Transparent
        Me.gbShipTo.Controls.Add(Me.radLabel1)
        Me.gbShipTo.Controls.Add(Me.tbName)
        Me.gbShipTo.Controls.Add(Me.meState)
        Me.gbShipTo.Controls.Add(Me.meZip)
        Me.gbShipTo.Controls.Add(Me.tbCity)
        Me.gbShipTo.Controls.Add(Me.tbAddress)
        Me.gbShipTo.Controls.Add(Me.radLabel10)
        Me.gbShipTo.Controls.Add(Me.radLabel8)
        Me.gbShipTo.Controls.Add(Me.radLabel7)
        Me.gbShipTo.Controls.Add(Me.radLabel9)
        Me.gbShipTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbShipTo.Location = New System.Drawing.Point(12, 12)
        Me.gbShipTo.Name = "gbShipTo"
        Me.gbShipTo.Size = New System.Drawing.Size(588, 126)
        Me.gbShipTo.TabIndex = 0
        Me.gbShipTo.TabStop = False
        Me.gbShipTo.Text = "Ship to"
        '
        'radLabel1
        '
        Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radLabel1.BackColor = System.Drawing.Color.Transparent
        Me.radLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel1.Location = New System.Drawing.Point(34, 25)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(38, 14)
        Me.radLabel1.TabIndex = 29
        Me.radLabel1.Text = "Name:"
        '
        'tbName
        '
        Me.tbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbName.Location = New System.Drawing.Point(78, 25)
        Me.tbName.Name = "tbName"
        Me.tbName.NullText = "<Enter Name>"
        '
        '
        '
        Me.tbName.RootElement.ToolTipText = "Enter a full name"
        Me.tbName.Size = New System.Drawing.Size(488, 20)
        Me.tbName.TabIndex = 20
        Me.tbName.Tag = "Full Name"
        '
        'meState
        '
        Me.meState.Culture = Nothing
        Me.meState.Location = New System.Drawing.Point(242, 82)
        Me.meState.Mask = "LL"
        Me.meState.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.meState.Name = "meState"
        Me.meState.NullText = "dd"
        '
        '
        '
        Me.meState.RootElement.ToolTipText = "Enter the ship to state"
        Me.meState.Size = New System.Drawing.Size(23, 20)
        Me.meState.TabIndex = 23
        Me.meState.Tag = "State"
        Me.meState.Text = "__"
        Me.meState.Value = ""
        '
        'meZip
        '
        Me.meZip.Culture = Nothing
        Me.meZip.Location = New System.Drawing.Point(318, 82)
        Me.meZip.Mask = "99999-9999"
        Me.meZip.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.meZip.Name = "meZip"
        '
        '
        '
        Me.meZip.RootElement.ToolTipText = "enter the ship to zip code"
        Me.meZip.Size = New System.Drawing.Size(68, 20)
        Me.meZip.TabIndex = 24
        Me.meZip.Tag = "Zip"
        Me.meZip.Text = "_____-____"
        Me.meZip.Value = ""
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(78, 82)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.NullText = "<Enter City>"
        '
        '
        '
        Me.tbCity.RootElement.ToolTipText = "Enter the ship to city"
        Me.tbCity.Size = New System.Drawing.Size(100, 20)
        Me.tbCity.TabIndex = 22
        Me.tbCity.Tag = "City"
        '
        'tbAddress
        '
        Me.tbAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAddress.Location = New System.Drawing.Point(78, 52)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.NullText = "<Enter Address>"
        '
        '
        '
        Me.tbAddress.RootElement.ToolTipText = "Enter the ship to address"
        Me.tbAddress.Size = New System.Drawing.Size(488, 20)
        Me.tbAddress.TabIndex = 21
        Me.tbAddress.Tag = "Address"
        '
        'radLabel10
        '
        Me.radLabel10.BackColor = System.Drawing.Color.Transparent
        Me.radLabel10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel10.Location = New System.Drawing.Point(289, 88)
        Me.radLabel10.Name = "radLabel10"
        Me.radLabel10.Size = New System.Drawing.Size(23, 14)
        Me.radLabel10.TabIndex = 28
        Me.radLabel10.Text = "Zip:"
        '
        'radLabel8
        '
        Me.radLabel8.BackColor = System.Drawing.Color.Transparent
        Me.radLabel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel8.Location = New System.Drawing.Point(202, 88)
        Me.radLabel8.Name = "radLabel8"
        Me.radLabel8.Size = New System.Drawing.Size(34, 14)
        Me.radLabel8.TabIndex = 27
        Me.radLabel8.Text = "State:"
        '
        'radLabel7
        '
        Me.radLabel7.BackColor = System.Drawing.Color.Transparent
        Me.radLabel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel7.Location = New System.Drawing.Point(45, 88)
        Me.radLabel7.Name = "radLabel7"
        Me.radLabel7.Size = New System.Drawing.Size(27, 14)
        Me.radLabel7.TabIndex = 26
        Me.radLabel7.Text = "City:"
        '
        'radLabel9
        '
        Me.radLabel9.BackColor = System.Drawing.Color.Transparent
        Me.radLabel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel9.Location = New System.Drawing.Point(23, 58)
        Me.radLabel9.Name = "radLabel9"
        Me.radLabel9.Size = New System.Drawing.Size(49, 14)
        Me.radLabel9.TabIndex = 25
        Me.radLabel9.Text = "Address:"
        '
        'gbDelivery
        '
        Me.gbDelivery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDelivery.BackColor = System.Drawing.Color.Transparent
        Me.gbDelivery.Controls.Add(Me.radLabel6)
        Me.gbDelivery.Controls.Add(Me.radLabel3)
        Me.gbDelivery.Controls.Add(Me.dtDeliver)
        Me.gbDelivery.Controls.Add(Me.radLabel5)
        Me.gbDelivery.Controls.Add(Me.seDeliver)
        Me.gbDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbDelivery.Location = New System.Drawing.Point(12, 149)
        Me.gbDelivery.Name = "gbDelivery"
        Me.gbDelivery.Size = New System.Drawing.Size(299, 117)
        Me.gbDelivery.TabIndex = 1
        Me.gbDelivery.TabStop = False
        Me.gbDelivery.Text = "Deliver By"
        '
        'radLabel6
        '
        Me.radLabel6.BackColor = System.Drawing.Color.Transparent
        Me.radLabel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel6.Location = New System.Drawing.Point(20, 40)
        Me.radLabel6.Name = "radLabel6"
        Me.radLabel6.Size = New System.Drawing.Size(24, 14)
        Me.radLabel6.TabIndex = 22
        Me.radLabel6.Text = "or..."
        '
        'radLabel3
        '
        Me.radLabel3.BackColor = System.Drawing.Color.Transparent
        Me.radLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel3.Location = New System.Drawing.Point(20, 60)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(58, 14)
        Me.radLabel3.TabIndex = 21
        Me.radLabel3.Text = "Deliver by:"
        '
        'dtDeliver
        '
        Me.dtDeliver.AutoSize = True
        Me.dtDeliver.Checked = True
        Me.dtDeliver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtDeliver.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtDeliver.Location = New System.Drawing.Point(108, 60)
        Me.dtDeliver.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtDeliver.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtDeliver.Name = "dtDeliver"
        Me.dtDeliver.NullDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtDeliver.RootElement.ToolTipText = "Enter a week day delivery date"
        Me.dtDeliver.Size = New System.Drawing.Size(170, 22)
        Me.dtDeliver.TabIndex = 19
        Me.dtDeliver.Tag = "Deliver by"
        Me.dtDeliver.Text = "radDateTimePicker1"
        Me.dtDeliver.Value = New Date(2008, 12, 22, 17, 0, 54, 361)
        '
        'radLabel5
        '
        Me.radLabel5.BackColor = System.Drawing.Color.Transparent
        Me.radLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radLabel5.Location = New System.Drawing.Point(20, 20)
        Me.radLabel5.Name = "radLabel5"
        Me.radLabel5.Size = New System.Drawing.Size(79, 14)
        Me.radLabel5.TabIndex = 20
        Me.radLabel5.Text = "Business Days"
        '
        'seDeliver
        '
        Me.seDeliver.BackColor = System.Drawing.Color.White
        Me.seDeliver.CausesValidation = False
        Me.seDeliver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.seDeliver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.seDeliver.Location = New System.Drawing.Point(108, 20)
        Me.seDeliver.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.seDeliver.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.seDeliver.Name = "seDeliver"
        '
        '
        '
        Me.seDeliver.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.seDeliver.ShowBorder = True
        Me.seDeliver.Size = New System.Drawing.Size(57, 20)
        Me.seDeliver.TabIndex = 18
        Me.seDeliver.Tag = "Business Days"
        Me.seDeliver.Text = "radSpinEditor1"
        Me.seDeliver.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.AllowShowFocusCues = True
        Me.btnPlaceOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlaceOrder.Location = New System.Drawing.Point(497, 276)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(103, 42)
        Me.btnPlaceOrder.TabIndex = 4
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.ThemeName = "Office2007Silver"
        '
        'radColorDialog1
        '
        Me.radColorDialog1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0, 1, 1)
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 330)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.gbGiftOptions)
        Me.Controls.Add(Me.gbShipTo)
        Me.Controls.Add(Me.gbDelivery)
        Me.MinimumSize = New System.Drawing.Size(630, 350)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.MinSize = New System.Drawing.Size(630, 350)
        Me.Text = "Checkout"
        Me.ThemeName = "Office2007Silver"
        Me.gbGiftOptions.ResumeLayout(False)
        Me.gbGiftOptions.PerformLayout()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChooseColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGiftWrap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbShipTo.ResumeLayout(False)
        Me.gbShipTo.PerformLayout()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDelivery.ResumeLayout(False)
        Me.gbDelivery.PerformLayout()
        CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDeliver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDeliver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlaceOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents gbGiftOptions As System.Windows.Forms.GroupBox
    Friend WithEvents gbShipTo As System.Windows.Forms.GroupBox
    Friend WithEvents gbDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlaceOrder As Telerik.WinControls.UI.RadButton
    Friend WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents meState As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents meZip As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents tbCity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents tbAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents radLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtDeliver As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents radLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seDeliver As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents radLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbNote As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnChooseColor As Telerik.WinControls.UI.RadButton
    Friend WithEvents cbGiftWrap As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents radColorDialog1 As Telerik.WinControls.RadColorDialog
    Friend WithEvents errorProvider1 As System.Windows.Forms.ErrorProvider
End Class
