Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports System.ComponentModel

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

    ' iterate the controls and verify the text entry has data
    ' and the date time picker has a week day selected.
    Private Function ValidateControls(ByVal controls As Control.ControlCollection) As Boolean
        Dim isValid As Boolean = True
        For Each control As Control In controls
            ' clear old errors
            errorProvider1.SetError(control, "")

            If IsEditorControl(control) Then

                Dim value As Object = GetControlValue(TryCast(control, RadControl))
                If (TypeOf value Is DateTime) AndAlso (Utils.IsWeekend(CDate(value))) Then
                    errorProvider1.SetError(control, "Please enter a weekday date to " & control.Tag.ToString())
                    isValid = False
                ElseIf value.ToString().Equals(String.Empty) Then
                    errorProvider1.SetError(control, "Please enter " & control.Tag.ToString())
                    isValid = False
                End If
            End If

            ' recurse into child controls of this control
            ' so that we get items on the group panels.
            If control.Controls.Count > 0 Then
                If (Not ValidateControls(control.Controls)) Then
                    isValid = False
                End If
            End If
        Next control
        Return isValid
    End Function

    ' retrieve the editor controls,
    ' get their values, build and return a summary string.
    Private Function GetFormData(ByVal controls As Control.ControlCollection) As String
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder()
        For Each control As Control In controls
            If IsEditorControl(control) Then
                Dim value As Object = GetControlValue(TryCast(control, RadControl))

                If (Not value Is Nothing) AndAlso ((Not value.ToString().Equals(String.Empty))) Then
                    builder.Append(Environment.NewLine)
                    builder.Append(control.Tag.ToString())
                    builder.Append(": ")
                    builder.Append(value)
                End If
            End If

            If control.Controls.Count > 0 Then
                builder.Append(GetFormData(control.Controls))
            End If
        Next control
        Return builder.ToString()
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

    ' True if given control is enabled,
    ' is on a group box and is a textbox base,
    ' date time picker or radbutton.
    Private Function IsEditorControl(ByVal control As Control) As Boolean
        If (Not control.Enabled) Then
            Return False
        End If

        ' only get input from controls within a groupbox
        If Not (TypeOf control.Parent Is GroupBox) Then
            Return False
        End If

        Return TypeOf control Is RadTextBoxBase OrElse TypeOf control Is RadDateTimePicker OrElse TypeOf control Is RadButton
    End Function

    ' return the appropriate vaue property for the RadControl
    Private Function GetControlValue(ByVal control As RadControl) As Object
        Dim value As Object = Nothing

        If TypeOf control Is RadTextBox Then
            value = (TryCast(control, RadTextBox)).Text
        ElseIf TypeOf control Is RadMaskedEditBox Then
            value = (TryCast(control, RadMaskedEditBox)).Value.ToString()
        ElseIf TypeOf control Is RadDateTimePicker Then
            value = (TryCast(control, RadDateTimePicker)).Value
        ElseIf TypeOf control Is RadCheckBox Then
            value = (TryCast(control, RadCheckBox)).Checked.ToString()
        ElseIf TypeOf control Is RadButton Then
            Dim buttonPrimitive As FillPrimitive = TryCast((TryCast(control, RadButton)).RootElement.Children(0).Children(0), FillPrimitive)
            value = Utils.GetKnownColorName(buttonPrimitive.BackColor)
        End If
        Return value
    End Function

    Private Sub dtDeliver_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles dtDeliver.Validating
        Dim [error] As String = Nothing
        If Utils.IsWeekend((TryCast(sender, RadDateTimePicker)).Value) Then
            [error] = "Please enter a weekday date for " & (TryCast(sender, Control)).Tag.ToString()
        End If
        errorProvider1.SetError(CType(sender, Control), [error])
    End Sub

    Private Sub RadForm1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        If (Not ValidateControls(Me.Controls)) Then
            RadMessageBox.SetThemeName("Office2007Silver")
            Dim result As DialogResult = RadMessageBox.Show("Please correct errors or press Cancel to close the window.", "Input errors", MessageBoxButtons.OKCancel, RadMessageIcon.Error)
            ' Cancel == true prevents the form from closing
            e.Cancel = result = System.Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class
