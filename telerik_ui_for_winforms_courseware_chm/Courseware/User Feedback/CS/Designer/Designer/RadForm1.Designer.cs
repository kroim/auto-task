namespace Designer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radSplitButtonElement1 = new Telerik.WinControls.UI.RadSplitButtonElement();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.radProgressBarElement1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.btnBuild = new Telerik.WinControls.UI.RadButton();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.ForeColor = System.Drawing.Color.Silver;
            this.radLabel1.Location = new System.Drawing.Point(38, 85);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Silver;
            this.radLabel1.Size = new System.Drawing.Size(165, 16);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Building MFG part X7712-78. . .";
            this.radLabel1.ThemeName = "Desert";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "Building MFG part X7712-78. . .";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).StretchVertically = false;
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.radTrackBar1.Location = new System.Drawing.Point(12, 12);
            this.radTrackBar1.Maximum = 100;
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Size = new System.Drawing.Size(374, 40);
            this.radTrackBar1.SlideAreaWidth = 2;
            this.radTrackBar1.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke;
            this.radTrackBar1.SliderAreaColor2 = System.Drawing.Color.DarkGray;
            this.radTrackBar1.TabIndex = 2;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.ThemeName = "Desert";
            this.radTrackBar1.TickFrequency = 5;
            this.radTrackBar1.TicksColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(150)))), ((int)(((byte)(194)))));
            this.radTrackBar1.Value = 20;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.ImageList = this.imageList1;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radSplitButtonElement1,
            this.radCheckBoxElement1,
            this.radProgressBarElement1});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 172);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(398, 46);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Desert";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "preferences.png");
            this.imageList1.Images.SetKeyName(1, "Printer.png");
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "Build";
            this.radButtonElement1.AccessibleName = "Build";
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement1.Image")));
            this.radButtonElement1.ImageKey = "preferences.png";
            this.radButtonElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Padding = new System.Windows.Forms.Padding(5);
            this.radStatusStrip1.SetSpring(this.radButtonElement1, false);
            this.radButtonElement1.Text = "Build";
            this.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radSplitButtonElement1
            // 
            this.radSplitButtonElement1.AccessibleDescription = "Print";
            this.radSplitButtonElement1.AccessibleName = "Print";
            this.radSplitButtonElement1.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.radSplitButtonElement1.DefaultItem = null;
            this.radSplitButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radSplitButtonElement1.ExpandArrowButton = false;
            this.radSplitButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("radSplitButtonElement1.Image")));
            this.radSplitButtonElement1.ImageKey = "Printer.png";
            this.radSplitButtonElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radSplitButtonElement1.Name = "radSplitButtonElement1";
            this.radStatusStrip1.SetSpring(this.radSplitButtonElement1, false);
            this.radSplitButtonElement1.Text = "Print";
            this.radSplitButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radSplitButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.AccessibleDescription = "Confirmation Email?";
            this.radCheckBoxElement1.AccessibleName = "Confirmation Email?";
            this.radCheckBoxElement1.CanFocus = true;
            this.radCheckBoxElement1.Checked = true;
            this.radCheckBoxElement1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radCheckBoxElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.radCheckBoxElement1.ShowBorder = false;
            this.radStatusStrip1.SetSpring(this.radCheckBoxElement1, false);
            this.radCheckBoxElement1.Text = "Confirmation Email?";
            this.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radProgressBarElement1
            // 
            this.radProgressBarElement1.AccessibleDescription = "part X7712-78. . .";
            this.radProgressBarElement1.AccessibleName = "part X7712-78. . .";
            this.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radProgressBarElement1.ClipDrawing = true;
            this.radProgressBarElement1.DefaultSize = new System.Drawing.Size(130, 16);
            this.radProgressBarElement1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.radProgressBarElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radProgressBarElement1.Name = "radProgressBarElement1";
            this.radProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorGradientAngle = 0;
            this.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F;
            this.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F;
            this.radProgressBarElement1.SeparatorNumberOfColors = 2;
            this.radStatusStrip1.SetSpring(this.radProgressBarElement1, false);
            this.radProgressBarElement1.StepWidth = 14;
            this.radProgressBarElement1.SweepAngle = 90;
            this.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radProgressBarElement1.Value1 = 20;
            this.radProgressBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(243, 76);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(130, 31);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "Build";
            this.btnBuild.ThemeName = "Desert";
            this.btnBuild.Visible = false;
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.radProgressBar1.ImageIndex = -1;
            this.radProgressBar1.ImageKey = "";
            this.radProgressBar1.Location = new System.Drawing.Point(21, 124);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorWidth = 4;
            this.radProgressBar1.ShowProgressIndicators = true;
            this.radProgressBar1.Size = new System.Drawing.Size(356, 30);
            this.radProgressBar1.StepWidth = 13;
            this.radProgressBar1.TabIndex = 6;
            this.radProgressBar1.Text = "23 %";
            this.radProgressBar1.ThemeName = "Desert";
            this.radProgressBar1.Value1 = 23;
            this.radProgressBar1.Visible = false;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 218);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radTrackBar1);
            this.Controls.Add(this.radLabel1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Build Stage";
            this.ThemeName = "Desert";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadSplitButtonElement radSplitButtonElement1;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.RadProgressBarElement radProgressBarElement1;
        private Telerik.WinControls.UI.RadButton btnBuild;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
    }
}

