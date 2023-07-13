'#region fileSystemItem
Public Class FileSystemItem
    Private id_Renamed As Integer
    Private name_Renamed As String
    Private creationTime_Renamed As Date
    Private parentFolderId_Renamed As Integer

    Private type As String

    Public Property Id() As Integer
        Get
            Return id_Renamed
        End Get
        Set(ByVal value As Integer)
            id_Renamed = value
        End Set
    End Property

    Public Property FileSystemInfoType() As String
        Get
            Return type
        End Get
        Set(ByVal value As String)
            type = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return name_Renamed
        End Get
        Set(ByVal value As String)
            name_Renamed = value
        End Set
    End Property

    Public Property CreationTime() As Date
        Get
            Return creationTime_Renamed
        End Get
        Set(ByVal value As Date)
            creationTime_Renamed = value
        End Set
    End Property

    Public Property ParentFolderId() As Integer
        Get
            Return parentFolderId_Renamed
        End Get
        Set(ByVal value As Integer)
            parentFolderId_Renamed = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal type As String, ByVal name As String, ByVal creationTime As Date, ByVal parentFolderId As Integer)
        Me.id_Renamed = id
        Me.type = type
        Me.name_Renamed = name
        Me.creationTime_Renamed = creationTime
        Me.parentFolderId_Renamed = parentFolderId
    End Sub
End Class
'#endregion