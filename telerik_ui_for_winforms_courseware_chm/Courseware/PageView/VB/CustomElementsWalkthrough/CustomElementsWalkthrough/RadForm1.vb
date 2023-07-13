Imports Telerik.WinControls.UI
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations


Public Class RadForm1

    Public Sub New()
        InitializeComponent()
        LoadPageView()
    End Sub

#Region "helper methods"

    ' Create and configure a single RadPageViewPage and populate the
    ' tag with the DriveInfo passed
    Private Function GetDrivePageItem(ByVal driveInfo As DriveInfo) As RadPageViewPage
        Dim page As New RadPageViewPage()
        page.TextImageRelation = TextImageRelation.ImageBeforeText
        page.TextAlignment = ContentAlignment.TopCenter
        page.ImageAlignment = ContentAlignment.TopLeft
        page.Tag = driveInfo
        Return page
    End Function

    ' Create, configure and populate a RadListControl with files from the
    ' drive root.
    Private Function GetListControl(ByVal drive As String) As RadListControl
        Dim listControl As New RadListControl()
        listControl.Dock = DockStyle.Fill
        listControl.ThemeName = "Desert"

        Dim directories As String() = Directory.GetDirectories(drive.ToString())
        For Each directory As String In directories
            listControl.Items.Add(New RadListDataItem(directory))
        Next

        Return listControl
    End Function

    ' Get the percent of used space on a drive
    Private Function GetUsedPercent(ByVal driveInfo As DriveInfo) As Integer
        Return CInt(Math.Truncate((CDbl(driveInfo.TotalSize) - CDbl(driveInfo.AvailableFreeSpace)) / CDbl(driveInfo.TotalSize) * 100))
    End Function

#End Region

#Region "private methods"

    Private Sub LoadPageView()
        For Each drive As String In Environment.GetLogicalDrives()
            Dim driveInfo As New DriveInfo(drive)

            AddHandler radPageView1.ItemCreating, AddressOf radPageView1_ItemCreating

            Dim page As RadPageViewPage = GetDrivePageItem(driveInfo)
            radPageView1.Pages.Add(page)

            Dim progressBar As RadProgressBarElement = DirectCast(page.Item, RadPageViewProgressBarItem).ProgressBar

            If driveInfo.IsReady Then
                page.Text = driveInfo.Name + Environment.NewLine + driveInfo.VolumeLabel
                page.Image = ilDriveTypes.Images(CInt(driveInfo.DriveType))

                progressBar.Value1 = GetUsedPercent(driveInfo)
                page.Controls.Add(GetListControl(drive))
            Else
                page.Text = drive + Environment.NewLine & " is not ready"
                page.Image = ilDriveTypes.Images("DisconnectedDrive.png")

                progressBar.Visibility = ElementVisibility.Hidden
            End If
        Next
    End Sub

#End Region

#Region "event handlers"
    'Replace the default page item with the custom one that contains RadProgressBarElement
    Private Sub radPageView1_ItemCreating(ByVal sender As Object, ByVal e As RadPageViewItemCreatingEventArgs)
        e.Item = New RadPageViewProgressBarItem()
    End Sub

    Private Sub radPageView1_SelectedPageChanging(ByVal sender As Object, ByVal e As RadPageViewCancelEventArgs) Handles radPageView1.SelectedPageChanging
        'Fill the labels with data
        If e.Page.Tag IsNot Nothing Then
            Dim driveInfo As DriveInfo = DirectCast(e.Page.Tag, DriveInfo)
            If driveInfo.IsReady Then
                lblDriveName.Text = driveInfo.Name
                lblVolumeLabel.Text = If(driveInfo.VolumeLabel.Equals([String].Empty), "No Volume Label", driveInfo.VolumeLabel)
                lblDriveFormat.Text = driveInfo.DriveFormat
                lblDriveType.Text = driveInfo.DriveType.ToString()
                lblTotalSpace.Text = driveInfo.TotalSize.ToString("n0")
            End If
        End If

        'Show message box for the drives that are not ready
        If e.Page Is Nothing Then
            Return
        End If
        If Not TryCast(e.Page.Tag, DriveInfo).IsReady Then
            Dim tabItem As RadPageViewItem = TryCast(e.Page.Item, RadPageViewItem)
            RadMessageBox.SetThemeName(Me.ThemeName)
            Dim message As [String] = [String].Format("{0}", tabItem.Text)
            RadMessageBox.Show(message, "Drive Unavailable", MessageBoxButtons.OK, RadMessageIcon.[Error])
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim selectedPage As RadPageViewPage = Nothing

        For Each page As RadPageViewPage In radPageView1.Pages
            ' no drive info, skip
            If page.Tag Is Nothing Then
                Continue For
            End If

            ' save first available tab with drive info
            If selectedPage Is Nothing Then
                selectedPage = page
            End If

            ' drive isn't ready, skip
            If Not TryCast(page.Tag, DriveInfo).IsReady Then
                Continue For
            End If

            ' save tab with greatest free space
            selectedPage = If(TryCast(selectedPage.Tag, DriveInfo).TotalFreeSpace > TryCast(page.Tag, DriveInfo).TotalFreeSpace, selectedPage, page)
        Next
        ' select tab with greatest free space
        radPageView1.SelectedPage = selectedPage
    End Sub

    ' Iterate the tabs DriveInfo and collapse any that aren't ready
    Private Sub btnShow_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles btnShow.ToggleStateChanged
        For Each page As RadPageViewPage In radPageView1.Pages
            If Not TryCast(page.Tag, DriveInfo).IsReady Then
                page.Item.Visibility = If(args.ToggleState = ToggleState.[On], ElementVisibility.Visible, ElementVisibility.Collapsed)
            End If
        Next
    End Sub
#End Region

End Class

'Create custom page item
Class RadPageViewProgressBarItem
    Inherits RadPageViewStripItem
    Private m_progressBar As RadProgressBarElement

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        ' Create and configure a RadProgressBarElement.
        ' Hook up a click event to pass through clicks made
        ' to the progress to the page item underneath
        m_progressBar = New RadProgressBarElement()
        m_progressBar.Margin = New Padding(5, 40, 5, 5)
        m_progressBar.Padding = New Padding(5)
        m_progressBar.MinSize = New Size(80, 20)
        m_progressBar.MaxSize = New Size(80, 20)
        AddHandler m_progressBar.Click, AddressOf TextElement_Click
        m_progressBar.TextElement.NotifyParentOnMouseInput = True
        m_progressBar.ShowProgressIndicators = True
        Me.Children.Add(m_progressBar)
    End Sub
    'expose the progressbar in order to access it directly from the page item
    Public ReadOnly Property ProgressBar() As RadProgressBarElement
        Get
            Return Me.m_progressBar
        End Get
    End Property

    'select the corresponding page when the progress bar is clicked
    Private Sub TextElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        DirectCast(Me.Owner.ElementTree.Control, RadPageView).SelectedPage = Me.Page
    End Sub

    'arrange the item children
    Protected Overrides Sub ArrangeChildren(ByVal available As SizeF)
        m_progressBar.Arrange(New RectangleF(PointF.Empty, available))
        MyBase.ArrangeChildren(available)
    End Sub

    'make the item themeable 
    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(RadPageViewStripItem)
        End Get
    End Property
End Class
