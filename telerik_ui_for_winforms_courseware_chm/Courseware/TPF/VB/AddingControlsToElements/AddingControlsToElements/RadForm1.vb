Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadListControl1.Items.Add("Item 1")
        RadListControl1.Items.Add("Item 2")
        RadListControl1.Items.Add("Item 3")
    End Sub

   
    Private Sub RadListControl1_CreatingVisualListItem(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.CreatingVisualListItemEventArgs) Handles RadListControl1.CreatingVisualListItem
        'make the items autosize 
        RadListControl1.AutoSizeItems = True

        ' create and configure the groupbox
        Dim groupBox As New GroupBox()

        ' create the RadHostItem with the groupbox as hosted control
        Dim host As New RadHostItem(groupBox)

        ' add host item to the list box item
        Dim visualItem As New RadListVisualItem()
        visualItem.Children.Insert(0, host)
        visualItem.Padding = New Padding(50)
        args.VisualItem = visualItem
    End Sub


    Private Sub RadListControl1_VisualItemFormatting(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.VisualItemFormattingEventArgs) Handles RadListControl1.VisualItemFormatting
        'get the host item from the visual item childred collection
        Dim hostItem As RadHostItem = DirectCast(args.VisualItem.Children(0), RadHostItem)
        'get the group box which is hosted by the host item
        Dim groupBox As GroupBox = DirectCast(hostItem.HostedControl, GroupBox)
        'set the text of the group box to eqals the data item text
        groupBox.Text = args.VisualItem.Data.Text
        'remove the visual item default text
        args.VisualItem.Text = ""
    End Sub
End Class
