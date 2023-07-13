Imports Telerik.WinControls.UI

Public Class Form1
    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGo.Click
        Dim fileItem As RadMenuItem = CType(radMenu1.Items("miFile"), RadMenuItem)
        Dim openItem As RadMenuItem = CType(fileItem.Items("miOpen"), RadMenuItem)
        If Not openItem Is Nothing Then
            fileItem.Items.Remove(openItem)
        End If

        ' finds the "Save" item from the "File" Items collection
        For Each item As RadMenuItem In fileItem.Items
            If item.Name.Equals("miSave") Then
                item.ToolTipText = "Next automatic save at " & DateTime.Now.AddHours(0.5)
                Exit For
            End If
        Next item
    End Sub
End Class
