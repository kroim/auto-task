Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace _04_SortingandFiltering
  Public Partial Class RadGridViewLab4
	  Inherits Form
	Public Sub New()
	  InitializeComponent()
	End Sub

	Private Sub RadGridViewLab4_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
	  Me.productTableAdapter.Fill(Me.productDataSet1.Product)
	  ' sort by "Color" in ascending order
            radGridView1.MasterTemplate.SortDescriptors.Add(New SortDescriptor("Color", System.ComponentModel.ListSortDirection.Ascending))

            ' filter for rows where "MakeFlag" is true
            radGridView1.MasterTemplate.FilterDescriptors.Add(New FilterDescriptor("MakeFlag", FilterOperator.IsEqualTo, True))

            ' filter for rows where ProductNumber starts with either a "C" or "R" character
            Dim compositeDescriptor As New CompositeFilterDescriptor()
            compositeDescriptor.LogicalOperator = FilterLogicalOperator.[Or]
            compositeDescriptor.FilterDescriptors.Add(New FilterDescriptor("ProductNumber", FilterOperator.StartsWith, "C"))
            compositeDescriptor.FilterDescriptors.Add(New FilterDescriptor("ProductNumber", FilterOperator.StartsWith, "R"))
            radGridView1.MasterTemplate.FilterDescriptors.Add(compositeDescriptor)
        End Sub
  End Class
End Namespace
