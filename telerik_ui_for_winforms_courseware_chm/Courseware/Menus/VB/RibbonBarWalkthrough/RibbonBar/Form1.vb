Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Public Class Form1
    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "RadRibbonBar"
        AddHandler radRibbonBar1.ExitButton.Click, AddressOf radRibbonBar1_ExitButton_Click
    End Sub

    Private Sub tbContent_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbContent.SelectionChanged
        cbBold.ToggleState = tbContent.SelectionFont.Bold
        cbItalic.ToggleState = tbContent.SelectionFont.Italic
    End Sub

    Private Sub miNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miNew.Click
        tbContent.Clear()
    End Sub

    Private Sub miOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpen.Click
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            tbContent.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSave.Click
        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            tbContent.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub miAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles qaHelp.Click
        RadMessageBox.SetThemeName("Office2007Black")
        RadMessageBox.Show(" By " & Environment.UserName & ", " & DateTime.Today.ToLongDateString(), "About RadMenu Demo")
    End Sub

    Private Sub miCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCut.Click
        tbContent.Cut()
    End Sub

    Private Sub miCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCopy.Click
        tbContent.Copy()
    End Sub

    Private Sub miPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miPaste.Click
        tbContent.Paste()
    End Sub

    Private Sub radRibbonBar1_ExitButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cbBold_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles cbBold.ToggleStateChanged
        If args.ToggleState = ToggleState.On Then
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style Or FontStyle.Bold)
        Else
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style And (Not FontStyle.Bold))
        End If
    End Sub

    Private Sub cbItalic_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles cbItalic.ToggleStateChanged
        If args.ToggleState = ToggleState.On Then
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style Or FontStyle.Italic)
        Else
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style And (Not FontStyle.Italic))
        End If
    End Sub
End Class
