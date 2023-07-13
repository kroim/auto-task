Public Class Contact
    Dim _first As String
    Dim _last As String
    Dim _email As String

    Public Sub New(ByVal first As String, ByVal last As String, ByVal email As String)
        Me._first = first
        Me._last = last
        Me._email = email
    End Sub

    Public Property First() As String
        Get
            Return _first

        End Get
        Set(ByVal value As String)
            _first = value
        End Set
    End Property

    Public Property Last() As String
        Get
            Return _last

        End Get
        Set(ByVal value As String)
            _last = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email

        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property


End Class
