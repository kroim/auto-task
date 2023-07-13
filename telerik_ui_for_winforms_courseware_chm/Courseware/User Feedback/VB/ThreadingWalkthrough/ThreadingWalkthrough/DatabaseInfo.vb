Public Class DatabaseInfo
    Dim serverName As String
    Dim databaseName As String
    Dim objectCount As Integer


    Public Sub New(ByVal serverName As String, ByVal databaseName As String, ByVal objectCount As Integer)
        Me.ServerName = serverName
        Me.DatabaseName = databaseName
        Me.ObjectCount = objectCount
    End Sub

    Public Property ServerNameProp() As String
        Get
            Return serverName
        End Get
        Set(ByVal value As String)
            serverName = value
        End Set
    End Property

    Public Property DatabaseNameProp() As String
        Get
            Return databaseName
        End Get
        Set(ByVal value As String)
            databaseName = value
        End Set
    End Property

    Public Property ObjectCountProp() As Integer
        Get
            Return objectCount
        End Get
        Set(ByVal value As Integer)
            objectCount = value
        End Set
    End Property
End Class
