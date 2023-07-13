namespace GettingStarted
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
            this.ddlDrives = new Telerik.WinControls.UI.RadDropDownList();
            this.lcFiles = new Telerik.WinControls.UI.RadListControl();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDrives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlDrives
            // 
            this.ddlDrives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlDrives.Location = new System.Drawing.Point(12, 12);
            this.ddlDrives.Name = "ddlDrives";
            this.ddlDrives.ShowImageInEditorArea = true;
            this.ddlDrives.Size = new System.Drawing.Size(388, 20);
            this.ddlDrives.TabIndex = 1;
            this.ddlDrives.Text = "radDropDownList1";
            this.ddlDrives.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlDrives_SelectedIndexChanged);
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
            this.lcFiles.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.lcFiles_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 351);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lcFiles);
            this.Controls.Add(this.ddlDrives);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddlDrives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlDrives;
        private Telerik.WinControls.UI.RadListControl lcFiles;
        private Telerik.WinControls.UI.RadLabel lblStatus;
    }
}