Public Class FACTUREDETAIL_DTO
    Public Const TABLE_NAME As String                  = "Factures_Detail"
    Public Const FIELD_ID As String                    = "ID"
    Public Const FIELD_Facture_ID As String            = "Facture_ID"
    Public Const FIELD_Product_name As String          = "Product_name"
    Public Const FIELD_Unit_Price As String            = "Unit_Price"
    Public Const FIELD_Qty As String                   = "Qty"
    Public Const FIELD_Sale As String                  = "Sale"
    Public Const FIELD_Reason_ID As String             = "Reason_ID"

    Public Property ID As Integer                      = 0
    Public Property Facture_ID As Integer              = 0
    Public Property Product_name As String             = ""
    Public Property Unit_Price As Decimal              = 0.00
    Public Property Qty As Integer                     = 0
    Public Property Reason_ID As Integer               = 0
    Public Property Sale As Decimal                    = 0.00
End Class
