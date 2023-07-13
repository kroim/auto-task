namespace Introduction
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarStripElement3 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarToggleButton1 = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarDropDownList1 = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarDropDownButton1 = new Telerik.WinControls.UI.CommandBarDropDownButton();
            this.commandBarButton4 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1,
            this.commandBarRowElement2});
            this.radCommandBar1.Size = new System.Drawing.Size(599, 105);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1,
            this.commandBarStripElement3});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1,
            this.commandBarButton2,
            this.commandBarButton3});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // commandBarStripElement3
            // 
            this.commandBarStripElement3.DisplayName = "commandBarStripElement3";
            this.commandBarStripElement3.EnableFloating = true;
            this.commandBarStripElement3.FloatingForm = null;
            this.commandBarStripElement3.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarDropDownButton1,
            this.commandBarToggleButton1,
            this.commandBarDropDownList1});
            this.commandBarStripElement3.Name = "commandBarStripElement3";
            this.commandBarStripElement3.Text = "";
            // 
            // commandBarToggleButton1
            // 
            this.commandBarToggleButton1.AccessibleDescription = "commandBarToggleButton1";
            this.commandBarToggleButton1.AccessibleName = "commandBarToggleButton1";
            this.commandBarToggleButton1.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleButton1.DrawText = true;
            this.commandBarToggleButton1.Image = null;
            this.commandBarToggleButton1.Name = "commandBarToggleButton1";
            this.commandBarToggleButton1.Text = "Two sided print";
            this.commandBarToggleButton1.ToolTipText = "Two sided print";
            this.commandBarToggleButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleButton1.VisibleInOverflowMenu = true;
            // 
            // commandBarDropDownList1
            // 
            this.commandBarDropDownList1.AccessibleDescription = "commandBarDropDownList1";
            this.commandBarDropDownList1.AccessibleName = "commandBarDropDownList1";
            this.commandBarDropDownList1.DisplayName = "commandBarDropDownList1";
            radListDataItem1.Text = "8.5 x 11";
            radListDataItem1.TextWrap = true;
            this.commandBarDropDownList1.Items.Add(radListDataItem1);
            this.commandBarDropDownList1.Name = "commandBarDropDownList1";
            this.commandBarDropDownList1.Text = "commandBarDropDownList1";
            this.commandBarDropDownList1.ToolTipText = "Size";
            this.commandBarDropDownList1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownList1.VisibleInOverflowMenu = true;
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.DisplayName = null;
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.FloatingForm = null;
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton4});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            this.commandBarStripElement2.Text = "";
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.AccessibleDescription = "commandBarButton1";
            this.commandBarButton1.AccessibleName = "commandBarButton1";
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton1.Image")));
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "commandBarButton1";
            this.commandBarButton1.ToolTipText = "Create New File";
            this.commandBarButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarButton1.VisibleInOverflowMenu = true;
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.AccessibleDescription = "commandBarButton2";
            this.commandBarButton2.AccessibleName = "commandBarButton2";
            this.commandBarButton2.DisplayName = "commandBarButton2";
            this.commandBarButton2.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton2.Image")));
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "commandBarButton2";
            this.commandBarButton2.ToolTipText = "Open file";
            this.commandBarButton2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarButton2.VisibleInOverflowMenu = true;
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.AccessibleDescription = "commandBarButton3";
            this.commandBarButton3.AccessibleName = "commandBarButton3";
            this.commandBarButton3.DisplayName = "commandBarButton3";
            this.commandBarButton3.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton3.Image")));
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.Text = "commandBarButton3";
            this.commandBarButton3.ToolTipText = "Save file";
            this.commandBarButton3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarButton3.VisibleInOverflowMenu = true;
            // 
            // commandBarDropDownButton1
            // 
            this.commandBarDropDownButton1.AccessibleDescription = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.AccessibleName = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.DisplayName = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarDropDownButton1.Image")));
            this.commandBarDropDownButton1.Name = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.Text = "commandBarDropDownButton1";
            this.commandBarDropDownButton1.ToolTipText = "Print";
            this.commandBarDropDownButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownButton1.VisibleInOverflowMenu = true;
            // 
            // commandBarButton4
            // 
            this.commandBarButton4.AccessibleDescription = "commandBarButton4";
            this.commandBarButton4.AccessibleName = "commandBarButton4";
            this.commandBarButton4.DisplayName = "commandBarButton4";
            this.commandBarButton4.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton4.Image")));
            this.commandBarButton4.Name = "commandBarButton4";
            this.commandBarButton4.Text = "commandBarButton4";
            this.commandBarButton4.ToolTipText = "Help";
            this.commandBarButton4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarButton4.VisibleInOverflowMenu = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 262);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton4;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement3;
        private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButton1;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleButton1;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownList1;
    }
}

