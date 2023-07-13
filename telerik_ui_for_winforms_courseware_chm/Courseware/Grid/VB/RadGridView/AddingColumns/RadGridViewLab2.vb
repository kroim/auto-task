Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace _02_AddingColumns
  Public Partial Class RadGridViewLab2
	  Inherits Form
	Public Sub New()
	  InitializeComponent()
	End Sub

	Private Sub RadGridViewLab2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
	  ' load the dataset
	  Me.salesPersonTableAdapter.Fill(Me.adventureWorksDataSet.SalesPerson)

	  ' assign the "PercentQuota" expression, and set format to be a percentage
	  Me.radGridView1.Columns("PercentQuota").Expression = "SalesYTD/SalesQuota"
            Me.radGridView1.Columns("PercentQuota").FormatString = "{0:P}"

	  ' create a new "Over 15 Percent" checkbox
	  Dim checkboxColumn As GridViewCheckBoxColumn = New GridViewCheckBoxColumn()
            checkboxColumn.Name = "CheckBoxColumn"
            checkboxColumn.HeaderText = "Over 15%"
            checkboxColumn.Width = 60
	  radGridView1.Columns.Add(checkboxColumn)
	  checkboxColumn.Expression = "PercentQuota > 15"

	  ' set column formats
            Me.radGridView1.Columns("SalesQuota").FormatString = "{0:C}"
            Me.radGridView1.Columns("Bonus").FormatString = "{0:C}"
            Me.radGridView1.Columns("SalesYTD").FormatString = "{0:C}"
            Me.radGridView1.Columns("SalesLastYear").FormatString = "{0:C}"
            Me.radGridView1.Columns("CommissionPct").FormatString = "{0:P}"

	  ' get the best fit for each column based on header text and data
            radGridView1.MasterTemplate.BestFitColumns()
	End Sub

  End Class
End Namespace
