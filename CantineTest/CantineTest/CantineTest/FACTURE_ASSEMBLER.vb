Public Class FACTURE_ASSEMBLER
    Inherits DATABASE_ACCESS

    Public Sub New()
        MyBase.New("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_LOCATION)
    End Sub

#Region "Get Factures"
    Public Function GetFactures() As DataTable
        Return GetDatatable("SELECT " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate, " & FACTURE_DTO.TABLE_NAME & ".ID, " & USER_DTO.TABLE_NAME & "." & USER_DTO.FIELD_Username & " AS Cashier, " & CLIENT_DTO.TABLE_NAME & ".Nom, " & CLIENT_DTO.TABLE_NAME & ".Client_FirstName, Payment_Type.Payment_Type, SUM(Factures_Detail.Unit_Price * Factures_Detail.Qty) AS Total FROM ((((" & FACTURE_DTO.TABLE_NAME & " 
                            INNER JOIN Client ON Client.ID = " & FACTURE_DTO.TABLE_NAME & ".Client_ID) 
                            INNER JOIN Payment_Type on Payment_Type.ID = " & FACTURE_DTO.TABLE_NAME & ".Payment_Type_ID) 
                            INNER JOIN Users on Users.ID = " & FACTURE_DTO.TABLE_NAME & ".Cashier_ID) 
                            INNER JOIN Factures_Detail ON Factures_Detail.Facture_ID = " & FACTURE_DTO.TABLE_NAME & ".ID) 
                            GROUP BY " & FACTURE_DTO.TABLE_NAME & ".ID,
                                     " & USER_DTO.TABLE_NAME & ".Username, 
                                     " & CLIENT_DTO.TABLE_NAME & ".Nom,
                                     " & CLIENT_DTO.TABLE_NAME & ".Client_FirstName,
                                     " & FACTURE_DTO.TABLE_NAME & ".Cashier_ID,
                                     Payment_Type.Payment_Type,
                                     " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate
                            ORDER BY " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate DESC")
    End Function
#End Region

#Region "Get Factures by name"
    Public Function GetFacturesByID(ByVal ID As Integer) As DataTable
        Return GetDatatable("SELECT " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate, " & FACTURE_DTO.TABLE_NAME & ".ID, " & CLIENT_DTO.TABLE_NAME & ".Nom, " & CLIENT_DTO.TABLE_NAME & ".Client_FirstName, Payment_Type.Payment_Type, Sum([" & FACTUREDETAIL_DTO.TABLE_NAME & "].[Unit_Price] * [" & FACTUREDETAIL_DTO.TABLE_NAME & "].[Qty]) AS TOTAL
                            FROM ((" & FACTURE_DTO.TABLE_NAME & " 
                            INNER JOIN " & CLIENT_DTO.TABLE_NAME & " ON " & FACTURE_DTO.TABLE_NAME & ".Client_ID = " & CLIENT_DTO.TABLE_NAME & ".ID) 
                            INNER JOIN Payment_Type ON " & FACTURE_DTO.TABLE_NAME & ".Payment_Type_ID = Payment_Type.ID) 
                            INNER JOIN " & FACTUREDETAIL_DTO.TABLE_NAME & " ON " & FACTURE_DTO.TABLE_NAME & ".ID = " & FACTUREDETAIL_DTO.TABLE_NAME & ".Facture_ID 
                            WHERE (((" & CLIENT_DTO.TABLE_NAME & ".ID) = " & ID & ")) 
                            GROUP BY " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate, " & FACTURE_DTO.TABLE_NAME & ".ID, " & CLIENT_DTO.TABLE_NAME & ".Nom, " & CLIENT_DTO.TABLE_NAME & ".Client_FirstName, Payment_Type.Payment_Type ORDER BY " & FACTURE_DTO.TABLE_NAME & ".InvoiceDate DESC
                            ")
    End Function
#End Region

#Region "Insert Facture"
    Public Sub InsertFacture(facture As FACTURE_DTO)
        Dim FactureQuery As New SqlQuery

        FactureQuery.SQL = "INSERT INTO " & FACTURE_DTO.TABLE_NAME & " (" &
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
        Dim FactureQuery As New SqlQuery

        FactureQuery.SQL = "INSERT INTO CashCredit ([" & CASHCREDIT_DTO.FIELD_Facture_ID & "], [" & CASHCREDIT_DTO.FIELD_Client_ID & "], [" & CASHCREDIT_DTO.FIELD_CreditPayment & "], [" & CASHCREDIT_DTO.FIELD_CashPayment & "])  
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
        Dim Data As DataTable = GetDatatable("SELECT " & CASHCREDIT_DTO.FIELD_CashPayment & ", " & CASHCREDIT_DTO.FIELD_CreditPayment & " FROM " & CASHCREDIT_DTO.TABLE_NAME & " 
                                              WHERE 
                                              [" & CASHCREDIT_DTO.FIELD_Facture_ID & "] = " & facture_ID)
        If Data.Rows.Count > 0 Then

            Dim Record As New CASHCREDIT_DTO With {
                .CreditPayment = Data.Rows(0)("CreditPayment"),
                .CashPayment = Data.Rows(0)("CashPayment")
            }

            Return Record
        Else
            Return New CASHCREDIT_DTO
        End If
    End Function
#End Region

#Region "Get Facture ID"
    Public Function GetNewestID() As FACTURE_DTO
        Dim Data As DataTable = GetDatatable("SELECT TOP 1 [ID] FROM " & FACTURE_DTO.TABLE_NAME & " ORDER BY InvoiceDate DESC")
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
        Dim getID As New SqlQuery
        Dim Data As DataTable = GetDatatable("SELECT [ID] FROM Reason WHERE Reason.Reason = '" & reason & "'")
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
        Dim FactureQuery As New SqlQuery

        FactureQuery.SQL = "INSERT INTO " & FACTUREDETAIL_DTO.TABLE_NAME & " (" &
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
        Return GetDatatable("SELECT " & 
                            FACTUREDETAIL_DTO.FIELD_Product_name & ", " &
                            FACTUREDETAIL_DTO.FIELD_Qty & ", " &
                            "(Unit_Price + Sale) AS Beforesale, " &
                            FACTUREDETAIL_DTO.FIELD_Unit_Price & " AS Sale_Price, " &
                            "Reason.Reason, 
                            (Unit_Price * Qty) AS Sub_total " &
                            "FROM " & FACTUREDETAIL_DTO.TABLE_NAME & 
                            " INNER JOIN Reason ON " &
                            FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Reason_ID & " = Reason.ID " &
                            "WHERE [" & FACTUREDETAIL_DTO.FIELD_Facture_ID & "] = " & ID)
    End Function
#End Region

#Region "get top 10 best sellers for a given month And year"
    Public Function GetBestSellers(ByVal month As String, ByVal year As String) As DataTable
        Return GetDatatable("SELECT TOP 10 " & FACTUREDETAIL_DTO.FIELD_Product_name & ", COUNT(Qty) as Qty_sold FROM " & FACTUREDETAIL_DTO.TABLE_NAME & 
                            " INNER JOIN " & FACTURE_DTO.TABLE_NAME & " ON " & FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Facture_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID &
                            " WHERE YEAR(InvoiceDate) = '" & year & "' AND MONTH(InvoiceDate) = '" & month &
                            "' GROUP BY " & FACTUREDETAIL_DTO.FIELD_Product_name & "
                             ORDER BY COUNT(QTY) DESC")
    End Function
#End Region

#Region "Get profit for a given month and year"
    Public Function GetProfitByMonthYear(ByVal month As String, ByVal year As String) As String
        Dim Data As DataTable = GetDatatable("SELECT
                                            SUM([Unit_Price] * [Qty]) AS TotalAmount 
                                            FROM " &
                                            FACTUREDETAIL_DTO.TABLE_NAME &
                                            " INNER JOIN " & FACTURE_DTO.TABLE_NAME & " ON " &
                                            FACTUREDETAIL_DTO.TABLE_NAME & "." & FACTUREDETAIL_DTO.FIELD_Facture_ID & " = " & FACTURE_DTO.TABLE_NAME & "." & FACTURE_DTO.FIELD_ID &
                                            " WHERE
                                             MONTH(" & FACTURE_DTO.TABLE_NAME & ".InvoiceDate) = " & month & " AND YEAR(" & FACTURE_DTO.TABLE_NAME & ".InvoiceDate) = " & year)
        If Data.Rows.Count > 0 Then

            Dim Record = Data.Rows(0)("TotalAmount").ToString()

            Return Record
        Else
            Return Nothing
        End If
    End Function
#End Region
End Class
