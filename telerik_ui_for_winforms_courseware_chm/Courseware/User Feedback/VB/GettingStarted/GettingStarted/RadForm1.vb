Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1
    Private Sub btnServers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServers.Click
        lcServers.Items.Clear()
        pbStatus.Maximum = tbMaxObjects.Value

        Dim i As Integer = 0
        Do While i < tbMaxObjects.Value
            Dim item As New RadListDataItem("Server" + i.ToString())
            lcServers.Items.Add(item)
            pbStatus.Value1 = i
            ssMain.Refresh()
            i += 1
        Loop
        lblStatus.Text = "Loaded " & tbMaxObjects.Value.ToString() & " servers"
    End Sub

    Private Sub tbMaxObjects_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbMaxObjects.ValueChanged
        lblCount.Text = tbMaxObjects.Value.ToString()
    End Sub

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbMaxObjects.Value = tbMaxObjects.Maximum
        lblCount.Text = tbMaxObjects.Value.ToString()
    End Sub
End Class
