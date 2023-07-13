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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarStripElement3 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.btnNew = New Telerik.WinControls.UI.CommandBarButton
        Me.btnOpen = New Telerik.WinControls.UI.CommandBarButton
        Me.btnSave = New Telerik.WinControls.UI.CommandBarButton
        Me.btnPrint = New Telerik.WinControls.UI.CommandBarButton
        Me.tbTwoSidedPrint = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.btnHelp = New Telerik.WinControls.UI.CommandBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.ImageList = Me.ImageList1
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1, Me.CommandBarRowElement2})
        Me.RadCommandBar1.Size = New System.Drawing.Size(363, 105)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1, Me.CommandBarStripElement2})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnNew, Me.btnOpen, Me.btnSave})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.AutoSize = True
        Me.RadStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 302)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(363, 26)
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 105)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(363, 197)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.DisplayName = Nothing
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement3})
        '
        'CommandBarStripElement2
        '
        Me.CommandBarStripElement2.DisplayName = "CommandBarStripElement2"
        Me.CommandBarStripElement2.FloatingForm = Nothing
        Me.CommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnPrint, Me.tbTwoSidedPrint})
        Me.CommandBarStripElement2.Name = "CommandBarStripElement2"
        Me.CommandBarStripElement2.Text = ""
        '
        'CommandBarStripElement3
        '
        Me.CommandBarStripElement3.DisplayName = "CommandBarStripElement3"
        Me.CommandBarStripElement3.FloatingForm = Nothing
        Me.CommandBarStripElement3.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnHelp})
        Me.CommandBarStripElement3.Name = "CommandBarStripElement3"
        Me.CommandBarStripElement3.Text = ""
        '
        'btnNew
        '
        Me.btnNew.AccessibleDescription = "CommandBarButton1"
        Me.btnNew.AccessibleName = "CommandBarButton1"
        Me.btnNew.DisplayName = "CommandBarButton1"
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageIndex = 0
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Text = "CommandBarButton1"
        Me.btnNew.ToolTipText = "File New"
        Me.btnNew.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnNew.VisibleInOverflowMenu = True
        '
        'btnOpen
        '
        Me.btnOpen.AccessibleDescription = "CommandBarButton2"
        Me.btnOpen.AccessibleName = "CommandBarButton2"
        Me.btnOpen.DisplayName = "CommandBarButton2"
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageIndex = 1
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Text = "CommandBarButton2"
        Me.btnOpen.ToolTipText = "File Open"
        Me.btnOpen.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnOpen.VisibleInOverflowMenu = True
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = "CommandBarButton3"
        Me.btnSave.AccessibleName = "CommandBarButton3"
        Me.btnSave.DisplayName = "CommandBarButton3"
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = 2
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "CommandBarButton3"
        Me.btnSave.ToolTipText = "File Save"
        Me.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnSave.VisibleInOverflowMenu = True
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleDescription = "CommandBarButton4"
        Me.btnPrint.AccessibleName = "CommandBarButton4"
        Me.btnPrint.DisplayName = "CommandBarButton4"
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageIndex = 3
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Text = "CommandBarButton4"
        Me.btnPrint.ToolTipText = "Print"
        Me.btnPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnPrint.VisibleInOverflowMenu = True
        '
        'tbTwoSidedPrint
        '
        Me.tbTwoSidedPrint.AccessibleDescription = "Two Sided Print"
        Me.tbTwoSidedPrint.AccessibleName = "Two Sided Print"
        Me.tbTwoSidedPrint.DisplayName = "CommandBarToggleButton1"
        Me.tbTwoSidedPrint.DrawText = True
        Me.tbTwoSidedPrint.Image = Nothing
        Me.tbTwoSidedPrint.Name = "tbTwoSidedPrint"
        Me.tbTwoSidedPrint.Text = "Two Sided Print"
        Me.tbTwoSidedPrint.ToolTipText = "Two Sided Print"
        Me.tbTwoSidedPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.tbTwoSidedPrint.VisibleInOverflowMenu = True
        '
        'btnHelp
        '
        Me.btnHelp.AccessibleDescription = "CommandBarButton5"
        Me.btnHelp.AccessibleName = "CommandBarButton5"
        Me.btnHelp.DisplayName = "CommandBarButton5"
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageIndex = 4
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Text = "CommandBarButton5"
        Me.btnHelp.ToolTipText = "Help"
        Me.btnHelp.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnHelp.VisibleInOverflowMenu = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "New.png")
        Me.ImageList1.Images.SetKeyName(1, "Open.png")
        Me.ImageList1.Images.SetKeyName(2, "Save.png")
        Me.ImageList1.Images.SetKeyName(3, "Print.png")
        Me.ImageList1.Images.SetKeyName(4, "Help.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 328)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents CommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarStripElement3 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnNew As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnOpen As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnPrint As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents tbTwoSidedPrint As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents btnHelp As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
