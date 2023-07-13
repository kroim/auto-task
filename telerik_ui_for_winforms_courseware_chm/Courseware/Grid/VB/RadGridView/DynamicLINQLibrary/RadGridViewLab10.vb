Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Linq.Dynamic
Imports System.Windows.Forms

Namespace _10_DynamicLINQLibrary
  Public Partial Class RadGridViewLab10
	  Inherits Form
	Public Sub New()
	  InitializeComponent()
	End Sub

	Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSort.Click
            Me.radGridView1.TableElement.BeginUpdate()
	  Dim queryable As IQueryable = New SalesOrderHeaderDataClassDataContext().SalesOrderHeaders.AsQueryable()
	  queryable = queryable.OrderBy(String.Format("{0} {1}", cbField.Text, cbSortType.Text))
	  radGridView1.DataSource = queryable.Take(Convert.ToInt32(numRecords.Value))
            Me.radGridView1.TableElement.EndUpdate(True)
	End Sub

  End Class
End Namespace
