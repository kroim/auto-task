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
        Me.btnAdd = New Telerik.WinControls.UI.RadButton
        Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton
        Me.btnDelete = New Telerik.WinControls.UI.RadButton
        Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(98, 245)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.ThemeName = "Desert"
        '
        'radGridView1
        '
        Me.radGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radGridView1.Location = New System.Drawing.Point(6, 8)
        Me.radGridView1.Name = "radGridView1"
        Me.radGridView1.Padding = New System.Windows.Forms.Padding(1)
        Me.radGridView1.Size = New System.Drawing.Size(330, 231)
        Me.radGridView1.TabIndex = 2
        Me.radGridView1.ThemeName = "Desert"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(179, 245)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "Desert"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(260, 245)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.ThemeName = "Desert"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 274)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.radGridView1)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(3)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "IBindingList"
        Me.ThemeName = "Desert"
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Private radGridView1 As Telerik.WinControls.UI.RadGridView
    Private WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Private WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
End Class
