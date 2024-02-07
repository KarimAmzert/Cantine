Public Class USER_DTO
    Public Const TABLE_NAME As String               = "Users"
    Public Const FIELD_ID As String                 = "ID"
    Public Const FIELD_Username As String           = "Username"
    Public Const FIELD_Salt As String               = "Salt"
    Public Const FIELD_Password As String           = "Password"
    Public Const FIELD_Cashier As String            = "Cashier"
    Public Const FIELD_Inventory As String          = "Inventory"
    Public Const FIELD_StockTaking As String        = "StockTaking"
    Public Const FIELD_Active As String             = "Active"
    Public Const FIELD_Admin As String              = "Admin"
    Public Const FIELD_ResetPassword As String      = "ResetPassword"

    Public Property ID As Integer                   = 0
    Public Property Username As String              = ""
    Public Property Salt As String                  = ""
    Public Property Password As String              = ""
    Public Property Cashier As Boolean              = False
    Public Property Inventory As Boolean            = False
    Public Property StockTaking As Boolean          = False
    Public Property Active As Boolean               = False
    Public Property Admin As Boolean                = False
    Public Property ResetPassword As Boolean        = False
End Class
