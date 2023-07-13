Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage
        Me.RadPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage
        Me.RadPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage
        Me.RadPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage
        Me.RadPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage5.SuspendLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage2)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage3)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage4)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage5)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage5
        Me.RadPageView1.Size = New System.Drawing.Size(459, 103)
        Me.RadPageView1.TabIndex = 0
        Me.RadPageView1.Text = "RadPageView1"
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(438, 55)
        Me.RadPageViewPage1.Text = "Check In"
        '
        'RadPageViewPage2
        '
        Me.RadPageViewPage2.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPage2.Name = "RadPageViewPage2"
        Me.RadPageViewPage2.Size = New System.Drawing.Size(438, 55)
        Me.RadPageViewPage2.Text = "Arrivals"
        '
        'RadPageViewPage3
        '
        Me.RadPageViewPage3.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPage3.Name = "RadPageViewPage3"
        Me.RadPageViewPage3.Size = New System.Drawing.Size(438, 55)
        Me.RadPageViewPage3.Text = "Departures"
        '
        'RadPageViewPage4
        '
        Me.RadPageViewPage4.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPage4.Name = "RadPageViewPage4"
        Me.RadPageViewPage4.Size = New System.Drawing.Size(438, 55)
        Me.RadPageViewPage4.Text = "Special Offer"
        '
        'RadPageViewPage5
        '
        Me.RadPageViewPage5.Controls.Add(Me.RadCheckBox1)
        Me.RadPageViewPage5.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPage5.Name = "RadPageViewPage5"
        Me.RadPageViewPage5.Size = New System.Drawing.Size(438, 55)
        Me.RadPageViewPage5.Text = "Book a Flight"
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Location = New System.Drawing.Point(67, 19)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(86, 18)
        Me.RadCheckBox1.TabIndex = 0
        Me.RadCheckBox1.Text = "Simple Menu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 103)
        Me.Controls.Add(Me.RadPageView1)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage5.ResumeLayout(False)
        Me.RadPageViewPage5.PerformLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox


End Class
