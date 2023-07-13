namespace ContextMenu
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
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.pnlWrappingPaper = new Telerik.WinControls.UI.RadPanel();
            this.cmWrapping = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.tbGiftType = new Telerik.WinControls.UI.RadTextBox();
            this.cmGiftType = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miGiftType1 = new Telerik.WinControls.UI.RadMenuItem();
            this.miGiftType2 = new Telerik.WinControls.UI.RadMenuItem();
            this.miGiftType3 = new Telerik.WinControls.UI.RadMenuItem();
            this.miGiftType4 = new Telerik.WinControls.UI.RadMenuItem();
            this.lblDeliveryMethod = new System.Windows.Forms.Label();
            this.cmDeliveryMethod = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.mbiDeliveryMethod1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.mbiDeliveryMethod2 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.mbiDeliveryMethod3 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.mbiDeliveryMethod4 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pnlWrappingPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWrappingPaper
            // 
            this.pnlWrappingPaper.BackColor = System.Drawing.Color.Transparent;
            this.pnlWrappingPaper.Location = new System.Drawing.Point(21, 89);
            this.pnlWrappingPaper.Name = "pnlWrappingPaper";
            this.radContextMenuManager1.SetRadContextMenu(this.pnlWrappingPaper, this.cmWrapping);
            this.pnlWrappingPaper.Size = new System.Drawing.Size(260, 109);
            this.pnlWrappingPaper.TabIndex = 10;
            this.pnlWrappingPaper.Text = "Right-click to choose wrapping paper";
            // 
            // tbGiftType
            // 
            this.tbGiftType.BackColor = System.Drawing.Color.Transparent;
            this.tbGiftType.Location = new System.Drawing.Point(90, 31);
            this.tbGiftType.Name = "tbGiftType";
            this.tbGiftType.NullText = "Right-click to enter a gift type";
            this.radContextMenuManager1.SetRadContextMenu(this.tbGiftType, this.cmGiftType);
            this.tbGiftType.ReadOnly = true;
            this.tbGiftType.Size = new System.Drawing.Size(190, 20);
            this.tbGiftType.TabIndex = 9;
            this.tbGiftType.ThemeName = "Office2007Silver";
            // 
            // cmGiftType
            // 
            this.cmGiftType.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miGiftType1,
            this.miGiftType2,
            this.miGiftType3,
            this.miGiftType4});
            // 
            // miGiftType1
            // 
            this.miGiftType1.Name = "miGiftType1";
            this.miGiftType1.Text = "Birthday";
            this.miGiftType1.Click += new System.EventHandler(this.miGiftTypeClick);
            // 
            // miGiftType2
            // 
            this.miGiftType2.Name = "miGiftType2";
            this.miGiftType2.Text = "Anniversary";
            this.miGiftType2.Click += new System.EventHandler(this.miGiftTypeClick);
            // 
            // miGiftType3
            // 
            this.miGiftType3.Name = "miGiftType3";
            this.miGiftType3.Text = "Get Well Soon";
            this.miGiftType3.Click += new System.EventHandler(this.miGiftTypeClick);
            // 
            // miGiftType4
            // 
            this.miGiftType4.Name = "miGiftType4";
            this.miGiftType4.Text = "Thank You";
            this.miGiftType4.Click += new System.EventHandler(this.miGiftTypeClick);
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryMethod.Location = new System.Drawing.Point(18, 219);
            this.lblDeliveryMethod.MinimumSize = new System.Drawing.Size(260, 50);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.radContextMenuManager1.SetRadContextMenu(this.lblDeliveryMethod, this.cmDeliveryMethod);
            this.lblDeliveryMethod.Size = new System.Drawing.Size(260, 50);
            this.lblDeliveryMethod.TabIndex = 8;
            this.lblDeliveryMethod.Text = "Right-click to choose delivery method";
            // 
            // cmDeliveryMethod
            // 
            this.cmDeliveryMethod.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mbiDeliveryMethod1,
            this.mbiDeliveryMethod2,
            this.mbiDeliveryMethod3,
            this.mbiDeliveryMethod4});
            // 
            // mbiDeliveryMethod1
            // 
            // 
            // 
            // 
            this.mbiDeliveryMethod1.ButtonElement.Class = "RadMenuButtonElement";
            this.mbiDeliveryMethod1.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbiDeliveryMethod1.Name = "mbiDeliveryMethod1";
            this.mbiDeliveryMethod1.Text = "Priority Overnight";
            this.mbiDeliveryMethod1.Click += new System.EventHandler(this.mbiDeliveryMethodClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod1.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod1.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // mbiDeliveryMethod2
            // 
            // 
            // 
            // 
            this.mbiDeliveryMethod2.ButtonElement.Class = "RadMenuButtonElement";
            this.mbiDeliveryMethod2.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbiDeliveryMethod2.Name = "mbiDeliveryMethod2";
            this.mbiDeliveryMethod2.Text = "Standard Overnight";
            this.mbiDeliveryMethod2.Click += new System.EventHandler(this.mbiDeliveryMethodClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod2.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod2.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // mbiDeliveryMethod3
            // 
            // 
            // 
            // 
            this.mbiDeliveryMethod3.ButtonElement.Class = "RadMenuButtonElement";
            this.mbiDeliveryMethod3.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbiDeliveryMethod3.Name = "mbiDeliveryMethod3";
            this.mbiDeliveryMethod3.Text = "2 Day";
            this.mbiDeliveryMethod3.Click += new System.EventHandler(this.mbiDeliveryMethodClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod3.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod3.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // mbiDeliveryMethod4
            // 
            // 
            // 
            // 
            this.mbiDeliveryMethod4.ButtonElement.Class = "RadMenuButtonElement";
            this.mbiDeliveryMethod4.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbiDeliveryMethod4.Name = "mbiDeliveryMethod4";
            this.mbiDeliveryMethod4.Text = "3 Day";
            this.mbiDeliveryMethod4.Click += new System.EventHandler(this.mbiDeliveryMethodClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod4.GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.mbiDeliveryMethod4.GetChildAt(2))).Class = "RadMenuButtonElement";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Location = new System.Drawing.Point(19, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 14);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Gift Type";
            this.radLabel1.ThemeName = "Office2007Silver";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Location = new System.Drawing.Point(20, 69);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(86, 14);
            this.radLabel2.TabIndex = 12;
            this.radLabel2.Text = "Wrapping Paper";
            this.radLabel2.ThemeName = "Office2007Silver";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 279);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.pnlWrappingPaper);
            this.Controls.Add(this.tbGiftType);
            this.Controls.Add(this.lblDeliveryMethod);
            this.Name = "RadForm1";
            this.Text = "Context Menus";
            this.ThemeName = "Office2007Silver";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlWrappingPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.UI.RadContextMenu cmDeliveryMethod;
        private Telerik.WinControls.UI.RadContextMenu cmWrapping;
        private Telerik.WinControls.UI.RadContextMenu cmGiftType;
        private Telerik.WinControls.UI.RadPanel pnlWrappingPaper;
        private Telerik.WinControls.UI.RadTextBox tbGiftType;
        private Telerik.WinControls.UI.RadMenuItem miGiftType1;
        private Telerik.WinControls.UI.RadMenuItem miGiftType2;
        private Telerik.WinControls.UI.RadMenuItem miGiftType3;
        private Telerik.WinControls.UI.RadMenuItem miGiftType4;

        private Telerik.WinControls.UI.RadMenuButtonItem mbiDeliveryMethod1;
        private Telerik.WinControls.UI.RadMenuButtonItem mbiDeliveryMethod2;
        private Telerik.WinControls.UI.RadMenuButtonItem mbiDeliveryMethod3;
        private Telerik.WinControls.UI.RadMenuButtonItem mbiDeliveryMethod4;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Label lblDeliveryMethod;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
    }
}

