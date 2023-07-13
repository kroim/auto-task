Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programmingh
    Inherits RadForm

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
        Me.components = New System.ComponentModel.Container
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Me.RadListView1 = New Telerik.WinControls.UI.RadListView
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel
        Me.commandBarDropDownSort = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator
        Me.commandBarDropDownGroup = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator
        Me.commandBarToggleButtonList = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.commandBarToggleButtonTiles = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.commandBarToggleButtonDetails = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator
        Me.commandBarTextBoxFilter = New Telerik.WinControls.UI.CommandBarTextBox
        Me.MusicCollectionDataSet = New Programming.MusicCollectionDataSet
        Me.SongsDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SongsDataTableTableAdapter = New Programming.MusicCollectionDataSetTableAdapters.SongsDataTableTableAdapter
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongsDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadListView1
        '
        Me.RadListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadListView1.GroupItemSize = New System.Drawing.Size(200, 20)
        Me.RadListView1.ItemSize = New System.Drawing.Size(200, 20)
        Me.RadListView1.Location = New System.Drawing.Point(0, 55)
        Me.RadListView1.Name = "RadListView1"
        Me.RadListView1.Size = New System.Drawing.Size(846, 541)
        Me.RadListView1.TabIndex = 0
        Me.RadListView1.Text = "RadListView1"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(846, 55)
        Me.RadCommandBar1.TabIndex = 1
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel1, Me.commandBarDropDownSort, Me.CommandBarSeparator1, Me.commandBarDropDownGroup, Me.CommandBarSeparator2, Me.commandBarToggleButtonList, Me.commandBarToggleButtonTiles, Me.commandBarToggleButtonDetails, Me.CommandBarSeparator3, Me.commandBarTextBoxFilter})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'CommandBarLabel1
        '
        Me.CommandBarLabel1.AccessibleDescription = "Sort By: "
        Me.CommandBarLabel1.AccessibleName = "Sort By: "
        Me.CommandBarLabel1.DisplayName = "CommandBarLabel1"
        Me.CommandBarLabel1.Name = "CommandBarLabel1"
        Me.CommandBarLabel1.Text = "Sort By: "
        Me.CommandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel1.VisibleInOverflowMenu = True
        '
        'commandBarDropDownSort
        '
        Me.commandBarDropDownSort.DisplayName = "CommandBarDropDownList1"
        Me.commandBarDropDownSort.DropDownAnimationEnabled = True
        RadListDataItem1.Text = "None"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Song Name"
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "Artist"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "Album"
        RadListDataItem4.TextWrap = True
        Me.commandBarDropDownSort.Items.Add(RadListDataItem1)
        Me.commandBarDropDownSort.Items.Add(RadListDataItem2)
        Me.commandBarDropDownSort.Items.Add(RadListDataItem3)
        Me.commandBarDropDownSort.Items.Add(RadListDataItem4)
        Me.commandBarDropDownSort.Name = "commandBarDropDownSort"
        Me.commandBarDropDownSort.Text = ""
        Me.commandBarDropDownSort.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.commandBarDropDownSort.VisibleInOverflowMenu = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
        Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'commandBarDropDownGroup
        '
        Me.commandBarDropDownGroup.DisplayName = "CommandBarDropDownList1"
        Me.commandBarDropDownGroup.DropDownAnimationEnabled = True
        Me.commandBarDropDownGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem5.Text = "None"
        RadListDataItem5.TextWrap = True
        RadListDataItem6.Text = "Album"
        RadListDataItem6.TextWrap = True
        RadListDataItem7.Text = "Artist"
        RadListDataItem7.TextWrap = True
        Me.commandBarDropDownGroup.Items.Add(RadListDataItem5)
        Me.commandBarDropDownGroup.Items.Add(RadListDataItem6)
        Me.commandBarDropDownGroup.Items.Add(RadListDataItem7)
        Me.commandBarDropDownGroup.Name = "commandBarDropDownGroup"
        Me.commandBarDropDownGroup.Text = ""
        Me.commandBarDropDownGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.commandBarDropDownGroup.VisibleInOverflowMenu = True
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
        Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.DisplayName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'commandBarToggleButtonList
        '
        Me.commandBarToggleButtonList.AccessibleDescription = "CommandBarToggleButton1"
        Me.commandBarToggleButtonList.AccessibleName = "CommandBarToggleButton1"
        Me.commandBarToggleButtonList.DisplayName = "CommandBarToggleButton1"
        Me.commandBarToggleButtonList.Image = Global.Programming.My.Resources.Resources.list_icon
        Me.commandBarToggleButtonList.Name = "commandBarToggleButtonList"
        Me.commandBarToggleButtonList.Text = "CommandBarToggleButton1"
        Me.commandBarToggleButtonList.ToolTipText = "ListView"
        Me.commandBarToggleButtonList.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.commandBarToggleButtonList.VisibleInOverflowMenu = True
        '
        'commandBarToggleButtonTiles
        '
        Me.commandBarToggleButtonTiles.AccessibleDescription = "CommandBarToggleButton2"
        Me.commandBarToggleButtonTiles.AccessibleName = "CommandBarToggleButton2"
        Me.commandBarToggleButtonTiles.DisplayName = "CommandBarToggleButton2"
        Me.commandBarToggleButtonTiles.Image = Global.Programming.My.Resources.Resources.tiles_icon
        Me.commandBarToggleButtonTiles.Name = "commandBarToggleButtonTiles"
        Me.commandBarToggleButtonTiles.Text = "CommandBarToggleButton2"
        Me.commandBarToggleButtonTiles.ToolTipText = "IconsView"
        Me.commandBarToggleButtonTiles.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.commandBarToggleButtonTiles.VisibleInOverflowMenu = True
        '
        'commandBarToggleButtonDetails
        '
        Me.commandBarToggleButtonDetails.AccessibleDescription = "CommandBarToggleButton3"
        Me.commandBarToggleButtonDetails.AccessibleName = "CommandBarToggleButton3"
        Me.commandBarToggleButtonDetails.DisplayName = "CommandBarToggleButton3"
        Me.commandBarToggleButtonDetails.Image = Global.Programming.My.Resources.Resources.details_icon
        Me.commandBarToggleButtonDetails.Name = "commandBarToggleButtonDetails"
        Me.commandBarToggleButtonDetails.Text = "CommandBarToggleButton3"
        Me.commandBarToggleButtonDetails.ToolTipText = "DetailsView"
        Me.commandBarToggleButtonDetails.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.commandBarToggleButtonDetails.VisibleInOverflowMenu = True
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.AccessibleDescription = "CommandBarSeparator3"
        Me.CommandBarSeparator3.AccessibleName = "CommandBarSeparator3"
        Me.CommandBarSeparator3.DisplayName = "CommandBarSeparator3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'commandBarTextBoxFilter
        '
        Me.commandBarTextBoxFilter.AccessibleDescription = "CommandBarTextBox1"
        Me.commandBarTextBoxFilter.AccessibleName = "CommandBarTextBox1"
        Me.commandBarTextBoxFilter.DisplayName = "CommandBarTextBox1"
        Me.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter"
        Me.commandBarTextBoxFilter.Text = ""
        Me.commandBarTextBoxFilter.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.commandBarTextBoxFilter.VisibleInOverflowMenu = True
        '
        'MusicCollectionDataSet
        '
        Me.MusicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
        Me.MusicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SongsDataTableBindingSource
        '
        Me.SongsDataTableBindingSource.DataMember = "SongsDataTable"
        Me.SongsDataTableBindingSource.DataSource = Me.MusicCollectionDataSet
        '
        'SongsDataTableTableAdapter
        '
        Me.SongsDataTableTableAdapter.ClearBeforeFill = True
        '
        'Programmingh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 596)
        Me.Controls.Add(Me.RadListView1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "Programmingh"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "ListViewGettingStarted"
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongsDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadListView1 As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents commandBarDropDownSort As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents commandBarDropDownGroup As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents commandBarToggleButtonList As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents commandBarToggleButtonTiles As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents commandBarToggleButtonDetails As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents commandBarTextBoxFilter As Telerik.WinControls.UI.CommandBarTextBox
    Friend WithEvents MusicCollectionDataSet As MusicCollectionDataSet
    Friend WithEvents SongsDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SongsDataTableTableAdapter As MusicCollectionDataSetTableAdapters.SongsDataTableTableAdapter
End Class
