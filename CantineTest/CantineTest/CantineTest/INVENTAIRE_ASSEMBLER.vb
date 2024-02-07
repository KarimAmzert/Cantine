Public Class INVENTAIRE_ASSEMBLER
    Inherits DATABASE_ACCESS

    Private Const PARAM_PRIX_VENTE As String = "@Prixvente"

    Public Sub New()
        MyBase.New("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_LOCATION)
    End Sub

#Region "Get active inventory"
    Public Function GetActiveInventory() As StockTakingReportCollection
        Dim Results As New StockTakingReportCollection
        Dim Data As DataTable = GetDatatable("SELECT " & INVENTORY_DTO.FIELD_NOM & ", " & INVENTORY_DTO.FIELD_UPC & ", " & INVENTORY_DTO.FIELD_Quantite & " FROM " & INVENTORY_DTO.TABLE_NAME &
                                             " WHERE " & INVENTORY_DTO.FIELD_Actif & " = -1  ORDER BY " & INVENTORY_DTO.FIELD_NOM)

        For each row In Data.Rows
            Results.Add(New StockTakingReportDTO(row))
        Next

        Return Results
    End Function
#End Region

#Region "Get Inventory"
    Public Function GetInventory() As DataTable
        Return GetDatatable("SELECT * FROM " & INVENTORY_DTO.TABLE_NAME & " ORDER BY " & INVENTORY_DTO.FIELD_NOM)
    End Function
#End Region

#Region "InsertInventory"
    Public Sub InsertInventory(record As INVENTORY_DTO)
        ExecuteQuery(InsertInventorySqlQuery(record))
    End Sub
    Private Function InsertInventorySqlQuery(record As INVENTORY_DTO) As SqlQuery
        Dim parameterPrice As New OleDb.OleDbParameter With {
               .Direction       = ParameterDirection.Input,
               .DbType          = DbType.Currency,
               .ParameterName   = INVENTORY_DTO.FIELD_Prixvente,
               .Value           = record.Prixvente
         }
        Dim Query As New SqlQuery With {
            .SQL         = InsertInventorySql(record)
        }

        Query.Parameters.Add(parameterPrice)

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
                       '" & record.NOM & "', " &
                            PARAM_PRIX_VENTE & ", 
                        " & record.Quantité & ", 
                       '" & record.UPC & "', 
                       '" & record.UOI & "', 
                        " & record.Minimum & ", 
                        " & record.Maximum & ",  
                        " & record.Actif & ", 
                       '" & record.LastModifiedBy & "')"
    End Function
#End Region
    
#Region "Adjust Quantity"
    Public Sub AdjustQTY(record As HISTORY_DTO)
        Dim QueryAdjust         As New SqlQuery 
        Dim QueryHistory        As New SqlQuery
        Dim Queries             As New List(Of SqlQuery)

        QueryHistory.SQL        = "INSERT INTO " & HISTORY_DTO.TABLE_NAME & " (" &
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

        QueryAdjust.SQL         = "UPDATE " & INVENTORY_DTO.TABLE_NAME & " SET 
                                  [" & INVENTORY_DTO.FIELD_Quantite & "] = " & record.AfterValue & ", " &
                                  "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.User &
                                  "' WHERE [" & INVENTORY_DTO.FIELD_UPC & "] = '" & record.UPC & "'"
        Queries.Add(QueryHistory)
        Queries.Add(QueryAdjust)
        ExecuteQueries(Queries)
    End Sub
#End Region

#Region "Sell Stock"
    Public Sub SellStock(qty As Integer, upc As String)
        Dim Query As New SqlQuery 
            
        Query.SQL = "UPDATE " & INVENTORY_DTO.TABLE_NAME & " SET 
                    [" & INVENTORY_DTO.FIELD_Quantite & "] = [" & INVENTORY_DTO.FIELD_Quantite & "] - " & qty & ", " &
                    " [" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & My.User.Name &
                    "' WHERE [" & INVENTORY_DTO.FIELD_UPC & "] = '" & upc & "'"

        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Update Inventory"
    Public Sub UpdateInventory(record As INVENTORY_DTO)
        Dim Query As New SqlQuery
        Dim QueryHistory As New SqlQuery

        Dim parameterPrice As New OleDb.OleDbParameter With {
               .Direction       = ParameterDirection.Input,
               .DbType          = DbType.Currency,
               .ParameterName   = INVENTORY_DTO.FIELD_Prixvente,
               .Value           = record.Prixvente
        }

        Query.SQL               = "UPDATE [" & INVENTORY_DTO.TABLE_NAME &
                                "] SET 
                                [" & INVENTORY_DTO.FIELD_Minimum & "] = 
                                IIF([" & INVENTORY_DTO.FIELD_Minimum & "] <> " & record.Minimum & ", " & record.Minimum & ", [" & INVENTORY_DTO.FIELD_Minimum & "]),

                                [" & INVENTORY_DTO.FIELD_Maximum & "] = 
                                IIF([" & INVENTORY_DTO.FIELD_Maximum & "] <> " & record.Maximum & ", " & record.Maximum & ", [" & INVENTORY_DTO.FIELD_Maximum & "]),

                                [" & INVENTORY_DTO.FIELD_Prixvente & "] = 
                                IIF([" & INVENTORY_DTO.FIELD_Prixvente & "] <> " & record.Prixvente & ", " & record.Prixvente & ", [" & INVENTORY_DTO.FIELD_Prixvente & "]),

                                [" & INVENTORY_DTO.FIELD_Actif & "] = 
                                IIF([" & INVENTORY_DTO.FIELD_Actif & "] <> " & record.Actif & ", " & record.Actif & ", [" & INVENTORY_DTO.FIELD_Actif & "]),

                                [" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.LastModifiedBy & "'                                  
                            WHERE 
                                [" & INVENTORY_DTO.FIELD_UPC & "] = '" & record.UPC & "'"

        Query.Parameters.Add(parameterPrice)
        ExecuteQuery(Query)
    End Sub
#End Region

#Region "Add Stock"
    Public Sub AddStock(ByVal qty As Integer, ByVal record As HISTORY_DTO)
        Dim Query               As New SqlQuery
        Dim QueryAddHistory     As New SqlQuery
        Dim Queries             As New List(Of SqlQuery)

        Query.SQL               = "UPDATE " & INVENTORY_DTO.TABLE_NAME & " SET 
                                    [" & INVENTORY_DTO.FIELD_Quantite & "] = [" & INVENTORY_DTO.FIELD_Quantite & "] + " & qty & ", " &
                                    "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.User &
                                    "' WHERE [" & INVENTORY_DTO.FIELD_UPC & "] = '" & record.UPC & "'"
        
        QueryAddHistory.SQL        = "INSERT INTO " & HISTORY_DTO.TABLE_NAME & " (" &
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
        Dim Data As DataTable = GetDatatable("SELECT * FROM " & INVENTORY_DTO.TABLE_NAME & " WHERE [" & INVENTORY_DTO.FIELD_UPC & "] = '" & upc & "'")

        If Data.Rows.Count > 0 Then
            Dim Record As New INVENTORY_DTO With {
                .NOM = Data.Rows(0)(INVENTORY_DTO.FIELD_NOM),
                .Prixvente = Data.Rows(0)(INVENTORY_DTO.FIELD_Prixvente),
                .Quantité = Data.Rows(0)(INVENTORY_DTO.FIELD_Quantite),
                .UOI = Data.Rows(0)(INVENTORY_DTO.FIELD_UOI),
                .UPC = Data.Rows(0)(INVENTORY_DTO.FIELD_UPC),
                .Minimum = Data.Rows(0)(INVENTORY_DTO.FIELD_Minimum),
                .Maximum = Data.Rows(0)(INVENTORY_DTO.FIELD_Maximum),
                .Actif = Data.Rows(0)(INVENTORY_DTO.FIELD_Actif),
                .LastModifiedBy = Data.Rows(0)(INVENTORY_DTO.FIELD_LastModifiedBy)
            }

            Return Record
        Else
            Return New INVENTORY_DTO
        End If
    End Function
#End Region

#Region "Add stock poutine pizza"
    Public Sub AdjustPizza(record As HISTORY_DTO)
        Dim QueryAdjust         As New SqlQuery 
        Dim QueryHistory        As New SqlQuery
        Dim Queries             As New List(Of SqlQuery)

        QueryHistory.SQL        = "INSERT INTO " & HISTORY_DTO.TABLE_NAME & " (" &
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

        QueryAdjust.SQL         = "UPDATE " & INVENTORY_DTO.TABLE_NAME & " SET 
                                  [" & INVENTORY_DTO.FIELD_Quantite & "] = " & record.AfterValue & ", " &
                                  "[" & INVENTORY_DTO.FIELD_LastModifiedBy & "] = '" & record.User &
                                  "' WHERE [" & INVENTORY_DTO.FIELD_UPC & "] = '" & record.UPC & "'"
        Queries.Add(QueryHistory)
        Queries.Add(QueryAdjust)
        ExecuteQueries(Queries)
    End Sub
#End Region
End Class
