namespace ProgrammingDock
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
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnLoad = new Telerik.WinControls.UI.CommandBarButton();
            this.btnSave = new Telerik.WinControls.UI.CommandBarButton();
            this.btnLayout = new Telerik.WinControls.UI.CommandBarButton();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.toolTabStrip3 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.toolTabStrip4 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow4 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).BeginInit();
            this.toolTabStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip4)).BeginInit();
            this.toolTabStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(733, 54);
            this.radCommandBar1.TabIndex = 0;
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
            this.btnLoad,
            this.btnSave,
            this.btnLayout});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleDescription = "Load";
            this.btnLoad.AccessibleName = "Load";
            this.btnLoad.DisplayName = "commandBarButton1";
            this.btnLoad.DrawText = true;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoad.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnLoad.VisibleInOverflowMenu = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "Save";
            this.btnSave.AccessibleName = "Save";
            this.btnSave.DisplayName = "commandBarButton2";
            this.btnSave.DrawText = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnSave.VisibleInOverflowMenu = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLayout
            // 
            this.btnLayout.AccessibleDescription = "Change Layout";
            this.btnLayout.AccessibleName = "Change Layout";
            this.btnLayout.DisplayName = "commandBarButton3";
            this.btnLayout.DrawText = true;
            this.btnLayout.Image = ((System.Drawing.Image)(resources.GetObject("btnLayout.Image")));
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.Text = "Change Layout";
            this.btnLayout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLayout.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnLayout.VisibleInOverflowMenu = true;
            this.btnLayout.Click += new System.EventHandler(this.btnLayout_Click);
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindow1;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.radSplitContainer1);
            this.radDock1.Controls.Add(this.toolTabStrip4);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 54);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radDock1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(733, 492);
            this.radDock1.SplitterWidth = 4;
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Location = new System.Drawing.Point(408, 0);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(315, 278);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SplitterWidth = 4;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.CausesValidation = false;
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.radSplitContainer2);
            this.radSplitContainer1.Controls.Add(this.documentContainer1);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(5, 5);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(723, 278);
            this.radSplitContainer1.SplitterWidth = 4;
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 278);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(1, 24);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(198, 252);
            this.toolWindow1.Text = "toolWindow1";
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.CausesValidation = false;
            this.radSplitContainer2.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer2.Controls.Add(this.toolTabStrip3);
            this.radSplitContainer2.IsCleanUpTarget = true;
            this.radSplitContainer2.Location = new System.Drawing.Point(204, 0);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(200, 278);
            this.radSplitContainer2.SplitterWidth = 4;
            this.radSplitContainer2.TabIndex = 2;
            this.radSplitContainer2.TabStop = false;
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(200, 137);
            this.toolTabStrip2.TabIndex = 0;
            this.toolTabStrip2.TabStop = false;
            // 
            // toolWindow2
            // 
            this.toolWindow2.Location = new System.Drawing.Point(1, 24);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(198, 111);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // toolTabStrip3
            // 
            this.toolTabStrip3.CausesValidation = false;
            this.toolTabStrip3.Controls.Add(this.toolWindow3);
            this.toolTabStrip3.Location = new System.Drawing.Point(0, 141);
            this.toolTabStrip3.Name = "toolTabStrip3";
            // 
            // 
            // 
            this.toolTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip3.SelectedIndex = 0;
            this.toolTabStrip3.Size = new System.Drawing.Size(200, 137);
            this.toolTabStrip3.TabIndex = 0;
            this.toolTabStrip3.TabStop = false;
            // 
            // toolWindow3
            // 
            this.toolWindow3.Location = new System.Drawing.Point(1, 24);
            this.toolWindow3.Name = "toolWindow3";
            this.toolWindow3.Size = new System.Drawing.Size(198, 111);
            this.toolWindow3.Text = "toolWindow3";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Controls.Add(this.documentWindow2);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(315, 278);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // documentWindow1
            // 
            this.documentWindow1.Location = new System.Drawing.Point(6, 30);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(303, 242);
            this.documentWindow1.Text = "documentWindow2";
            // 
            // documentWindow2
            // 
            this.documentWindow2.Location = new System.Drawing.Point(0, 0);
            this.documentWindow2.Name = "documentWindow2";
            this.documentWindow2.Size = new System.Drawing.Size(296, 194);
            this.documentWindow2.Text = "documentWindow1";
            // 
            // toolTabStrip4
            // 
            this.toolTabStrip4.Controls.Add(this.toolWindow4);
            this.toolTabStrip4.Location = new System.Drawing.Point(5, 287);
            this.toolTabStrip4.Name = "toolTabStrip4";
            // 
            // 
            // 
            this.toolTabStrip4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip4.SelectedIndex = 0;
            this.toolTabStrip4.Size = new System.Drawing.Size(723, 200);
            this.toolTabStrip4.TabIndex = 3;
            this.toolTabStrip4.TabStop = false;
            // 
            // toolWindow4
            // 
            this.toolWindow4.Location = new System.Drawing.Point(1, 24);
            this.toolWindow4.Name = "toolWindow4";
            this.toolWindow4.Size = new System.Drawing.Size(721, 174);
            this.toolWindow4.Text = "toolWindow4";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 520);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(733, 26);
            this.radStatusStrip1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 546);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).EndInit();
            this.toolTabStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip4)).EndInit();
            this.toolTabStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnLoad;
        private Telerik.WinControls.UI.CommandBarButton btnSave;
        private Telerik.WinControls.UI.CommandBarButton btnLayout;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip4;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
    }
}

