Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1
    Private Sub btnRadForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRadForm.Click
        Dim radForm1 As RadForm1 = New RadForm1()
        AddHandler radForm1.Activated, AddressOf formActivated
        radForm1.Show()
    End Sub

    Private Sub btnShapedForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShapedForm.Click
        Dim shapedForm1 As ShapedForm1 = New ShapedForm1()
        Dim shape As RoundRectShape = New RoundRectShape()
        shape.Radius = 20
        shapedForm1.Shape = shape
        AddHandler shapedForm1.Activated, AddressOf formActivated
        shapedForm1.Show()
    End Sub

    Private Sub btnRadRibbonForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRadRibbonBar.Click
        Dim radRibbonForm1 As RadRibbonForm1 = New RadRibbonForm1()
        AddHandler radRibbonForm1.Activated, AddressOf formActivated
        radRibbonForm1.Show()
    End Sub

    Private Sub btnRadAboutBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRadAboutBox.Click
        Dim radAboutBox1 As RadAboutBox1 = New RadAboutBox1()
        AddHandler radAboutBox1.Activated, AddressOf formActivated
        radAboutBox1.Show()
    End Sub

    Private Sub formActivated(ByVal sender As Object, ByVal e As EventArgs)
        lblStatus.Text = "The " & (TryCast(sender, Control)).Name & " form is active"
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "Office2007Silver"
    End Sub

    Private Sub btnRadMessageBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMessageBox.Click

        RadMessageLocalizationProvider.CurrentProvider = New MyMessageLocalizationProvider()

        Dim result As DialogResult = RadMessageBox.Show("Go online to register?", "Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ' do something...
        End If
    End Sub

    Public Class MyMessageLocalizationProvider
        Inherits RadMessageLocalizationProvider
        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case RadMessageStringID.AbortButton
                    Return "Hold it!"
                Case RadMessageStringID.CancelButton
                    Return "Lets not"
                Case RadMessageStringID.IgnoreButton
                    Return "Forget it"
                Case RadMessageStringID.NoButton
                    Return "Nope"
                Case RadMessageStringID.OKButton
                    Return "Allright"
                Case RadMessageStringID.RetryButton
                    Return "Again Please"
                Case RadMessageStringID.YesButton
                    Return "Yup"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
End Class
