Public Class CLIENT_DTO
    Public Const TABLE_NAME As String                  = "Client"
    Public Const FIELD_ID As String                    = "ID"
    Public Const FIELD_Nom As String                   = "Nom"
    Public Const FIELD_Client_FirstName As String      = "Client_FirstName"
    Public Const FIELD_Matricule As String             = "Matricule"
    Public Const FIELD_Credit As String                = "Credit"
    Public Const FIELD_Rank As String                  = "RANK"

    Public Property Nom As String                      = ""
    Public Property Client_FirstName As String         = ""
    Public Property Matricule As String                = ""
    Public Property Rank As String                     = ""
    Public Property Credit As Decimal                  = 0
    Public Property ID As Integer                      = 0
End Class
