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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnRadForm = new Telerik.WinControls.UI.CommandBarButton();
            this.btnShapedForm = new Telerik.WinControls.UI.CommandBarButton();
            this.btnRadRibbonForm = new Telerik.WinControls.UI.CommandBarButton();
            this.btnRadAboutBox = new Telerik.WinControls.UI.CommandBarButton();
            this.btnRadMessageBox = new Telerik.WinControls.UI.CommandBarButton();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 263);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(528, 28);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2007Silver";
            // 
            // lblStatus
            // 
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, true);
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(528, 70);
            this.radCommandBar1.TabIndex = 2;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnRadForm,
            this.btnShapedForm,
            this.btnRadRibbonForm,
            this.btnRadAboutBox,
            this.btnRadMessageBox});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnRadForm
            // 
            this.btnRadForm.AccessibleDescription = "RadForm";
            this.btnRadForm.AccessibleName = "RadForm";
            this.btnRadForm.DisplayName = "commandBarButton1";
            this.btnRadForm.DrawText = true;
            this.btnRadForm.Image = ((System.Drawing.Image)(resources.GetObject("btnRadForm.Image")));
            this.btnRadForm.Name = "btnRadForm";
            this.btnRadForm.Text = "RadForm";
            this.btnRadForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRadForm.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRadForm.VisibleInOverflowMenu = true;
            this.btnRadForm.Click += new System.EventHandler(this.btnRadForm_Click);
            // 
            // btnShapedForm
            // 
            this.btnShapedForm.AccessibleDescription = "ShapedForm";
            this.btnShapedForm.AccessibleName = "ShapedForm";
            this.btnShapedForm.DisplayName = "commandBarButton2";
            this.btnShapedForm.DrawText = true;
            this.btnShapedForm.Image = ((System.Drawing.Image)(resources.GetObject("btnShapedForm.Image")));
            this.btnShapedForm.Name = "btnShapedForm";
            this.btnShapedForm.Text = "ShapedForm";
            this.btnShapedForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShapedForm.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnShapedForm.VisibleInOverflowMenu = true;
            this.btnShapedForm.Click += new System.EventHandler(this.btnShapedForm_Click);
            // 
            // btnRadRibbonForm
            // 
            this.btnRadRibbonForm.AccessibleDescription = "RadRibbonForm";
            this.btnRadRibbonForm.AccessibleName = "RadRibbonForm";
            this.btnRadRibbonForm.DisplayName = "commandBarButton3";
            this.btnRadRibbonForm.DrawText = true;
            this.btnRadRibbonForm.Image = ((System.Drawing.Image)(resources.GetObject("btnRadRibbonForm.Image")));
            this.btnRadRibbonForm.Name = "btnRadRibbonForm";
            this.btnRadRibbonForm.Text = "RadRibbonForm";
            this.btnRadRibbonForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRadRibbonForm.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRadRibbonForm.VisibleInOverflowMenu = true;
            this.btnRadRibbonForm.Click += new System.EventHandler(this.btnRadRibbonForm_Click);
            // 
            // btnRadAboutBox
            // 
            this.btnRadAboutBox.AccessibleDescription = "RadAboutBox";
            this.btnRadAboutBox.AccessibleName = "RadAboutBox";
            this.btnRadAboutBox.DisplayName = "commandBarButton4";
            this.btnRadAboutBox.DrawText = true;
            this.btnRadAboutBox.Image = ((System.Drawing.Image)(resources.GetObject("btnRadAboutBox.Image")));
            this.btnRadAboutBox.Name = "btnRadAboutBox";
            this.btnRadAboutBox.Text = "RadAboutBox";
            this.btnRadAboutBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRadAboutBox.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRadAboutBox.VisibleInOverflowMenu = true;
            this.btnRadAboutBox.Click += new System.EventHandler(this.btnRadAboutBox_Click);
            // 
            // btnRadMessageBox
            // 
            this.btnRadMessageBox.AccessibleDescription = "RadMessageBox";
            this.btnRadMessageBox.AccessibleName = "RadMessageBox";
            this.btnRadMessageBox.DisplayName = "commandBarButton5";
            this.btnRadMessageBox.DrawText = true;
            this.btnRadMessageBox.Image = ((System.Drawing.Image)(resources.GetObject("btnRadMessageBox.Image")));
            this.btnRadMessageBox.Name = "btnRadMessageBox";
            this.btnRadMessageBox.Text = "RadMessageBox";
            this.btnRadMessageBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRadMessageBox.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRadMessageBox.VisibleInOverflowMenu = true;
            this.btnRadMessageBox.Click += new System.EventHandler(this.btnRadMessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 291);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "Form1";
            this.Text = "Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnRadForm;
        private Telerik.WinControls.UI.CommandBarButton btnShapedForm;
        private Telerik.WinControls.UI.CommandBarButton btnRadRibbonForm;
        private Telerik.WinControls.UI.CommandBarButton btnRadAboutBox;
        private Telerik.WinControls.UI.CommandBarButton btnRadMessageBox;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
    }
}

