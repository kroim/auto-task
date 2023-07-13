Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls

Public Class ShapedForm1

    Private Sub ShapedForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        albumsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        albumsBindingSource.MoveNext()
    End Sub

    Private Sub btnInfo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInfo.Click
        RadMessageBox.SetThemeName("Office2007Silver")
        Dim message As String = "Go on line to get information about """ & pnlTitle.Text & """?"

        Dim bitmap As Bitmap = New Bitmap(Me.BackgroundImage)
        RadMessageBox.Show(Me, message, "Information Options", MessageBoxButtons.YesNo, bitmap)
    End Sub

    Private Function GetContrastingColor(ByVal color As Color) As Color
        ' "exclusive OR" the color passed in to leave only the opposite color
        Return color.FromArgb(color.ToArgb() Xor &HFFFFFF)
    End Function

    ' configure the FillPrimitive to display in a "Gel" gradient style and set color
    Private Sub SetFillPrimitiveColor(ByVal element As RadElement, ByVal color1 As Color)
        Dim fillPrimitive As FillPrimitive = TryCast(element, FillPrimitive)
        fillPrimitive.NumberOfColors = 1
        fillPrimitive.GradientStyle = Telerik.WinControls.GradientStyles.Gel
        fillPrimitive.BackColor = color1
    End Sub

    Private Sub albumsBindingSource_BindingComplete(ByVal sender As Object, ByVal e As BindingCompleteEventArgs) Handles albumsBindingSource.BindingComplete
        ' background image will be null when the form first loads
        If Not Me.BackgroundImage Is Nothing Then
            ' convert Image to Bitmap for further manipulation
            Dim bitmap As Bitmap = New Bitmap(Me.BackgroundImage)

            ' get a color from the very center of the background image
            Dim color1 As Color = bitmap.GetPixel(bitmap.Width / 2, bitmap.Height / 2)
            ' get a color that contrasts with the center of the image
            Dim contrastingColor As Color = GetContrastingColor(color1)
            ' make a transluscent version of this color
            Dim semiTransparentColor As Color = Color.FromArgb(150, color1)

            ' set the buttons and panel with a gradient from the translucent color to the corner color
            SetFillPrimitiveColor(pnlTitle.PanelElement.Children(0), semiTransparentColor)
            SetFillPrimitiveColor(btnBack.ButtonElement.Children(0), semiTransparentColor)
            SetFillPrimitiveColor(btnNext.ButtonElement.Children(0), semiTransparentColor)
            SetFillPrimitiveColor(btnInfo.ButtonElement.Children(0), semiTransparentColor)

            ' set the color for the text to the contrasting color
            TryCast(btnBack.ButtonElement.Children(1).Children(1), TextPrimitive).ForeColor = contrastingColor
            TryCast(btnNext.ButtonElement.Children(1).Children(1), TextPrimitive).ForeColor = contrastingColor
            TryCast(btnInfo.ButtonElement.Children(1).Children(1), TextPrimitive).ForeColor = contrastingColor
            pnlTitle.ForeColor = contrastingColor
        End If
    End Sub
End Class
