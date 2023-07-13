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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabItem1 = new Telerik.WinControls.UI.TabItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.btnExit = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.qaOpen = new Telerik.WinControls.UI.RadButtonElement();
            this.qaSave = new Telerik.WinControls.UI.RadButtonElement();
            this.qaHelp = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarCommandTab1 = new Telerik.WinControls.UI.RadRibbonBarCommandTab();
            this.radRibbonBarChunk1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.miCut = new Telerik.WinControls.UI.RadButtonElement();
            this.miCopy = new Telerik.WinControls.UI.RadButtonElement();
            this.miPaste = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarChunk2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.cbBold = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.cbItalic = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.miNew = new Telerik.WinControls.UI.RadMenuItem();
            this.miOpen = new Telerik.WinControls.UI.RadMenuItem();
            this.miSave = new Telerik.WinControls.UI.RadMenuItem();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radGalleryElement1 = new Telerik.WinControls.UI.RadGalleryElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabItem1
            // 
            this.tabItem1.AccessibleDescription = "Home";
            this.tabItem1.AccessibleName = "Home";
            this.tabItem1.CanFocus = true;
            this.tabItem1.Class = "TabItem";
            // 
            // tabItem1.ContentPanel
            // 
            this.tabItem1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.tabItem1.ContentPanel.CausesValidation = true;
            this.tabItem1.ContentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabItem1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabItem1.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.tabItem1.ContentPanel.Size = new System.Drawing.Size(200, 100);
            this.tabItem1.IsSelected = true;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Home";
            this.tabItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Rich Text Files|*.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Rich Text Files|*.rtf";
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbContent.HideSelection = false;
            this.tbContent.Location = new System.Drawing.Point(8, 159);
            this.tbContent.Name = "tbContent";
            this.tbContent.ShowSelectionMargin = true;
            this.tbContent.Size = new System.Drawing.Size(530, 189);
            this.tbContent.TabIndex = 1;
            this.tbContent.Text = "";
            this.tbContent.SelectionChanged += new System.EventHandler(this.tbContent_SelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NewDocumentHS.png");
            this.imageList1.Images.SetKeyName(1, "Folder_Open.png");
            this.imageList1.Images.SetKeyName(2, "FloppyDisk.png");
            this.imageList1.Images.SetKeyName(3, "cut.png");
            this.imageList1.Images.SetKeyName(4, "copy.png");
            this.imageList1.Images.SetKeyName(5, "paste.png");
            this.imageList1.Images.SetKeyName(6, "help.png");
            this.imageList1.Images.SetKeyName(7, "boldhs.png");
            this.imageList1.Images.SetKeyName(8, "ItalicHS.png");
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "Exit";
            this.btnExit.AccessibleName = "Exit";
            // 
            // 
            // 
            this.btnExit.ButtonElement.AccessibleDescription = "Exit";
            this.btnExit.ButtonElement.AccessibleName = "Exit";
            this.btnExit.ButtonElement.Class = "RadMenuButtonElement";
            this.btnExit.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Exit";
            this.btnExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExit.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExit.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // qaOpen
            // 
            this.qaOpen.AccessibleDescription = "Open";
            this.qaOpen.AccessibleName = "Open";
            this.qaOpen.CanFocus = true;
            this.qaOpen.Class = "RibbonBarButtonElement";
            this.qaOpen.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.qaOpen.Image = ((System.Drawing.Image)(resources.GetObject("qaOpen.Image")));
            this.qaOpen.ImageKey = "Folder_Open.png";
            this.qaOpen.MaxSize = new System.Drawing.Size(0, 18);
            this.qaOpen.Name = "qaOpen";
            this.qaOpen.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.qaOpen.Text = "Open";
            this.qaOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.qaOpen.ZIndex = 2;
            this.qaOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // qaSave
            // 
            this.qaSave.AccessibleDescription = "Save";
            this.qaSave.AccessibleName = "Save";
            this.qaSave.CanFocus = true;
            this.qaSave.Class = "RibbonBarButtonElement";
            this.qaSave.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.qaSave.Image = ((System.Drawing.Image)(resources.GetObject("qaSave.Image")));
            this.qaSave.ImageKey = "FloppyDisk.png";
            this.qaSave.MaxSize = new System.Drawing.Size(0, 18);
            this.qaSave.Name = "qaSave";
            this.qaSave.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.qaSave.Text = "Save";
            this.qaSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.qaSave.ZIndex = 1;
            this.qaSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // qaHelp
            // 
            this.qaHelp.AccessibleDescription = "Help";
            this.qaHelp.AccessibleName = "Help";
            this.qaHelp.CanFocus = true;
            this.qaHelp.Class = "RibbonBarButtonElement";
            this.qaHelp.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.qaHelp.Image = ((System.Drawing.Image)(resources.GetObject("qaHelp.Image")));
            this.qaHelp.ImageKey = "help.png";
            this.qaHelp.MaxSize = new System.Drawing.Size(0, 18);
            this.qaHelp.Name = "qaHelp";
            this.qaHelp.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.qaHelp.Text = "Help";
            this.qaHelp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.qaHelp.ZIndex = 0;
            this.qaHelp.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // radRibbonBarCommandTab1
            // 
            this.radRibbonBarCommandTab1.AccessibleDescription = "Home";
            this.radRibbonBarCommandTab1.AccessibleName = "Home";
            this.radRibbonBarCommandTab1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radRibbonBarCommandTab1.CanFocus = true;
            this.radRibbonBarCommandTab1.Class = "TabItem";
            // 
            // radRibbonBarCommandTab1.ContentPanel
            // 
            this.radRibbonBarCommandTab1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.radRibbonBarCommandTab1.ContentPanel.CausesValidation = true;
            this.radRibbonBarCommandTab1.ContentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRibbonBarCommandTab1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radRibbonBarCommandTab1.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBarCommandTab1.ContentPanel.Size = new System.Drawing.Size(200, 100);
            this.radRibbonBarCommandTab1.IsSelected = true;
            this.radRibbonBarCommandTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarChunk1,
            this.radRibbonBarChunk2});
            this.radRibbonBarCommandTab1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.radRibbonBarCommandTab1.Name = "radRibbonBarCommandTab1";
            this.radRibbonBarCommandTab1.StretchHorizontally = false;
            this.radRibbonBarCommandTab1.Text = "Home";
            this.radRibbonBarCommandTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarChunk1
            // 
            this.radRibbonBarChunk1.AccessibleDescription = "Clipboard";
            this.radRibbonBarChunk1.AccessibleName = "Clipboard";
            this.radRibbonBarChunk1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miCut,
            this.miCopy,
            this.miPaste});
            this.radRibbonBarChunk1.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarChunk1.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarChunk1.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarChunk1.Name = "radRibbonBarChunk1";
            this.radRibbonBarChunk1.Text = "Clipboard";
            this.radRibbonBarChunk1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // miCut
            // 
            this.miCut.AccessibleDescription = "Cut";
            this.miCut.AccessibleName = "Cut";
            this.miCut.CanFocus = true;
            this.miCut.Class = "ButtonElement";
            this.miCut.Image = ((System.Drawing.Image)(resources.GetObject("miCut.Image")));
            this.miCut.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.miCut.ImageKey = "cut.png";
            this.miCut.Name = "miCut";
            this.miCut.SmallImageKey = "cut.png";
            this.miCut.StretchVertically = false;
            this.miCut.Text = "Cut";
            this.miCut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.miCut.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // miCopy
            // 
            this.miCopy.AccessibleDescription = "Copy";
            this.miCopy.AccessibleName = "Copy";
            this.miCopy.CanFocus = true;
            this.miCopy.Class = "ButtonElement";
            this.miCopy.Image = ((System.Drawing.Image)(resources.GetObject("miCopy.Image")));
            this.miCopy.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.miCopy.ImageKey = "copy.png";
            this.miCopy.Name = "miCopy";
            this.miCopy.SmallImageKey = "copy.png";
            this.miCopy.StretchVertically = false;
            this.miCopy.Text = "Copy";
            this.miCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.miCopy.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.AccessibleDescription = "Paste";
            this.miPaste.AccessibleName = "Paste";
            this.miPaste.CanFocus = true;
            this.miPaste.Class = "ButtonElement";
            this.miPaste.Image = ((System.Drawing.Image)(resources.GetObject("miPaste.Image")));
            this.miPaste.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.miPaste.ImageKey = "paste.png";
            this.miPaste.Name = "miPaste";
            this.miPaste.SmallImageKey = "paste.png";
            this.miPaste.StretchVertically = false;
            this.miPaste.Text = "Paste";
            this.miPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.miPaste.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // radRibbonBarChunk2
            // 
            this.radRibbonBarChunk2.AccessibleDescription = "Font";
            this.radRibbonBarChunk2.AccessibleName = "Font";
            this.radRibbonBarChunk2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cbBold,
            this.cbItalic});
            this.radRibbonBarChunk2.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarChunk2.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarChunk2.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarChunk2.Name = "radRibbonBarChunk2";
            this.radRibbonBarChunk2.Text = "Font";
            this.radRibbonBarChunk2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // cbBold
            // 
            this.cbBold.AccessibleDescription = "Bold";
            this.cbBold.AccessibleName = "Bold";
            this.cbBold.CanFocus = true;
            this.cbBold.Checked = false;
            this.cbBold.Class = "RibbonBarButtonElement";
            this.cbBold.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.cbBold.Image = ((System.Drawing.Image)(resources.GetObject("cbBold.Image")));
            this.cbBold.Name = "cbBold";
            this.cbBold.StretchVertically = false;
            this.cbBold.Text = "Bold";
            this.cbBold.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbBold.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbBold_ToggleStateChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AccessibleDescription = "Italic";
            this.cbItalic.AccessibleName = "Italic";
            this.cbItalic.CanFocus = true;
            this.cbItalic.Checked = false;
            this.cbItalic.Class = "RibbonBarButtonElement";
            this.cbItalic.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.cbItalic.Image = ((System.Drawing.Image)(resources.GetObject("cbItalic.Image")));
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.StretchVertically = false;
            this.cbItalic.Text = "Italic";
            this.cbItalic.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cbItalic.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbItalic_ToggleStateChanged);
            // 
            // miNew
            // 
            this.miNew.AccessibleDescription = "New";
            this.miNew.AccessibleName = "New";
            this.miNew.Class = "";
            this.miNew.ImageKey = "NewDocumentHS.png";
            this.miNew.Name = "miNew";
            this.miNew.Text = "New";
            this.miNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.AccessibleDescription = "Open";
            this.miOpen.AccessibleName = "Open";
            this.miOpen.Class = "";
            this.miOpen.ImageKey = "Folder_Open.png";
            this.miOpen.Name = "miOpen";
            this.miOpen.Text = "Open";
            this.miOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.AccessibleDescription = "Save";
            this.miSave.AccessibleName = "Save";
            this.miSave.Class = "";
            this.miSave.ImageKey = "FloppyDisk.png";
            this.miSave.Name = "miSave";
            this.miSave.Text = "Save";
            this.miSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.AutoSize = true;
            this.radRibbonBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarCommandTab1});
            this.radRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radRibbonBar1.EnableKeyMap = true;
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.AccessibleDescription = "Exit";
            this.radRibbonBar1.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.radRibbonBar1.ExitButton.ButtonElement.Class = "RadMenuButtonElement";
            this.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.Click += new System.EventHandler(this.radRibbonBar1_ExitButton_Click);
            this.radRibbonBar1.ImageList = this.imageList1;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.AccessibleDescription = "Options";
            this.radRibbonBar1.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.radRibbonBar1.OptionsButton.ButtonElement.Class = "RadMenuButtonElement";
            this.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.QuickAccessToolBarHeight = 40;
            this.radRibbonBar1.QuickAccessToolBarItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.qaOpen,
            this.qaSave,
            this.qaHelp});
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(550, 164);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.miNew,
            this.miOpen,
            this.miSave});
            this.radRibbonBar1.TabIndex = 2;
            this.radRibbonBar1.Text = "radRibbonBar2";
            this.radRibbonBar1.ThemeName = "Office2007Black";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "asdasdasdasdasdasdas";
            this.radRibbonBarGroup3.AccessibleName = "asdasdasdasdasdasdas";
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGalleryElement1});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "asdasdasdasdasdasdas";
            this.radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radGalleryElement1
            // 
            this.radGalleryElement1.AccessibleDescription = "radGalleryElement1";
            this.radGalleryElement1.AccessibleName = "radGalleryElement1";
            this.radGalleryElement1.Name = "radGalleryElement1";
            this.radGalleryElement1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radGalleryElement1.Text = "radGalleryElement1";
            this.radGalleryElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 357);
            this.Controls.Add(this.radRibbonBar1);
            this.Controls.Add(this.tbContent);
            this.Name = "Form1";
            this.Text = "radRibbonBar2";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.UI.TabItem tabItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem btnExit;
        private Telerik.WinControls.UI.RadButtonElement qaOpen;
        private Telerik.WinControls.UI.RadButtonElement qaSave;
        private Telerik.WinControls.UI.RadButtonElement qaHelp;
        private Telerik.WinControls.UI.RadRibbonBarCommandTab radRibbonBarCommandTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarChunk1;
        private Telerik.WinControls.UI.RadButtonElement miCut;
        private Telerik.WinControls.UI.RadButtonElement miCopy;
        private Telerik.WinControls.UI.RadButtonElement miPaste;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarChunk2;
        private Telerik.WinControls.UI.RadCheckBoxElement cbBold;
        private Telerik.WinControls.UI.RadCheckBoxElement cbItalic;
        private Telerik.WinControls.UI.RadMenuItem miNew;
        private Telerik.WinControls.UI.RadMenuItem miOpen;
        private Telerik.WinControls.UI.RadMenuItem miSave;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadGalleryElement radGalleryElement1;
    }
}

