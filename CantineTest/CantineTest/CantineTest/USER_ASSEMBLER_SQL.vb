Public Class USER_ASSEMBLER_SQL
    Inherits DATABASE_SQL

    Private Const PARAM_USERNAME        As String = "@Username"
    Private Const PARAM_ACTIVE          As String = "@Active"
    Private Const PARAM_CASHIER         As String = "@Cashier"
    Private Const PARAM_INVENTORY       As String = "@Inventory"
    Private Const PARAM_STOCKTAKING     As String = "@StockTaking"
    Private Const PARAM_ADMIN           As String = "@Admin"
    Private Const PARAM_Reset           As String = "@ResetPassword"

    Public Sub New()
        MyBase.New()
    End Sub

#Region "Get user by Name"
    Public Function GetUserByName(ByVal username As String) As USER_DTO
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT
                    *

                    FROM 
                    " & USER_DTO.TABLE_NAME & "

                    WHERE 
                    [" & USER_DTO.FIELD_Username & "] = " & PARAM_USERNAME
        }

        Query.Parameters.Add(New SqlClient.SqlParameter("@Username", username))
        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then
            Dim Record As New USER_DTO With {
            .ID                 = Data.Rows(0)(USER_DTO.FIELD_ID),
            .Username           = Data.Rows(0)(USER_DTO.FIELD_Username),
            .Active             = Data.Rows(0)(USER_DTO.FIELD_Active),
            .Salt               = Data.Rows(0)(USER_DTO.FIELD_Salt),
            .Password           = Data.Rows(0)(USER_DTO.FIELD_Password),
            .Cashier            = Data.Rows(0)(USER_DTO.FIELD_Cashier),
            .Inventory          = Data.Rows(0)(USER_DTO.FIELD_Inventory),
            .StockTaking        = Data.Rows(0)(USER_DTO.FIELD_StockTaking),
            .Admin              = Data.Rows(0)(USER_DTO.FIELD_Admin),
            .ResetPassword      = Data.Rows(0)(USER_DTO.FIELD_ResetPassword)
        }

            Return Record
        Else
            Return New USER_DTO
        End If
    End Function
#End Region

#Region "Get all users"
    Public Function GetAllUsers() As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                    " & USER_DTO.FIELD_ID & ", " &
                    USER_DTO.FIELD_Username & ", " &
                    USER_DTO.FIELD_Cashier & ", " &
                    USER_DTO.FIELD_Inventory & ", " &
                    USER_DTO.FIELD_StockTaking & ", " &
                    USER_DTO.FIELD_Admin & ", " &
                    USER_DTO.FIELD_Active & "
                            
                    FROM " &
                    USER_DTO.TABLE_NAME & "
                            
                    ORDER BY 
                    " & USER_DTO.FIELD_Username
        }
        Return GetDatatable(Query)
    End Function
#End Region

#Region "Insert User"
    Public Sub InsertUser(record As USER_DTO)
        ExecuteQuery(InsertUserSqlQuery(record))
    End Sub

    Private Function InsertUserSqlQuery(record As USER_DTO) As SqlQuery_SQL
        Dim parameterUsername As New SqlClient.SqlParameter With {
            .Direction              = ParameterDirection.Input,
            .DbType                 = DbType.String,
            .ParameterName          = USER_DTO.FIELD_Username,
            .Value                  = record.Username
        }

        Dim parameterCashier        = CreateParam(USER_DTO.FIELD_Cashier, record.Cashier)
        Dim parameterStockTaking    = CreateParam(USER_DTO.FIELD_StockTaking, record.StockTaking)
        Dim parameterActive         = CreateParam(USER_DTO.FIELD_Active, record.Active)
        Dim parameterInventory      = CreateParam(USER_DTO.FIELD_Inventory, record.Inventory)
        Dim parameterAdmin          = CreateParam(USER_DTO.FIELD_Admin, record.Admin)

        Dim Query As New SqlQuery_SQL With {
            .SQL = InsertUserSql(record)
        }

        Query.Parameters.Add(parameterCashier)
        Query.Parameters.Add(parameterStockTaking)
        Query.Parameters.Add(parameterActive)
        Query.Parameters.Add(parameterInventory)
        Query.Parameters.Add(parameterAdmin)
        Query.Parameters.Add(parameterUsername)
     
        Return Query
    End Function
    
    Private Function CreateParam(parametername As String, value As Boolean)
        Return New SqlClient.SqlParameter With {
            .Direction      = ParameterDirection.Input,
            .DbType         = DbType.Byte,
            .ParameterName  = parametername,
            .Value          = value 
        }
    End Function

    Private Function InsertUserSql(record As USER_DTO) As String
        Return "INSERT INTO 
                        " & USER_DTO.TABLE_NAME & " (" &
                      "[" & USER_DTO.FIELD_Username & "], " &
                      "[" & USER_DTO.FIELD_Password & "], " &
                      "[" & USER_DTO.FIELD_Salt & "], " &
                      "[" & USER_DTO.FIELD_Active & "], " &
                      "[" & USER_DTO.FIELD_Cashier & "], " &
                      "[" & USER_DTO.FIELD_Inventory & "], " &
                      "[" & USER_DTO.FIELD_Admin & "], " &
                      "[" & USER_DTO.FIELD_StockTaking & "]" & ") 

                   VALUES (
                        " & PARAM_USERNAME & ", '" &
                            record.Password & "', 
                       '" & record.Salt & "', 
                        " & PARAM_ACTIVE & ", 
                        " & PARAM_CASHIER & ", 
                        " & PARAM_INVENTORY & ", 
                        " & PARAM_ADMIN & ",                        
                        " & PARAM_STOCKTAKING & ")"
    End Function
#End Region

#Region "Update user"
    Public Sub UpdateUser(record As USER_DTO)
        ExecuteQuery(UpdateUserSqlQuery(record))
    End Sub

    Private Function UpdateUserSqlQuery(record As USER_DTO) As SqlQuery_SQL
        Dim parameterUsername As New SqlClient.SqlParameter With {
            .Direction              = ParameterDirection.Input,
            .DbType                 = DbType.String,
            .ParameterName          = USER_DTO.FIELD_Username,
            .Value                  = record.Username
        }

        Dim parameterCashier        = CreateParam(USER_DTO.FIELD_Cashier, record.Cashier)
        Dim parameterStockTaking    = CreateParam(USER_DTO.FIELD_StockTaking, record.StockTaking)
        Dim parameterActive         = CreateParam(USER_DTO.FIELD_Active, record.Active)
        Dim parameterInventory      = CreateParam(USER_DTO.FIELD_Inventory, record.Inventory)
        Dim parameterAdmin          = CreateParam(USER_DTO.FIELD_Admin, record.Admin)

        Dim Query As New SqlQuery_SQL With {
            .SQL = UpdateUserSql(record)
        }

        Query.Parameters.Add(parameterUsername)
        Query.Parameters.Add(parameterCashier)
        Query.Parameters.Add(parameterStockTaking)
        Query.Parameters.Add(parameterActive)
        Query.Parameters.Add(parameterInventory)
        Query.Parameters.Add(parameterAdmin)

        Return Query
    End Function

    Private Function UpdateUserSql(record As USER_DTO) As String
        Return "UPDATE 
                " & USER_DTO.TABLE_NAME & " 

                SET 
                [" & USER_DTO.FIELD_Active & "]             = " & PARAM_ACTIVE & ", " &
                "[" & USER_DTO.FIELD_Cashier & "]           = " & PARAM_CASHIER & ", " &
                "[" & USER_DTO.FIELD_Inventory & "]         = " & PARAM_INVENTORY & ", " &
                "[" & USER_DTO.FIELD_StockTaking & "]       = " & PARAM_STOCKTAKING &
                ", [" & USER_DTO.FIELD_Admin & "]           = " & PARAM_ADMIN & " 
                
                WHERE 
                [" & USER_DTO.FIELD_Username & "] = " & PARAM_USERNAME
    End Function
#End Region

#Region "Reset user password"
    Public Sub ResetUserPassword(record As USER_DTO, isreset As Boolean)
        ExecuteQuery(ResetUserPasswordSqlQuery(record, isreset))
    End Sub

    Private Function ResetUserPasswordSqlQuery(record As USER_DTO, isreset As Boolean) As SqlQuery_SQL
        Dim parameterUsername As New SqlClient.SqlParameter With {
            .Direction      = ParameterDirection.Input,
            .DbType         = DbType.String,
            .ParameterName  = USER_DTO.FIELD_Username,
            .Value          = record.Username
         }

        Dim parameterIsReset As New SqlClient.SqlParameter With {
            .Direction      = ParameterDirection.Input,
            .DbType         = DbType.Byte,
            .ParameterName  = USER_DTO.FIELD_ResetPassword,
            .Value          = isreset
         }
        Dim Query As New SqlQuery_SQL With {
            .SQL = ResetUserPasswordSql(record, isreset)
        }

        Query.Parameters.Add(parameterUsername)
        Query.Parameters.Add(parameterIsReset)

        Return Query
    End Function

    Private Function ResetUserPasswordSql(record As USER_DTO, isreset As Boolean) As String
        Return "UPDATE 
                " & USER_DTO.TABLE_NAME & "

                SET 
                [" & USER_DTO.FIELD_Password & "]            = '" & record.Password &
                "', [" & USER_DTO.FIELD_ResetPassword & "]   = " & PARAM_Reset & "
                
                WHERE 
                [" & USER_DTO.FIELD_Username & "] = " & PARAM_USERNAME
    End Function
#End Region

#Region "Get user role by Name"
    Public Function GetUserRoleByName(ByVal username As String, ByVal Role As String) As String
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & Role & "
                   
                   FROM 
                   " & USER_DTO.TABLE_NAME & "
                   
                   WHERE 
                   [" & USER_DTO.FIELD_Username & "] = '" & username & "'"
        }

        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then
            Dim userRole As String = Data.Rows(0)(Role)
            Return userRole
        Else
            Return False
        End If
    End Function
#End Region
End Class
