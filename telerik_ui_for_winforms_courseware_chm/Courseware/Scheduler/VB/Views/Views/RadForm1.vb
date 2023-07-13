Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each viewType As SchedulerViewType In System.Enum.GetValues(GetType(SchedulerViewType))
            Dim item As RadListDataItem = New RadListDataItem()
            item.Text = viewType.ToString()
            item.Value = viewType
            ddActiveViewType.Items.Add(item)
        Next viewType

        For Each range As ScaleRange In System.Enum.GetValues(GetType(ScaleRange))
            Dim item As RadListDataItem = New RadListDataItem()
            item.Text = range.ToString()
            item.Value = range
            ddRange.Items.Add(item)
        Next range

        For i As Integer = 1 To 9
            Dim item As RadListDataItem = New RadListDataItem()
            item.Text = i.ToString()
            item.Value = i
            ddCount.Items.Add(item)
        Next i
    End Sub

    Private Sub ddActiveViewType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddActiveViewType.SelectedIndexChanged
        Dim dropDownList As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        radScheduler1.ActiveViewType = CType(dropDownList.SelectedValue, SchedulerViewType)
    End Sub

    Private Sub ddRange_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddRange.SelectedIndexChanged
        Dim dropDownList As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        Dim range As ScaleRange = CType(dropDownList.SelectedValue, ScaleRange)

        ' set the appropriate range factor based on the type of view
        Select Case radScheduler1.ActiveViewType
            Case SchedulerViewType.Day
                TryCast(radScheduler1.ActiveView, SchedulerDayView).RangeFactor = range
            Case SchedulerViewType.MultiDay
                TryCast(radScheduler1.ActiveView, SchedulerMultiDayView).RangeFactor = range
            Case SchedulerViewType.Week, SchedulerViewType.WorkWeek
                TryCast(radScheduler1.ActiveView, SchedulerWeekView).RangeFactor = range
        End Select
    End Sub

    Private Sub ddCount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddCount.SelectedIndexChanged
        Dim dropDownList As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        Dim count As Integer = CInt(Fix(dropDownList.SelectedValue))

        ' set the Day or WeekCount based on the current view
        Select Case radScheduler1.ActiveViewType
            Case SchedulerViewType.Day
                TryCast(radScheduler1.ActiveView, SchedulerDayView).DayCount = count
            Case SchedulerViewType.MultiDay
                TryCast(radScheduler1.ActiveView, SchedulerMultiDayView).DayCount = count
            Case SchedulerViewType.Month
                TryCast(radScheduler1.ActiveView, SchedulerMonthView).WeekCount = count
        End Select
    End Sub

    Private Sub radScheduler1_ActiveViewChanging(ByVal sender As Object, ByVal e As SchedulerViewChangingEventArgs) Handles radScheduler1.ActiveViewChanging
        lblStatus.Text = String.Format("Old: {0}   New: {1}", e.OldView.ViewType.ToString(), e.NewView.ViewType.ToString())
    End Sub






End Class
