using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BusinessObjects
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // create a list of MyAppointment objects
            BindingList<MyAppointment> appointments = new BindingList<MyAppointment>();

            for (int i = 0; i < 10; i++)
            {
                // add every other appointment, populate with sample data
                if ((i % 2) == 0)
                {
                    int appointmentNumber = i + 1;
                    MyAppointment myAppointment =
                      new MyAppointment(
                        DateTime.Now.AddHours(appointmentNumber),
                        DateTime.Now.AddHours(appointmentNumber + 2),
                        "Appointment " + appointmentNumber.ToString(),
                        "Description for Appointment " + appointmentNumber.ToString(),
                        "Conference room " + appointmentNumber.ToString());
                    
                    appointments.Add(myAppointment);
                }

            }

            // create and configure a scheduler binding source
            SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
            // map the MyAppointment properties to the scheduler
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "Subject";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";
            appointmentMappingInfo.UniqueId = "Id";
            dataSource.EventProvider.Mapping = appointmentMappingInfo;

            // assign the generic List of MyAppointment as the EventProvider data source
            dataSource.EventProvider.DataSource = appointments;

            this.radScheduler1.DataSource = dataSource;
        }
    }
}
