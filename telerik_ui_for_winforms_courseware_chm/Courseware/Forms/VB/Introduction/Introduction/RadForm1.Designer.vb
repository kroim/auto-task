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
        Me.aquaTheme1 = New Telerik.WinControls.Themes.AquaTheme
        Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.radLabelElement1 = New Telerik.WinControls.UI.RadLabelElement
        Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement
        Me.radProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement
        Me.radButton1 = New Telerik.WinControls.UI.RadButton
        Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList
        Me.RadListDataItem1 = New Telerik.WinControls.UI.RadListDataItem
        Me.RadListDataItem2 = New Telerik.WinControls.UI.RadListDataItem
        Me.RadListDataItem3 = New Telerik.WinControls.UI.RadListDataItem
        Me.RadListDataItem4 = New Telerik.WinControls.UI.RadListDataItem
        Me.RadListDataItem5 = New Telerik.WinControls.UI.RadListDataItem
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radCalendar1
        '
        Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radCalendar1.HeaderHeight = 17
        Me.radCalendar1.HeaderWidth = 17
        Me.radCalendar1.Location = New System.Drawing.Point(13, 10)
        Me.radCalendar1.Name = "radCalendar1"
        Me.radCalendar1.RangeMaxDate = New Date(2099, 12, 30, 0, 0, 0, 0)
        Me.radCalendar1.Size = New System.Drawing.Size(275, 238)
        Me.radCalendar1.TabIndex = 0
        Me.radCalendar1.Text = "radCalendar1"
        Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
        Me.radCalendar1.ZoomFactor = 1.2!
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radLabelElement1, Me.radCheckBoxElement1, Me.radProgressBarElement1})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 255)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(442, 24)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'radLabelElement1
        '
        Me.radLabelElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radLabelElement1.Name = "radLabelElement1"
        Me.radStatusStrip1.SetSpring(Me.radLabelElement1, False)
        Me.radLabelElement1.Text = "Current Document: Financials"
        '
        'radCheckBoxElement1
        '
        Me.radCheckBoxElement1.CanFocus = True
        Me.radCheckBoxElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
        Me.radCheckBoxElement1.ShowBorder = False
        Me.radStatusStrip1.SetSpring(Me.radCheckBoxElement1, False)
        Me.radCheckBoxElement1.Text = "Check Validity"
        Me.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'radProgressBarElement1
        '
        Me.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.radProgressBarElement1.ClipDrawing = True
        Me.radProgressBarElement1.DefaultSize = New System.Drawing.Size(130, 16)
        Me.radProgressBarElement1.Margin = New System.Windows.Forms.Padding(1)
        Me.radProgressBarElement1.Name = "radProgressBarElement1"
        Me.radStatusStrip1.SetSpring(Me.radProgressBarElement1, False)
        Me.radProgressBarElement1.Text = "Verifying"
        Me.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radProgressBarElement1.Value1 = 30
        '
        'radButton1
        '
        Me.radButton1.AllowShowFocusCues = True
        Me.radButton1.Location = New System.Drawing.Point(355, 225)
        Me.radButton1.Name = "radButton1"
        Me.radButton1.Size = New System.Drawing.Size(75, 23)
        Me.radButton1.TabIndex = 2
        Me.radButton1.Text = "Confirm"
        '
        'radDropDownList1
        '
        Me.radDropDownList1.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() {Me.RadListDataItem1, Me.RadListDataItem2, Me.RadListDataItem3, Me.RadListDataItem4, Me.RadListDataItem5})
        Me.radDropDownList1.Location = New System.Drawing.Point(304, 10)
        Me.radDropDownList1.Name = "radDropDownList1"
        '
        '
        '
        Me.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radDropDownList1.Size = New System.Drawing.Size(126, 19)
        Me.radDropDownList1.TabIndex = 3
        Me.radDropDownList1.Text = "radDropDownList1"
        '
        'RadListDataItem1
        '
        Me.RadListDataItem1.Text = "First Quarter"
        '
        'RadListDataItem2
        '
        Me.RadListDataItem2.Text = "Second Quarter"
        '
        'RadListDataItem3
        '
        Me.RadListDataItem3.Text = "Third Quarter"
        '
        'RadListDataItem4
        '
        Me.RadListDataItem4.Text = "Fourth Quarter"
        '
        'RadListDataItem5
        '
        Me.RadListDataItem5.Text = "Yearly"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 279)
        Me.Controls.Add(Me.radDropDownList1)
        Me.Controls.Add(Me.radButton1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Controls.Add(Me.radCalendar1)
        Me.Name = "RadForm1"
        Me.Text = "Aqua Theme Form"
        Me.ThemeName = "ControlDefault"
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Friend WithEvents radCalendar1 As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents radLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
    Friend WithEvents radProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents radButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem
    Friend WithEvents RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem
    Friend WithEvents RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem
    Friend WithEvents RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem
    Friend WithEvents RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem

End Class
