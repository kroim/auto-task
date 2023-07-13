Public Class Form1
    ' The "Me" variable refers to the form that contains the RibbonBar
    ' Declare variables for tabs and contextual tab groups
    Private RibbonTab1 As New Telerik.WinControls.UI.RibbonTab()
    Private RibbonTab2 As New Telerik.WinControls.UI.RibbonTab()
    Private RibbonTab3 As New Telerik.WinControls.UI.RibbonTab()
    Private RibbonTab4 As New Telerik.WinControls.UI.RibbonTab()
    Private RibbonTab5 As New Telerik.WinControls.UI.RibbonTab()
    Private ContextualTabGroup1 As New Telerik.WinControls.UI.ContextualTabGroup()
    Private ContextualTabGroup2 As New Telerik.WinControls.UI.ContextualTabGroup()

    Private Sub ManagingContextualTabGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RibbonTab1.Text = "Tab one"
        RibbonTab2.Text = "Tab two"
        RibbonTab3.Text = "Tab three"
        RibbonTab4.Text = "Tab four"
        RibbonTab5.Text = "Tab five"

        ContextualTabGroup1.Text = "Contextual tab group 1"
        ContextualTabGroup2.Text = "Contextual tab group 2"

        'Add the tabs to the ribbon bar
        Me.RadRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.UI.RibbonTab() {Me.RibbonTab1, Me.RibbonTab2, Me.RibbonTab3, Me.RibbonTab4, Me.RibbonTab5})

        'Add the contextual tab groups to the ribbon bar
        Me.RadRibbonBar1.ContextualTabGroups.AddRange(New Telerik.WinControls.RadItem() {Me.ContextualTabGroup1, Me.ContextualTabGroup2})

        'Associate the groups with some tabs
        Me.ContextualTabGroup1.TabItems.Add(Me.RibbonTab1)
        Me.ContextualTabGroup1.TabItems.Add(Me.RibbonTab2)
        Me.ContextualTabGroup2.TabItems.Add(Me.RibbonTab3)
        Me.ContextualTabGroup2.TabItems.Add(Me.RibbonTab4)
    End Sub


End Class
