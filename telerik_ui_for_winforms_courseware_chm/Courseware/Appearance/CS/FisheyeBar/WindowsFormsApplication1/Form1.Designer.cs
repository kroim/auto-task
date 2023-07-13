namespace WindowsFormsApplication1
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
            this.welcomeScreenBottom1 = new Telerik.QuickStart.WinControls.WelcomeScreenBottom();
            this.SuspendLayout();
            // 
            // welcomeScreenBottom1
            // 
            this.welcomeScreenBottom1.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreenBottom1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeScreenBottom1.ForeColor = System.Drawing.Color.White;
            this.welcomeScreenBottom1.Location = new System.Drawing.Point(29, 82);
            this.welcomeScreenBottom1.Name = "welcomeScreenBottom1";
            this.welcomeScreenBottom1.Size = new System.Drawing.Size(673, 189);
            this.welcomeScreenBottom1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(733, 339);
            this.Controls.Add(this.welcomeScreenBottom1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.QuickStart.WinControls.WelcomeScreenBottom welcomeScreenBottom1;

    }
}

