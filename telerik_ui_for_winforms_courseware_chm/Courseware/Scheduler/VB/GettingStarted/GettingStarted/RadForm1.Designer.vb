<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Dim DateTimeInterval1 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval
        Dim AppointmentMappingInfo1 As Telerik.WinControls.UI.AppointmentMappingInfo = New Telerik.WinControls.UI.AppointmentMappingInfo
        Dim ResourceMappingInfo1 As Telerik.WinControls.UI.ResourceMappingInfo = New Telerik.WinControls.UI.ResourceMappingInfo
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler
        Me.schedulerBindingDataSource1 = New Telerik.WinControls.UI.SchedulerBindingDataSource
        Me.schedulerDataDataSet = New GettingStarted.SchedulerDataDataSet
        Me.appointmentsResourcesTableAdapter1 = New GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter
        Me.appointmentsTableAdapter1 = New GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter
        Me.resourcesTableAdapter1 = New GettingStarted.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter
        Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnUpdate = New Telerik.WinControls.UI.CommandBarButton
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerBindingDataSource1.EventProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerBindingDataSource1.ResourceProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatus})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(5, 341)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(488, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 0
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.radStatusStrip1.SetSpring(Me.lblStatus, False)
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radScheduler1
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        Me.radScheduler1.AccessibleInterval = DateTimeInterval1
        Me.radScheduler1.AppointmentTitleFormat = Nothing
        Me.radScheduler1.BackColor = System.Drawing.Color.White
        Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.radScheduler1.DataSource = Nothing
        Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radScheduler1.FocusedDate = New Date(2011, 3, 28, 0, 0, 0, 0)
        Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.radScheduler1.HeaderFormat = "MMMM dd"
        Me.radScheduler1.Location = New System.Drawing.Point(5, 35)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        '
        '
        '
        Me.radScheduler1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.radScheduler1.ShowAllDayAppointmentStatus = True
        Me.radScheduler1.Size = New System.Drawing.Size(488, 306)
        Me.radScheduler1.TabIndex = 2
        Me.radScheduler1.Text = "radScheduler1"
        Me.radScheduler1.ThemeName = "ControlDefault"
        '
        'schedulerBindingDataSource1
        '
        '
        '
        '
        Me.schedulerBindingDataSource1.EventProvider.Mapping = AppointmentMappingInfo1
        '
        '
        '
        Me.schedulerBindingDataSource1.ResourceProvider.Mapping = ResourceMappingInfo1
        '
        'schedulerDataDataSet
        '
        Me.schedulerDataDataSet.DataSetName = "SchedulerDataDataSet"
        Me.schedulerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'appointmentsResourcesTableAdapter1
        '
        Me.appointmentsResourcesTableAdapter1.ClearBeforeFill = True
        '
        'appointmentsTableAdapter1
        '
        Me.appointmentsTableAdapter1.ClearBeforeFill = True
        '
        'resourcesTableAdapter1
        '
        Me.resourcesTableAdapter1.ClearBeforeFill = True
        '
        'radCommandBar1
        '
        Me.radCommandBar1.AutoSize = True
        Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radCommandBar1.Location = New System.Drawing.Point(5, 5)
        Me.radCommandBar1.Name = "radCommandBar1"
        Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.radCommandBar1.Size = New System.Drawing.Size(488, 30)
        Me.radCommandBar1.TabIndex = 0
        Me.radCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnUpdate})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleDescription = "Update"
        Me.btnUpdate.AccessibleName = "Update"
        Me.btnUpdate.DisplayName = "CommandBarButton1"
        Me.btnUpdate.DrawText = True
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnUpdate.VisibleInOverflowMenu = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 372)
        Me.Controls.Add(Me.radScheduler1)
        Me.Controls.Add(Me.radCommandBar1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Name = "RadForm1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Scheduler"
        Me.ThemeName = "ControlDefault"
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerBindingDataSource1.EventProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerBindingDataSource1.ResourceProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Private schedulerBindingDataSource1 As Telerik.WinControls.UI.SchedulerBindingDataSource
    Private schedulerDataDataSet As SchedulerDataDataSet
    Private appointmentsResourcesTableAdapter1 As GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter
    Private appointmentsTableAdapter1 As GettingStarted.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter
    Private resourcesTableAdapter1 As GettingStarted.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.CommandBarButton
End Class
