namespace MenuFindItem
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
            this.miFile = new Telerik.WinControls.UI.RadMenuItem();
            this.miNew = new Telerik.WinControls.UI.RadMenuItem();
            this.miOpen = new Telerik.WinControls.UI.RadMenuItem();
            this.miSave = new Telerik.WinControls.UI.RadMenuItem();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miFile});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(284, 22);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // miFile
            // 
            this.miFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miNew,
            this.miOpen,
            this.miSave});
            this.miFile.Name = "miFile";
            this.miFile.Tag = "999";
            this.miFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Tag = "111";
            this.miNew.Text = "New";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Tag = "222";
            this.miOpen.Text = "Open";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Tag = "333";
            this.miSave.Text = "Save";
            // 
            // btnGo
            // 
            this.btnGo.AllowShowFocusCues = true;
            this.btnGo.Location = new System.Drawing.Point(102, 129);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.radMenu1);
            this.Name = "Form1";
            this.Text = "Menus";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem miFile;
        private Telerik.WinControls.UI.RadMenuItem miNew;
        private Telerik.WinControls.UI.RadMenuItem miOpen;
        private Telerik.WinControls.UI.RadMenuItem miSave;
        private Telerik.WinControls.UI.RadButton btnGo;
    }
}

