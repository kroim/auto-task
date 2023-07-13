namespace _08_VirtualMode
{
    partial class RadGridViewLab8
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
          this.timer1 = new System.Windows.Forms.Timer(this.components);
          this.adventureWorksDataSet = new _08_VirtualMode.AdventureWorksDataSet();
          this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.contactTableAdapter = new _08_VirtualMode.AdventureWorksDataSetTableAdapters.ContactTableAdapter();
          ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
          this.SuspendLayout();
          // 
          // radGridView1
          // 
          this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.radGridView1.Location = new System.Drawing.Point(0, 0);
          this.radGridView1.Name = "radGridView1";
          this.radGridView1.Size = new System.Drawing.Size(804, 351);
          this.radGridView1.TabIndex = 0;
          this.radGridView1.CellValueNeeded += new Telerik.WinControls.UI.GridViewCellValueEventHandler(this.radGridView1_CellValueNeeded_1);
          // 
          // timer1
          // 
          this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
          // 
          // adventureWorksDataSet
          // 
          this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
          this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // contactBindingSource
          // 
          this.contactBindingSource.DataMember = "Contact";
          this.contactBindingSource.DataSource = this.adventureWorksDataSet;
          // 
          // contactTableAdapter
          // 
          this.contactTableAdapter.ClearBeforeFill = true;
          // 
          // RadGridViewLab8
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(804, 351);
          this.Controls.Add(this.radGridView1);
          this.Name = "RadGridViewLab8";
          this.Text = "RadGridView Lab 8";
          this.Load += new System.EventHandler(this.RadGridViewLab8_Load);
          ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Timer timer1;
        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private _08_VirtualMode.AdventureWorksDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
    }
}

