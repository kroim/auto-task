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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Introduction.MusicCollectionDataSet();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.albumsTableAdapter = new Introduction.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListControl1
            // 
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.DataSource = this.albumsBindingSource;
            this.radListControl1.DisplayMember = "AlbumName";
            this.radListControl1.ItemHeight = 18;
            this.radListControl1.Location = new System.Drawing.Point(13, 66);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(259, 87);
            this.radListControl1.TabIndex = 0;
            this.radListControl1.ThemeName = "Desert";
            this.radListControl1.ValueMember = "AlbumID";
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
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(13, 44);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 16);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "RadListControl";
            this.radLabel1.ThemeName = "Desert";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(290, 41);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(81, 17);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "RadTreeView";
            this.radLabel2.ThemeName = "Desert";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoCompleteDisplayMember = "AlbumName";
            this.radDropDownList1.AutoCompleteValueMember = "AlbumID";
            this.radDropDownList1.DataSource = this.albumsBindingSource;
            this.radDropDownList1.DisplayMember = "AlbumName";
            this.radDropDownList1.Location = new System.Drawing.Point(13, 193);
            this.radDropDownList1.MaxDropDownItems = 3;
            this.radDropDownList1.Name = "radDropDownList1";
            // 
            // 
            // 
            this.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(259, 22);
            this.radDropDownList1.TabIndex = 5;
            this.radDropDownList1.ThemeName = "Desert";
            this.radDropDownList1.ValueMember = "AlbumID";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(13, 271);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(83, 14);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "RadGridView";
            this.radLabel3.ThemeName = "Desert";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(13, 291);
            // 
            // radGridView1
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "AlbumID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "AlbumID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "AlbumID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.FieldName = "AlbumName";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "AlbumName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "AlbumName";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ArtistID";
            gridViewDecimalColumn2.HeaderText = "ArtistID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ArtistID";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "ImageIndex";
            gridViewDecimalColumn3.HeaderText = "ImageIndex";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ImageIndex";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewImageColumn1.DataType = typeof(byte[]);
            gridViewImageColumn1.FieldName = "Image";
            gridViewImageColumn1.HeaderText = "Image";
            gridViewImageColumn1.IsAutoGenerated = true;
            gridViewImageColumn1.Name = "Image";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewImageColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.albumsBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(1);
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(1);
            this.radGridView1.Size = new System.Drawing.Size(536, 150);
            this.radGridView1.TabIndex = 7;
            this.radGridView1.Text = "radGridViewPreview";
            this.radGridView1.ThemeName = "Desert";
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(13, 173);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(121, 14);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "RadDropDownList";
            this.radLabel4.ThemeName = "Desert";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(13, 450);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(71, 16);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "RadTextBox";
            this.radLabel5.ThemeName = "Desert";
            // 
            // radTextBox1
            // 
            this.radTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.albumsBindingSource, "AlbumID", true));
            this.radTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "AlbumName", true));
            this.radTextBox1.Location = new System.Drawing.Point(13, 471);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(181, 20);
            this.radTextBox1.TabIndex = 9;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.Text = "radTextBox1";
            this.radTextBox1.ThemeName = "Desert";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.albumsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(559, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.Transparent;
            this.radTreeView1.DataSource = this.albumsBindingSource;
            this.radTreeView1.DisplayMember = "AlbumName";
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.Location = new System.Drawing.Point(278, 66);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.Size = new System.Drawing.Size(270, 205);
            this.radTreeView1.TabIndex = 11;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "Desert";
            this.radTreeView1.ValueMember = "AlbumID";
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 506);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radListControl1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Data Binding";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private Introduction.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
    }
}

