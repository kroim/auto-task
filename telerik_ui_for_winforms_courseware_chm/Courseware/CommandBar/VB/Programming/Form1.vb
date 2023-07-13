Imports Telerik.WinControls.UI
Imports System.Resources
Imports System.Globalization
Imports Telerik.WinControls

Public Class Form1
    Inherits RadForm

    Private radCommandBar1 As New RadCommandBar()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radCommandBar1.Dock = DockStyle.Top
        radCommandBar1.Name = "radCommandBar1"
        Me.Controls.Add(radCommandBar1)

        Dim commandBarRowElement1 As New CommandBarRowElement()
        commandBarRowElement1.Name = "commandBarRowElement1"
        radCommandBar1.Rows.Add(commandBarRowElement1)

        Dim commandBarStripElement1 As New CommandBarStripElement()
        commandBarStripElement1.Name = "commandBarStripElement1"
        commandBarRowElement1.Strips.Add(commandBarStripElement1)

        LoadItems(commandBarStripElement1)
    End Sub

    Private Sub LoadItems(ByVal stripElement As CommandBarStripElement)
        ' list the resources in Properties.Resources
        Dim resourceSet As ResourceSet = Programming.My.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, True, True)
        Dim enumerator As IDictionaryEnumerator = resourceSet.GetEnumerator()

        ' for each image resources, retrieve the image name and object,
        ' create and populate the list items
        While enumerator.MoveNext()
            Dim item As New CommandBarButton()

            item.Image = DirectCast(enumerator.Value, Bitmap)
            'the name have to be set since the save and load layout mechanism is using it
            item.Name = enumerator.Key.ToString().Replace("_", " ")
            item.ToolTipText = item.Name
            'sets the text that will be displayed in the overflow button
            item.DisplayName = item.Name
            item.TextImageRelation = TextImageRelation.ImageAboveText
            AddHandler item.Click, AddressOf item_Click
            stripElement.Items.Add(item)
        End While
    End Sub

    Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim buttonElement As CommandBarButton = TryCast(sender, CommandBarButton)
        Dim commandBar As RadCommandBar = TryCast(buttonElement.ElementTree.Control, RadCommandBar)
        Dim bitmap As New Bitmap(buttonElement.Image)
        RadMessageBox.Show(Me, buttonElement.Text, "You clicked...", MessageBoxButtons.OK, bitmap)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim s As String = "default.xml"
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        dialog.Title = "Select a xml file"
        If dialog.ShowDialog() = DialogResult.OK Then
            s = dialog.FileName
        End If

        Me.RadCommandBar1.CommandBarElement.SaveLayout(s)
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim s As String = "default.xml"
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        dialog.Title = "Select a xml file"
        If dialog.ShowDialog() = DialogResult.OK Then
            s = dialog.FileName
        End If

        Me.radCommandBar1.CommandBarElement.LoadLayout(s)
    End Sub
End Class
