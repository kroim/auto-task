namespace _04_SortingandFiltering
{
    partial class RadGridViewLab4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet1 = new _04_SortingandFiltering.ProductDataSet1();
            this.productTableAdapter = new _04_SortingandFiltering.ProductDataSet1TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ProductID";
            gridViewDecimalColumn1.HeaderText = "ProductID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ProductID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.DataType = typeof(short);
            gridViewDecimalColumn2.FieldName = "ReorderPoint";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "ReorderPoint";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ReorderPoint";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.Width = 122;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 88;
            gridViewTextBoxColumn2.FieldName = "ProductNumber";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "ProductNumber";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ProductNumber";
            gridViewTextBoxColumn2.Width = 88;
            gridViewCheckBoxColumn1.FieldName = "MakeFlag";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "MakeFlag";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "MakeFlag";
            gridViewCheckBoxColumn1.Width = 88;
            gridViewCheckBoxColumn2.FieldName = "FinishedGoodsFlag";
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "FinishedGoodsFlag";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "FinishedGoodsFlag";
            gridViewCheckBoxColumn2.Width = 88;
            gridViewTextBoxColumn3.FieldName = "Color";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Color";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Color";
            gridViewTextBoxColumn3.Width = 88;
            gridViewDecimalColumn3.DataType = typeof(short);
            gridViewDecimalColumn3.FieldName = "SafetyStockLevel";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "SafetyStockLevel";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "SafetyStockLevel";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.Width = 88;
            gridViewDecimalColumn4.FieldName = "StandardCost";
            gridViewDecimalColumn4.FormatString = "";
            gridViewDecimalColumn4.HeaderText = "StandardCost";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "StandardCost";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn4.Width = 88;
            gridViewDecimalColumn5.FieldName = "ListPrice";
            gridViewDecimalColumn5.FormatString = "";
            gridViewDecimalColumn5.HeaderText = "ListPrice";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "ListPrice";
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn5.Width = 88;
            gridViewTextBoxColumn4.FieldName = "Size";
            gridViewTextBoxColumn4.HeaderText = "Size";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Size";
            gridViewTextBoxColumn5.FieldName = "SizeUnitMeasureCode";
            gridViewTextBoxColumn5.HeaderText = "SizeUnitMeasureCode";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "SizeUnitMeasureCode";
            gridViewTextBoxColumn6.FieldName = "WeightUnitMeasureCode";
            gridViewTextBoxColumn6.HeaderText = "WeightUnitMeasureCode";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "WeightUnitMeasureCode";
            gridViewDecimalColumn6.FieldName = "Weight";
            gridViewDecimalColumn6.HeaderText = "Weight";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "Weight";
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn7.DataType = typeof(int);
            gridViewDecimalColumn7.FieldName = "DaysToManufacture";
            gridViewDecimalColumn7.FormatString = "";
            gridViewDecimalColumn7.HeaderText = "DaysToManufacture";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "DaysToManufacture";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn7.Width = 88;
            gridViewTextBoxColumn7.FieldName = "ProductLine";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "ProductLine";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "ProductLine";
            gridViewTextBoxColumn7.Width = 88;
            gridViewTextBoxColumn8.FieldName = "Class";
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Class";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Class";
            gridViewTextBoxColumn8.Width = 134;
            gridViewTextBoxColumn9.FieldName = "Style";
            gridViewTextBoxColumn9.HeaderText = "Style";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "Style";
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.FieldName = "ProductSubcategoryID";
            gridViewDecimalColumn8.HeaderText = "ProductSubcategoryID";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "ProductSubcategoryID";
            gridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn9.DataType = typeof(int);
            gridViewDecimalColumn9.FieldName = "ProductModelID";
            gridViewDecimalColumn9.HeaderText = "ProductModelID";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.IsVisible = false;
            gridViewDecimalColumn9.Name = "ProductModelID";
            gridViewDecimalColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn1.FieldName = "SellStartDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "SellStartDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "SellStartDate";
            gridViewDateTimeColumn2.FieldName = "SellEndDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "SellEndDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "SellEndDate";
            gridViewDateTimeColumn3.FieldName = "DiscontinuedDate";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.HeaderText = "DiscontinuedDate";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.IsVisible = false;
            gridViewDateTimeColumn3.Name = "DiscontinuedDate";
            gridViewTextBoxColumn10.DataType = typeof(System.Guid);
            gridViewTextBoxColumn10.FieldName = "rowguid";
            gridViewTextBoxColumn10.HeaderText = "rowguid";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "rowguid";
            gridViewDateTimeColumn4.FieldName = "ModifiedDate";
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn4.HeaderText = "ModifiedDate";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.IsVisible = false;
            gridViewDateTimeColumn4.Name = "ModifiedDate";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn10,
            gridViewDateTimeColumn4});
            this.radGridView1.MasterTemplate.DataSource = this.productBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "ReorderPoint";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1146, 402);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridViewPreview";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDataSet1;
            // 
            // productDataSet1
            // 
            this.productDataSet1.DataSetName = "ProductDataSet1";
            this.productDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // RadGridViewLab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 402);
            this.Controls.Add(this.radGridView1);
            this.Name = "RadGridViewLab4";
            this.Text = "RadGridView Lab 4";
            this.Load += new System.EventHandler(this.RadGridViewLab4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private ProductDataSet1 productDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private _04_SortingandFiltering.ProductDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
    }
}

