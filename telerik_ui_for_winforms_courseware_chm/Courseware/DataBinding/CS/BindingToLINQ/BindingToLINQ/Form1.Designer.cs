namespace BindingToLINQ
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
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // radListControl1
            // 
            this.radListControl1.Location = new System.Drawing.Point(12, 12);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(260, 240);
            this.radListControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.radListControl1);
            this.Name = "Form1";
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radListControl1;
    }
}

