Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI


Public Class ColorSwatchCellElement
    Inherits GridDataCellElement
    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Private _swatch As LightVisualElement

    Protected Overloads Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        _swatch = New LightVisualElement()
        _swatch.DrawFill = True
        _swatch.Font = New Font("Arial", 7.0F, FontStyle.Regular)
        _swatch.Shape = New RoundRectShape(5)
        _swatch.GradientStyle = GradientStyles.Linear
        _swatch.NumberOfColors = 2
        RemoveHandler _swatch.MouseDown, AddressOf _swatch_MouseDown
        AddHandler _swatch.MouseDown, AddressOf _swatch_MouseDown
        Me.Children.Add(_swatch)
    End Sub

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        MyBase.ArrangeOverride(finalSize)
        'size the element according to the cell size
        _swatch.Arrange(New RectangleF(3, 3, finalSize.Width - 6, finalSize.Height - 6))
        Return finalSize
    End Function

    Protected Overloads Overrides Sub SetContentCore(ByVal value As Object)
        ' blank out the cell's text, only show on swatch element
        Me.Text = ""
    End Sub

    Public Overloads Overrides Sub SetContent()
        MyBase.SetContent()

        ' set default properties
        _swatch.BackColor = Color.White
        _swatch.BackColor2 = Color.White
        _swatch.Text = String.Empty

        ' only process if there is a value and its not "Transparent"
        If (Not Me.Value.Equals(System.DBNull.Value)) AndAlso ((Not Me.Value.ToString().Equals("Transparent"))) Then
            Dim colorName As String = Me.Value.ToString()
            ' convert to a Color type and assign to background color
            _swatch.BackColor2 = Color.FromName(colorName)
            ' set the readable color name
            _swatch.Text = colorName
        End If

        If Me.ElementTree IsNot Nothing Then
            ' get the size of the color name string
            Dim size As SizeF = SizeF.Empty
            Using g As Graphics = Me.ElementTree.Control.CreateGraphics()
                size = g.MeasureString(_swatch.Text, Me.Font)
            End Using

            ' get the current column width
            Dim width As Integer = Me.GridControl.Columns(Me.ColumnIndex).Width
            ' set column width to use the column or measured 
            ' color name string width, whichever is widest
            Me.GridControl.Columns(Me.ColumnIndex).Width = Math.Max(width, CInt(Fix(size.Width)))
        End If
    End Sub

    Private Sub _swatch_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' configure color dialog to only show web colors
        Dim colorDialog As RadColorDialog = New RadColorDialog()
        colorDialog.ColorDialogForm.ShowBasicColors = False
        colorDialog.ColorDialogForm.ShowProfessionalColors = False
        colorDialog.ColorDialogForm.ShowSystemColors = False
        colorDialog.ColorDialogForm.ShowCustomColors = False
        colorDialog.ColorDialogForm.ShowHEXColorValue = False
        colorDialog.ColorDialogForm.AllowColorPickFromScreen = False
        colorDialog.ColorDialogForm.AllowColorSaving = False
        colorDialog.ColorDialogForm.WebTabHeading = "Swatch Colors"

        ' set initial dialog color
        colorDialog.SelectedColor = _swatch.BackColor2
        If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' set value to known color name of selected color
            Me.Value = GetColorName(colorDialog.SelectedColor)
        End If
    End Sub

    Public Function GetColorName(ByVal color As Color) As String
        For Each knownColor As KnownColor In System.Enum.GetValues(GetType(KnownColor))
            ' only look for web colors, not system colors
            If (knownColor > knownColor.Transparent) AndAlso (knownColor < knownColor.ButtonFace) Then
                If color.ToArgb() = System.Drawing.Color.FromKnownColor(knownColor).ToArgb() Then
                    Return knownColor.ToString()
                End If
            End If
        Next knownColor
        Return KnownColor.Transparent.ToString()
    End Function

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridDataCellElement)
        End Get
    End Property

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is ColorSwatchColumn AndAlso TypeOf context Is GridDataRowElement
    End Function
End Class
