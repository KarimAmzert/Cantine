Public Class CAISSE_DTO
    Public Const TABLE_NAME As String               = "Caisse"
    Public Const FIELD_ID As String                 = "ID"
    Public Const FIELD_AMOUNT As String             = "Amount"
    Public Const FIELD_TABLE_HISTORY As String      = "Caisse_Historique"
    Public Const FIELD_DESC As String               = "Desc"
    Public Const FIELD_BEFORE_VALUE As String       = "BeforeValue"
    Public Const FIELD_AFTER_VALUE As String        = "AfterValue"
    Public Const FIELD_USER As String               = "User"

    Public Property Amount As Decimal               = 0
    Public Property BeforeValue As Decimal          = 0
    Public Property AfterValue As Decimal           = 0
    Public Property Desc As String                  = ""
    Public Property User As String                  = ""
End Class
