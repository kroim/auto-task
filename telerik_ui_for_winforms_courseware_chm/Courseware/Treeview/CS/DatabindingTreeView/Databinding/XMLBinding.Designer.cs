namespace Databinding
{
    partial class XMLBinding
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
            this.components = new System.ComponentModel.Container();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.Transparent;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.Location = new System.Drawing.Point(15, 15);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(268, 249);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // XMLBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 279);
            this.Controls.Add(this.radTreeView1);
            this.Name = "XMLBinding";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "XMLBinding";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.XMLBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
    }
}

