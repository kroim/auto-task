namespace CheckBoxesDemo
{
    partial class CheckBoxes
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 282);
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radTreeView1.ForeColor = System.Drawing.Color.Black;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radTreeView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTreeView1.Size = new System.Drawing.Size(298, 282);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            this.Controls.Add(this.radTreeView1);
            this.Name = "CheckBoxes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CheckBoxes";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.CheckBoxes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;


    }
}

