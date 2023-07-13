namespace Editing
{
    partial class EditNodes
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.White;
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Expanded = true;
            radTreeNode2.Text = "To Do List";
            radTreeNode3.Text = "New Budget";
            radTreeNode4.Text = "Project Proposal Template";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3,
            radTreeNode4});
            radTreeNode1.Text = "My Documents";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1});
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.Size = new System.Drawing.Size(298, 278);
            this.radTreeView1.TabIndex = 2;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "Aqua";
            this.radTreeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.radTreeView1_MouseDoubleClick);
            this.radTreeView1.Edited += new Telerik.WinControls.UI.TreeNodeEditedEventHandler(this.radTreeView1_Edited);
            this.radTreeView1.Editing += new Telerik.WinControls.UI.TreeNodeEditingEventHandler(this.radTreeView1_Editing);
            this.radTreeView1.ValueValidating += new Telerik.WinControls.UI.TreeNodeValidatingEventHandler(this.radTreeView1_ValueValidating);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 252);
            this.radStatusStrip1.Name = "radStatusStrip1";
            // 
            // 
            // 
            this.radStatusStrip1.RootElement.StretchVertically = true;
            this.radStatusStrip1.Size = new System.Drawing.Size(298, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "ControlDefault";
            // 
            // lblStatus
            // 
            this.lblStatus.AccessibleDescription = null;
            this.lblStatus.AccessibleName = null;
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // EditNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 278);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radTreeView1);
            this.Name = "EditNodes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EditNodes";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.EditNodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
    }
}

