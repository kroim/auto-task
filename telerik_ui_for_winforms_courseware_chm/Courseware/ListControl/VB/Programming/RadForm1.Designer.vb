<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.RadListControl1 = New Telerik.WinControls.UI.RadListControl
        Me.btnLocate = New Telerik.WinControls.UI.RadButton
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox
        Me.rbDescending = New Telerik.WinControls.UI.RadRadioButton
        Me.rbAscending = New Telerik.WinControls.UI.RadRadioButton
        Me.rbNone = New Telerik.WinControls.UI.RadRadioButton
        Me.btnShowSelected = New Telerik.WinControls.UI.RadButton
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLocate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rbDescending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbAscending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbNone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnShowSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadListControl1
        '
        Me.RadListControl1.CaseSensitiveSort = True
        Me.RadListControl1.ItemHeight = 18
        Me.RadListControl1.Location = New System.Drawing.Point(11, 51)
        Me.RadListControl1.Name = "RadListControl1"
        Me.RadListControl1.Size = New System.Drawing.Size(282, 270)
        Me.RadListControl1.TabIndex = 0
        Me.RadListControl1.Text = "RadListControl1"
        '
        'btnLocate
        '
        Me.btnLocate.Location = New System.Drawing.Point(157, 12)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(135, 33)
        Me.btnLocate.TabIndex = 1
        Me.btnLocate.Text = "Locate"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.rbDescending)
        Me.RadGroupBox1.Controls.Add(Me.rbAscending)
        Me.RadGroupBox1.Controls.Add(Me.rbNone)
        Me.RadGroupBox1.FooterImageIndex = -1
        Me.RadGroupBox1.FooterImageKey = ""
        Me.RadGroupBox1.HeaderImageIndex = -1
        Me.RadGroupBox1.HeaderImageKey = ""
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox1.HeaderText = "RadGroupBox1"
        Me.RadGroupBox1.Location = New System.Drawing.Point(11, 327)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        '
        '
        Me.RadGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.RadGroupBox1.Size = New System.Drawing.Size(281, 52)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.Text = "RadGroupBox1"
        '
        'rbDescending
        '
        Me.rbDescending.AutoSize = True
        Me.rbDescending.Location = New System.Drawing.Point(146, 27)
        Me.rbDescending.Name = "rbDescending"
        Me.rbDescending.Size = New System.Drawing.Size(79, 18)
        Me.rbDescending.TabIndex = 2
        Me.rbDescending.Text = "Descending"
        '
        'rbAscending
        '
        Me.rbAscending.AutoSize = True
        Me.rbAscending.Location = New System.Drawing.Point(68, 27)
        Me.rbAscending.Name = "rbAscending"
        Me.rbAscending.Size = New System.Drawing.Size(72, 18)
        Me.rbAscending.TabIndex = 1
        Me.rbAscending.Text = "Ascending"
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Location = New System.Drawing.Point(14, 27)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(48, 18)
        Me.rbNone.TabIndex = 0
        Me.rbNone.Text = "None"
        '
        'btnShowSelected
        '
        Me.btnShowSelected.Location = New System.Drawing.Point(12, 12)
        Me.btnShowSelected.Name = "btnShowSelected"
        Me.btnShowSelected.Size = New System.Drawing.Size(124, 32)
        Me.btnShowSelected.TabIndex = 4
        Me.btnShowSelected.Text = "Show Selected"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 384)
        Me.Controls.Add(Me.btnShowSelected)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.btnLocate)
        Me.Controls.Add(Me.RadListControl1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form1"
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLocate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rbDescending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbAscending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbNone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnShowSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadListControl1 As Telerik.WinControls.UI.RadListControl
    Friend WithEvents btnLocate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rbNone As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbAscending As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbDescending As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents btnShowSelected As Telerik.WinControls.UI.RadButton

End Class
