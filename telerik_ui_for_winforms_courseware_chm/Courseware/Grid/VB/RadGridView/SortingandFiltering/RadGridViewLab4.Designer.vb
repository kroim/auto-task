Imports Microsoft.VisualBasic
Imports System
Namespace _04_SortingandFiltering
	Public Partial Class RadGridViewLab4
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
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn
            Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDecimalColumn7 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewDecimalColumn8 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDecimalColumn9 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn
            Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn
            Dim GridViewDateTimeColumn3 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn
            Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
            Dim GridViewDateTimeColumn4 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn
            Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
            Me.productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.productDataSet1 = New ProductDataSet1
            Me.productTableAdapter = New ProductDataSet1TableAdapters.ProductTableAdapter
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            GridViewDecimalColumn1.DataType = GetType(Integer)
            GridViewDecimalColumn1.FieldName = "ProductID"
            GridViewDecimalColumn1.HeaderText = "ProductID"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "ProductID"
            GridViewDecimalColumn1.ReadOnly = True
            GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn2.DataType = GetType(Short)
            GridViewDecimalColumn2.FieldName = "ReorderPoint"
            GridViewDecimalColumn2.HeaderText = "ReorderPoint"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Name = "ReorderPoint"
            GridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn2.Width = 123
            GridViewTextBoxColumn1.FieldName = "Name"
            GridViewTextBoxColumn1.HeaderText = "Name"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "Name"
            GridViewTextBoxColumn1.Width = 88
            GridViewTextBoxColumn2.FieldName = "ProductNumber"
            GridViewTextBoxColumn2.HeaderText = "ProductNumber"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "ProductNumber"
            GridViewTextBoxColumn2.Width = 88
            GridViewCheckBoxColumn1.FieldName = "MakeFlag"
            GridViewCheckBoxColumn1.HeaderText = "MakeFlag"
            GridViewCheckBoxColumn1.IsAutoGenerated = True
            GridViewCheckBoxColumn1.Name = "MakeFlag"
            GridViewCheckBoxColumn1.Width = 88
            GridViewCheckBoxColumn2.FieldName = "FinishedGoodsFlag"
            GridViewCheckBoxColumn2.HeaderText = "FinishedGoodsFlag"
            GridViewCheckBoxColumn2.IsAutoGenerated = True
            GridViewCheckBoxColumn2.Name = "FinishedGoodsFlag"
            GridViewCheckBoxColumn2.Width = 88
            GridViewTextBoxColumn3.FieldName = "Color"
            GridViewTextBoxColumn3.HeaderText = "Color"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Color"
            GridViewTextBoxColumn3.Width = 88
            GridViewDecimalColumn3.DataType = GetType(Short)
            GridViewDecimalColumn3.FieldName = "SafetyStockLevel"
            GridViewDecimalColumn3.HeaderText = "SafetyStockLevel"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.Name = "SafetyStockLevel"
            GridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn3.Width = 88
            GridViewDecimalColumn4.FieldName = "StandardCost"
            GridViewDecimalColumn4.HeaderText = "StandardCost"
            GridViewDecimalColumn4.IsAutoGenerated = True
            GridViewDecimalColumn4.Name = "StandardCost"
            GridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn4.Width = 88
            GridViewDecimalColumn5.FieldName = "ListPrice"
            GridViewDecimalColumn5.HeaderText = "ListPrice"
            GridViewDecimalColumn5.IsAutoGenerated = True
            GridViewDecimalColumn5.Name = "ListPrice"
            GridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn5.Width = 88
            GridViewTextBoxColumn4.FieldName = "Size"
            GridViewTextBoxColumn4.HeaderText = "Size"
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.IsVisible = False
            GridViewTextBoxColumn4.Name = "Size"
            GridViewTextBoxColumn5.FieldName = "SizeUnitMeasureCode"
            GridViewTextBoxColumn5.HeaderText = "SizeUnitMeasureCode"
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.IsVisible = False
            GridViewTextBoxColumn5.Name = "SizeUnitMeasureCode"
            GridViewTextBoxColumn6.FieldName = "WeightUnitMeasureCode"
            GridViewTextBoxColumn6.HeaderText = "WeightUnitMeasureCode"
            GridViewTextBoxColumn6.IsAutoGenerated = True
            GridViewTextBoxColumn6.IsVisible = False
            GridViewTextBoxColumn6.Name = "WeightUnitMeasureCode"
            GridViewDecimalColumn6.FieldName = "Weight"
            GridViewDecimalColumn6.HeaderText = "Weight"
            GridViewDecimalColumn6.IsAutoGenerated = True
            GridViewDecimalColumn6.IsVisible = False
            GridViewDecimalColumn6.Name = "Weight"
            GridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn7.DataType = GetType(Integer)
            GridViewDecimalColumn7.FieldName = "DaysToManufacture"
            GridViewDecimalColumn7.HeaderText = "DaysToManufacture"
            GridViewDecimalColumn7.IsAutoGenerated = True
            GridViewDecimalColumn7.Name = "DaysToManufacture"
            GridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn7.Width = 88
            GridViewTextBoxColumn7.FieldName = "ProductLine"
            GridViewTextBoxColumn7.HeaderText = "ProductLine"
            GridViewTextBoxColumn7.IsAutoGenerated = True
            GridViewTextBoxColumn7.Name = "ProductLine"
            GridViewTextBoxColumn7.Width = 88
            GridViewTextBoxColumn8.FieldName = "Class"
            GridViewTextBoxColumn8.HeaderText = "Class"
            GridViewTextBoxColumn8.IsAutoGenerated = True
            GridViewTextBoxColumn8.Name = "Class"
            GridViewTextBoxColumn8.Width = 133
            GridViewTextBoxColumn9.FieldName = "Style"
            GridViewTextBoxColumn9.HeaderText = "Style"
            GridViewTextBoxColumn9.IsAutoGenerated = True
            GridViewTextBoxColumn9.IsVisible = False
            GridViewTextBoxColumn9.Name = "Style"
            GridViewDecimalColumn8.DataType = GetType(Integer)
            GridViewDecimalColumn8.FieldName = "ProductSubcategoryID"
            GridViewDecimalColumn8.HeaderText = "ProductSubcategoryID"
            GridViewDecimalColumn8.IsAutoGenerated = True
            GridViewDecimalColumn8.IsVisible = False
            GridViewDecimalColumn8.Name = "ProductSubcategoryID"
            GridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDecimalColumn9.DataType = GetType(Integer)
            GridViewDecimalColumn9.FieldName = "ProductModelID"
            GridViewDecimalColumn9.HeaderText = "ProductModelID"
            GridViewDecimalColumn9.IsAutoGenerated = True
            GridViewDecimalColumn9.IsVisible = False
            GridViewDecimalColumn9.Name = "ProductModelID"
            GridViewDecimalColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewDateTimeColumn1.FieldName = "SellStartDate"
            GridViewDateTimeColumn1.HeaderText = "SellStartDate"
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.IsVisible = False
            GridViewDateTimeColumn1.Name = "SellStartDate"
            GridViewDateTimeColumn2.FieldName = "SellEndDate"
            GridViewDateTimeColumn2.HeaderText = "SellEndDate"
            GridViewDateTimeColumn2.IsAutoGenerated = True
            GridViewDateTimeColumn2.IsVisible = False
            GridViewDateTimeColumn2.Name = "SellEndDate"
            GridViewDateTimeColumn3.FieldName = "DiscontinuedDate"
            GridViewDateTimeColumn3.HeaderText = "DiscontinuedDate"
            GridViewDateTimeColumn3.IsAutoGenerated = True
            GridViewDateTimeColumn3.IsVisible = False
            GridViewDateTimeColumn3.Name = "DiscontinuedDate"
            GridViewTextBoxColumn10.DataType = GetType(System.Guid)
            GridViewTextBoxColumn10.FieldName = "rowguid"
            GridViewTextBoxColumn10.HeaderText = "rowguid"
            GridViewTextBoxColumn10.IsAutoGenerated = True
            GridViewTextBoxColumn10.IsVisible = False
            GridViewTextBoxColumn10.Name = "rowguid"
            GridViewDateTimeColumn4.FieldName = "ModifiedDate"
            GridViewDateTimeColumn4.HeaderText = "ModifiedDate"
            GridViewDateTimeColumn4.IsAutoGenerated = True
            GridViewDateTimeColumn4.IsVisible = False
            GridViewDateTimeColumn4.Name = "ModifiedDate"
            Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewCheckBoxColumn1, GridViewCheckBoxColumn2, GridViewTextBoxColumn3, GridViewDecimalColumn3, GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewDecimalColumn6, GridViewDecimalColumn7, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewDecimalColumn8, GridViewDecimalColumn9, GridViewDateTimeColumn1, GridViewDateTimeColumn2, GridViewDateTimeColumn3, GridViewTextBoxColumn10, GridViewDateTimeColumn4})
            Me.radGridView1.MasterTemplate.DataSource = Me.productBindingSource
            Me.radGridView1.MasterTemplate.EnableFiltering = True
            SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
            SortDescriptor1.PropertyName = "ReorderPoint"
            Me.radGridView1.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.radGridView1.Size = New System.Drawing.Size(1146, 402)
            Me.radGridView1.TabIndex = 0
            Me.radGridView1.Text = "radGridViewPreview"
            '
            'productBindingSource
            '
            Me.productBindingSource.DataMember = "Product"
            Me.productBindingSource.DataSource = Me.productDataSet1
            '
            'productDataSet1
            '
            Me.productDataSet1.DataSetName = "ProductDataSet1"
            Me.productDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'productTableAdapter
            '
            Me.productTableAdapter.ClearBeforeFill = True
            '
            'RadGridViewLab4
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1146, 402)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "RadGridViewLab4"
            Me.Text = "RadGridView Lab 4"
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private productDataSet1 As ProductDataSet1
		Private productBindingSource As System.Windows.Forms.BindingSource
        Private productTableAdapter As ProductDataSet1TableAdapters.ProductTableAdapter
	End Class
End Namespace

