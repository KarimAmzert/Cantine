Imports iTextSharp.text.PDF
Imports iTextSharp.text

Friend Class CountSheetPDF_PageEvents
    Inherits PdfPageEventHelper

    Private Shared footerFont As New Font(Font.FontFamily.TIMES_ROMAN, 8F, Font.NORMAL)

    Private _TotalPage As Integer 

    Public Sub New(ByVal totalPage As Integer)
        MyBase.New()
        _TotalPage = totalPage
    End Sub

    Public Overrides Sub OnEndPage(writer As PdfWriter, theDocument As Document)
        MyBase.OnEndPage(writer, theDocument)

        Dim tabFot as New PdfPTable(2)
        tabFot.TotalWidth = theDocument.PageSize.Width - theDocument.LeftMargin - theDocument.RightMargin

        dim cell1 As New PdfPCell(New Phrase(Format(Now, "g"), footerFont))
        cell1.Border = 0
        tabFot.AddCell(cell1)

        dim cell2 As New PdfPCell(New Phrase("Page " & writer.PageNumber.ToString & " / " & _TotalPage.ToString, footerFont))
        cell2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        cell2.Border = 0
        tabFot.AddCell(cell2)

        tabFot.WriteSelectedRows(0, -1, theDocument.LeftMargin, theDocument.Bottom - 5, writer.DirectContent)
    End Sub
End Class
