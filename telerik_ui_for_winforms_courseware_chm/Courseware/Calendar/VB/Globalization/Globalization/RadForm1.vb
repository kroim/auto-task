Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' list some cultures that we can assign to the calendar
        Dim cultures As System.Globalization.CultureInfo() = System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.WindowsOnlyCultures)

        For Each cultureInfo As System.Globalization.CultureInfo In cultures
            Dim description As String = "Culture code: " & cultureInfo.Name
            Dim item As RadListDataItem = New RadListDataItem(description, cultureInfo.Name)
            CommandBarDropDownList1.Items.Add(item)
        Next cultureInfo

        CommandBarDropDownList1.SelectedIndex = 0
        ' make the combo textbox wider
        CommandBarDropDownList1.MinSize = New System.Drawing.Size(200, 0)

        ' list the DayNameFormats
        For Each dayNameFormat As DayNameFormat In System.Enum.GetValues(GetType(DayNameFormat))
            CommandBarDropDownList2.Items.Add(New RadListDataItem(dayNameFormat.ToString(), dayNameFormat))
        Next dayNameFormat
        CommandBarDropDownList2.SelectedIndex = 0

        ' list FirstdayOfWeek members
        For Each firstDayOfWeek As FirstDayOfWeek In System.Enum.GetValues(GetType(FirstDayOfWeek))
            CommandBarDropDownList3.Items.Add(New RadListDataItem(firstDayOfWeek.ToString(), firstDayOfWeek))
        Next firstDayOfWeek
        CommandBarDropDownList3.SelectedIndex = 0
    End Sub





    Private Sub CommandBarDropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles CommandBarDropDownList1.SelectedIndexChanged
        ' show the selected culture and code in the status strip
        Dim element As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        If Not element.SelectedValue Is Nothing Then
            radCalendar1.Culture = System.Globalization.CultureInfo.GetCultureInfo((element.SelectedValue.ToString()))
            RadLabelElement1.Text = "Culture: " & element.SelectedText & "   Code:" & element.SelectedValue.ToString()
        End If
    End Sub

    ' Select DayNameFormat
    Private Sub CommandBarDropDownList2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles CommandBarDropDownList2.SelectedIndexChanged
        Dim element As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        radCalendar1.DayNameFormat = CType(element.SelectedValue, DayNameFormat)
    End Sub

    ' Select FirstDayOfWeek
    Private Sub CommandBarDropDownList3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles CommandBarDropDownList3.SelectedIndexChanged
        Dim element As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        If Not element.SelectedValue Is Nothing Then
            radCalendar1.FirstDayOfWeek = CType(element.SelectedValue, FirstDayOfWeek)
        End If
    End Sub

    ' Show the selected date in the status strip
    Private Sub radCalendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCalendar1.SelectionChanged
        Dim cultureInfo As System.Globalization.CultureInfo = New System.Globalization.CultureInfo((cbCultures.SelectedValue.ToString()))
        RadLabelElement1.Text = radCalendar1.SelectedDate.ToString(cultureInfo)
    End Sub

    ' toggle RightToLeft
    Private Sub CommandBarToggleButton1_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CommandBarToggleButton1.ToggleStateChanged
        If args.ToggleState = Enumerations.ToggleState.On Then
            radCalendar1.RightToLeft = RightToLeft.Yes
        Else
            radCalendar1.RightToLeft = RightToLeft.No
        End If
    End Sub
End Class
