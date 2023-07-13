Imports Microsoft.VisualBasic
Imports System
Namespace _13_ConditionalFormatting
  Public Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	  If disposing AndAlso (Not components Is Nothing) Then
		components.Dispose()
	  End If
	  MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn
            Me.adventureWorksDataSet = New AdventureWorksDataSet
            Me.creditCardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.creditCardTableAdapter = New AdventureWorksDataSetTableAdapters.CreditCardTableAdapter
            Me.cbEnableAlternatingRowStyle = New Telerik.WinControls.UI.RadCheckBoxElement
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
            Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
            Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
            Me.toggleButtonEnableAlternationRowColor = New Telerik.WinControls.UI.CommandBarToggleButton
            CType(Me.adventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.creditCardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'adventureWorksDataSet
            '
            Me.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
            Me.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'creditCardBindingSource
            '
            Me.creditCardBindingSource.DataMember = "CreditCard"
            Me.creditCardBindingSource.DataSource = Me.adventureWorksDataSet
            '
            'creditCardTableAdapter
            '
            Me.creditCardTableAdapter.ClearBeforeFill = True
            '
            'cbEnableAlternatingRowStyle
            '
            Me.cbEnableAlternatingRowStyle.AccessibleDescription = "EnableAlternatingRowStyle"
            Me.cbEnableAlternatingRowStyle.AccessibleName = "EnableAlternatingRowStyle"
            Me.cbEnableAlternatingRowStyle.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.cbEnableAlternatingRowStyle.CanFocus = True
            Me.cbEnableAlternatingRowStyle.Checked = False
            Me.cbEnableAlternatingRowStyle.Name = "cbEnableAlternatingRowStyle"
            Me.cbEnableAlternatingRowStyle.ShowBorder = False
            Me.cbEnableAlternatingRowStyle.Text = "EnableAlternatingRowStyle"
            Me.cbEnableAlternatingRowStyle.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGridView1
            '
            Me.radGridView1.BackColor = System.Drawing.SystemColors.Control
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.radGridView1.Location = New System.Drawing.Point(0, 30)
            '
            'radGridView1
            '
            GridViewDecimalColumn1.DataType = GetType(Integer)
            GridViewDecimalColumn1.FieldName = "CreditCardID"
            GridViewDecimalColumn1.FormatInfo = New System.Globalization.CultureInfo("")
            GridViewDecimalColumn1.HeaderText = "CreditCardID"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "CreditCardID"
            GridViewDecimalColumn1.ReadOnly = True
            GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn1.VisibleInColumnChooser = False
            GridViewTextBoxColumn1.FieldName = "CardType"
            GridViewTextBoxColumn1.FormatInfo = New System.Globalization.CultureInfo("")
            GridViewTextBoxColumn1.FormatString = ""
            GridViewTextBoxColumn1.HeaderText = "Card Type"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "CardType"
            GridViewTextBoxColumn2.FieldName = "CardNumber"
            GridViewTextBoxColumn2.FormatInfo = New System.Globalization.CultureInfo("")
            GridViewTextBoxColumn2.FormatString = ""
            GridViewTextBoxColumn2.HeaderText = "CardNumber"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "CardNumber"
            GridViewDecimalColumn2.DataType = GetType(Byte)
            GridViewDecimalColumn2.FieldName = "ExpMonth"
            GridViewDecimalColumn2.FormatInfo = New System.Globalization.CultureInfo("")
            GridViewDecimalColumn2.FormatString = ""
            GridViewDecimalColumn2.HeaderText = "ExpMonth"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Name = "ExpMonth"
            GridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn3.DataType = GetType(Short)
            GridViewDecimalColumn3.FieldName = "ExpYear"
            GridViewDecimalColumn3.FormatInfo = New System.Globalization.CultureInfo("")
            GridViewDecimalColumn3.FormatString = ""
            GridViewDecimalColumn3.HeaderText = "ExpYear"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.Name = "ExpYear"
            GridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDateTimeColumn1.FieldName = "ModifiedDate"
            GridViewDateTimeColumn1.FormatInfo = New System.Globalization.CultureInfo("")
            GridViewDateTimeColumn1.HeaderText = "ModifiedDate"
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.IsVisible = False
            GridViewDateTimeColumn1.Name = "ModifiedDate"
            GridViewDateTimeColumn1.Width = 133
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDateTimeColumn1})
            Me.radGridView1.MasterTemplate.DataSource = Me.creditCardBindingSource
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.radGridView1.Size = New System.Drawing.Size(506, 319)
            Me.radGridView1.TabIndex = 2
            Me.radGridView1.Text = "radGridViewPreview"
            Me.radGridView1.ThemeName = "ControlDefault"
            '
            'RadCommandBar1
            '
            Me.RadCommandBar1.AutoSize = True
            Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
            Me.RadCommandBar1.Name = "RadCommandBar1"
            Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            Me.RadCommandBar1.Size = New System.Drawing.Size(506, 30)
            Me.RadCommandBar1.TabIndex = 0
            Me.RadCommandBar1.Text = "RadCommandBar1"
            '
            'CommandBarRowElement1
            '
            Me.CommandBarRowElement1.DisplayName = Nothing
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
            '
            'CommandBarStripElement1
            '
            Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
            Me.CommandBarStripElement1.FloatingForm = Nothing
            Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.toggleButtonEnableAlternationRowColor})
            Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
            Me.CommandBarStripElement1.Text = ""
            '
            'toggleButtonEnableAlternationRowColor
            '
            Me.toggleButtonEnableAlternationRowColor.AccessibleDescription = "Enable Alternating Row Color"
            Me.toggleButtonEnableAlternationRowColor.AccessibleName = "Enable Alternating Row Color"
            Me.toggleButtonEnableAlternationRowColor.DisplayName = "CommandBarToggleButton1"
            Me.toggleButtonEnableAlternationRowColor.DrawText = True
            Me.toggleButtonEnableAlternationRowColor.Image = Nothing
            Me.toggleButtonEnableAlternationRowColor.Name = "toggleButtonEnableAlternationRowColor"
            Me.toggleButtonEnableAlternationRowColor.Text = "Enable Alternating Row Color"
            Me.toggleButtonEnableAlternationRowColor.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.toggleButtonEnableAlternationRowColor.VisibleInOverflowMenu = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(506, 349)
            Me.Controls.Add(Me.radGridView1)
            Me.Controls.Add(Me.RadCommandBar1)
            Me.Name = "Form1"
            Me.Text = "Formatting"
            CType(Me.adventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.creditCardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private adventureWorksDataSet As AdventureWorksDataSet
        Private creditCardBindingSource As System.Windows.Forms.BindingSource
        Private creditCardTableAdapter As AdventureWorksDataSetTableAdapters.CreditCardTableAdapter
        Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
        Private WithEvents cbEnableAlternatingRowStyle As Telerik.WinControls.UI.RadCheckBoxElement
        Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents toggleButtonEnableAlternationRowColor As Telerik.WinControls.UI.CommandBarToggleButton
  End Class
End Namespace

