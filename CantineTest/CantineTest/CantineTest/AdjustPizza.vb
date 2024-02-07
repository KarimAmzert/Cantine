Public Class AdjustPizza
    Implements IFormDatagridview

    Private ReadOnly Caisse         As New CAISSE_ASSEMBLER_SQL
    Private ReadOnly Inventory      As New INVENTAIRE_ASSEMBLER_SQL

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()
        CashNumeric.Minimum             = convert.ToDecimal(CashLabel.Text.Split("$")(1)) - (convert.ToDecimal(CashLabel.Text.Split("$")(1)) * 2)
        CashNumeric.Maximum             = 0
    End Sub

#Region "RefreshGrid"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
        Dim caisseAmount As String      = Caisse.GetCaisse().Amount.ToString("c")
        CashLabel.Text                  = caisseAmount
    End Sub
#End Region

#Region "Confirm button"
    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        dim res = MsgBox("Adjust Cash Register?", vbYesNo + vbExclamation, "Warning")
        If res = MsgBoxResult.Yes
            Try
                ValidateForm()
                Dim caisseRecord As CAISSE_DTO      = CreateCaisseRecord()
                Dim pizzaRecord As HISTORY_DTO      = CreatePizzaPoutineRecord("PIZZA", PizzaNumeric)
                Dim poutineRecord As HISTORY_DTO    = CreatePizzaPoutineRecord("POUTINE", PoutineNumeric)

                CaisseDBInserts(caisseRecord)
                InventoryDBInserts(pizzaRecord)
                InventoryDBInserts(poutineRecord)
                MsgBox("Pizza Adjustment Complete.", MsgBoxStyle.Information, "Adjustment")
                Close()
                SyncManager(New ArrayList From {GetType(CaisseHistory), GetType(AdjustRegister), GetType(Cantine), GetType(ItemHistory), GetType(UserHistory)})
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        End If
    End Sub

    Private Sub InventoryDBInserts(ProductRecord As HISTORY_DTO)
        Inventory.AdjustPizza(ProductRecord)
    End Sub

    Private Sub CaisseDBInserts(ByVal caisseRecord As CAISSE_DTO)
        Caisse.UpdateCaisse(caisseRecord)
        Caisse.InsertHistory(caisseRecord)
    End Sub

    Private Function CreateCaisseRecord()
        Dim caisseInfo As CAISSE_DTO = Caisse.GetCaisse()
        Return New CAISSE_DTO with{
            .Amount         = CashNumeric.Value,
            .Desc           = "Pizza Purchase",
            .BeforeValue    = caisseInfo.Amount,
            .AfterValue     = caisseInfo.Amount + CashNumeric.Value,
            .User           = My.User.Name
        }
    End Function

    Private Function CreatePizzaPoutineRecord(ByVal UPC As String, byval productNumeric As NumericUpDown)
        Dim productInfo As INVENTORY_DTO = Inventory.GetProductByUPC(UPC)
        Return New HISTORY_DTO with{
            .Action         = "Receive Stock",
            .AfterValue     = productInfo.Quantité + productNumeric.Value,
            .BeforeValue    = productInfo.Quantité,
            .Desc           = productInfo.NOM,
            .Remarques      = "",
            .UPC            = UPC,
            .User           = My.User.Name
        }
    End Function

    Private Sub ValidateForm()
        If CashNumeric.Value = 0 Then Throw New Exception("No amount selected for the adjustment.")
        If (convert.ToDecimal(CashLabel.Text.Split("$")(1)) + CashNumeric.Value) < 0 Then Throw New Exception("The adjustment is too high for the cash register's current amount")
    End Sub
#End Region

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub Caisse_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class