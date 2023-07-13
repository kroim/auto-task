Imports Microsoft.VisualBasic
Imports System
Namespace _06_HierarcyAuto
	Public Partial Class RadGridViewLab6
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
            Me.components = New System.ComponentModel.Container
            Dim GridViewRelation1 As Telerik.WinControls.UI.GridViewRelation = New Telerik.WinControls.UI.GridViewRelation
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadGridViewLab6))
            Dim GridViewRelation2 As Telerik.WinControls.UI.GridViewRelation = New Telerik.WinControls.UI.GridViewRelation
            Dim GridViewRelation3 As Telerik.WinControls.UI.GridViewRelation = New Telerik.WinControls.UI.GridViewRelation
            Me.adventureWorksDataSet = New AdventureWorksDataSet
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
            Me.adventureWorksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.adventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.adventureWorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'adventureWorksDataSet
            '
            Me.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
            Me.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'radGridView1
            '
            Me.radGridView1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            '
            'radGridView1
            '
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.MasterTemplate.DataSource = Me.adventureWorksDataSetBindingSource
            Me.radGridView1.Name = "radGridView1"
            GridViewRelation1.ChildColumnNames = CType(resources.GetObject("GridViewRelation1.ChildColumnNames"), System.Collections.Specialized.StringCollection)
            GridViewRelation1.ParentColumnNames = CType(resources.GetObject("GridViewRelation1.ParentColumnNames"), System.Collections.Specialized.StringCollection)
            GridViewRelation1.ParentTemplate = Me.radGridView1.MasterTemplate
            GridViewRelation1.RelationName = "AdventureWorksDataSet_ProductVendor"
            GridViewRelation2.ChildColumnNames = CType(resources.GetObject("GridViewRelation2.ChildColumnNames"), System.Collections.Specialized.StringCollection)
            GridViewRelation2.ParentColumnNames = CType(resources.GetObject("GridViewRelation2.ParentColumnNames"), System.Collections.Specialized.StringCollection)
            GridViewRelation2.ParentTemplate = Me.radGridView1.MasterTemplate
            GridViewRelation2.RelationName = "AdventureWorksDataSet_Vendor"
            GridViewRelation3.ChildColumnNames = CType(resources.GetObject("GridViewRelation3.ChildColumnNames"), System.Collections.Specialized.StringCollection)
            GridViewRelation3.ParentColumnNames = CType(resources.GetObject("GridViewRelation3.ParentColumnNames"), System.Collections.Specialized.StringCollection)
            GridViewRelation3.RelationName = "Vendor_"
            Me.radGridView1.Relations.AddRange(New Telerik.WinControls.UI.GridViewRelation() {GridViewRelation1, GridViewRelation2, GridViewRelation3})
            Me.radGridView1.Size = New System.Drawing.Size(804, 350)
            Me.radGridView1.TabIndex = 0
            Me.radGridView1.ThemeName = "ControlDefault"
            '
            'adventureWorksDataSetBindingSource
            '
            Me.adventureWorksDataSetBindingSource.DataSource = Me.adventureWorksDataSet
            Me.adventureWorksDataSetBindingSource.Position = 0
            '
            'RadGridViewLab6
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(804, 350)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "RadGridViewLab6"
            Me.Text = "RadGridView Lab 6"
            CType(Me.adventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.adventureWorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private adventureWorksDataSetBindingSource As System.Windows.Forms.BindingSource
		Private adventureWorksDataSet As AdventureWorksDataSet
		Private gridViewTemplate1 As Telerik.WinControls.UI.GridViewTemplate
    End Class
End Namespace

