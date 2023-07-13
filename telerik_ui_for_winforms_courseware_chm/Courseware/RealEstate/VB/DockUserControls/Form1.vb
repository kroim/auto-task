Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim calendarPanel As New CalendarPanel()
        Dim host As HostWindow = Me.RadDock1.DockControl(calendarPanel, Telerik.WinControls.UI.Docking.DockPosition.Left)
        host.Text = "Calendar"
        AddHandler calendarPanel.DateChanged, AddressOf calendarPanel_DateChanged
    End Sub

    Sub calendarPanel_DateChanged(ByVal [date] As DateTime)
        RadMessageBox.Show("Selected date is: " + [date].ToShortDateString())
    End Sub
End Class
