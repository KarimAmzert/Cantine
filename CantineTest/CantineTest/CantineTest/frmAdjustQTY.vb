Public Class frmAdjustQTY
    Private ReadOnly Assembler As New INVENTAIRE_ASSEMBLER_SQL

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Confirm button"
    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        If AdjustNumeric.Value = 0 Then Exit Sub
        Try
            CheckInventoryQty()
            Assembler.AdjustQTY(AdjustQTYHistory())
            MsgBox("Quantity adjusted.", MsgBoxStyle.Information, "Record Adjusted")
            Close()
            SyncManager(New ArrayList From {GetTYpe(Cantine), GetType(ItemHistory), GetType(UserHistory)})
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private function AdjustQTYHistory() As HISTORY_DTO
        Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(UPCLabel.Text)
        Return New HISTORY_DTO With {
            .Desc        = ProductnameLabel.Text,
            .UPC         = UPCLabel.Text,
            .BeforeValue = productInfo.Quantité,
            .AfterValue  = productInfo.Quantité + AdjustNumeric.Value,
            .Action      = "Adjustment",
            .Remarques   = ReasonListComboBox.SelectedItem,
            .User        = My.User.Name
        }
    End function

    Private Sub CheckInventoryQty()
        Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(UPCLabel.Text)
        If productInfo.Quantité + AdjustNumeric.Value < 0 Then Throw New Exception ("Can't remove more products than there currently are in the inventory.")
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub FrmAdjustQTYAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If AdjustNumeric.Value = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then Confirmbtn_Click(Nothing, Nothing)
    End Sub
#End Region
End Class