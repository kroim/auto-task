Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.radListControl1 = New Telerik.WinControls.UI.RadListControl
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.musicCollectionDataSet = New BindingSource.MusicCollectionDataSet
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel
        Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
        Me.radLabel4 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel5 = New Telerik.WinControls.UI.RadLabel
        Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox
        Me.bindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.albumsTableAdapter = New BindingSource.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNavigator1.SuspendLayout()
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radListControl1
        '
        Me.radListControl1.CaseSensitiveSort = True
        Me.radListControl1.DataSource = Me.albumsBindingSource
        Me.radListControl1.DisplayMember = "AlbumName"
        Me.radListControl1.ItemHeight = 18
        Me.radListControl1.Location = New System.Drawing.Point(13, 66)
        Me.radListControl1.Name = "radListControl1"
        Me.radListControl1.Size = New System.Drawing.Size(259, 87)
        Me.radListControl1.TabIndex = 0
        Me.radListControl1.ThemeName = "Desert"
        Me.radListControl1.ValueMember = "AlbumID"
        '
        'albumsBindingSource
        '
        Me.albumsBindingSource.DataMember = "Albums"
        Me.albumsBindingSource.DataSource = Me.musicCollectionDataSet
        '
        'musicCollectionDataSet
        '
        Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
        Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'radLabel1
        '
        Me.radLabel1.AutoSize = False
        Me.radLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel1.Location = New System.Drawing.Point(13, 44)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(107, 14)
        Me.radLabel1.TabIndex = 2
        Me.radLabel1.Text = "RadListControl"
        Me.radLabel1.ThemeName = "Desert"
        '
        'radLabel2
        '
        Me.radLabel2.AutoSize = False
        Me.radLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel2.Location = New System.Drawing.Point(290, 41)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(81, 17)
        Me.radLabel2.TabIndex = 3
        Me.radLabel2.Text = "RadTreeView"
        Me.radLabel2.ThemeName = "Desert"
        '
        'radDropDownList1
        '
        Me.radDropDownList1.AutoCompleteDisplayMember = "AlbumName"
        Me.radDropDownList1.AutoCompleteValueMember = "AlbumID"
        Me.radDropDownList1.DataSource = Me.albumsBindingSource
        Me.radDropDownList1.DisplayMember = "AlbumName"
        Me.radDropDownList1.Location = New System.Drawing.Point(13, 193)
        Me.radDropDownList1.MaxDropDownItems = 3
        Me.radDropDownList1.Name = "radDropDownList1"
        '
        '
        '
        Me.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radDropDownList1.ShowImageInEditorArea = True
        Me.radDropDownList1.Size = New System.Drawing.Size(259, 22)
        Me.radDropDownList1.TabIndex = 5
        Me.radDropDownList1.ThemeName = "Desert"
        Me.radDropDownList1.ValueMember = "AlbumID"
        '
        'radLabel3
        '
        Me.radLabel3.AutoSize = False
        Me.radLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel3.Location = New System.Drawing.Point(13, 271)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(83, 14)
        Me.radLabel3.TabIndex = 6
        Me.radLabel3.Text = "RadGridView"
        Me.radLabel3.ThemeName = "Desert"
        '
        'radGridView1
        '
        Me.radGridView1.BackColor = System.Drawing.SystemColors.Control
        Me.radGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.radGridView1.Location = New System.Drawing.Point(13, 291)
        '
        'radGridView1
        '
        GridViewDecimalColumn4.DataType = GetType(Integer)
        GridViewDecimalColumn4.FieldName = "AlbumID"
        GridViewDecimalColumn4.FormatString = ""
        GridViewDecimalColumn4.HeaderText = "AlbumID"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.Name = "AlbumID"
        GridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn4.Width = 76
        GridViewTextBoxColumn4.FieldName = "AlbumName"
        GridViewTextBoxColumn4.FormatString = ""
        GridViewTextBoxColumn4.HeaderText = "AlbumName"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "AlbumName"
        GridViewTextBoxColumn4.Width = 158
        Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn4, GridViewTextBoxColumn4})
        Me.radGridView1.MasterTemplate.DataSource = Me.albumsBindingSource
        Me.radGridView1.Name = "radGridView1"
        Me.radGridView1.Padding = New System.Windows.Forms.Padding(1)
        Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radGridView1.Size = New System.Drawing.Size(536, 150)
        Me.radGridView1.TabIndex = 7
        Me.radGridView1.Text = "radGridViewPreview"
        Me.radGridView1.ThemeName = "Desert"
        '
        'radLabel4
        '
        Me.radLabel4.AutoSize = False
        Me.radLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel4.Location = New System.Drawing.Point(13, 173)
        Me.radLabel4.Name = "radLabel4"
        Me.radLabel4.Size = New System.Drawing.Size(134, 14)
        Me.radLabel4.TabIndex = 3
        Me.radLabel4.Text = "RadDropDownList"
        Me.radLabel4.ThemeName = "Desert"
        '
        'radLabel5
        '
        Me.radLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel5.Location = New System.Drawing.Point(13, 450)
        Me.radLabel5.Name = "radLabel5"
        Me.radLabel5.Size = New System.Drawing.Size(71, 16)
        Me.radLabel5.TabIndex = 8
        Me.radLabel5.Text = "RadTextBox"
        Me.radLabel5.ThemeName = "Desert"
        '
        'radTextBox1
        '
        Me.radTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.albumsBindingSource, "AlbumID", True))
        Me.radTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.albumsBindingSource, "AlbumName", True))
        Me.radTextBox1.Location = New System.Drawing.Point(13, 471)
        Me.radTextBox1.Name = "radTextBox1"
        Me.radTextBox1.Size = New System.Drawing.Size(181, 20)
        Me.radTextBox1.TabIndex = 9
        Me.radTextBox1.TabStop = False
        Me.radTextBox1.Text = "radTextBox1"
        Me.radTextBox1.ThemeName = "Desert"
        '
        'bindingNavigator1
        '
        Me.bindingNavigator1.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.bindingNavigator1.BindingSource = Me.albumsBindingSource
        Me.bindingNavigator1.CountItem = Me.bindingNavigatorCountItem
        Me.bindingNavigator1.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.bindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem})
        Me.bindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.bindingNavigator1.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.bindingNavigator1.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.bindingNavigator1.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.bindingNavigator1.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.bindingNavigator1.Name = "bindingNavigator1"
        Me.bindingNavigator1.PositionItem = Me.bindingNavigatorPositionItem
        Me.bindingNavigator1.Size = New System.Drawing.Size(559, 25)
        Me.bindingNavigator1.TabIndex = 10
        Me.bindingNavigator1.Text = "bindingNavigator1"
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorDeleteItem.Text = "Delete"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.AccessibleName = "Position"
        Me.bindingNavigatorPositionItem.AutoSize = False
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
        Me.radTreeView1.DataSource = Me.albumsBindingSource
        Me.radTreeView1.DisplayMember = "AlbumName"
        Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.radTreeView1.Location = New System.Drawing.Point(278, 66)
        Me.radTreeView1.Name = "radTreeView1"
        Me.radTreeView1.ShowLines = True
        Me.radTreeView1.Size = New System.Drawing.Size(270, 205)
        Me.radTreeView1.TabIndex = 11
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ThemeName = "Desert"
        Me.radTreeView1.ValueMember = "AlbumID"
        '
        'albumsTableAdapter
        '
        Me.albumsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 506)
        Me.Controls.Add(Me.radTreeView1)
        Me.Controls.Add(Me.bindingNavigator1)
        Me.Controls.Add(Me.radTextBox1)
        Me.Controls.Add(Me.radLabel5)
        Me.Controls.Add(Me.radLabel4)
        Me.Controls.Add(Me.radGridView1)
        Me.Controls.Add(Me.radLabel3)
        Me.Controls.Add(Me.radDropDownList1)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.radListControl1)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Data Binding"
        Me.ThemeName = "Desert"
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNavigator1.ResumeLayout(False)
        Me.bindingNavigator1.PerformLayout()
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radListControl1 As Telerik.WinControls.UI.RadListControl
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As BindingSource.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private radGridView1 As Telerik.WinControls.UI.RadGridView
    Private radLabel4 As Telerik.WinControls.UI.RadLabel
    Private radLabel5 As Telerik.WinControls.UI.RadLabel
    Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
    Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Private bindingNavigator1 As System.Windows.Forms.BindingNavigator
    Private bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Private bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Private bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Private bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Private bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
End Class
