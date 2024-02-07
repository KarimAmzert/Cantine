Public Class INVENTORY_DTO
    Public Const TABLE_NAME As String               = "Inventaire"
    Public Const FIELD_TABLEHISTORY As String       = "Inventaire_History"
    Public Const FIELD_ID As String                 = "ID"
    Public Const FIELD_NOM As String                = "Nom"
    Public Const FIELD_Prixvente As String          = "Prixvente"
    Public Const FIELD_Quantite As String           = "Quantité"
    Public Const FIELD_UOI As String                = "UOI"
    Public Const FIELD_UPC As String                = "UPC"
    Public Const FIELD_Minimum As String            = "Minimum"
    Public Const FIELD_Maximum As String            = "Maximum"
    Public Const FIELD_LastModifiedBy As String     = "LastModifiedBy"
    Public Const FIELD_Actif As String              = "Actif"

    Public Property ID As Integer               = 0
    Public Property NOM As String               = ""
    Public Property Prixvente As Decimal        = 0
    Public Property Quantité As Integer         = 0
    Public Property UOI As String               = ""
    Public Property UPC As String               = ""
    Public Property Minimum As Integer          = 0
    Public Property Maximum As Integer          = 0
    Public Property LastModifiedBy As String    = ""
    Public Property Actif As Boolean            = True

    Public Sub IsValid()
        If NOM.Length = 0 Then Throw New Exception("You must enter a product name")
        If UPC.Length = 0 Then Throw New Exception("You must enter a UPC")
        If NOM.Length > 50 Then NOM = NOM.Substring(0,49)
    End Sub

End Class
