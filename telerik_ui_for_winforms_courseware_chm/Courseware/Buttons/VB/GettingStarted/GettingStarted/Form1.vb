Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' apply style to entire form, also color the form background.
        ThemeResolutionService.ApplicationThemeName = "Desert"

        ' set the item to execute when the button portion of the split
        ' button is clicked.
        sbSizeMode.DefaultItem = sbSizeMode.Items("btnSizeModeZoom")
        ' set the initial text for the split button
        sbSizeMode.Text = sbSizeMode.Items("btnSizeModeZoom").Text
        sbSizeMode.DefaultItem.PerformClick()

        AddHandler btnSizeModeNormal.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeStretch.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeAutoSize.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeCenterImage.Click, AddressOf SizeModeClick
        AddHandler btnSizeModeZoom.Click, AddressOf SizeModeClick
        AddHandler rbFixed3D.Click, AddressOf BorderStyleClick
        AddHandler rbFixedSingle.Click, AddressOf BorderStyleClick
        AddHandler rbNone.Click, AddressOf BorderStyleClick
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

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        ' open a user selected image file and assign to the picture box
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim bitmap As Bitmap = New Bitmap(openFileDialog1.FileName)
            pictureBox1.Image = bitmap
        End If
    End Sub
End Class
