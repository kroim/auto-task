<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalendarPanel))
        Me.RadCalendar1 = New Telerik.WinControls.UI.RadCalendar
        CType(Me.RadCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCalendar1
        '
        Me.RadCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadCalendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCalendar1.FastNavigationNextImage = CType(resources.GetObject("RadCalendar1.FastNavigationNextImage"), System.Drawing.Image)
        Me.RadCalendar1.FastNavigationPrevImage = CType(resources.GetObject("RadCalendar1.FastNavigationPrevImage"), System.Drawing.Image)
        Me.RadCalendar1.HeaderHeight = 17
        Me.RadCalendar1.HeaderWidth = 17
        Me.RadCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCalendar1.Name = "RadCalendar1"
        Me.RadCalendar1.NavigationNextImage = CType(resources.GetObject("RadCalendar1.NavigationNextImage"), System.Drawing.Image)
        Me.RadCalendar1.NavigationPrevImage = CType(resources.GetObject("RadCalendar1.NavigationPrevImage"), System.Drawing.Image)
        Me.RadCalendar1.RangeMaxDate = New Date(2099, 12, 30, 0, 0, 0, 0)
        Me.RadCalendar1.Size = New System.Drawing.Size(150, 150)
        Me.RadCalendar1.TabIndex = 0
        Me.RadCalendar1.Text = "RadCalendar1"
        Me.RadCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
        '
        'CalendarPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RadCalendar1)
        Me.Name = "CalendarPanel"
        CType(Me.RadCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCalendar1 As Telerik.WinControls.UI.RadCalendar

End Class
