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
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.btnShowPopup = new Telerik.WinControls.UI.RadButtonElement();
            this.lblSelected = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMultiColumnComboBox1
            // 
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(4, 1);
            // 
            // 
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(292, 104);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.EditorControl.Visible = false;
            this.radMultiColumnComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(12, 21);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            // 
            // 
            // 
            this.radMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radMultiColumnComboBox1.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(274, 20);
            this.radMultiColumnComboBox1.TabIndex = 0;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.ThemeName = "ControlDefault";
            this.radMultiColumnComboBox1.SelectedIndexChanged += new System.EventHandler(this.radMultiColumnComboBox1_SelectedIndexChanged);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnShowPopup,
            this.lblSelected});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 280);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(298, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "ControlDefault";
            // 
            // btnShowPopup
            // 
            this.btnShowPopup.AccessibleDescription = "ShowPopup";
            this.btnShowPopup.AccessibleName = "ShowPopup";
            this.btnShowPopup.CanFocus = true;
            this.btnShowPopup.Margin = new System.Windows.Forms.Padding(1);
            this.btnShowPopup.Name = "btnShowPopup";
            this.radStatusStrip1.SetSpring(this.btnShowPopup, false);
            this.btnShowPopup.Text = "ShowPopup";
            this.btnShowPopup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnShowPopup.Click += new System.EventHandler(this.btnShowPopup_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.Margin = new System.Windows.Forms.Padding(1);
            this.lblSelected.Name = "lblSelected";
            this.radStatusStrip1.SetSpring(this.lblSelected, false);
            this.lblSelected.TextWrap = true;
            this.lblSelected.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 306);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radMultiColumnComboBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadMultiColumnComboBox";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadButtonElement btnShowPopup;
        private Telerik.WinControls.UI.RadLabelElement lblSelected;
    }
}

