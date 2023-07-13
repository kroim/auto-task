<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelfReferencing
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
        Me.components = New System.ComponentModel.Container
        Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView
        Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nwindDataSet = New Databinding.NwindDataSet
        Me.employeesTableAdapter = New Databinding.NwindDataSetTableAdapters.EmployeesTableAdapter
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radTreeView1
        '
        Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
        Me.radTreeView1.DisplayMember = ""
        Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6!)
        Me.radTreeView1.Location = New System.Drawing.Point(15, 15)
        Me.radTreeView1.Name = "radTreeView1"
        Me.radTreeView1.Size = New System.Drawing.Size(268, 249)
        Me.radTreeView1.TabIndex = 0
        Me.radTreeView1.Text = "radTreeView1"
        Me.radTreeView1.ValueMember = ""
        '
        'employeesBindingSource
        '
        Me.employeesBindingSource.DataMember = "Employees"
        Me.employeesBindingSource.DataSource = Me.nwindDataSet
        '
        'nwindDataSet
        '
        Me.nwindDataSet.DataSetName = "NwindDataSet"
        Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'employeesTableAdapter
        '
        Me.employeesTableAdapter.ClearBeforeFill = True
        '
        'SelfReferencing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 279)
        Me.Controls.Add(Me.radTreeView1)
        Me.Name = "SelfReferencing"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "Self Referencing"
        Me.ThemeName = "ControlDefault"
        CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
    Private nwindDataSet As NwindDataSet
    Private employeesBindingSource As System.Windows.Forms.BindingSource
    Private employeesTableAdapter As Databinding.NwindDataSetTableAdapters.EmployeesTableAdapter
End Class
