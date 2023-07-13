namespace Databinding
{
    partial class LoadOnDemand
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode8 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode9 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode10 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode11 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode12 = new Telerik.WinControls.UI.RadTreeNode();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarToggleButton1 = new Telerik.WinControls.UI.CommandBarToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radTreeView1.FullRowSelect = false;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Text = "Current Temperature";
            radTreeNode2.Text = "High Temperature";
            radTreeNode3.Text = "Low Temperature";
            radTreeNode4.Text = "Wind Chill Factor";
            radTreeNode5.Text = "Barometric Pressure";
            radTreeNode6.Text = "Relative Humidity";
            radTreeNode7.Text = "Dewpoint";
            radTreeNode8.Text = "Wind Speed";
            radTreeNode9.Text = "Wind Direction";
            radTreeNode10.Text = "Peak Wind Gust";
            radTreeNode11.Text = "Precipitation Today";
            radTreeNode12.Text = "Precipitation To Date";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode2,
            radTreeNode3,
            radTreeNode4,
            radTreeNode5,
            radTreeNode6,
            radTreeNode7,
            radTreeNode8,
            radTreeNode9,
            radTreeNode10,
            radTreeNode11,
            radTreeNode12});
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.Size = new System.Drawing.Size(298, 257);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 3;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "ControlDefault";
            this.radTreeView1.NodesNeeded += new Telerik.WinControls.UI.NodesNeededEventHandler(this.radTreeView1_NodesNeeded);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 257);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(298, 22);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "ControlDefault";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            // 
            // commandBarToggleButton1
            // 
            this.commandBarToggleButton1.AccessibleDescription = "Use BeginUpdate/EndUpdate";
            this.commandBarToggleButton1.AccessibleName = "Use BeginUpdate/EndUpdate";
            this.commandBarToggleButton1.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleButton1.VisibleInOverflowMenu = true;
            // 
            // LoadOnDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 279);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "LoadOnDemand";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LoadOnDemand";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButton1;
    }
}

