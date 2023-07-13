Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        Me.radPageView1 = New Telerik.WinControls.UI.RadPageView
        Me.ilDriveTypes = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlTop = New Telerik.WinControls.UI.RadPanel
        Me.btnShow = New Telerik.WinControls.UI.RadToggleButton
        Me.btnSearch = New Telerik.WinControls.UI.RadButton
        Me.lblTotalSpace = New Telerik.WinControls.UI.RadLabel
        Me.radLabel6 = New Telerik.WinControls.UI.RadLabel
        Me.lblDriveName = New Telerik.WinControls.UI.RadLabel
        Me.radLabel5 = New Telerik.WinControls.UI.RadLabel
        Me.lblDriveType = New Telerik.WinControls.UI.RadLabel
        Me.radLabel4 = New Telerik.WinControls.UI.RadLabel
        Me.lblDriveFormat = New Telerik.WinControls.UI.RadLabel
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel
        Me.lblVolumeLabel = New Telerik.WinControls.UI.RadLabel
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDriveName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDriveType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDriveFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVolumeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPageView1
        '
        Me.radPageView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.radPageView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.radPageView1.ImageList = Me.ilDriveTypes
        Me.radPageView1.Location = New System.Drawing.Point(13, 134)
        Me.radPageView1.Name = "radPageView1"
        Me.radPageView1.Size = New System.Drawing.Size(603, 179)
        Me.radPageView1.TabIndex = 1
        Me.radPageView1.Text = "radTabStrip1"
        Me.radPageView1.ThemeName = "Desert"
        '
        'ilDriveTypes
        '
        Me.ilDriveTypes.ImageStream = CType(resources.GetObject("ilDriveTypes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilDriveTypes.TransparentColor = System.Drawing.Color.Transparent
        Me.ilDriveTypes.Images.SetKeyName(0, "UnknownDrive.png")
        Me.ilDriveTypes.Images.SetKeyName(1, "EmptyDrive.png")
        Me.ilDriveTypes.Images.SetKeyName(2, "3.5_Disk_Drive.png")
        Me.ilDriveTypes.Images.SetKeyName(3, "Hard_Drive.png")
        Me.ilDriveTypes.Images.SetKeyName(4, "Network.png")
        Me.ilDriveTypes.Images.SetKeyName(5, "CD_ROM.png")
        Me.ilDriveTypes.Images.SetKeyName(6, "ram.png")
        Me.ilDriveTypes.Images.SetKeyName(7, "search.png")
        Me.ilDriveTypes.Images.SetKeyName(8, "DisconnectedDrive.png")
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.Controls.Add(Me.btnShow)
        Me.pnlTop.Controls.Add(Me.btnSearch)
        Me.pnlTop.Controls.Add(Me.lblTotalSpace)
        Me.pnlTop.Controls.Add(Me.radLabel6)
        Me.pnlTop.Controls.Add(Me.lblDriveName)
        Me.pnlTop.Controls.Add(Me.radLabel5)
        Me.pnlTop.Controls.Add(Me.lblDriveType)
        Me.pnlTop.Controls.Add(Me.radLabel4)
        Me.pnlTop.Controls.Add(Me.lblDriveFormat)
        Me.pnlTop.Controls.Add(Me.radLabel3)
        Me.pnlTop.Controls.Add(Me.lblVolumeLabel)
        Me.pnlTop.Controls.Add(Me.radLabel1)
        Me.pnlTop.Location = New System.Drawing.Point(12, 12)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(602, 108)
        Me.pnlTop.TabIndex = 2
        Me.pnlTop.ThemeName = "Desert"
        '
        'btnShow
        '
        Me.btnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShow.ImageKey = "DisconnectedDrive.png"
        Me.btnShow.ImageList = Me.ilDriveTypes
        Me.btnShow.Location = New System.Drawing.Point(380, 59)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(210, 40)
        Me.btnShow.TabIndex = 11
        Me.btnShow.Text = "Show Disconnected Drives?"
        Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShow.ThemeName = "Desert"
        Me.btnShow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ImageKey = "search.png"
        Me.btnSearch.ImageList = Me.ilDriveTypes
        Me.btnSearch.Location = New System.Drawing.Point(380, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(210, 40)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Find Max Free Space"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.ThemeName = "Desert"
        '
        'lblTotalSpace
        '
        Me.lblTotalSpace.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSpace.Location = New System.Drawing.Point(88, 59)
        Me.lblTotalSpace.Name = "lblTotalSpace"
        Me.lblTotalSpace.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblTotalSpace.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblTotalSpace.Size = New System.Drawing.Size(17, 16)
        Me.lblTotalSpace.TabIndex = 9
        Me.lblTotalSpace.Text = "x"
        Me.lblTotalSpace.ThemeName = "Desert"
        '
        'radLabel6
        '
        Me.radLabel6.BackColor = System.Drawing.Color.Transparent
        Me.radLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel6.Location = New System.Drawing.Point(13, 59)
        Me.radLabel6.Name = "radLabel6"
        Me.radLabel6.Size = New System.Drawing.Size(72, 16)
        Me.radLabel6.TabIndex = 8
        Me.radLabel6.Text = "Total Space:"
        Me.radLabel6.ThemeName = "Desert"
        '
        'lblDriveName
        '
        Me.lblDriveName.BackColor = System.Drawing.Color.Transparent
        Me.lblDriveName.Location = New System.Drawing.Point(88, 15)
        Me.lblDriveName.Name = "lblDriveName"
        Me.lblDriveName.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblDriveName.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblDriveName.Size = New System.Drawing.Size(17, 16)
        Me.lblDriveName.TabIndex = 7
        Me.lblDriveName.Text = "x"
        Me.lblDriveName.ThemeName = "Desert"
        '
        'radLabel5
        '
        Me.radLabel5.BackColor = System.Drawing.Color.Transparent
        Me.radLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel5.Location = New System.Drawing.Point(13, 15)
        Me.radLabel5.Name = "radLabel5"
        Me.radLabel5.Size = New System.Drawing.Size(71, 16)
        Me.radLabel5.TabIndex = 6
        Me.radLabel5.Text = "Drive Name:"
        Me.radLabel5.ThemeName = "Desert"
        '
        'lblDriveType
        '
        Me.lblDriveType.BackColor = System.Drawing.Color.Transparent
        Me.lblDriveType.Location = New System.Drawing.Point(223, 37)
        Me.lblDriveType.Name = "lblDriveType"
        Me.lblDriveType.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblDriveType.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblDriveType.Size = New System.Drawing.Size(17, 16)
        Me.lblDriveType.TabIndex = 5
        Me.lblDriveType.Text = "x"
        Me.lblDriveType.ThemeName = "Desert"
        '
        'radLabel4
        '
        Me.radLabel4.BackColor = System.Drawing.Color.Transparent
        Me.radLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel4.Location = New System.Drawing.Point(139, 37)
        Me.radLabel4.Name = "radLabel4"
        Me.radLabel4.Size = New System.Drawing.Size(66, 16)
        Me.radLabel4.TabIndex = 4
        Me.radLabel4.Text = "Drive Type:"
        Me.radLabel4.ThemeName = "Desert"
        '
        'lblDriveFormat
        '
        Me.lblDriveFormat.BackColor = System.Drawing.Color.Transparent
        Me.lblDriveFormat.Location = New System.Drawing.Point(88, 37)
        Me.lblDriveFormat.Name = "lblDriveFormat"
        Me.lblDriveFormat.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblDriveFormat.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblDriveFormat.Size = New System.Drawing.Size(17, 16)
        Me.lblDriveFormat.TabIndex = 3
        Me.lblDriveFormat.Text = "x"
        Me.lblDriveFormat.ThemeName = "Desert"
        '
        'radLabel3
        '
        Me.radLabel3.BackColor = System.Drawing.Color.Transparent
        Me.radLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel3.Location = New System.Drawing.Point(13, 37)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.radLabel3.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.radLabel3.Size = New System.Drawing.Size(83, 16)
        Me.radLabel3.TabIndex = 2
        Me.radLabel3.Text = "Drive Format:"
        Me.radLabel3.ThemeName = "Desert"
        '
        'lblVolumeLabel
        '
        Me.lblVolumeLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblVolumeLabel.Location = New System.Drawing.Point(223, 15)
        Me.lblVolumeLabel.Name = "lblVolumeLabel"
        Me.lblVolumeLabel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblVolumeLabel.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblVolumeLabel.Size = New System.Drawing.Size(17, 16)
        Me.lblVolumeLabel.TabIndex = 1
        Me.lblVolumeLabel.Text = "x"
        Me.lblVolumeLabel.ThemeName = "Desert"
        '
        'radLabel1
        '
        Me.radLabel1.BackColor = System.Drawing.Color.Transparent
        Me.radLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel1.Location = New System.Drawing.Point(139, 15)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.radLabel1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.radLabel1.Size = New System.Drawing.Size(86, 16)
        Me.radLabel1.TabIndex = 0
        Me.radLabel1.Text = "Volume Label:"
        Me.radLabel1.ThemeName = "Desert"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 325)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.radPageView1)
        Me.MinimumSize = New System.Drawing.Size(630, 350)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MinSize = New System.Drawing.Size(630, 350)
        Me.Text = "Drive Info"
        Me.ThemeName = "Desert"
        CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalSpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDriveName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDriveType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDriveFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVolumeLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Private WithEvents radPageView1 As Telerik.WinControls.UI.RadPageView
    Private ilDriveTypes As System.Windows.Forms.ImageList
    Private pnlTop As Telerik.WinControls.UI.RadPanel
    Private WithEvents btnShow As Telerik.WinControls.UI.RadToggleButton
    Private WithEvents btnSearch As Telerik.WinControls.UI.RadButton
    Private lblTotalSpace As Telerik.WinControls.UI.RadLabel
    Private radLabel6 As Telerik.WinControls.UI.RadLabel
    Private lblDriveName As Telerik.WinControls.UI.RadLabel
    Private radLabel5 As Telerik.WinControls.UI.RadLabel
    Private lblDriveType As Telerik.WinControls.UI.RadLabel
    Private radLabel4 As Telerik.WinControls.UI.RadLabel
    Private lblDriveFormat As Telerik.WinControls.UI.RadLabel
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private lblVolumeLabel As Telerik.WinControls.UI.RadLabel
    Private radLabel1 As Telerik.WinControls.UI.RadLabel

End Class
