Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.RegisterThemeFromStorage(ThemeStorageType.Resource, "ContextMenu.RadMenuButtonItem.xml")
        cmDeliveryMethod.ThemeName = "Office2007Silver"

        ' prevent the standard MS context menu
        tbGiftType.TextBoxElement.TextBoxItem.HostedControl.ContextMenuStrip = New ContextMenuStrip()

        ' hook up a RadContextMenu by using the TextBoxElement mouse down event      
        AddHandler tbGiftType.TextBoxElement.MouseDown, AddressOf TextBoxElement_MouseDown
        AddHandler mbiDeliveryMethod1.Click, AddressOf mbiDeliveryMethodClick
        AddHandler mbiDeliveryMethod2.Click, AddressOf mbiDeliveryMethodClick
        AddHandler mbiDeliveryMethod3.Click, AddressOf mbiDeliveryMethodClick
        AddHandler mbiDeliveryMethod4.Click, AddressOf mbiDeliveryMethodClick

        AddHandler miGiftType1.Click, AddressOf miGiftTypeClick
        AddHandler miGiftType2.Click, AddressOf miGiftTypeClick
        AddHandler miGiftType3.Click, AddressOf miGiftTypeClick
        AddHandler miGiftType4.Click, AddressOf miGiftTypeClick

        LoadWrappingContextMenu()
    End Sub

    ' respond to right mouse clicks in the text box
    Private Sub TextBoxElement_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            cmGiftType.Show(TryCast(sender, RadTextBoxElement), e.X, e.Y)
        End If
    End Sub

    ' enumerate the image resources, creating menu items
    Private Sub LoadWrappingContextMenu()
        Dim resourceSet As Resources.ResourceSet = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        Dim enumerator As IDictionaryEnumerator = resourceSet.GetEnumerator()

        Do While enumerator.MoveNext()
            Dim key As String = (CStr(enumerator.Key)).Replace("_"c, " "c)
            Dim image As Image = CType(enumerator.Value, Image)

            Dim item As RadMenuItem = New RadMenuItem()
            item.Text = System.IO.Path.GetFileNameWithoutExtension(key)
            item.Image = image.GetThumbnailImage(64, 64, Nothing, New IntPtr())
            AddHandler item.Click, AddressOf item_Click
            cmWrapping.Items.Add(item)
        Loop
    End Sub

    ' respond to clicks of the "wrapping" items by assigning
    ' the panel background image.
    Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
        pnlWrappingPaper.BackgroundImage = (TryCast(sender, RadMenuItem)).Image
    End Sub

    Private Sub miGiftTypeClick(ByVal sender As Object, ByVal e As EventArgs)
        tbGiftType.Text = (TryCast(sender, RadMenuItem)).Text
    End Sub

    Private Sub mbiDeliveryMethodClick(ByVal sender As Object, ByVal e As EventArgs)
        lblDeliveryMethod.Text = (TryCast(sender, RadMenuButtonItem)).Text
    End Sub
End Class
