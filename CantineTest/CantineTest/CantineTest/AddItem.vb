Public Class AddItem
    Private ReadOnly Assembler As New INVENTAIRE_ASSEMBLER_SQL

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Confirm button"
    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        Try
            Dim addstockHistory = CreateHistory()
            Assembler.AddStock(QTYNumeric.Value, addstockHistory)
            MsgBox("Product Stock Updated!", MsgBoxStyle.Information, "Record Updated")
            Close()
            SyncManager(New ArrayList From {GetTYpe(Cantine), GetType(ItemHistory), GetType(UserHistory)})
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Function CreateHistory() As HISTORY_DTO
        Dim productInfo = Assembler.GetProductByUPC(UPCLabel.Text)
        Return New HISTORY_DTO With {
            .User           = My.User.Name,
            .Desc           = productInfo.NOM,
            .UPC            = UPCLabel.Text,
            .Action         = "Receive Stock",
            .Remarques      = "",
            .BeforeValue    = productInfo.Quantité,
            .AfterValue     = productInfo.Quantité + QTYNumeric.Value
        }
    End Function
#End Region
End Class