Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'furnitureDataSet.Products' table. You can move, or remove it, as needed.
        Me.productsTableAdapter.Fill(Me.furnitureDataSet.Products)

        radGridView1.Columns("Photo").ImageLayout = ImageLayout.Stretch
        radGridView1.Columns("ProductName").BestFit()
        radGridView1.Columns("Manufacturer").BestFit()
        radGridView1.TableElement.UpdateView()

        ThemeResolutionService.ApplicationThemeName = "Desert"

        RadDock1.MainDocumentContainerVisible = False

        For Each knownColor As KnownColor In System.Enum.GetValues(GetType(KnownColor))
            Dim item As RadListDataItem = New RadListDataItem()
            item.Text = Color.FromKnownColor(knownColor).Name
            item.Value = Color.FromKnownColor(knownColor)
            CommandBarDropDownList1.Items.Add(item)
        Next knownColor

        RadCommandBar1.Rows(0).Strips(0).StretchHorizontally = True
        CommandBarDropDownList1.DropDownListElement.MaxSize = CommandBarDropDownList1.Size
        CommandBarDropDownList1.DropDownListElement.Alignment = ContentAlignment.MiddleCenter
        CommandBarDropDownList1.StretchHorizontally = True
        CommandBarDropDownList1.Text = "Choose a Color"
        AddHandler CommandBarDropDownList1.SelectedIndexChanged, AddressOf CommandBarDropDownList1_SelectedIndexChanged

    End Sub

    Private Sub CommandBarDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        Dim item As RadListDataItem = TryCast((TryCast(sender, RadDropDownListElement)).SelectedItem, RadListDataItem)
        Dim color As Color = CType(item.Value, Color)

        Dim currentTheme As Theme = ThemeResolutionService.GetTheme(ThemeResolutionService.ApplicationThemeName)
        currentTheme.AddColorBlend("BaseColor", Telerik.WinControls.HslColor.FromColor(color.Orange))
        currentTheme.ThemeProperties("BaseColor") = Telerik.WinControls.HslColor.FromColor(color)

        currentTheme.AddColorBlend("CommandBarColor", Telerik.WinControls.HslColor.FromColor(color.FromArgb(170, 215, 218)))
        currentTheme.ThemeProperties("CommandBarColor") = Telerik.WinControls.HslColor.FromColor(color)
    End Sub
End Class
