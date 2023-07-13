Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' set multiple lines of text using several different approaches
        tbMultiLine.Lines = New String(2) {"It was the best of times,", "it was the worst of times,", "it was the age of wisdom..."}

        tbMultiLine.Text = "It was the best of times," & Environment.NewLine & "it was the worst of times," & Environment.NewLine & "it was the age of wisdom..."

        tbMultiLine.Text = "It was the best of times," & Constants.vbCrLf & "it was the worst of times," & Constants.vbCrLf & "it was the age of wisdom..."

        ' traverse the element tree and locate the text box border. Makes the border invisible.
        TryCast(tbMultiLine.TextBoxElement.Children(2), BorderPrimitive).Visibility = ElementVisibility.Collapsed

        ' setup an auto complete source for a RadTextBox
        tbContainer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim containers As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        containers.Add("Box")
        containers.Add("Bundle")
        containers.Add("Pallet")
        containers.Add("Carton")
        tbContainer.AutoCompleteCustomSource = containers
        ' allow the auto completions to be shown in a list and automaticaly appened 
        ' during typing
        tbContainer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        ' display a message when there is no entry
        tbContainer.Text = String.Empty
        tbContainer.NullText = "Enter a container name"

        ' load a RadComboBox with MaskType enum memembers
        For Each maskType As MaskType In System.Enum.GetValues(GetType(MaskType))
            cbMaskType.Items.Add(New RadListDataItem(maskType.ToString(), maskType))
        Next maskType

        ' load an assortment of masks to a RadComboBox
        Dim masks As String() = New String() {"#", "L", "a", "c", "d", "f", "p", "D", "F", "g", "G", "m", "r", "s", "t", "T"}
        For Each mask As String In masks
            cbMasks.Items.Add(New RadListDataItem(mask, mask))
        Next mask

        ' set the initial combo box item selected 
        cbMasks.SelectedIndex = 0
        cbMaskType.SelectedIndex = 0

        ' set the initial date time picker value and bounds
        radDateTimePicker1.MinDate = DateTime.Today.AddDays(-1)
        radDateTimePicker1.MaxDate = DateTime.Today.AddDays(7)
        radDateTimePicker1.Value = DateTime.Today

        ' hook up a ToggleStateChanged event handler to a date time picker checkbox

        Dim checkBox As RadCheckBoxElement = TryCast(radDateTimePicker1.DateTimePickerElement.Children(1).Children(0), RadCheckBoxElement)
        AddHandler checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

        ' apply a custom format to a date time picker
        radDateTimePicker1.Format = DateTimePickerFormat.Custom
        radDateTimePicker1.CustomFormat = "yyyy MMMM dd h:m:s tt"



    End Sub

    Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
        RadMessageBox.Show(args.ToggleState.ToString())
    End Sub

    Private Sub tbContainer_TextChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.TextChangingEventArgs) Handles tbContainer.TextChanging
        btnUseContainer.Enabled = e.NewValue.Length > 0
    End Sub

    Private Sub tbContainer_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbContainer.TextChanged
        btnUseContainer.Text = "Use " & (TryCast(sender, RadTextBox)).Text & " container"
    End Sub

    Private Sub meDemo_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles meDemo.ValueChanged
        lblValue.Text = Me.meDemo.Value.ToString()
    End Sub

    Private Sub cbMaskType_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMaskType.SelectedValueChanged
        meDemo.MaskType = CType((TryCast(sender, RadDropDownList)).SelectedValue, MaskType)
    End Sub

    Private Sub cbMasks_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMasks.SelectedValueChanged
        meDemo.Mask = (TryCast(sender, RadDropDownList)).SelectedText
    End Sub

    Private Sub btnAddMask_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddMask.Click
        ' if the current text in the combo box is not already
        ' in the list, add it.
        'If (Not cbMasks.Items.Any(ri >= ri.Text.Equals(cbMasks.Text))) Then
        '    cbMasks.Items.Add(New RadComboBoxItem(cbMasks.Text))
        'End If
    End Sub

    Private Sub btnChangeColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChangeColor.Click
        ' set the color dialog initial color to the panel background color, 
        ' show the color dialog and if the user selects a color, 
        ' assign it to the panel.
        radColorDialog1.SelectedColor = pnlColor.BackColor
        If radColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pnlColor.BackColor = radColorDialog1.SelectedColor
        End If
    End Sub

    Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
        lblSpin.Text = radSpinEditor1.Value.ToString()
        radProgressBar1.Value1 = CInt(Fix(radSpinEditor1.Value))
    End Sub

    Private Sub radSpinEditor1_ValueChanging(ByVal sender As Object, ByVal e As ValueChangingEventArgs) Handles radSpinEditor1.ValueChanging
        e.Cancel = Convert.ToDecimal(e.NewValue) > Convert.ToDecimal(e.OldValue) * 2
    End Sub
End Class
