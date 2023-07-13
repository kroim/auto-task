Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace _08_VirtualMode
  Public Partial Class RadGridViewLab8
	  Inherits Form
	Private ContactTable As List(Of List(Of String)) = New List(Of List(Of String))()
	Private NumberOfRows As Integer = 20
	Private NumberOfCols As Integer = 4

	Public Sub New()
            InitializeComponent()

            AddHandler timer1.Tick, AddressOf timer1_Tick
	End Sub

        Private Sub RefreshContactData()
            'Dim seedInt As Integer = CInt(DateTime.Now.Ticks)
            Dim random As Random = New Random()

            ' iterate the number of to retrieve, 
            ' randomly index into the Contact table,
            ' and assign data to the current row
            Dim i As Integer = 0
            Do While i < NumberOfRows
                Dim index As Integer = random.Next(1000)
                Dim cr As AdventureWorksDataSet.ContactRow = adventureWorksDataSet.Contact(index)
                ContactTable(i)(0) = cr.FirstName
                ContactTable(i)(1) = cr.LastName
                ContactTable(i)(2) = cr.EmailAddress
                ContactTable(i)(3) = cr.Phone
                i += 1
            Loop
        End Sub

	Private Sub RadGridViewLab8_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
	  Me.contactTableAdapter.Fill(Me.adventureWorksDataSet.Contact)

	  ' set grid properties
            radGridView1.MasterTemplate.AllowAddNewRow = False
            radGridView1.MasterTemplate.AllowCellContextMenu = False
            radGridView1.MasterTemplate.AllowDeleteRow = False
            radGridView1.MasterTemplate.AllowEditRow = False
            radGridView1.EnableSorting = False
            radGridView1.EnableFiltering = False
            radGridView1.EnableGrouping = False

            ' initialize ContactTable
            Dim i As Integer = 0
            Do While i < NumberOfRows
                Dim list As List(Of String) = New List(Of String)
                list.Add(String.Empty)
                list.Add(String.Empty)
                list.Add(String.Empty)
                list.Add(String.Empty)
                ContactTable.Add(list)
                i += 1
            Loop

            ' configure the grid to use virtual mode, set the number of columns and rows, set
            ' the column heading text 
            radGridView1.VirtualMode = True
            radGridView1.ColumnCount = NumberOfCols
            radGridView1.Columns(0).HeaderText = "First Name"
            radGridView1.Columns(1).HeaderText = "Last Name"
            radGridView1.Columns(2).HeaderText = "Email"
            radGridView1.Columns(3).HeaderText = "Phone Number"
            radGridView1.RowCount = NumberOfRows

            ' auto size the columns
            radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

            ' trigger the timer
            timer1.Interval = 100
	  timer1.Start()
	End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            ' reload the contact table
            RefreshContactData()

            ' signal that the grid should be updated
            radGridView1.TableElement.Update(Telerik.WinControls.UI.GridUINotifyAction.DataChanged)
        End Sub

	Private Sub radGridView1_CellValueNeeded_1(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellValueEventArgs) Handles radGridView1.CellValueNeeded
	  ' supply the cell value from the ContactTable using the row and column index passed in
	  ' the GridViewCellValueEventArgs parameter
	  e.Value = ContactTable(e.RowIndex)(e.ColumnIndex)
	End Sub

  End Class
End Namespace
