<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.radRibbonBarCommandTab1 = New Telerik.WinControls.UI.RibbonTab
        Me.radRibbonBarChunk1 = New Telerik.WinControls.UI.RadRibbonBarGroup
        Me.miCut = New Telerik.WinControls.UI.RadButtonElement
        Me.miCopy = New Telerik.WinControls.UI.RadButtonElement
        Me.miPaste = New Telerik.WinControls.UI.RadButtonElement
        Me.radRibbonBarChunk2 = New Telerik.WinControls.UI.RadRibbonBarGroup
        Me.cbBold = New Telerik.WinControls.UI.RadCheckBoxElement
        Me.cbItalic = New Telerik.WinControls.UI.RadCheckBoxElement
        Me.tabItem1 = New Telerik.WinControls.UI.TabItem
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.tbContent = New System.Windows.Forms.RichTextBox
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar
        Me.qaOpen = New Telerik.WinControls.UI.RadButtonElement
        Me.qaSave = New Telerik.WinControls.UI.RadButtonElement
        Me.qaHelp = New Telerik.WinControls.UI.RadButtonElement
        Me.miNew = New Telerik.WinControls.UI.RadMenuItem
        Me.miOpen = New Telerik.WinControls.UI.RadMenuItem
        Me.miSave = New Telerik.WinControls.UI.RadMenuItem
        Me.office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme
        Me.btnExit = New Telerik.WinControls.UI.RadMenuButtonItem
        CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radRibbonBarCommandTab1
        '
        Me.radRibbonBarCommandTab1.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Me.radRibbonBarCommandTab1.CanFocus = True
        Me.radRibbonBarCommandTab1.Class = "TabItem"
        '
        'radRibbonBarCommandTab1.ContentPanel
        '
        Me.radRibbonBarCommandTab1.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.radRibbonBarCommandTab1.ContentPanel.CausesValidation = True
        Me.radRibbonBarCommandTab1.IsSelected = True
        Me.radRibbonBarCommandTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarChunk1, Me.radRibbonBarChunk2})
        Me.radRibbonBarCommandTab1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.radRibbonBarCommandTab1.Name = "radRibbonBarCommandTab1"
        Me.radRibbonBarCommandTab1.StretchHorizontally = False
        Me.radRibbonBarCommandTab1.Text = "Home"
        '
        'radRibbonBarChunk1
        '
        Me.radRibbonBarChunk1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCut, Me.miCopy, Me.miPaste})
        Me.radRibbonBarChunk1.Name = "radRibbonBarChunk1"
        Me.radRibbonBarChunk1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.radRibbonBarChunk1.SizeAfterCollapsing = New System.Drawing.SizeF(0.0!, 0.0!)
        Me.radRibbonBarChunk1.SizeBeforeCollapsing = New System.Drawing.SizeF(0.0!, 0.0!)
        Me.radRibbonBarChunk1.Text = "Clipboard"
        '
        'miCut
        '
        Me.miCut.CanFocus = True
        Me.miCut.Class = "ButtonElement"
        Me.miCut.Image = CType(resources.GetObject("miCut.Image"), System.Drawing.Image)
        Me.miCut.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.miCut.ImageKey = "cut.png"
        Me.miCut.Name = "miCut"
        Me.miCut.SmallImageKey = "cut.png"
        Me.miCut.StretchVertically = False
        Me.miCut.Text = "Cut"
        Me.miCut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'miCopy
        '
        Me.miCopy.CanFocus = True
        Me.miCopy.Class = "ButtonElement"
        Me.miCopy.Image = CType(resources.GetObject("miCopy.Image"), System.Drawing.Image)
        Me.miCopy.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.miCopy.ImageKey = "copy.png"
        Me.miCopy.Name = "miCopy"
        Me.miCopy.SmallImageKey = "copy.png"
        Me.miCopy.StretchVertically = False
        Me.miCopy.Text = "Copy"
        Me.miCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'miPaste
        '
        Me.miPaste.CanFocus = True
        Me.miPaste.Class = "ButtonElement"
        Me.miPaste.Image = CType(resources.GetObject("miPaste.Image"), System.Drawing.Image)
        Me.miPaste.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.miPaste.ImageKey = "paste.png"
        Me.miPaste.Name = "miPaste"
        Me.miPaste.SmallImageKey = "paste.png"
        Me.miPaste.StretchVertically = False
        Me.miPaste.Text = "Paste"
        Me.miPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'radRibbonBarChunk2
        '
        Me.radRibbonBarChunk2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.cbBold, Me.cbItalic})
        Me.radRibbonBarChunk2.Name = "radRibbonBarChunk2"
        Me.radRibbonBarChunk2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.radRibbonBarChunk2.SizeAfterCollapsing = New System.Drawing.SizeF(0.0!, 0.0!)
        Me.radRibbonBarChunk2.SizeBeforeCollapsing = New System.Drawing.SizeF(0.0!, 0.0!)
        Me.radRibbonBarChunk2.Text = "Font"
        '
        'cbBold
        '
        Me.cbBold.CanFocus = True
        Me.cbBold.Class = "RibbonBarButtonElement"
        Me.cbBold.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.cbBold.Image = CType(resources.GetObject("cbBold.Image"), System.Drawing.Image)
        Me.cbBold.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
        Me.cbBold.Name = "cbBold"
        Me.cbBold.ShowBorder = False
        Me.cbBold.StretchVertically = False
        Me.cbBold.Text = "Bold"
        '
        'cbItalic
        '
        Me.cbItalic.CanFocus = True
        Me.cbItalic.Class = "RibbonBarButtonElement"
        Me.cbItalic.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.cbItalic.Image = CType(resources.GetObject("cbItalic.Image"), System.Drawing.Image)
        Me.cbItalic.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
        Me.cbItalic.Name = "cbItalic"
        Me.cbItalic.ShowBorder = False
        Me.cbItalic.StretchVertically = False
        Me.cbItalic.Text = "Italic"
        '
        'tabItem1
        '
        Me.tabItem1.CanFocus = True
        Me.tabItem1.Class = "TabItem"
        '
        'tabItem1.ContentPanel
        '
        Me.tabItem1.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.tabItem1.ContentPanel.CausesValidation = True
        Me.tabItem1.IsSelected = True
        Me.tabItem1.Name = "tabItem1"
        Me.tabItem1.Text = "Home"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.Filter = "Rich Text Files|*.rtf"
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.Filter = "Rich Text Files|*.rtf"
        '
        'tbContent
        '
        Me.tbContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContent.HideSelection = False
        Me.tbContent.Location = New System.Drawing.Point(8, 159)
        Me.tbContent.Name = "tbContent"
        Me.tbContent.ShowSelectionMargin = True
        Me.tbContent.Size = New System.Drawing.Size(530, 189)
        Me.tbContent.TabIndex = 1
        Me.tbContent.Text = ""
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "NewDocumentHS.png")
        Me.imageList1.Images.SetKeyName(1, "Folder_Open.png")
        Me.imageList1.Images.SetKeyName(2, "FloppyDisk.png")
        Me.imageList1.Images.SetKeyName(3, "cut.png")
        Me.imageList1.Images.SetKeyName(4, "copy.png")
        Me.imageList1.Images.SetKeyName(5, "paste.png")
        Me.imageList1.Images.SetKeyName(6, "help.png")
        Me.imageList1.Images.SetKeyName(7, "boldhs.png")
        Me.imageList1.Images.SetKeyName(8, "ItalicHS.png")
        '
        'radRibbonBar1
        '
        Me.radRibbonBar1.AutoSize = True
        Me.radRibbonBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarCommandTab1})
        Me.radRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radRibbonBar1.EnableKeyMap = True
        '
        '
        '
        '
        '
        '
        Me.radRibbonBar1.ExitButton.ButtonElement.Class = "RadMenuButtonElement"
        Me.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.radRibbonBar1.ExitButton.Text = "Exit"
        Me.radRibbonBar1.ImageList = Me.imageList1
        Me.radRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.radRibbonBar1.Name = "radRibbonBar1"
        '
        '
        '
        '
        '
        '
        Me.radRibbonBar1.OptionsButton.ButtonElement.Class = "RadMenuButtonElement"
        Me.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.radRibbonBar1.OptionsButton.Text = "Options"
        Me.radRibbonBar1.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.radRibbonBar1.QuickAccessToolBarHeight = 40
        Me.radRibbonBar1.QuickAccessToolBarItems.AddRange(New Telerik.WinControls.RadItem() {Me.qaOpen, Me.qaSave, Me.qaHelp})
        '
        '
        '
        Me.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radRibbonBar1.Size = New System.Drawing.Size(550, 153)
        Me.radRibbonBar1.StartButtonImage = CType(resources.GetObject("radRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.radRibbonBar1.StartMenuItems.AddRange(New Telerik.WinControls.RadItem() {Me.miNew, Me.miOpen, Me.miSave})
        Me.radRibbonBar1.TabIndex = 2
        Me.radRibbonBar1.Text = "radRibbonBar2"
        Me.radRibbonBar1.ThemeName = "Office2007Black"
        '
        'qaOpen
        '
        Me.qaOpen.CanFocus = True
        Me.qaOpen.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.qaOpen.Image = CType(resources.GetObject("qaOpen.Image"), System.Drawing.Image)
        Me.qaOpen.ImageKey = "Folder_Open.png"
        Me.qaOpen.MaxSize = New System.Drawing.Size(0, 18)
        Me.qaOpen.Name = "qaOpen"
        Me.qaOpen.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.qaOpen.Text = "Open"
        Me.qaOpen.ZIndex = 3
        '
        'qaSave
        '
        Me.qaSave.CanFocus = True
        Me.qaSave.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.qaSave.Image = CType(resources.GetObject("qaSave.Image"), System.Drawing.Image)
        Me.qaSave.ImageKey = "FloppyDisk.png"
        Me.qaSave.MaxSize = New System.Drawing.Size(0, 18)
        Me.qaSave.Name = "qaSave"
        Me.qaSave.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.qaSave.Text = "Save"
        Me.qaSave.ZIndex = 2
        '
        'qaHelp
        '
        Me.qaHelp.CanFocus = True
        Me.qaHelp.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.qaHelp.Image = CType(resources.GetObject("qaHelp.Image"), System.Drawing.Image)
        Me.qaHelp.ImageKey = "help.png"
        Me.qaHelp.MaxSize = New System.Drawing.Size(0, 18)
        Me.qaHelp.Name = "qaHelp"
        Me.qaHelp.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.qaHelp.Text = "Help"
        Me.qaHelp.ZIndex = 1
        '
        'miNew
        '
        Me.miNew.ImageKey = "NewDocumentHS.png"
        Me.miNew.Name = "miNew"
        Me.miNew.Text = "New"
        '
        'miOpen
        '
        Me.miOpen.ImageKey = "Folder_Open.png"
        Me.miOpen.Name = "miOpen"
        Me.miOpen.Text = "Open"
        '
        'miSave
        '
        Me.miSave.ImageKey = "FloppyDisk.png"
        Me.miSave.Name = "miSave"
        Me.miSave.Text = "Save"
        '
        'btnExit
        '
        '
        '
        '
        Me.btnExit.ButtonElement.Class = "RadMenuButtonElement"
        Me.btnExit.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Text = "Exit"
        CType(Me.btnExit.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnExit.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 357)
        Me.Controls.Add(Me.radRibbonBar1)
        Me.Controls.Add(Me.tbContent)
        Me.Name = "Form1"
        Me.Text = "radRibbonBar2"
        Me.ThemeName = "Office2007Black"
        CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents tbContent As System.Windows.Forms.RichTextBox
    Private imageList1 As System.Windows.Forms.ImageList
    Private WithEvents radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Private office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Private radRibbonBarChunk1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Private radRibbonBarChunk2 As Telerik.WinControls.UI.RadRibbonBarGroup
    Private tabItem1 As Telerik.WinControls.UI.TabItem
    Private WithEvents qaOpen As Telerik.WinControls.UI.RadButtonElement
    Private WithEvents qaSave As Telerik.WinControls.UI.RadButtonElement
    Private WithEvents qaHelp As Telerik.WinControls.UI.RadButtonElement
    Private WithEvents miNew As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miOpen As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miSave As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miCut As Telerik.WinControls.UI.RadButtonElement
    Private WithEvents miCopy As Telerik.WinControls.UI.RadButtonElement
    Private WithEvents miPaste As Telerik.WinControls.UI.RadButtonElement
    Private btnExit As Telerik.WinControls.UI.RadMenuButtonItem
    Private WithEvents cbBold As Telerik.WinControls.UI.RadCheckBoxElement
    Private WithEvents cbItalic As Telerik.WinControls.UI.RadCheckBoxElement
    Friend WithEvents radRibbonBarCommandTab1 As Telerik.WinControls.UI.RibbonTab

End Class
