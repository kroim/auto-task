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
        Dim RadCalendarDay1 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay
        Dim RadCalendarDay2 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay
        Dim RadCalendarDay3 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay
        Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radCalendar1
        '
        Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radCalendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radCalendar1.HeaderHeight = 17
        Me.radCalendar1.HeaderWidth = 17
        Me.radCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.radCalendar1.Name = "radCalendar1"
        Me.radCalendar1.RangeMaxDate = New Date(2099, 12, 30, 0, 0, 0, 0)
        Me.radCalendar1.Size = New System.Drawing.Size(269, 241)
        RadCalendarDay1.Date = New Date(2009, 2, 14, 0, 0, 0, 0)
        RadCalendarDay1.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
        RadCalendarDay1.Selectable = False
        RadCalendarDay1.ToolTip = "Don't forget Valentines Day!"
        RadCalendarDay2.Date = New Date(2009, 2, 12, 0, 0, 0, 0)
        RadCalendarDay2.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
        RadCalendarDay2.Selectable = False
        RadCalendarDay2.ToolTip = "Abraham Lincoln's Birthday"
        RadCalendarDay3.Date = New Date(2009, 2, 2, 0, 0, 0, 0)
        RadCalendarDay3.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
        RadCalendarDay3.Selectable = False
        RadCalendarDay3.ToolTip = "Groundhog Day"
        Me.radCalendar1.SpecialDays.Add(RadCalendarDay1)
        Me.radCalendar1.SpecialDays.Add(RadCalendarDay2)
        Me.radCalendar1.SpecialDays.Add(RadCalendarDay3)
        Me.radCalendar1.TabIndex = 0
        Me.radCalendar1.Text = "radCalendar1"
        Me.radCalendar1.ThemeName = "Desert"
        Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
        Me.radCalendar1.ZoomFactor = 1.2!
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 241)
        Me.Controls.Add(Me.radCalendar1)
        Me.Name = "RadForm1"
        Me.Text = "Calendar"
        Me.ThemeName = "Desert"
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radCalendar1 As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents desertTheme1 As Telerik.WinControls.Themes.DesertTheme

End Class
