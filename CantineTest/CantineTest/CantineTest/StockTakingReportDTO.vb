Public Class StockTakingReportDTO
    Public Const FIELD_NOM                          As String = "Nom"
    Public Const FIELD_UPC                          As String = "UPC"
    Public Const FIELD_QUANTITE                     As String = "Quantité"

    Public Property NOM                             As String = ""
    Public Property UPC                             As String = ""
    Public Property QUANTITE                        As String = ""

    Public Sub New
    End Sub
    Public Sub New(Byval data As DataRow) 
        Me.NOM                          = data.Item(FIELD_NOM) & ""        
        Me.UPC                          = data.Item(FIELD_UPC) & ""
        Me.QUANTITE                     = data.Item(FIELD_QUANTITE) & ""
    End Sub
End Class                    

