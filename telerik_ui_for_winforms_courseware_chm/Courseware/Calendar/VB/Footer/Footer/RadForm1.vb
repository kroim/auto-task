Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radCalendar1.FocusedDate = New System.DateTime(2011, 2, 1)

        radCalendar1.ShowFooter = True
        radCalendar1.ClearButton.Visibility = ElementVisibility.Collapsed
        radCalendar1.TodayButton.Visibility = ElementVisibility.Collapsed

        ' get the footer layout panel 
        Dim layoutPanel As DockLayoutPanel = TryCast(radCalendar1.CalendarElement.Children(0).Children(0).Children(0), DockLayoutPanel)
        ' get the updating date and time label and hide that too
        layoutPanel.Children(2).Visibility = ElementVisibility.Collapsed

        Dim rotator As RadRotatorElement = New RadRotatorElement()
        For Each day As RadCalendarDay In radCalendar1.SpecialDays
            Dim button As RadButtonElement = New RadButtonElement()
            button.Text = day.ToolTip
            button.DisplayStyle = DisplayStyle.Text
            rotator.Items.Add(button)
        Next day
        rotator.Interval = 4000
        rotator.Running = True

        layoutPanel.Children.Add(rotator)
    End Sub
End Class
