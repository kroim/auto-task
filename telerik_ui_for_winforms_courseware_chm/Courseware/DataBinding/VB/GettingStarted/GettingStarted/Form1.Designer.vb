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
        Me.radListControl1 = New Telerik.WinControls.UI.RadListControl
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.musicCollectionDataSet = New GettingStarted.MusicCollectionDataSet
        Me.albumsTableAdapter = New GettingStarted.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radListBox1
        '
        Me.radListControl1.DataSource = Me.albumsBindingSource
        Me.radListControl1.DisplayMember = "AlbumName"
        Me.radListControl1.Location = New System.Drawing.Point(13, 13)
        Me.radListControl1.Name = "radListBox1"
        Me.radListControl1.Size = New System.Drawing.Size(259, 239)
        Me.radListControl1.TabIndex = 0
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
        'albumsTableAdapter
        '
        Me.albumsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.radListControl1)
        Me.Name = "Form1"
        Me.Text = "Data Binding"
        CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radListControl1 As Telerik.WinControls.UI.RadListControl
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As GettingStarted.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter

End Class
