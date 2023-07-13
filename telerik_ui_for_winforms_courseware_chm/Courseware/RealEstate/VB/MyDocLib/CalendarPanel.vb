Imports System
Imports Telerik.WinControls.UI.Docking.RadDock

Namespace MyDockLib
    Partial Public Class CalendarPanel
        Inherits DockUserControls

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Delegate Sub DateChangedHandler(ByVal [date] As DateTime)
        Public Event DateChanged As DateChangedHandler
        Private Sub radCalendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateChanged <> Nothing Then
                DateChanged((TryCast(sender, Telerik.WinControls.UI.RadCalendar)).SelectedDate)
            End If
        End Sub
    End Class
End Namespace
