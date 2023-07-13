namespace FindItem
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
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Controls.Add(this.radPageViewPage4);
            this.radPageView1.Controls.Add(this.radPageViewPage5);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage3;
            this.radPageView1.Size = new System.Drawing.Size(524, 105);
            this.radPageView1.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(554, 258);
            this.radPageViewPage1.Text = "Check In";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(554, 258);
            this.radPageViewPage2.Text = "Arrivals";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Controls.Add(this.radCheckBox1);
            this.radPageViewPage3.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(503, 57);
            this.radPageViewPage3.Text = "Departures";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(554, 258);
            this.radPageViewPage4.Text = "Special Offer";
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage5.Name = "radPageViewPage5";
            this.radPageViewPage5.Size = new System.Drawing.Size(554, 258);
            this.radPageViewPage5.Text = "Book a flight";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(73, 24);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(86, 18);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "Simple Menu";
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 105);
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage3.ResumeLayout(false);
            this.radPageViewPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}

