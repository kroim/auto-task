namespace WorkingWithNodesWalkThrough
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
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.miOpen = new Telerik.WinControls.UI.RadMenuItem();
            this.miClose = new Telerik.WinControls.UI.RadMenuItem();
            this.miExit = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tvReflection = new Telerik.WinControls.UI.RadTreeView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.lblDetail = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvReflection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Fuchsia;
            this.ilIcons.Images.SetKeyName(0, "library");
            this.ilIcons.Images.SetKeyName(1, "class");
            this.ilIcons.Images.SetKeyName(2, "property");
            this.ilIcons.Images.SetKeyName(3, "method");
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(499, 20);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "File";
            this.radMenuItem1.AccessibleName = "File";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miOpen,
            this.miClose,
            this.miExit});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // miOpen
            // 
            this.miOpen.AccessibleDescription = "Open";
            this.miOpen.AccessibleName = "Open";
            this.miOpen.Name = "miOpen";
            this.miOpen.Text = "Open";
            this.miOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miClose
            // 
            this.miClose.AccessibleDescription = "Close";
            this.miClose.AccessibleName = "Close";
            this.miClose.Name = "miClose";
            this.miClose.Text = "Close";
            this.miClose.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miClose.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miExit
            // 
            this.miExit.AccessibleDescription = "Exit";
            this.miExit.AccessibleName = "Exit";
            this.miExit.Name = "miExit";
            this.miExit.Text = "Exit";
            this.miExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 515);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(499, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "";
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.tvReflection);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 20);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(499, 380);
            this.radPanel1.TabIndex = 2;
            // 
            // tvReflection
            // 
            this.tvReflection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReflection.Location = new System.Drawing.Point(0, 0);
            this.tvReflection.Name = "tvReflection";
            this.tvReflection.Size = new System.Drawing.Size(499, 380);
            this.tvReflection.TabIndex = 0;
            this.tvReflection.Text = "radTreeView1";
            this.tvReflection.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.tvReflection_SelectedNodeChanged);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.lblDetail);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 406);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(499, 109);
            this.radPanel2.TabIndex = 3;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = false;
            this.lblDetail.BackColor = System.Drawing.SystemColors.Info;
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetail.Location = new System.Drawing.Point(0, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // 
            // 
            this.lblDetail.RootElement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDetail.Size = new System.Drawing.Size(499, 109);
            this.lblDetail.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 541);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radMenu1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TreeView";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvReflection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilIcons;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem miOpen;
        private Telerik.WinControls.UI.RadMenuItem miClose;
        private Telerik.WinControls.UI.RadMenuItem miExit;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadLabel lblDetail;
        private Telerik.WinControls.UI.RadTreeView tvReflection;
    }
}

