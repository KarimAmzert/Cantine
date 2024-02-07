Public Class StockTakingReportCollection
    Inherits List(of StockTakingReportDTO)

    Public Property PageNumber As integer   = 1
    Public Property TotalPages As Integer   = 1    

    Public Function Create2DBarcode() As string
        Dim barcode As String = ""
        
        If Me.Count > 0 Then

            For Each record As StockTakingReportDTO In Me
                barcode =   barcode &
                            record.NOM                    & BARCODE_FIELD_DELIMITER & _
                            record.UPC                    & BARCODE_FIELD_DELIMITER & _
                            record.QUANTITE               & BARCODE_FIELD_DELIMITER 
            Next
        End If

        Return barcode
    End Function

    Public Function LoadFrom2DBarcode(ByVal barcode As String) as String        
        Dim bc As String = barcode

        Return bc
    End Function

    Public Sub CreateCountSheet()
        Try
            CountSheetPDF.CreateAndOpenPDF(Me, IMAGE_LOCATION & "\Resources\StockTaking.PDF")
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
End Class
