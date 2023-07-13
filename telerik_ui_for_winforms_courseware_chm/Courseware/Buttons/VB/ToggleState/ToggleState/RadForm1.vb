Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler btnSizeModeNormal.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeStretch.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeAutoSize.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeCenterImage.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeZoom.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeStretch.Click, AddressOf SizeModeClick
        AddHandler rbFixed3D.Click, AddressOf BorderStyleClick
        AddHandler rbFixedSingle.Click, AddressOf BorderStyleClick
        AddHandler rbNone.Click, AddressOf BorderStyleClick
        AddHandler rbRotate.Click, AddressOf RotateClick
        ' apply style to entire form, also color the form background.
        ThemeResolutionService.ApplicationThemeName = "Desert"

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

            Dim item As RadMenuItem = GetImageMenuItem(key, image)
            ddbImages.Items.Add(item)
        Loop
        ddbImages.Items(0).PerformClick()

        ' set the item to execute when the button portion of the split
        ' button is clicked.
        sbSizeMode.DefaultItem = sbSizeMode.Items("btnSizeModeZoom")
        ' set the initial text for the split button
        sbSizeMode.Text = sbSizeMode.Items("btnSizeModeZoom").Text
        sbSizeMode.DefaultItem.PerformClick()

        radPanel1.ThemeName = String.Empty
        ThemeResolutionService.ApplicationThemeName = "Desert"
    End Sub

    Private Sub SizeModeClick(ByVal sender As Object, ByVal e As EventArgs)
        ' retrieve the clicked item
        Dim item As RadMenuButtonItem = TryCast(sender, RadMenuButtonItem)
        ' Get the SizeMode enumeration element from the tag and assign to the PictureBox SizeMode
        pictureBox1.SizeMode = CType(Convert.ToInt32(item.Tag), PictureBoxSizeMode)
        ' set the SplitButton text to the clicked on item text
        sbSizeMode.Text = item.Text
    End Sub

    Private Sub BorderStyleClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Get the BorderStyle enumeration element from the tag and assign to the PictureBox BorderStyle
        pictureBox1.BorderStyle = CType(Convert.ToInt32((TryCast(sender, RadRadioButton)).Tag), BorderStyle)
    End Sub

    ' create and populate a single menu item
    Private Function GetImageMenuItem(ByVal name As String, ByVal image As Image) As RadMenuItem
        Dim item As RadMenuItem = New RadMenuItem()
        item.Text = name
        ' store the full image in the tag property and display a thumbnail version
        item.Tag = image
        item.Image = image.GetThumbnailImage(32, 32, Nothing, New IntPtr())
        AddHandler item.Click, AddressOf ChooseImagesClick

        Return item
    End Function

    Private Sub ChooseImagesClick(ByVal sender As Object, ByVal e As EventArgs)
        ' when a drop down button item is clicked, get the item and
        ' retrieve the image, thumbnail and text, then assign to 
        ' the picture box image and the drop down buttondddddd image and text.
        Dim item As RadMenuItem = (TryCast(sender, RadMenuItem))
        ddbImages.Image = (CType(item.Tag, Image)).GetThumbnailImage(16, 16, Nothing, New IntPtr())
        ddbImages.Text = item.Text
        ddbImages.TextImageRelation = TextImageRelation.ImageBeforeText

        pictureBox1.Image = CType(item.Tag, Image)
        SetBackgroundColor(tbBackgroundColor.ToggleState)
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        ' if the user selects an image, create a Bitmap object
        ' and create a key name by stripping the file path for only
        ' the file name without extension. 
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim bitmap As Bitmap = New Bitmap(openFileDialog1.FileName)
            Dim key As String = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName)

            Dim item As RadMenuItem = GetImageMenuItem(key, bitmap)
            ddbImages.Items.Insert(0, item)
            item.PerformClick()

            pictureBox1.Image = bitmap
        End If
    End Sub

    ' Toggle the picture background color between two colors. The first color
    ' is from a pixel grabbed from the middle of the picture, the second is 
    ' a contrasting color calculated off the first.
    Private Sub SetBackgroundColor(ByVal toggleState As Enumerations.ToggleState)
        ' cast picture as bitmap so we can use the GetPixel method
        Dim bitmap As Bitmap = TryCast(pictureBox1.Image, Bitmap)
        ' grab a pixel color from the center of the image
        Dim color As Color = bitmap.GetPixel(bitmap.Width / 2, bitmap.Height / 2)
        ' calculate a contrasting color
        Dim contrastingColor As Color = color.FromArgb(color.ToArgb() Xor &HFFFFFF)
        ' assign the back color based on the toggle state
        pictureBox1.BackColor = IIf(toggleState = toggleState.Off, color, contrastingColor)

    End Sub

    Private Sub tbBackgroundColor_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles tbBackgroundColor.ToggleStateChanged
        SetBackgroundColor(args.ToggleState)
    End Sub

    Private Sub HorizVert_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
        ' true if both checkboxes are off
        Dim bothOff As Boolean = (cbHorizontalFlip.ToggleState = Enumerations.ToggleState.Off) AndAlso (cbVerticalFlip.ToggleState = Enumerations.ToggleState.Off)

        ' true if both checkboxes are on
        Dim bothOn As Boolean = (cbHorizontalFlip.ToggleState = Enumerations.ToggleState.On) AndAlso (cbVerticalFlip.ToggleState = Enumerations.ToggleState.On)

        If bothOn Then
            cbFlip.ToggleState = Enumerations.ToggleState.On
        ElseIf bothOff Then
            cbFlip.ToggleState = Enumerations.ToggleState.Off
        Else
            cbFlip.ToggleState = Enumerations.ToggleState.Indeterminate
        End If
    End Sub

    Private Sub cbFlip_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
        If args.ToggleState <> Enumerations.ToggleState.Indeterminate Then
            ' unhook event handler temporarily
            RemoveHandler cbHorizontalFlip.ToggleStateChanged, AddressOf HorizVert_ToggleStateChanged
            RemoveHandler cbVerticalFlip.ToggleStateChanged, AddressOf HorizVert_ToggleStateChanged

            cbHorizontalFlip.ToggleState = args.ToggleState
            cbVerticalFlip.ToggleState = args.ToggleState

            ' re-hook event handler 
            AddHandler cbHorizontalFlip.ToggleStateChanged, AddressOf HorizVert_ToggleStateChanged
            AddHandler cbVerticalFlip.ToggleStateChanged, AddressOf HorizVert_ToggleStateChanged
        End If
    End Sub

    ' rotate and flip the image based on the checkbox settings
    Private Sub RotateClick(ByVal sender As Object, ByVal e As EventArgs)
        If cbFlip.ToggleState = Enumerations.ToggleState.On Then
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
        ElseIf cbHorizontalFlip.ToggleState = Enumerations.ToggleState.On Then
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
        ElseIf cbVerticalFlip.ToggleState = Enumerations.ToggleState.On Then
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY)
        Else
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        pictureBox1.Refresh()
    End Sub
End Class