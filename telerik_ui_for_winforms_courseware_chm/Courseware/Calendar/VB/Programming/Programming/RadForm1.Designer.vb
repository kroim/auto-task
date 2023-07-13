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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.aquaTheme1 = New Telerik.WinControls.Themes.AquaTheme
        Me.btnGetFlights = New Telerik.WinControls.UI.RadButton
        Me.lblStatus = New Telerik.WinControls.UI.RadLabel
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGetFlights, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radCalendar1
        '
        Me.radCalendar1.AllowColumnHeaderSelectors = True
        Me.radCalendar1.AllowFishEye = True
        Me.radCalendar1.AllowMultipleSelect = True
        Me.radCalendar1.AllowRowHeaderSelectors = True
        Me.radCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radCalendar1.CellToolTipFormat = "dddd, MMMM dd, yyyy blah"
        Me.radCalendar1.FastNavigationNextImage = CType(resources.GetObject("radCalendar1.FastNavigationNextImage"), System.Drawing.Image)
        Me.radCalendar1.FastNavigationPrevImage = CType(resources.GetObject("radCalendar1.FastNavigationPrevImage"), System.Drawing.Image)
        Me.radCalendar1.HeaderHeight = 17
        Me.radCalendar1.HeaderWidth = 17
        Me.radCalendar1.ImageList = Me.imageList1
        Me.radCalendar1.Location = New System.Drawing.Point(9, 9)
        Me.radCalendar1.Margin = New System.Windows.Forms.Padding(0)
        Me.radCalendar1.Name = "radCalendar1"
        Me.radCalendar1.NavigationNextImage = CType(resources.GetObject("radCalendar1.NavigationNextImage"), System.Drawing.Image)
        Me.radCalendar1.NavigationPrevImage = CType(resources.GetObject("radCalendar1.NavigationPrevImage"), System.Drawing.Image)
        Me.radCalendar1.RangeMaxDate = New Date(2099, 12, 30, 0, 0, 0, 0)
        Me.radCalendar1.ShowFooter = True
        Me.radCalendar1.ShowRowHeaders = True
        Me.radCalendar1.ShowViewSelector = True
        Me.radCalendar1.Size = New System.Drawing.Size(663, 484)
        Me.radCalendar1.TabIndex = 0
        Me.radCalendar1.Text = "radCalendar1"
        Me.radCalendar1.ThemeName = "Aqua"
        Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
        Me.radCalendar1.TitleFormat = "MMM yy"
        Me.radCalendar1.ZoomFactor = 1.2!
        CType(Me.radCalendar1.GetChildAt(0), Telerik.WinControls.UI.RadCalendarElement).AllowFishEye = True
        CType(Me.radCalendar1.GetChildAt(0), Telerik.WinControls.UI.RadCalendarElement).ZoomFactor = 1.2!
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadLabelElement).Text = "3/2/2011 6:34:54 PM"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "blackout.ico")
        '
        'btnGetFlights
        '
        Me.btnGetFlights.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetFlights.BackColor = System.Drawing.Color.Transparent
        Me.btnGetFlights.Location = New System.Drawing.Point(565, 502)
        Me.btnGetFlights.Name = "btnGetFlights"
        Me.btnGetFlights.Size = New System.Drawing.Size(107, 23)
        Me.btnGetFlights.TabIndex = 1
        Me.btnGetFlights.Text = "Get Flights"
        Me.btnGetFlights.ThemeName = "Aqua"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Location = New System.Drawing.Point(19, 442)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(2, 2)
        Me.lblStatus.TabIndex = 2
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 533)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnGetFlights)
        Me.Controls.Add(Me.radCalendar1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Request Flights"
        Me.ThemeName = "Aqua"
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGetFlights, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radCalendar1 As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents aquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Friend WithEvents btnGetFlights As Telerik.WinControls.UI.RadButton
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblStatus As Telerik.WinControls.UI.RadLabel

End Class
