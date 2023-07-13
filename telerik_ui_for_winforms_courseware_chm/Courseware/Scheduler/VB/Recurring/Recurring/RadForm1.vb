Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim appointment As Appointment = New Appointment(DateTime.Now, TimeSpan.FromMinutes(30), "Summary", "Description")
        radScheduler1.Appointments.Add(appointment)

        Dim startDate As DateTime = New DateTime(2008, 10, 1, 3, 30, 0)
        ' Create a sample appointment that starts at 10/1/2008 3:30 AM and lasts half an hour.
        Dim recurringAppointment As Appointment = New Appointment(startDate, TimeSpan.FromHours(1.0), "Appointment Subject")

        ' Create a recurrence rule to repeat the appointment every 2 hours for 10 occurrences.      
        Dim rrule As HourlyRecurrenceRule = New HourlyRecurrenceRule(recurringAppointment.Start, 2, 10)

        'Assign the hourly recurrence rule to the appointment
        recurringAppointment.RecurrenceRule = rrule
        radScheduler1.Appointments.Add(recurringAppointment)

        ' iterate all appointment occurrances
        For Each ev As IEvent In recurringAppointment.Occurrences
            lcAll.Items.Add(New RadListDataItem(ev.Start.ToShortTimeString() & " - " & ev.End.ToShortTimeString()))
        Next ev

        ' iterate only occurrances after 10am
        Dim occurrencesAfter10AM As IEnumerable(Of IEvent) = recurringAppointment.GetOccurrences(New DateTime(2008, 10, 1, 10, 0, 0), DateTime.Now)
        For Each ev As IEvent In occurrencesAfter10AM
            lcAfter10.Items.Add(New RadListDataItem(ev.Start.ToShortTimeString() & " - " & ev.End.ToShortTimeString()))
            ' set the background id to "Important" and make this occurence an "Exception"
            ev.BackgroundId = CInt(Fix(AppointmentBackground.Important))
            ev.StatusId = CInt(Fix(AppointmentStatus.Tentative))
            ev.MasterEvent.Exceptions.Add(ev)
        Next ev

        radScheduler1.FocusedDate = startDate
    End Sub
End Class
