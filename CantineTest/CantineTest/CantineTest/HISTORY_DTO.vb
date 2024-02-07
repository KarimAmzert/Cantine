Public Class HISTORY_DTO
    Public Const TABLE_NAME As String                  = "Historique"
    Public Const FIELD_User As String                  = "User"
    Public Const FIELD_Desc As String                  = "Desc"
    Public Const FIELD_UPC As String                   = "UPC"
    Public Const FIELD_Action As String                = "Action"
    Public Const FIELD_Remarques As String             = "Remarques"
    Public Const FIELD_BeforeValue As String           = "BeforeValue"
    Public Const FIELD_AfterValue As String            = "AfterValue"

    Public Property User As String                     = ""
    Public Property UPC As String                      = ""
    Public Property Desc As String                     = ""
    Public Property Action As String                   = ""
    Public Property Remarques As String                = ""
    Public Property BeforeValue As String              = ""
    Public Property AfterValue As String               = ""
End Class
