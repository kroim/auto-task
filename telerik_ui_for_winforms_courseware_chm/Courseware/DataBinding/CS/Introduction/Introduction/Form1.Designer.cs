namespace Introduction
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Introduction.MusicCollectionDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.albumsTableAdapter = new Introduction.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(0, 0);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(100, 20);
            this.radTextBox1.TabIndex = 12;
            this.radTextBox1.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 15);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "<html><b>RadListControl</html>";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(0, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(99, 15);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "<html><b>RadDropDownList</html>";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(0, 0);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(74, 15);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "<html><b>RadGridView</html>";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(0, 0);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(69, 15);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "<html><b>RadTextBox</html>";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(0, 0);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(76, 15);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "<html><b>RadTreeView</html>";
            // 
            // radListControl1
            // 
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.ItemHeight = 18;
            this.radListControl1.Location = new System.Drawing.Point(0, 0);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(120, 95);
            this.radListControl1.TabIndex = 7;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoCompleteDisplayMember = "AlbumName";
            this.radDropDownList1.DataSource = this.albumsBindingSource;
            this.radDropDownList1.DisplayMember = "AlbumName";
            this.radDropDownList1.DropDownHeight = 53;
            this.radDropDownList1.Location = new System.Drawing.Point(0, 0);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(106, 21);
            this.radDropDownList1.TabIndex = 6;
            this.radDropDownList1.Text = "radDropDownList1";
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
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(13, 257);
            // 
            // radGridView1
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "AlbumID";
            gridViewDecimalColumn1.HeaderText = "AlbumID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "AlbumID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 70;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ArtistID";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "ArtistID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ArtistID";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.FieldName = "AlbumName";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "AlbumName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "AlbumName";
            gridViewTextBoxColumn1.Width = 256;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "ImageIndex";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "ImageIndex";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "ImageIndex";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewImageColumn1.DataType = typeof(byte[]);
            gridViewImageColumn1.FieldName = "Image";
            gridViewImageColumn1.FormatString = "";
            gridViewImageColumn1.HeaderText = "Image";
            gridViewImageColumn1.IsAutoGenerated = true;
            gridViewImageColumn1.IsVisible = false;
            gridViewImageColumn1.Name = "Image";
            gridViewImageColumn1.VisibleInColumnChooser = false;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn3,
            gridViewImageColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.albumsBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(1);
            this.radGridView1.Size = new System.Drawing.Size(546, 150);
            this.radGridView1.TabIndex = 5;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Desert";
            // 
            // radTreeView1
            // 
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.Size = new System.Drawing.Size(150, 250);
            this.radTreeView1.TabIndex = 0;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 481);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radListControl1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTextBox1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private Introduction.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
    }
}