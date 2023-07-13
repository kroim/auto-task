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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.miAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.miItalic = new Telerik.WinControls.UI.RadMenuItem();
            this.miBold = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.miPaste = new Telerik.WinControls.UI.RadMenuItem();
            this.miCopy = new Telerik.WinControls.UI.RadMenuItem();
            this.miCut = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.miQuit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.miSave = new Telerik.WinControls.UI.RadMenuItem();
            this.miOpen = new Telerik.WinControls.UI.RadMenuItem();
            this.miNew = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.tbContent.HideSelection = false;
            this.tbContent.Location = new System.Drawing.Point(8, 28);
            this.tbContent.Name = "tbContent";
            this.tbContent.ShowSelectionMargin = true;
            this.tbContent.Size = new System.Drawing.Size(534, 242);
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
            // miAbout
            // 
            this.miAbout.AccessibleDescription = "About";
            this.miAbout.AccessibleName = "About";
            this.miAbout.Class = "";
            this.miAbout.ImageKey = "help.png";
            this.miAbout.Name = "miAbout";
            this.miAbout.Text = "About";
            this.miAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miAbout.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Help";
            this.radMenuItem4.AccessibleName = "Help";
            this.radMenuItem4.Class = "";
            this.radMenuItem4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miAbout});
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Help";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // miItalic
            // 
            this.miItalic.AccessibleDescription = "Italic";
            this.miItalic.AccessibleName = "Italic";
            this.miItalic.CheckOnClick = true;
            this.miItalic.Class = "";
            this.miItalic.ImageKey = "ItalicHS.png";
            this.miItalic.Name = "miItalic";
            this.miItalic.Text = "Italic";
            this.miItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miItalic.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miItalic.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.miItalic_ToggleStateChanged);
            // 
            // miBold
            // 
            this.miBold.AccessibleDescription = "Bold";
            this.miBold.AccessibleName = "Bold";
            this.miBold.CheckOnClick = true;
            this.miBold.Class = "";
            this.miBold.ImageKey = "boldhs.png";
            this.miBold.Name = "miBold";
            this.miBold.Text = "Bold";
            this.miBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miBold.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miBold.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.miBold_ToggleStateChanged);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Format";
            this.radMenuItem3.AccessibleName = "Format";
            this.radMenuItem3.Class = "";
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miBold,
            this.miItalic});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Format";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // miPaste
            // 
            this.miPaste.AccessibleDescription = "Paste";
            this.miPaste.AccessibleName = "Paste";
            this.miPaste.Class = "";
            this.miPaste.ImageKey = "paste.png";
            this.miPaste.Name = "miPaste";
            this.miPaste.Text = "Paste";
            this.miPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miPaste.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miCopy
            // 
            this.miCopy.AccessibleDescription = "Copy";
            this.miCopy.AccessibleName = "Copy";
            this.miCopy.Class = "";
            this.miCopy.ImageKey = "copy.png";
            this.miCopy.Name = "miCopy";
            this.miCopy.Text = "Copy";
            this.miCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miCopy.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miCut
            // 
            this.miCut.AccessibleDescription = "Cut";
            this.miCut.AccessibleName = "Cut";
            this.miCut.Class = "";
            this.miCut.ImageKey = "cut.png";
            this.miCut.Name = "miCut";
            this.miCut.Text = "Cut";
            this.miCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miCut.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Edit";
            this.radMenuItem2.AccessibleName = "Edit";
            this.radMenuItem2.Class = "";
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miCut,
            this.miCopy,
            this.miPaste});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Edit";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // miQuit
            // 
            this.miQuit.AccessibleDescription = "Quit";
            this.miQuit.AccessibleName = "Quit";
            this.miQuit.Class = "";
            this.miQuit.Name = "miQuit";
            this.miQuit.Padding = new System.Windows.Forms.Padding(3);
            this.miQuit.Text = "Quit";
            this.miQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miQuit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Class = "";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // miSave
            // 
            this.miSave.AccessibleDescription = "Save";
            this.miSave.AccessibleName = "Save";
            this.miSave.Class = "";
            this.miSave.ImageKey = "FloppyDisk.png";
            this.miSave.Name = "miSave";
            this.miSave.Padding = new System.Windows.Forms.Padding(3);
            this.miSave.Text = "Save";
            this.miSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miOpen
            // 
            this.miOpen.AccessibleDescription = "Open";
            this.miOpen.AccessibleName = "Open";
            this.miOpen.Class = "";
            this.miOpen.ImageKey = "Folder_Open.png";
            this.miOpen.Name = "miOpen";
            this.miOpen.Padding = new System.Windows.Forms.Padding(3);
            this.miOpen.Text = "Open";
            this.miOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miNew
            // 
            this.miNew.AccessibleDescription = "New";
            this.miNew.AccessibleName = "New";
            this.miNew.BackColor = System.Drawing.Color.Red;
            this.miNew.ImageKey = "NewDocumentHS.png";
            this.miNew.Name = "miNew";
            this.miNew.Padding = new System.Windows.Forms.Padding(3);
            this.miNew.Text = "New";
            this.miNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.miNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "File";
            this.radMenuItem1.AccessibleName = "File";
            this.radMenuItem1.Class = "";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.radMenuSeparatorItem1,
            this.miQuit});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenu1
            // 
            this.radMenu1.ImageList = this.imageList1;
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(550, 28);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "Office2007Silver";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 279);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.radMenu1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Menus";
            this.ThemeName = "Office2007Silver";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadMenuItem miAbout;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem miItalic;
        private Telerik.WinControls.UI.RadMenuItem miBold;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem miPaste;
        private Telerik.WinControls.UI.RadMenuItem miCopy;
        private Telerik.WinControls.UI.RadMenuItem miCut;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem miQuit;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem miSave;
        private Telerik.WinControls.UI.RadMenuItem miOpen;
        private Telerik.WinControls.UI.RadMenuItem miNew;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
    }
}

