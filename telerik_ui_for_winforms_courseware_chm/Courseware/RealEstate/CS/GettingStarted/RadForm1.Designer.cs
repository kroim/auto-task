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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement6 = new Telerik.WinControls.UI.RadButtonElement();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radRotator1 = new Telerik.WinControls.UI.RadRotator();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            this.toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindow1;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.radSplitContainer1);
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radDock1.Size = new System.Drawing.Size(692, 466);
            this.radDock1.SplitterWidth = 4;
            this.radDock1.TabIndex = 0;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            this.radDock1.ThemeName = "Office2010Silver";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Controls.Add(this.radCarousel1);
            this.toolWindow1.Location = new System.Drawing.Point(1, 22);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(204, 204);
            this.toolWindow1.Text = "RadCarousel";
            // 
            // radCarousel1
            // 
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50, 50, 0);
            carouselEllipsePath1.FinalAngle = -100;
            carouselEllipsePath1.InitialAngle = -90;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-20, -17, -50);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(30, -25, -60);
            carouselEllipsePath1.ZScale = 500;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.EnableAutoLoop = true;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement4,
            this.radButtonElement5,
            this.radButtonElement6});
            this.radCarousel1.Location = new System.Drawing.Point(0, 0);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.SelectedIndex = 0;
            this.radCarousel1.Size = new System.Drawing.Size(204, 204);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.AccessibleDescription = "radButtonElement4";
            this.radButtonElement4.AccessibleName = "radButtonElement4";
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "radButtonElement4";
            this.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.AccessibleDescription = "radButtonElement5";
            this.radButtonElement5.AccessibleName = "radButtonElement5";
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.Text = "radButtonElement5";
            this.radButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement6
            // 
            this.radButtonElement6.AccessibleDescription = "radButtonElement6";
            this.radButtonElement6.AccessibleName = "radButtonElement6";
            this.radButtonElement6.Name = "radButtonElement6";
            this.radButtonElement6.Text = "radButtonElement6";
            this.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.CausesValidation = false;
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(5, 5);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(206, 456);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(206, 200);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(6, 0);
            this.radSplitContainer1.SplitterWidth = 4;
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "Office2010Silver";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(206, 226);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "Office2010Silver";
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CausesValidation = false;
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 230);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(206, 226);
            this.toolTabStrip2.TabIndex = 0;
            this.toolTabStrip2.TabStop = false;
            this.toolTabStrip2.ThemeName = "Office2010Silver";
            // 
            // toolWindow2
            // 
            this.toolWindow2.Controls.Add(this.radRotator1);
            this.toolWindow2.Location = new System.Drawing.Point(1, 22);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(204, 204);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // radRotator1
            // 
            this.radRotator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRotator1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3});
            this.radRotator1.Location = new System.Drawing.Point(0, 0);
            this.radRotator1.LocationAnimation = new System.Drawing.SizeF(0F, -1F);
            this.radRotator1.Name = "radRotator1";
            this.radRotator1.Running = true;
            this.radRotator1.Size = new System.Drawing.Size(204, 204);
            this.radRotator1.TabIndex = 0;
            this.radRotator1.Text = "radRotator1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "radButtonElement2";
            this.radButtonElement2.AccessibleName = "radButtonElement2";
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "radButtonElement2";
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "radButtonElement3";
            this.radButtonElement3.AccessibleName = "radButtonElement3";
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "radButtonElement3";
            this.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Location = new System.Drawing.Point(215, 5);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(472, 456);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(472, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-6, 0);
            this.documentContainer1.SplitterWidth = 4;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            this.documentContainer1.ThemeName = "Office2010Silver";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(472, 456);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "Office2010Silver";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Location = new System.Drawing.Point(1, 29);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(470, 426);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.Controls.Add(this.radDock1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "Office2010Silver";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            this.toolWindow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadRotator radRotator1;
        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement5;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement6;

    }
}

