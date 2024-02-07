Public Class HISTORIQUE_ASSEMBLER
    Inherits DATABASE_ACCESS

    Public Sub New()
        MyBase.New("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_LOCATION)
    End Sub
    
#Region "GetHistorique"
      Public Function GetHistorique() As DataTable
        Return GetDatatable("SELECT * FROM " & HISTORY_DTO.TABLE_NAME)
    End Function
#End Region
      
#Region "GetItemHistorique"
    Public Function GetItemHistorique(ByVal upc As String) As DataTable
        Return GetDatatable("SELECT * FROM " & HISTORY_DTO.TABLE_NAME & " WHERE [" & HISTORY_DTO.FIELD_UPC & "] = '" & upc & "' ORDER BY Editdate DESC")
    End Function
#End Region

#Region "Get User Item Historique"
    Public Function GetUserItemHistorique(ByVal username As String) As DataTable
        Return GetDatatable("SELECT * FROM " & HISTORY_DTO.TABLE_NAME & " WHERE [" & HISTORY_DTO.FIELD_User & "] = '" & username & "' ORDER BY Editdate DESC")
    End Function
#End Region

#Region "InsertHistory"
    Public Sub InsertHistory(record As HISTORY_DTO)
        ExecuteQuery(InsertHistorySqlQuery(record))
    End Sub
    Private Function InsertHistorySqlQuery(record As HISTORY_DTO) As SqlQuery
        Dim Query As New SqlQuery With {
            .SQL         = InsertHistorySql(record)
        }
        Return Query
    End Function
    Private Function InsertHistorySql(record As HISTORY_DTO) As String
      return "INSERT INTO " & HISTORY_DTO.TABLE_NAME & " (" &
                      "[" & HISTORY_DTO.FIELD_User & "], " &
                      "[" & HISTORY_DTO.FIELD_Desc & "], " &
                      "[" & HISTORY_DTO.FIELD_UPC & "], " &
                      "[" & HISTORY_DTO.FIELD_Action & "], " &
                      "[" & HISTORY_DTO.FIELD_Remarques & "], " &
                      "[" & HISTORY_DTO.FIELD_BeforeValue & "], " &
                      "[" & HISTORY_DTO.FIELD_AfterValue & "]" & ") 
                   VALUES (
                       '" & record.User & "',
                       '" & record.Desc & "', 
                       '" & record.UPC & "', 
                       '" & record.Action & "', 
                       '" & record.Remarques & "', 
                       '" & record.BeforeValue & "',  
                       '" & record.AfterValue & "')"
    End Function
#End Region
End Class
