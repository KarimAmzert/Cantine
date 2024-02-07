Public Class HISTORIQUE_ASSEMBLER_SQL
    Inherits DATABASE_SQL

    Private Const PARAM_USER As String = "@User"
    Private Const PARAM_UPC As String = "@UPC"

    Public Sub New()
        MyBase.New()
    End Sub
    
#Region "GetHistorique"
      Public Function GetHistorique() As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                    * 

                    FROM 
                    " & HISTORY_DTO.TABLE_NAME
        }
        Return GetDatatable(Query)
    End Function
#End Region
      
#Region "GetItemHistorique"
    Public Function GetItemHistorique(ByVal upc As String) As DataTable
        Dim parameterUPC As New SqlClient.SqlParameter With {
            .Direction       = ParameterDirection.Input,
            .DbType          = DbType.String,
            .ParameterName   = INVENTORY_DTO.FIELD_UPC,
            .Value           = upc
        }

        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                    * 

                    FROM 
                    " & HISTORY_DTO.TABLE_NAME & "

                    WHERE 
                    [" & HISTORY_DTO.FIELD_UPC & "] = " & PARAM_UPC & "

                    ORDER BY
                    Editdate DESC"
        }

        Query.Parameters.Add(parameterUPC)
        Return GetDatatable(Query)
    End Function
#End Region

#Region "Get User Item Historique"
    Public Function GetUserItemHistorique(ByVal username As String) As DataTable
        Dim parameterUser As New SqlClient.SqlParameter With {
            .Direction       = ParameterDirection.Input,
            .DbType          = DbType.String,
            .ParameterName   = HISTORY_DTO.FIELD_User,
            .Value           = username
        }

        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   * 

                   FROM 
                   " & HISTORY_DTO.TABLE_NAME & "

                   WHERE 
                   [" & HISTORY_DTO.FIELD_User & "] = " & PARAM_USER & "
                   
                   ORDER BY 
                   Editdate DESC"
        }

        Query.Parameters.Add(parameterUser)
        Return GetDatatable(Query)
    End Function
#End Region

#Region "InsertHistory"
    Public Sub InsertHistory(record As HISTORY_DTO)
        ExecuteQuery(InsertHistorySqlQuery(record))
    End Sub
    Private Function InsertHistorySqlQuery(record As HISTORY_DTO) As SqlQuery_SQL
        Dim Query As New SqlQuery_SQL With {
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
