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
        Me.office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme
        Me.lblItemSelected = New Telerik.WinControls.UI.RadLabel
        Me.RadListControl1 = New Telerik.WinControls.UI.RadListControl
        CType(Me.lblItemSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblItemSelected
        '
        Me.lblItemSelected.BackColor = System.Drawing.Color.Transparent
        Me.lblItemSelected.Location = New System.Drawing.Point(12, 12)
        Me.lblItemSelected.Name = "lblItemSelected"
        Me.lblItemSelected.Size = New System.Drawing.Size(55, 18)
        Me.lblItemSelected.TabIndex = 1
        Me.lblItemSelected.Text = "radLabel1"
        '
        'RadListControl1
        '
        Me.RadListControl1.CaseSensitiveSort = True
        Me.RadListControl1.Location = New System.Drawing.Point(12, 31)
        Me.RadListControl1.Name = "RadListControl1"
        Me.RadListControl1.Size = New System.Drawing.Size(393, 236)
        Me.RadListControl1.TabIndex = 2
        Me.RadListControl1.Text = "RadListControl1"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 279)
        Me.Controls.Add(Me.RadListControl1)
        Me.Controls.Add(Me.lblItemSelected)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Adding Hosted Controls"
        Me.ThemeName = "Office2007Silver"
        CType(Me.lblItemSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Private lblItemSelected As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadListControl1 As Telerik.WinControls.UI.RadListControl

End Class
