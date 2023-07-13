Imports System.ComponentModel

Public Class Product
    Implements INotifyPropertyChanged
    Public Sub New()

    End Sub

    Public Sub New(ByVal id_Renamed As Integer, ByVal description_Renamed As String)
        Me.id_Renamed = id_Renamed
        Me.description_Renamed = description_Renamed
    End Sub

    Private id_Renamed As Integer
    Public Property ID() As Integer
        Get
            Return Me.id_Renamed
        End Get
        Set(ByVal value As Integer)
            Me.id_Renamed = value
            NotifyPropertyChanged("ID")
        End Set
    End Property

    Private description_Renamed As String
    Public Property Description() As String
        Get
            Return Me.description_Renamed
        End Get
        Set(ByVal value As String)
            Me.description_Renamed = value
            NotifyPropertyChanged("Description")
        End Set
    End Property

#Region "INotifyPropertyChanged Members"

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)

        OnPropertyChanged(New PropertyChangedEventArgs(info))

    End Sub

    Protected Overridable Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
        If Not PropertyChangedEvent Is Nothing Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(e.PropertyName))
        End If
    End Sub

#End Region
End Class