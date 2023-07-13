Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' setup initial delivery date
        dtDeliver.Value = Utils.AddBusinessDays(DateTime.Today, CInt(Fix(seDeliver.Value)))

        ' configure color dialog
        Dim dialog As RadColorDialogForm = radColorDialog1.ColorDialogForm
        dialog.ShowBasicColors = False
        dialog.ShowCustomColors = False
        dialog.ShowProfessionalColors = False
        dialog.ShowHEXColorValue = False
        dialog.ShowCustomColors = False
        dialog.AllowColorPickFromScreen = False
        dialog.WebTabHeading = "Named Colors"
        dialog.ActiveMode = ColorPickerActiveMode.Web
    End Sub

    ' When the "Gift Wrap" checkbox is unchecked,
    ' Disable the "Note" text box and disable it
    Private Sub cbGiftWrap_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbGiftWrap.ToggleStateChanged
        tbNote.Enabled = args.ToggleState = Enumerations.ToggleState.On
        btnChooseColor.Enabled = args.ToggleState = Enumerations.ToggleState.On
        If args.ToggleState <> Enumerations.ToggleState.On Then
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

    ' Based on the spin edit value, add business days to the date time picker.    
    Private Sub seDeliver_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seDeliver.ValueChanged
        dtDeliver.Value = Utils.AddBusinessDays(DateTime.Today, CInt(Fix(seDeliver.Value)))
    End Sub

    Private Sub btnChooseColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChooseColor.Click
        ' get the fill and text primitives for the button
        Dim fillPrimitive As FillPrimitive = TryCast(btnChooseColor.RootElement.Children(0).Children(0), FillPrimitive)
        Dim textPrimitive As TextPrimitive = TryCast(btnChooseColor.RootElement.Children(0).Children(1).Children(1), TextPrimitive)

        ' retrieve the current button color
        radColorDialog1.ColorDialogForm.OldColor = fillPrimitive.BackColor
        radColorDialog1.ColorDialogForm.SelectedColor = fillPrimitive.BackColor

        ' retrieve the user selected color and calculate a contrasting color,
        ' then set the BackColor properties to succesively more transparent 
        ' shades of the primary color and set the text to the contrasting color.
        If radColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim color As Color = radColorDialog1.SelectedColor
            textPrimitive.ForeColor = Utils.GetContrastingColor(color)
            fillPrimitive.BackColor = color
            fillPrimitive.BackColor2 = color.FromArgb(200, color)
            fillPrimitive.BackColor3 = color.FromArgb(100, color)
            fillPrimitive.BackColor4 = color.FromArgb(50, color)
        End If
    End Sub
End Class
