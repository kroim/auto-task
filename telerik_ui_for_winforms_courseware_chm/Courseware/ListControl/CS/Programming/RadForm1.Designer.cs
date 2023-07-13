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
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.btnLocate = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rbDescending = new Telerik.WinControls.UI.RadRadioButton();
            this.rbAscending = new Telerik.WinControls.UI.RadRadioButton();
            this.rbNone = new Telerik.WinControls.UI.RadRadioButton();
            this.btnShowSelected = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLocate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbDescending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAscending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListControl1
            // 
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.ItemHeight = 18;
            this.radListControl1.Location = new System.Drawing.Point(12, 78);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(278, 240);
            this.radListControl1.TabIndex = 0;
            this.radListControl1.Text = "radListControl1";
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(146, 12);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(142, 28);
            this.btnLocate.TabIndex = 2;
            this.btnLocate.Text = "Locate";
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rbDescending);
            this.radGroupBox1.Controls.Add(this.rbAscending);
            this.radGroupBox1.Controls.Add(this.rbNone);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Sort";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 324);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(276, 57);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Sort";
            // 
            // rbDescending
            // 
            this.rbDescending.Location = new System.Drawing.Point(173, 23);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(82, 18);
            this.rbDescending.TabIndex = 1;
            this.rbDescending.Text = "Descending";
            this.rbDescending.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Sort_ToggleStateChanged);
            // 
            // rbAscending
            // 
            this.rbAscending.Location = new System.Drawing.Point(87, 23);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(78, 18);
            this.rbAscending.TabIndex = 1;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Sort_ToggleStateChanged);
            // 
            // rbNone
            // 
            this.rbNone.Location = new System.Drawing.Point(27, 23);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(54, 18);
            this.rbNone.TabIndex = 0;
            this.rbNone.Text = "None";
            this.rbNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Sort_ToggleStateChanged);
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(10, 12);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(121, 27);
            this.btnShowSelected.TabIndex = 4;
            this.btnShowSelected.Text = "Show Selected";
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // radDropDownList1
            // 
            radListDataItem5.Text = "None";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "One";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "MultiSimple";
            radListDataItem7.TextWrap = true;
            radListDataItem8.Text = "MultiExtended";
            radListDataItem8.TextWrap = true;
            this.radDropDownList1.Items.Add(radListDataItem5);
            this.radDropDownList1.Items.Add(radListDataItem6);
            this.radDropDownList1.Items.Add(radListDataItem7);
            this.radDropDownList1.Items.Add(radListDataItem8);
            this.radDropDownList1.Location = new System.Drawing.Point(10, 52);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(278, 20);
            this.radDropDownList1.TabIndex = 5;
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 398);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnLocate);
            this.Controls.Add(this.radListControl1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLocate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbDescending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAscending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadButton btnLocate;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton rbNone;
        private Telerik.WinControls.UI.RadRadioButton rbAscending;
        private Telerik.WinControls.UI.RadRadioButton rbDescending;
        private Telerik.WinControls.UI.RadButton btnShowSelected;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
    }
}

