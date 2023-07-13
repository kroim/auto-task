Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    
    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.IsMdiContainer = True
        ' disable the delete button - there are no child forms
        Me.btnDelete.Enabled = False
        ' load drop down list with theme names
        Dim themes As ThemeList = ThemeResolutionService.GetAvailableThemes(Me)
        For Each theme As Theme In themes
            CommandBarDropDownList1.Items.Add(New RadListDataItem(theme.ThemeName))
        Next theme
        CommandBarDropDownList1.SelectedIndex = 0

        AddHandler MdiChildActivate, AddressOf RadForm1_MdiChildActivate
    End Sub

    Private Sub RadForm1_MdiChildActivate(ByVal sender As Object, ByVal e As EventArgs)
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.lblStatus.Text = (TryCast(Me.ActiveMdiChild, RadForm)).Text
            'for shaped form uncomment the next line and comment the above one
            'Me.lblStatus.Text = TryCast(TryCast(Me.ActiveMdiChild, ShapedForm1).Controls("radTitleBar1"), RadTitleBar).Text

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        ' close the active mdi child form
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        ' Create a new mdi child form, using the current theme
        Dim child As RadForm = New RadForm()

        'to use the shaped forms commet the line above and uncomment the following two lines
        'Dim child As ShapedForm1 = New ShapedForm1()
        'TryCast(child.Controls("radTitleBar1"), RadTitleBar).ThemeName = CommandBarDropDownList1.SelectedText

        child.MdiParent = Me
        child.Text = "Child Form - " & CommandBarDropDownList1.SelectedText
        child.ThemeName = CommandBarDropDownList1.SelectedText
        AddHandler child.FormClosed, AddressOf child_FormClosed
        child.Show()

        ' enable the delete button
        Me.btnDelete.Enabled = True
    End Sub

    Private Sub child_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' if there are child forms, enable the delete button
        ' add one to the count - the child form being closed still exists at this point
        Me.btnDelete.Enabled = Me.MdiChildren.Length > 1
    End Sub

  
End Class
