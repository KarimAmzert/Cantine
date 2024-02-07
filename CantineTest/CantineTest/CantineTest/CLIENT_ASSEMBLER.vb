Public Class CLIENT_ASSEMBLER
Inherits DATABASE_ACCESS

    Public Sub New()
        MyBase.New("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_LOCATION)
    End Sub

#Region "Get Client by matricule"
    Public Function getClientByMatricule(ByVal matricule As String) As CLIENT_COLLECTION
        'injection SQL on matricule
        Dim data As DataTable = GetDatatable("SELECT * FROM " & CLIENT_DTO.TABLE_NAME & " WHERE " & CLIENT_DTO.FIELD_Matricule & " = '" & matricule & "' OR " & CLIENT_DTO.FIELD_Nom & " LIKE '" & matricule & "'" )
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

#Region "Get Client by name"
    Public Function getClientByName(ByVal firstname As String, ByVal lastname As String) As CLIENT_COLLECTION
        Dim data As DataTable = GetDatatable("SELECT * FROM " & CLIENT_DTO.TABLE_NAME & " WHERE " & CLIENT_DTO.FIELD_Client_FirstName & " LIKE '" & firstname & "' AND " & CLIENT_DTO.FIELD_Nom & " LIKE '" & lastname & "'" )
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
        Dim Query As New SqlQuery 
            
        Query.SQL = "UPDATE " & CLIENT_DTO.TABLE_NAME & " SET 
                    [" & CLIENT_DTO.FIELD_Credit & "] = [" & CLIENT_DTO.FIELD_Credit & "] + " & credit &
                    " WHERE [" & CLIENT_DTO.FIELD_Matricule & "] = '" & matricule & "'"

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Pay off Credit after purchase"
    Public Sub PayOffCredit(ByVal credit As Decimal, ByVal matricule As String)
        Dim Query As New SqlQuery 
            
        Query.SQL = "UPDATE " & CLIENT_DTO.TABLE_NAME & " SET 
                    [" & CLIENT_DTO.FIELD_Credit & "] = [" & CLIENT_DTO.FIELD_Credit & "] - " & credit &
                    " WHERE [" & CLIENT_DTO.FIELD_Matricule & "] = '" & matricule & "'"

        ExecuteQuery(Query)
    End Sub
#End Region
End Class
