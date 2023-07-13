namespace ButtonsShortcuts
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
            this.radToggleButton1 = new Telerik.WinControls.UI.RadToggleButton();
            this.radSplitButton1 = new Telerik.WinControls.UI.RadSplitButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radToggleButton1
            // 
            this.radToggleButton1.Location = new System.Drawing.Point(76, 206);
            this.radToggleButton1.Name = "radToggleButton1";
            this.radToggleButton1.Size = new System.Drawing.Size(127, 30);
            this.radToggleButton1.TabIndex = 0;
            this.radToggleButton1.Text = "radToggleButton1";
            this.radToggleButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radToggleButton1_ToggleStateChanged);
            // 
            // radSplitButton1
            // 
            this.radSplitButton1.DefaultItem = null;
            this.radSplitButton1.Location = new System.Drawing.Point(76, 145);
            this.radSplitButton1.Name = "radSplitButton1";
            this.radSplitButton1.Size = new System.Drawing.Size(127, 29);
            this.radSplitButton1.TabIndex = 1;
            this.radSplitButton1.Text = "radSplitButton1";
            this.radSplitButton1.Click += new System.EventHandler(this.radSplitButton1_Click);
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(76, 105);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(127, 18);
            this.radRadioButton1.TabIndex = 2;
            this.radRadioButton1.Text = "radRadioButton1";
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(76, 42);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(127, 28);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "radButton1";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radRadioButton1);
            this.Controls.Add(this.radSplitButton1);
            this.Controls.Add(this.radToggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadToggleButton radToggleButton1;
        private Telerik.WinControls.UI.RadSplitButton radSplitButton1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}

