Imports Telerik.WinControls

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadWizard1.WelcomeImageLayout = ImageLayout.Center
        AddHandler RadWizard1.SelectedPageChanged, AddressOf radWizard1_SelectedPageChanged
        AddHandler RadWizard1.Help, AddressOf radWizard1_Help
        AddHandler RadWizard1.Cancel, AddressOf radWizard1_Cancel
        AddHandler RadWizard1.Finish, AddressOf radWizard1_Finish

    End Sub

    Private Sub radWizard1_Finish(ByVal sender As Object, ByVal e As EventArgs)
        Application.[Exit]()
    End Sub

    Private Sub radWizard1_Help(ByVal sender As Object, ByVal e As EventArgs)
        Process.Start("http://www.telerik.com")
    End Sub

    Private Sub radWizard1_SelectedPageChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.SelectedPageChangedEventArgs)
        If e.SelectedPage.Equals(WizardPage3) Then
            RadWaitingBar1.StartWaiting()
        Else
            RadWaitingBar1.StopWaiting()
        End If
    End Sub

    Private Sub radWizard1_Cancel(ByVal sender As Object, ByVal e As EventArgs)
        If RadMessageBox.Show("Are you sure that you want to stop the installation?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.[Exit]()
        End If
    End Sub

End Class
