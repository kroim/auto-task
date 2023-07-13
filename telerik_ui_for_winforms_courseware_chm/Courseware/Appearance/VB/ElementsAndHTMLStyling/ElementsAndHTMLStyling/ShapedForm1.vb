Imports Telerik.WinControls

Public Class ShapedForm1

    Private Sub ShapedForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "Aqua"
        Dim list As ThemeList = ThemeResolutionService.GetAvailableThemes(radTitleBar1)

        lblTitle.Text = "<html>" + "<size=11><b><color=1,78,194><font=Papyrus>Blue Sky Travel Planning</b>" + "<br>" + "<size=10><color=72,173,229><font=Narkisim>Get where you're going"
    End Sub
End Class
