Imports System.IO
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
        Using stream As FileStream = File.Create("c:\schedule.ics")
            Me.radScheduler1.Export(stream, New Scheduler.ICalendar.SchedulerICalendarExporter())
        End Using
    End Sub

    Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
        Using stream As FileStream = File.OpenRead("c:\schedule.ics")
            Me.radScheduler1.Import(stream, New Scheduler.ICalendar.SchedulerICalendarImporter())
        End Using

    End Sub
End Class
