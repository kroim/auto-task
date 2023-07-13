namespace _10_DynamicLINQLibrary
{
    partial class RadGridViewLab10
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numRecords = new System.Windows.Forms.NumericUpDown();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbField = new System.Windows.Forms.ComboBox();
            this.cbSortType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(12, 42);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(775, 328);
            this.radGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Records:";
            // 
            // numRecords
            // 
            this.numRecords.Location = new System.Drawing.Point(667, 12);
            this.numRecords.Name = "numRecords";
            this.numRecords.Size = new System.Drawing.Size(120, 20);
            this.numRecords.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(424, 8);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(103, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbField
            // 
            this.cbField.FormattingEnabled = true;
            this.cbField.Items.AddRange(new object[] {
            "SalesOrderID",
            "OrderDate",
            "SubTotal",
            "TaxAmt",
            "Freight",
            "TotalDue"});
            this.cbField.Location = new System.Drawing.Point(63, 10);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(155, 21);
            this.cbField.TabIndex = 5;
            // 
            // cbSortType
            // 
            this.cbSortType.FormattingEnabled = true;
            this.cbSortType.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cbSortType.Location = new System.Drawing.Point(234, 10);
            this.cbSortType.Name = "cbSortType";
            this.cbSortType.Size = new System.Drawing.Size(153, 21);
            this.cbSortType.TabIndex = 6;
            // 
            // RadGridViewLab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 382);
            this.Controls.Add(this.cbSortType);
            this.Controls.Add(this.cbField);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.numRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGridView1);
            this.Name = "RadGridViewLab10";
            this.Text = "RadGridView Lab 10";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRecords;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.ComboBox cbSortType;
    }
}

