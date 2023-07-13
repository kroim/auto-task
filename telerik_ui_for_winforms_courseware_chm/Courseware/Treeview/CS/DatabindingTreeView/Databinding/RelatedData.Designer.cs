namespace Databinding
{
    partial class RelatedData
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Databinding.MusicCollectionDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new Databinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new Databinding.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter();
            this.songsTableAdapter = new Databinding.MusicCollectionDataSetTableAdapters.SongsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.Transparent;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.Location = new System.Drawing.Point(15, 15);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(268, 249);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.musicCollectionDataSet;
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
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // RelatedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 279);
            this.Controls.Add(this.radTreeView1);
            this.Name = "RelatedData";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "RelatedData ";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RelatedData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private Databinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private Databinding.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private Databinding.MusicCollectionDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
    }
}

