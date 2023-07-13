Imports Telerik.WinControls.UI

Public Class CalendarPanel

    Public Delegate Sub DateChangedHandler(ByVal [date] As DateTime)
    Public Event DateChanged As DateChangedHandler

    Private Sub RadCalendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCalendar1.SelectionChanged
        RaiseEvent DateChanged((TryCast(sender, RadCalendar)).SelectedDate)
    End Sub
End Class
