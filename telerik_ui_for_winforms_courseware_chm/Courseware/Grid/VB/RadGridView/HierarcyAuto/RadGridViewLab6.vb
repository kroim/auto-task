Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace _06_HierarcyAuto
  Public Partial Class RadGridViewLab6
	  Inherits Form
	Public Sub New()
	  InitializeComponent()
	End Sub

	Private Sub RadGridViewLab6_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
	  Dim vendorTA As AdventureWorksDataSetTableAdapters.VendorTableAdapter = New AdventureWorksDataSetTableAdapters.VendorTableAdapter()
	  Dim productvendorTA As AdventureWorksDataSetTableAdapters.ProductVendorTableAdapter = New AdventureWorksDataSetTableAdapters.ProductVendorTableAdapter()
	  vendorTA.Fill(adventureWorksDataSet.Vendor)
            productvendorTA.Fill(adventureWorksDataSet.ProductVendor)

            radGridView1.AutoGenerateHierarchy = True
            radGridView1.DataMember = "Vendor"
            radGridView1.MasterTemplate.BestFitColumns()
            radGridView1.MasterTemplate.Templates(0).BestFitColumns()
	End Sub
  End Class
End Namespace
