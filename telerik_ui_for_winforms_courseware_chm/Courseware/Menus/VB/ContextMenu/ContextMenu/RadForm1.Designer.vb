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
        Me.radContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager
        Me.pnlWrappingPaper = New Telerik.WinControls.UI.RadPanel
        Me.cmWrapping = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.tbGiftType = New Telerik.WinControls.UI.RadTextBox
        Me.cmGiftType = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.miGiftType1 = New Telerik.WinControls.UI.RadMenuItem
        Me.miGiftType2 = New Telerik.WinControls.UI.RadMenuItem
        Me.miGiftType3 = New Telerik.WinControls.UI.RadMenuItem
        Me.miGiftType4 = New Telerik.WinControls.UI.RadMenuItem
        Me.lblDeliveryMethod = New System.Windows.Forms.Label
        Me.cmDeliveryMethod = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.mbiDeliveryMethod1 = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.mbiDeliveryMethod2 = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.mbiDeliveryMethod3 = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.mbiDeliveryMethod4 = New Telerik.WinControls.UI.RadMenuButtonItem
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        CType(Me.pnlWrappingPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGiftType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlWrappingPaper
        '
        Me.pnlWrappingPaper.BackColor = System.Drawing.Color.Transparent
        Me.pnlWrappingPaper.Location = New System.Drawing.Point(21, 89)
        Me.pnlWrappingPaper.Name = "pnlWrappingPaper"
        Me.radContextMenuManager1.SetRadContextMenu(Me.pnlWrappingPaper, Me.cmWrapping)
        Me.pnlWrappingPaper.Size = New System.Drawing.Size(260, 109)
        Me.pnlWrappingPaper.TabIndex = 10
        Me.pnlWrappingPaper.Text = "Right-click to choose wrapping paper"
        '
        'tbGiftType
        '
        Me.tbGiftType.BackColor = System.Drawing.Color.Transparent
        Me.tbGiftType.Location = New System.Drawing.Point(90, 31)
        Me.tbGiftType.Name = "tbGiftType"
        Me.tbGiftType.NullText = "Right-click to enter a gift type"
        Me.radContextMenuManager1.SetRadContextMenu(Me.tbGiftType, Me.cmGiftType)
        Me.tbGiftType.ReadOnly = True
        Me.tbGiftType.Size = New System.Drawing.Size(190, 20)
        Me.tbGiftType.TabIndex = 9
        Me.tbGiftType.ThemeName = "Office2007Silver"
        '
        'cmGiftType
        '
        Me.cmGiftType.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miGiftType1, Me.miGiftType2, Me.miGiftType3, Me.miGiftType4})
        '
        'miGiftType1
        '
        Me.miGiftType1.Name = "miGiftType1"
        Me.miGiftType1.Text = "Birthday"
        '
        'miGiftType2
        '
        Me.miGiftType2.Name = "miGiftType2"
        Me.miGiftType2.Text = "Anniversary"
        '
        'miGiftType3
        '
        Me.miGiftType3.Name = "miGiftType3"
        Me.miGiftType3.Text = "Get Well Soon"
        '
        'miGiftType4
        '
        Me.miGiftType4.Name = "miGiftType4"
        Me.miGiftType4.Text = "Thank You"
        '
        'lblDeliveryMethod
        '
        Me.lblDeliveryMethod.BackColor = System.Drawing.Color.Transparent
        Me.lblDeliveryMethod.Location = New System.Drawing.Point(18, 219)
        Me.lblDeliveryMethod.MinimumSize = New System.Drawing.Size(260, 50)
        Me.lblDeliveryMethod.Name = "lblDeliveryMethod"
        Me.radContextMenuManager1.SetRadContextMenu(Me.lblDeliveryMethod, Me.cmDeliveryMethod)
        Me.lblDeliveryMethod.Size = New System.Drawing.Size(260, 50)
        Me.lblDeliveryMethod.TabIndex = 8
        Me.lblDeliveryMethod.Text = "Right-click to choose delivery method"
        '
        'cmDeliveryMethod
        '
        Me.cmDeliveryMethod.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mbiDeliveryMethod1, Me.mbiDeliveryMethod2, Me.mbiDeliveryMethod3, Me.mbiDeliveryMethod4})
        '
        'mbiDeliveryMethod1
        '
        '
        '
        '
        Me.mbiDeliveryMethod1.ButtonElement.Class = "RadMenuButtonElement"
        Me.mbiDeliveryMethod1.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mbiDeliveryMethod1.Name = "mbiDeliveryMethod1"
        Me.mbiDeliveryMethod1.Text = "Priority Overnight"
        CType(Me.mbiDeliveryMethod1.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.mbiDeliveryMethod1.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'mbiDeliveryMethod2
        '
        '
        '
        '
        Me.mbiDeliveryMethod2.ButtonElement.Class = "RadMenuButtonElement"
        Me.mbiDeliveryMethod2.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mbiDeliveryMethod2.Name = "mbiDeliveryMethod2"
        Me.mbiDeliveryMethod2.Text = "Standard Overnight"
        CType(Me.mbiDeliveryMethod2.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.mbiDeliveryMethod2.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'mbiDeliveryMethod3
        '
        '
        '
        '
        Me.mbiDeliveryMethod3.ButtonElement.Class = "RadMenuButtonElement"
        Me.mbiDeliveryMethod3.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mbiDeliveryMethod3.Name = "mbiDeliveryMethod3"
        Me.mbiDeliveryMethod3.Text = "2 Day"
        CType(Me.mbiDeliveryMethod3.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.mbiDeliveryMethod3.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'mbiDeliveryMethod4
        '
        '
        '
        '
        Me.mbiDeliveryMethod4.ButtonElement.Class = "RadMenuButtonElement"
        Me.mbiDeliveryMethod4.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.mbiDeliveryMethod4.Name = "mbiDeliveryMethod4"
        Me.mbiDeliveryMethod4.Text = "3 Day"
        CType(Me.mbiDeliveryMethod4.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.mbiDeliveryMethod4.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Class = "RadMenuButtonElement"
        '
        'radLabel1
        '
        Me.radLabel1.BackColor = System.Drawing.Color.Transparent
        Me.radLabel1.Location = New System.Drawing.Point(19, 31)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(50, 14)
        Me.radLabel1.TabIndex = 11
        Me.radLabel1.Text = "Gift Type"
        Me.radLabel1.ThemeName = "Office2007Silver"
        '
        'radLabel2
        '
        Me.radLabel2.BackColor = System.Drawing.Color.Transparent
        Me.radLabel2.Location = New System.Drawing.Point(20, 69)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(86, 14)
        Me.radLabel2.TabIndex = 12
        Me.radLabel2.Text = "Wrapping Paper"
        Me.radLabel2.ThemeName = "Office2007Silver"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 279)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.pnlWrappingPaper)
        Me.Controls.Add(Me.tbGiftType)
        Me.Controls.Add(Me.lblDeliveryMethod)
        Me.Name = "RadForm1"
        Me.Text = "Context Menus"
        Me.ThemeName = "Office2007Silver"
        CType(Me.pnlWrappingPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGiftType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
    Private cmDeliveryMethod As Telerik.WinControls.UI.RadContextMenu
    Private cmWrapping As Telerik.WinControls.UI.RadContextMenu
    Private cmGiftType As Telerik.WinControls.UI.RadContextMenu
    Private pnlWrappingPaper As Telerik.WinControls.UI.RadPanel
    Private tbGiftType As Telerik.WinControls.UI.RadTextBox
    Private WithEvents miGiftType1 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miGiftType2 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miGiftType3 As Telerik.WinControls.UI.RadMenuItem
    Private WithEvents miGiftType4 As Telerik.WinControls.UI.RadMenuItem

    Private WithEvents mbiDeliveryMethod1 As Telerik.WinControls.UI.RadMenuButtonItem
    Private WithEvents mbiDeliveryMethod2 As Telerik.WinControls.UI.RadMenuButtonItem
    Private WithEvents mbiDeliveryMethod3 As Telerik.WinControls.UI.RadMenuButtonItem
    Private WithEvents mbiDeliveryMethod4 As Telerik.WinControls.UI.RadMenuButtonItem
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private lblDeliveryMethod As System.Windows.Forms.Label
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme

End Class
