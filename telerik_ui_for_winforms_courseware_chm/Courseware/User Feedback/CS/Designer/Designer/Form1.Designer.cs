namespace Designer
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
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.label1 = new System.Windows.Forms.Label();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radTrackBar2 = new Telerik.WinControls.UI.RadTrackBar();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(76, 102);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(221, 36);
            this.radWaitingBar1.TabIndex = 6;
            this.radWaitingBar1.WaitingIndicatorSize = new System.Drawing.Size(30, 0);
            this.radWaitingBar1.WaitingSpeed = 100;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = global::Designer.Properties.Resources.Oryx_Antelope;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 77);
            this.label1.TabIndex = 5;
            this.label1.Text = "Antelope";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.BackgroundImage = global::Designer.Properties.Resources.Oryx_Antelope;
            this.radLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radLabel1.Image = ((System.Drawing.Image)(resources.GetObject("radLabel1.Image")));
            this.radLabel1.ImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.radLabel1.ImageKey = "1403_Globe.png";
            this.radLabel1.Location = new System.Drawing.Point(158, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(139, 77);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Antelope";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "help.png");
            this.imageList1.Images.SetKeyName(1, "1403_Globe.png");
            // 
            // radTrackBar2
            // 
            this.radTrackBar2.Location = new System.Drawing.Point(12, 102);
            this.radTrackBar2.Maximum = 100;
            this.radTrackBar2.Name = "radTrackBar2";
            this.radTrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radTrackBar2.Size = new System.Drawing.Size(58, 213);
            this.radTrackBar2.SlideAreaWidth = 10;
            this.radTrackBar2.SliderAreaColor1 = System.Drawing.Color.LightGray;
            this.radTrackBar2.SliderAreaColor2 = System.Drawing.Color.Red;
            this.radTrackBar2.SliderAreaGradientAngle = 320F;
            this.radTrackBar2.TabIndex = 1;
            this.radTrackBar2.ThemeName = "Office2007Silver";
            this.radTrackBar2.TickFrequency = 10;
            this.radTrackBar2.TicksColor = System.Drawing.Color.Maroon;
            this.radTrackBar2.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            this.radTrackBar2.Value = 80;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).SliderAreaGradientColor1 = System.Drawing.Color.LightGray;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).SliderAreaGradientColor2 = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).TickColor = System.Drawing.Color.Maroon;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).SliderAreaGradientAngle = 320F;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).TickFrequency = 10;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).TrackBarOrientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).SlideAreaWidth = 10;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).Maximum = 100;
            ((Telerik.WinControls.UI.RadTrackBarElement)(this.radTrackBar2.GetChildAt(0))).Value = 80;
            ((Telerik.WinControls.UI.TrackBarThumb)(this.radTrackBar2.GetChildAt(0).GetChildAt(2))).AngleTransform = 0F;
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radProgressBar1.Dash = true;
            this.radProgressBar1.ImageIndex = -1;
            this.radProgressBar1.ImageKey = "";
            this.radProgressBar1.Location = new System.Drawing.Point(76, 173);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.Purple;
            this.radProgressBar1.SeparatorColor2 = System.Drawing.Color.Red;
            this.radProgressBar1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorWidth = 10;
            this.radProgressBar1.Size = new System.Drawing.Size(221, 35);
            this.radProgressBar1.SweepAngle = 135;
            this.radProgressBar1.TabIndex = 0;
            this.radProgressBar1.Text = "50 %";
            this.radProgressBar1.Value1 = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 452);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.radTrackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.radLabel1);
            this.Name = "Form1";
            this.Text = "User Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar2;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
    }
}

