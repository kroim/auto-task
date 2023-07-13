namespace MenuAddCheckBoxItem
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(284, 20);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Item 1";
            this.radMenuItem1.AccessibleName = "Item 1";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Item 1";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Item 2";
            this.radMenuItem2.AccessibleName = "Item 2";
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem6});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Item 2";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Item 3";
            this.radMenuItem3.AccessibleName = "Item 3";
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem7});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Item 3";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Sub menu item 1";
            this.radMenuItem4.AccessibleName = "Sub menu item 1";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Sub menu item 1";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "Sub menu item 2";
            this.radMenuItem5.AccessibleName = "Sub menu item 2";
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Sub menu item 2";
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.AccessibleDescription = "Sub menu item 1";
            this.radMenuItem6.AccessibleName = "Sub menu item 1";
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Sub menu item 1";
            this.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.AccessibleDescription = "Sub menu item 1";
            this.radMenuItem7.AccessibleName = "Sub menu item 1";
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Sub menu item 1";
            this.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radMenu1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
    }
}

