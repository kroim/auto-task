namespace ThreadingWalkthrough
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
            this.ssMain = new Telerik.WinControls.UI.RadStatusStrip();
            this.btnServers = new Telerik.WinControls.UI.RadButtonElement();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.lblHost = new Telerik.WinControls.UI.RadLabelElement();
            this.pbStatus = new Telerik.WinControls.UI.RadProgressBarElement();
            this.lblServers = new Telerik.WinControls.UI.RadLabel();
            this.lblDatabases = new Telerik.WinControls.UI.RadLabel();
            this.lbDatabases = new Telerik.WinControls.UI.RadListControl();
            this.lbServers = new Telerik.WinControls.UI.RadListControl();
            this.pnlMaxObjects = new Telerik.WinControls.UI.RadPanel();
            this.lblCount = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tbMaxObjects = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ssMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMaxObjects)).BeginInit();
            this.pnlMaxObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.AutoSize = true;
            this.ssMain.BackColor = System.Drawing.Color.Transparent;
            this.ssMain.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnServers,
            this.lblStatus,
            this.lblHost,
            this.pbStatus});
            this.ssMain.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.ssMain.Location = new System.Drawing.Point(0, 313);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(621, 62);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 0;
            this.ssMain.Text = "radStatusStrip1";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.ssMain.GetChildAt(0))).Text = "radStatusStrip1";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.ssMain.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2);
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.ssMain.GetChildAt(0))).MinSize = new System.Drawing.Size(0, 19);
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.ssMain.GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ssMain.GetChildAt(0).GetChildAt(0))).ForeColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ssMain.GetChildAt(0).GetChildAt(0))).ForeColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ssMain.GetChildAt(0).GetChildAt(0))).ForeColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.ssMain.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // btnServers
            // 
            this.btnServers.AccessibleDescription = "Find\r\nServers";
            this.btnServers.AccessibleName = "Find\r\nServers";
            this.btnServers.CanFocus = true;
            this.btnServers.Image = global::ThreadingWalkthrough.Properties.Resources.FindServers;
            this.btnServers.Margin = new System.Windows.Forms.Padding(1);
            this.btnServers.Name = "btnServers";
            this.btnServers.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.ssMain.SetSpring(this.btnServers, false);
            this.btnServers.Text = "Find\r\nServers";
            this.btnServers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServers.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnServers.Click += new System.EventHandler(this.btnServers_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatus.Name = "lblStatus";
            this.ssMain.SetSpring(this.lblStatus, true);
            this.lblStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = false;
            this.lblHost.BackColor = System.Drawing.Color.Transparent;
            this.lblHost.Bounds = new System.Drawing.Rectangle(0, 0, 54, 54);
            this.lblHost.Margin = new System.Windows.Forms.Padding(1);
            this.lblHost.Name = "lblHost";
            this.ssMain.SetSpring(this.lblHost, false);
            this.lblHost.TextWrap = true;
            this.lblHost.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // pbStatus
            // 
            this.pbStatus.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pbStatus.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.pbStatus.ClipDrawing = true;
            this.pbStatus.DefaultSize = new System.Drawing.Size(130, 16);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(1);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pbStatus.SeparatorColor1 = System.Drawing.Color.White;
            this.pbStatus.SeparatorColor2 = System.Drawing.Color.White;
            this.pbStatus.SeparatorColor3 = System.Drawing.Color.White;
            this.pbStatus.SeparatorColor4 = System.Drawing.Color.White;
            this.pbStatus.SeparatorGradientAngle = 0;
            this.pbStatus.SeparatorGradientPercentage1 = 0.4F;
            this.pbStatus.SeparatorGradientPercentage2 = 0.6F;
            this.pbStatus.SeparatorNumberOfColors = 2;
            this.ssMain.SetSpring(this.pbStatus, false);
            this.pbStatus.StepWidth = 14;
            this.pbStatus.StretchVertically = false;
            this.pbStatus.SweepAngle = 90;
            this.pbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pbStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblServers
            // 
            this.lblServers.BackColor = System.Drawing.Color.Transparent;
            this.lblServers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServers.Location = new System.Drawing.Point(12, 12);
            this.lblServers.Name = "lblServers";
            this.lblServers.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            // 
            // 
            // 
            this.lblServers.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServers.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblServers.Size = new System.Drawing.Size(47, 18);
            this.lblServers.TabIndex = 2;
            this.lblServers.Text = "Servers";
            // 
            // lblDatabases
            // 
            this.lblDatabases.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabases.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDatabases.Location = new System.Drawing.Point(14, 138);
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            // 
            // 
            // 
            this.lblDatabases.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDatabases.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblDatabases.Size = new System.Drawing.Size(62, 18);
            this.lblDatabases.TabIndex = 4;
            this.lblDatabases.Text = "Databases";
            // 
            // lbDatabases
            // 
            this.lbDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatabases.CaseSensitiveSort = true;
            this.lbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabases.ItemHeight = 18;
            this.lbDatabases.Location = new System.Drawing.Point(14, 158);
            this.lbDatabases.Name = "lbDatabases";
            this.lbDatabases.Size = new System.Drawing.Size(595, 87);
            this.lbDatabases.TabIndex = 5;
            this.lbDatabases.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.lbDatabases_SelectedIndexChanged);
            // 
            // lbServers
            // 
            this.lbServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbServers.CaseSensitiveSort = true;
            this.lbServers.ItemHeight = 18;
            this.lbServers.Location = new System.Drawing.Point(12, 32);
            this.lbServers.Name = "lbServers";
            this.lbServers.Size = new System.Drawing.Size(597, 87);
            this.lbServers.TabIndex = 6;
            this.lbServers.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.lbServers_SelectedIndexChanged);
            // 
            // pnlMaxObjects
            // 
            this.pnlMaxObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaxObjects.BackColor = System.Drawing.Color.Transparent;
            this.pnlMaxObjects.Controls.Add(this.lblCount);
            this.pnlMaxObjects.Controls.Add(this.radLabel1);
            this.pnlMaxObjects.Controls.Add(this.tbMaxObjects);
            this.pnlMaxObjects.Location = new System.Drawing.Point(371, 259);
            this.pnlMaxObjects.Name = "pnlMaxObjects";
            this.pnlMaxObjects.Size = new System.Drawing.Size(238, 48);
            this.pnlMaxObjects.TabIndex = 8;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCount.Location = new System.Drawing.Point(199, 11);
            this.lblCount.Name = "lblCount";
            // 
            // 
            // 
            this.lblCount.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCount.Size = new System.Drawing.Size(12, 18);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radLabel1.Location = new System.Drawing.Point(8, 11);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radLabel1.Size = new System.Drawing.Size(46, 33);
            this.radLabel1.TabIndex = 8;
            this.radLabel1.Text = "Max\r\nObjects:";
            // 
            // tbMaxObjects
            // 
            this.tbMaxObjects.Location = new System.Drawing.Point(61, 11);
            this.tbMaxObjects.Maximum = 100;
            this.tbMaxObjects.Name = "tbMaxObjects";
            this.tbMaxObjects.ShowTicks = false;
            this.tbMaxObjects.Size = new System.Drawing.Size(123, 30);
            this.tbMaxObjects.SlideAreaWidth = 2;
            this.tbMaxObjects.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke;
            this.tbMaxObjects.SliderAreaColor2 = System.Drawing.Color.DarkGray;
            this.tbMaxObjects.SliderAreaGradientAngle = 270F;
            this.tbMaxObjects.TabIndex = 10;
            this.tbMaxObjects.ThumbWidth = 18;
            this.tbMaxObjects.TicksColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbMaxObjects.ValueChanged += new System.EventHandler(this.tbMaxObjects_ValueChanged);
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).SliderAreaGradientColor1 = System.Drawing.Color.WhiteSmoke;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).SliderAreaGradientColor2 = System.Drawing.Color.DarkGray;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).SliderAreaGradientAngle = 270F;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).ShowTicks = false;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).SlideAreaWidth = 2;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.tbMaxObjects.GetChildAt(0))).Maximum = 100;
            ((Telerik.WinControls.Primitives.TrackBarPrimitive)(this.tbMaxObjects.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.TrackBarPrimitive)(this.tbMaxObjects.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tbMaxObjects.GetChildAt(0).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tbMaxObjects.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 375);
            this.Controls.Add(this.pnlMaxObjects);
            this.Controls.Add(this.lbServers);
            this.Controls.Add(this.lbDatabases);
            this.Controls.Add(this.lblDatabases);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.ssMain);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MS SQL Servers";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ssMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMaxObjects)).EndInit();
            this.pnlMaxObjects.ResumeLayout(false);
            this.pnlMaxObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip ssMain;
        private Telerik.WinControls.UI.RadListDataItem radListDataItem1;
        private Telerik.WinControls.UI.RadLabel lblServers;
        private Telerik.WinControls.UI.RadLabel lblDatabases;
        private Telerik.WinControls.UI.RadListControl lbDatabases;
        private Telerik.WinControls.UI.RadButtonElement btnServers;
        private Telerik.WinControls.UI.RadListControl lbServers;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadPanel pnlMaxObjects;
        private Telerik.WinControls.UI.RadLabel lblCount;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTrackBar tbMaxObjects;
        private Telerik.WinControls.UI.RadLabelElement lblHost;
        private Telerik.WinControls.UI.RadProgressBarElement pbStatus;
    }
}

