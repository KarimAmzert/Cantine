Public Class INVENTAIRE_ASSEMBLER_SQL
    Inherits DATABASE_SQL

    Private Const PARAM_NOM             As String = "@Nom"
    Private Const PARAM_UPC             As String = "@UPC"
    Private Const PARAM_PRIX_VENTE      As String = "@Prixvente"
    Private Const PARAM_Active          As String = "@Actif"
    Private Const ACTIVE_PRODUCTS       As Integer = 1
    Public Sub New()
        MyBase.New()
    End Sub

#Region "Get active inventory"
    Public Function GetActiveInventory() As StockTakingReportCollection
        Dim Results As New StockTakingReportCollection

        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & INVENTORY_DTO.FIELD_NOM & ", 
                   " & INVENTORY_DTO.FIELD_UPC & ", 
                   " & INVENTORY_DTO.FIELD_Quantite & "

                   FROM 
                   " & INVENTORY_DTO.TABLE_NAME & "

                   WHERE
                   " & INVENTORY_DTO.FIELD_Actif & " = " & ACTIVE_PRODUCTS & "

                   ORDER BY 
                   " & INVENTORY_DTO.FIELD_NOM
        }

        Dim Data As DataTable = GetDatatable(Query)

        For each row In Data.Rows
            Results.Add(New StockTakingReportDTO(row))
        Next

        Return Results
    End Function
#End Region

#Region "Get Inventory"
    Public Function GetInventory() As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT * FROM " & INVENTORY_DTO.TABLE_NAME & " ORDER BY " & INVENTORY_DTO.FIELD_NOM
        }
        Return GetDatatable(Query)
    End Function
#End Region

#Region "InsertInventory"
    Public Sub InsertInventory(record As INVENTORY_DTO)
        ExecuteQuery(InsertInventorySqlQuery(record))
    End Sub

    Private Function InsertInventorySqlQuery(record As INVENTORY_DTO) As SqlQuery_SQL
        Dim parameterPrice As New SqlClient.SqlParameter With {
               .Direction       = ParameterDirection.Input,
               .DbType          = DbType.Currency,
               .ParameterName   = INVENTORY_DTO.FIELD_Prixvente,
               .Value           = record.Prixvente
        }

        Dim parameterActif As New SqlClient.SqlParameter With {
               .Direction       = ParameterDirection.Input,
               .DbType          = DbType.Byte,
               .ParameterName   = INVENTORY_DTO.FIELD_Actif,
               .Value           = record.Actif
        }

        Dim parameterNom As New SqlClient.SqlParameter With {
               .Direction       = ParameterDirection.Input,
               .DbType          = DbType.String,
               .ParameterName   = INVENTORY_DTO.FIELD_NOM,
               .Value           = record.NOM
        }

        Dim Query As New SqlQuery_SQL With {
            .SQL = InsertInventorySql(record)
        }

        Query.Parameters.Add(parameterNom)
        Query.Parameters.Add(parameterPrice)
        Query.Parameters.Add(parameterActif)

        Return Query
    End Function

    Private Function InsertInventorySql(record As INVENTORY_DTO) As String
      return  "INSERT INTO " & INVENTORY_DTO.TABLE_NAME & " (" &
                      "[" & INVENTORY_DTO.FIELD_NOM & "], " &
                      "[" & INVENTORY_DTO.FIELD_Prixvente & "], " &
                      "[" & INVENTORY_DTO.FIELD_Quantite & "], " &
                      "[" & INVENTORY_DTO.FIELD_UPC & "], " &
                      "[" & INVENTORY_DTO.FIELD_UOI & "], " &
                      "[" & INVENTORY_DTO.FIELD_Minimum & "], " &
                      "[" & INVENTORY_DTO.FIELD_Maximum & "], " &
                      "[" & INVENTORY_DTO.FIELD_Actif & "], " &
                      "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "]" & ") 
                   VALUES (
                        " & PARAM_NOM & ", " &
                            PARAM_PRIX_VENTE & ", 
                        " & record.Quantité & ", 
                       '" & record.UPC & "', 
                       '" & record.UOI & "', 
                        " & record.Minimum & ", 
                        " & record.Maximum & ",  
                        " & PARAM_Active & ", 
                       '" & record.LastModifiedBy & "')"
    End Function
#End Region
    
#Region "Adjust Quantity"
    Public Sub AdjustQTY(record As HISTORY_DTO)
        Dim QueryAdjust         As New SqlQuery_SQL 
        Dim QueryHistory        As New SqlQuery_SQL
        Dim Queries             As New List(Of SqlQuery_SQL)

        Dim parameterUPC As New SqlClient.SqlParameter With {
            .Direction       = ParameterDirection.Input,
            .DbType          = DbType.String,
            .ParameterName   = INVENTORY_DTO.FIELD_UPC,
            .Value           = record.UPC
        }

        QueryHistory.SQL        = "INSERT INTO 
                                  " & HISTORY_DTO.TABLE_NAME & " (" &
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

        QueryAdjust.SQL         = "UPDATE 
                                  " & INVENTORY_DTO.TABLE_NAME & "

                                  SET 
                                  [" & INVENTORY_DTO.FIELD_Quantite & "] = " & record.AfterValue & ", " &
                                  "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.User & "'

                                  WHERE 
                                  [" & INVENTORY_DTO.FIELD_UPC & "] = " & PARAM_UPC

        QueryAdjust.Parameters.Add(parameterUPC)
        ExecuteQueries({QueryHistory, QueryAdjust}.ToList())
    End Sub
#End Region

#Region "Sell Stock"
    Public Sub SellStock(qty As Integer, upc As String)
        Dim Query As New SqlQuery_SQL 
            
        Query.SQL = "UPDATE 
                    " & INVENTORY_DTO.TABLE_NAME & " 

                    SET 
                    [" & INVENTORY_DTO.FIELD_Quantite & "] = [" & INVENTORY_DTO.FIELD_Quantite & "] - " & qty & ", " &
                    " [" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & My.User.Name & "'

                    WHERE 
                    [" & INVENTORY_DTO.FIELD_UPC & "] = '" & upc & "'"

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Update Inventory"
    Public Sub UpdateInventory(record As INVENTORY_DTO)
        Dim Query As New SqlQuery_SQL
        Dim QueryHistory As New SqlQuery_SQL

        Dim parameterPrice As New SqlClient.SqlParameter With {
            .Direction      = ParameterDirection.Input,
            .DbType         = DbType.Currency,
            .ParameterName  = INVENTORY_DTO.FIELD_Prixvente,
            .Value          = record.Prixvente
        }

        Dim parameterUPC As New SqlClient.SqlParameter With {
            .Direction      = ParameterDirection.Input,
            .DbType         = DbType.String,
            .ParameterName  = INVENTORY_DTO.FIELD_UPC,
            .Value          = record.UPC
        }

        Dim actifParameter As New SqlClient.SqlParameter With{
            .Direction      = ParameterDirection.Input,
            .DbType         = DbType.Byte,
            .ParameterName  = INVENTORY_DTO.FIELD_Actif,
            .Value          = record.actif            
        }

        Query.SQL = "UPDATE [" & INVENTORY_DTO.TABLE_NAME & "] SET 
                        [" & INVENTORY_DTO.FIELD_Minimum & "] = 
                            CASE WHEN [" & INVENTORY_DTO.FIELD_Minimum & "] <> " & record.Minimum & " THEN " & record.Minimum & " ELSE [" & INVENTORY_DTO.FIELD_Minimum & "] END,

                        [" & INVENTORY_DTO.FIELD_Maximum & "] = 
                            CASE WHEN [" & INVENTORY_DTO.FIELD_Maximum & "] <> " & record.Maximum & " THEN " & record.Maximum & " ELSE [" & INVENTORY_DTO.FIELD_Maximum & "] END,

                        [" & INVENTORY_DTO.FIELD_Prixvente & "] = 
                            CASE WHEN [" & INVENTORY_DTO.FIELD_Prixvente & "] <> " & PARAM_PRIX_VENTE & " THEN " & PARAM_PRIX_VENTE & " ELSE [" & INVENTORY_DTO.FIELD_Prixvente & "] END,

                        [" & INVENTORY_DTO.FIELD_Actif & "] = 
                            CASE WHEN [" & INVENTORY_DTO.FIELD_Actif & "] <> " & PARAM_Active & " THEN " & PARAM_Active & " ELSE [" & INVENTORY_DTO.FIELD_Actif & "] END,

                        [" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.LastModifiedBy & "'                                  
                    WHERE 
                        [" & INVENTORY_DTO.FIELD_UPC & "] = " & PARAM_UPC

        Query.Parameters.Add(parameterUPC)
        Query.Parameters.Add(parameterPrice)
        Query.Parameters.Add(actifParameter)

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Add Stock"
    Public Sub AddStock(ByVal qty As Integer, ByVal record As HISTORY_DTO)
        Dim Query               As New SqlQuery_SQL
        Dim QueryAddHistory     As New SqlQuery_SQL
        Dim Queries             As New List(Of SqlQuery_SQL)

        Query.SQL               = "UPDATE 
                                   " & INVENTORY_DTO.TABLE_NAME & "
                                   
                                   SET 
                                   [" & INVENTORY_DTO.FIELD_Quantite & "] = [" & INVENTORY_DTO.FIELD_Quantite & "] + " & qty & ", " &
                                   "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.User & "'
                                   
                                   WHERE
                                   [" & INVENTORY_DTO.FIELD_UPC & "] = '" & record.UPC & "'"
        
        QueryAddHistory.SQL     = "INSERT INTO 
                                   " & HISTORY_DTO.TABLE_NAME & " (" &
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
        Queries.Add(Query)
        Queries.Add(QueryAddHistory)
        ExecuteQueries(Queries)
    End Sub
#End Region

#Region "Get product by UPC"
    Public Function GetProductByUPC(ByVal upc As String) As INVENTORY_DTO
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
                    " & INVENTORY_DTO.TABLE_NAME & "

                    WHERE 
                    [" & INVENTORY_DTO.FIELD_UPC & "] = " & PARAM_UPC
        }

        Query.Parameters.Add(parameterUPC)
        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then
            Dim Record As New INVENTORY_DTO With {
                .NOM                = Data.Rows(0)(INVENTORY_DTO.FIELD_NOM),
                .Prixvente          = Data.Rows(0)(INVENTORY_DTO.FIELD_Prixvente),
                .Quantité           = Data.Rows(0)(INVENTORY_DTO.FIELD_Quantite),
                .UOI                = Data.Rows(0)(INVENTORY_DTO.FIELD_UOI),
                .UPC                = Data.Rows(0)(INVENTORY_DTO.FIELD_UPC),
                .Minimum            = Data.Rows(0)(INVENTORY_DTO.FIELD_Minimum),
                .Maximum            = Data.Rows(0)(INVENTORY_DTO.FIELD_Maximum),
                .Actif              = Data.Rows(0)(INVENTORY_DTO.FIELD_Actif),
                .LastModifiedBy     = Data.Rows(0)(INVENTORY_DTO.FIELD_LastModifiedBy)
            }

            Return Record
        Else
            Return New INVENTORY_DTO
        End If
    End Function
#End Region

#Region "Add stock poutine pizza"
    Public Sub AdjustPizza(record As HISTORY_DTO)
        Dim QueryAdjust         As New SqlQuery_SQL 
        Dim QueryHistory        As New SqlQuery_SQL
        Dim Queries             As New List(Of SqlQuery_SQL)

        Dim parameterUPC As New SqlClient.SqlParameter With {
            .Direction       = ParameterDirection.Input,
            .DbType          = DbType.String,
            .ParameterName   = INVENTORY_DTO.FIELD_UPC,
            .Value           = record.UPC
        }

        QueryHistory.SQL        = "INSERT INTO 
                                  " & HISTORY_DTO.TABLE_NAME & " (" &
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

        QueryAdjust.SQL         = "UPDATE 
                                  " & INVENTORY_DTO.TABLE_NAME & " 

                                  SET 
                                  [" & INVENTORY_DTO.FIELD_Quantite & "] = " & record.AfterValue & ", " &
                                  "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.User & "'

                                  WHERE
                                  [" & INVENTORY_DTO.FIELD_UPC & "] = " & PARAM_UPC

        QueryAdjust.Parameters.Add(parameterUPC)
        ExecuteQueries({QueryHistory, QueryAdjust}.ToList())
    End Sub
#End Region
End Class
