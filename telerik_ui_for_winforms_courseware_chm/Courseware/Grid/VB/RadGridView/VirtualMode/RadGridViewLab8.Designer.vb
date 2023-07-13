Imports Microsoft.VisualBasic
Imports System
Namespace _08_VirtualMode
	Public Partial Class RadGridViewLab8
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
		  Me.components = New System.ComponentModel.Container()
		  Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
		  Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.adventureWorksDataSet = New Global.AdventureWorksDataSet()
		  Me.contactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.contactTableAdapter = New AdventureWorksDataSetTableAdapters.ContactTableAdapter()
		  CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.adventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.contactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radGridView1
            ' 
            Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radGridView1.Location = New System.Drawing.Point(0, 0)
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Size = New System.Drawing.Size(804, 351)
            Me.radGridView1.TabIndex = 0
            '		  Me.radGridView1.CellValueNeeded += New Telerik.WinControls.UI.GridViewCellValueEventHandler(Me.radGridView1_CellValueNeeded_1);
            ' 
            ' timer1
            ' 
            '		  Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
            ' 
            ' adventureWorksDataSet
            ' 
            Me.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
            Me.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' contactBindingSource
            ' 
            Me.contactBindingSource.DataMember = "Contact"
            Me.contactBindingSource.DataSource = Me.adventureWorksDataSet
            ' 
            ' contactTableAdapter
            ' 
            Me.contactTableAdapter.ClearBeforeFill = True
            ' 
            ' RadGridViewLab8
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(804, 351)
            Me.Controls.Add(Me.radGridView1)
            Me.Name = "RadGridViewLab8"
            Me.Text = "RadGridView Lab 8"
            '		  Me.Load += New System.EventHandler(Me.RadGridViewLab8_Load);
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		  CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		  CType(Me.adventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		  CType(Me.contactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		  Me.ResumeLayout(False)
		  Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private adventureWorksDataSet As AdventureWorksDataSet
		Private contactBindingSource As System.Windows.Forms.BindingSource
        Private contactTableAdapter As AdventureWorksDataSetTableAdapters.ContactTableAdapter
	End Class
End Namespace

