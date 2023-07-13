Imports Telerik.WinControls

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radCalendar1.ShowFooter = True
    End Sub

    Private Sub btnGetFlights_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetFlights.Click
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder()
        For Each dateTime As DateTime In radCalendar1.SelectedDates
            builder.Append(dateTime.ToLongDateString())
            builder.Append(Environment.NewLine)
        Next dateTime
        RadMessageBox.SetThemeName("Aqua")
        RadMessageBox.Show(builder.ToString(), "Look for flights on these days?", MessageBoxButtons.YesNo, RadMessageIcon.Question)
    End Sub
End Class
