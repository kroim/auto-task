Imports Telerik.WinControls
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName
        'Me.FormElement.ClientFillPrimitive.BackColor = Color.FromArgb(228, 241, 243)
        'Me.FormElement.ClientFillPrimitive.BackColor2 = Color.FromArgb(238, 251, 253)

        ' create a list of MyAppointment objects
        Dim appointments As BindingList(Of MyAppointment) = New BindingList(Of MyAppointment)()

        For i As Integer = 0 To 9
            ' add every other appointment, populate with sample data
            If (i Mod 2) = 0 Then
                Dim appointmentNumber As Integer = i + 1
                Dim myAppointment As MyAppointment = New MyAppointment(DateTime.Now.AddHours(appointmentNumber), DateTime.Now.AddHours(appointmentNumber + 2), "Appointment " & appointmentNumber.ToString(), "Description for Appointment " & appointmentNumber.ToString(), "Conference room " & appointmentNumber.ToString())

                appointments.Add(myAppointment)
            End If

        Next i

        ' create and configure a scheduler binding source
        Dim dataSource As SchedulerBindingDataSource = New SchedulerBindingDataSource()
        ' map the MyAppointment properties to the scheduler
        Dim appointmentMappingInfo As AppointmentMappingInfo = New AppointmentMappingInfo()
        appointmentMappingInfo.Start = "Start"
        appointmentMappingInfo.End = "End"
        appointmentMappingInfo.Summary = "Subject"
        appointmentMappingInfo.Description = "Description"
        appointmentMappingInfo.Location = "Location"
        appointmentMappingInfo.UniqueId = "Id"
        dataSource.EventProvider.Mapping = appointmentMappingInfo

        ' assign the generic List of MyAppointment as the EventProvider data source
        dataSource.EventProvider.DataSource = appointments

        Me.radScheduler1.DataSource = dataSource
    End Sub
End Class
