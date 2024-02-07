Public Class frmEditCart
    Private ReadOnly Assembler As New INVENTAIRE_ASSEMBLER_SQL
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddReasonsToComboBox()
    End Sub

#Region "Add reasons to ComboBox"
    Private Sub AddReasonsToComboBox()
        ReasonComboBox.Items.Add("Liquidation")
        ReasonComboBox.Items.Add("Out of date")
        ReasonComboBox.Items.Add("N/A")
    End Sub
#End Region

#Region "Item listbox value changed"
    Private Sub ItemListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemListbox.SelectedIndexChanged
        ItemPriceNumericUpDown.Value    = CashRegisterBuy.dgData.Rows.Item(ItemListbox.SelectedIndex).Cells("Prixunitaire").Value
        ItemQTYNumericUpDown.Value      = CashRegisterBuy.dgData.Rows.Item(ItemListbox.SelectedIndex).Cells(INVENTORY_DTO.FIELD_Quantite).Value
        ReasonComboBox.SelectedItem     = CashRegisterBuy.dgData.Rows.Item(ItemListbox.SelectedIndex).Cells("SaleReason").Value
    End Sub
    Private Sub ItemListbox_GotFocus(sender As Object, e As EventArgs) Handles ItemListbox.GotFocus
        ItemListbox.SelectedIndex = 0
    End Sub
#End Region

#Region "Remove row button"
    Private Sub RemoveRowbtn_Click(sender As Object, e As EventArgs) Handles RemoveRowbtn.Click
        if ItemListbox.SelectedIndex = -1 Then Exit Sub

        dim res = MsgBox("Are you sure you want to remove this item?", vbYesNo + vbExclamation, "Warning")
        If res = MsgBoxResult.Yes
            Try
                CashRegisterBuy.dgData.Rows.RemoveAt(ItemListbox.SelectedIndex)
                ComputeSum()
                refreshCart()

                If CashRegisterBuy.dgData.Rows.Count > 3 Then
                    Dim middleRowIndex As Integer = CashRegisterBuy.dgData.Rows.Count \ 2
                    CashRegisterBuy.dgData.FirstDisplayedScrollingRowIndex = middleRowIndex
                End If

            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "Compute sum"
    Private Sub ComputeSum()
        Dim total As Decimal = 0

        For each row As DataGridViewRow In CashRegisterBuy.dgData.Rows
            total += row.Cells(INVENTORY_DTO.FIELD_Prixvente).value
        Next

        CashRegisterBuy.TotalLabel.Text = total.ToString("c")
        CashRegisterSell.TotalLabel.Text = total.ToString("c")
    End Sub
#End Region

#Region "Refresh cart"
    Private Sub RefreshCart()
         ItemListbox.Items.Clear()
         ItemQTYNumericUpDown.Value        = 1
         ItemPriceNumericUpDown.Value      = 0
         ItemListbox.BeginUpdate()
         For each row In CashRegisterBuy.dgData.Rows()
            ItemListbox.Items.Add(row.Cells(INVENTORY_DTO.FIELD_NOM).value)
         Next
         ItemListbox.EndUpdate()
    End Sub
#End Region

#Region "Edit cart button"
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        if ItemListbox.SelectedIndex    = -1 Then Exit Sub
        dim res                         = MsgBox("Edit this item?", vbYesNo + vbExclamation, "Warning")
        If res = MsgBoxResult.Yes
            Try
                EditItemInfo()
                RefreshCart()
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        End If
    End Sub

    Private Function CheckQuantity()
        Dim productInfo  As INVENTORY_DTO = Assembler.GetProductByUPC(CashRegisterBuy.dgData.Rows.Item(ItemListbox.SelectedIndex).Cells(INVENTORY_DTO.FIELD_UPC).Value)
        Dim stock        As New Integer
        For each row In CashRegisterBuy.dgData.Rows
            If row.Cells(INVENTORY_DTO.FIELD_UPC).Value.Equals(productInfo.UPC)
                stock += row.Cells(INVENTORY_DTO.FIELD_Quantite).Value
            End If
        Next
    Return stock - CashRegisterBuy.dgData.Rows.Item(ItemListbox.SelectedIndex).Cells(INVENTORY_DTO.FIELD_Quantite).Value
    End Function

    Private Sub EditItemInfo()
        Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(CashRegisterBuy.dgData.Rows.Item(ItemListbox.SelectedIndex).Cells(INVENTORY_DTO.FIELD_UPC).Value)
        For each row In CashRegisterBuy.dgData.Rows()
            If CheckQuantity() + ItemQTYNumericUpDown.Value > productInfo.Quantité Then Throw New Exception("Not enough stock in the inventory for this amount.")
            if productInfo.Prixvente < ItemPriceNumericUpDown.Value Then Throw New Exception("Selling price can't be higher than the one in the inventory.")
            If row.Index = ItemListbox.SelectedIndex Then
                row.Cells(INVENTORY_DTO.FIELD_Quantite).Value     = ItemQTYNumericUpDown.Value
                row.Cells("Prixunitaire").Value                   = ItemPriceNumericUpDown.Value
                row.Cells(INVENTORY_DTO.FIELD_Prixvente).Value    = row.Cells("Prixunitaire").Value * row.Cells(INVENTORY_DTO.FIELD_Quantite).Value
                row.Cells("SaleReason").Value                     = ReasonComboBox.SelectedItem
                ComputeSum()
            End If
        Next 
    End Sub
#End Region

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub FrmInventoryAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Cancelbtn_Click(Nothing, Nothing)
    End Sub
#End Region
End Class