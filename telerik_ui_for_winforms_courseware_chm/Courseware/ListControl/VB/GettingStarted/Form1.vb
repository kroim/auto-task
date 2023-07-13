Imports System.IO
Imports Telerik.WinControls.UI

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' load the dropdown list with drive names and select the first one
        For Each driveInfo__1 As DriveInfo In DriveInfo.GetDrives()
            If driveInfo__1.IsReady Then
                Dim info As New DirectoryInfo(driveInfo__1.RootDirectory.FullName)
                AddDirectoryToDropDownList(info, ddlDrives)
            End If
        Next
        ddlDrives.SelectedIndex = 0
    End Sub

    Private Sub AddDirectoryToDropDownList(ByVal info As DirectoryInfo, ByVal dropDownList As RadDropDownList)
        ' display the path and save the "info" as the Value property
        Dim item As New RadListDataItem(info.FullName, info)
        dropDownList.Items.Add(item)
    End Sub

    Private Sub ddlDrives_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlDrives.SelectedIndexChanged
        ' get the dropdown list that triggered this event,
        ' get the currently selected item in the dropdown lsit and
        ' extract the DirectoryInfo
        Dim dropDownListElement As RadDropDownListElement = TryCast(sender, RadDropDownListElement)
        Dim item As RadListDataItem = dropDownListElement.SelectedItem
        Dim directoryInfo As DirectoryInfo = TryCast(item.Value, DirectoryInfo)
        lcFiles.Items.Clear()
        ' get a list of all directories and files
        For Each info As FileSystemInfo In directoryInfo.GetFileSystemInfos()
            lcFiles.Items.Add(New RadListDataItem(info.Name, info))
        Next
        lcFiles.SelectedIndex = 0
    End Sub

    Private Sub lcFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles lcFiles.SelectedIndexChanged
        If TryCast(sender, RadListElement).SelectedItem IsNot Nothing Then
            Dim item As RadListDataItem = TryCast(sender, RadListElement).SelectedItem
            Dim info As FileSystemInfo = TryCast(item.Value, FileSystemInfo)
            lblStatus.Text = info.Name
        End If
    End Sub

End Class
