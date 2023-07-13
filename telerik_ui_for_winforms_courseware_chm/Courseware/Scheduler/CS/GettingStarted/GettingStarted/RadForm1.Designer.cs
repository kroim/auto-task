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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.schedulerDataDataSet = new GettingStarted.SchedulerDataDataSet();
            this.appointmentsResourcesTableAdapter1 = new GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter();
            this.appointmentsTableAdapter1 = new GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter1 = new GettingStarted.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnUpdate = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).BeginInit();
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
            this.radStatusStrip1.Location = new System.Drawing.Point(5, 345);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(488, 22);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 0;
            this.radStatusStrip1.Text = " ";
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
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.BackColor = System.Drawing.Color.White;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.FocusedDate = new System.DateTime(2009, 3, 7, 0, 0, 0, 0);
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "MMMM dd";
            this.radScheduler1.Location = new System.Drawing.Point(5, 35);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radScheduler1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radScheduler1.ShowAllDayAppointmentStatus = true;
            this.radScheduler1.Size = new System.Drawing.Size(488, 310);
            this.radScheduler1.TabIndex = 2;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ThemeName = "ControlDefault";
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // schedulerDataDataSet
            // 
            this.schedulerDataDataSet.DataSetName = "SchedulerDataDataSet";
            this.schedulerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsResourcesTableAdapter1
            // 
            this.appointmentsResourcesTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter1
            // 
            this.resourcesTableAdapter1.ClearBeforeFill = true;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(5, 5);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(488, 30);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "radCommandBar1";
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
            this.btnUpdate});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleDescription = "Update";
            this.btnUpdate.AccessibleName = "Update";
            this.btnUpdate.DisplayName = "commandBarButton1";
            this.btnUpdate.DrawText = true;
            this.btnUpdate.Image = null;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnUpdate.VisibleInOverflowMenu = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 372);
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "RadForm1";
            this.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Scheduler";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private SchedulerDataDataSet schedulerDataDataSet;
        private GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter appointmentsResourcesTableAdapter1;
        private GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
        private GettingStarted.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton btnUpdate;
    }
}

