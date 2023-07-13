Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Public Class LoadOnDemand
    Private Sub radTreeView1_NodesNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.NodesNeededEventArgs) Handles radTreeView1.NodesNeeded
        ' measure how long this takes
        Dim stopwatch As New Stopwatch()
        stopwatch.Start()

        Dim count As Integer = 0

        ' get the data for all child nodes
        Dim weatherStations As String() = My.Resources.WeatherStations.Split(New String() {Constants.vbCrLf}, StringSplitOptions.RemoveEmptyEntries)


        For Each station As String In weatherStations
            e.Nodes.Add(New RadTreeNode(station))
            count += 1
        Next

        ' show performance results
        stopwatch.[Stop]()
        Dim ts As TimeSpan = stopwatch.Elapsed
        lblStatus.Text = [String].Format("{0:00}:{1:00}:{2:00}.{3:00} loading {4} nodes", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10, count)

        Me.radTreeView1.EndUpdate()
    End Sub
End Class