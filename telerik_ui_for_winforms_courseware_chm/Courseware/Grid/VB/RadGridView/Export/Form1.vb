Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Export.ExcelML
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export.HTML
Imports Telerik.WinControls.UI.Export.CSV

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdventureWorksDataSet.SalesPerson' table. You can move, or remove it, as needed.
        Me.SalesPersonTableAdapter.Fill(Me.AdventureWorksDataSet.SalesPerson)

    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = [String].Format("{0} (*{1})|*{1}", "Excel Files", ".xls")
        If sfd.ShowDialog() = DialogResult.OK Then
            'create instance of the exporter
            Dim exporter As New ExportToExcelML(Me.RadGridView1)
            'define the file extension 
            exporter.FileExtension = "xls"
            'define what action should be taken for the hidden columns
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
            'should it export formatting
            exporter.ExportVisualSettings = True
            'prevent exporting of summaries
            exporter.SummariesExportOption = SummariesOption.DoNotExport
            'set the sheet max rows
            exporter.SheetMaxRows = ExcelMaxRows._1048576
            'set the sheet name
            exporter.SheetName = "Sheet"

            AddHandler exporter.ExcelCellFormatting, AddressOf exporter_ExcelCellFormatting
            AddHandler exporter.ExcelTableCreated, AddressOf exporter_ExcelTableCreated

            'run the export
            exporter.RunExport(sfd.FileName)
            MessageBox.Show("Export completed")

        End If
    End Sub

    Sub exporter_ExcelTableCreated(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Export.ExcelML.ExcelTableCreatedEventArgs)
        Dim headerText As String = "Custom added header text."
        Dim style As SingleStyleElement = DirectCast(sender, ExportToExcelML).AddCustomExcelRow(e.ExcelTableElement, 50, headerText)
        style.FontStyle.Bold = True
        style.FontStyle.Size = 18
        style.FontStyle.Color = Color.White
        style.InteriorStyle.Color = Color.Red
        style.InteriorStyle.Pattern = InteriorPatternType.Solid
        style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center
        style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center
    End Sub

    Sub exporter_ExcelCellFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Export.ExcelML.ExcelCellFormattingEventArgs)
        If e.GridRowInfoType Is GetType(GridViewTableHeaderRowInfo) Then
            Dim headerBorder As New BorderStyles()
            headerBorder.Color = Color.Black
            headerBorder.Weight = 2
            headerBorder.LineStyle = LineStyle.Continuous
            headerBorder.PositionType = PositionType.Bottom
            e.ExcelStyleElement.Borders.Add(headerBorder)
        ElseIf e.GridColumnIndex = RadGridView1.Columns("SalesLastYear").Index Then
            Dim value As Integer = Convert.ToInt32(RadGridView1.Rows(e.GridRowIndex).Cells(e.GridColumnIndex).Value)
            If value > 1500000 Then
                e.ExcelStyleElement.InteriorStyle.Color = Color.Yellow
                e.ExcelStyleElement.AlignmentElement.WrapText = True
            End If
        End If
    End Sub

    Private Sub btnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportPDF.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = [String].Format("{0} (*{1})|*{1}", "PDF Files", ".pdf")
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim exporter As New ExportToPDF(Me.RadGridView1)
            exporter.FileExtension = "pdf"
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
            exporter.ExportVisualSettings = True
            exporter.PageTitle = "My Page Title"
            exporter.SummariesExportOption = SummariesOption.DoNotExport
            exporter.FitToPageWidth = True
            exporter.Scale = 1.2F
            exporter.TableBorderThickness = 1
            exporter.PdfExportSettings.PageHeight = 210
            exporter.PdfExportSettings.PageWidth = 297
            exporter.PdfExportSettings.Author = "Telerik"
            AddHandler exporter.HTMLCellFormatting, AddressOf exporter_HTMLCellFormatting
            exporter.RunExport(sfd.FileName)
            MessageBox.Show("Export completed")
        End If
    End Sub

    Sub exporter_HTMLCellFormatting(ByVal sender As System.Object, ByVal e As HTMLCellFormattingEventArgs)
        If e.GridRowIndex > -1 AndAlso e.GridColumnIndex = RadGridView1.Columns("SalesLastYear").Index Then
            Dim value As Integer = Convert.ToInt32(RadGridView1.Rows(e.GridRowIndex).Cells(e.GridColumnIndex).Value)
            'cells with value over 1500000 will be yellow
            If value > 1500000 Then
                e.HTMLCellElement.Styles.Add("background-color", ColorTranslator.ToHtml(Color.Yellow))
            End If
        End If
    End Sub

    Private Sub btnExportHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportHTML.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = [String].Format("{0} (*{1})|*{1}", "HTML Files", ".html")
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim exporter As New ExportToHTML(Me.RadGridView1)
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
            exporter.ExportVisualSettings = True
            exporter.SummariesExportOption = SummariesOption.ExportAll
            exporter.TableCaption = "My Table"
            AddHandler exporter.HTMLTableCaptionFormatting, AddressOf exporter_HTMLTableCaptionFormatting
            exporter.RunExport(sfd.FileName)
            MessageBox.Show("Export completed")
        End If
    End Sub

    Sub exporter_HTMLTableCaptionFormatting(ByVal sender As System.Object, ByVal e As HTMLTableCaptionFormattingEventArgs)
        e.TableCaptionElement.Styles.Add("background-color", ColorTranslator.ToHtml(Color.Red))
        e.TableCaptionElement.Styles.Add("font-size", "200%")
        e.TableCaptionElement.Styles.Add("color", ColorTranslator.ToHtml(Color.Yellow))
        e.TableCaptionElement.Styles.Add("font-weight", "bold")
        e.CaptionText = "My Table Caption"
    End Sub

    Private Sub btnExportCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportCSV.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = [String].Format("{0} (*{1})|*{1}", "CSV Files", ".csv")
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim exporter As New ExportToCSV(Me.RadGridView1)
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
            exporter.SummariesExportOption = SummariesOption.DoNotExport
            AddHandler exporter.CSVCellFormatting, AddressOf exporter_CSVCellFormatting
            AddHandler exporter.CSVTableCreated, AddressOf exporter_CSVTableCreated
            exporter.RunExport(sfd.FileName)
            MessageBox.Show("Export completed")
        End If
    End Sub


    Private Sub exporter_CSVTableCreated(ByVal sender As Object, ByVal e As CSVTableCreatedEventArgs)
        DirectCast(sender, ExportToCSV).AddCustomCSVRow(e.CSVTableElement, "MY TABLE CAPTION")
    End Sub

    Private Sub exporter_CSVCellFormatting(ByVal sender As Object, ByVal e As CSVCellFormattingEventArgs)
        If e.GridColumnIndex = 8 AndAlso e.GridRowInfoType Is GetType(GridViewDataRowInfo) Then
            e.CSVCellElement.Value = "111111"
        End If
    End Sub

End Class
