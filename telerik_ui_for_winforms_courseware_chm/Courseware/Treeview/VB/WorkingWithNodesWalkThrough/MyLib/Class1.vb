Public Class [MyClass]

    Public Enum MyEnum
        Up
        Down
        Sideways
    End Enum

    Public Sub New()

    End Sub

    Public Sub New(ByVal myStringProperty As String)
        Me.MyStringProperty = myStringProperty
    End Sub

    Private _myStringProperty As String

    Public Property MyStringProperty() As String
        Get
            Return _myStringProperty
        End Get
        Set(ByVal value As String)
            _myStringProperty = Value
        End Set
    End Property

    Public Function Foo(ByVal message As String, ByVal count As Integer) As String
        Dim result As String = ""
        Dim i As Integer = 0
        Do While i < count
            result &= message
            i += 1
        Loop
        Return result
    End Function

    Private Sub Bar()

    End Sub

End Class