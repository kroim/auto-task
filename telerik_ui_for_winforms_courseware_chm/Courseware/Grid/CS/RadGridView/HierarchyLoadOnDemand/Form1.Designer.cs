namespace HierarchyLoadOnDemand
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.adventureWorksDataSet = new HierarchyLoadOnDemand.AdventureWorksDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductTableAdapter();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productModelTableAdapter = new HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(284, 262);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataMember = "ProductModel";
            this.productModelBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // productModelTableAdapter
            // 
            this.productModelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productModelBindingSource;
        private HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter productModelTableAdapter;
    }
}

