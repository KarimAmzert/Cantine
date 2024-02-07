Public Class CLIENT_ASSEMBLER_SQL
    Inherits DATABASE_SQL

    Private Const PARAM_FIRSTNAME   As String = "@Client_FirstName"
    Private Const PARAM_LASTNAME    As String = "@Nom"
    Private Const PARAM_MATRICULE   As String = "@Matricule"

    Public Sub New()
        MyBase.New()
    End Sub

#Region "Get all clients"
    Public Function GetAllClients() As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & CLIENT_DTO.FIELD_ID & ", 
                   " & CLIENT_DTO.FIELD_Nom & ", 
                   " & CLIENT_DTO.FIELD_Client_FirstName & ", 
                   [" & CLIENT_DTO.FIELD_Rank & "], 
                   " & CLIENT_DTO.FIELD_Matricule & ", 
                   " & CLIENT_DTO.FIELD_Credit & "
                   
                   FROM 
                   " & CLIENT_DTO.TABLE_NAME & "

                   ORDER BY 
                   " & CLIENT_DTO.FIELD_Nom
        }
        Return GetDatatable(Query)
    End Function
#End Region

#Region "Get Client by matricule"
    Public Function getClientByMatricule(ByVal matricule As String) As CLIENT_COLLECTION
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   * 

                   FROM 
                   " & CLIENT_DTO.TABLE_NAME & "

                   WHERE 
                   " & CLIENT_DTO.FIELD_Matricule & " = " & PARAM_MATRICULE & "

                   OR 
                   " & CLIENT_DTO.FIELD_Nom & " LIKE " & PARAM_MATRICULE
        }

        Query.Parameters.Add(New SqlClient.SqlParameter(PARAM_MATRICULE, matricule))
        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then
            Dim records As New CLIENT_COLLECTION

            For Each row As DataRow In Data.Rows
                Dim record As New CLIENT_DTO With {
                    .Client_FirstName   = row(CLIENT_DTO.FIELD_Client_FirstName),
                    .Credit             = row(CLIENT_DTO.FIELD_Credit),
                    .Matricule          = row(CLIENT_DTO.FIELD_Matricule),
                    .Nom                = row(CLIENT_DTO.FIELD_Nom),
                    .ID                 = row(CLIENT_DTO.FIELD_ID)
                }
                records.Add(record)
            Next

            Return records
        Else
            Return New CLIENT_COLLECTION
        End If
    End Function
#End Region

#Region "Get Client by name"
    Public Function getClientByName(ByVal firstname As String, ByVal lastname As String) As CLIENT_COLLECTION
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   * 
                   
                   FROM 
                   " & CLIENT_DTO.TABLE_NAME & " 
                   
                   WHERE 
                   " & CLIENT_DTO.FIELD_Client_FirstName & " LIKE " & PARAM_FIRSTNAME & " 
                   
                   AND 
                   " & CLIENT_DTO.FIELD_Nom & " LIKE " & PARAM_LASTNAME
        }

        Query.Parameters.AddRange({
            New SqlClient.SqlParameter(PARAM_FIRSTNAME, firstname),
            New SqlClient.SqlParameter(PARAM_LASTNAME, lastname)
        })

        Dim Data As DataTable = GetDatatable(Query)
        If Data.Rows.Count > 0 Then
            Dim records As New CLIENT_COLLECTION

            For each row As DataRow In data.Rows
                Dim record As New CLIENT_DTO With {
                    .Client_FirstName   = row(CLIENT_DTO.FIELD_Client_FirstName),
                    .Credit             = row(CLIENT_DTO.FIELD_Credit),
                    .Matricule          = row(CLIENT_DTO.FIELD_Matricule),
                    .Nom                = row(CLIENT_DTO.FIELD_Nom),
                    .ID                 = row(CLIENT_DTO.FIELD_ID)
                }
                records.Add(record)
            Next

            Return records
        Else
            Return New CLIENT_COLLECTION
        End If
    End Function
#End Region

#Region "Adjust Credit after purchase"
    Public Sub AdjustCredit(ByVal credit As Decimal, ByVal matricule As String)
        Dim Query As New SqlQuery_SQL
            
        Query.SQL = "UPDATE 
                    " & CLIENT_DTO.TABLE_NAME & "
                    
                    SET 
                    [" & CLIENT_DTO.FIELD_Credit & "] = [" & CLIENT_DTO.FIELD_Credit & "] + " & credit & "
                    
                    WHERE 
                    [" & CLIENT_DTO.FIELD_Matricule & "] = '" & matricule & "'"

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Pay off Credit after purchase"
    Public Sub PayOffCredit(ByVal credit As Decimal, ByVal matricule As String)
        Dim Query As New SqlQuery_SQL
            
        Query.SQL = "UPDATE 
                    " & CLIENT_DTO.TABLE_NAME & "

                    SET 
                    [" & CLIENT_DTO.FIELD_Credit & "] = [" & CLIENT_DTO.FIELD_Credit & "] - " & credit & "
                    
                    WHERE 
                    [" & CLIENT_DTO.FIELD_Matricule & "] = '" & matricule & "'"

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Insert Client"
    Public Sub InsertClient(record As CLIENT_DTO)
        ExecuteQuery(InsertClientSqlQuery(record))
    End Sub

    Private Function createParameterClient(ByVal record As String, ByVal parameterName As String) As SqlClient.SqlParameter
        Return New SqlClient.SqlParameter With {
            .Direction              = ParameterDirection.Input,
            .DbType                 = DbType.String,
            .ParameterName          = parameterName,
            .Value                  = record
        }
    End Function

    Private Function InsertClientSqlQuery(record As CLIENT_DTO) As SqlQuery_SQL
        Dim parameterFirstName  As SqlClient.SqlParameter = createParameterClient(record.Client_FirstName, CLIENT_DTO.FIELD_Client_FirstName)
        Dim parameterLastName   As SqlClient.SqlParameter = createParameterClient(record.Nom, CLIENT_DTO.FIELD_Nom)
        Dim parameterMatricule  As SqlClient.SqlParameter = createParameterClient(record.Matricule, CLIENT_DTO.FIELD_Matricule)

        Dim Query As New SqlQuery_SQL With {
            .SQL = InsertClientSql(record)
        }

        Query.Parameters.Add(parameterFirstName)
        Query.Parameters.Add(parameterLastName)
        Query.Parameters.Add(parameterMatricule)

        Return Query
    End Function
    
    Private Function InsertClientSql(record As CLIENT_DTO) As String
        Return "INSERT INTO 
               " & CLIENT_DTO.TABLE_NAME & " (" &
               "[" & CLIENT_DTO.FIELD_Client_FirstName & "], " &
               "[" & CLIENT_DTO.FIELD_Nom & "], " &
               "[" & CLIENT_DTO.FIELD_Matricule & "], " &
               "[" & CLIENT_DTO.FIELD_Rank & "], " &
               "[" & CLIENT_DTO.FIELD_Credit & "]" & ") 

               VALUES 
               (" & PARAM_FIRSTNAME & ", " &
               PARAM_LASTNAME & ", 
               " & PARAM_MATRICULE & ",
               '" & record.Rank & "',                       
               " & record.Credit & ")"
    End Function
#End Region

#Region "Update Client"
    Public Sub UpdateClient(record As CLIENT_DTO)
        ExecuteQuery(UpdateClientSqlQuery(record))
    End Sub

    Private Function UpdateClientSqlQuery(record As CLIENT_DTO) As SqlQuery_SQL
        Dim parameterFirstName As New SqlClient.SqlParameter With {
            .Direction              = ParameterDirection.Input,
            .DbType                 = DbType.String,
            .ParameterName          = CLIENT_DTO.FIELD_Client_FirstName,
            .Value                  = record.Client_FirstName
        }

        Dim parameterLastName As New SqlClient.SqlParameter With {
            .Direction              = ParameterDirection.Input,
            .DbType                 = DbType.String,
            .ParameterName          = CLIENT_DTO.FIELD_Nom,
            .Value                  = record.Nom
        }

        Dim parameterMatricule As New SqlClient.SqlParameter With {
            .Direction              = ParameterDirection.Input,
            .DbType                 = DbType.String,
            .ParameterName          = CLIENT_DTO.FIELD_Matricule,
            .Value                  = record.Matricule
        }

        Dim Query As New SqlQuery_SQL With {
            .SQL = UpdateClientSql(record)
        }

        Query.Parameters.Add(parameterFirstName)
        Query.Parameters.Add(parameterLastName)
        Query.Parameters.Add(parameterMatricule)

        Return Query
    End Function
    
    Private Function UpdateClientSql(record As CLIENT_DTO) As String
        Return "UPDATE " & CLIENT_DTO.TABLE_NAME & 
               " SET 
                [" & CLIENT_DTO.FIELD_Client_FirstName & "]        = " & PARAM_FIRSTNAME & ", " &
                "[" & CLIENT_DTO.FIELD_Nom & "]                    = " & PARAM_LASTNAME & ", " &
                " [" & CLIENT_DTO.FIELD_Rank & "]                  = '" & record.Rank &
                "' WHERE 
                [" & CLIENT_DTO.FIELD_Matricule & "] = " & PARAM_MATRICULE
    End Function
#End Region
End Class
