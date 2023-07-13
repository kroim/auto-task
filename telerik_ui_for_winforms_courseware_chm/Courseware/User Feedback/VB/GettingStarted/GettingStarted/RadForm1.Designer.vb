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
        Me.ssMain = New Telerik.WinControls.UI.RadStatusStrip
        Me.btnServers = New Telerik.WinControls.UI.RadButtonElement
        Me.lblStatus = New Telerik.WinControls.UI.RadLabelElement
        Me.lblHost = New Telerik.WinControls.UI.RadLabelElement
        Me.lblServers = New Telerik.WinControls.UI.RadLabel
        Me.lblDatabases = New Telerik.WinControls.UI.RadLabel
        Me.lcDatabases = New Telerik.WinControls.UI.RadListControl
        Me.lcServers = New Telerik.WinControls.UI.RadListControl
        Me.pnlMaxObjects = New Telerik.WinControls.UI.RadPanel
        Me.lblCount = New Telerik.WinControls.UI.RadLabel
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.tbMaxObjects = New Telerik.WinControls.UI.RadTrackBar
        Me.pbStatus = New Telerik.WinControls.UI.RadProgressBarElement
        CType(Me.ssMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblServers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDatabases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcDatabases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcServers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMaxObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMaxObjects.SuspendLayout()
        CType(Me.lblCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMaxObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssMain
        '
        Me.ssMain.AutoSize = True
        Me.ssMain.BackColor = System.Drawing.Color.Transparent
        Me.ssMain.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnServers, Me.lblStatus, Me.lblHost, Me.pbStatus})
        Me.ssMain.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.ssMain.Location = New System.Drawing.Point(0, 304)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(592, 62)
        Me.ssMain.SizingGrip = False
        Me.ssMain.TabIndex = 0
        Me.ssMain.Text = "radStatusStrip1"
        CType(Me.ssMain.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Text = "radStatusStrip1"
        CType(Me.ssMain.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).Padding = New System.Windows.Forms.Padding(2)
        CType(Me.ssMain.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).MinSize = New System.Drawing.Size(0, 19)
        CType(Me.ssMain.GetChildAt(0), Telerik.WinControls.UI.RadStatusBarElement).StretchVertically = False
        CType(Me.ssMain.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.Transparent
        CType(Me.ssMain.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor3 = System.Drawing.Color.Transparent
        CType(Me.ssMain.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor4 = System.Drawing.Color.Transparent
        CType(Me.ssMain.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
        '
        'btnServers
        '
        Me.btnServers.AccessibleDescription = "Find" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servers"
        Me.btnServers.AccessibleName = "Find" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servers"
        Me.btnServers.CanFocus = True
        Me.btnServers.Image = Global.GettingStarted.My.Resources.Resources.FindServers
        Me.btnServers.Margin = New System.Windows.Forms.Padding(1)
        Me.btnServers.Name = "btnServers"
        Me.btnServers.Padding = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.ssMain.SetSpring(Me.btnServers, False)
        Me.btnServers.Text = "Find" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servers"
        Me.btnServers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnServers.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'lblStatus
        '
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.lblStatus.Name = "lblStatus"
        Me.ssMain.SetSpring(Me.lblStatus, True)
        Me.lblStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lblStatus.TextWrap = True
        Me.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'lblHost
        '
        Me.lblHost.AutoSize = False
        Me.lblHost.BackColor = System.Drawing.Color.Transparent
        Me.lblHost.Bounds = New System.Drawing.Rectangle(0, 0, 54, 54)
        Me.lblHost.Margin = New System.Windows.Forms.Padding(1)
        Me.lblHost.Name = "lblHost"
        Me.ssMain.SetSpring(Me.lblHost, False)
        Me.lblHost.TextWrap = True
        Me.lblHost.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'lblServers
        '
        Me.lblServers.BackColor = System.Drawing.Color.Transparent
        Me.lblServers.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblServers.Location = New System.Drawing.Point(12, 12)
        Me.lblServers.Name = "lblServers"
        Me.lblServers.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblServers.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblServers.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblServers.Size = New System.Drawing.Size(47, 18)
        Me.lblServers.TabIndex = 2
        Me.lblServers.Text = "Servers"
        '
        'lblDatabases
        '
        Me.lblDatabases.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabases.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDatabases.Location = New System.Drawing.Point(14, 138)
        Me.lblDatabases.Name = "lblDatabases"
        Me.lblDatabases.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        '
        '
        Me.lblDatabases.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDatabases.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblDatabases.Size = New System.Drawing.Size(62, 18)
        Me.lblDatabases.TabIndex = 4
        Me.lblDatabases.Text = "Databases"
        '
        'lcDatabases
        '
        Me.lcDatabases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcDatabases.CaseSensitiveSort = True
        Me.lcDatabases.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcDatabases.ItemHeight = 18
        Me.lcDatabases.Location = New System.Drawing.Point(14, 158)
        Me.lcDatabases.Name = "lcDatabases"
        Me.lcDatabases.Size = New System.Drawing.Size(566, 87)
        Me.lcDatabases.TabIndex = 5
        Me.lcDatabases.ThemeName = "Telerik"
        '
        'lcServers
        '
        Me.lcServers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcServers.CaseSensitiveSort = True
        Me.lcServers.ItemHeight = 18
        Me.lcServers.Location = New System.Drawing.Point(12, 32)
        Me.lcServers.Name = "lcServers"
        Me.lcServers.Size = New System.Drawing.Size(568, 87)
        Me.lcServers.TabIndex = 6
        Me.lcServers.ThemeName = "Telerik"
        '
        'pnlMaxObjects
        '
        Me.pnlMaxObjects.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMaxObjects.BackColor = System.Drawing.Color.Transparent
        Me.pnlMaxObjects.Controls.Add(Me.lblCount)
        Me.pnlMaxObjects.Controls.Add(Me.radLabel1)
        Me.pnlMaxObjects.Controls.Add(Me.tbMaxObjects)
        Me.pnlMaxObjects.Location = New System.Drawing.Point(342, 253)
        Me.pnlMaxObjects.Name = "pnlMaxObjects"
        Me.pnlMaxObjects.Size = New System.Drawing.Size(238, 48)
        Me.pnlMaxObjects.TabIndex = 8
        Me.pnlMaxObjects.ThemeName = "ControlDefault"
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCount.Location = New System.Drawing.Point(199, 11)
        Me.lblCount.Name = "lblCount"
        '
        '
        '
        Me.lblCount.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCount.Size = New System.Drawing.Size(12, 18)
        Me.lblCount.TabIndex = 9
        Me.lblCount.Text = "0"
        '
        'radLabel1
        '
        Me.radLabel1.BackColor = System.Drawing.Color.Transparent
        Me.radLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.radLabel1.Location = New System.Drawing.Point(8, 10)
        Me.radLabel1.Name = "radLabel1"
        '
        '
        '
        Me.radLabel1.RootElement.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.radLabel1.Size = New System.Drawing.Size(46, 33)
        Me.radLabel1.TabIndex = 8
        Me.radLabel1.Text = "Max" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Objects:"
        '
        'tbMaxObjects
        '
        Me.tbMaxObjects.Location = New System.Drawing.Point(61, 11)
        Me.tbMaxObjects.Maximum = 100
        Me.tbMaxObjects.Name = "tbMaxObjects"
        Me.tbMaxObjects.ShowTicks = False
        Me.tbMaxObjects.Size = New System.Drawing.Size(123, 30)
        Me.tbMaxObjects.SlideAreaWidth = 2
        Me.tbMaxObjects.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke
        Me.tbMaxObjects.SliderAreaColor2 = System.Drawing.Color.DarkGray
        Me.tbMaxObjects.TabIndex = 10
        Me.tbMaxObjects.ThumbWidth = 18
        Me.tbMaxObjects.TicksColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        CType(Me.tbMaxObjects.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SliderAreaGradientColor1 = System.Drawing.Color.WhiteSmoke
        CType(Me.tbMaxObjects.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SliderAreaGradientColor2 = System.Drawing.Color.DarkGray
        CType(Me.tbMaxObjects.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).TickColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        CType(Me.tbMaxObjects.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).ShowTicks = False
        CType(Me.tbMaxObjects.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SlideAreaWidth = 2
        CType(Me.tbMaxObjects.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).Maximum = 100
        CType(Me.tbMaxObjects.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.TrackBarPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.tbMaxObjects.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.TrackBarPrimitive).BackColor = System.Drawing.Color.Transparent
        CType(Me.tbMaxObjects.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.tbMaxObjects.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
        '
        'pbStatus
        '
        Me.pbStatus.Alignment = System.Drawing.ContentAlignment.BottomCenter
        Me.pbStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.pbStatus.MaxSize = New System.Drawing.Size(0, 23)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.SeparatorColor1 = System.Drawing.Color.White
        Me.pbStatus.SeparatorColor2 = System.Drawing.Color.White
        Me.pbStatus.SeparatorColor3 = System.Drawing.Color.White
        Me.pbStatus.SeparatorColor4 = System.Drawing.Color.White
        Me.pbStatus.SeparatorGradientAngle = 0
        Me.pbStatus.SeparatorGradientPercentage1 = 0.4!
        Me.pbStatus.SeparatorGradientPercentage2 = 0.6!
        Me.pbStatus.SeparatorNumberOfColors = 2
        Me.ssMain.SetSpring(Me.pbStatus, True)
        Me.pbStatus.StepWidth = 14
        Me.pbStatus.SweepAngle = 90
        Me.pbStatus.Text = ""
        Me.pbStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 366)
        Me.Controls.Add(Me.pnlMaxObjects)
        Me.Controls.Add(Me.lcServers)
        Me.Controls.Add(Me.lcDatabases)
        Me.Controls.Add(Me.lblDatabases)
        Me.Controls.Add(Me.lblServers)
        Me.Controls.Add(Me.ssMain)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MS SQL Servers"
        CType(Me.ssMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblServers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDatabases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcDatabases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcServers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMaxObjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMaxObjects.ResumeLayout(False)
        Me.pnlMaxObjects.PerformLayout()
        CType(Me.lblCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMaxObjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private ssMain As Telerik.WinControls.UI.RadStatusStrip
    Private radListDataItem1 As Telerik.WinControls.UI.RadListDataItem
    Private lblServers As Telerik.WinControls.UI.RadLabel
    Private lblDatabases As Telerik.WinControls.UI.RadLabel
    Private lcDatabases As Telerik.WinControls.UI.RadListControl
    Private WithEvents btnServers As Telerik.WinControls.UI.RadButtonElement
    Private lcServers As Telerik.WinControls.UI.RadListControl
    Private lblStatus As Telerik.WinControls.UI.RadLabelElement
    Private pnlMaxObjects As Telerik.WinControls.UI.RadPanel
    Private lblCount As Telerik.WinControls.UI.RadLabel
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private WithEvents tbMaxObjects As Telerik.WinControls.UI.RadTrackBar
    Private lblHost As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents pbStatus As Telerik.WinControls.UI.RadProgressBarElement

End Class
