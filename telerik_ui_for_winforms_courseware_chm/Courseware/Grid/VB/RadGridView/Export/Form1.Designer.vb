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
        Dim GridViewDecimalColumn29 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewDecimalColumn30 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewDecimalColumn31 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewDecimalColumn32 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewDecimalColumn33 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewDecimalColumn34 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewDecimalColumn35 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Dim GridViewDateTimeColumn5 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView
        Me.btnExportExcel = New Telerik.WinControls.UI.CommandBarButton
        Me.btnExportPDF = New Telerik.WinControls.UI.CommandBarButton
        Me.btnExportHTML = New Telerik.WinControls.UI.CommandBarButton
        Me.btnExportCSV = New Telerik.WinControls.UI.CommandBarButton
        Me.AdventureWorksDataSet = New Export.AdventureWorksDataSet
        Me.SalesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesPersonTableAdapter = New Export.AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoSize = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(811, 55)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnExportExcel, Me.btnExportPDF, Me.btnExportHTML, Me.btnExportCSV})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.SystemColors.Control
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(0, 55)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewDecimalColumn29.DataType = GetType(Integer)
        GridViewDecimalColumn29.FieldName = "SalesPersonID"
        GridViewDecimalColumn29.FormatString = ""
        GridViewDecimalColumn29.HeaderText = "SalesPersonID"
        GridViewDecimalColumn29.IsAutoGenerated = True
        GridViewDecimalColumn29.Name = "SalesPersonID"
        GridViewDecimalColumn29.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn29.Width = 132
        GridViewDecimalColumn30.DataType = GetType(Integer)
        GridViewDecimalColumn30.FieldName = "TerritoryID"
        GridViewDecimalColumn30.HeaderText = "TerritoryID"
        GridViewDecimalColumn30.IsAutoGenerated = True
        GridViewDecimalColumn30.IsVisible = False
        GridViewDecimalColumn30.Name = "TerritoryID"
        GridViewDecimalColumn30.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn31.FieldName = "SalesQuota"
        GridViewDecimalColumn31.FormatString = ""
        GridViewDecimalColumn31.HeaderText = "SalesQuota"
        GridViewDecimalColumn31.IsAutoGenerated = True
        GridViewDecimalColumn31.Name = "SalesQuota"
        GridViewDecimalColumn31.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn31.Width = 132
        GridViewDecimalColumn32.FieldName = "Bonus"
        GridViewDecimalColumn32.FormatString = ""
        GridViewDecimalColumn32.HeaderText = "Bonus"
        GridViewDecimalColumn32.IsAutoGenerated = True
        GridViewDecimalColumn32.Name = "Bonus"
        GridViewDecimalColumn32.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn32.Width = 132
        GridViewDecimalColumn33.FieldName = "CommissionPct"
        GridViewDecimalColumn33.FormatString = ""
        GridViewDecimalColumn33.HeaderText = "CommissionPct"
        GridViewDecimalColumn33.IsAutoGenerated = True
        GridViewDecimalColumn33.Name = "CommissionPct"
        GridViewDecimalColumn33.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn33.Width = 132
        GridViewDecimalColumn34.FieldName = "SalesYTD"
        GridViewDecimalColumn34.FormatString = ""
        GridViewDecimalColumn34.HeaderText = "SalesYTD"
        GridViewDecimalColumn34.IsAutoGenerated = True
        GridViewDecimalColumn34.Name = "SalesYTD"
        GridViewDecimalColumn34.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn34.Width = 132
        GridViewDecimalColumn35.FieldName = "SalesLastYear"
        GridViewDecimalColumn35.FormatString = ""
        GridViewDecimalColumn35.HeaderText = "SalesLastYear"
        GridViewDecimalColumn35.IsAutoGenerated = True
        GridViewDecimalColumn35.Name = "SalesLastYear"
        GridViewDecimalColumn35.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn35.Width = 135
        GridViewTextBoxColumn5.DataType = GetType(System.Guid)
        GridViewTextBoxColumn5.FieldName = "rowguid"
        GridViewTextBoxColumn5.HeaderText = "rowguid"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.IsVisible = False
        GridViewTextBoxColumn5.Name = "rowguid"
        GridViewDateTimeColumn5.FieldName = "ModifiedDate"
        GridViewDateTimeColumn5.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        GridViewDateTimeColumn5.HeaderText = "ModifiedDate"
        GridViewDateTimeColumn5.IsAutoGenerated = True
        GridViewDateTimeColumn5.IsVisible = False
        GridViewDateTimeColumn5.Name = "ModifiedDate"
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn29, GridViewDecimalColumn30, GridViewDecimalColumn31, GridViewDecimalColumn32, GridViewDecimalColumn33, GridViewDecimalColumn34, GridViewDecimalColumn35, GridViewTextBoxColumn5, GridViewDateTimeColumn5})
        Me.RadGridView1.MasterTemplate.DataSource = Me.SalesPersonBindingSource
        Me.RadGridView1.MasterTemplate.EnableGrouping = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.Size = New System.Drawing.Size(811, 413)
        Me.RadGridView1.TabIndex = 1
        Me.RadGridView1.Text = "RadGridView1"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.AccessibleDescription = "Export Excel"
        Me.btnExportExcel.AccessibleName = "Export Excel"
        Me.btnExportExcel.DisplayName = "CommandBarButton1"
        Me.btnExportExcel.DrawText = True
        Me.btnExportExcel.Image = Nothing
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnExportExcel.VisibleInOverflowMenu = True
        '
        'btnExportPDF
        '
        Me.btnExportPDF.AccessibleDescription = "Export PDF"
        Me.btnExportPDF.AccessibleName = "Export PDF"
        Me.btnExportPDF.DisplayName = "CommandBarButton2"
        Me.btnExportPDF.DrawText = True
        Me.btnExportPDF.Image = Nothing
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Text = "Export PDF"
        Me.btnExportPDF.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnExportPDF.VisibleInOverflowMenu = True
        '
        'btnExportHTML
        '
        Me.btnExportHTML.AccessibleDescription = "Export HTML"
        Me.btnExportHTML.AccessibleName = "Export HTML"
        Me.btnExportHTML.DisplayName = "CommandBarButton3"
        Me.btnExportHTML.DrawText = True
        Me.btnExportHTML.Image = Nothing
        Me.btnExportHTML.Name = "btnExportHTML"
        Me.btnExportHTML.Text = "Export HTML"
        Me.btnExportHTML.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnExportHTML.VisibleInOverflowMenu = True
        '
        'btnExportCSV
        '
        Me.btnExportCSV.AccessibleDescription = "Export CSV"
        Me.btnExportCSV.AccessibleName = "Export CSV"
        Me.btnExportCSV.DisplayName = "CommandBarButton4"
        Me.btnExportCSV.DrawText = True
        Me.btnExportCSV.Image = Nothing
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Text = "Export CSV"
        Me.btnExportCSV.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.btnExportCSV.VisibleInOverflowMenu = True
        '
        'AdventureWorksDataSet
        '
        Me.AdventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
        Me.AdventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesPersonBindingSource
        '
        Me.SalesPersonBindingSource.DataMember = "SalesPerson"
        Me.SalesPersonBindingSource.DataSource = Me.AdventureWorksDataSet
        '
        'SalesPersonTableAdapter
        '
        Me.SalesPersonTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 468)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnExportExcel As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnExportPDF As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnExportHTML As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnExportCSV As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents AdventureWorksDataSet As Export.AdventureWorksDataSet
    Friend WithEvents SalesPersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesPersonTableAdapter As Export.AdventureWorksDataSetTableAdapters.SalesPersonTableAdapter
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView

End Class
