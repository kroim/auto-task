namespace SimpleBinding
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tbAlbumID = new Telerik.WinControls.UI.RadTextBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new SimpleBinding.MusicCollectionDataSet();
            this.tbAlbumName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.albumsTableAdapter = new SimpleBinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlbumID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlbumName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(51, 14);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Album ID";
            // 
            // tbAlbumID
            // 
            this.tbAlbumID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "AlbumID", true));
            this.tbAlbumID.Location = new System.Drawing.Point(116, 14);
            this.tbAlbumID.Name = "tbAlbumID";
            this.tbAlbumID.Size = new System.Drawing.Size(100, 20);
            this.tbAlbumID.TabIndex = 1;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAlbumName
            // 
            this.tbAlbumName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "AlbumName", true));
            this.tbAlbumName.Location = new System.Drawing.Point(116, 45);
            this.tbAlbumName.Name = "tbAlbumName";
            this.tbAlbumName.Size = new System.Drawing.Size(100, 20);
            this.tbAlbumName.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 45);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 14);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Album Name";
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 241);
            this.Controls.Add(this.tbAlbumName);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.tbAlbumID);
            this.Controls.Add(this.radLabel1);
            this.Name = "Form1";
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlbumID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlbumName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox tbAlbumID;
        private Telerik.WinControls.UI.RadTextBox tbAlbumName;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private SimpleBinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
    }
}

