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
        Me.radTabStrip1 = New Telerik.WinControls.UI.RadTabStrip()
        Me.radComboBox1 = New Telerik.WinControls.UI.RadComboBox()
        Me.radPageViewPage1 = New Telerik.WinControls.UI.TabItem()
        Me.radPageViewPage2 = New Telerik.WinControls.UI.TabItem()
        Me.radPageViewPage3 = New Telerik.WinControls.UI.TabItem()
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
        Me.office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.aquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
        Me.telerikTheme1 = New Telerik.WinControls.Themes.TelerikTheme()
        Me.vistaTheme1 = New Telerik.WinControls.Themes.VistaTheme()
        Me.breezeTheme1 = New Telerik.WinControls.Themes.BreezeTheme()
        Me.miscellaneousTheme1 = New Telerik.WinControls.Themes.MiscellaneousTheme()
        CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPageView1.SuspendLayout()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radTabStrip1
        ' 
        Me.radPageView1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.radPageView1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.radPageView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
        Me.radPageView1.Controls.Add(Me.radDropDownList1)
        Me.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTabStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tabItem1, Me.tabItem2, Me.tabItem3})
        Me.radPageView1.Location = New System.Drawing.Point(0, 0)
        Me.radPageView1.Name = "radTabStrip1"
        Me.radTabStrip1.ScrollOffsetStep = 5
        Me.radPageView1.Size = New System.Drawing.Size(361, 112)
        Me.radPageView1.TabIndex = 0
        Me.radTabStrip1.TabScrollButtonsPosition = Telerik.WinControls.UI.TabScrollButtonsPosition.RightBottom
        Me.radPageView1.Text = "radTabStrip1"
        ' 
        ' radComboBox1
        ' 
        Me.radDropDownList1.Location = New System.Drawing.Point(251, 0)
        Me.radDropDownList1.Name = "radComboBox1"
        ' 
        ' 
        ' 
        Me.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radDropDownList1.Size = New System.Drawing.Size(106, 19)
        Me.radDropDownList1.TabIndex = 0
        ' 
        ' tabItem1
        ' 
        Me.radPageViewPage1.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Me.radPageViewPage1.CanFocus = True
        Me.radPageViewPage1.Class = "TabItem"
        ' 
        ' tabItem1.ContentPanel
        ' 
        Me.radPageViewPage1.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.radPageViewPage1.ContentPanel.CausesValidation = True
        Me.radPageViewPage1.IsSelected = True
        Me.radPageViewPage1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.radPageViewPage1.Name = "tabItem1"
        Me.radPageViewPage1.StretchHorizontally = False
        Me.radPageViewPage1.Text = "Coffee"
        ' 
        ' tabItem2
        ' 
        Me.radPageViewPage2.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Me.radPageViewPage2.CanFocus = True
        Me.radPageViewPage2.Class = "TabItem"
        ' 
        ' tabItem2.ContentPanel
        ' 
        Me.radPageViewPage2.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.radPageViewPage2.ContentPanel.CausesValidation = True
        Me.radPageViewPage2.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.radPageViewPage2.Name = "tabItem2"
        Me.radPageViewPage2.StretchHorizontally = False
        Me.radPageViewPage2.Text = "Espresso"
        ' 
        ' tabItem3
        ' 
        Me.radPageViewPage3.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Me.radPageViewPage3.CanFocus = True
        Me.radPageViewPage3.Class = "TabItem"
        ' 
        ' tabItem3.ContentPanel
        ' 
        Me.radPageViewPage3.BackColor = System.Drawing.Color.Transparent
        Me.radPageViewPage3.CausesValidation = True
        Me.radPageViewPage3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.radPageViewPage3.Name = "tabItem3"
        Me.radPageViewPage3.Text = "Mocha"
        ' 
        ' RadForm1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 112)
        Me.Controls.Add(Me.radPageView1)
        Me.Name = "RadForm1"
        Me.Text = "Tab Strip Themes"
        Me.ThemeName = "ControlDefault"
        '			Me.Load += New System.EventHandler(Me.RadForm1_Load);
        CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPageView1.ResumeLayout(False)
        Me.radPageView1.PerformLayout()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radPageView1 As Telerik.WinControls.UI.RadPageView
    Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
    Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Private office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Private aquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Private telerikTheme1 As Telerik.WinControls.Themes.TelerikTheme
    Private vistaTheme1 As Telerik.WinControls.Themes.VistaTheme
    Private breezeTheme1 As Telerik.WinControls.Themes.BreezeTheme
    Private miscellaneousTheme1 As Telerik.WinControls.Themes.MiscellaneousTheme

End Class
