namespace TestMyTPF
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Image = global::TestMyTPF.Properties.Resources.Globe;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(138, 82);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "World\r\nClock";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::TestMyTPF.Properties.Resources.Globe;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "World\r\nClock";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(10);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.LightBlue;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Lavender;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Purple;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlass;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Blue;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.None;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Opacity = 0.5;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(13, 153);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(75, 23);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "radButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Name = "Form1";
            this.Text = "TPF";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}

