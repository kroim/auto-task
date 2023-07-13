namespace MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnNew = new Telerik.WinControls.UI.CommandBarButton();
            this.btnDelete = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarDropDownList1 = new Telerik.WinControls.UI.CommandBarDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 406);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(598, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 0;
            this.radStatusStrip1.Text = "radStatusStrip1";
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
            this.radCommandBar1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            // 
            // 
            // 
            this.radCommandBar1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(598, 56);
            this.radCommandBar1.TabIndex = 1;
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
            this.btnNew,
            this.btnDelete,
            this.commandBarDropDownList1});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "New";
            this.btnNew.AccessibleName = "New";
            this.btnNew.DisplayName = "commandBarButton1";
            this.btnNew.DrawText = true;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnNew.VisibleInOverflowMenu = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "Delete";
            this.btnDelete.AccessibleName = "Delete";
            this.btnDelete.DisplayName = "commandBarButton2";
            this.btnDelete.DrawText = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnDelete.VisibleInOverflowMenu = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // commandBarDropDownList1
            // 
            this.commandBarDropDownList1.DisplayName = "commandBarDropDownList1";
            this.commandBarDropDownList1.Name = "commandBarDropDownList1";
            this.commandBarDropDownList1.Text = "";
            this.commandBarDropDownList1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownList1.VisibleInOverflowMenu = true;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 432);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MDI Parent";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            this.MdiChildActivate += new System.EventHandler(this.RadForm1_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnNew;
        private Telerik.WinControls.UI.CommandBarButton btnDelete;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownList1;
    }
}

