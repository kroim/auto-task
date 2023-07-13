namespace Databinding
{
    partial class XMLSerialize
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnSave = new Telerik.WinControls.UI.CommandBarButton();
            this.btnLoad = new Telerik.WinControls.UI.CommandBarButton();
            this.tbNodeText = new Telerik.WinControls.UI.CommandBarTextBox();
            this.btnAddSibling = new Telerik.WinControls.UI.CommandBarButton();
            this.btnAddChild = new Telerik.WinControls.UI.CommandBarButton();
            this.btnDeleteNode = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.Transparent;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.FullRowSelect = false;
            this.radTreeView1.Location = new System.Drawing.Point(0, 72);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.Size = new System.Drawing.Size(454, 210);
            this.radTreeView1.TabIndex = 4;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "ControlDefault";
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(454, 72);
            this.radCommandBar1.TabIndex = 0;
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
            this.btnSave,
            this.btnLoad,
            this.tbNodeText,
            this.btnAddSibling,
            this.btnAddChild,
            this.btnDeleteNode});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "Save";
            this.btnSave.AccessibleName = "Save";
            this.btnSave.DisplayName = "commandBarButton1";
            this.btnSave.DrawText = true;
            this.btnSave.Image = global::Databinding.Properties.Resources._3_5_Disk_Drive;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnSave.VisibleInOverflowMenu = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleDescription = "Load";
            this.btnLoad.AccessibleName = "Load";
            this.btnLoad.DisplayName = "commandBarButton2";
            this.btnLoad.DrawText = true;
            this.btnLoad.Image = global::Databinding.Properties.Resources.Folder_Open;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoad.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnLoad.VisibleInOverflowMenu = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbNodeText
            // 
            this.tbNodeText.DisplayName = "commandBarTextBox1";
            this.tbNodeText.MinSize = new System.Drawing.Size(100, 0);
            this.tbNodeText.Name = "tbNodeText";
            this.tbNodeText.Text = "";
            this.tbNodeText.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.tbNodeText.VisibleInOverflowMenu = true;
            // 
            // btnAddSibling
            // 
            this.btnAddSibling.AccessibleDescription = "Add Sibling";
            this.btnAddSibling.AccessibleName = "Add Sibling";
            this.btnAddSibling.DisplayName = "commandBarButton3";
            this.btnAddSibling.DrawFill = true;
            this.btnAddSibling.DrawText = true;
            this.btnAddSibling.Image = null;
            this.btnAddSibling.Name = "btnAddSibling";
            this.btnAddSibling.Text = "Add Sibling";
            this.btnAddSibling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSibling.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnAddSibling.VisibleInOverflowMenu = true;
            this.btnAddSibling.Click += new System.EventHandler(this.btnAddSibling_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.AccessibleDescription = "Add Child";
            this.btnAddChild.AccessibleName = "Add Child";
            this.btnAddChild.DisplayName = "commandBarButton4";
            this.btnAddChild.DrawText = true;
            this.btnAddChild.Image = null;
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddChild.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnAddChild.VisibleInOverflowMenu = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.AccessibleDescription = "Delete Node";
            this.btnDeleteNode.AccessibleName = "Delete Node";
            this.btnDeleteNode.DisplayName = "commandBarButton5";
            this.btnDeleteNode.DrawText = true;
            this.btnDeleteNode.Image = null;
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Text = "Delete Node";
            this.btnDeleteNode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteNode.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnDeleteNode.VisibleInOverflowMenu = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // XMLSerialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 282);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "XMLSerialize";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "XMLSerialize";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnSave;
        private Telerik.WinControls.UI.CommandBarButton btnLoad;
        private Telerik.WinControls.UI.CommandBarTextBox tbNodeText;
        private Telerik.WinControls.UI.CommandBarButton btnAddSibling;
        private Telerik.WinControls.UI.CommandBarButton btnAddChild;
        private Telerik.WinControls.UI.CommandBarButton btnDeleteNode;
    }
}

