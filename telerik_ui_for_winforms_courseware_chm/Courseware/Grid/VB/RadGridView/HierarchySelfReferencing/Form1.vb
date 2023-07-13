Imports System.ComponentModel
Imports System.IO
Imports Telerik.WinControls.UI

Public Class Form1
    Public Sub New()

        InitializeComponent()
        GetFilesAndFolders("C:\Program Files (x86)\Telerik", fileFolderIndex)

        Me.RadGridView1.Relations.AddSelfReference(Me.RadGridView1.MasterTemplate, "Id", "ParentFolderId")
        Me.RadGridView1.DataSource = list

        Me.RadGridView1.Columns("Id").IsVisible = False
        Me.RadGridView1.Columns("ParentFolderId").IsVisible = False
        Me.RadGridView1.Columns("FileSystemInfoType").IsVisible = False

    End Sub

    Private list As New BindingList(Of FileSystemItem)()
    Private fileFolderIndex As Integer = 0

    Public Sub GetFilesAndFolders(ByVal dir As String, ByVal parentId As Integer)
        Dim di As New DirectoryInfo(dir)
        Dim rgFiles() As FileInfo = di.GetFiles()
        For Each fi As FileInfo In rgFiles
            fileFolderIndex += 1
            list.Add(New FileSystemItem(fileFolderIndex, "File", fi.Name, fi.CreationTime, parentId))
        Next fi

        Dim dirs() As DirectoryInfo = di.GetDirectories()
        For Each d As DirectoryInfo In dirs
            fileFolderIndex += 1
            list.Add(New FileSystemItem(fileFolderIndex, "Folder", d.Name, d.CreationTime, parentId))
            GetFilesAndFolders(d.FullName, fileFolderIndex)
        Next d
    End Sub

    ' Getting the images from the resources of the project
    Private documentImage As Image = HierarchySelfReferencing.My.Resources.Document
    Private folderImage As Image = HierarchySelfReferencing.My.Resources.Folder

    Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        Dim dataCell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)

        If dataCell.ColumnInfo.Name = "Name" Then
            Dim dataRow As GridViewDataRowInfo = TryCast(dataCell.RowInfo, GridViewDataRowInfo)
            If dataRow IsNot Nothing Then
                dataCell.ImageAlignment = ContentAlignment.MiddleLeft

                Dim valueType As String = Convert.ToString(dataRow.Cells("FileSystemInfoType").Value).ToUpperInvariant()

                If valueType.Contains("FILE") Then
                    dataCell.Image = documentImage
                Else
                    dataCell.Image = folderImage
                End If

                dataCell.TextImageRelation = TextImageRelation.ImageBeforeText
            End If
        Else
            dataCell.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
            dataCell.ResetValue(LightVisualElement.ImageAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
            dataCell.ResetValue(LightVisualElement.TextImageRelationProperty, Telerik.WinControls.ValueResetFlags.Local)
            dataCell.ResetValue(LightVisualElement.ImageLayoutProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
End Class
