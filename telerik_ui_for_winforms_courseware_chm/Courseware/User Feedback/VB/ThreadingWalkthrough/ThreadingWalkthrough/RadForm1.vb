Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Drawing
Imports Microsoft.SqlServer.Management.Smo
Imports Telerik.WinControls.Primitives

Friend Enum StatusTypes
    Info
    [Error]
    Find
End Enum

Public Class RadForm1
    Private _dbInfoList As List(Of DatabaseInfo)
    Private _waitingBarHostLabel As RadLabelElement

    ' retrieve an image for a given status
    Private Function GetStatusImage(ByVal statusType As StatusTypes) As Image
        Select Case statusType
            Case StatusTypes.Error
                Return My.Resources.Error1

            Case StatusTypes.Info
                Return My.Resources.Information

            Case StatusTypes.Find
                Return My.Resources.FindServersAnimated

            Case Else
                Return My.Resources.Information
        End Select
    End Function

    ' display a text and image status message
    Private Sub DisplayStatus(ByVal message As String, ByVal statusType As StatusTypes)
        lblStatus.Text = message
        lblStatus.Image = GetStatusImage(statusType)
    End Sub

    ' create a RadLabel\HostedItem\RadWaitingBar and insert into
    ' the status strip.
    Private Function GetHostedWaitingBar(ByVal name As String) As RadLabelElement
        ' make height and width the same so ellipse will be a circle
        Dim size As System.Drawing.Size = New System.Drawing.Size(btnServers.Size.Height, btnServers.Size.Height)
        ' use hosted waiting bar control instead of element for access to 
        ' start/stop waiting methods.
        Dim waitingBar As RadWaitingBar = New RadWaitingBar()
        ' waiting bar animation sweeps top to bottom
        waitingBar.Orientation = Orientation.Vertical
        waitingBar.WaitingBarElement.BackColor = Color.SteelBlue
        waitingBar.WaitingBarElement.Shape = New EllipseShape()
        Dim waitingBarHostLabel As RadLabelElement = New RadLabelElement()
        ' status label to the left will respect DefaultSize and 
        ' leave room for waiting bar
        waitingBarHostLabel.DefaultSize = size
        waitingBarHostLabel.Name = name
        Dim host As RadHostItem = New RadHostItem(waitingBar)
        waitingBarHostLabel.Children.Insert(0, host)
        ' set transparent after being inserted to host children
        waitingBar.BackColor = Color.Transparent

        Return waitingBarHostLabel
    End Function

    ' Loads a list control with generic List of DatabaseInfo; 
    ' Name to the Text and number of objects to the description
    Private Sub LoadDatabaseList(ByVal listControl As RadListControl, ByVal maxObjects As Integer)
        listControl.Items.Clear()
        For Each info As DatabaseInfo In _dbInfoList
            ' limit databases to those with number of objects within trackbar limits
            If info.ObjectCountProp <= maxObjects Then
                Dim item As RadListDataItem = New RadListDataItem(info.DatabaseNameProp, info)
                listControl.Items.Add(item)
            End If
        Next info
    End Sub

    ' reset progress bar value and add to status strip
    Private Sub ShowProgressBar()
        pbStatus.Value1 = 0
        ssMain.Items.Add(pbStatus)
    End Sub

    ' remove progress bar from status strip
    Private Sub HideProgressBar()
        ssMain.Items.Remove(pbStatus)
    End Sub

    ' add waiting bar element to status strip,
    ' get host item, drill down to waitiing bar and StartWaiting()
    Private Sub ShowWaitingBar()
        ssMain.Items.Add(_waitingBarHostLabel)
        Dim hostItem As RadHostItem = TryCast(_waitingBarHostLabel.Children(0), RadHostItem)
        TryCast(hostItem.HostedControl, RadWaitingBar).StartWaiting()
    End Sub

    ' get host item, drill down to waitiing bar, StopWaiting() and 
    ' remove element from status strip.   
    Private Sub HideWaitingBar()
        Dim hostItem As RadHostItem = TryCast(_waitingBarHostLabel.Children(0), RadHostItem)
        TryCast(hostItem.HostedControl, RadWaitingBar).StopWaiting()
        ssMain.Items.Remove(_waitingBarHostLabel)
    End Sub

    ' disable controls during processing
    Private Sub SetUIEnabled(ByVal enabled As Boolean)
        btnServers.Enabled = enabled
        lbServers.Enabled = enabled
        lbDatabases.Enabled = enabled
        ' only enable when there are objects to filter
        If (Not enabled) Then
            tbMaxObjects.Enabled = False
        End If
    End Sub

    ' create and configure the BackgroundWorker object 
    Private Sub RunServerWorker()
        Dim serverWorker As BackgroundWorker = New BackgroundWorker()
        AddHandler serverWorker.DoWork, AddressOf serverWorker_DoWork
        AddHandler serverWorker.RunWorkerCompleted, AddressOf serverWorker_RunWorkerCompleted
        serverWorker.RunWorkerAsync()
    End Sub

    ' retrieve MS SQL servers, pass back DataTable result
    Private Sub serverWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        e.Result = SmoApplication.EnumAvailableSqlServers()
    End Sub

    ' update the UI using the Result property of the args, or
    ' the Error property if the operation fails.
    Private Sub serverWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If Not e.Error Is Nothing Then
            DisplayStatus(e.Error.Message, StatusTypes.Error)
        Else
            ' populate list control from data table of servers passed in as Result
            Dim dt As DataTable = TryCast(e.Result, DataTable)
            For Each row As DataRow In dt.Rows
                lbServers.Items.Add(New RadListDataItem(row("Name").ToString()))
            Next row
            DisplayStatus("Found " & dt.Rows.Count.ToString() & " servers", StatusTypes.Info)
        End If
        HideWaitingBar()
        SetUIEnabled(True)
    End Sub

    ' create and configure BackgroundWorker. Populate and pass argument.
    ' enable progress reporting
    Private Sub RunDbWorker(ByVal serverName As String, ByVal maxObjects As Integer)
        Dim dbWorker As BackgroundWorker = New BackgroundWorker()
        dbWorker.WorkerReportsProgress = True
        AddHandler dbWorker.DoWork, AddressOf dbWorker_DoWork
        AddHandler dbWorker.ProgressChanged, AddressOf dbWorker_ProgressChanged
        AddHandler dbWorker.RunWorkerCompleted, AddressOf dbWorker_RunWorkerCompleted
        dbWorker.RunWorkerAsync(serverName)
    End Sub

    ' retrieve the list of databases for the server: 
    ' -get the number of objects for each database,
    ' -keep track of the min and max number of objects.
    ' -calculate progress,
    ' -create and populate a DatabaseInfo object and pass to 
    ' ProgressChanged event handler.
    ' Create and populate a DBWorkerResult object and assign to the arguments
    ' Result property.
    Private Sub dbWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim server As Server = New Server(e.Argument.ToString())
        Dim count As Integer = 0
        Dim maxObjectCount As Integer = 0
        Dim minObjectCount As Integer = 0
        For Each database As Database In server.Databases
            count += 1
            ' ignore empty databases
            If database.IsAccessible Then
                ' get all objects in the database
                Dim dtObjects As DataTable = database.EnumObjects()
                ' calculate progress 
                Dim progress As Integer = CInt(Fix((CDbl(count) / CDbl(server.Databases.Count)) * 100))
                ' assign the first non-zero value
                If (minObjectCount = 0) AndAlso (dtObjects.Rows.Count > 0) Then
                    minObjectCount = dtObjects.Rows.Count
                End If
                ' get min and max number of objects for all databases in server
                maxObjectCount = Math.Max(maxObjectCount, dtObjects.Rows.Count)
                minObjectCount = Math.Min(maxObjectCount, dtObjects.Rows.Count)
                ' Call ReportProgress to trigger ProgressChanged event.
                ' DatabaseInfo passed as the UserState property
                Dim databaseInfo As DatabaseInfo = New DatabaseInfo(server.Name, database.Name, dtObjects.Rows.Count)
                TryCast(sender, BackgroundWorker).ReportProgress(progress, databaseInfo)
            End If
        Next database
        e.Result = New DBWorkerResult(server.Name, maxObjectCount, minObjectCount)
    End Sub

    ' respond to ReportProgress() method calls, set progress bar value, 
    ' extract the DatabaseInfo object from the argument's UserState property:
    ' add to the generic list of DatabaseInfo objects for use on completion,
    ' and display a status message with the current database name.
    Private Sub dbWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        pbStatus.Value1 = e.ProgressPercentage
        Dim info As DatabaseInfo = TryCast(e.UserState, DatabaseInfo)
        _dbInfoList.Add(info)
        DisplayStatus(info.DatabaseNameProp, StatusTypes.Info)
    End Sub

    ' update the UI using the Result property of the args, or
    ' the Error property if the operation fails.
    Private Sub dbWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If Not e.Error Is Nothing Then
            ' reset the "Databases" label to default value
            lblDatabases.Text = "Databases"
            ' display the exception
            DisplayStatus(e.Error.Message, StatusTypes.Error)
        Else
            Dim workerResult As DBWorkerResult = TryCast(e.Result, DBWorkerResult)
            tbMaxObjects.Maximum = workerResult.MaxItemsProp
            ' if there are no items, then minimum is zero, otherwise, 
            ' set to the fewest number of items (will always display at least one)
            If workerResult.MinItemsProp = 0 Then
                tbMaxObjects.Minimum = 0
            Else
                tbMaxObjects.Minimum = workerResult.MinItemsProp - 1
            End If
            Dim range As Integer = workerResult.MaxItemsProp - workerResult.MinItemsProp
            tbMaxObjects.TickFrequency = range / 10
            tbMaxObjects.Value = tbMaxObjects.Maximum
            ' only enable when there are items
            tbMaxObjects.Enabled = workerResult.MaxItemsProp > 0
            lblCount.Text = tbMaxObjects.Value.ToString()
            LoadDatabaseList(lbDatabases, tbMaxObjects.Value)

            lblDatabases.Text = "Databases for " & workerResult.ServerNameProp
            Dim message As String = "Found " & lbDatabases.Items.Count & " databases for " & workerResult.ServerNameProp
            DisplayStatus(message, StatusTypes.Info)
        End If

        HideProgressBar()
        SetUIEnabled(True)
    End Sub

    Private Sub btnServers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServers.Click
        SetUIEnabled(False)
        lbServers.Items.Clear()
        lbDatabases.Items.Clear()
        lblDatabases.Text = "Databases"
        ShowWaitingBar()
        DisplayStatus("Searching for MS SQL Servers", StatusTypes.Find)
        RunServerWorker()
    End Sub

    Private Sub lbServers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbServers.SelectedIndexChanged
        Dim listControl As RadListElement = TryCast(sender, RadListElement)
        If Not listControl.SelectedItem Is Nothing Then
            SetUIEnabled(False)
            lbDatabases.Items.Clear()
            _dbInfoList = New List(Of DatabaseInfo)()
            Dim serverName As String = (TryCast(listControl.SelectedItem, RadListDataItem)).Text
            ShowProgressBar()
            DisplayStatus("Finding databases for " & serverName, StatusTypes.Find)
            RunDbWorker(serverName, tbMaxObjects.Value)
        End If
    End Sub

    Private Sub tbMaxObjects_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbMaxObjects.ValueChanged
        Dim trackBar As RadTrackBar = TryCast(sender, RadTrackBar)
        LoadDatabaseList(lbDatabases, trackBar.Value)
        lblCount.Text = trackBar.Value.ToString()
    End Sub

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbMaxObjects.Enabled = False
        ' panel should have rounded shape
        TryCast(pnlMaxObjects.RootElement.Children(0).Children(1), BorderPrimitive).Shape = New RoundRectShape()

        _waitingBarHostLabel = GetHostedWaitingBar("WaitingBarHostLabel")

        HideProgressBar()
    End Sub

    Private Sub lbDatabases_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles lbDatabases.SelectedIndexChanged
        If Not (TryCast(sender, RadListElement)).SelectedValue Is Nothing Then
            Dim info As DatabaseInfo = TryCast((TryCast(sender, RadListControl)).SelectedValue, DatabaseInfo)
            Dim message As String = String.Format("{0}\{1}{2}{3} objects", info.ServerNameProp, info.DatabaseNameProp, Environment.NewLine, info.ObjectCountProp)
            DisplayStatus(message, StatusTypes.Info)
        End If
    End Sub
End Class
