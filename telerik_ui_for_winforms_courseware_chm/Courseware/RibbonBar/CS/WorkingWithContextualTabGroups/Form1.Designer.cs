namespace WorkingWithContextualTabGroups
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.AutoSize = true;
            this.radRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radRibbonBar1.EnableKeyMap = true;
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.AccessibleDescription = "Exit";
            this.radRibbonBar1.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.AccessibleDescription = "Options";
            this.radRibbonBar1.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(284, 144);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "radRibbonBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "Form1";
            this.Text = "radRibbonBar1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
    }
}

