<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("New", New String() {"New", "Create new file"})
        Dim ListViewDataItem2 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Open", New String() {"Open ", "Open file"})
        Dim ListViewDataItem3 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Save", New String() {"Save", "Save file"})
        Dim ListViewDataItem4 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Help", New String() {"Help", "Show help"})
        Me.listViewButton = New Telerik.WinControls.UI.RadButton
        Me.detailsViewButton = New Telerik.WinControls.UI.RadButton
        Me.iconsViewButton = New Telerik.WinControls.UI.RadButton
        Me.RadListView1 = New Telerik.WinControls.UI.RadListView
        CType(Me.listViewButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detailsViewButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconsViewButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listViewButton
        '
        Me.listViewButton.Location = New System.Drawing.Point(41, 328)
        Me.listViewButton.Name = "listViewButton"
        Me.listViewButton.Size = New System.Drawing.Size(130, 24)
        Me.listViewButton.TabIndex = 0
        Me.listViewButton.Text = "ListView"
        '
        'detailsViewButton
        '
        Me.detailsViewButton.Location = New System.Drawing.Point(188, 328)
        Me.detailsViewButton.Name = "detailsViewButton"
        Me.detailsViewButton.Size = New System.Drawing.Size(130, 24)
        Me.detailsViewButton.TabIndex = 1
        Me.detailsViewButton.Text = "DetailsView"
        '
        'iconsViewButton
        '
        Me.iconsViewButton.Location = New System.Drawing.Point(339, 328)
        Me.iconsViewButton.Name = "iconsViewButton"
        Me.iconsViewButton.Size = New System.Drawing.Size(130, 24)
        Me.iconsViewButton.TabIndex = 1
        Me.iconsViewButton.Text = "IconsView"
        '
        'RadListView1
        '
        Me.RadListView1.AllowArbitraryItemHeight = True
        Me.RadListView1.GroupItemSize = New System.Drawing.Size(200, 20)
        ListViewDataItem1.Image = Global.GettingStarted.My.Resources.Resources._New
        ListViewDataItem1.Text = "New"
        ListViewDataItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        ListViewDataItem2.Image = Global.GettingStarted.My.Resources.Resources.Open
        ListViewDataItem2.Text = "Open"
        ListViewDataItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        ListViewDataItem3.Image = Global.GettingStarted.My.Resources.Resources.Save
        ListViewDataItem3.Text = "Save"
        ListViewDataItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        ListViewDataItem4.Image = Global.GettingStarted.My.Resources.Resources.Help
        ListViewDataItem4.Text = "Help"
        ListViewDataItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {ListViewDataItem1, ListViewDataItem2, ListViewDataItem3, ListViewDataItem4})
        Me.RadListView1.ItemSize = New System.Drawing.Size(200, 20)
        Me.RadListView1.Location = New System.Drawing.Point(12, 12)
        Me.RadListView1.Name = "RadListView1"
        Me.RadListView1.Size = New System.Drawing.Size(484, 295)
        Me.RadListView1.TabIndex = 2
        Me.RadListView1.Text = "RadListView1"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 364)
        Me.Controls.Add(Me.RadListView1)
        Me.Controls.Add(Me.iconsViewButton)
        Me.Controls.Add(Me.detailsViewButton)
        Me.Controls.Add(Me.listViewButton)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form1"
        CType(Me.listViewButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detailsViewButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconsViewButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listViewButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents detailsViewButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents iconsViewButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadListView1 As Telerik.WinControls.UI.RadListView

End Class
