Imports Telerik.WinControls

Public Class RadForm1
    Public Sub New()
        InitializeComponent()

        ' setup initial delivery date
        dtDeliver.Value = Utils.AddBusinessDays(DateTime.Today, CInt(Fix(seDeliver.Value)))

        AddHandler seDeliver.ValueChanged, AddressOf seDeliver_ValueChanged

    End Sub

    Private Sub seDeliver_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        dtDeliver.Value = Utils.AddBusinessDays(DateTime.Today, Int(seDeliver.Value))
    End Sub


    ' When the "Gift Wrap" checkbox is unchecked,
    ' Disable the "Note" text box and disable it

    Private Sub cbGiftWrap_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbGiftWrap.ToggleStateChanged
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

