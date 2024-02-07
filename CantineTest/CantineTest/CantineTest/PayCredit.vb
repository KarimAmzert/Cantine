Public Class PayCredit
    Private ReadOnly Client       As New CLIENT_ASSEMBLER_SQL
    Private ReadOnly Caisse       As New CAISSE_ASSEMBLER_SQL

#Region "Confirm button"
    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        Dim clientInfo As CLIENT_DTO = Client.getClientByName(ClientNameLabel.Text.Split(" ")(0), ClientNameLabel.Text.Split(" ")(1))(0)
        Dim reponse = MsgBox("Pay Credit?", vbYesNo + vbExclamation, "Warning")
        If reponse = MsgBoxResult.Yes Then
            Try
                ValidateForm(clientInfo)

                If CheckChange(clientInfo) Then
                    Dim Change = (clientInfo.Credit - PayNumeric.Value).ToString("c").Split("-")(1)
                    Client.PayOffCredit(clientInfo.Credit, clientInfo.Matricule)
                    InsertCaisse(CreateCaisseInfo(clientInfo.Credit))
                    MsgBox("Credit Paid. Change: " & Change, MsgBoxStyle.Information, "Pay Credit")
                    SyncManager(New ArrayList From {GetType(Clients)})
                    Close()
                    Exit Sub
                End If

                Client.PayOffCredit(PayNumeric.Value, clientInfo.Matricule)
                InsertCaisse(CreateCaisseInfo(PayNumeric.Value))
                MsgBox("Credit Paid.", MsgBoxStyle.Information, "Pay Credit")
                SyncManager(New ArrayList From {GetType(Clients)})
                Close()
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        ElseIf reponse = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub InsertCaisse(ByVal caisseInfo As CAISSE_DTO)
        Caisse.InsertHistory(caisseInfo)
        Caisse.UpdateCaisse(caisseInfo)
    End Sub

    Private Function CreateCaisseInfo(ByVal Amount As Decimal)
        Return New CAISSE_DTO With {
            .Amount         = Amount,
            .User           = My.User.Name,
            .Desc           = "Credit Paid",
            .BeforeValue    = Caisse.GetCaisse().Amount,
            .AfterValue     = Caisse.GetCaisse.Amount + Amount
        }
    End Function

    Private Sub ValidateForm(ByVal clientInfo As CLIENT_DTO)
        If (clientInfo.Credit = 0)  Then Throw New Exception("No Credit owed for this account.")
        If (PayNumeric.Value = 0)   Then Throw New Exception("No amount entered.")
    End Sub

    Private Function CheckChange(Byval clientInfo As CLIENT_DTO) As Boolean
        Return (clientInfo.Credit - PayNumeric.Value < 0)
    End Function
#End Region

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class