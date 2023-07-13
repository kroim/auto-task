namespace _06_HierarcyAuto
{
    partial class RadGridViewLab6
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
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadGridViewLab6));
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.adventureWorksDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet = new _06_HierarcyAuto.AdventureWorksDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.DataSource = this.adventureWorksDataSetBindingSource;
            this.radGridView1.Name = "radGridView1";
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            gridViewRelation1.ParentTemplate = this.radGridView1.MasterTemplate;
            gridViewRelation1.RelationName = "Vendor_ProductVendor";
            this.radGridView1.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.radGridView1.Size = new System.Drawing.Size(804, 350);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // adventureWorksDataSetBindingSource
            // 
            this.adventureWorksDataSetBindingSource.DataSource = this.adventureWorksDataSet;
            this.adventureWorksDataSetBindingSource.Position = 0;
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RadGridViewLab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 350);
            this.Controls.Add(this.radGridView1);
            this.Name = "RadGridViewLab6";
            this.Text = "RadGridView Lab 6";
            this.Load += new System.EventHandler(this.RadGridViewLab6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource adventureWorksDataSetBindingSource;
    }
}

