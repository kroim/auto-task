namespace MovingItems
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            this.lcLeft = new Telerik.WinControls.UI.RadListControl();
            this.lcRight = new Telerik.WinControls.UI.RadListControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lcLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lcLeft
            // 
            this.lcLeft.CaseSensitiveSort = true;
            this.lcLeft.ItemHeight = 18;
            radListDataItem1.Text = "RadControls for WPF";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Sitefinity";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "OpenAccess ORM";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "RadControls for ASP.NET AJAX";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "RadControl for WinForms";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "RadControls for Silverlight";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "Telerik Reporting";
            radListDataItem7.TextWrap = true;
            this.lcLeft.Items.Add(radListDataItem1);
            this.lcLeft.Items.Add(radListDataItem2);
            this.lcLeft.Items.Add(radListDataItem3);
            this.lcLeft.Items.Add(radListDataItem4);
            this.lcLeft.Items.Add(radListDataItem5);
            this.lcLeft.Items.Add(radListDataItem6);
            this.lcLeft.Items.Add(radListDataItem7);
            this.lcLeft.Location = new System.Drawing.Point(27, 49);
            this.lcLeft.Name = "lcLeft";
            this.lcLeft.Size = new System.Drawing.Size(221, 238);
            this.lcLeft.TabIndex = 0;
            this.lcLeft.Text = "radListControl1";
            this.lcLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lcLeft_MouseUp);
            this.lcLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lcLeft_MouseDown);
            this.lcLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lcLeft_MouseMove);
            // 
            // lcRight
            // 
            this.lcRight.CaseSensitiveSort = true;
            this.lcRight.ItemHeight = 18;
            this.lcRight.Location = new System.Drawing.Point(288, 49);
            this.lcRight.Name = "lcRight";
            this.lcRight.Size = new System.Drawing.Size(221, 238);
            this.lcRight.TabIndex = 1;
            this.lcRight.Text = "radListControl2";
            this.lcRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.lcRight_DragDrop);
            this.lcRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.lcRight_DragEnter);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(30, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Source";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(288, 25);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Destination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 318);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lcRight);
            this.Controls.Add(this.lcLeft);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl lcLeft;
        private Telerik.WinControls.UI.RadListControl lcRight;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}

