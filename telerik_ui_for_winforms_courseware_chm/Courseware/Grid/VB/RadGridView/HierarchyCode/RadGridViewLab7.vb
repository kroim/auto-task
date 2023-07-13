Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace _07_HierarchyCode
  Public Partial Class RadGridViewLab7
	  Inherits Form
	Public Sub New()
	  InitializeComponent()

	End Sub

	Private Sub RadGridViewLab7_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
	  ' Create the dataset and table adapters
	  Dim adventureWorksDS As AdventureWorksDataSet = New AdventureWorksDataSet()
	  Dim salesPersonTA As AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter = New AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter()
	  Dim salesTerritoryTA As AdventureWorksDataSetTableAdapters.SalesTerritoryTableAdapter = New AdventureWorksDataSetTableAdapters.SalesTerritoryTableAdapter()
	  ' load the tables with data
	  salesTerritoryTA.Fill(adventureWorksDS.SalesTerritory)
	  salesPersonTA.Fill(adventureWorksDS.SalesPerson)

	  ' assign the parent table as the datasource for the grid and configure the master grid view
	  radGridView1.DataSource = adventureWorksDS.SalesTerritory
            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            radGridView1.MasterTemplate.AllowAddNewRow = False

            ' create, configure and assign the child grid view template
            Dim childTmpt As GridViewTemplate = New GridViewTemplate()
            childTmpt.DataSource = adventureWorksDS.SalesPerson
            childTmpt.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            childTmpt.AllowAddNewRow = False
            radGridView1.MasterTemplate.Templates.Add(childTmpt)

            ' create, configure and add the relation between master grid view and child template
            Dim relation As GridViewRelation = New GridViewRelation(radGridView1.MasterTemplate)
            relation.ChildTemplate = childTmpt
            relation.RelationName = "SalesTerritoryPerson"
            relation.ParentColumnNames.Add("TerritoryID")
            relation.ChildColumnNames.Add("TerritoryID")
            radGridView1.Relations.Add(relation)

            ' hide guid columns
            radGridView1.Columns("rowguid").IsVisible = False
            childTmpt.Columns("rowguid").IsVisible = False
        End Sub
  End Class
End Namespace
