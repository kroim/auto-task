Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler btnSizeModeNormal.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeStretch.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeAutoSize.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeCenterImage.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeZoom.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeStretch.Click, AddressOf SizeModeClick

        AddHandler rbFixed3D.Click, AddressOf BorderStyleClick
        AddHandler rbFixedSingle.Click, AddressOf BorderStyleClick
        AddHandler rbNone.Click, AddressOf BorderStyleClick

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
        ' the picture box image and the drop down button image and text.
        Dim item As RadMenuItem = (TryCast(sender, RadMenuItem))
        ddbImages.Image = (CType(item.Tag, Image)).GetThumbnailImage(16, 16, Nothing, New IntPtr())
        ddbImages.Text = item.Text
        ddbImages.TextImageRelation = TextImageRelation.ImageBeforeText

        pictureBox1.Image = CType(item.Tag, Image)
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
End Class
