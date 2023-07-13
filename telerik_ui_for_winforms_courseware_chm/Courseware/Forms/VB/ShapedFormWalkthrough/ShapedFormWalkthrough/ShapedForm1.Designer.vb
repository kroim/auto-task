<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShapedForm1
    Inherits Telerik.WinControls.UI.ShapedForm
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
        Me.donutShape1 = New Telerik.WinControls.Tests.DonutShape
        Me.pnlTitle = New Telerik.WinControls.UI.RadPanel
        Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.musicCollectionDataSet = New ShapedFormWalkthrough.MusicCollectionDataSet
        Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.albumsTableAdapter = New ShapedFormWalkthrough.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Me.btnNext = New Telerik.WinControls.UI.RadButton
        Me.ellipseShape1 = New Telerik.WinControls.EllipseShape
        Me.btnInfo = New Telerik.WinControls.UI.RadButton
        Me.btnBack = New Telerik.WinControls.UI.RadButton
        Me.aquaTheme1 = New Telerik.WinControls.Themes.AquaTheme
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        CType(Me.pnlTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'donutShape1
        '
        Me.donutShape1.Thickness = 100
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.albumsBindingSource, "AlbumName", True))
        Me.pnlTitle.Location = New System.Drawing.Point(30, 168)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(200, 30)
        Me.pnlTitle.TabIndex = 0
        Me.pnlTitle.Text = "radPanel1"
        CType(Me.pnlTitle.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "radPanel1"
        CType(Me.pnlTitle.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.roundRectShape1
        CType(Me.pnlTitle.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
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
        'roundRectShape1
        '
        Me.roundRectShape1.Radius = 20
        '
        'albumsTableAdapter
        '
        Me.albumsTableAdapter.ClearBeforeFill = True
        '
        'btnNext
        '
        Me.btnNext.AllowShowFocusCues = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Location = New System.Drawing.Point(156, 204)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 40)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        CType(Me.btnNext.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Next"
        CType(Me.btnNext.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Shape = Me.ellipseShape1
        '
        'btnInfo
        '
        Me.btnInfo.AllowShowFocusCues = True
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.Location = New System.Drawing.Point(113, 204)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(40, 40)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Info"
        CType(Me.btnInfo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Info"
        CType(Me.btnInfo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Shape = Me.ellipseShape1
        '
        'btnBack
        '
        Me.btnBack.AllowShowFocusCues = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(70, 204)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        CType(Me.btnBack.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Back"
        CType(Me.btnBack.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Shape = Me.ellipseShape1
        '
        'ShapedForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 260)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlTitle)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundImage", Me.albumsBindingSource, "Image", True))
        Me.Name = "ShapedForm1"
        Me.Shape = Me.donutShape1
        Me.Text = "ShapedForm1"
        CType(Me.pnlTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private donutShape1 As Telerik.WinControls.Tests.DonutShape
    Private pnlTitle As Telerik.WinControls.UI.RadPanel
    Private roundRectShape1 As Telerik.WinControls.RoundRectShape
    Private musicCollectionDataSet As MusicCollectionDataSet
    Private WithEvents albumsBindingSource As System.Windows.Forms.BindingSource
    Private albumsTableAdapter As ShapedFormWalkthrough.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
    Private WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Private ellipseShape1 As Telerik.WinControls.EllipseShape
    Private WithEvents btnInfo As Telerik.WinControls.UI.RadButton
    Private WithEvents btnBack As Telerik.WinControls.UI.RadButton
    Private aquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
End Class
