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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarStripElement3 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnNew = new Telerik.WinControls.UI.CommandBarButton();
            this.btnOpen = new Telerik.WinControls.UI.CommandBarButton();
            this.btnSave = new Telerik.WinControls.UI.CommandBarButton();
            this.btnPrint = new Telerik.WinControls.UI.CommandBarButton();
            this.tbTwoSidedPrint = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.btnHelp = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "New.png");
            this.imageList1.Images.SetKeyName(1, "Open.png");
            this.imageList1.Images.SetKeyName(2, "Save.png");
            this.imageList1.Images.SetKeyName(3, "Print.png");
            this.imageList1.Images.SetKeyName(4, "Help.png");
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.ImageList = this.imageList1;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1,
            this.commandBarRowElement2});
            this.radCommandBar1.Size = new System.Drawing.Size(425, 105);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1,
            this.commandBarStripElement2});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.ImageList = this.imageList1;
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 308);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(425, 26);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 203);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.DisplayName = null;
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement3});
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.FloatingForm = null;
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnPrint,
            this.tbTwoSidedPrint});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            this.commandBarStripElement2.Text = "";
            // 
            // commandBarStripElement3
            // 
            this.commandBarStripElement3.DisplayName = "commandBarStripElement3";
            this.commandBarStripElement3.FloatingForm = null;
            this.commandBarStripElement3.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnHelp});
            this.commandBarStripElement3.Name = "commandBarStripElement3";
            this.commandBarStripElement3.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "commandBarButton1";
            this.btnNew.AccessibleName = "commandBarButton1";
            this.btnNew.DisplayName = "commandBarButton1";
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageIndex = 0;
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "commandBarButton1";
            this.btnNew.ToolTipText = "File New";
            this.btnNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnNew.VisibleInOverflowMenu = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleDescription = "commandBarButton2";
            this.btnOpen.AccessibleName = "commandBarButton2";
            this.btnOpen.DisplayName = "commandBarButton2";
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageIndex = 1;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Text = "commandBarButton2";
            this.btnOpen.ToolTipText = "File Open";
            this.btnOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnOpen.VisibleInOverflowMenu = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "commandBarButton3";
            this.btnSave.AccessibleName = "commandBarButton3";
            this.btnSave.DisplayName = "commandBarButton3";
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 2;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "commandBarButton3";
            this.btnSave.ToolTipText = "File Save";
            this.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnSave.VisibleInOverflowMenu = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleDescription = "commandBarButton1";
            this.btnPrint.AccessibleName = "commandBarButton1";
            this.btnPrint.DisplayName = "commandBarButton1";
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "commandBarButton1";
            this.btnPrint.ToolTipText = "Print";
            this.btnPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnPrint.VisibleInOverflowMenu = true;
            // 
            // tbTwoSidedPrint
            // 
            this.tbTwoSidedPrint.AccessibleDescription = "Two Sided Print";
            this.tbTwoSidedPrint.AccessibleName = "Two Sided Print";
            this.tbTwoSidedPrint.DisplayName = "commandBarToggleButton1";
            this.tbTwoSidedPrint.DrawText = true;
            this.tbTwoSidedPrint.Image = null;
            this.tbTwoSidedPrint.Name = "tbTwoSidedPrint";
            this.tbTwoSidedPrint.Text = "Two Sided Print";
            this.tbTwoSidedPrint.ToolTipText = "Two Sided Print";
            this.tbTwoSidedPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.tbTwoSidedPrint.VisibleInOverflowMenu = true;
            // 
            // btnHelp
            // 
            this.btnHelp.AccessibleDescription = "commandBarButton1";
            this.btnHelp.AccessibleName = "commandBarButton1";
            this.btnHelp.DisplayName = "commandBarButton1";
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageIndex = 4;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Text = "commandBarButton1";
            this.btnHelp.ToolTipText = "Help";
            this.btnHelp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnHelp.VisibleInOverflowMenu = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 334);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement3;
        private Telerik.WinControls.UI.CommandBarButton btnNew;
        private Telerik.WinControls.UI.CommandBarButton btnOpen;
        private Telerik.WinControls.UI.CommandBarButton btnSave;
        private Telerik.WinControls.UI.CommandBarButton btnPrint;
        private Telerik.WinControls.UI.CommandBarToggleButton tbTwoSidedPrint;
        private Telerik.WinControls.UI.CommandBarButton btnHelp;
    }
}