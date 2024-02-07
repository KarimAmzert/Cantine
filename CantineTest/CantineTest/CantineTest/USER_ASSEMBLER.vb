Public Class USER_ASSEMBLER
    Inherits DATABASE_ACCESS

    Public Sub New()
        MyBase.New("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_LOCATION)
    End Sub

#Region "Get user by Name"
    Public Function GetUserByName(ByVal username As String) As USER_DTO
        Dim Data As DataTable = GetDatatable("SELECT * FROM " & USER_DTO.TABLE_NAME & " WHERE [" & USER_DTO.FIELD_Username & "] = '" & username & "'")

        If Data.Rows.Count > 0 Then
            Dim Record As New USER_DTO With {
                .ID             = Data.Rows(0)(USER_DTO.FIELD_ID),
                .Username       = Data.Rows(0)(USER_DTO.FIELD_Username),
                .Active         = Data.Rows(0)(USER_DTO.FIELD_Active),
                .Salt           = Data.Rows(0)(USER_DTO.FIELD_Salt),
                .Password       = Data.Rows(0)(USER_DTO.FIELD_Password),
                .Cashier        = Data.Rows(0)(USER_DTO.FIELD_Cashier),
                .Inventory      = Data.Rows(0)(USER_DTO.FIELD_Inventory),
                .StockTaking    = Data.Rows(0)(USER_DTO.FIELD_StockTaking),
                .Admin          = Data.Rows(0)(USER_DTO.FIELD_Admin),
                .ResetPassword  = Data.Rows(0)(USER_DTO.FIELD_ResetPassword)
            }

            Return Record
        Else
            Return New USER_DTO
        End If
    End Function
#End Region

#Region "Get all users"
    Public Function GetAllUsers() As DataTable
        Return GetDatatable("SELECT " & USER_DTO.FIELD_ID & ", " &
                            USER_DTO.FIELD_Username & ", " &
                            USER_DTO.FIELD_Cashier & ", " &
                            USER_DTO.FIELD_Inventory & ", " &
                            USER_DTO.FIELD_StockTaking & ", " &
                            USER_DTO.FIELD_Admin & ", " &
                            USER_DTO.FIELD_Active &
                            " FROM " &
                            USER_DTO.TABLE_NAME & 
                            " ORDER BY " & USER_DTO.FIELD_Username)
    End Function
#End Region

#Region "Insert User"
    Public Sub InsertUser(record As USER_DTO)
        ExecuteQuery(InsertUserSqlQuery(record))
    End Sub

    Private Function InsertUserSqlQuery(record As USER_DTO) As SqlQuery
        Dim Query As New SqlQuery With {
            .SQL         = InsertUserSql(record)
        }
        Return Query
    End Function

    Private Function InsertUserSql(record As USER_DTO) As String
      return  "INSERT INTO " & USER_DTO.TABLE_NAME & " (" &
                      "[" & USER_DTO.FIELD_Username & "], " &
                      "[" & USER_DTO.FIELD_Password & "], " &
                      "[" & USER_DTO.FIELD_Salt & "], " &
                      "[" & USER_DTO.FIELD_Active & "], " &
                      "[" & USER_DTO.FIELD_Cashier & "], " &
                      "[" & USER_DTO.FIELD_Inventory & "], " &
                      "[" & USER_DTO.FIELD_Admin & "], " &
                      "[" & USER_DTO.FIELD_StockTaking & "]" & ") 
                   VALUES (
                       '" & record.Username & "', '" &
                            record.Password & "', 
                       '" & record.Salt & "', 
                        " & record.Active & ", 
                        " & record.Cashier & ", 
                        " & record.Inventory & ",
                        " & record.Admin & ",                        
                        " & record.StockTaking & ")"
    End Function
#End Region

#Region "Update user"
    Public Sub UpdateUser(ByVal record As USER_DTO)
        Dim Query               As New SqlQuery

        Query.SQL               = "UPDATE " & USER_DTO.TABLE_NAME & " SET 
                                    [" & USER_DTO.FIELD_Active & "]             = " & record.Active & ", " &
                                    "[" & USER_DTO.FIELD_Cashier & "]           = " & record.Cashier & ", " &
                                    "[" & USER_DTO.FIELD_Inventory & "]         = " & record.Inventory & ", " &
                                    "[" & USER_DTO.FIELD_StockTaking & "]       = " & record.StockTaking &
                                    ", [" & USER_DTO.FIELD_Admin & "]           = " & record.Admin &
                                    " WHERE [" & USER_DTO.FIELD_Username & "]   = '" & record.Username & "'"
        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Reset user password"
    Public Sub ResetUserPassword(ByVal record As USER_DTO, ByVal isreset As Boolean)
        Dim Query As New SqlQuery

        Query.SQL = "UPDATE " & USER_DTO.TABLE_NAME & " SET 
                                    [" & USER_DTO.FIELD_Password & "]            = '" & record.Password &
                                    "', [" & USER_DTO.FIELD_ResetPassword & "]   = " & isreset &
                                    " WHERE 
                                    [" & USER_DTO.FIELD_Username & "]            = '" & record.Username & "'"
        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Get user role by Name"
    Public Function GetUserRoleByName(ByVal username As String, ByVal Role As String) As String
        Dim Data As DataTable = GetDatatable("SELECT " & Role & " FROM " & USER_DTO.TABLE_NAME & " WHERE [" & USER_DTO.FIELD_Username & "] = '" & username & "'")
        
        If Data.Rows.Count > 0 Then
            Dim userRole As String = Data.Rows(0)(Role)
            Return userRole
        Else
            Return False
        End If
    End Function
#End Region
End Class
