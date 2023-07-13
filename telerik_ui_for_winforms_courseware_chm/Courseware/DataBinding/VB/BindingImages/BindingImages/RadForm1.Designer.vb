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
        Me.components = New System.ComponentModel.Container
        Me.albumsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.musicCollectionDataSet = New BindingImages.MusicCollectionDataSet
        Me.albumsTableAdapter = New BindingImages.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.radListControl1 = New Telerik.WinControls.UI.RadListControl
        CType(Me.albumsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'albumsBindingSource1
        '
        Me.albumsBindingSource1.DataMember = "Albums"
        Me.albumsBindingSource1.DataSource = Me.musicCollectionDataSet
        '
        'musicCollectionDataSet
        '
        Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
        Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'albumsTableAdapter
        '
        Me.albumsTableAdapter.ClearBeforeFill = True
        '
        'radListControl1
        '
        Me.radListControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radListControl1.AutoSizeItems = True
        Me.radListControl1.CaseSensitiveSort = True
        Me.radListControl1.DataSource = Me.albumsBindingSource1
        Me.radListControl1.DisplayMember = "AlbumName"
        Me.radListControl1.ItemHeight = 18
        Me.radListControl1.Location = New System.Drawing.Point(12, 12)
        Me.radListControl1.Name = "radListControl1"
        Me.radListControl1.Size = New System.Drawing.Size(375, 255)
        Me.radListControl1.TabIndex = 1
        Me.radListControl1.ValueMember = "AlbumID"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 279)
        Me.Controls.Add(Me.radListControl1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Data Binding"
        CType(Me.albumsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private albumsBindingSource1 As System.Windows.Forms.BindingSource
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As BindingImages.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
    Private WithEvents radListControl1 As Telerik.WinControls.UI.RadListControl

End Class
