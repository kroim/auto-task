Imports Telerik.WinControls

Public Class Form1

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.RadButton1.ButtonElement.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.B))
        Me.RadRadioButton1.ButtonElement.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.R))
        Me.radSplitButton1.DropDownButtonElement.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.S))
        Me.RadToggleButton1.ButtonElement.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.T))

    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        RadMessageBox.Show("RadButton Clicked")
    End Sub

    Private Sub RadRadioButton1_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadRadioButton1.ToggleStateChanged
        RadMessageBox.Show("RadRadioButton Clicked")
    End Sub

    Private Sub RadToggleButton1_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadToggleButton1.ToggleStateChanged
        RadMessageBox.Show("RadToggleButton Clicked")
    End Sub

    Private Sub RadSplitButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSplitButton1.Click
        RadMessageBox.Show("RadSplitButton Clicked")
    End Sub
End Class
