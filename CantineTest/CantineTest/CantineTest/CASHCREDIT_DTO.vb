Public Class CASHCREDIT_DTO
    Public Const TABLE_NAME As String                       = "CashCredit"
    Public Const FIELD_Facture_ID As String                 = "Facture_ID"
    Public Const FIELD_Client_ID As String                  = "Client_ID"
    Public Const FIELD_CreditPayment As String              = "CreditPayment"
    Public Const FIELD_CashPayment As String                = "CashPayment"
    Public Const CASH_ID As Integer                         = 1
    Public Const CREDIT_ID As Integer                       = 2            
    Public Const CASH_CREDIT_ID As Integer                  = 3

    Public Property Facture_ID As Integer                   = 0
    Public Property Client_ID As Integer                    = 0
    Public Property CreditPayment As Decimal                = 0
    Public Property CashPayment As Decimal                  = 0
End Class
