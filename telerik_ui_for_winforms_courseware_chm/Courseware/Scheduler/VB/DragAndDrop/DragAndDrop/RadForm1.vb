Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private _dragRectangle As Rectangle = Rectangle.Empty
    Private _currentItem As RadListVisualItem

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        ' list the resources in Properties.Resources
        Dim resourceSet As Resources.ResourceSet = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        Dim enumerator As IDictionaryEnumerator = resourceSet.GetEnumerator()

        ' for each image resources, retrieve the image name and object,
        ' create and populate the menu item, then add to the drop down
        ' button items collection
        Do While enumerator.MoveNext()
            ' the key will be the name of the image, minus extension,
            ' also remove underline
            Dim key As String = (CStr(enumerator.Key)).Replace("_"c, " "c)
            ' the value will be the image object
            Dim image As Image = CType(enumerator.Value, Image)
            Dim item As RadListDataItem = New RadListDataItem(key)
            item.Image = image
            item.TextImageRelation = TextImageRelation.ImageBeforeText
            lcClasses.Items.Add(item)
        Loop
    End Sub

    Private Sub lcClasses_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcClasses.MouseDown
        ' get the list control that items are being dragged from
        Dim sourceListControl As RadListControl = TryCast(sender, RadListControl)

        ' get the list control item directly under the mouse 
        Dim element As RadElement = sourceListControl.ElementTree.GetElementAtPoint(e.Location)
        If Not element Is Nothing Then
            _currentItem = TryCast(element, RadListVisualItem)
            ' create a "drag rectangle" with mouse in center
            Dim dragPoint As System.Drawing.Point = New System.Drawing.Point(e.X - (SystemInformation.DragSize.Width / 2), e.Y - (SystemInformation.DragSize.Height / 2))
            _dragRectangle = New Rectangle(dragPoint, SystemInformation.DragSize)
        End If
    End Sub

    Private Sub lcClasses_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcClasses.MouseMove
        Dim sourceListControl As RadListControl = TryCast(sender, RadListControl)
        ' we have at least one item to drop
        If Not _currentItem Is Nothing Then
            ' we have moved outside the rectangle, so start the drag drop
            If (Not _dragRectangle.Contains(e.X, e.Y)) Then
                sourceListControl.DoDragDrop(sourceListControl, DragDropEffects.Copy)
            End If
        End If
    End Sub

    Private Sub radScheduler1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles radScheduler1.DragEnter
        ' verify that the drag contains the RadListControl and that 
        ' we're not dragging onto the same list control.
        If e.Data.GetDataPresent(GetType(RadListControl)) Then
            Dim sourceListControl As RadListControl = CType(e.Data.GetData(GetType(RadListControl)), RadListControl)
            If Not sourceListControl Is (TryCast(sender, RadListControl)) Then
                e.Effect = DragDropEffects.Copy
            End If
        End If

        If e.Data.GetDataPresent(GetType(RadListDataItem)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub radScheduler1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles radScheduler1.DragDrop
        Dim scheduler As RadScheduler = TryCast(sender, RadScheduler)
        ' get mouse location on the screen
        Dim mouseLocation As System.Drawing.Point = New System.Drawing.Point(e.X, e.Y)
        ' convert to location on the sceduler
        Dim schedulerLocation As System.Drawing.Point = scheduler.SchedulerElement.PointFromScreen(mouseLocation)
        ' get the cell element for the location
        Dim element As RadElement = scheduler.ElementTree.GetElementAtPoint(schedulerLocation)
        ' cast cell element to MonthCellElement and create an appointment for cell date
        If (Not element Is Nothing) AndAlso (TypeOf element Is MonthCellElement) Then
            Dim monthCellElement As MonthCellElement = TryCast(element, MonthCellElement)
            Dim appointment As Appointment = GetCellAppointment(monthCellElement)
            scheduler.Appointments.Add(appointment)
        End If

        ' finished drop, clear temporary variables
        _dragRectangle = Rectangle.Empty
        _currentItem = Nothing
    End Sub

    Private Function GetCellAppointment(ByVal monthCellElement As MonthCellElement) As Appointment
        Dim appointment As Appointment = New Appointment()
        ' start at 9:00AM on the drop target cell date
        appointment.Start = monthCellElement.Date.AddHours(9)
        ' class is 8 hours long
        appointment.Duration = TimeSpan.FromHours(8)
        ' copy the listbox item itext as the summary
        appointment.Summary = _currentItem.Text
        ' fill other misc properties
        appointment.Location = "Telerik Training Center"

        appointment.BackgroundId = AppointmentBackground.Important
        appointment.StatusId = AppointmentStatus.Busy

        ' the class will run for three, eight hour days
        appointment.RecurrenceRule = New DailyRecurrenceRule(appointment.Start, 1, 3)

        Return appointment
    End Function

    Private Sub lcClasses_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcClasses.MouseUp
        ' we're no longer dragging, so clear these temporary variables
        _dragRectangle = Rectangle.Empty
        _currentItem = Nothing
    End Sub
End Class
