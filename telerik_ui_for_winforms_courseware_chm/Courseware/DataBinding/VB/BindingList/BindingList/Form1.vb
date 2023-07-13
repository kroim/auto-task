Imports Telerik.WinControls
Imports System.ComponentModel

Public Class Form1
    ' BindingList to contain list of MyObject
    Private _myObjects As BindingList(Of MyObject)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "Desert"

        ' instantiate _myObjects and assign to gridview datasource
        _myObjects = New BindingList(Of MyObject)()
        radGridView1.DataSource = _myObjects

        radGridView1.Columns(0).Width = 150
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        ' newly added MyObject shows up automatically in the grid
        _myObjects.Add(New MyObject())
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        ' updated MyObject TimeStamp property shows up automatically in the grid
        If Not radGridView1.CurrentRow Is Nothing Then
            Dim currentObject As MyObject = TryCast(radGridView1.CurrentRow.DataBoundItem, MyObject)
            currentObject.TimeStamp = DateTime.Now
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        ' deleted MyObject displays automatically in the grid
        If Not radGridView1.CurrentRow Is Nothing Then
            Dim currentObject As MyObject = TryCast(radGridView1.CurrentRow.DataBoundItem, MyObject)
            _myObjects.Remove(currentObject)
        End If
    End Sub

    ' MyObject implements INotifyPropertyChanged. 
    ' The object has a single property "TimeStamp". When
    ' TimeStamp is modified, PropertyChanged is fired
    Public Class MyObject
        Implements INotifyPropertyChanged
        Public Sub New()
            _timeStamp = DateTime.Now
        End Sub

        Private _timeStamp As DateTime
        Public Property TimeStamp() As DateTime
            Get
                Return _timeStamp
            End Get
            Set(ByVal value As DateTime)
                _timeStamp = value
                If Not PropertyChangedEvent Is Nothing Then
                    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("TimeStamp"))
                End If
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Class
