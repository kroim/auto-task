﻿namespace Export
{
    partial class ExportCSV
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet = new ExportExcel.AdventureWorksDataSet();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnExportExcel = new Telerik.WinControls.UI.CommandBarButton();
            this.btnExportPDF = new Telerik.WinControls.UI.CommandBarButton();
            this.btnExportHTML = new Telerik.WinControls.UI.CommandBarButton();
            this.btnExportCSV = new Telerik.WinControls.UI.CommandBarButton();
            this.salesPersonTableAdapter = new ExportExcel.AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 30);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(System.Guid);
            gridViewTextBoxColumn1.FieldName = "rowguid";
            gridViewTextBoxColumn1.HeaderText = "rowguid";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "rowguid";
            gridViewDateTimeColumn1.FieldName = "ModifiedDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "ModifiedDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "ModifiedDate";
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "SalesPersonID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "SalesPersonID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "SalesPersonID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 132;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "TerritoryID";
            gridViewDecimalColumn2.HeaderText = "TerritoryID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "TerritoryID";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.FieldName = "SalesQuota";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "SalesQuota";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "SalesQuota";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.Width = 132;
            gridViewDecimalColumn4.FieldName = "Bonus";
            gridViewDecimalColumn4.FormatString = "";
            gridViewDecimalColumn4.HeaderText = "Bonus";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Bonus";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn4.Width = 132;
            gridViewDecimalColumn5.FieldName = "CommissionPct";
            gridViewDecimalColumn5.FormatString = "";
            gridViewDecimalColumn5.HeaderText = "CommissionPct";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "CommissionPct";
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn5.Width = 132;
            gridViewDecimalColumn6.FieldName = "SalesYTD";
            gridViewDecimalColumn6.FormatString = "";
            gridViewDecimalColumn6.HeaderText = "SalesYTD";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "SalesYTD";
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn6.Width = 132;
            gridViewDecimalColumn7.FieldName = "SalesLastYear";
            gridViewDecimalColumn7.FormatString = "";
            gridViewDecimalColumn7.HeaderText = "SalesLastYear";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "SalesLastYear";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn7.Width = 135;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7});
            this.radGridView1.MasterTemplate.DataSource = this.salesPersonBindingSource;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(811, 438);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(811, 30);
            this.radCommandBar1.TabIndex = 1;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnExportExcel,
            this.btnExportPDF,
            this.btnExportHTML,
            this.btnExportCSV});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = false;
            this.commandBarStripElement1.Text = "";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleDescription = "Export Excel";
            this.btnExportExcel.AccessibleName = "Export Excel";
            this.btnExportExcel.DisplayName = "commandBarButton1";
            this.btnExportExcel.DrawText = true;
            this.btnExportExcel.Image = null;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnExportExcel.VisibleInOverflowMenu = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.AccessibleDescription = "Export PDF";
            this.btnExportPDF.AccessibleName = "Export PDF";
            this.btnExportPDF.DisplayName = "commandBarButton2";
            this.btnExportPDF.DrawText = true;
            this.btnExportPDF.Image = null;
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnExportPDF.VisibleInOverflowMenu = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnExportHTML
            // 
            this.btnExportHTML.AccessibleDescription = "Export HTML";
            this.btnExportHTML.AccessibleName = "Export HTML";
            this.btnExportHTML.DisplayName = "commandBarButton3";
            this.btnExportHTML.DrawText = true;
            this.btnExportHTML.Image = null;
            this.btnExportHTML.Name = "btnExportHTML";
            this.btnExportHTML.Text = "Export HTML";
            this.btnExportHTML.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnExportHTML.VisibleInOverflowMenu = true;
            this.btnExportHTML.Click += new System.EventHandler(this.btnExportHTML_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.AccessibleDescription = "Export CSV";
            this.btnExportCSV.AccessibleName = "Export CSV";
            this.btnExportCSV.DisplayName = "commandBarButton4";
            this.btnExportCSV.DrawText = true;
            this.btnExportCSV.Image = null;
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnExportCSV.VisibleInOverflowMenu = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // ExportCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 468);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "ExportCSV";
            this.Text = "ExportCSV";
            this.Load += new System.EventHandler(this.ExportCSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnExportExcel;
        private Telerik.WinControls.UI.CommandBarButton btnExportPDF;
        private Telerik.WinControls.UI.CommandBarButton btnExportHTML;
        private Telerik.WinControls.UI.CommandBarButton btnExportCSV;
        private ExportExcel.AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private ExportExcel.AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
    }
}