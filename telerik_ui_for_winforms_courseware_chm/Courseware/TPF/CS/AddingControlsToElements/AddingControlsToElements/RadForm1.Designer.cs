namespace AddingControlsToElements
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
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.lblItemSelected = new Telerik.WinControls.UI.RadLabel();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemSelected
            // 
            this.lblItemSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblItemSelected.Location = new System.Drawing.Point(12, 12);
            this.lblItemSelected.Name = "lblItemSelected";
            this.lblItemSelected.Size = new System.Drawing.Size(55, 18);
            this.lblItemSelected.TabIndex = 1;
            this.lblItemSelected.Text = "radLabel1";
            // 
            // radListControl1
            // 
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.Location = new System.Drawing.Point(12, 38);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(364, 269);
            this.radListControl1.TabIndex = 2;
            this.radListControl1.Text = "radListControl1";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 319);
            this.Controls.Add(this.radListControl1);
            this.Controls.Add(this.lblItemSelected);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Adding Hosted Controls";
            this.ThemeName = "Office2007Silver";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblItemSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.UI.RadLabel lblItemSelected;
        private Telerik.WinControls.UI.RadListControl radListControl1;
    }
}

