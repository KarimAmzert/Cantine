Public Class Checkout
    Private ReadOnly Assembler      As New INVENTAIRE_ASSEMBLER_SQL
    Private ReadOnly History        As New HISTORIQUE_ASSEMBLER_SQL
    Private ReadOnly Facture        As New FACTURE_ASSEMBLER_SQL
    Private ReadOnly Client         As New CLIENT_ASSEMBLER_SQL
    Private ReadOnly User           As New USER_ASSEMBLER_SQL
    Private ReadOnly Caisse         As New CAISSE_ASSEMBLER_SQL

    Private ReadOnly GUEST_NAME     As String = "GUEST"
    Private ReadOnly Column1        As String = "Column1"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PopulateDgData()
        ChangeDgDataCellStyleToCurrency()
        AddCashRegisterText()
        dgData.Columns(Column1).Visible = False

        CheckForGuest()
    End Sub

#Region "Populate dgdata"
    Private Sub PopulateDgData()
        dgData.DataSource = DgDataSource()
    End Sub
#End Region

#Region "Change dgdata cell style to currency"
    Private Sub ChangeDgDataCellStyleToCurrency()
        dgData.Columns("Unit Price").DefaultCellStyle.Format    = "c"
        dgData.Columns("Sub Total").DefaultCellStyle.Format     = "c"
    End Sub
#End Region

#Region "Check for guest"
    Private Sub CheckForGuest()
        If CashRegisterBuy.NameLabel.Text.Split(" ")(0) = GUEST_NAME Then
            Creditbtn.Enabled = False
        End If
    End Sub
#End Region

#Region "Add Cash Register Text"
    Private Sub AddCashRegisterText()
        TotalLabel.Text                                         = CashRegisterBuy.TotalLabel.Text
        RemainingLabel.Text                                     = CashRegisterBuy.TotalLabel.Text
        DateLabel.Text                                          = CashRegisterBuy.DateLabel.Text
    End Sub
#End Region

#Region "DgData datasource"
    Private Function DgDataSource() As DataTable
        Dim dataTable As New DataTable()

        For Each dgvCol As DataGridViewColumn In CashRegisterBuy.dgData.Columns
            Dim columnDataType As Type = GetType(String)

            For Each dgvRow As DataGridViewRow In CashRegisterBuy.dgData.Rows
                If Not dgvRow.IsNewRow AndAlso dgvRow.Cells(dgvCol.Index).Value IsNot Nothing Then
                    Dim cellValue = dgvRow.Cells(dgvCol.Index).Value

                    If IsNumeric(cellValue) AndAlso TypeOf cellValue Is Decimal Then
                        columnDataType = GetType(Decimal)
                        Exit For
                    End If
                End If
            Next

            dataTable.Columns.Add(dgvCol.HeaderText, columnDataType)
        Next

        For Each dgvRow As DataGridViewRow In CashRegisterBuy.dgData.Rows
            If Not dgvRow.IsNewRow Then
                Dim newRow As DataRow = dataTable.NewRow()

                For Each dgvCell As DataGridViewCell In dgvRow.Cells
                    newRow(dgvCell.ColumnIndex) = dgvCell.Value
                Next

                dataTable.Rows.Add(newRow)
            End If
        Next

        Return dataTable
    End Function
#End Region

#Region "Confirm button"
    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        Dim paymentTypeID = CASHCREDIT_DTO.CASH_ID
        SellItems(paymentTypeID)
        InsertCashToCaisse(convert.ToDecimal(TotalLabel.Text.Split("$")(1)), "Sale")
        MsgBox("Purchase complete", MsgBoxStyle.Information, "Purchase")
        Close()
        CashRegisterBuy.Close()
        Clearcheckout()
        SyncManager(New ArrayList From {GetType(Cantine), GetType(ItemHistory), GetType(Transactions), GetType(UserHistory), GetType(Clients)})
    End Sub

    Private Sub InsertCashToCaisse(ByVal Amount As Decimal, ByVal Desc As String)
        Dim caisseInfo As CAISSE_DTO = Caisse.GetCaisse()
        Dim caisseRecord As New CAISSE_DTO With {
            .Amount         = Amount,
            .Desc           = Desc,
            .BeforeValue    = caisseInfo.Amount,
            .AfterValue     = caisseInfo.Amount + Amount,
            .User           = My.User.Name
        }
        Caisse.UpdateCaisse(caisseRecord)
        Caisse.InsertHistory(caisseRecord)
    End Sub

    Private sub Clearcheckout()
        CashRegisterSell.TotalLabel.Text = "$0.00"
    End sub

    Private Sub SellItems(ByVal paymentTypeID As Integer)
        If Not ChangeLabel.Text = "$0.00" Then
             dim res = MsgBox("Use remaining amount to pay off credit?", vbYesNo + vbExclamation, "Warning")

             If res = MsgBoxResult.Yes Then
                Dim clientInfo As CLIENT_DTO     = Client.getClientByMatricule(CashRegisterBuy.MatriculeLabel.Text)(0)
                Dim remainingValue               = ChangeLabel.Text.Split("$")(1)

                Client.PayOffCredit(Convert.ToDecimal(remainingValue), CashRegisterBuy.MatriculeLabel.Text)
             End If
        End if

        newFacture(PaymentTypeID)
        Dim facture_ID As FACTURE_DTO = Facture.GetNewestID()

        For each row In CashRegisterBuy.dgData.Rows
            Try
                Dim productInfo As INVENTORY_DTO    = Assembler.GetProductByUPC(row.Cells(INVENTORY_DTO.FIELD_UPC).value)
                Dim reason_ID As FACTURE_DTO        = Facture.GetReasonIDByName(row.Cells("Salereason").value)

                Dim historySellRecord As New HISTORY_DTO With {
                    .UPC                    = row.Cells(INVENTORY_DTO.FIELD_UPC).value,
                    .Desc                   = row.Cells(INVENTORY_DTO.FIELD_NOM).value,
                    .User                   = My.User.Name,
                    .Action                 = "Stock Sold",
                    .Remarques              = "",
                    .BeforeValue            = productInfo.Quantité,
                    .AfterValue             = productInfo.Quantité - row.Cells(INVENTORY_DTO.FIELD_Quantite).value
                }

                FactureDetails(facture_ID, row, productInfo, reason_ID)
                History.InsertHistory(historySellRecord)
                Assembler.SellStock(row.Cells(INVENTORY_DTO.FIELD_Quantite).value, row.Cells(INVENTORY_DTO.FIELD_UPC).value)
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        Next
    End Sub

    Private Sub FactureDetails(facture_ID As FACTURE_DTO, ByVal row As DataGridViewRow, ByVal productInfo As INVENTORY_DTO, ByVal reason_ID As FACTURE_DTO)
        Dim factureDetailRecord As New FACTUREDETAIL_DTO With {
            .Facture_ID         = facture_ID.ID,
            .Product_name       = row.Cells(INVENTORY_DTO.FIELD_NOM).Value,
            .Qty                = row.Cells(INVENTORY_DTO.FIELD_Quantite).Value,
            .Unit_Price         = row.Cells("Prixunitaire").Value,
            .Sale               = productInfo.Prixvente - row.Cells("Prixunitaire").Value,
            .Reason_ID          = reason_ID.ID
        }
        Facture.InsertFacture_Detail(factureDetailRecord)
    End Sub

    Private Sub NewFacture(ByVal paymentTypeID As Integer)
        Dim clientInfo As CLIENT_DTO    = Client.getClientByMatricule(CashRegisterBuy.MatriculeLabel.Text)(0)
        Dim cashierInfo As USER_DTO     = User.GetUserByName(My.User.Name)

        Dim factureRecord As New FACTURE_DTO With{
            .Cashier_ID                 = cashierInfo.ID,
            .Client_ID                  = clientInfo.ID,
            .Payment_Type_ID            = paymentTypeID
        }
        Facture.InsertFacture(factureRecord)
    End Sub
#End Region

#Region "Reset button"
    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        ChangeLabel.Text                    = "$0.00"
        PayLabel.Text                       = "$0.00"
        RemainingLabel.Text                 = CashRegisterBuy.TotalLabel.Text

        If CashRegisterBuy.MatriculeLabel.Text = "GUEST" Then
            Creditbtn.Enabled = False
            Else
            Creditbtn.Enabled = True
        End If
    End Sub
#end Region

#Region "Add button"
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim payValue            = PayLabel.Text.Split("$")(1)
        Dim change              = Convert.ToDecimal(payValue) + ClientAmountNumeric.Value
        PayLabel.Text           = "$" & change
        Dim totalValue          = TotalLabel.Text.Split("$")(1)
        Dim changeCalculator    = Convert.ToDecimal(totalValue) - Convert.ToDecimal(PayLabel.Text.Split("$")(1))

        If changeCalculator >= 0 Then
            RemainingLabel.Text = "$" & changeCalculator.ToString()
            Exit Sub
        Else
            RemainingLabel.Text     = "$0.00"
            Creditbtn.Enabled       =  False
        End If

        ChangeLabel.Text = "$" & changeCalculator.ToString().Remove(0,1)
        ClientAmountNumeric.Select(0, ClientAmountNumeric.Text.Length)
    End Sub
#End Region

#Region "Credit button"
    Private Sub Creditbtn_Click(sender As Object, e As EventArgs) Handles Creditbtn.Click
        Dim msgBox              As String
        Dim paymentTypeID       As Integer
        Dim valueToPay          As String

        If Not RemainingLabel.Text = CashRegisterBuy.TotalLabel.Text Then
            msgBox              = "Use Credit for the remaining amount?"
            paymentTypeID       = CASHCREDIT_DTO.CASH_CREDIT_ID
            valueToPay          = RemainingLabel.Text.Split("$")(1)
            PayWithCredit(msgBox,paymentTypeID,valueToPay)
        Else
            msgBox              = "Use Credit for this purchase?"
            paymentTypeID       = CASHCREDIT_DTO.CREDIT_ID
            valueToPay          = TotalLabel.Text.Split("$")(1)
            PayWithCredit(msgBox,paymentTypeID,valueToPay)
        End if
    End Sub

    Private Sub PayWithCredit(ByVal messageBoxMsg As String, ByVal paymentTypeID As Integer, totalValue As String)
        dim res = MsgBox(messageBoxMsg, vbYesNo + vbExclamation, "Warning")
        If res = MsgBoxResult.Yes
            Try
                Dim clientInfo As CLIENT_DTO = Client.getClientByMatricule(CashRegisterBuy.MatriculeLabel.Text)(0)

                if Not CheckClientCredit(clientInfo.Credit, Convert.ToDecimal(totalValue)) Then Exit Sub

                SellItems(paymentTypeID)
                Client.AdjustCredit(Convert.ToDecimal(totalValue), CashRegisterBuy.MatriculeLabel.Text)

                If paymentTypeID = 3 Then
                    Dim Factureinfo As FACTURE_DTO      = Facture.GetNewestID()
                    Dim valueToPayCash                  = PayLabel.Text.Split("$")(1)

                    Dim cashCreditRecord As New CASHCREDIT_DTO With {
                        .Facture_ID         = Factureinfo.ID,
                        .Client_ID          = clientInfo.ID,
                        .CashPayment        = Convert.ToDecimal(totalValue),
                        .CreditPayment      = Convert.ToDecimal(valueToPayCash)
                    }

                    Facture.InsertCashCredit(cashCreditRecord)
                    InsertCashToCaisse(Convert.ToDecimal(totalValue), "Sale")
                End If

                MsgBox("Purchase complete.", MsgBoxStyle.Information, "Purchase")
                CashRegisterBuy.Close()
                Clearcheckout()
                Close()
                SyncManager(New ArrayList From {GetType(Cantine), GetType(ItemHistory), GetType(Transactions), GetType(UserHistory)})
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        Elseif res = MsgBoxResult.No
            Exit Sub
        End If
    End Sub

    Private Function CheckClientCredit(ByVal clientCredit As Decimal, totalAmount As Decimal) As Boolean
        If (clientCredit + totalAmount > FACTURE_DTO.CREDIT_LIMIT) Then
            Dim clientLimit = MsgBox("Credit limit reached by Client with this purchase. Proceed?", vbYesNo + vbExclamation, "Warning")

            If clientLimit = MsgBoxResult.No Then
                Return False
            End If

        End If
        Return True
    End Function
#End Region

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Cancelbtn_Click(Nothing, Nothing)
    End Sub
#End Region
End Class