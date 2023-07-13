Public Class RadForm1
    Public Sub New()
        InitializeComponent()

        Dim myDog As New Dog()
        myDog.Name = "Lassie"
        myDog.Age = 4
        myDog.Birthday = New DateTime(2007, 5, 4)
        myDog.Gender = "Male"
        myDog.Homeless = False
        myDog.Weight = 21

        RadPropertyGrid1.SelectedObject = myDog

    End Sub
End Class

Public Class Dog
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String
    Public Property Age() As Integer
        Get
            Return m_Age
        End Get
        Set(ByVal value As Integer)
            m_Age = Value
        End Set
    End Property
    Private m_Age As Integer
    Public Property Weight() As Double
        Get
            Return m_Weight
        End Get
        Set(ByVal value As Double)
            m_Weight = Value
        End Set
    End Property
    Private m_Weight As Double
    Public Property Gender() As String
        Get
            Return m_Gender
        End Get
        Set(ByVal value As String)
            m_Gender = Value
        End Set
    End Property
    Private m_Gender As String
    Public Property Homeless() As Boolean
        Get
            Return m_Homeless
        End Get
        Set(ByVal value As Boolean)
            m_Homeless = Value
        End Set
    End Property
    Private m_Homeless As Boolean
    Public Property Birthday() As DateTime
        Get
            Return m_Birthday
        End Get
        Set(ByVal value As DateTime)
            m_Birthday = Value
        End Set
    End Property
    Private m_Birthday As DateTime
    Private Property OwnerName() As String
        Get
            Return m_OwnerName
        End Get
        Set(ByVal value As String)
            m_OwnerName = Value
        End Set
    End Property
    Private m_OwnerName As String
End Class
