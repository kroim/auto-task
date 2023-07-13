namespace Views
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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.ddActiveViewType = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.ddRange = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.ddCount = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarLabel2 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarLabel3 = new Telerik.WinControls.UI.CommandBarLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 403);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(837, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 0;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Desert";
            // 
            // lblStatus
            // 
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.BackColor = System.Drawing.Color.White;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(0, 30);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            // 
            // 
            // 
            this.radScheduler1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.radScheduler1.Size = new System.Drawing.Size(837, 373);
            this.radScheduler1.TabIndex = 2;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ThemeName = "Desert";
            this.radScheduler1.ActiveViewChanging += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangingEventArgs>(this.radScheduler1_ActiveViewChanging);
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(837, 30);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "radCommandBar1";
            this.radCommandBar1.ThemeName = "Desert";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel1,
            this.ddActiveViewType,
            this.commandBarLabel2,
            this.ddRange,
            this.commandBarLabel3,
            this.ddCount});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // ddActiveViewType
            // 
            this.ddActiveViewType.DisplayName = "commandBarDropDownList1";
            this.ddActiveViewType.Name = "ddActiveViewType";
            this.ddActiveViewType.Text = "";
            this.ddActiveViewType.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.ddActiveViewType.VisibleInOverflowMenu = true;
            this.ddActiveViewType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddActiveViewType_SelectedIndexChanged);
            // 
            // ddRange
            // 
            this.ddRange.DisplayName = "commandBarDropDownList2";
            this.ddRange.Name = "ddRange";
            this.ddRange.Text = "";
            this.ddRange.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.ddRange.VisibleInOverflowMenu = true;
            this.ddRange.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddRange_SelectedIndexChanged);
            // 
            // ddCount
            // 
            this.ddCount.DisplayName = "commandBarDropDownList3";
            this.ddCount.Name = "ddCount";
            this.ddCount.Text = "";
            this.ddCount.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.ddCount.VisibleInOverflowMenu = true;
            this.ddCount.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddCount_SelectedIndexChanged);
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.AccessibleDescription = "View Types:";
            this.commandBarLabel1.AccessibleName = "View Types:";
            this.commandBarLabel1.DisplayName = "commandBarLabel1";
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "View Types:";
            this.commandBarLabel1.UseVerticalText = false;
            this.commandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarLabel1.VisibleInOverflowMenu = true;
            // 
            // commandBarLabel2
            // 
            this.commandBarLabel2.AccessibleDescription = "Scale Range: ";
            this.commandBarLabel2.AccessibleName = "Scale Range: ";
            this.commandBarLabel2.DisplayName = "commandBarLabel2";
            this.commandBarLabel2.Name = "commandBarLabel2";
            this.commandBarLabel2.Text = "Scale Range: ";
            this.commandBarLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarLabel2.VisibleInOverflowMenu = true;
            // 
            // commandBarLabel3
            // 
            this.commandBarLabel3.AccessibleDescription = "Count: ";
            this.commandBarLabel3.AccessibleName = "Count: ";
            this.commandBarLabel3.DisplayName = "commandBarLabel3";
            this.commandBarLabel3.Name = "commandBarLabel3";
            this.commandBarLabel3.Text = "Count: ";
            this.commandBarLabel3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarLabel3.VisibleInOverflowMenu = true;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 429);
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadScheduler";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarDropDownList ddActiveViewType;
        private Telerik.WinControls.UI.CommandBarDropDownList ddRange;
        private Telerik.WinControls.UI.CommandBarDropDownList ddCount;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel2;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel3;
    }
}

