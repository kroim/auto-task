using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;

namespace Recurring
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            Appointment appointment =
              new Appointment(DateTime.Now, TimeSpan.FromMinutes(30), "Summary", "Description");
            radScheduler1.Appointments.Add(appointment);

            DateTime startDate = new DateTime(2008, 10, 1, 3, 30, 0);
            // Create a sample appointment that starts at 10/1/2008 3:30 AM and lasts half an hour.
            Appointment recurringAppointment = new Appointment(startDate,
              TimeSpan.FromHours(1.0), "Appointment Subject");

            // Create a recurrence rule to repeat the appointment every 2 hours for 10 occurrences.      
            HourlyRecurrenceRule rrule =
              new HourlyRecurrenceRule(recurringAppointment.Start, 2, 10);

            //Assign the hourly recurrence rule to the appointment
            recurringAppointment.RecurrenceRule = rrule;
            radScheduler1.Appointments.Add(recurringAppointment);

            // iterate all appointment occurrances
            foreach (IEvent ev in recurringAppointment.Occurrences)
            {
                lcAll.Items.Add(
                  new RadListDataItem(ev.Start.ToShortTimeString() + " - " +
                    ev.End.ToShortTimeString()));
            }

            // iterate only occurrances after 10am
            IEnumerable<IEvent> occurrencesAfter10AM = recurringAppointment.GetOccurrences(
              new DateTime(2008, 10, 1, 10, 0, 0), DateTime.Now);
            foreach (IEvent ev in occurrencesAfter10AM)
            {
                lcAfter10.Items.Add(
                  new RadListDataItem(ev.Start.ToShortTimeString() + " - " +
                    ev.End.ToShortTimeString()));
                // set the background id to "Important" and make this occurence an "Exception"
                ev.BackgroundId = (int)AppointmentBackground.Important;
                ev.StatusId = (int)AppointmentStatus.Tentative;
                ev.MasterEvent.Exceptions.Add(ev);
            }

            radScheduler1.FocusedDate = startDate;
        }
    }
}
