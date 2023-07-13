Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadRibbonForm1

    Private Sub RadRibbonForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add tab
        Dim tabItem1 As New RibbonTab()
        tabItem1.Text = "Manage"
        RadRibbonBar1.CommandTabs.Add(tabItem1)

        'add multiple tabs
        Dim tabItem2 As New RibbonTab()
        Dim tabItem3 As New RibbonTab()
        Dim tabItem4 As New RibbonTab()
        tabItem1.Text = "Write"
        tabItem2.Text = "Layout"
        tabItem3.Text = "Image"
        RadRibbonBar1.CommandTabs.AddRange(New RibbonTab() {tabItem2, tabItem3, tabItem4})

        'remove specified tab
        RadRibbonBar1.CommandTabs.Remove(tabItem1)
        'remove tab at specified index
        RadRibbonBar1.CommandTabs.RemoveAt(2)

        'add ribbon bar group
        Dim radRibbonBarGroup1 As New RadRibbonBarGroup()
        radRibbonBarGroup1.Text = "Options"
        DirectCast(RadRibbonBar1.CommandTabs(0), RibbonTab).Items.Add(radRibbonBarGroup1)

        'add multiple ribbon bar groups
        Dim radRibbonBarGroup2 As New RadRibbonBarGroup()
        Dim radRibbonBarGroup3 As New RadRibbonBarGroup()
        Dim radRibbonBarGroup4 As New RadRibbonBarGroup()
        radRibbonBarGroup2.Text = "Options"
        radRibbonBarGroup3.Text = "Text"
        radRibbonBarGroup4.Text = "Alignment"
        Dim ribbonTab1 As RibbonTab = DirectCast(RadRibbonBar1.CommandTabs(0), RibbonTab)
        ribbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {radRibbonBarGroup2, radRibbonBarGroup3, radRibbonBarGroup4})

        'remove speficied tab
        DirectCast(RadRibbonBar1.CommandTabs(0), RibbonTab).Items.Remove(radRibbonBarGroup1)

        'remove tab at specified index
        DirectCast(RadRibbonBar1.CommandTabs(0), RibbonTab).Items.RemoveAt(2)

        'add buttons
        Dim radButtonElement1 As New RadButtonElement()
        radButtonElement1.Text = "Button"
        radRibbonBarGroup2.Items.Add(radButtonElement1)

        'add multiple buttons
        Dim radButtonElement2 As New RadButtonElement()
        Dim radButtonElement3 As New RadButtonElement()
        radButtonElement2.Text = "Second Button"
        radButtonElement3.Text = "Third Button"
        radRibbonBarGroup2.Items.AddRange(New RadItem() {radButtonElement2, radButtonElement3})


        'remove button
        radRibbonBarGroup2.Items.Remove(radButtonElement3)

        'remove button at spcified index
        radRibbonBarGroup2.Items.RemoveAt(1)

        'add button group with buttons
        Dim radRibbonBarButtonGroup1 As New RadRibbonBarButtonGroup()
        radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal
        radRibbonBarButtonGroup1.MinSize = New System.Drawing.Size(22, 22)
        radRibbonBarButtonGroup1.ShowBorder = True
        Dim radButtonElement4 As New RadButtonElement()
        Dim radButtonElement5 As New RadButtonElement()
        radButtonElement4.Text = "Button One"
        radButtonElement5.Text = "Button Two"
        radRibbonBarButtonGroup1.Items.AddRange(New RadItem() {radButtonElement4, radButtonElement5})
        radRibbonBarGroup3.Items.Add(radRibbonBarButtonGroup1)
    End Sub
End Class
