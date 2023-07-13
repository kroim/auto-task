Imports Microsoft.VisualBasic
Imports System
Namespace _15_CustomCells
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
            Me.productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.adventureWorksDataSet1 = New AdventureWorksDataSet1
            Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement
            Me.btnShowDialog = New Telerik.WinControls.UI.RadButtonElement
            Me.radToolStripItem1 = New Telerik.WinControls.UI.RadToolStripItem
            Me.productTableAdapter = New AdventureWorksDataSet1TableAdapters.ProductTableAdapter
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
            CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.adventureWorksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'productBindingSource
            '
            Me.productBindingSource.DataMember = "Product"
            Me.productBindingSource.DataSource = Me.adventureWorksDataSet1
            '
            'adventureWorksDataSet1
            '
            Me.adventureWorksDataSet1.DataSetName = "AdventureWorksDataSet1"
            Me.adventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'radCheckBoxElement1
            '
            Me.radCheckBoxElement1.AccessibleDescription = "radCheckBoxElement1"
            Me.radCheckBoxElement1.AccessibleName = "radCheckBoxElement1"
            Me.radCheckBoxElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radCheckBoxElement1.CanFocus = True
            Me.radCheckBoxElement1.Checked = False
            Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
            Me.radCheckBoxElement1.ShowBorder = False
            Me.radCheckBoxElement1.Text = "radCheckBoxElement1"
            Me.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'btnShowDialog
            '
            Me.btnShowDialog.AccessibleDescription = "Show Dialog"
            Me.btnShowDialog.AccessibleName = "Show Dialog"
            Me.btnShowDialog.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnShowDialog.CanFocus = True
            Me.btnShowDialog.Name = "btnShowDialog"
            Me.btnShowDialog.Text = "Show Dialog"
            Me.btnShowDialog.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radToolStripItem1
            '
            Me.radToolStripItem1.AccessibleDescription = "radToolStripItem1"
            Me.radToolStripItem1.AccessibleName = "radToolStripItem1"
            Me.radToolStripItem1.Class = "ToolStripItem"
            Me.radToolStripItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnShowDialog})
            Me.radToolStripItem1.Key = "0"
            Me.radToolStripItem1.MinSize = New System.Drawing.Size(25, 21)
            Me.radToolStripItem1.Name = "radToolStripItem1"
            Me.radToolStripItem1.Text = "radToolStripItem1"
            Me.radToolStripItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'productTableAdapter
            '
            Me.productTableAdapter.ClearBeforeFill = True
            '
            'radGridView1
            '
            Me.radGridView1.BackColor = System.Drawing.SystemColors.Control
            Me.radGridView1.Cursor = System.Windows.Forms.Cursors.Default
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            'radGridView1
            '
            GridViewDecimalColumn1.DataType = GetType(Integer)
            GridViewDecimalColumn1.FieldName = "ProductID"
            GridViewDecimalColumn1.FormatString = ""
            GridViewDecimalColumn1.HeaderText = "ProductID"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.Name = "ProductID"
            GridViewDecimalColumn1.ReadOnly = True
            GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewTextBoxColumn1.FieldName = "Name"
            GridViewTextBoxColumn1.FormatString = ""
            GridViewTextBoxColumn1.HeaderText = "Name"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "Name"
            GridViewTextBoxColumn2.FieldName = "Color"
            GridViewTextBoxColumn2.FormatString = ""
            GridViewTextBoxColumn2.HeaderText = "Color"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Color"
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2})
            Me.radGridView1.MasterTemplate.DataSource = Me.productBindingSource
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.radGridView1.Size = New System.Drawing.Size(506, 349)
            Me.radGridView1.TabIndex = 2
            Me.radGridView1.Text = "radGridViewPreview"
            Me.radGridView1.ThemeName = "ControlDefault"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(506, 349)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "Form1"
            Me.Text = "Custom Elements"
            CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.adventureWorksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

	#End Region

        Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
	Private btnShowDialog As Telerik.WinControls.UI.RadButtonElement
	Private radToolStripItem1 As Telerik.WinControls.UI.RadToolStripItem
	Private adventureWorksDataSet1 As AdventureWorksDataSet1
	Private productBindingSource As System.Windows.Forms.BindingSource
        Private productTableAdapter As AdventureWorksDataSet1TableAdapters.ProductTableAdapter
	Private radGridView1 As Telerik.WinControls.UI.RadGridView
  End Class
End Namespace

