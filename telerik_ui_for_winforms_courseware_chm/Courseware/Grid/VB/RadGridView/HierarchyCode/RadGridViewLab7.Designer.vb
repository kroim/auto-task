Imports Microsoft.VisualBasic
Imports System
Namespace _07_HierarchyCode
	Public Partial Class RadGridViewLab7
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radGridView1
            '
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(798, 424)
            Me.radGridView1.TabIndex = 0
            '
            'RadGridViewLab7
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(798, 424)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "RadGridViewLab7"
            Me.Text = "RadGridView Lab 7"
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private radGridView1 As Telerik.WinControls.UI.RadGridView
	End Class
End Namespace

