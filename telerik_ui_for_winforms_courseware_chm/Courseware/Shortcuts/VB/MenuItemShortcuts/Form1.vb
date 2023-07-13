Imports Telerik.WinControls

Public Class Form1

    Public Sub New()
        InitializeComponent()

        Me.RadMenuItem1.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.N))
        Me.RadMenuItem2.Shortcuts.Add(New RadShortcut(Keys.Shift, Keys.F, Keys.K))

    End Sub

    Private Sub RadMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem1.Click
        RadMessageBox.Show("New")
    End Sub

    Private Sub RadMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem2.Click
        RadMessageBox.Show("File")
    End Sub
End Class
