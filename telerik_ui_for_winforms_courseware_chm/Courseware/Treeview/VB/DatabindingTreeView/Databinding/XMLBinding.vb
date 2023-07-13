Public Class XMLBinding

    Private Sub XMLBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dataSet As DataSet = New DataSet()
        dataSet.ReadXml("toc.xml")
        Me.radTreeView1.DataMember = "item"
        Me.radTreeView1.DisplayMember = "title"
        Me.radTreeView1.ChildMember = "id"
        Me.radTreeView1.ParentMember = "parentId"
        Me.radTreeView1.DataSource = dataSet
    End Sub
End Class