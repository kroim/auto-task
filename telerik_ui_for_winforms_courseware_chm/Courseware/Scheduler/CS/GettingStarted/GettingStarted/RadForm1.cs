using System;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GettingStarted
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // fill all three tables
            appointmentsTableAdapter1.Fill(schedulerDataDataSet.Appointments);
            resourcesTableAdapter1.Fill(schedulerDataDataSet.Resources);
            appointmentsResourcesTableAdapter1.Fill(schedulerDataDataSet.AppointmentsResources);

            // create and assign appointment mapping
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "Summary";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";
            appointmentMappingInfo.BackgroundId = "BackgroundID";
            appointmentMappingInfo.StatusId = "StatusID";
            appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
            appointmentMappingInfo.Resources = "Appointments_AppointmentsResources";
            appointmentMappingInfo.ResourceId = "ResourceID";
            schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo;
            schedulerBindingDataSource1.EventProvider.DataSource = schedulerDataDataSet.Appointments;

            // create and assign resource mapping
            ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
            resourceMappingInfo.Id = "ID";
            resourceMappingInfo.Name = "ResourceName";
            schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo;
            schedulerBindingDataSource1.ResourceProvider.DataSource = schedulerDataDataSet.Resources;

            // assign mapped binding data source
            radScheduler1.DataSource = schedulerBindingDataSource1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // save scheduler changes       
            appointmentsTableAdapter1.Update(schedulerDataDataSet.Appointments);
            appointmentsResourcesTableAdapter1.Update(schedulerDataDataSet.AppointmentsResources);
            lblStatus.Text = "Updated scheduler at " + DateTime.Now.ToString();
        }
    }
}
