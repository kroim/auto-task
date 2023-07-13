<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelatedData
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
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.songsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.musicCollectionDataSet = New Databinding.MusicCollectionDataSet
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.albumsTableAdapter = New Databinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Me.artistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.artistsTableAdapter = New Databinding.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
        Me.songsTableAdapter = New Databinding.MusicCollectionDataSetTableAdapters.SongsTableAdapter
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.songsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
        Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.radTreeView1.Location = New System.Drawing.Point(15, 15)
        Me.radTreeView1.Name = "radTreeView1"
        Me.radTreeView1.Size = New System.Drawing.Size(268, 249)
        Me.radTreeView1.TabIndex = 0
        Me.radTreeView1.Text = "radTreeView1"
        '
        'songsBindingSource
        '
        Me.songsBindingSource.DataMember = "Songs"
        Me.songsBindingSource.DataSource = Me.musicCollectionDataSet
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
        'artistsBindingSource
        '
        Me.artistsBindingSource.DataMember = "Artists"
        Me.artistsBindingSource.DataSource = Me.musicCollectionDataSet
        '
        'artistsTableAdapter
        '
        Me.artistsTableAdapter.ClearBeforeFill = True
        '
        'songsTableAdapter
        '
        Me.songsTableAdapter.ClearBeforeFill = True
        '
        'RelatedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 279)
        Me.Controls.Add(Me.radTreeView1)
        Me.Name = "RelatedData"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "RelatedData "
        Me.ThemeName = "ControlDefault"
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.songsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As Databinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
    Private artistsBindingSource As System.Windows.Forms.BindingSource
    Private artistsTableAdapter As Databinding.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
    Private songsBindingSource As System.Windows.Forms.BindingSource
    Private songsTableAdapter As Databinding.MusicCollectionDataSetTableAdapters.SongsTableAdapter
End Class
