namespace _15_CustomCells
{
    partial class Form1
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet1 = new _15_CustomCells.AdventureWorksDataSet1();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.btnShowDialog = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripItem1 = new Telerik.WinControls.UI.RadToolStripItem();
            this.productTableAdapter = new _15_CustomCells.AdventureWorksDataSet1TableAdapters.ProductTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksDataSet1;
            // 
            // adventureWorksDataSet1
            // 
            this.adventureWorksDataSet1.DataSetName = "AdventureWorksDataSet1";
            this.adventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.AccessibleDescription = "radCheckBoxElement1";
            this.radCheckBoxElement1.AccessibleName = "radCheckBoxElement1";
            this.radCheckBoxElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBoxElement1.CanFocus = true;
            this.radCheckBoxElement1.Checked = false;
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.radCheckBoxElement1.ShowBorder = false;
            this.radCheckBoxElement1.Text = "radCheckBoxElement1";
            this.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.AccessibleDescription = "Show Dialog";
            this.btnShowDialog.AccessibleName = "Show Dialog";
            this.btnShowDialog.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDialog.CanFocus = true;
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Text = "Show Dialog";
            this.btnShowDialog.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radToolStripItem1
            // 
            this.radToolStripItem1.AccessibleDescription = "radToolStripItem1";
            this.radToolStripItem1.AccessibleName = "radToolStripItem1";
            this.radToolStripItem1.Class = "ToolStripItem";
            this.radToolStripItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnShowDialog});
            this.radToolStripItem1.Key = "0";
            this.radToolStripItem1.MinSize = new System.Drawing.Size(25, 21);
            this.radToolStripItem1.Name = "radToolStripItem1";
            this.radToolStripItem1.Text = "radToolStripItem1";
            this.radToolStripItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ProductID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "ProductID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ProductID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn2.FieldName = "Color";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Color";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Color";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.productBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(506, 349);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridViewPreview";
            this.radGridView1.ThemeName = "ControlDefault";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 349);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Text = "Custom Elements";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.RadButtonElement btnShowDialog;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem1;
        private AdventureWorksDataSet1 adventureWorksDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private _15_CustomCells.AdventureWorksDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}

