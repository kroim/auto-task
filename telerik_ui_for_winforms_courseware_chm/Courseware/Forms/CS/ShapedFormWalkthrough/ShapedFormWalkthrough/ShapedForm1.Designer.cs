namespace ShapedFormWalkthrough
{
    partial class ShapedForm1
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
            this.donutShape1 = new Telerik.WinControls.Tests.DonutShape();
            this.pnlTitle = new Telerik.WinControls.UI.RadPanel();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new ShapedFormWalkthrough.MusicCollectionDataSet();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.albumsTableAdapter = new ShapedFormWalkthrough.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            this.btnNext = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnInfo = new Telerik.WinControls.UI.RadButton();
            this.btnBack = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // donutShape1
            // 
            this.donutShape1.Thickness = 100;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "AlbumName", true));
            this.pnlTitle.Location = new System.Drawing.Point(30, 168);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(200, 30);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Text = "radPanel1";
            this.pnlTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadPanelElement)(this.pnlTitle.GetChildAt(0))).Text = "radPanel1";
            ((Telerik.WinControls.UI.RadPanelElement)(this.pnlTitle.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.pnlTitle.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.pnlTitle.GetChildAt(0).GetChildAt(2))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicCollectionDataSet;
            this.albumsBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.albumsBindingSource_BindingComplete);
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 20;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(156, 204);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNext.GetChildAt(0))).Text = "Next";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNext.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Location = new System.Drawing.Point(113, 204);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnInfo.GetChildAt(0))).Text = "Info";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnInfo.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(70, 204);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBack.GetChildAt(0))).Text = "Back";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBack.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // ShapedForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 260);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTitle);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundImage", this.albumsBindingSource, "Image", true));
            this.Name = "ShapedForm1";
            this.Shape = this.donutShape1;
            this.Text = "ShapedForm1";
            this.Load += new System.EventHandler(this.ShapedForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Tests.DonutShape donutShape1;
        private Telerik.WinControls.UI.RadPanel pnlTitle;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private MusicCollectionDataSet musicCollectionDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private ShapedFormWalkthrough.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private Telerik.WinControls.UI.RadButton btnNext;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadButton btnInfo;
        private Telerik.WinControls.UI.RadButton btnBack;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
    }
}