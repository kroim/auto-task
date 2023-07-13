Imports Telerik.WinControls

Public Class Form1
    Private provider As MyShortcutProvider

    Public Sub New()


        InitializeComponent()

        provider = New MyShortcutProvider()
        provider.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.A, Keys.S))

    End Sub
End Class
