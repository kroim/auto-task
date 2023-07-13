Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private Sub tbContent_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbContent.SelectionChanged
        miBold.IsChecked = tbContent.SelectionFont.Bold
        miItalic.IsChecked = tbContent.SelectionFont.Italic
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

    Private Sub miAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miAbout.Click
        RadMessageBox.SetThemeName(Me.ThemeName)
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

    Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miQuit.Click
        Me.Close()
    End Sub

    Private Sub miBold_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles miBold.ToggleStateChanged
        If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style Or FontStyle.Bold)
        Else
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style And (Not FontStyle.Bold))
        End If
    End Sub

    Private Sub miItalic_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles miItalic.ToggleStateChanged
        If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style Or FontStyle.Italic)
        Else
            tbContent.SelectionFont = New Font(tbContent.SelectionFont, tbContent.SelectionFont.Style And (Not FontStyle.Italic))
        End If
    End Sub
End Class


