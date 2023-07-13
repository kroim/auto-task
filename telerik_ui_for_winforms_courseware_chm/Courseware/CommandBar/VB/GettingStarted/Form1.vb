Public Class Form1

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "*.txt,*.rtf|*.txt;*.rtf"
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = dialog.FileName
            If fileName.Length > 0 Then
                RichTextBox1.LoadFile(fileName, GetStreamType(fileName))
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "*.txt,*.rtf|*.txt;*.rtf"
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = dialog.FileName
            richTextBox1.SaveFile(fileName, GetStreamType(dialog.FileName))
        End If
    End Sub

    Private Function GetStreamType(ByVal fileName As String) As RichTextBoxStreamType
        Return If(fileName.EndsWith("rtf"), RichTextBoxStreamType.RichText, RichTextBoxStreamType.PlainText)
    End Function

End Class
