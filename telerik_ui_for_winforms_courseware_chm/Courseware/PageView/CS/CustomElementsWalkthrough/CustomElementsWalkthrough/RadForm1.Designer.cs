namespace GettingStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radToggleButton1 = new Telerik.WinControls.UI.RadToggleButton();
            this.ilDriveTypes = new System.Windows.Forms.ImageList(this.components);
            this.lblDriveType = new Telerik.WinControls.UI.RadLabel();
            this.lblVolumeLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.lblTotalSpace = new Telerik.WinControls.UI.RadLabel();
            this.lblDriveFormat = new Telerik.WinControls.UI.RadLabel();
            this.lblDriveName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDriveType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVolumeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDriveFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDriveName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Controls.Add(this.radToggleButton1);
            this.radPanel1.Controls.Add(this.lblDriveType);
            this.radPanel1.Controls.Add(this.lblVolumeLabel);
            this.radPanel1.Controls.Add(this.radLabel10);
            this.radPanel1.Controls.Add(this.lblTotalSpace);
            this.radPanel1.Controls.Add(this.lblDriveFormat);
            this.radPanel1.Controls.Add(this.lblDriveName);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.btnSearch);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(602, 108);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Desert";
            // 
            // radToggleButton1
            // 
            this.radToggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radToggleButton1.ImageKey = "DisconnectedDrive.png";
            this.radToggleButton1.ImageList = this.ilDriveTypes;
            this.radToggleButton1.Location = new System.Drawing.Point(374, 60);
            this.radToggleButton1.Name = "radToggleButton1";
            this.radToggleButton1.Size = new System.Drawing.Size(210, 40);
            this.radToggleButton1.TabIndex = 6;
            this.radToggleButton1.Text = "Show Disconnected Drives";
            this.radToggleButton1.ThemeName = "Desert";
            this.radToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radToggleButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btnShow_ToggleStateChanged);
            // 
            // ilDriveTypes
            // 
            this.ilDriveTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDriveTypes.ImageStream")));
            this.ilDriveTypes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDriveTypes.Images.SetKeyName(0, "UnknownDrive.png");
            this.ilDriveTypes.Images.SetKeyName(1, "EmptyDrive.png");
            this.ilDriveTypes.Images.SetKeyName(2, "3.5_Disk_Drive.png");
            this.ilDriveTypes.Images.SetKeyName(3, "Hard_Drive.png");
            this.ilDriveTypes.Images.SetKeyName(4, "Network.png");
            this.ilDriveTypes.Images.SetKeyName(5, "CD_ROM.png");
            this.ilDriveTypes.Images.SetKeyName(6, "ram.png");
            this.ilDriveTypes.Images.SetKeyName(7, "search.png");
            this.ilDriveTypes.Images.SetKeyName(8, "DisconnectedDrive.png");
            // 
            // lblDriveType
            // 
            this.lblDriveType.Location = new System.Drawing.Point(249, 38);
            this.lblDriveType.Name = "lblDriveType";
            this.lblDriveType.Size = new System.Drawing.Size(12, 16);
            this.lblDriveType.TabIndex = 5;
            this.lblDriveType.Text = "x";
            // 
            // lblVolumeLabel
            // 
            this.lblVolumeLabel.Location = new System.Drawing.Point(249, 14);
            this.lblVolumeLabel.Name = "lblVolumeLabel";
            this.lblVolumeLabel.Size = new System.Drawing.Size(12, 16);
            this.lblVolumeLabel.TabIndex = 3;
            this.lblVolumeLabel.Text = "x";
            // 
            // radLabel10
            // 
            this.radLabel10.Location = new System.Drawing.Point(165, 38);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(63, 15);
            this.radLabel10.TabIndex = 4;
            this.radLabel10.Text = "<html><b>Drive Type</html>";
            // 
            // lblTotalSpace
            // 
            this.lblTotalSpace.Location = new System.Drawing.Point(90, 62);
            this.lblTotalSpace.Name = "lblTotalSpace";
            this.lblTotalSpace.Size = new System.Drawing.Size(12, 16);
            this.lblTotalSpace.TabIndex = 3;
            this.lblTotalSpace.Text = "x";
            // 
            // lblDriveFormat
            // 
            this.lblDriveFormat.Location = new System.Drawing.Point(90, 38);
            this.lblDriveFormat.Name = "lblDriveFormat";
            this.lblDriveFormat.Size = new System.Drawing.Size(12, 16);
            this.lblDriveFormat.TabIndex = 3;
            this.lblDriveFormat.Text = "x";
            // 
            // lblDriveName
            // 
            this.lblDriveName.BackColor = System.Drawing.Color.Transparent;
            this.lblDriveName.Location = new System.Drawing.Point(90, 14);
            this.lblDriveName.Name = "lblDriveName";
            this.lblDriveName.Size = new System.Drawing.Size(12, 16);
            this.lblDriveName.TabIndex = 3;
            this.lblDriveName.Text = "x";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(165, 14);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(77, 15);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "<html><b>Volume Label</html>";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(15, 62);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(69, 15);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "<html><b>Total Space</html>";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(15, 38);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(74, 15);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "<html><b>Drive Format</html>";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(15, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 15);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "<html><b>Drive Name</html>";
            this.radLabel1.ThemeName = "Desert";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ImageKey = "search.png";
            this.btnSearch.ImageList = this.ilDriveTypes;
            this.btnSearch.Location = new System.Drawing.Point(374, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 40);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Find Max Free Space";
            this.btnSearch.ThemeName = "Desert";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radPageView1
            // 
            this.radPageView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageView1.Location = new System.Drawing.Point(12, 130);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(602, 179);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "Desert";
            this.radPageView1.SelectedPageChanging += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.radPageView1_SelectedPageChanging);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 316);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radPanel1);
            this.MinimumSize = new System.Drawing.Size(630, 350);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Drive Info";
            this.ThemeName = "Desert";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDriveType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVolumeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDriveFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDriveName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lblDriveName;
        private Telerik.WinControls.UI.RadLabel lblDriveFormat;
        private Telerik.WinControls.UI.RadLabel lblTotalSpace;
        private Telerik.WinControls.UI.RadLabel lblVolumeLabel;
        private Telerik.WinControls.UI.RadLabel lblDriveType;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private System.Windows.Forms.ImageList ilDriveTypes;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadToggleButton radToggleButton1;
    }
}

