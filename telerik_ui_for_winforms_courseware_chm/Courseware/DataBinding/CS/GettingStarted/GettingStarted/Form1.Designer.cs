namespace GettingStarted
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
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.musicCollectionDataSet = new GettingStarted.MusicCollectionDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new GettingStarted.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radListControl1
            // 
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.DataSource = this.albumsBindingSource;
            this.radListControl1.DisplayMember = "AlbumName";
            this.radListControl1.ItemHeight = 18;
            this.radListControl1.Location = new System.Drawing.Point(12, 14);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(254, 243);
            this.radListControl1.TabIndex = 0;
            this.radListControl1.Text = "radListControl1";
            this.radListControl1.ValueMember = "AlbumID";
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.radListControl1);
            this.Name = "Form1";
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radListControl1;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private GettingStarted.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;

    }
}

