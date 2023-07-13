Imports Telerik.WinControls.UI
Imports System.IO

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)
    End Sub

    Private Sub radListControl1_ItemDataBound(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.ListItemDataBoundEventArgs) Handles radListControl1.ItemDataBound
        ' retrieve the data row that was bound
        Dim row As MusicCollectionDataSet.AlbumsRow = (TryCast((TryCast(args.NewItem.DataBoundItem, DataRowView)).Row, MusicCollectionDataSet.AlbumsRow))

        ' retrieve the item that was bound to and set properties
        Dim item As RadListDataItem = TryCast(args.NewItem, RadListDataItem)
        item.TextImageRelation = TextImageRelation.ImageBeforeText

        ' assign the image as a thumbnail
        item.Image = GetImageFromData(row.Image).GetThumbnailImage(64, 64, Nothing, New IntPtr())
    End Sub

    ' return true if the byte array has an OLE DB header
    Private Function HasOleContainerHeader(ByVal imageByteArray As Byte()) As Boolean
        Const OleByte0 As Byte = 21
        Const OleByte1 As Byte = 28
        Return (imageByteArray(0) = OleByte0) AndAlso (imageByteArray(1) = OleByte1)
    End Function

    ' convert the image byte array to a memory stream, then a bitmap 
    Private Function GetImageFromData(ByVal imageData As Byte()) As Image
        Const OleHeaderLength As Integer = 78
        Dim memoryStream As MemoryStream = New MemoryStream()

        ' if the byte array has a OLE DB header, leave the header out of the copy
        If HasOleContainerHeader(imageData) Then
            memoryStream.Write(imageData, OleHeaderLength, imageData.Length - OleHeaderLength)
        Else
            memoryStream.Write(imageData, 0, imageData.Length)
        End If

        ' convert to Bitmap/Image
        Return New Bitmap(memoryStream)
    End Function

   
End Class
