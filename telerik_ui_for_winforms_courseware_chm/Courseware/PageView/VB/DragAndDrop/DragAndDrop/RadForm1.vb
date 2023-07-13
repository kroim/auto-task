Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.TabStrip
Imports Telerik.WinControls

Public Class RadForm1
    Private _actIndex As Integer = 0

    ' reposition tabs to take whole horizontal width
    Private Sub StretchItems()
        For Each ti As TabItem In radTabStrip1.Items
            ti.StretchHorizontally = True
        Next ti
    End Sub

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyClass.Load
        ThemeResolutionService.RegisterThemeFromStorage(ThemeStorageType.Resource, "DragAndDrop.TabStrip.IE7.xml")

        ' set the initial index to exclude the stationary items, i.e. cast, teaser, etc.
        _actIndex = radTabStrip1.Items.Count - 4
        ' allow tabs to be brought back in view from the overflow button
        radTabStrip1.TabStripElement.TabStripOverFlowBehavior = OverFlowBehavior.BringIntoView

        ' create an add act button element and add it
        ' to the tab item's children
        Dim button As RadButtonElement = New RadButtonElement()
        button.Padding = New Padding(3)
        button.Text = "<Add New Act>"
        button.ImageKey = "Copy.png"
        button.TextImageRelation = TextImageRelation.TextAboveImage
        button.ImagePrimitive.AngleTransform = 90
        AddHandler button.Click, AddressOf button_Click
        tiNewAct.Children.Add(button)

        ' select the "cast" tab instead of the "tag"
        radTabStrip1.SelectFirstVisibleItem()
        StretchItems()
    End Sub

    Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' increment the act index
        _actIndex += 1

        ' create a tab item for the new act
        Dim item As TabItem = New TabItem()
        item.ImageKey = "Copy.png"
        item.ImageAlignment = ContentAlignment.BottomLeft
        item.TextImageRelation = TextImageRelation.TextAboveImage
        item.TextAlignment = ContentAlignment.TopRight
        item.Text = "Act " & _actIndex.ToString()
        item.Tag = "act"
        item.ImagePrimitive.AngleTransform = 90
        ' we allow the user to double click the tab to edit
        ' and prevent empty entry in the TextChanging handler
        AddHandler item.DoubleClick, AddressOf ActDoubleClick
        AddHandler item.TextChanging, AddressOf ActTextChanging
        ' insert after "cast", "teaser" and other acts
        radTabStrip1.Items.Insert(_actIndex + 1, item)
        StretchItems()
    End Sub


    Private Sub radTabStrip1_TabDragStarting(ByVal sender As Object, ByVal args As TabDragCancelEventArgs) Handles radTabStrip1.TabDragStarting
        ' prevent "fixed" items from being dragged.
        args.Cancel = args.DraggedItem.Tag.ToString().Equals("fixed")
    End Sub

    Private Sub radTabStrip1_TabDragEnding(ByVal sender As Object, ByVal args As TabDragCancelEventArgs) Handles radTabStrip1.TabDragEnding
        ' don't allow replacing fixed items
        args.Cancel = args.ReplacedItem.Tag.ToString().Equals("fixed")
    End Sub

    Private Sub radTabStrip1_TabDragEnded(ByVal sender As Object, ByVal args As TabDragEventArgs) Handles radTabStrip1.TabDragStarted
        StretchItems()
    End Sub

    Private Sub ActDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        ' allow tab to be edited only if tagged as "act" 
        radTabStrip1.AllowEdit = False
        Dim item As TabItem = TryCast(sender, TabItem)
        If item.Tag.ToString().Equals("act") Then
            radTabStrip1.AllowEdit = True
            radTabStrip1.TabStripElement.BeginEdit()
        End If
    End Sub

    Private Sub ActTextChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.TextChangingEventArgs)
        ' prevent titles being entered to tabs
        e.Cancel = e.NewValue.Equals(String.Empty)
    End Sub
End Class
