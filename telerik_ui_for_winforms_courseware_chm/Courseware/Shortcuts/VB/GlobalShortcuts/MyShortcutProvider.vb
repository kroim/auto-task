Imports Telerik.WinControls

Public Class MyShortcutProvider
    Implements IShortcutProvider
    Private shortcuts_Renamed As RadShortcutCollection
    Private registered As Boolean

    Public Sub New()
        Me.shortcuts_Renamed = New RadShortcutCollection(Me)
    End Sub

    Public Sub OnPartialShortcut(ByVal e As PartialShortcutEventArgs) Implements IShortcutProvider.OnPartialShortcut
        'This callback is called when a key that partially matches a registered shortcut is pressed
        'For example if we have CTRL + A, S pressing CTRL + A will execute this callback.
        'You will need to set the PartialShortcutEventArgs.Handled to true if you want to wait for the complete keyboard combination
        e.Handled = True
    End Sub

    Public Sub OnShortcut(ByVal e As ShortcutEventArgs) Implements IShortcutProvider.OnShortcut
        'A keyboard combination for a specific shortcut is pressed.
        MessageBox.Show("Shortcut [" & e.Shortcut.GetDisplayText() & "] is executed.")
        'Mark the event arguments as "Handled" so that this shortcut is no further processed.
        e.Handled = True
    End Sub

    Public Sub OnShortcutsChanged() Implements IShortcutProvider.OnShortcutsChanged
        'Called by the Shortcuts collection when a shortcut is either added or removed from the collection
        'This is used for optimization purposes - e.g. is we do not have shortcuts registered,
        'we do not need to be registered with RadShortcutManager
        If Me.shortcuts_Renamed.Count > 0 Then
            If (Not Me.registered) Then
                RadShortcutManager.Instance.AddShortcutProvider(Me)
                Me.registered = True
            End If
        Else
            If Me.registered Then
                RadShortcutManager.Instance.RemoveShortcutProvider(Me)
                Me.registered = False
            End If
        End If
    End Sub

    Public ReadOnly Property Shortcuts() As RadShortcutCollection Implements IShortcutProvider.Shortcuts
        Get
            Return Me.shortcuts_Renamed
        End Get
    End Property
End Class

