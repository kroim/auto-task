Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' fill all three tables
        appointmentsTableAdapter1.Fill(schedulerDataDataSet.Appointments)
        resourcesTableAdapter1.Fill(schedulerDataDataSet.Resources)
        appointmentsResourcesTableAdapter1.Fill(schedulerDataDataSet.AppointmentsResources)

        ' create and assign appointment mapping
        Dim appointmentMappingInfo As AppointmentMappingInfo = New AppointmentMappingInfo()
        appointmentMappingInfo.Start = "Start"
        appointmentMappingInfo.End = "End"
        appointmentMappingInfo.Summary = "Summary"
        appointmentMappingInfo.Description = "Description"
        appointmentMappingInfo.Location = "Location"
        appointmentMappingInfo.BackgroundId = "BackgroundID"
        appointmentMappingInfo.StatusId = "StatusID"
        appointmentMappingInfo.RecurrenceRule = "RecurrenceRule"
        appointmentMappingInfo.Resources = "Appointments_AppointmentsResources"
        appointmentMappingInfo.ResourceId = "ResourceID"
        schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo
        schedulerBindingDataSource1.EventProvider.DataSource = schedulerDataDataSet.Appointments

        ' create and assign resource mapping
        Dim resourceMappingInfo As ResourceMappingInfo = New ResourceMappingInfo()
        resourceMappingInfo.Id = "ID"
        resourceMappingInfo.Name = "ResourceName"
        schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo
        schedulerBindingDataSource1.ResourceProvider.DataSource = schedulerDataDataSet.Resources

        ' assign mapped binding data source
        radScheduler1.DataSource = schedulerBindingDataSource1

        
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ' save scheduler changes       
        appointmentsTableAdapter1.Update(schedulerDataDataSet.Appointments)
        appointmentsResourcesTableAdapter1.Update(schedulerDataDataSet.AppointmentsResources)
        lblStatus.Text = "Updated scheduler at " & DateTime.Now.ToString()
    End Sub
End Class
