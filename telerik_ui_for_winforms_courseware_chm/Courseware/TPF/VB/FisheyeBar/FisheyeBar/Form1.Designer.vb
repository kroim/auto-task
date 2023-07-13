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
        Me.welcomeScreenBottom1 = New WelcomeScreenBottom()
        Me.SuspendLayout()
        ' 
        ' welcomeScreenBottom1
        ' 
        Me.welcomeScreenBottom1.BackColor = System.Drawing.Color.Transparent
        Me.welcomeScreenBottom1.Font = New System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.welcomeScreenBottom1.ForeColor = System.Drawing.Color.White
        Me.welcomeScreenBottom1.Location = New System.Drawing.Point(29, 82)
        Me.welcomeScreenBottom1.Name = "welcomeScreenBottom1"
        Me.welcomeScreenBottom1.Size = New System.Drawing.Size(673, 189)
        Me.welcomeScreenBottom1.TabIndex = 0
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(733, 339)
        Me.Controls.Add(Me.welcomeScreenBottom1)
        Me.Name = "Form1"
        Me.Text = "Animation"
        Me.ResumeLayout(False)

    End Sub

    Private welcomeScreenBottom1 As WelcomeScreenBottom

End Class
