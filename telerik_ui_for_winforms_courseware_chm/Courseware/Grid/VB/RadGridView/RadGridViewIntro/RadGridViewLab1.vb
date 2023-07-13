Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace _01_RadGridViewIntro
	Public Partial Class RadGridViewLab1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RadGridViewLab1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'adventureWorksDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.adventureWorksDataSet.SalesPerson)

		End Sub
	End Class
End Namespace
