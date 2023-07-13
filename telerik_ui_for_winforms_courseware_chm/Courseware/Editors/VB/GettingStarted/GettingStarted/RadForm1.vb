Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ThemeName = "Office2007Silver"
        SetTheme(Me.Controls)
    End Sub

    ' cycle through the controls collection recursively and set the 
    ' theme for all rad controls
    Private Sub SetTheme(ByVal controls As Control.ControlCollection)
        For Each control As Control In controls
            If TypeOf control Is RadControl Then
                TryCast(control, RadControl).ThemeName = Me.ThemeName
            End If

            If control.Controls.Count > 0 Then
                SetTheme(control.Controls)
            End If
        Next control
    End Sub

    ' When the "Gift Wrap" checkbox is unchecked,
    ' Disable the "Note" text box and disable it
    Private Sub cbGiftWrap_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
        tbNote.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        btnChooseColor.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        If args.ToggleState <> Telerik.WinControls.Enumerations.ToggleState.On Then
            tbNote.Text = String.Empty
        End If
    End Sub

    Private Sub btnPlaceOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPlaceOrder.Click
        If ValidateControls(Me.Controls) Then
            Dim caption As String = "Order Summary"
            Dim message As String = "Thank you for your order" & Environment.NewLine & GetFormData(Me.Controls)
            RadMessageBox.Show(message, caption, MessageBoxButtons.OK)
        End If
    End Sub

    Private Function ValidateControls(ByVal controls As Control.ControlCollection) As Boolean
        Return True
    End Function

    Private Function GetFormData(ByVal controls As Control.ControlCollection) As String
        Return Environment.NewLine & "...summary"
    End Function
End Class
