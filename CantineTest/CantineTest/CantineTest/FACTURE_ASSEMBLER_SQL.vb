Public Class FACTURE_ASSEMBLER_SQL
    Inherits DATABASE_SQL

    Public Sub New()
        MyBase.New()
    End Sub

#Region "Get Factures"
    Public Function GetFactures() As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL =          "SELECT 
                            " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate, 
                            " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & ", 
                            " & USER_DTO.TABLE_NAME & "." & USER_DTO.FIELD_Username & " AS Cashier, 
                            " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Nom & ", 
                            " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Client_FirstName & ",
                            Payment_Type.Payment_Type, 
                            SUM(" & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Unit_Price & " * " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Qty & ") AS Total
                            
                            FROM 
                            " & FACTURE_DTO.TABLE_NAME & "
                            
                            INNER JOIN " & CLIENT_DTO.TABLE_NAME & " ON " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_Client_ID & " 
                            INNER JOIN Payment_Type ON Payment_Type.ID = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_Payment_Type_ID & " 
                            INNER JOIN " & USER_DTO.TABLE_NAME & " ON " & USER_DTO.TABLE_NAME & "." & USER_DTO.FIELD_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_Cashier_ID & " 
                            INNER JOIN " & FACTUREDETAIL_DTO.TABLE_NAME & " ON " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Facture_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & " 
                            
                            GROUP BY 
                            " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & ", 
                            " & USER_DTO.TABLE_NAME & "." & USER_DTO.FIELD_Username & ", 
                            " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Nom & ", 
                            " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Client_FirstName & ", 
                            " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_Cashier_ID & ", 
                            Payment_Type.Payment_Type, 
                            " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate
                            
                            ORDER BY 
                            " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate DESC"
        }
        Return GetDatatable(Query)
    End Function
#End Region

#Region "Get Factures by name"
    Public Function GetFacturesByID(ByVal ID As Integer) As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                    " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate, 
                    " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & ", 
                    " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Nom & ", 
                    " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Client_FirstName & ", 
                    Payment_Type.Payment_Type, 
                    SUM([" & FACTUREDETAIL_DTO.TABLE_NAME & "].[" & FACTUREDETAIL_DTO.FIELD_Unit_Price & "] * [" & FACTUREDETAIL_DTO.TABLE_NAME & "].[" & FACTUREDETAIL_DTO.FIELD_Qty & "]) AS TOTAL
                    
                    FROM 
                    " & FACTURE_DTO.TABLE_NAME & " 
                            
                    INNER JOIN " & CLIENT_DTO.TABLE_NAME & " ON " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_Client_ID & " = " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_ID & "          
                    INNER JOIN Payment_Type ON " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_Payment_Type_ID & " = Payment_Type.ID 
                    INNER JOIN " & FACTUREDETAIL_DTO.TABLE_NAME & " ON " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & " = " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Facture_ID & "  
                    
                    WHERE 
                    " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_ID & " = " & ID & " 
                    
                    GROUP BY 
                    " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate, " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & ", " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Nom & ", " & CLIENT_DTO.TABLE_NAME & "." & CLIENT_DTO.FIELD_Client_FirstName & ", Payment_Type.Payment_Type ORDER BY " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate DESC"
        }
        Return GetDatatable(Query)
    End Function
#End Region

#Region "Insert Facture"
    Public Sub InsertFacture(facture As FACTURE_DTO)
        Dim FactureQuery As New SqlQuery_SQL

        FactureQuery.SQL = "INSERT INTO 
                           " & FACTURE_DTO.TABLE_NAME & " (" &
                           "[" & FACTURE_DTO.FIELD_Client_ID & "], " &
                           "[" & FACTURE_DTO.FIELD_Cashier_ID & "], " &
                           "[" & FACTURE_DTO.FIELD_Payment_Type_ID & "]" & ") 

                              VALUES (
                                   " & facture.Client_ID & ",
                                   " & facture.Cashier_ID & ",  
                                   " & facture.Payment_Type_ID & ")"

            
        ExecuteQuery(FactureQuery)
    End Sub
#End Region

#Region "Insert Cash & Credit amount"
    Public Sub InsertCashCredit(ByVal cashCreditInfo As CASHCREDIT_DTO)
        Dim FactureQuery As New SqlQuery_SQL

        FactureQuery.SQL = "INSERT INTO 
                           " & CASHCREDIT_DTO.TABLE_NAME & 
                           " ([" & CASHCREDIT_DTO.FIELD_Facture_ID & "], 
                           [" & CASHCREDIT_DTO.FIELD_Client_ID & "], 
                           [" & CASHCREDIT_DTO.FIELD_CreditPayment & "], 
                           [" & CASHCREDIT_DTO.FIELD_CashPayment & "])
                           
                           VALUES (
                           " & cashCreditInfo.Facture_ID & ",
                           " & cashCreditInfo.Client_ID & ",
                           " & cashCreditInfo.CreditPayment & ", 
                           " & cashCreditInfo.CashPayment & ")"
            
        ExecuteQuery(FactureQuery)
    End Sub
#End Region

#Region "Get cash and credit amount on transaction"
    Public Function GetCashCredit(ByVal facture_ID As Integer) As CASHCREDIT_DTO
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & CASHCREDIT_DTO.FIELD_CashPayment & ", 
                   " & CASHCREDIT_DTO.FIELD_CreditPayment & "

                   FROM 
                   " & CASHCREDIT_DTO.TABLE_NAME & "

                   WHERE 
                   [" & CASHCREDIT_DTO.FIELD_Facture_ID & "] = " & facture_ID
        }

        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then

            Dim Record As New CASHCREDIT_DTO With {
                .CreditPayment  = Data.Rows(0)("CreditPayment"),
                .CashPayment    = Data.Rows(0)("CashPayment")
            }

            Return Record
        Else
            Return New CASHCREDIT_DTO
        End If
    End Function
#End Region

#Region "Get Facture ID"
    Public Function GetNewestID() As FACTURE_DTO
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                    TOP 1 [ID] 

                    FROM 
                    " & FACTURE_DTO.TABLE_NAME & " 

                    ORDER BY 
                    InvoiceDate DESC"
        }
        Dim Data As DataTable = GetDatatable(Query)
        If Data.Rows.Count > 0 Then

            Dim Record As New FACTURE_DTO With {
                .ID =  Data.Rows(0)("ID")
            }

            Return Record
        Else
            Return New FACTURE_DTO
        End If
    End Function
#End Region

#Region "Get Reason ID by name"
    Public Function GetReasonIDByName(ByVal reason As String) As FACTURE_DTO
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                    [ID] 

                    FROM 
                    Reason 

                    WHERE 
                    Reason.Reason = '" & reason & "'"
        }

        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then

            Dim Record As New FACTURE_DTO With {
                .ID =  Data.Rows(0)("ID")
            }

            Return Record
        Else
            Return New FACTURE_DTO
        End If
    End Function
#End Region

#Region "Insert Facture details"
    Public Sub InsertFacture_Detail(facture As FACTUREDETAIL_DTO)
        Dim FactureQuery As New SqlQuery_SQL

        FactureQuery.SQL = "INSERT INTO 
                           " & FACTUREDETAIL_DTO.TABLE_NAME & " (" &
                           "[" & FACTUREDETAIL_DTO.FIELD_Facture_ID & "], " &
                           "[" & FACTUREDETAIL_DTO.FIELD_Product_name & "], " &
                           "[" & FACTUREDETAIL_DTO.FIELD_Qty & "], " &
                           "[" & FACTUREDETAIL_DTO.FIELD_Unit_Price & "], " &
                           "[" & FACTUREDETAIL_DTO.FIELD_Sale & "], " &
                           "[" & FACTUREDETAIL_DTO.FIELD_Reason_ID & "]" & ")
                           
                           VALUES (
                           " & facture.Facture_ID & ",
                           '" & facture.Product_name & "',
                           " & facture.Qty & ",
                           " & facture.Unit_Price & ",
                           " & facture.Sale & ",
                           " & facture.Reason_ID & ")"
   
        ExecuteQuery(FactureQuery)
    End Sub
#End Region

#Region "Get Facture details By ID"
    Public Function GetFactureByID(ByVal ID As Integer) As DataTable
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT 
                   " & FACTUREDETAIL_DTO.FIELD_Product_name & ", 
                   " & FACTUREDETAIL_DTO.FIELD_Qty & ", 
                   " & "("& FACTUREDETAIL_DTO.FIELD_Unit_Price & " + " & FACTUREDETAIL_DTO.FIELD_Sale & ") AS Beforesale, 
                   " & FACTUREDETAIL_DTO.FIELD_Unit_Price & " AS Sale_Price, 
                   " & "Reason.Reason, 
                   (" & FACTUREDETAIL_DTO.FIELD_Unit_Price & " * " & FACTUREDETAIL_DTO.FIELD_Qty & ") AS Sub_total 

                   " & "FROM 
                   " & FACTUREDETAIL_DTO.TABLE_NAME & "

                   INNER JOIN 
                   Reason ON " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Reason_ID & " = Reason.ID 

                   " & "WHERE 
                   [" & FACTUREDETAIL_DTO.FIELD_Facture_ID & "] = " & ID
        }

        Return GetDatatable(Query)
    End Function
#End Region

#Region "get top 10 best sellers for a given month And year"
Public Function GetBestSellers(ByVal month As String, ByVal year As String) As DataTable
    Dim Query As New SqlQuery_SQL With {
        .SQL = "SELECT 
                * 
                FROM (SELECT DENSE_RANK() OVER (ORDER BY COUNT(" & FACTUREDETAIL_DTO.FIELD_Qty & ") DESC) AS Rank, 
                " & FACTUREDETAIL_DTO.FIELD_Product_name & " AS ProductName,
                COUNT(" & FACTUREDETAIL_DTO.FIELD_Qty & ") as Qty_sold 

                FROM " &
                FACTUREDETAIL_DTO.TABLE_NAME & " 

                INNER JOIN 
                " & FACTURE_DTO.TABLE_NAME & " ON " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Facture_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & " 

                WHERE 
                YEAR(InvoiceDate) = '" & year & "' 

                AND 
                MONTH(InvoiceDate) = '" & month & "' 

                GROUP BY " &
                FACTUREDETAIL_DTO.FIELD_Product_name & ") AS RankedProducts 

                WHERE
                Rank <= 10"
    }
    Return GetDatatable(Query)
End Function
#End Region

#Region "Get profit for a given month and year"
    Public Function GetProfitByMonthYear(ByVal month As String, ByVal year As String) As String
        Dim Query As New SqlQuery_SQL With {
            .SQL = "SELECT
                    SUM([" & FACTUREDETAIL_DTO.FIELD_Unit_Price & "] * [" & FACTUREDETAIL_DTO.FIELD_Qty & "]) AS TotalAmount
                    
                    FROM 
                    " & FACTUREDETAIL_DTO.TABLE_NAME &"
                    
                    INNER JOIN " & FACTURE_DTO.TABLE_NAME & " ON " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Facture_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID & "
                    
                    WHERE
                    MONTH(" & FACTURE_DTO.TABLE_NAME & ".InvoiceDate) = " & month & "

                    AND
                    YEAR(" & FACTURE_DTO.TABLE_NAME & ".InvoiceDate) = " & year
        }

        Dim Data As DataTable = GetDatatable(Query)

        If Data.Rows.Count > 0 Then

            Dim Record = Data.Rows(0)("TotalAmount").ToString()

            Return Record
        Else
            Return Nothing
        End If
    End Function
#End Region
End Class
