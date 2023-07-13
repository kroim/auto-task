Imports Telerik.WinControls.UI
Imports System.IO

Public Class RadForm1

    Public Sub New()

        InitializeComponent()

        lblDriveName.Text = radPageView1.SelectedPage.Text

        RadPageViewPage1.Image = ilDriveTypes.Images("Hard_Drive.png")
        RadPageViewPage2.Image = ilDriveTypes.Images("CD_ROM.png")
        RadPageViewPage3.Image = ilDriveTypes.Images("Network.png")

    End Sub

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get a list of directories for the C:\ drive.
        ' Iterate the list and add RadListBoxItems to the list.
        ' Finally, select the first tab so that the file list will 
        ' be visible.
        Dim directories As String() = Directory.GetDirectories("C:\")
        For Each directory As String In directories
            lbFiles.Items.Add(New RadListDataItem(directory))
        Next directory
    End Sub

    Private Sub radPageView1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPageView1.SelectedPageChanged
        lblDriveName.Text = radPageView1.SelectedPage.Text
    End Sub
End Class
