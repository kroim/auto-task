Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

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

        AddHandler tbNote.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler tbName.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler meState.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler meZip.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler tbCity.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler tbAddress.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler dtDeliver.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
        AddHandler seDeliver.ToolTipTextNeeded, AddressOf HandleToolTipNeeded
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

    Private Sub HandleToolTipNeeded(ByVal sender As Object, ByVal e As ToolTipTextNeededEventArgs)
        e.ToolTipText = "Please enter " & (TryCast(sender, RadItem)).ElementTree.Control.Tag.ToString()
    End Sub
End Class
