Imports System.Data.OleDb
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)
        radTreeView1.DataSource = Me.musicCollectionDataSet.Albums
        radTreeView1.DisplayMember = "AlbumName"
        radTreeView1.ValueMember = "AlbumID"

        DataSourceAssignments()
    End Sub

    Private Sub DataSourceAssignments()
        Dim products As List(Of Product) = New List(Of Product)()
        products.Add(New Product(1, "Jute Heather Cardigan"))
        products.Add(New Product(2, "Retro Cardigan"))
        products.Add(New Product(3, "Cashmere Cardigan"))
        radListControl1.DataSource = products
        radListControl1.DisplayMember = "Description"
        radListControl1.ValueMember = "ID"

        Dim myArray As String() = {"one", "two", "three"}
        radListControl1.DataSource = myArray

        Dim list As List(Of String) = New List(Of String)()
        list.Add("one")
        list.Add("two")
        list.Add("three")
        radListControl1.DataSource = list

        ' bind to a DataTable or DataTable descendant. You may need to change your MusicConnection string
        Dim connection As OleDbConnection = New OleDbConnection(My.MySettings.Default.MusicCollectionConnectionString)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("select AlbumID, AlbumName from Albums", connection)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        radListControl1.DataSource = table
        radListControl1.DisplayMember = "AlbumName"
        radListControl1.ValueMember = "AlbumID"

        ' bind to a DataView. You may need to change your MusicConnection string
        Dim dataView As DataView = New DataView(table, "AlbumName LIKE 'B%'", "", DataViewRowState.CurrentRows)
        radListControl1.DataSource = dataView
        radListControl1.DisplayMember = "AlbumName"
        radListControl1.ValueMember = "AlbumID"

        ' create an xml file with the albums 
        table.TableName = "Albums"
        table.WriteXml("c:\Albums.xml", XmlWriteMode.WriteSchema)

        ' read xml into a table and set as datasource
        Dim table2 As DataTable = New DataTable()
        table2.ReadXml("c:\Albums.xml")
        radListControl1.DataSource = table2
        radListControl1.DisplayMember = "AlbumName"
        radListControl1.ValueMember = "AlbumID"

        radTextBox1.DataBindings.Add("Text", table, "AlbumName")
        radTextBox1.DataBindings.Add("Tag", table, "AlbumID")

        AddHandler radListControl1.SelectedIndexChanged, AddressOf radListControl1_SelectedIndexChanged
    End Sub

    Private Sub radListControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        Dim item As RadListDataItem = TryCast((TryCast(sender, RadListElement)).SelectedItem, RadListDataItem)
        RadMessageBox.SetThemeName("Desert")
        RadMessageBox.Show(String.Format("Text: {0}  Value: {1}", item.Text, item.Value))
    End Sub

    Public Class Product
        Dim _id As Integer
        Dim _description As String

        Public Sub New(ByVal id As Integer, ByVal description As String)
            Me._id = id
            Me._description = description
        End Sub

        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                _description = value
            End Set
        End Property
    End Class
End Class
