namespace WindowsFormsApplication1
{
    partial class RadForm1
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
            this.albumsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new WindowsFormsApplication1.MusicCollectionDataSet();
            this.albumsTableAdapter = new WindowsFormsApplication1.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // albumsBindingSource1
            // 
            this.albumsBindingSource1.DataMember = "Albums";
            this.albumsBindingSource1.DataSource = this.musicCollectionDataSet;
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // radListControl1
            // 
            this.radListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radListControl1.AutoSizeItems = true;
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.DataSource = this.albumsBindingSource1;
            this.radListControl1.DisplayMember = "AlbumName";
            this.radListControl1.ItemHeight = 18;
            this.radListControl1.Location = new System.Drawing.Point(12, 12);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(375, 255);
            this.radListControl1.TabIndex = 1;
            this.radListControl1.ValueMember = "AlbumID";
            this.radListControl1.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.radListControl1_ItemDataBound);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 279);
            this.Controls.Add(this.radListControl1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource albumsBindingSource1;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private WindowsFormsApplication1.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private Telerik.WinControls.UI.RadListControl radListControl1;
    }
}

