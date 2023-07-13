<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim CarouselEllipsePath1 As Telerik.WinControls.UI.CarouselEllipsePath = New Telerik.WinControls.UI.CarouselEllipsePath
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.RadRotator1 = New Telerik.WinControls.UI.RadRotator
        Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement
        Me.RadButtonElement2 = New Telerik.WinControls.UI.RadButtonElement
        Me.RadButtonElement3 = New Telerik.WinControls.UI.RadButtonElement
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow
        Me.RadCarousel1 = New Telerik.WinControls.UI.RadCarousel
        Me.RadButtonElement4 = New Telerik.WinControls.UI.RadButtonElement
        Me.RadButtonElement5 = New Telerik.WinControls.UI.RadButtonElement
        Me.RadButtonElement6 = New Telerik.WinControls.UI.RadButtonElement
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        Me.ToolWindow2.SuspendLayout()
        CType(Me.RadRotator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.RadCarousel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow1
        Me.RadDock1.CausesValidation = False
        Me.RadDock1.Controls.Add(Me.RadSplitContainer1)
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDock1.Size = New System.Drawing.Size(692, 466)
        Me.RadDock1.SplitterWidth = 4
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        Me.RadDock1.ThemeName = "Office2010Silver"
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Controls.Add(Me.RadCarousel1)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(198, 204)
        Me.ToolWindow1.Text = "RadCarousel"
        '
        'RadSplitContainer1
        '
        Me.RadSplitContainer1.CausesValidation = False
        Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip1)
        Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip2)
        Me.RadSplitContainer1.IsCleanUpTarget = True
        Me.RadSplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.RadSplitContainer1.Name = "RadSplitContainer1"
        Me.RadSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(200, 456)
        Me.RadSplitContainer1.SplitterWidth = 4
        Me.RadSplitContainer1.TabIndex = 1
        Me.RadSplitContainer1.TabStop = False
        Me.RadSplitContainer1.ThemeName = "Office2010Silver"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(200, 226)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        Me.ToolTabStrip1.ThemeName = "Office2010Silver"
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.CausesValidation = False
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(0, 230)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(200, 226)
        Me.ToolTabStrip2.TabIndex = 0
        Me.ToolTabStrip2.TabStop = False
        Me.ToolTabStrip2.ThemeName = "Office2010Silver"
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Controls.Add(Me.RadRotator1)
        Me.ToolWindow2.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.Size = New System.Drawing.Size(198, 204)
        Me.ToolWindow2.Text = "RadRotator"
        '
        'RadRotator1
        '
        Me.RadRotator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadRotator1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1, Me.RadButtonElement2, Me.RadButtonElement3})
        Me.RadRotator1.Location = New System.Drawing.Point(0, 0)
        Me.RadRotator1.LocationAnimation = New System.Drawing.SizeF(0.0!, -1.0!)
        Me.RadRotator1.Name = "RadRotator1"
        Me.RadRotator1.Running = False
        Me.RadRotator1.Size = New System.Drawing.Size(198, 204)
        Me.RadRotator1.TabIndex = 0
        Me.RadRotator1.Text = "RadRotator1"
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.AccessibleDescription = "RadButtonElement1"
        Me.RadButtonElement1.AccessibleName = "RadButtonElement1"
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.Text = "RadButtonElement1"
        Me.RadButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement2
        '
        Me.RadButtonElement2.AccessibleDescription = "RadButtonElement2"
        Me.RadButtonElement2.AccessibleName = "RadButtonElement2"
        Me.RadButtonElement2.Name = "RadButtonElement2"
        Me.RadButtonElement2.Text = "RadButtonElement2"
        Me.RadButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement3
        '
        Me.RadButtonElement3.AccessibleDescription = "RadButtonElement3"
        Me.RadButtonElement3.AccessibleName = "RadButtonElement3"
        Me.RadButtonElement3.Name = "RadButtonElement3"
        Me.RadButtonElement3.Text = "RadButtonElement3"
        Me.RadButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(209, 5)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.Size = New System.Drawing.Size(478, 456)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = False
        Me.DocumentContainer1.ThemeName = "Office2010Silver"
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(478, 456)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        Me.DocumentTabStrip1.ThemeName = "Office2010Silver"
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Location = New System.Drawing.Point(1, 29)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(476, 426)
        Me.DocumentWindow1.Text = "documentWindow1"
        '
        'RadCarousel1
        '
        CarouselEllipsePath1.Center = New Telerik.WinControls.UI.Point3D(50, 50, 0)
        CarouselEllipsePath1.FinalAngle = -100
        CarouselEllipsePath1.InitialAngle = -90
        CarouselEllipsePath1.U = New Telerik.WinControls.UI.Point3D(-20, -17, -50)
        CarouselEllipsePath1.V = New Telerik.WinControls.UI.Point3D(30, -25, -60)
        CarouselEllipsePath1.ZScale = 500
        Me.RadCarousel1.CarouselPath = CarouselEllipsePath1
        Me.RadCarousel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCarousel1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement4, Me.RadButtonElement5, Me.RadButtonElement6})
        Me.RadCarousel1.Location = New System.Drawing.Point(0, 0)
        Me.RadCarousel1.Name = "RadCarousel1"
        Me.RadCarousel1.SelectedIndex = 0
        Me.RadCarousel1.Size = New System.Drawing.Size(198, 204)
        Me.RadCarousel1.TabIndex = 0
        Me.RadCarousel1.Text = "RadCarousel1"
        '
        'RadButtonElement4
        '
        Me.RadButtonElement4.AccessibleDescription = "RadButtonElement4"
        Me.RadButtonElement4.AccessibleName = "RadButtonElement4"
        Me.RadButtonElement4.Name = "RadButtonElement4"
        Me.RadButtonElement4.Text = "RadButtonElement4"
        Me.RadButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement5
        '
        Me.RadButtonElement5.AccessibleDescription = "RadButtonElement5"
        Me.RadButtonElement5.AccessibleName = "RadButtonElement5"
        Me.RadButtonElement5.Name = "RadButtonElement5"
        Me.RadButtonElement5.Text = "RadButtonElement5"
        Me.RadButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement6
        '
        Me.RadButtonElement6.AccessibleDescription = "RadButtonElement6"
        Me.RadButtonElement6.AccessibleName = "RadButtonElement6"
        Me.RadButtonElement6.Name = "RadButtonElement6"
        Me.RadButtonElement6.Text = "RadButtonElement6"
        Me.RadButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 466)
        Me.Controls.Add(Me.RadDock1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        Me.ToolWindow2.ResumeLayout(False)
        CType(Me.RadRotator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.RadCarousel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents RadRotator1 As Telerik.WinControls.UI.RadRotator
    Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement2 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement3 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadCarousel1 As Telerik.WinControls.UI.RadCarousel
    Friend WithEvents RadButtonElement4 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement5 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement6 As Telerik.WinControls.UI.RadButtonElement

End Class
