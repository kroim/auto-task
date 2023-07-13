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
        Me.radMultiColumnComboBox1 = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.btnShowPopup = New Telerik.WinControls.UI.RadButtonElement
        Me.lblSelected = New Telerik.WinControls.UI.RadLabelElement
        CType(Me.radMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radMultiColumnComboBox1
        '
        '
        'radMultiColumnComboBox1.NestedRadGridView
        '
        Me.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radMultiColumnComboBox1.EditorControl.Location = New System.Drawing.Point(4, 1)
        '
        '
        '
        Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
        Me.radMultiColumnComboBox1.EditorControl.ReadOnly = True
        Me.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
        Me.radMultiColumnComboBox1.EditorControl.Size = New System.Drawing.Size(282, 104)
        Me.radMultiColumnComboBox1.EditorControl.TabIndex = 0
        Me.radMultiColumnComboBox1.EditorControl.Visible = False
        Me.radMultiColumnComboBox1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.radMultiColumnComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.radMultiColumnComboBox1.Location = New System.Drawing.Point(12, 21)
        Me.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1"
        '
        '
        '
        Me.radMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radMultiColumnComboBox1.RootElement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.radMultiColumnComboBox1.Size = New System.Drawing.Size(274, 20)
        Me.radMultiColumnComboBox1.TabIndex = 0
        Me.radMultiColumnComboBox1.ThemeName = "Breeze"
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnShowPopup, Me.lblSelected})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 282)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(298, 24)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
        Me.radStatusStrip1.Text = "radStatusStrip1"
        Me.radStatusStrip1.ThemeName = "Breeze"
        '
        'btnShowPopup
        '
        Me.btnShowPopup.CanFocus = True
        Me.btnShowPopup.Margin = New System.Windows.Forms.Padding(1)
        Me.btnShowPopup.Name = "btnShowPopup"
        Me.radStatusStrip1.SetSpring(Me.btnShowPopup, False)
        Me.btnShowPopup.Text = "ShowPopup"
        '
        'lblSelected
        '
        Me.lblSelected.Margin = New System.Windows.Forms.Padding(1)
        Me.lblSelected.Name = "lblSelected"
        Me.radStatusStrip1.SetSpring(Me.lblSelected, False)
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 306)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Controls.Add(Me.radMultiColumnComboBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "RadForm1"
        Me.Text = "RadMultiColumnComboBox"
        Me.ThemeName = "Breeze"
        CType(Me.radMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents radMultiColumnComboBox1 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private WithEvents btnShowPopup As Telerik.WinControls.UI.RadButtonElement
    Private lblSelected As Telerik.WinControls.UI.RadLabelElement
End Class
