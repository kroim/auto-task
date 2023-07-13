<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.tbAlbumID = New Telerik.WinControls.UI.RadTextBox
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.musicCollectionDataSet = New SimpleBinding.MusicCollectionDataSet
        Me.tbAlbumName = New Telerik.WinControls.UI.RadTextBox
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.albumsTableAdapter = New SimpleBinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAlbumID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAlbumName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radLabel1
        '
        Me.radLabel1.Location = New System.Drawing.Point(13, 14)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(51, 14)
        Me.radLabel1.TabIndex = 0
        Me.radLabel1.Text = "Album ID"
        '
        'tbAlbumID
        '
        Me.tbAlbumID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.albumsBindingSource, "AlbumID", True))
        Me.tbAlbumID.Location = New System.Drawing.Point(116, 14)
        Me.tbAlbumID.Name = "tbAlbumID"
        Me.tbAlbumID.Size = New System.Drawing.Size(100, 20)
        Me.tbAlbumID.TabIndex = 1
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
        'tbAlbumName
        '
        Me.tbAlbumName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.albumsBindingSource, "AlbumName", True))
        Me.tbAlbumName.Location = New System.Drawing.Point(116, 45)
        Me.tbAlbumName.Name = "tbAlbumName"
        Me.tbAlbumName.Size = New System.Drawing.Size(100, 20)
        Me.tbAlbumName.TabIndex = 3
        '
        'radLabel2
        '
        Me.radLabel2.Location = New System.Drawing.Point(13, 45)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(70, 14)
        Me.radLabel2.TabIndex = 2
        Me.radLabel2.Text = "Album Name"
        '
        'albumsTableAdapter
        '
        Me.albumsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 241)
        Me.Controls.Add(Me.tbAlbumName)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.tbAlbumID)
        Me.Controls.Add(Me.radLabel1)
        Me.Name = "Form1"
        Me.Text = "Data Binding"
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAlbumID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAlbumName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private tbAlbumID As Telerik.WinControls.UI.RadTextBox
    Private tbAlbumName As Telerik.WinControls.UI.RadTextBox
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As SimpleBinding.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter

End Class
