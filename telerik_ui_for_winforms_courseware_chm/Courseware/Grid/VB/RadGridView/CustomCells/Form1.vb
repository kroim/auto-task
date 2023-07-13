Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace _15_CustomCells
  Public Partial Class Form1
	  Inherits Form
	Public Sub New()
	  InitializeComponent()

	End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.productTableAdapter.Fill(Me.adventureWorksDataSet1.Product)
            radGridView1.MasterTemplate.BestFitColumns()
            radGridView1.Columns.Remove("Color")
            Dim col As New ColorSwatchColumn("Color")

            radGridView1.Columns.Add(col)
        End Sub

	Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
	  Me.productTableAdapter.Update(Me.adventureWorksDataSet1)
	End Sub

  End Class
End Namespace
