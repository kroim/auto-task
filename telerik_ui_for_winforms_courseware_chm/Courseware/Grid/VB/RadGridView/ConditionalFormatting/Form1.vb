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

Namespace _13_ConditionalFormatting
  Public Partial Class Form1
	  Inherits Form
	Public Sub New()
	  InitializeComponent()
	End Sub

	Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'adventureWorksDataSet.CreditCard' table. You can move, or remove it, as needed.
	  Me.creditCardTableAdapter.Fill(Me.adventureWorksDataSet.CreditCard)

            radGridView1.MasterTemplate.BestFitColumns()

            ' create a rule to highlight "SuperiorCard" card types
            ' -highlight the entire row
            Dim cfo As ConditionalFormattingObject = New ConditionalFormattingObject("SuperiorCards", ConditionTypes.Equal, "SuperiorCard", "", True)
            cfo.RowBackColor = Color.LightGreen
            cfo.RowForeColor = Color.DarkGreen
            cfo.TextAlignment = ContentAlignment.MiddleRight
            radGridView1.Columns("CardType").ConditionalFormattingObjectList.Add(cfo)

            ' highlight cards with expiry year less than 2008.
            ' -highlight only the cell
            Dim cfo2 As ConditionalFormattingObject = New ConditionalFormattingObject("Expired Cards", ConditionTypes.Less, "2008", "", False)
            cfo2.CellBackColor = Color.Transparent
            cfo2.CellForeColor = Color.Red
            cfo2.TextAlignment = ContentAlignment.MiddleRight
            radGridView1.Columns("ExpYear").ConditionalFormattingObjectList.Add(cfo2)
        End Sub

        ' show the conditional formatting dialog
        Private Sub btnShowDialog_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDialog.Click

            Dim cf As ConditionalFormattingForm = New ConditionalFormattingForm(radGridView1.MasterTemplate, Nothing)
            cf.Show()
        End Sub

        ' replace a grid context menu item
        Private Sub radGridView1_ContextMenuOpening(ByVal sender As Object, ByVal e As ContextMenuOpeningEventArgs) Handles radGridView1.ContextMenuOpening
            Dim i As Integer = 0
            Do While i < e.ContextMenu.Items.Count
                Dim item As RadMenuItemBase = CType(e.ContextMenu.Items(i), RadMenuItemBase)
                If item.Text = "Conditional Formatting" Then
                    e.ContextMenu.Items.Remove(item)
                    Dim newItem As RadMenuItem = New RadMenuItem("My Conditional Formatting")
                    AddHandler newItem.Click, AddressOf newItem_Click
                    e.ContextMenu.Items.Insert(4, newItem)
                    Exit Do
                End If
                i += 1
            Loop
        End Sub

        ' handle the click for the custom grid menu item
        Private Sub newItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim cf As ConditionalFormattingForm = New ConditionalFormattingForm(radGridView1.MasterTemplate, Nothing)
            cf.TopMost = True
            cf.Show()
            cf.Focus()
        End Sub



    End Class
End Namespace
