namespace DragAndDrop
{
    partial class DragAndDropForm
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
            this.grdLowerRight = new Telerik.WinControls.UI.RadGridView();
            this.tvTopRight = new Telerik.WinControls.UI.RadTreeView();
            this.tvLeft = new Telerik.WinControls.UI.RadTreeView();
            this.radToolStripElement1 = new Telerik.WinControls.UI.RadToolStripElement();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnAllowDragDrop = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.btnFeedback = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            ((System.ComponentModel.ISupportInitialize)(this.grdLowerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLowerRight.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            this.toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLowerRight
            // 
            this.grdLowerRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grdLowerRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdLowerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLowerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grdLowerRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdLowerRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdLowerRight.Location = new System.Drawing.Point(0, 0);
            // 
            // grdLowerRight
            // 
            this.grdLowerRight.MasterTemplate.AllowAddNewRow = false;
            this.grdLowerRight.MasterTemplate.AllowColumnChooser = false;
            this.grdLowerRight.MasterTemplate.AllowColumnReorder = false;
            this.grdLowerRight.MasterTemplate.AllowDeleteRow = false;
            this.grdLowerRight.MasterTemplate.AllowEditRow = false;
            this.grdLowerRight.MasterTemplate.EnableGrouping = false;
            this.grdLowerRight.MasterTemplate.EnableSorting = false;
            this.grdLowerRight.MasterTemplate.ShowFilteringRow = false;
            this.grdLowerRight.Name = "grdLowerRight";
            this.grdLowerRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdLowerRight.Size = new System.Drawing.Size(210, 223);
            this.grdLowerRight.TabIndex = 0;
            this.grdLowerRight.Text = "radGridViewPreview";
            this.grdLowerRight.ThemeName = "Telerik";
            ((Telerik.WinControls.UI.RadGridViewElement)(this.grdLowerRight.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            // 
            // tvTopRight
            // 
            this.tvTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tvTopRight.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.tvTopRight.Location = new System.Drawing.Point(0, 30);
            this.tvTopRight.Name = "tvTopRight";
            this.tvTopRight.ShowDropHint = false;
            this.tvTopRight.Size = new System.Drawing.Size(210, 195);
            this.tvTopRight.TabIndex = 0;
            this.tvTopRight.Text = "radTreeView1";
            this.tvTopRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvTopRight_DragEnter);
            this.tvTopRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvTopRight_DragDrop);
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvTopRight.GetChildAt(0))).DrawFill = true;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvTopRight.GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(254)))), ((int)(((byte)(209)))));
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvTopRight.GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvTopRight.GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvTopRight.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            // 
            // tvLeft
            // 
            this.tvLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tvLeft.DisplayMember = "FullName";
            this.tvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLeft.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.tvLeft.Location = new System.Drawing.Point(0, 0);
            this.tvLeft.Name = "tvLeft";
            this.tvLeft.ShowDropHint = false;
            this.tvLeft.Size = new System.Drawing.Size(174, 446);
            this.tvLeft.TabIndex = 0;
            this.tvLeft.Text = "radTreeView1";
            this.tvLeft.ValueMember = "EmployeeID";
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvLeft.GetChildAt(0))).DrawFill = true;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvLeft.GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(254)))), ((int)(((byte)(209)))));
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvLeft.GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvLeft.GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvLeft.GetChildAt(0))).GradientAngle = 180F;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.tvLeft.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            // 
            // radToolStripElement1
            // 
            this.radToolStripElement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(242)))));
            this.radToolStripElement1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.radToolStripElement1.MinSize = new System.Drawing.Size(0, 21);
            this.radToolStripElement1.Name = "radToolStripElement1";
            this.radToolStripElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(412, 30);
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
            this.btnAllowDragDrop,
            this.btnFeedback});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnAllowDragDrop
            // 
            this.btnAllowDragDrop.AccessibleDescription = "AllowDragDrop";
            this.btnAllowDragDrop.AccessibleName = "AllowDragDrop";
            this.btnAllowDragDrop.DisplayName = null;
            this.btnAllowDragDrop.DrawText = true;
            this.btnAllowDragDrop.Image = null;
            this.btnAllowDragDrop.Name = "btnAllowDragDrop";
            this.btnAllowDragDrop.Text = "AllowDragDrop";
            this.btnAllowDragDrop.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnAllowDragDrop.VisibleInOverflowMenu = true;
            this.btnAllowDragDrop.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btnAllowDragDrop_ToggleStateChanged);
            // 
            // btnFeedback
            // 
            this.btnFeedback.AccessibleDescription = "Feedback (ShowLine)";
            this.btnFeedback.AccessibleName = "Feedback (ShowLine)";
            this.btnFeedback.DisplayName = null;
            this.btnFeedback.DrawText = true;
            this.btnFeedback.Image = null;
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnFeedback.VisibleInOverflowMenu = true;
            this.btnFeedback.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btnFeedback_ToggleStateChanged);
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow1;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Controls.Add(this.radSplitContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 30);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radDock1.Size = new System.Drawing.Size(412, 468);
            this.radDock1.SplitterWidth = 4;
            this.radDock1.TabIndex = 2;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.tvLeft);
            this.documentWindow1.Location = new System.Drawing.Point(6, 6);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(174, 446);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Location = new System.Drawing.Point(5, 5);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(186, 458);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(186, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-221, 0);
            this.documentContainer1.SplitterWidth = 4;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(186, 458);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.TabStripVisible = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.CausesValidation = false;
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(195, 5);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(212, 458);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(212, 200);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(221, 0);
            this.radSplitContainer1.SplitterWidth = 4;
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CaptionVisible = false;
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(212, 227);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.TabStripVisible = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Controls.Add(this.textBox1);
            this.toolWindow1.Controls.Add(this.tvTopRight);
            this.toolWindow1.Location = new System.Drawing.Point(1, 2);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(210, 223);
            this.toolWindow1.Text = "toolWindow1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CaptionVisible = false;
            this.toolTabStrip2.CausesValidation = false;
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 231);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(212, 227);
            this.toolTabStrip2.TabIndex = 0;
            this.toolTabStrip2.TabStop = false;
            this.toolTabStrip2.TabStripVisible = false;
            // 
            // toolWindow2
            // 
            this.toolWindow2.Controls.Add(this.grdLowerRight);
            this.toolWindow2.Location = new System.Drawing.Point(1, 2);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(210, 223);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // DragAndDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 498);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "DragAndDropForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Drag And Drop";
            this.ThemeName = "Telerik";
            this.Load += new System.EventHandler(this.DragAndDropForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLowerRight.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLowerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.toolWindow1.ResumeLayout(false);
            this.toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            this.toolWindow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadToolStripElement radToolStripElement1;
        private Telerik.WinControls.UI.RadGridView grdLowerRight;
        private Telerik.WinControls.UI.RadTreeView tvTopRight;
        private Telerik.WinControls.UI.RadTreeView tvLeft;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.CommandBarToggleButton btnAllowDragDrop;
        private Telerik.WinControls.UI.CommandBarToggleButton btnFeedback;
        private System.Windows.Forms.TextBox textBox1;
    }
}

