Imports iTextSharp.text
Imports iTextSharp.text.pdf

Friend Class CountSheetPDF
    Private Const MAX_ITEM_PER_PAGE As Integer = 14

    Private _Pages              As New Generic.List(Of StockTakingReportCollection)
    Private _TableFont          As New Font(Font.FontFamily.TIMES_ROMAN, 8F, Font.NORMAL)
    Private _TableFontBold      As New Font(Font.FontFamily.TIMES_ROMAN, 8F, Font.BOLD)

    Public Sub New(ByVal countSheetData As StockTakingReportCollection)
        CreatePagesData(countSheetData)
    End Sub
    Private Sub CreatePagesData(ByVal items As StockTakingReportCollection)
        Dim i As Integer
        Dim count As Integer = 0
        Dim page As StockTakingReportCollection = Nothing
        Dim pageNumber As Integer = 1

        If items.Count > 0 then 
            page        = GetNewPage(items(0), pageNumber)
        End If

        For i = 0 To items.Count - 1
            count = count + 1

            If count > MAX_ITEM_PER_PAGE Then
                _Pages.Add(page)
                
                pageNumber = pageNumber + 1
                page = GetNewPage(items(i), pageNumber)                                
                count = 1
            End If

            page.Add(items(i))            
        Next
        If page.Count > 0 Then
            _Pages.Add(page)
        End If
    End Sub

    Private Function GetNewPage(item As StockTakingReportDTO, Byval pageNumber As integer) As StockTakingReportCollection
        Return GetNewPage(pageNumber)
    End Function

    Private Function GetNewPage(Byval pageNumber As integer) As StockTakingReportCollection
        Dim page As New StockTakingReportCollection

        page.PageNumber = pageNumber 

        Return page
    End Function

    Public Sub CreatePDF(ByVal fileName As String)
        If System.IO.File.Exists(fileName) Then Kill(fileName)

        Dim fs As New system.IO.FileStream(fileName, system.IO.FileMode.Create, system.IO.FileAccess.Write, system.IO.FileShare.None)
        Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER)
        Dim pdfWriter as iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs)

        pdfWriter.AddViewerPreference(iTextSharp.text.pdf.PdfName.PICKTRAYBYPDFSIZE, iTextSharp.text.pdf.PdfBoolean.PDFTRUE)

        pdfWriter.PageEvent = new CountSheetPDF_PageEvents(_Pages.Count)
        Doc.Open()

        For i As Integer = 0 To _Pages.Count - 1
            doc.NewPage()

            AddTitle(doc, _Pages(i))

            AddBarcode(doc, _Pages(i))
            
            AddRowHeader(doc)
            AddDatagrid(doc, _Pages(i))

        Next

        Doc.Close()

        fs.dispose
    End Sub    

    Private Sub AddTitle(Byref doc As iTextSharp.text.Document, ByVal page As StockTakingReportCollection)
        Dim titleFont As New Font(Font.FontFamily.TIMES_ROMAN, 11F, Font.BOLD)

        doc.Add(New Paragraph("StockTaking", titleFont))

        Dim p1 As New Paragraph
        p1.SpacingAfter = 125
        p1.Alignment = Element.ALIGN_RIGHT

        doc.Add(p1)
    End Sub

    Private Sub AddBarcode(Byref doc As iTextSharp.text.Document, ByVal page As StockTakingReportCollection)
        Dim barcode As New iTextSharp.text.pdf.BarcodeQRCode(page.Create2DBarcode(), 175, 175, Nothing)
        Dim myImage As Image = barcode.GetImage()

        myImage.SetAbsolutePosition(425, 600)
        doc.Add(myImage)
    End Sub

     Private Sub AddRowHeader(Byref doc As iTextSharp.text.Document)
        Dim table As PdfPTable = GetDatagridTable()
        AddDataHeader(table)
        doc.Add(table)
     End Sub

    Private Function GetDatagridTable As PdfPTable
        Dim table As New PdfPTable(4)

        table.WidthPercentage = 100
        table.SetWidths(New Single() { 4.0F, 0.75F, 0.75F, 0.75F})

        Return table
    End Function

    Private Sub AddDataHeader(Byref table As PdfPTable)
        table.AddCell(New Phrase("Product Name", _TableFontBold))
        table.AddCell(New Phrase(StockTakingReportDTO.FIELD_UPC, _TableFontBold))
        table.AddCell(New Phrase("Qty", _TableFontBold))
        table.AddCell(New Phrase("Count", _TableFontBold))
    End Sub

    Private Sub AddDatagrid(Byref doc As iTextSharp.text.Document, ByVal data As StockTakingReportCollection)
        Dim table As PdfPTable = GetDatagridTable

        table.DefaultCell.FixedHeight = 40F
       
        For each record As StockTakingReportDTO In data
            AddData(table, record)
        Next

        doc.Add(table)
    End Sub

    Private Sub AddData(Byref table As PdfPTable, ByVal record As StockTakingReportDTO)
        table.AddCell(New Phrase(record.NOM, _TableFont))
        table.AddCell(New Phrase(record.UPC, _TableFont))
        table.AddCell(New Phrase(record.QUANTITE, _TableFont))
        table.AddCell(New Phrase("", _TableFont))
    End Sub

    Public Shared Sub CreateAndOpenPDF(ByVal data As StockTakingReportCollection, ByVal fileName As String)
        Dim report As New CountSheetPDF(data)

        report.CreatePDF(fileName)

        OpenPDF(fileName)
    End Sub
End Class
