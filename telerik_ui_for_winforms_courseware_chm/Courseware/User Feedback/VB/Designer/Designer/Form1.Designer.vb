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
        Me.radWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        Me.label1 = New System.Windows.Forms.Label
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.radTrackBar2 = New Telerik.WinControls.UI.RadTrackBar
        Me.DesertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar
        CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radWaitingBar1
        '
        Me.radWaitingBar1.Location = New System.Drawing.Point(76, 102)
        Me.radWaitingBar1.Name = "radWaitingBar1"
        Me.radWaitingBar1.Size = New System.Drawing.Size(221, 36)
        Me.radWaitingBar1.TabIndex = 3
        Me.radWaitingBar1.Text = "radWaitingBar1"
        Me.radWaitingBar1.ThemeName = "Vista"
        Me.radWaitingBar1.WaitingIndicatorSize = New Size(30, 0)
        Me.radWaitingBar1.WaitingSpeed = 100
        '
        'label1
        '
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label1.Image = Global.Designer.My.Resources.Resources.Oryx_Antelope
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(139, 77)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Antelope"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radLabel1
        '
        Me.radLabel1.AutoSize = False
        Me.radLabel1.BackgroundImage = Global.Designer.My.Resources.Resources.Oryx_Antelope
        Me.radLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.radLabel1.Image = CType(resources.GetObject("radLabel1.Image"), System.Drawing.Image)
        Me.radLabel1.ImageAlignment = System.Drawing.ContentAlignment.BottomRight
        Me.radLabel1.ImageKey = "1403_Globe.png"
        Me.radLabel1.ImageList = Me.imageList1
        Me.radLabel1.Location = New System.Drawing.Point(158, 9)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(139, 77)
        Me.radLabel1.TabIndex = 0
        Me.radLabel1.Text = "Antelope"
        Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.radLabel1.ThemeName = "Desert"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "help.png")
        Me.imageList1.Images.SetKeyName(1, "1403_Globe.png")
        '
        'radTrackBar2
        '
        Me.radTrackBar2.Location = New System.Drawing.Point(12, 102)
        Me.radTrackBar2.Maximum = 100
        Me.radTrackBar2.Name = "radTrackBar2"
        Me.radTrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.radTrackBar2.Size = New System.Drawing.Size(58, 213)
        Me.radTrackBar2.SlideAreaWidth = 10
        Me.radTrackBar2.SliderAreaColor1 = System.Drawing.Color.LightGray
        Me.radTrackBar2.SliderAreaColor2 = System.Drawing.Color.Red
        Me.radTrackBar2.SliderAreaGradientAngle = 320.0!
        Me.radTrackBar2.TabIndex = 6
        Me.radTrackBar2.Text = "radTrackBar2"
        Me.radTrackBar2.ThemeName = "Office2007Silver"
        Me.radTrackBar2.TickFrequency = 10
        Me.radTrackBar2.TicksColor = System.Drawing.Color.Maroon
        Me.radTrackBar2.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight
        Me.radTrackBar2.Value = 80
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SliderAreaGradientColor1 = System.Drawing.Color.LightGray
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SliderAreaGradientColor2 = System.Drawing.Color.Red
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).TickColor = System.Drawing.Color.Maroon
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SliderAreaGradientAngle = 320.0!
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).TickFrequency = 10
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).TrackBarOrientation = System.Windows.Forms.Orientation.Vertical
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).SlideAreaWidth = 10
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).Maximum = 100
        CType(Me.radTrackBar2.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).Value = 80
        CType(Me.radTrackBar2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.TrackBarThumb).AngleTransform = 0.0!
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Dash = True
        Me.RadProgressBar1.ImageIndex = -1
        Me.RadProgressBar1.ImageKey = ""
        Me.RadProgressBar1.Location = New System.Drawing.Point(76, 173)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.SeparatorColor1 = System.Drawing.Color.Purple
        Me.RadProgressBar1.SeparatorColor2 = System.Drawing.Color.Red
        Me.RadProgressBar1.SeparatorColor3 = System.Drawing.Color.White
        Me.RadProgressBar1.SeparatorColor4 = System.Drawing.Color.White
        Me.RadProgressBar1.SeparatorWidth = 10
        Me.RadProgressBar1.Size = New System.Drawing.Size(221, 35)
        Me.RadProgressBar1.SweepAngle = 135
        Me.RadProgressBar1.TabIndex = 7
        Me.RadProgressBar1.Value1 = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 452)
        Me.Controls.Add(Me.RadProgressBar1)
        Me.Controls.Add(Me.radTrackBar2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.radWaitingBar1)
        Me.Controls.Add(Me.radLabel1)
        Me.Name = "Form1"
        Me.Text = "User Feedback"
        CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Private label1 As System.Windows.Forms.Label
    Private imageList1 As System.Windows.Forms.ImageList
    Private radTrackBar2 As Telerik.WinControls.UI.RadTrackBar
    Friend WithEvents DesertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
End Class
