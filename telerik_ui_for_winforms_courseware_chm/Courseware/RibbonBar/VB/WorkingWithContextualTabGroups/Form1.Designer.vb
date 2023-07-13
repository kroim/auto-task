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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRibbonBar1
        '
        Me.RadRibbonBar1.AutoSize = True
        Me.RadRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadRibbonBar1.EnableKeyMap = True
        '
        '
        '
        Me.RadRibbonBar1.ExitButton.AccessibleDescription = "Exit"
        Me.RadRibbonBar1.ExitButton.AccessibleName = "Exit"
        '
        '
        '
        Me.RadRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit"
        Me.RadRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit"
        Me.RadRibbonBar1.ExitButton.Text = "Exit"
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        '
        '
        '
        Me.RadRibbonBar1.OptionsButton.AccessibleDescription = "Options"
        Me.RadRibbonBar1.OptionsButton.AccessibleName = "Options"
        '
        '
        '
        Me.RadRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options"
        Me.RadRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options"
        Me.RadRibbonBar1.OptionsButton.Text = "Options"
        Me.RadRibbonBar1.Size = New System.Drawing.Size(284, 144)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "RadRibbonBar1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.Name = "Form1"
        Me.Text = "RadRibbonBar1"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar

End Class
