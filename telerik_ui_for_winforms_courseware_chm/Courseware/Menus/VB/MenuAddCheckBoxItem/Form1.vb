Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1
    Public Sub New()

        InitializeComponent()

        Dim checkBoxItem As New CustomCheckMenuItem()
        checkBoxItem.Text = "Check Box"
        AddHandler checkBoxItem.ToggleStateChanged, AddressOf checkBoxItem_ToggleStateChanged
        RadMenuItem1.Items.Add(checkBoxItem)

    End Sub

    Private Sub checkBoxItem_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
        RadMessageBox.Show("Check box state has changed to " + args.ToggleState.ToString())
    End Sub

End Class

Public Class CustomCheckMenuItem
    Inherits RadMenuItemBase

    Private checkBoxElement As RadCheckBoxElement

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        checkBoxElement = New RadCheckBoxElement()
        checkBoxElement.Padding = New Padding(20, 0, 0, 0)
        checkBoxElement.CheckMarkPrimitive.Margin = New Padding(0, 0, 5, 0)
        Me.Children.Add(checkBoxElement)
    End Sub

    Public Overrides Property Text() As String
        Get
            Return checkBoxElement.Text
        End Get
        Set(ByVal value As String)
            checkBoxElement.Text = value
        End Set
    End Property

    Public Custom Event ToggleStateChanged As StateChangedEventHandler
        AddHandler(ByVal value As StateChangedEventHandler)
            AddHandler checkBoxElement.ToggleStateChanged, value
        End AddHandler
        RemoveHandler(ByVal value As StateChangedEventHandler)
            RemoveHandler checkBoxElement.ToggleStateChanged, value
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal e As StateChangedEventArgs)

        End RaiseEvent
    End Event

End Class