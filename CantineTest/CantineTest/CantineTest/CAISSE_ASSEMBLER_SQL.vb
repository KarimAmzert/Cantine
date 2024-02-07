Public Class CAISSE_ASSEMBLER_SQL
    Inherits DATABASE_SQL

    Private Const CAISSE_NUMBER As Integer = 1

    Public Sub New()
        MyBase.New()
    End Sub

#Region "Update caisse"
    Public Sub UpdateCaisse(ByVal record As CAISSE_DTO)
        Dim Query As New SqlQuery_SQL

        Query.SQL = "UPDATE 
                    " & CAISSE_DTO.TABLE_NAME & "

                    SET 
                    [" & CAISSE_DTO.FIELD_AMOUNT & "] = [" & CAISSE_DTO.FIELD_AMOUNT & "] + " & record.Amount & "
                    
                    WHERE
                    [" & CAISSE_DTO.FIELD_ID & "] = " & CAISSE_NUMBER

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Insert History"
    Public Sub InsertHistory(record As CAISSE_DTO)
        ExecuteQuery(InsertHistorySqlQuery(record))
    End Sub

    Private Function InsertHistorySqlQuery(record As CAISSE_DTO) As SqlQuery_SQL
        Dim Query As New SqlQuery_SQL With {
            .SQL = InsertHistorySql(record)
        }
        Return Query
    End Function

    Private Function InsertHistorySql(record As CAISSE_DTO) As String
      return  "INSERT INTO 
              " & CAISSE_DTO.FIELD_TABLE_HISTORY & " (" &
              "[" & CAISSE_DTO.FIELD_AMOUNT & "], " &
              "[" & CAISSE_DTO.FIELD_BEFORE_VALUE & "], " &
              "[" & CAISSE_DTO.FIELD_AFTER_VALUE & "], " &
              "[" & CAISSE_DTO.FIELD_USER & "], " &
              "[" & CAISSE_DTO.FIELD_DESC & "]" & ")
              
              VALUES
              (" & record.Amount & ", " &
              record.BeforeValue & ", " &
              record.AfterValue & ", '" &
              record.User & "', '" &
              record.Desc & "')"
    End Function
#End Region

#Region "Get Caisse"
    Public Function GetCaisse() As CAISSE_DTO
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & CAISSE_DTO.FIELD_AMOUNT & "
                   
                   FROM 
                   " & CAISSE_DTO.TABLE_NAME & "
                   
                   WHERE 
                   [" & CAISSE_DTO.FIELD_ID & "] = " & CAISSE_NUMBER
        }

        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then

            Dim Record As New CAISSE_DTO With {
                .Amount = Data.Rows(0)(CAISSE_DTO.FIELD_AMOUNT)
            }

            Return Record
        Else
            Return New CAISSE_DTO
        End If
    End Function
#End Region

#Region "Get Caisse History"
    Public Function GetHistory() As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & CAISSE_DTO.FIELD_ID & ", 
                   [" & CAISSE_DTO.FIELD_USER & "], 
                   " & CAISSE_DTO.FIELD_AMOUNT & ", 
                   [" & CAISSE_DTO.FIELD_DESC & "], 
                   " & CAISSE_DTO.FIELD_BEFORE_VALUE & ", 
                   " & CAISSE_DTO.FIELD_AFTER_VALUE & ", 
                   " & "AdjustmentDate " & "

                   FROM 
                   " & CAISSE_DTO.FIELD_TABLE_HISTORY & "
                   
                   ORDER BY 
                   " & "AdjustmentDate DESC"
        }
        Return GetDatatable(Query)
    End Function
#End Region
End Class
