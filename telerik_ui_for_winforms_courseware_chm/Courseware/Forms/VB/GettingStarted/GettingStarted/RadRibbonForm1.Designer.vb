Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadRibbonForm1
    Inherits RadRibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadRibbonForm1))
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRibbonBar1
        '
        Me.RadRibbonBar1.AutoSize = True
        Me.RadRibbonBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.RadRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadRibbonBar1.EnableKeyMap = True
        '
        '
        '
        Me.RadRibbonBar1.ExitButton.AccessibleDescription = "Exit"
        Me.RadRibbonBar1.ExitButton.AccessibleName = "Exit"
        '
        '
        '
        Me.RadRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit"
        Me.RadRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit"
        Me.RadRibbonBar1.ExitButton.ButtonElement.Class = "RadMenuButtonElement"
        Me.RadRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadRibbonBar1.ExitButton.Text = "Exit"
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        '
        '
        '
        Me.RadRibbonBar1.OptionsButton.AccessibleDescription = "Options"
        Me.RadRibbonBar1.OptionsButton.AccessibleName = "Options"
        '
        '
        '
        Me.RadRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options"
        Me.RadRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options"
        Me.RadRibbonBar1.OptionsButton.ButtonElement.Class = "RadMenuButtonElement"
        Me.RadRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadRibbonBar1.OptionsButton.Text = "Options"
        '
        '
        '
        Me.RadRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.RadRibbonBar1.Size = New System.Drawing.Size(458, 144)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "RadRibbonForm1"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.AutoSize = True
        Me.RadStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 409)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(458, 26)
        Me.RadStatusStrip1.SizingGrip = False
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 265)
        Me.Panel1.TabIndex = 2
        '
        'RadRibbonForm1
        '
        Me.AllowAero = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.Name = "RadRibbonForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadRibbonForm1"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
