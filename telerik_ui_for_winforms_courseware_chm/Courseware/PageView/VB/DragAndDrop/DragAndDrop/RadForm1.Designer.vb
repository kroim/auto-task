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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.radTabStrip1 = New Telerik.WinControls.UI.RadTabStrip()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tiCast = New Telerik.WinControls.UI.TabItem()
        Me.tiTeaser = New Telerik.WinControls.UI.TabItem()
        Me.tiAct1 = New Telerik.WinControls.UI.TabItem()
        Me.tiNewAct = New Telerik.WinControls.UI.TabItem()
        Me.tiTag = New Telerik.WinControls.UI.TabItem()
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
        Me.miscellaneousTheme1 = New Telerik.WinControls.Themes.MiscellaneousTheme()
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.aquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
        CType(Me.radTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radTabStrip1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radTabStrip1
        ' 
        Me.radTabStrip1.AllowDragDrop = True
        Me.radTabStrip1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.radTabStrip1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.radTabStrip1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(244))))))
        Me.radTabStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTabStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
        Me.radTabStrip1.ImageList = Me.imageList1
        Me.radTabStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tiCast, Me.tiTeaser, Me.tiAct1, Me.tiNewAct, Me.tiTag})
        Me.radTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.radTabStrip1.Name = "radTabStrip1"
        Me.radTabStrip1.ScrollOffsetStep = 5
        Me.radTabStrip1.ShowOverFlowButton = True
        Me.radTabStrip1.Size = New System.Drawing.Size(446, 384)
        Me.radTabStrip1.TabDropDownButtonPosition = Telerik.WinControls.UI.TabItemsDropDownButtonPosition.LeftTop
        Me.radTabStrip1.TabIndex = 0
        Me.radTabStrip1.TabScrollButtonsPosition = Telerik.WinControls.UI.TabScrollButtonsPosition.RightBottom
        Me.radTabStrip1.TabsPosition = Telerik.WinControls.UI.TabPositions.Left
        Me.radTabStrip1.Text = "radTabStrip1"
        Me.radTabStrip1.TextOrientation = System.Windows.Forms.Orientation.Vertical
        Me.radTabStrip1.ThemeName = "IE7"
        '	  Me.radTabStrip1.TabDragEnding += New Telerik.WinControls.UI.TabDragCancelEventHandler(Me.radTabStrip1_TabDragEnding);
        '	  Me.radTabStrip1.TabDragStarting += New Telerik.WinControls.UI.TabDragCancelEventHandler(Me.radTabStrip1_TabDragStarting);
        '	  Me.radTabStrip1.TabDragEnded += New Telerik.WinControls.UI.TabDragEventHandler(Me.radTabStrip1_TabDragEnded);
        ' 
        ' imageList1
        ' 
        Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "Users.png")
        Me.imageList1.Images.SetKeyName(1, "Annotation_New.png")
        Me.imageList1.Images.SetKeyName(2, "copy.png")
        Me.imageList1.Images.SetKeyName(3, "Journal.png")
        ' 
        ' tiCast
        ' 
        Me.tiCast.Alignment = System.Drawing.ContentAlignment.TopRight
        Me.tiCast.AngleTransform = 270.0F
        Me.tiCast.CanFocus = True
        Me.tiCast.Class = "TabItem"
        ' 
        ' tiCast.ContentPanel
        ' 
        Me.tiCast.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.tiCast.ContentPanel.CausesValidation = True
        Me.tiCast.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
        Me.tiCast.Image = (CType(resources.GetObject("tiCast.Image"), System.Drawing.Image))
        Me.tiCast.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.tiCast.ImageKey = "Users.png"
        Me.tiCast.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
        Me.tiCast.Name = "tiCast"
        Me.tiCast.StretchVertically = False
        Me.tiCast.Tag = "fixed"
        Me.tiCast.Text = "Cast of Characters"
        Me.tiCast.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.tiCast.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.tiCast.TextOrientation = System.Windows.Forms.Orientation.Vertical
        CType(Me.tiCast.GetChildAt(2), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).StretchHorizontally = False
        CType(Me.tiCast.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 90.0F
        ' 
        ' tiTeaser
        ' 
        Me.tiTeaser.Alignment = System.Drawing.ContentAlignment.TopRight
        Me.tiTeaser.AngleTransform = 270.0F
        Me.tiTeaser.CanFocus = True
        Me.tiTeaser.Class = "TabItem"
        ' 
        ' tiTeaser.ContentPanel
        ' 
        Me.tiTeaser.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.tiTeaser.ContentPanel.CausesValidation = True
        Me.tiTeaser.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
        Me.tiTeaser.Image = (CType(resources.GetObject("tiTeaser.Image"), System.Drawing.Image))
        Me.tiTeaser.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.tiTeaser.ImageKey = "Annotation_New.png"
        Me.tiTeaser.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
        Me.tiTeaser.Name = "tiTeaser"
        Me.tiTeaser.Tag = "fixed"
        Me.tiTeaser.Text = "Teaser"
        Me.tiTeaser.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.tiTeaser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.tiTeaser.TextOrientation = System.Windows.Forms.Orientation.Vertical
        CType(Me.tiTeaser.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).Alignment = System.Drawing.ContentAlignment.BottomLeft
        CType(Me.tiTeaser.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 90.0F
        ' 
        ' tiAct1
        ' 
        Me.tiAct1.Alignment = System.Drawing.ContentAlignment.TopRight
        Me.tiAct1.AngleTransform = 270.0F
        Me.tiAct1.CanFocus = True
        Me.tiAct1.Class = "TabItem"
        ' 
        ' tiAct1.ContentPanel
        ' 
        Me.tiAct1.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.tiAct1.ContentPanel.CausesValidation = True
        Me.tiAct1.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
        Me.tiAct1.Image = (CType(resources.GetObject("tiAct1.Image"), System.Drawing.Image))
        Me.tiAct1.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.tiAct1.ImageKey = "copy.png"
        Me.tiAct1.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
        Me.tiAct1.Name = "tiAct1"
        Me.tiAct1.StretchVertically = False
        Me.tiAct1.Tag = "act"
        Me.tiAct1.Text = "Act 1"
        Me.tiAct1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.tiAct1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.tiAct1.TextOrientation = System.Windows.Forms.Orientation.Vertical
        '	  Me.tiAct1.TextChanging += New Telerik.WinControls.TextChangingEventHandler(Me.ActTextChanging);
        '	  Me.tiAct1.DoubleClick += New System.EventHandler(Me.ActDoubleClick);
        CType(Me.tiAct1.GetChildAt(2), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).StretchHorizontally = False
        CType(Me.tiAct1.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).Alignment = System.Drawing.ContentAlignment.BottomLeft
        CType(Me.tiAct1.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 90.0F
        ' 
        ' tiNewAct
        ' 
        Me.tiNewAct.Alignment = System.Drawing.ContentAlignment.TopRight
        Me.tiNewAct.AngleTransform = 270.0F
        Me.tiNewAct.CanFocus = True
        Me.tiNewAct.Class = "TabItem"
        ' 
        ' tiNewAct.ContentPanel
        ' 
        Me.tiNewAct.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.tiNewAct.ContentPanel.CausesValidation = True
        Me.tiNewAct.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
        Me.tiNewAct.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.tiNewAct.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
        Me.tiNewAct.Name = "tiNewAct"
        Me.tiNewAct.Tag = "fixed"
        Me.tiNewAct.Text = " "
        Me.tiNewAct.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.tiNewAct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.tiNewAct.TextOrientation = System.Windows.Forms.Orientation.Vertical
        CType(Me.tiNewAct.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).Alignment = System.Drawing.ContentAlignment.BottomLeft
        CType(Me.tiNewAct.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 90.0F
        ' 
        ' tiTag
        ' 
        Me.tiTag.Alignment = System.Drawing.ContentAlignment.TopRight
        Me.tiTag.AngleTransform = 270.0F
        Me.tiTag.CanFocus = True
        Me.tiTag.Class = "TabItem"
        ' 
        ' tiTag.ContentPanel
        ' 
        Me.tiTag.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.tiTag.ContentPanel.CausesValidation = True
        Me.tiTag.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
        Me.tiTag.Image = (CType(resources.GetObject("tiTag.Image"), System.Drawing.Image))
        Me.tiTag.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.tiTag.ImageKey = "Journal.png"
        Me.tiTag.IsSelected = True
        Me.tiTag.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
        Me.tiTag.Name = "tiTag"
        Me.tiTag.StretchVertically = False
        Me.tiTag.Tag = "fixed"
        Me.tiTag.Text = "Tag"
        Me.tiTag.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.tiTag.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.tiTag.TextOrientation = System.Windows.Forms.Orientation.Vertical
        CType(Me.tiTag.GetChildAt(2), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).StretchHorizontally = False
        CType(Me.tiTag.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).Alignment = System.Drawing.ContentAlignment.BottomLeft
        CType(Me.tiTag.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 90.0F
        ' 
        ' RadForm1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 384)
        Me.Controls.Add(Me.radTabStrip1)
        Me.Name = "RadForm1"
        Me.Text = "Script  Creator"
        Me.ThemeName = "Office2007Silver"
        '	  Me.Load += New System.EventHandler(Me.RadForm1_Load);
        CType(Me.radTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radTabStrip1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents radTabStrip1 As Telerik.WinControls.UI.RadTabStrip
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Private miscellaneousTheme1 As Telerik.WinControls.Themes.MiscellaneousTheme
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Private tiTeaser As Telerik.WinControls.UI.TabItem
    Private WithEvents tiAct1 As Telerik.WinControls.UI.TabItem
    Private tiNewAct As Telerik.WinControls.UI.TabItem
    Private tiTag As Telerik.WinControls.UI.TabItem
    Private imageList1 As System.Windows.Forms.ImageList
    Private tiCast As Telerik.WinControls.UI.TabItem
    Private aquaTheme1 As Telerik.WinControls.Themes.AquaTheme
End Class
