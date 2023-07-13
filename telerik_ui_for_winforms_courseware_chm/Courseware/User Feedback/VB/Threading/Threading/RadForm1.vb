Imports System.Threading
Imports System.ComponentModel
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbMaxObjects.Value = tbMaxObjects.Maximum
        lblCount.Text = tbMaxObjects.Value.ToString()
    End Sub

    Private Sub btnServers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServers.Click
        lblStatus.Text = "Finding..."
        Dim worker As BackgroundWorker = New BackgroundWorker()
        AddHandler worker.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler worker.DoWork, AddressOf worker_DoWork
        worker.WorkerReportsProgress = True
        AddHandler worker.ProgressChanged, AddressOf worker_ProgressChanged
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim i As Integer = 0
        While i < tbMaxObjects.Value
            TryCast(sender, BackgroundWorker).ReportProgress(i, i)
            Thread.Sleep(5)
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        e.Result = tbMaxObjects.Value
    End Sub

    Private Sub worker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        Dim item As New RadListDataItem("Server" & e.UserState.ToString())
        lcServers.Items.Add(item)
        pbStatus.Value1 = e.ProgressPercentage
    End Sub

    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        lblStatus.Text = "Completed processing " & e.Result.ToString() & " items"
    End Sub

    Private Sub tbMaxObjects_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbMaxObjects.ValueChanged
        lblCount.Text = tbMaxObjects.Value.ToString()
    End Sub
End Class
