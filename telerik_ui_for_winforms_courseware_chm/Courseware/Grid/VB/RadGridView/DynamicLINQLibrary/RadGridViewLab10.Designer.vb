Imports Microsoft.VisualBasic
Imports System
Namespace _10_DynamicLINQLibrary
	Public Partial Class RadGridViewLab10
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.numRecords = New System.Windows.Forms.NumericUpDown()
			Me.btnSort = New System.Windows.Forms.Button()
			Me.cbField = New System.Windows.Forms.ComboBox()
			Me.cbSortType = New System.Windows.Forms.ComboBox()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numRecords, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.Location = New System.Drawing.Point(12, 42)
			' 
			' 
			' 
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False
            Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(775, 328)
			Me.radGridView1.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(13, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(44, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Sort By:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(547, 13)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(102, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Number of Records:"
			' 
			' numRecords
			' 
			Me.numRecords.Location = New System.Drawing.Point(667, 12)
			Me.numRecords.Name = "numRecords"
			Me.numRecords.Size = New System.Drawing.Size(120, 20)
			Me.numRecords.TabIndex = 3
			' 
			' btnSort
			' 
			Me.btnSort.Location = New System.Drawing.Point(424, 8)
			Me.btnSort.Name = "btnSort"
			Me.btnSort.Size = New System.Drawing.Size(103, 23)
			Me.btnSort.TabIndex = 4
			Me.btnSort.Text = "Sort"
			Me.btnSort.UseVisualStyleBackColor = True
'			Me.btnSort.Click += New System.EventHandler(Me.btnSort_Click);
			' 
			' cbField
			' 
			Me.cbField.FormattingEnabled = True
			Me.cbField.Items.AddRange(New Object() { "SalesOrderID", "OrderDate", "SubTotal", "TaxAmt", "Freight", "TotalDue"})
			Me.cbField.Location = New System.Drawing.Point(63, 10)
			Me.cbField.Name = "cbField"
			Me.cbField.Size = New System.Drawing.Size(155, 21)
			Me.cbField.TabIndex = 5
			' 
			' cbSortType
			' 
			Me.cbSortType.FormattingEnabled = True
			Me.cbSortType.Items.AddRange(New Object() { "ASC", "DESC"})
			Me.cbSortType.Location = New System.Drawing.Point(234, 10)
			Me.cbSortType.Name = "cbSortType"
			Me.cbSortType.Size = New System.Drawing.Size(153, 21)
			Me.cbSortType.TabIndex = 6
			' 
			' RadGridViewLab10
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(798, 382)
			Me.Controls.Add(Me.cbSortType)
			Me.Controls.Add(Me.cbField)
			Me.Controls.Add(Me.btnSort)
			Me.Controls.Add(Me.numRecords)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "RadGridViewLab10"
			Me.Text = "RadGridView Lab 10"
            CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numRecords, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private numRecords As System.Windows.Forms.NumericUpDown
		Private WithEvents btnSort As System.Windows.Forms.Button
		Private cbField As System.Windows.Forms.ComboBox
		Private cbSortType As System.Windows.Forms.ComboBox
	End Class
End Namespace

