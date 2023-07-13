namespace _05_HierarchyDesigner
{
    partial class RadGridViewLab5
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadGridViewLab5));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn7 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn8 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            this.employeeDepartmentHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet1 = new _05_HierarchyDesigner.AdventureWorksDataSet1();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new _05_HierarchyDesigner.AdventureWorksDataSet1TableAdapters.DepartmentTableAdapter();
            this.employeeDepartmentHistoryTableAdapter = new _05_HierarchyDesigner.AdventureWorksDataSet1TableAdapters.EmployeeDepartmentHistoryTableAdapter();
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDepartmentHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDepartmentHistoryBindingSource
            // 
            this.employeeDepartmentHistoryBindingSource.DataMember = "EmployeeDepartmentHistory";
            this.employeeDepartmentHistoryBindingSource.DataSource = this.adventureWorksDataSet1;
            // 
            // adventureWorksDataSet1
            // 
            this.adventureWorksDataSet1.DataSetName = "AdventureWorksDataSet1";
            this.adventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.radGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn5.DataType = typeof(short);
            gridViewDecimalColumn5.FieldName = "DepartmentID";
            gridViewDecimalColumn5.HeaderText = "DepartmentID";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "DepartmentID";
            gridViewDecimalColumn5.ReadOnly = true;
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn5.Width = 193;
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Name";
            gridViewTextBoxColumn3.Width = 193;
            gridViewTextBoxColumn4.FieldName = "GroupName";
            gridViewTextBoxColumn4.HeaderText = "GroupName";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "GroupName";
            gridViewTextBoxColumn4.Width = 193;
            gridViewDateTimeColumn5.FieldName = "ModifiedDate";
            gridViewDateTimeColumn5.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn5.HeaderText = "ModifiedDate";
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.Name = "ModifiedDate";
            gridViewDateTimeColumn5.Width = 193;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn5});
            this.radGridView1.MasterTemplate.DataSource = this.departmentBindingSource;
            this.radGridView1.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.radGridView1.Name = "radGridView1";
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ChildTemplate = this.gridViewTemplate1;
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            gridViewRelation1.ParentTemplate = this.radGridView1.MasterTemplate;
            this.radGridView1.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(811, 342);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridViewPreview";
            this.radGridView1.ThemeName = "ControlDefault";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.adventureWorksDataSet1;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDepartmentHistoryTableAdapter
            // 
            this.employeeDepartmentHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // gridViewTemplate1
            // 
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.FieldName = "EmployeeID";
            gridViewDecimalColumn6.HeaderText = "EmployeeID";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "EmployeeID";
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn7.DataType = typeof(short);
            gridViewDecimalColumn7.FieldName = "DepartmentID";
            gridViewDecimalColumn7.HeaderText = "DepartmentID";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "DepartmentID";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn8.DataType = typeof(byte);
            gridViewDecimalColumn8.FieldName = "ShiftID";
            gridViewDecimalColumn8.HeaderText = "ShiftID";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "ShiftID";
            gridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn6.FieldName = "StartDate";
            gridViewDateTimeColumn6.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn6.HeaderText = "StartDate";
            gridViewDateTimeColumn6.IsAutoGenerated = true;
            gridViewDateTimeColumn6.Name = "StartDate";
            gridViewDateTimeColumn7.FieldName = "EndDate";
            gridViewDateTimeColumn7.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn7.HeaderText = "EndDate";
            gridViewDateTimeColumn7.IsAutoGenerated = true;
            gridViewDateTimeColumn7.Name = "EndDate";
            gridViewDateTimeColumn8.FieldName = "ModifiedDate";
            gridViewDateTimeColumn8.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn8.HeaderText = "ModifiedDate";
            gridViewDateTimeColumn8.IsAutoGenerated = true;
            gridViewDateTimeColumn8.Name = "ModifiedDate";
            this.gridViewTemplate1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDateTimeColumn6,
            gridViewDateTimeColumn7,
            gridViewDateTimeColumn8});
            this.gridViewTemplate1.DataSource = this.employeeDepartmentHistoryBindingSource;
            // 
            // RadGridViewLab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 342);
            this.Controls.Add(this.MasterTemplate);
            this.Name = "RadGridViewLab5";
            this.Text = "RadGridView Lab 5";
            this.Load += new System.EventHandler(this.RadGridViewLab5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDepartmentHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private AdventureWorksDataSet1 adventureWorksDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private _05_HierarchyDesigner.AdventureWorksDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource employeeDepartmentHistoryBindingSource;
        private _05_HierarchyDesigner.AdventureWorksDataSet1TableAdapters.EmployeeDepartmentHistoryTableAdapter employeeDepartmentHistoryTableAdapter;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
    }
}

