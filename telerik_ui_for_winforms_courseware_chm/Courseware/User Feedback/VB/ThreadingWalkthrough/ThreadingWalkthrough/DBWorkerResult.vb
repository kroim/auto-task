Public Class DBWorkerResult
    Dim maxItems As Integer
    Dim minItems As Integer
    Dim serverName As String

    Public Sub New(ByVal serverName As String, ByVal maxItems As Integer, ByVal minItems As Integer)
        Me.ServerName = serverName
        Me.MaxItems = maxItems
        Me.MinItems = minItems
    End Sub

    Public Property ServerNameProp() As String
        Get
            Return serverName
        End Get
        Set(ByVal value As String)
            serverName = value
        End Set
    End Property

    Public Property MaxItemsProp() As Integer
        Get
            Return maxItems
        End Get
        Set(ByVal value As Integer)
            maxItems = value
        End Set
    End Property

    Public Property MinItemsProp() As Integer
        Get
            Return minItems
        End Get
        Set(ByVal value As Integer)
            minItems = value
        End Set
    End Property
End Class


