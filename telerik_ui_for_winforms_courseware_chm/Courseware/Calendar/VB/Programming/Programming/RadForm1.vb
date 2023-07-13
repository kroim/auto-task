Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' assign New Years as a special day
        Dim newYearsDay As RadCalendarDay = New RadCalendarDay(New DateTime(2010, 1, 1))
        radCalendar1.SpecialDays.Add(newYearsDay)
        radCalendar1.SpecialDays(0).Image = imageList1.Images("blackout.ico")

        ' assign template to New Years Eve 
        Dim checkbox As CheckBox = New CheckBox()
        checkbox.Text = "Blackout?"
        checkbox.Padding = New Padding(5)
        Dim hostItem As RadHostItem = New RadHostItem(checkbox)
        Dim newYearsEveDay As RadCalendarDay = New RadCalendarDay(New DateTime(2009, 12, 31))
        radCalendar1.SpecialDays.Add(newYearsEveDay)
        newYearsEveDay.TemplateItem = hostItem

        ' recurring dates
        'Dim fridays As New RadCalendarDay(New DateTime(2010, 1, 8))
        'fridays.Recurring = RecurringEvents.Week
        'radCalendar1.SpecialDays.Add(fridays)

        radCalendar1.FocusedDate = newYearsDay.Date
    End Sub

    Private Sub btnGetFlights_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetFlights.Click
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder()
        builder.Append("Selected Date: ")
        builder.Append(radCalendar1.SelectedDate.ToLongDateString())
        builder.Append(Environment.NewLine)
        builder.Append(Environment.NewLine)
        For Each dateTime As DateTime In radCalendar1.SelectedDates
            builder.Append(dateTime.ToLongDateString())
            builder.Append(Environment.NewLine)
        Next dateTime
        RadMessageBox.SetThemeName("Aqua")
        RadMessageBox.Show(builder.ToString(), "SelectedDate vs SelectedDates", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub radCalendar1_ElementRender(ByVal sender As Object, ByVal e As RenderElementEventArgs) Handles radCalendar1.ElementRender
        ' is the Day one of the SpecialDays collection?
        Dim isSpecialDay As Boolean = radCalendar1.SpecialDays.Find(e.Day.Date).Length > 0
        If isSpecialDay Then
            e.Element.BackColor = Color.FromArgb(105, 181, 218)
            e.Element.BackColor2 = Color.FromArgb(112, 145, 181)
            e.Element.BackColor3 = Color.Blue
            e.Element.NumberOfColors = 3
            e.Element.GradientStyle = GradientStyles.OfficeGlassRect
            e.Element.GradientPercentage = 80
            e.Element.ForeColor = Color.Transparent
            e.Element.ToolTipText = "Blackout date"
        End If
    End Sub

    Private Sub radCalendar1_SelectionChanging(ByVal sender As Object, ByVal e As SelectionEventArgs) Handles radCalendar1.SelectionChanging
        If e.Dates.Count = 3 Then
            e.Cancel = True
            RadMessageBox.SetThemeName("Aqua")
            RadMessageBox.Show("Select no more than three travel dates")
        End If
    End Sub

    Private Sub radCalendar1_ViewChanging(ByVal sender As Object, ByVal e As ViewChangingEventArgs) Handles radCalendar1.ViewChanging
        If e.View.ViewStartDate > radCalendar1.FocusedDate.AddDays(90) Then
            e.Cancel = True
            RadMessageBox.SetThemeName("Aqua")
            RadMessageBox.Show("You may not reserve flights more than 90 days in advance")
        End If
    End Sub
End Class
