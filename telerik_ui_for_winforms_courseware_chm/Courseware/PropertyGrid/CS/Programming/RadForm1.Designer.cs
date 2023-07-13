namespace Programming
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
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            this.sortButton = new Telerik.WinControls.UI.RadButton();
            this.groupButton = new Telerik.WinControls.UI.RadButton();
            this.filterButton = new Telerik.WinControls.UI.RadButton();
            this.clearButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.Location = new System.Drawing.Point(10, 16);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.Size = new System.Drawing.Size(280, 420);
            this.radPropertyGrid1.TabIndex = 0;
            this.radPropertyGrid1.Text = "radPropertyGrid1";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(12, 442);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(130, 24);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Add SortDescriptor";
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(160, 442);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(130, 24);
            this.groupButton.TabIndex = 2;
            this.groupButton.Text = "Add GroupDescriptor";
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(12, 472);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(130, 24);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Add FilterDescriptor";
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(160, 472);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 24);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear Descriptors";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 507);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.radPropertyGrid1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadButton sortButton;
        private Telerik.WinControls.UI.RadButton groupButton;
        private Telerik.WinControls.UI.RadButton filterButton;
        private Telerik.WinControls.UI.RadButton clearButton;
    }
}

