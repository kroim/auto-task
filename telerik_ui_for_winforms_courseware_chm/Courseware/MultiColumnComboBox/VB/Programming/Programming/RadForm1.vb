Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim contacts As List(Of Contact) = New List(Of Contact)()
        contacts.Add(New Contact("Akina", "Yamada", "ykiko@gmail.com"))
        contacts.Add(New Contact("Bob", "Coffee", "bob@mymail.com"))
        contacts.Add(New Contact("Ajit", "Singh", "ajitsingh@yahoo.com"))
        contacts.Add(New Contact("Chavdar", "Ivanov", "civanov@gmail.com"))

        radMultiColumnComboBox1.DataSource = contacts
        radMultiColumnComboBox1.DisplayMember = "First"
        radMultiColumnComboBox1.ValueMember = "Email"

        Dim combo As RadMultiColumnComboBoxElement = radMultiColumnComboBox1.MultiColumnComboBoxElement
        combo.DropDownWidth = radMultiColumnComboBox1.Width
        combo.ArrowButtonMinWidth = 100

        combo.EditorControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        radMultiColumnComboBox1.AutoFilter = True
        Dim filter As FilterDescriptor = New FilterDescriptor()
        filter.PropertyName = radMultiColumnComboBox1.DisplayMember
        filter.Operator = FilterOperator.StartsWith
        combo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub

    Private Sub btnShowPopup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowPopup.Click
        Dim combo As RadMultiColumnComboBoxElement = radMultiColumnComboBox1.MultiColumnComboBoxElement
        combo.ShowPopup()
    End Sub

    Private Sub radMultiColumnComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radMultiColumnComboBox1.SelectedIndexChanged
        Dim rowInfo As GridViewDataRowInfo = TryCast((TryCast(sender, RadMultiColumnComboBox)).SelectedItem, GridViewDataRowInfo)
        Dim contact As Contact = TryCast(rowInfo.DataBoundItem, Contact)
        If Not contact Is Nothing Then
            lblSelected.Text = contact.First & " " & contact.Last & " " & contact.Email
        End If
    End Sub
End Class
