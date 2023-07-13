namespace AddControls
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageView2 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage6 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView2)).BeginInit();
            this.radPageView2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage3;
            this.radPageView1.Size = new System.Drawing.Size(284, 117);
            this.radPageView1.TabIndex = 1;
            // 
            // radPageView2
            // 
            this.radPageView2.Controls.Add(this.radPageViewPage4);
            this.radPageView2.Controls.Add(this.radPageViewPage5);
            this.radPageView2.Controls.Add(this.radPageViewPage6);
            this.radPageView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPageView2.Location = new System.Drawing.Point(0, 145);
            this.radPageView2.Name = "radPageView2";
            this.radPageView2.SelectedPage = this.radPageViewPage6;
            this.radPageView2.Size = new System.Drawing.Size(284, 117);
            this.radPageView2.TabIndex = 0;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(263, 69);
            this.radPageViewPage1.Text = "Mocha";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(263, 69);
            this.radPageViewPage2.Text = "Espresso";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(263, 69);
            this.radPageViewPage3.Text = "Chai";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(263, 69);
            this.radPageViewPage4.Text = "Large";
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage5.Name = "radPageViewPage5";
            this.radPageViewPage5.Size = new System.Drawing.Size(263, 69);
            this.radPageViewPage5.Text = "Medium";
            // 
            // radPageViewPage6
            // 
            this.radPageViewPage6.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage6.Name = "radPageViewPage6";
            this.radPageViewPage6.Size = new System.Drawing.Size(263, 69);
            this.radPageViewPage6.Text = "Small";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radPageView2);
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView2)).EndInit();
            this.radPageView2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageView radPageView2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage6;
    }
}

