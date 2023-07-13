Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' get themes that exist for all RadControls in the project
        Dim tabStripThemes As ThemeList = ThemeResolutionService.GetAvailableThemes(radPageView1)
        Dim comboBoxThemes As ThemeList = ThemeResolutionService.GetAvailableThemes(radDropDownList1)
        Dim formThemes As ThemeList = ThemeResolutionService.GetAvailableThemes(Me)

        Dim masterList As ThemeList = New ThemeList()

        ' formThemes.ForEach(theme =>
        'Dim tempTheme As Theme = tabStripThemes.Find(tabStripTheme => { Return theme.Equals(tabStripTheme); })
        'Dim tempTheme2 As Theme = comboBoxThemes.Find(comboBoxTheme => { Return comboBoxTheme.Equals(tempTheme); })
        '      If Not tempTheme2 Is Nothing Then
        '          masterList.Add(tempTheme2)
        '      End If
        ')
        For Each s As Theme In formThemes
            Dim tempTheme As Theme = Nothing
            For Each tabStripTheme As Theme In tabStripThemes
                If tabStripTheme.Equals(s) Then
                    tempTheme = s
                    Exit For
                End If
            Next

            If tempTheme IsNot Nothing Then
                Dim tempTheme2 As Theme = Nothing
                For Each comboBoxTheme As Theme In comboBoxThemes
                    If comboBoxTheme.Equals(tempTheme) Then
                        tempTheme2 = comboBoxTheme
                        Exit For
                    End If
                Next

                If tempTheme2 IsNot Nothing Then
                    masterList.Add(tempTheme2)
                End If
            End If
        Next


        For Each theme As Theme In masterList
            radComboBox1.Items.Add(New RadComboBoxItem(theme.ThemeName, theme))
        Next theme
        AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radComboBox1_SelectedIndexChanged
        radDropDownList1.SelectedIndex = 0
    End Sub

    Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim theme As Theme = TryCast(radDropDownList1.SelectedValue, Theme)
        radPageView1.ThemeName = theme.ThemeName
        radDropDownList1.ThemeName = theme.ThemeName
        Me.ThemeName = theme.ThemeName
    End Sub
End Class
