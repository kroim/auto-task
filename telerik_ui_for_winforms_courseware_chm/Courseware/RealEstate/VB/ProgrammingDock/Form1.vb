Imports Telerik.WinControls

Public Class Form1


    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim dialog As New OpenFileDialog()
        dialog.DefaultExt = "xml"
        If dialog.ShowDialog() = DialogResult.OK Then
            RadDock1.LoadFromXml(dialog.FileName)
            lblStatus.Text = "Loaded layout " + dialog.FileName
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dialog As New SaveFileDialog()
        dialog.DefaultExt = "xml"
        If dialog.ShowDialog() = DialogResult.OK Then
            RadDock1.SaveToXml(dialog.FileName)
            lblStatus.Text = "Saved layout as " + dialog.FileName
        End If

    End Sub

    Private Sub btnLayout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLayout.Click
        ToolWindow1.Close()
        ToolWindow3.Close()
        ToolWindow4.Close()
        lblStatus.Text = "Layout changed"
    End Sub
End Class
