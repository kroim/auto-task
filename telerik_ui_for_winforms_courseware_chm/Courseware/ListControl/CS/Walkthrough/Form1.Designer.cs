namespace Walkthrough
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ddlDrives = new Telerik.WinControls.UI.RadDropDownList();
            this.lcFiles = new Telerik.WinControls.UI.RadListControl();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDrives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlDrives
            // 
            this.ddlDrives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlDrives.Location = new System.Drawing.Point(72, 12);
            this.ddlDrives.Name = "ddlDrives";
            this.ddlDrives.ShowImageInEditorArea = true;
            this.ddlDrives.Size = new System.Drawing.Size(328, 20);
            this.ddlDrives.TabIndex = 1;
            this.ddlDrives.Text = "radDropDownList1";
            // 
            // lcFiles
            // 
            this.lcFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lcFiles.CaseSensitiveSort = true;
            this.lcFiles.ItemHeight = 18;
            this.lcFiles.Location = new System.Drawing.Point(12, 38);
            this.lcFiles.Name = "lcFiles";
            this.lcFiles.Size = new System.Drawing.Size(388, 287);
            this.lcFiles.TabIndex = 2;
            this.lcFiles.Text = "radListControl1";
            this.lcFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lcFiles_MouseUp);
            this.lcFiles.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.lcFiles_SelectedIndexChanged);
            this.lcFiles.DoubleClick += new System.EventHandler(this.lcFiles_DoubleClick);
            this.lcFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lcFiles_MouseDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 331);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(412, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "radLabel1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Symbol Error.ico");
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 19);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 351);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lcFiles);
            this.Controls.Add(this.ddlDrives);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddlDrives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlDrives;
        private Telerik.WinControls.UI.RadListControl lcFiles;
        private Telerik.WinControls.UI.RadLabel lblStatus;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton btnBack;

    }
}

