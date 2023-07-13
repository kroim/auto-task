Imports System
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI


Public Class Form1
    Private Function IsRootDirectory(ByVal info As DirectoryInfo) As Boolean
        Return info.Root.FullName.Equals(info.FullName)
    End Function

    Private Function IsDirectory(ByVal info As FileSystemInfo) As Boolean
        Return (info.Attributes And FileAttributes.Directory) = FileAttributes.Directory
    End Function

    Private Function IsHidden(ByVal info As FileSystemInfo) As Boolean
        Return (info.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden
    End Function

    Private Function GetParentDirectory(ByVal info As FileSystemInfo) As DirectoryInfo
        Return New DirectoryInfo(Path.GetDirectoryName(info.FullName))
    End Function

    ' reference to element for image in dropdown list text area
    Private _imagePrimitive As ImagePrimitive
    ' stores a reference to item under last mouse down
    Private _currentItem As RadListDataItem

    ' display a status message and accompanying image 16px thumbnail
    Private Sub ShowStatus(ByVal message As String, ByVal image As Image)
        lblStatus.Text = message
        lblStatus.TextImageRelation = TextImageRelation.ImageBeforeText
        If image IsNot Nothing Then
            lblStatus.Image = image.GetThumbnailImage(16, 16, Nothing, New IntPtr())
        End If
    End Sub

    ' display exception message in status label with error icon 16px thumbnail
    Private Sub ShowStatus(ByVal ex As Exception)
        ShowStatus(ex.Message, imageList1.Images("symbol error.ico"))
    End Sub

    ' show file/directory description as status message and 16px icon
    Private Sub ShowStatus(ByVal selectedItem As RadListDataItem)
        If selectedItem IsNot Nothing Then
            Dim item As RadListDataItem = TryCast(selectedItem, RadListDataItem)
            Dim info As FileSystemInfo = TryCast(item.Value, FileSystemInfo)
            Dim message As String = GetFileSystemDescription(info, DescriptionDetail.[Partial])
            ShowStatus(message, item.Image)
        End If
    End Sub

    ' scope of description
    Private Enum DescriptionDetail
        [Partial]
        Full
    End Enum

    ' build a string with number of objects/bytes in directory/file.
    ' if DescriptionDetail is "Full", add "Created"/"Updated" statistics
    Private Function GetFileSystemDescription(ByVal info As FileSystemInfo, ByVal detail As DescriptionDetail) As String
        Dim builder As New StringBuilder()

        If TypeOf info Is DirectoryInfo Then
            Dim dirInfo As DirectoryInfo = TryCast(info, DirectoryInfo)
            Dim size As Long = dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length
            builder.Append(size.ToString())
            builder.Append(" objects")
            builder.Append(System.Environment.NewLine)
        Else
            Dim fileInfo As FileInfo = TryCast(info, FileInfo)
            builder.Append(fileInfo.Length.ToString())
            builder.Append(" bytes")
            builder.Append(System.Environment.NewLine)
        End If

        If detail = DescriptionDetail.Full Then
            builder.Append("Created on: ")
            builder.Append(info.CreationTime.ToString())
            builder.Append(System.Environment.NewLine)
            builder.Append("Updated on: ")
            builder.Append(info.LastWriteTime.ToString())
        End If
        Return builder.ToString()

    End Function

    ' Add path and DirectoryInfo object to RadDropDownList   
    Private Sub AddDirectoryToDropDownList(ByVal info As DirectoryInfo, ByVal dropDownList As RadDropDownList)
        If dropDownList.FindStringExact(info.FullName) = -1 Then
            Dim item As New RadListDataItem(info.FullName, info)
            item.Text = info.FullName
            item.TextImageRelation = TextImageRelation.ImageBeforeText
            ' use Shell32 api to get appication bitmap
            item.Image = Shell32.GetFileBitmap(info.FullName)

            dropDownList.Items.Add(item)
        End If
        dropDownList.SelectedItem = dropDownList.Items(dropDownList.FindStringExact(info.FullName))
    End Sub

    ' load a RadListControl with the files in a directory
    Private Sub LoadFilesListControl(ByVal directoryInfo As DirectoryInfo, ByVal listControl As RadListControl)
        listControl.Items.Clear()

        For Each info As FileSystemInfo In directoryInfo.GetFileSystemInfos()
            If Not IsHidden(info) Then
                ' add Text and Value in constructor
                Dim item As New RadListDataItem(info.Name, info)
                item.TextImageRelation = TextImageRelation.ImageBeforeText
                ' use the Shell32 API to get bitmap for file
                item.Image = Shell32.GetFileBitmap(info.FullName)

                listControl.Items.Add(item)

                Try
                    GetFileSystemDescription(DirectCast(item.Value, FileSystemInfo), DescriptionDetail.Full)
                    ' if directory cannot be accessed, disable item and include error message
                Catch ex As UnauthorizedAccessException
                    item.Enabled = False

                End Try
            End If
        Next
        If listControl.Items.Count > 0 Then
            listControl.SelectedIndex = 0
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' load the dropdown list with drive names and select the first one
        For Each driveInfo__1 As DriveInfo In DriveInfo.GetDrives()
            If driveInfo__1.IsReady Then
                Dim info As New DirectoryInfo(driveInfo__1.RootDirectory.FullName)
                AddDirectoryToDropDownList(info, ddlDrives)
            End If
        Next

        ' get references to the textbox element and the textbox item within the element
        Dim textBoxElement As RadTextBoxElement = ddlDrives.DropDownListElement.TextBox
        Dim textBoxItem As RadTextBoxItem = textBoxElement.TextBoxItem
        ' Add extra padding on the left for the new image
        textBoxItem.Margin = New Padding(20, 1, 1, 1)
        ' pad the element so textboxitem doesn't overwrite the
        ' border on the right side
        textBoxElement.Padding = New Padding(2, 2, 20, 2)
        ' save a reference
        _imagePrimitive = New ImagePrimitive()

        AddHandler lcFiles.ToolTipTextNeeded, AddressOf lcFiles_ToolTipTextNeeded
        AddHandler ddlDrives.SelectedIndexChanged, AddressOf ddlDrives_SelectedIndexChanged
        'insert the ImagePrimitive to the text box element
        textBoxElement.Children.Insert(0, _imagePrimitive)
        'hide the FillPrimitive so the image to be displayed
        textBoxElement.Fill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        'select the first item in the dropdown
        ddlDrives.SelectedIndex = 0
        'make the items size according to their content
        ddlDrives.AutoSizeItems = True
        lcFiles.AutoSizeItems = True

    End Sub

    Private Sub lcFiles_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles lcFiles.ToolTipTextNeeded
        Dim visualItem As RadListVisualItem = TryCast(sender, RadListVisualItem)
        If visualItem IsNot Nothing Then
            Try
                e.ToolTipText = GetFileSystemDescription(DirectCast(visualItem.Data.Value, FileSystemInfo), DescriptionDetail.Full)
                ' if directory cannot be accessed, display error message
            Catch ex As UnauthorizedAccessException
                e.ToolTipText = ex.Message
            End Try
        End If
    End Sub

    Private Sub ddlDrives_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        Cursor.Current = Cursors.WaitCursor
        Try
            Dim directoryInfo As DirectoryInfo = TryCast(ddlDrives.SelectedValue, DirectoryInfo)
            btnBack.Enabled = Not IsRootDirectory(directoryInfo)
            LoadFilesListControl(directoryInfo, lcFiles)
            Dim selectedImage As Image = TryCast(ddlDrives.SelectedItem, RadListDataItem).Image
            _imagePrimitive.Image = selectedImage.GetThumbnailImage(16, 16, Nothing, New IntPtr())
        Catch ex As UnauthorizedAccessException
            ShowStatus(ex)
        Finally
            Cursor.Current = Cursors.[Default]
        End Try
    End Sub

    Private Sub lcFiles_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles lcFiles.SelectedIndexChanged
        If lcFiles.SelectedItem IsNot Nothing AndAlso lcFiles.SelectedItem.Enabled Then
            ShowStatus(lcFiles.SelectedItem)
        End If
    End Sub

    Private Sub lcFiles_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcFiles.MouseDown
        Dim item As RadListVisualItem = TryCast(lcFiles.ElementTree.GetElementAtPoint(e.Location), RadListVisualItem)
        If item IsNot Nothing Then
            _currentItem = item.Data
        End If
    End Sub

    Private Sub lcFiles_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lcFiles.MouseUp
        _currentItem = Nothing
    End Sub

    Private Sub lcFiles_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lcFiles.DoubleClick
        Cursor.Current = Cursors.WaitCursor
        If _currentItem IsNot Nothing AndAlso _currentItem.Enabled Then
            Dim info As FileSystemInfo = TryCast(_currentItem.Value, FileSystemInfo)
            If TypeOf info Is DirectoryInfo Then
                AddDirectoryToDropDownList(TryCast(info, DirectoryInfo), ddlDrives)
            Else
                System.Diagnostics.Process.Start(info.FullName)
            End If
        End If
        Cursor.Current = Cursors.[Default]
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Cursor.Current = Cursors.WaitCursor
        Dim directoryInfo As DirectoryInfo = TryCast(ddlDrives.SelectedValue, DirectoryInfo)
        AddDirectoryToDropDownList(GetParentDirectory(directoryInfo), ddlDrives)
        Cursor.Current = Cursors.[Default]
    End Sub
End Class
