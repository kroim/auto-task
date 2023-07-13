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
	End Sub

	Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs) Handles radGridView1.CellFormatting
	  ' make sure the column is not the header and is a GridViewDataColumn
	  If TypeOf e.CellElement.ColumnInfo Is GridViewDataColumn AndAlso Not(TypeOf e.CellElement Is GridHeaderCellElement) Then
		Dim column As GridViewDataColumn = TryCast(e.CellElement.ColumnInfo, GridViewDataColumn)
		' only make changes to the CardType column
                If column.Name.Equals("CardType") AndAlso e.CellElement.RowInfo.Cells("ExpYear").Value IsNot Nothing Then
                    ' get value of the "ExpYear"
                    Dim year As Integer = CShort(Fix(e.CellElement.RowInfo.Cells("ExpYear").Value))
                    ' make changes based on another column ("ExpYear") where the current 
                    ' column contains "SuperiorCard"    
                    If (year < 2008) AndAlso (e.CellElement.Text.Equals("SuperiorCard")) Then
                        ' must set DrawFill for background colors to show!
                        e.CellElement.DrawFill = True
                        ' change any CellElement property
                        e.CellElement.BackColor = Color.PaleGreen
                        e.CellElement.BackColor2 = Color.LightGreen
                        e.CellElement.BackColor3 = Color.YellowGreen
                        e.CellElement.BackColor4 = Color.Green
                        e.CellElement.NumberOfColors = 4
                        e.CellElement.GradientStyle = GradientStyles.OfficeGlassRect
                    Else
                        ' must reset the visual modifications 
                        e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                        e.CellElement.ResetValue(LightVisualElement.BackColor3Property, ValueResetFlags.Local)
                        e.CellElement.ResetValue(LightVisualElement.BackColor4Property, ValueResetFlags.Local)
                        e.CellElement.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local)
                        e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                    End If
                End If
	  End If
	End Sub

        Private Sub toggleButtonEnableAlternationRowColor_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles toggleButtonEnableAlternationRowColor.ToggleStateChanged
            radGridView1.EnableAlternatingRowColor = Convert.ToBoolean(args.ToggleState)
            'radGridView1.TableElement.AlternatingRowColor = Color.Yellow
        End Sub

	Private Sub radGridView1_RowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs) Handles radGridView1.RowFormatting
            If toggleButtonEnableAlternationRowColor.ToggleState = ToggleState.On Then
                If e.RowElement.IsOdd Then
                    e.RowElement.DrawFill = True
                    e.RowElement.BackColor = Color.LightGreen
                    e.RowElement.BackColor2 = Color.PaleTurquoise
                    e.RowElement.BackColor3 = Color.PaleGreen
                    e.RowElement.BackColor4 = Color.SpringGreen
                    e.RowElement.GradientStyle = GradientStyles.Vista
                Else
                    e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                    e.RowElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                    e.RowElement.ResetValue(LightVisualElement.BackColor3Property, ValueResetFlags.Local)
                    e.RowElement.ResetValue(LightVisualElement.BackColor4Property, ValueResetFlags.Local)
                    e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                    e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                End If
            End If
	End Sub

    End Class
End Namespace
