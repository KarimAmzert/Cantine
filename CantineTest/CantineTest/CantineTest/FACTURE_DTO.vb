Public Class FACTURE_DTO
    Public Const TABLE_NAME As String                  = "Factures"
    Public Const FIELD_ID As String                    = "ID"
    Public Const FIELD_Client_ID As String             = "Client_ID"
    Public Const FIELD_Cashier_ID As String            = "Cashier_ID"
    Public Const FIELD_Payment_Type_ID As String       = "Payment_Type_ID"
    Public Const CREDIT_LIMIT As Decimal               = 25.00

    Public Property ID As Integer                      = 0
    Public Property Client_ID As Integer               = 0
    Public Property Cashier_ID As Integer              = 0
    Public Property Payment_Type_ID As Integer         = 0
End Class
