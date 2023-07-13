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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.tbContent = New System.Windows.Forms.RichTextBox
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.miAbout = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem
        Me.miItalic = New Telerik.WinControls.UI.RadMenuItem
        Me.miBold = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem
        Me.miPaste = New Telerik.WinControls.UI.RadMenuItem
        Me.miCopy = New Telerik.WinControls.UI.RadMenuItem
        Me.miCut = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem
        Me.miQuit = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem
        Me.miSave = New Telerik.WinControls.UI.RadMenuItem
        Me.miOpen = New Telerik.WinControls.UI.RadMenuItem
        Me.miNew = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem
        Me.radMenu1 = New Telerik.WinControls.UI.RadMenu
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.tbContent.Location = New System.Drawing.Point(8, 28)
        Me.tbContent.Name = "tbContent"
        Me.tbContent.ShowSelectionMargin = True
        Me.tbContent.Size = New System.Drawing.Size(534, 242)
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
        'miAbout
        '
        Me.miAbout.AccessibleDescription = "About"
        Me.miAbout.AccessibleName = "About"
        Me.miAbout.Class = ""
        Me.miAbout.ImageKey = "help.png"
        Me.miAbout.Name = "miAbout"
        Me.miAbout.Text = "About"
        Me.miAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miAbout.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuItem4
        '
        Me.radMenuItem4.AccessibleDescription = "Help"
        Me.radMenuItem4.AccessibleName = "Help"
        Me.radMenuItem4.Class = ""
        Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miAbout})
        Me.radMenuItem4.Name = "radMenuItem4"
        Me.radMenuItem4.Text = "Help"
        Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miItalic
        '
        Me.miItalic.AccessibleDescription = "Italic"
        Me.miItalic.AccessibleName = "Italic"
        Me.miItalic.CheckOnClick = True
        Me.miItalic.Class = ""
        Me.miItalic.ImageKey = "ItalicHS.png"
        Me.miItalic.Name = "miItalic"
        Me.miItalic.Text = "Italic"
        Me.miItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miItalic.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miBold
        '
        Me.miBold.AccessibleDescription = "Bold"
        Me.miBold.AccessibleName = "Bold"
        Me.miBold.CheckOnClick = True
        Me.miBold.Class = ""
        Me.miBold.ImageKey = "boldhs.png"
        Me.miBold.Name = "miBold"
        Me.miBold.Text = "Bold"
        Me.miBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miBold.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuItem3
        '
        Me.radMenuItem3.AccessibleDescription = "Format"
        Me.radMenuItem3.AccessibleName = "Format"
        Me.radMenuItem3.Class = ""
        Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miBold, Me.miItalic})
        Me.radMenuItem3.Name = "radMenuItem3"
        Me.radMenuItem3.Text = "Format"
        Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miPaste
        '
        Me.miPaste.AccessibleDescription = "Paste"
        Me.miPaste.AccessibleName = "Paste"
        Me.miPaste.Class = ""
        Me.miPaste.ImageKey = "paste.png"
        Me.miPaste.Name = "miPaste"
        Me.miPaste.Text = "Paste"
        Me.miPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miPaste.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miCopy
        '
        Me.miCopy.AccessibleDescription = "Copy"
        Me.miCopy.AccessibleName = "Copy"
        Me.miCopy.Class = ""
        Me.miCopy.ImageKey = "copy.png"
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Text = "Copy"
        Me.miCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miCopy.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miCut
        '
        Me.miCut.AccessibleDescription = "Cut"
        Me.miCut.AccessibleName = "Cut"
        Me.miCut.Class = ""
        Me.miCut.ImageKey = "cut.png"
        Me.miCut.Name = "miCut"
        Me.miCut.Text = "Cut"
        Me.miCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miCut.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuItem2
        '
        Me.radMenuItem2.AccessibleDescription = "Edit"
        Me.radMenuItem2.AccessibleName = "Edit"
        Me.radMenuItem2.Class = ""
        Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCut, Me.miCopy, Me.miPaste})
        Me.radMenuItem2.Name = "radMenuItem2"
        Me.radMenuItem2.Text = "Edit"
        Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miQuit
        '
        Me.miQuit.AccessibleDescription = "Quit"
        Me.miQuit.AccessibleName = "Quit"
        Me.miQuit.Class = ""
        Me.miQuit.Name = "miQuit"
        Me.miQuit.Padding = New System.Windows.Forms.Padding(3)
        Me.miQuit.Text = "Quit"
        Me.miQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miQuit.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuSeparatorItem1
        '
        Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
        Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
        Me.radMenuSeparatorItem1.Class = ""
        Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
        Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
        Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miSave
        '
        Me.miSave.AccessibleDescription = "Save"
        Me.miSave.AccessibleName = "Save"
        Me.miSave.Class = ""
        Me.miSave.ImageKey = "FloppyDisk.png"
        Me.miSave.Name = "miSave"
        Me.miSave.Padding = New System.Windows.Forms.Padding(3)
        Me.miSave.Text = "Save"
        Me.miSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miSave.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miOpen
        '
        Me.miOpen.AccessibleDescription = "Open"
        Me.miOpen.AccessibleName = "Open"
        Me.miOpen.Class = ""
        Me.miOpen.ImageKey = "Folder_Open.png"
        Me.miOpen.Name = "miOpen"
        Me.miOpen.Padding = New System.Windows.Forms.Padding(3)
        Me.miOpen.Text = "Open"
        Me.miOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'miNew
        '
        Me.miNew.AccessibleDescription = "New"
        Me.miNew.AccessibleName = "New"
        Me.miNew.BackColor = System.Drawing.Color.Red
        Me.miNew.ImageKey = "NewDocumentHS.png"
        Me.miNew.Name = "miNew"
        Me.miNew.Padding = New System.Windows.Forms.Padding(3)
        Me.miNew.Text = "New"
        Me.miNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miNew.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenuItem1
        '
        Me.radMenuItem1.AccessibleDescription = "File"
        Me.radMenuItem1.AccessibleName = "File"
        Me.radMenuItem1.Class = ""
        Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miNew, Me.miOpen, Me.miSave, Me.radMenuSeparatorItem1, Me.miQuit})
        Me.radMenuItem1.Name = "radMenuItem1"
        Me.radMenuItem1.Text = "File"
        Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radMenu1
        '
        Me.radMenu1.ImageList = Me.imageList1
        Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4})
        Me.radMenu1.Location = New System.Drawing.Point(0, 0)
        Me.radMenu1.Name = "radMenu1"
        Me.radMenu1.Size = New System.Drawing.Size(550, 28)
        Me.radMenu1.TabIndex = 0
        Me.radMenu1.Text = "radMenu1"
        Me.radMenu1.ThemeName = "Office2007Silver"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 279)
        Me.Controls.Add(Me.tbContent)
        Me.Controls.Add(Me.radMenu1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Menus"
        Me.ThemeName = "Office2007Silver"
        CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents tbContent As System.Windows.Forms.RichTextBox
    Private imageList1 As System.Windows.Forms.ImageList
    Private WithEvents miAbout As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miItalic As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miBold As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miPaste As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miCopy As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miCut As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miQuit As Telerik.WinControls.UI.RadMenuItem
    Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Private WithEvents miSave As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miOpen As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miNew As Telerik.WinControls.UI.RadMenuItem
    Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Private radMenu1 As Telerik.WinControls.UI.RadMenu
End Class
