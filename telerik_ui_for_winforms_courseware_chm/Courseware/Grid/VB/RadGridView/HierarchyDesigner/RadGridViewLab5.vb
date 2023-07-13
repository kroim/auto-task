Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace _05_HierarchyDesigner
	Public Partial Class RadGridViewLab5
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RadGridViewLab5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'adventureWorksDataSet1.EmployeeDepartmentHistory' table. You can move, or remove it, as needed.
			Me.employeeDepartmentHistoryTableAdapter.Fill(Me.adventureWorksDataSet1.EmployeeDepartmentHistory)
			' TODO: This line of code loads data into the 'adventureWorksDataSet1.Department' table. You can move, or remove it, as needed.
			Me.departmentTableAdapter.Fill(Me.adventureWorksDataSet1.Department)

		End Sub
	End Class
End Namespace
