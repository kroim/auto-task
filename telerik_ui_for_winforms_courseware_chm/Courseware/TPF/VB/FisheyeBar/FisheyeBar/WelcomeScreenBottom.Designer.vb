<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreenBottom
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeScreenBottom))
        Me.radStackItemsPanel1 = New RadStackItemsPanel()
        Me.radStackItemsPanelElement1 = New RadStackItemsPanelElement()
        Me.radStackItemsPanelElement2 = New RadStackItemsPanelElement()
        Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.radImageItem1 = New Telerik.WinControls.UI.RadImageItem()
        Me.radLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lightVisualElement1 = New Telerik.WinControls.UI.LightVisualElement()
        Me.radStackItemsPanelElement3 = New RadStackItemsPanelElement()
        Me.radLabelElement5 = New Telerik.WinControls.UI.RadLabelElement()
        Me.radImageItem3 = New Telerik.WinControls.UI.RadImageItem()
        Me.radLabelElement6 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lightVisualElement2 = New Telerik.WinControls.UI.LightVisualElement()
        Me.radStackItemsPanelElement4 = New RadStackItemsPanelElement()
        Me.radLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.radImageItem2 = New Telerik.WinControls.UI.RadImageItem()
        Me.radLabelElement4 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lightVisualElement3 = New Telerik.WinControls.UI.LightVisualElement()
        Me.radStackItemsPanelElement5 = New RadStackItemsPanelElement()
        Me.radLabelElement7 = New Telerik.WinControls.UI.RadLabelElement()
        Me.radImageItem4 = New Telerik.WinControls.UI.RadImageItem()
        Me.radLabelElement8 = New Telerik.WinControls.UI.RadLabelElement()
        CType(Me.radStackItemsPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radStackItemsPanel1
        ' 
        Me.radStackItemsPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radStackItemsPanel1.ForeColor = System.Drawing.Color.White
        Me.radStackItemsPanel1.Location = New System.Drawing.Point(0, 0)
        Me.radStackItemsPanel1.Name = "radStackItemsPanel1"
        ' 
        ' 
        ' 
        Me.radStackItemsPanel1.PanelElement.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radStackItemsPanelElement1})
        ' 
        ' 
        ' 
        Me.radStackItemsPanel1.RootElement.ForeColor = System.Drawing.Color.White
        Me.radStackItemsPanel1.Size = New System.Drawing.Size(673, 189)
        Me.radStackItemsPanel1.TabIndex = 0
        Me.radStackItemsPanel1.Text = "radStackItemsPanel1"
        ' 
        ' radStackItemsPanelElement1
        ' 
        Me.radStackItemsPanelElement1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radStackItemsPanelElement2, Me.lightVisualElement1, Me.radStackItemsPanelElement3, Me.lightVisualElement2, Me.radStackItemsPanelElement4, Me.lightVisualElement3, Me.radStackItemsPanelElement5})
        Me.radStackItemsPanelElement1.Name = "radStackItemsPanelElement1"
        Me.radStackItemsPanelElement1.Text = "radStackItemsPanelElement1"
        ' 
        ' radStackItemsPanelElement2
        ' 
        Me.radStackItemsPanelElement2.DefaultSize = New System.Drawing.Size(200, 0)
        Me.radStackItemsPanelElement2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement1, Me.radImageItem1, Me.radLabelElement2})
        Me.radStackItemsPanelElement2.MinSize = New System.Drawing.Size(160, 0)
        Me.radStackItemsPanelElement2.Name = "radStackItemsPanelElement2"
        Me.radStackItemsPanelElement2.StackLayout.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.radStackItemsPanelElement2.StackLayout.SerializeProperties = True
        Me.radStackItemsPanelElement2.Text = "radStackItemsPanelElement2"
        '			Me.radStackItemsPanelElement2.Click += New System.EventHandler(Me.radStackItemsPanelElement2_Click);
        CType(Me.radStackItemsPanelElement2.GetChildAt(0), Telerik.WinControls.Layouts.StackLayoutPanel).Orientation = System.Windows.Forms.Orientation.Vertical
        ' 
        ' radLabelElement1
        ' 
        Me.radLabelElement1.Font = New System.Drawing.Font("Lucida Sans", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radLabelElement1.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement1.Name = "radLabelElement1"
        Me.radLabelElement1.Text = "Controls"
        Me.radLabelElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' radImageItem1
        ' 
        Me.radImageItem1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.radImageItem1.Image = (CType(resources.GetObject("radImageItem1.Image"), System.Drawing.Image))
        Me.radImageItem1.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radImageItem1.Name = "radImageItem1"
        Me.radImageItem1.Text = "radImageItem1"
        ' 
        ' radLabelElement2
        ' 
        Me.radLabelElement2.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement2.Name = "radLabelElement2"
        Me.radLabelElement2.Text = "RadConrols for " & Constants.vbCrLf & "WinForms on" & Constants.vbCrLf & "www.telerik.com"
        Me.radLabelElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' lightVisualElement1
        ' 
        Me.lightVisualElement1.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lightVisualElement1.BorderBottomColor = System.Drawing.Color.Transparent
        Me.lightVisualElement1.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        Me.lightVisualElement1.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.lightVisualElement1.BorderLeftColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(156))))))
        Me.lightVisualElement1.BorderRightColor = System.Drawing.Color.Transparent
        Me.lightVisualElement1.BorderTopColor = System.Drawing.Color.Transparent
        Me.lightVisualElement1.CanFocus = True
        Me.lightVisualElement1.DrawBorder = True
        Me.lightVisualElement1.MinSize = New System.Drawing.Size(2, 160)
        Me.lightVisualElement1.Name = "lightVisualElement1"
        Me.lightVisualElement1.ShouldPaint = True
        Me.lightVisualElement1.StretchHorizontally = False
        Me.lightVisualElement1.StretchVertically = False
        ' 
        ' radStackItemsPanelElement3
        ' 
        Me.radStackItemsPanelElement3.DefaultSize = New System.Drawing.Size(200, 0)
        Me.radStackItemsPanelElement3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement5, Me.radImageItem3, Me.radLabelElement6})
        Me.radStackItemsPanelElement3.MinSize = New System.Drawing.Size(160, 0)
        Me.radStackItemsPanelElement3.Name = "radStackItemsPanelElement3"
        Me.radStackItemsPanelElement3.StackLayout.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.radStackItemsPanelElement3.StackLayout.SerializeProperties = True
        Me.radStackItemsPanelElement3.Text = "radStackItemsPanelElement2"
        '			Me.radStackItemsPanelElement3.Click += New System.EventHandler(Me.radStackItemsPanelElement3_Click);
        CType(Me.radStackItemsPanelElement3.GetChildAt(0), Telerik.WinControls.Layouts.StackLayoutPanel).Orientation = System.Windows.Forms.Orientation.Vertical
        ' 
        ' radLabelElement5
        ' 
        Me.radLabelElement5.Font = New System.Drawing.Font("Lucida Sans", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radLabelElement5.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement5.Name = "radLabelElement5"
        Me.radLabelElement5.Text = "Sample Apps"
        Me.radLabelElement5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' radImageItem3
        ' 
        Me.radImageItem3.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.radImageItem3.Image = (CType(resources.GetObject("radImageItem3.Image"), System.Drawing.Image))
        Me.radImageItem3.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radImageItem3.Name = "radImageItem3"
        Me.radImageItem3.Text = "radImageItem1"
        ' 
        ' radLabelElement6
        ' 
        Me.radLabelElement6.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement6.Name = "radLabelElement6"
        Me.radLabelElement6.Text = "Explore WinForms" & Constants.vbCrLf & "sample applications"
        Me.radLabelElement6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' lightVisualElement2
        ' 
        Me.lightVisualElement2.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lightVisualElement2.BorderBottomColor = System.Drawing.Color.Transparent
        Me.lightVisualElement2.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        Me.lightVisualElement2.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.lightVisualElement2.BorderLeftColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(156))))))
        Me.lightVisualElement2.BorderRightColor = System.Drawing.Color.Transparent
        Me.lightVisualElement2.BorderTopColor = System.Drawing.Color.Transparent
        Me.lightVisualElement2.CanFocus = True
        Me.lightVisualElement2.DrawBorder = True
        Me.lightVisualElement2.MinSize = New System.Drawing.Size(2, 160)
        Me.lightVisualElement2.Name = "lightVisualElement2"
        Me.lightVisualElement2.ShouldPaint = True
        Me.lightVisualElement2.StretchHorizontally = False
        Me.lightVisualElement2.StretchVertically = False
        ' 
        ' radStackItemsPanelElement4
        ' 
        Me.radStackItemsPanelElement4.DefaultSize = New System.Drawing.Size(200, 0)
        Me.radStackItemsPanelElement4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement3, Me.radImageItem2, Me.radLabelElement4})
        Me.radStackItemsPanelElement4.MinSize = New System.Drawing.Size(160, 0)
        Me.radStackItemsPanelElement4.Name = "radStackItemsPanelElement4"
        Me.radStackItemsPanelElement4.StackLayout.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.radStackItemsPanelElement4.StackLayout.SerializeProperties = True
        Me.radStackItemsPanelElement4.Text = "radStackItemsPanelElement2"
        '			Me.radStackItemsPanelElement4.Click += New System.EventHandler(Me.radStackItemsPanelElement4_Click);
        CType(Me.radStackItemsPanelElement4.GetChildAt(0), Telerik.WinControls.Layouts.StackLayoutPanel).Orientation = System.Windows.Forms.Orientation.Vertical
        ' 
        ' radLabelElement3
        ' 
        Me.radLabelElement3.Font = New System.Drawing.Font("Lucida Sans", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radLabelElement3.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement3.Name = "radLabelElement3"
        Me.radLabelElement3.Text = "Productivity Tools"
        Me.radLabelElement3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' radImageItem2
        ' 
        Me.radImageItem2.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.radImageItem2.Image = (CType(resources.GetObject("radImageItem2.Image"), System.Drawing.Image))
        Me.radImageItem2.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radImageItem2.Name = "radImageItem2"
        Me.radImageItem2.Text = "radImageItem1"
        ' 
        ' radLabelElement4
        ' 
        Me.radLabelElement4.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement4.Name = "radLabelElement4"
        Me.radLabelElement4.Text = "Learn more on the tools" & Constants.vbCrLf & "included in RadControls" & Constants.vbCrLf & "for WinForms suite"
        Me.radLabelElement4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' lightVisualElement3
        ' 
        Me.lightVisualElement3.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lightVisualElement3.BorderBottomColor = System.Drawing.Color.Transparent
        Me.lightVisualElement3.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        Me.lightVisualElement3.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.lightVisualElement3.BorderLeftColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(156))))))
        Me.lightVisualElement3.BorderRightColor = System.Drawing.Color.Transparent
        Me.lightVisualElement3.BorderTopColor = System.Drawing.Color.Transparent
        Me.lightVisualElement3.CanFocus = True
        Me.lightVisualElement3.DrawBorder = True
        Me.lightVisualElement3.MinSize = New System.Drawing.Size(2, 160)
        Me.lightVisualElement3.Name = "lightVisualElement3"
        Me.lightVisualElement3.ShouldPaint = True
        Me.lightVisualElement3.StretchHorizontally = False
        Me.lightVisualElement3.StretchVertically = False
        ' 
        ' radStackItemsPanelElement5
        ' 
        Me.radStackItemsPanelElement5.DefaultSize = New System.Drawing.Size(200, 0)
        Me.radStackItemsPanelElement5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement7, Me.radImageItem4, Me.radLabelElement8})
        Me.radStackItemsPanelElement5.MinSize = New System.Drawing.Size(160, 0)
        Me.radStackItemsPanelElement5.Name = "radStackItemsPanelElement5"
        Me.radStackItemsPanelElement5.StackLayout.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.radStackItemsPanelElement5.StackLayout.SerializeProperties = True
        Me.radStackItemsPanelElement5.Text = "radStackItemsPanelElement2"
        '			Me.radStackItemsPanelElement5.Click += New System.EventHandler(Me.radStackItemsPanelElement5_Click);
        CType(Me.radStackItemsPanelElement5.GetChildAt(0), Telerik.WinControls.Layouts.StackLayoutPanel).Orientation = System.Windows.Forms.Orientation.Vertical
        ' 
        ' radLabelElement7
        ' 
        Me.radLabelElement7.Font = New System.Drawing.Font("Lucida Sans", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radLabelElement7.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement7.Name = "radLabelElement7"
        Me.radLabelElement7.Text = "What's new"
        Me.radLabelElement7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' radImageItem4
        ' 
        Me.radImageItem4.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.radImageItem4.Image = (CType(resources.GetObject("radImageItem4.Image"), System.Drawing.Image))
        Me.radImageItem4.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radImageItem4.Name = "radImageItem4"
        Me.radImageItem4.Text = "radImageItem1"
        ' 
        ' radLabelElement8
        ' 
        Me.radLabelElement8.Margin = New System.Windows.Forms.Padding(12, 5, 12, 5)
        Me.radLabelElement8.Name = "radLabelElement8"
        Me.radLabelElement8.Text = "Detailed list of what" & Constants.vbCrLf & "is new in 'Q1 2009"
        Me.radLabelElement8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        ' 
        ' WelcomeScreenBottom
        ' 
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.Controls.Add(Me.radStackItemsPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "WelcomeScreenBottom"
        Me.Size = New System.Drawing.Size(673, 189)
        '			Me.Load += New System.EventHandler(Me.WelcomeScreenBottom_Load);
        CType(Me.radStackItemsPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radStackItemsPanel1 As RadStackItemsPanel
    Private radStackItemsPanelElement1 As RadStackItemsPanelElement
    Private WithEvents radStackItemsPanelElement2 As RadStackItemsPanelElement
    Private radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Private radImageItem1 As Telerik.WinControls.UI.RadImageItem
    Private radLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Private lightVisualElement1 As Telerik.WinControls.UI.LightVisualElement
    Private WithEvents radStackItemsPanelElement4 As RadStackItemsPanelElement
    Private radLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Private radImageItem2 As Telerik.WinControls.UI.RadImageItem
    Private radLabelElement4 As Telerik.WinControls.UI.RadLabelElement
    Private lightVisualElement2 As Telerik.WinControls.UI.LightVisualElement
    Private lightVisualElement3 As Telerik.WinControls.UI.LightVisualElement
    Private WithEvents radStackItemsPanelElement3 As RadStackItemsPanelElement
    Private radLabelElement5 As Telerik.WinControls.UI.RadLabelElement
    Private radImageItem3 As Telerik.WinControls.UI.RadImageItem
    Private radLabelElement6 As Telerik.WinControls.UI.RadLabelElement
    Private WithEvents radStackItemsPanelElement5 As RadStackItemsPanelElement
    Private radLabelElement7 As Telerik.WinControls.UI.RadLabelElement
    Private radImageItem4 As Telerik.WinControls.UI.RadImageItem
    Private radLabelElement8 As Telerik.WinControls.UI.RadLabelElement

End Class
