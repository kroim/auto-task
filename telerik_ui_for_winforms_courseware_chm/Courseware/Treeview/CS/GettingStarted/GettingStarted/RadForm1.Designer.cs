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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radBreadCrumb1 = new Telerik.WinControls.UI.RadBreadCrumb();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radTreeView1);
            this.radPanel1.Controls.Add(this.radBreadCrumb1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // 
            // 
            this.radPanel1.RootElement.Padding = new System.Windows.Forms.Padding(3);
            this.radPanel1.Size = new System.Drawing.Size(362, 333);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(3);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(223)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 4;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).GradientAngle = 50F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.Transparent;
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radTreeView1.Location = new System.Drawing.Point(3, 39);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Name = "Email Contacts";
            radTreeNode1.Text = "Email Contacts";
            radTreeNode2.Name = "Lists";
            radTreeNode2.Text = "Lists";
            radTreeNode3.Name = "Reports";
            radTreeNode3.Text = "Reports";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode2,
            radTreeNode3});
            this.radTreeView1.Padding = new System.Windows.Forms.Padding(5);
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radTreeView1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radTreeView1.Size = new System.Drawing.Size(356, 291);
            this.radTreeView1.TabIndex = 2;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "ControlDefault";
            // 
            // radBreadCrumb1
            // 
            this.radBreadCrumb1.BackColor = System.Drawing.Color.Transparent;
            this.radBreadCrumb1.DefaultTreeView = this.radTreeView1;
            this.radBreadCrumb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radBreadCrumb1.Location = new System.Drawing.Point(3, 3);
            this.radBreadCrumb1.Name = "radBreadCrumb1";
            this.radBreadCrumb1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radBreadCrumb1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radBreadCrumb1.Size = new System.Drawing.Size(356, 36);
            this.radBreadCrumb1.TabIndex = 1;
            this.radBreadCrumb1.Text = "radBreadCrumb1";
            this.radBreadCrumb1.ThemeName = "ControlDefault";
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Open";
            this.radMenuItem1.AccessibleName = "Open";
            this.radMenuItem1.Image = global::GettingStarted.Properties.Resources.Folder_Open;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Open";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Print";
            this.radMenuItem2.AccessibleName = "Print";
            this.radMenuItem2.Image = global::GettingStarted.Properties.Resources.Printer;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Print";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Archive";
            this.radMenuItem3.AccessibleName = "Archive";
            this.radMenuItem3.Image = global::GettingStarted.Properties.Resources.Journal;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Archive";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 333);
            this.Controls.Add(this.radPanel1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TreeView";
            this.ThemeName = "Office2007Silver";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadBreadCrumb radBreadCrumb1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
    }
}

