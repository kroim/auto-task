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
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Me.radListControl1 = New Telerik.WinControls.UI.RadListControl
        Me.musicCollectionDataSet = New Introduction.MusicCollectionDataSet
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.albumsTableAdapter = New Introduction.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel
        Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
        Me.radLabel4 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel5 = New Telerik.WinControls.UI.RadLabel
        Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox
        Me.DesertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radListControl1
        '
        Me.radListControl1.CaseSensitiveSort = True
        Me.radListControl1.ItemHeight = 18
        Me.radListControl1.Location = New System.Drawing.Point(13, 32)
        Me.radListControl1.Name = "radListControl1"
        Me.radListControl1.Size = New System.Drawing.Size(259, 87)
        Me.radListControl1.TabIndex = 0
        Me.radListControl1.ThemeName = "Desert"
        '
        'musicCollectionDataSet
        '
        Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
        Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'albumsBindingSource
        '
        Me.albumsBindingSource.DataMember = "Albums"
        Me.albumsBindingSource.DataSource = Me.musicCollectionDataSet
        '
        'albumsTableAdapter
        '
        Me.albumsTableAdapter.ClearBeforeFill = True
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
        Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.radTreeView1.Location = New System.Drawing.Point(290, 32)
        Me.radTreeView1.Name = "radTreeView1"
        Me.radTreeView1.ShowLines = True
        Me.radTreeView1.Size = New System.Drawing.Size(259, 191)
        Me.radTreeView1.TabIndex = 1
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ThemeName = "Desert"
        '
        'radLabel1
        '
        Me.radLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel1.Location = New System.Drawing.Point(13, 10)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(84, 16)
        Me.radLabel1.TabIndex = 2
        Me.radLabel1.Text = "RadListControl"
        Me.radLabel1.ThemeName = "Desert"
        '
        'radLabel2
        '
        Me.radLabel2.AutoSize = False
        Me.radLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel2.Location = New System.Drawing.Point(290, 7)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(129, 19)
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
        Me.radDropDownList1.DropDownHeight = 53
        Me.radDropDownList1.Location = New System.Drawing.Point(13, 159)
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
        Me.radLabel3.Location = New System.Drawing.Point(13, 237)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(111, 14)
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
        Me.radGridView1.Location = New System.Drawing.Point(13, 257)
        '
        'radGridView1
        '
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.FieldName = "AlbumID"
        GridViewDecimalColumn1.HeaderText = "AlbumID"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "AlbumID"
        GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn1.Width = 76
        GridViewTextBoxColumn1.FieldName = "AlbumName"
        GridViewTextBoxColumn1.HeaderText = "AlbumName"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "AlbumName"
        GridViewTextBoxColumn1.Width = 158
        Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1})
        Me.radGridView1.MasterTemplate.DataSource = Me.albumsBindingSource
        Me.radGridView1.Name = "radGridView1"
        Me.radGridView1.Padding = New System.Windows.Forms.Padding(1)
        Me.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(1)
        Me.radGridView1.Size = New System.Drawing.Size(536, 150)
        Me.radGridView1.TabIndex = 7
        Me.radGridView1.Text = "radGridViewPreview"
        Me.radGridView1.ThemeName = "Desert"
        '
        'radLabel4
        '
        Me.radLabel4.AutoSize = False
        Me.radLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel4.Location = New System.Drawing.Point(13, 139)
        Me.radLabel4.Name = "radLabel4"
        Me.radLabel4.Size = New System.Drawing.Size(120, 16)
        Me.radLabel4.TabIndex = 3
        Me.radLabel4.Text = "RadDropDownList"
        Me.radLabel4.ThemeName = "Desert"
        '
        'radLabel5
        '
        Me.radLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel5.Location = New System.Drawing.Point(13, 425)
        Me.radLabel5.Name = "radLabel5"
        Me.radLabel5.Size = New System.Drawing.Size(71, 16)
        Me.radLabel5.TabIndex = 8
        Me.radLabel5.Text = "RadTextBox"
        Me.radLabel5.ThemeName = "Desert"
        '
        'radTextBox1
        '
        Me.radTextBox1.Location = New System.Drawing.Point(13, 446)
        Me.radTextBox1.Name = "radTextBox1"
        Me.radTextBox1.Size = New System.Drawing.Size(181, 20)
        Me.radTextBox1.TabIndex = 9
        Me.radTextBox1.TabStop = False
        Me.radTextBox1.Text = "radTextBox1"
        Me.radTextBox1.ThemeName = "Desert"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 479)
        Me.Controls.Add(Me.radTextBox1)
        Me.Controls.Add(Me.radLabel5)
        Me.Controls.Add(Me.radLabel4)
        Me.Controls.Add(Me.radGridView1)
        Me.Controls.Add(Me.radLabel3)
        Me.Controls.Add(Me.radDropDownList1)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.radTreeView1)
        Me.Controls.Add(Me.radListControl1)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Data Binding"
        Me.ThemeName = "Desert"
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radListControl1 As Telerik.WinControls.UI.RadListControl
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As Introduction.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
    Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private radGridView1 As Telerik.WinControls.UI.RadGridView
    Private radLabel4 As Telerik.WinControls.UI.RadLabel
    Private radLabel5 As Telerik.WinControls.UI.RadLabel
    Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents DesertTheme1 As Telerik.WinControls.Themes.DesertTheme

End Class
