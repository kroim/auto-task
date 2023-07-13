namespace GettingStarted
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
            this.ddbImages = new Telerik.WinControls.UI.RadDropDownButton();
            this.sbSizeMode = new Telerik.WinControls.UI.RadSplitButton();
            this.btnSizeModeNormal = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeStretch = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeAutoSize = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeCenterImage = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeZoom = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFlip = new Telerik.WinControls.UI.RadCheckBox();
            this.cbVerticalFlip = new Telerik.WinControls.UI.RadCheckBox();
            this.rbRotate = new Telerik.WinControls.UI.RadRepeatButton();
            this.cbHorizontalFlip = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFixed3D = new Telerik.WinControls.UI.RadRadioButton();
            this.rbFixedSingle = new Telerik.WinControls.UI.RadRadioButton();
            this.rbNone = new Telerik.WinControls.UI.RadRadioButton();
            this.tbBackgroundColor = new Telerik.WinControls.UI.RadToggleButton();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.telerikTheme1 = new Telerik.WinControls.Themes.TelerikTheme();
            ((System.ComponentModel.ISupportInitialize)(this.ddbImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSizeMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVerticalFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHorizontalFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixed3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixedSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackgroundColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ddbImages
            // 
            this.ddbImages.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.ddbImages.Location = new System.Drawing.Point(325, 10);
            this.ddbImages.Name = "ddbImages";
            this.ddbImages.Size = new System.Drawing.Size(143, 24);
            this.ddbImages.TabIndex = 4;
            this.ddbImages.Text = "Choose Images";
            this.ddbImages.ThemeName = "ControlDefault";
            // 
            // sbSizeMode
            // 
            this.sbSizeMode.DefaultItem = null;
            this.sbSizeMode.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSizeModeNormal,
            this.btnSizeModeStretch,
            this.btnSizeModeAutoSize,
            this.btnSizeModeCenterImage,
            this.btnSizeModeZoom});
            this.sbSizeMode.Location = new System.Drawing.Point(541, 13);
            this.sbSizeMode.Name = "sbSizeMode";
            this.sbSizeMode.Size = new System.Drawing.Size(130, 24);
            this.sbSizeMode.TabIndex = 6;
            this.sbSizeMode.Text = "Choose a Size Mode";
            this.sbSizeMode.ThemeName = "ControlDefault";
            // 
            // btnSizeModeNormal
            // 
            // 
            // 
            // 
            this.btnSizeModeNormal.ButtonElement.Class = "RadMenuButtonElement";
            this.btnSizeModeNormal.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSizeModeNormal.Name = "btnSizeModeNormal";
            this.btnSizeModeNormal.Tag = "0";
            this.btnSizeModeNormal.Text = "Normal";
            this.btnSizeModeNormal.Click += new System.EventHandler(this.SizeModeClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeNormal.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeNormal.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // btnSizeModeStretch
            // 
            // 
            // 
            // 
            this.btnSizeModeStretch.ButtonElement.Class = "RadMenuButtonElement";
            this.btnSizeModeStretch.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSizeModeStretch.Name = "btnSizeModeStretch";
            this.btnSizeModeStretch.Tag = "1";
            this.btnSizeModeStretch.Text = "Stretch Image";
            this.btnSizeModeStretch.Click += new System.EventHandler(this.SizeModeClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeStretch.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeStretch.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // btnSizeModeAutoSize
            // 
            // 
            // 
            // 
            this.btnSizeModeAutoSize.ButtonElement.Class = "RadMenuButtonElement";
            this.btnSizeModeAutoSize.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSizeModeAutoSize.Name = "btnSizeModeAutoSize";
            this.btnSizeModeAutoSize.Tag = "2";
            this.btnSizeModeAutoSize.Text = "AutoSize";
            this.btnSizeModeAutoSize.Click += new System.EventHandler(this.SizeModeClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeAutoSize.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeAutoSize.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // btnSizeModeCenterImage
            // 
            // 
            // 
            // 
            this.btnSizeModeCenterImage.ButtonElement.Class = "RadMenuButtonElement";
            this.btnSizeModeCenterImage.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSizeModeCenterImage.Name = "btnSizeModeCenterImage";
            this.btnSizeModeCenterImage.Tag = "3";
            this.btnSizeModeCenterImage.Text = "Center Image";
            this.btnSizeModeCenterImage.Click += new System.EventHandler(this.SizeModeClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeCenterImage.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeCenterImage.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // btnSizeModeZoom
            // 
            // 
            // 
            // 
            this.btnSizeModeZoom.ButtonElement.Class = "RadMenuButtonElement";
            this.btnSizeModeZoom.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSizeModeZoom.Name = "btnSizeModeZoom";
            this.btnSizeModeZoom.Tag = "4";
            this.btnSizeModeZoom.Text = "Zoom";
            this.btnSizeModeZoom.Click += new System.EventHandler(this.SizeModeClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeZoom.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSizeModeZoom.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.Controls.Add(this.groupBox2);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.groupBox1);
            this.radPanel1.Controls.Add(this.sbSizeMode);
            this.radPanel1.Controls.Add(this.tbBackgroundColor);
            this.radPanel1.Controls.Add(this.ddbImages);
            this.radPanel1.Controls.Add(this.btnLoad);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(683, 126);
            this.radPanel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFlip);
            this.groupBox2.Controls.Add(this.cbVerticalFlip);
            this.groupBox2.Controls.Add(this.rbRotate);
            this.groupBox2.Controls.Add(this.cbHorizontalFlip);
            this.groupBox2.Location = new System.Drawing.Point(266, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 57);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Rotation";
            // 
            // cbFlip
            // 
            this.cbFlip.AllowShowFocusCues = true;
            this.cbFlip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cbFlip.Location = new System.Drawing.Point(142, 21);
            this.cbFlip.Name = "cbFlip";
            this.cbFlip.Size = new System.Drawing.Size(37, 14);
            this.cbFlip.TabIndex = 22;
            this.cbFlip.Text = "Flip";
            this.cbFlip.ThemeName = "ControlDefault";
            // 
            // cbVerticalFlip
            // 
            this.cbVerticalFlip.AllowShowFocusCues = true;
            this.cbVerticalFlip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cbVerticalFlip.Location = new System.Drawing.Point(298, 21);
            this.cbVerticalFlip.Name = "cbVerticalFlip";
            this.cbVerticalFlip.Size = new System.Drawing.Size(77, 14);
            this.cbVerticalFlip.TabIndex = 21;
            this.cbVerticalFlip.Text = "Vertical Flip";
            this.cbVerticalFlip.ThemeName = "ControlDefault";
            // 
            // rbRotate
            // 
            this.rbRotate.AllowShowFocusCues = true;
            this.rbRotate.Interval = 1000;
            this.rbRotate.Location = new System.Drawing.Point(20, 18);
            this.rbRotate.Name = "rbRotate";
            this.rbRotate.Size = new System.Drawing.Size(100, 23);
            this.rbRotate.TabIndex = 20;
            this.rbRotate.Text = "Rotate";
            this.rbRotate.ThemeName = "ControlDefault";
            // 
            // cbHorizontalFlip
            // 
            this.cbHorizontalFlip.AllowShowFocusCues = true;
            this.cbHorizontalFlip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cbHorizontalFlip.Location = new System.Drawing.Point(190, 21);
            this.cbHorizontalFlip.Name = "cbHorizontalFlip";
            this.cbHorizontalFlip.Size = new System.Drawing.Size(91, 14);
            this.cbHorizontalFlip.TabIndex = 19;
            this.cbHorizontalFlip.Text = "Horizontal Flip";
            this.cbHorizontalFlip.ThemeName = "ControlDefault";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(275, 13);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(44, 14);
            this.radLabel2.TabIndex = 16;
            this.radLabel2.Text = "Images:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(474, 11);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(61, 14);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "Size Mode:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFixed3D);
            this.groupBox1.Controls.Add(this.rbFixedSingle);
            this.groupBox1.Controls.Add(this.rbNone);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border Style";
            // 
            // rbFixed3D
            // 
            this.rbFixed3D.AllowShowFocusCues = true;
            this.rbFixed3D.IsChecked = true;
            this.rbFixed3D.Location = new System.Drawing.Point(167, 21);
            this.rbFixed3D.Name = "rbFixed3D";
            this.rbFixed3D.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbFixed3D.Size = new System.Drawing.Size(62, 16);
            this.rbFixed3D.TabIndex = 16;
            this.rbFixed3D.Tag = "2";
            this.rbFixed3D.Text = "Fixed3D";
            this.rbFixed3D.ThemeName = "ControlDefault";
            this.rbFixed3D.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rbFixed3D.Click += new System.EventHandler(this.BorderStyleClick);
            // 
            // rbFixedSingle
            // 
            this.rbFixedSingle.AllowShowFocusCues = true;
            this.rbFixedSingle.Location = new System.Drawing.Point(68, 21);
            this.rbFixedSingle.Name = "rbFixedSingle";
            this.rbFixedSingle.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbFixedSingle.Size = new System.Drawing.Size(83, 16);
            this.rbFixedSingle.TabIndex = 15;
            this.rbFixedSingle.Tag = "1";
            this.rbFixedSingle.Text = "Fixed Single";
            this.rbFixedSingle.ThemeName = "ControlDefault";
            this.rbFixedSingle.Click += new System.EventHandler(this.BorderStyleClick);
            // 
            // rbNone
            // 
            this.rbNone.AllowShowFocusCues = true;
            this.rbNone.Location = new System.Drawing.Point(6, 21);
            this.rbNone.Name = "rbNone";
            this.rbNone.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbNone.Size = new System.Drawing.Size(47, 16);
            this.rbNone.TabIndex = 14;
            this.rbNone.Tag = "0";
            this.rbNone.Text = "None";
            this.rbNone.ThemeName = "ControlDefault";
            this.rbNone.Click += new System.EventHandler(this.BorderStyleClick);
            // 
            // tbBackgroundColor
            // 
            this.tbBackgroundColor.AllowShowFocusCues = true;
            this.tbBackgroundColor.Location = new System.Drawing.Point(103, 12);
            this.tbBackgroundColor.Name = "tbBackgroundColor";
            this.tbBackgroundColor.Size = new System.Drawing.Size(156, 23);
            this.tbBackgroundColor.TabIndex = 11;
            this.tbBackgroundColor.Text = "Contrast Background";
            this.tbBackgroundColor.ThemeName = "ControlDefault";
            // 
            // btnLoad
            // 
            this.btnLoad.AllowShowFocusCues = true;
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.ThemeName = "ControlDefault";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 318);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radPanel1);
            this.Name = "RadForm1";
            this.Text = "Buttons";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddbImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSizeMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVerticalFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHorizontalFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixed3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixedSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackgroundColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownButton ddbImages;
        private Telerik.WinControls.UI.RadSplitButton sbSizeMode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.UI.RadToggleButton tbBackgroundColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadRadioButton rbFixed3D;
        private Telerik.WinControls.UI.RadRadioButton rbFixedSingle;
        private Telerik.WinControls.UI.RadRadioButton rbNone;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeNormal;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeStretch;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeAutoSize;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeCenterImage;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeZoom;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.TelerikTheme telerikTheme1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadCheckBox cbFlip;
        private Telerik.WinControls.UI.RadCheckBox cbVerticalFlip;
        private Telerik.WinControls.UI.RadRepeatButton rbRotate;
        private Telerik.WinControls.UI.RadCheckBox cbHorizontalFlip;
    }
}

