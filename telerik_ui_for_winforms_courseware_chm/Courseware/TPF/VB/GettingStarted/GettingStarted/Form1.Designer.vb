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
        Me.radButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radButton1
        ' 
        Me.radButton1.Image = Global.GettingStarted.My.Resources._1403_Globe
        Me.radButton1.Location = New System.Drawing.Point(12, 12)
        Me.radButton1.Name = "radButton1"
        Me.radButton1.Size = New System.Drawing.Size(138, 82)
        Me.radButton1.TabIndex = 0
        Me.radButton1.Text = "World" & Constants.vbCrLf & "Clock"
        Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.GettingStarted.My.Resources._1403_Globe
        CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "World" & Constants.vbCrLf & "Clock"
        CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(10)
        CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.LightBlue
        CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Lavender
        CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Purple
        CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlass
        CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Blue
        CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Opacity = 0.5
        CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
        CType(Me.radButton1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.radButton1)
        Me.Name = "Form1"
        Me.Text = "TPF"
        CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radButton1 As Telerik.WinControls.UI.RadButton
End Class
