Imports System.ComponentModel

Public Class MyAppointment
    Implements INotifyPropertyChanged
    Private start_Renamed As DateTime = DateTime.Now
    Private end_renamed As DateTime = DateTime.Now
    Private subject_Renamed As String = String.Empty
    Private description_Renamed As String = String.Empty
    Private location_Renamed As String = String.Empty
    Private id_Renamed As Guid = Guid.NewGuid()

    Public Sub New()
    End Sub

    Public Sub New(ByVal start_Renamed As DateTime, ByVal end_renamed As DateTime, ByVal subject_Renamed As String, ByVal description_Renamed As String, ByVal location_Renamed As String)
        Me.start_Renamed = start_Renamed
        Me.end_renamed = end_renamed
        Me.subject_Renamed = subject_Renamed
        Me.description_Renamed = description_Renamed
        Me.location_Renamed = location_Renamed
    End Sub

    Public Property Id() As Guid
        Get
            Return Me.id_Renamed
        End Get
        Set(ByVal value As Guid)
            If Me.id_Renamed <> value Then
                Me.id_Renamed = value
                Me.OnPropertyChanged("Id")
            End If
        End Set
    End Property

    Public Property Start() As DateTime
        Get
            Return Me.start_Renamed
        End Get
        Set(ByVal value As DateTime)
            If Me.start_Renamed <> value Then
                Me.start_Renamed = value
                Me.OnPropertyChanged("Start")
            End If
        End Set
    End Property

    Public Property [End]() As DateTime
        Get
            Return Me.end_renamed
        End Get
        Set(ByVal value As DateTime)
            If Me.end_renamed <> value Then
                Me.end_renamed = value
                Me.OnPropertyChanged("End")
            End If
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return Me.subject_Renamed
        End Get
        Set(ByVal value As String)
            If Me.subject_Renamed <> value Then
                Me.subject_Renamed = value
                Me.OnPropertyChanged("Subject")
            End If
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Me.description_Renamed
        End Get
        Set(ByVal value As String)
            If Me.description_Renamed <> value Then
                Me.description_Renamed = value
                Me.OnPropertyChanged("Description")
            End If
        End Set
    End Property

    Public Property Location() As String
        Get
            Return Me.location_Renamed
        End Get
        Set(ByVal value As String)
            If Me.location_Renamed <> value Then
                Me.location_Renamed = value
                Me.OnPropertyChanged("Location")
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
        If Not Me.PropertyChangedEvent Is Nothing Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class