Imports Telerik.WinControls.UI

Class ColorSwatchColumn
    Inherits GridViewDataColumn
    Public Sub New(ByVal fieldName As String)

        MyBase.New(fieldName)
    End Sub

    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As System.Type
        If TypeOf row Is GridViewDataRowInfo Then
            Return GetType(ColorSwatchCellElement)
        End If
        Return MyBase.GetCellType(row)
    End Function
End Class

