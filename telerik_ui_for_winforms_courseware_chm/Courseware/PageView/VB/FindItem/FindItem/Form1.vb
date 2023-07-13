Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Public Class Form1

    Public Sub New()
        InitializeComponent()

        RadPageViewPage1.Tag = "simple"
        RadPageViewPage2.Tag = "simple"
        RadPageViewPage3.Tag = "simple"
        RadPageViewPage4.Tag = "advanced"
        RadPageViewPage5.Tag = "advanced"

    End Sub
    Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        'iterating pages
        For Each page As RadPageViewPage In RadPageView1.Pages
            If (page.Tag.ToString().Equals("advanced") And args.ToggleState.Equals(ToggleState.On)) Then
                page.Item.Visibility = ElementVisibility.Collapsed
            Else
                page.Item.Visibility = ElementVisibility.Visible
            End If
        Next page

        'finding items
        Dim advanced As IEnumerable(Of RadPageViewPage) = RadPageView1.Pages.Where(Function(item) item.Tag.ToString().Equals("advanced"))
        For Each page As RadPageViewPage In advanced
            page.Item.Visibility = If(args.ToggleState = ToggleState.[On], ElementVisibility.Collapsed, ElementVisibility.Visible)
        Next
    End Sub
End Class
