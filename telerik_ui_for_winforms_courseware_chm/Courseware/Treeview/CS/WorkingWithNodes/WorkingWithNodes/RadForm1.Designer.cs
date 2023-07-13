namespace WorkingWithNodes
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
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnReorder = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarTextBox1 = new Telerik.WinControls.UI.CommandBarTextBox();
            this.btnSearch = new Telerik.WinControls.UI.CommandBarButton();
            this.btnSelectedNodes = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarToggleButton1 = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            this.radCommandBar1.Size = new System.Drawing.Size(392, 30);
            this.radCommandBar1.TabIndex = 2;
            this.radCommandBar1.Text = "radCommandBar1";
            this.radCommandBar1.ThemeName = "ControlDefault";
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
            this.btnReorder,
            this.commandBarTextBox1,
            this.btnSearch,
            this.btnSelectedNodes,
            this.commandBarToggleButton1});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnReorder
            // 
            this.btnReorder.AccessibleDescription = "Reorder";
            this.btnReorder.AccessibleName = "Reorder";
            this.btnReorder.DisplayName = "commandBarButton1";
            this.btnReorder.DrawText = true;
            this.btnReorder.Image = null;
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Text = "Reorder";
            this.btnReorder.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnReorder.VisibleInOverflowMenu = true;
            this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
            // 
            // commandBarTextBox1
            // 
            this.commandBarTextBox1.DisplayName = "commandBarTextBox1";
            this.commandBarTextBox1.MaxSize = new System.Drawing.Size(120, 0);
            this.commandBarTextBox1.MinSize = new System.Drawing.Size(120, 0);
            this.commandBarTextBox1.Name = "commandBarTextBox1";
            this.commandBarTextBox1.Text = "";
            this.commandBarTextBox1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarTextBox1.VisibleInOverflowMenu = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = "Search";
            this.btnSearch.AccessibleName = "Search";
            this.btnSearch.DisplayName = "commandBarButton2";
            this.btnSearch.DrawText = true;
            this.btnSearch.Image = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "Search";
            this.btnSearch.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnSearch.VisibleInOverflowMenu = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelectedNodes
            // 
            this.btnSelectedNodes.AccessibleDescription = "Selected Nodes";
            this.btnSelectedNodes.AccessibleName = "Selected Nodes";
            this.btnSelectedNodes.DisplayName = "commandBarButton3";
            this.btnSelectedNodes.DrawText = true;
            this.btnSelectedNodes.Image = null;
            this.btnSelectedNodes.Name = "btnSelectedNodes";
            this.btnSelectedNodes.Text = "Selected Nodes";
            this.btnSelectedNodes.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnSelectedNodes.VisibleInOverflowMenu = true;
            this.btnSelectedNodes.Click += new System.EventHandler(this.btnSelectedNodes_Click);
            // 
            // commandBarToggleButton1
            // 
            this.commandBarToggleButton1.AccessibleDescription = "Multi Select";
            this.commandBarToggleButton1.AccessibleName = "Multi Select";
            this.commandBarToggleButton1.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleButton1.DrawText = true;
            this.commandBarToggleButton1.Image = null;
            this.commandBarToggleButton1.Name = "commandBarToggleButton1";
            this.commandBarToggleButton1.Text = "Multi Select";
            this.commandBarToggleButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleButton1.VisibleInOverflowMenu = true;
            this.commandBarToggleButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.MultiSelect_ToggleStateChanged);
            // 
            // radTreeView1
            // 
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Location = new System.Drawing.Point(0, 30);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(392, 262);
            this.radTreeView1.TabIndex = 3;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "ControlDefault";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 292);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnReorder;
        private Telerik.WinControls.UI.CommandBarTextBox commandBarTextBox1;
        private Telerik.WinControls.UI.CommandBarButton btnSearch;
        private Telerik.WinControls.UI.CommandBarButton btnSelectedNodes;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButton1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
    }
}

