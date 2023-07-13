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
        Me.components = New System.ComponentModel.Container
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView
        Me.AdventureWorksDataSet = New HierarchyLoadOnDemand.AdventureWorksDataSet
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductTableAdapter
        Me.ProductModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductModelTableAdapter = New HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(557, 449)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'AdventureWorksDataSet
        '
        Me.AdventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
        Me.AdventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.AdventureWorksDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ProductModelBindingSource
        '
        Me.ProductModelBindingSource.DataMember = "ProductModel"
        Me.ProductModelBindingSource.DataSource = Me.AdventureWorksDataSet
        '
        'ProductModelTableAdapter
        '
        Me.ProductModelTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 449)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents AdventureWorksDataSet As HierarchyLoadOnDemand.AdventureWorksDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductModelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductModelTableAdapter As HierarchyLoadOnDemand.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter

End Class
