Public Class AdjustRegister
    Implements IFormDatagridview

    Private ReadOnly Caisse As New CAISSE_ASSEMBLER_SQL

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()
        CashNumeric.Minimum = convert.ToDecimal(CashLabel.Text.Split("$")(1)) - (convert.ToDecimal(CashLabel.Text.Split("$")(1)) * 2)
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
                Dim caisseRecord As CAISSE_DTO = CreateCaisseRecord()
                CaisseDBInserts(caisseRecord)
                MsgBox("Adjustment Complete.", MsgBoxStyle.Information, "Adjustment")
                Close()
                SyncManager(New ArrayList From {GetType(CaisseHistory), GetType(AdjustPizza)})
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CaisseDBInserts(ByVal caisseRecord As CAISSE_DTO)
        Caisse.UpdateCaisse(caisseRecord)
        Caisse.InsertHistory(caisseRecord)
    End Sub

    Private Function CreateCaisseRecord()
        Dim caisseInfo As CAISSE_DTO = Caisse.GetCaisse()
        Return New CAISSE_DTO with{
            .Amount         = CashNumeric.Value,
            .Desc           = ReasonListComboBox.SelectedItem,
            .BeforeValue    = caisseInfo.Amount,
            .AfterValue     = caisseInfo.Amount + CashNumeric.Value,
            .User           = My.User.Name
        }
    End Function

    Private Sub ValidateForm()
        If CashNumeric.Value = 0                                                        Then Throw New Exception("No amount selected for the adjustment.")
        If ReasonListComboBox.SelectedIndex = -1                                        Then Throw New Exception("No reason selected for the adjustment.")
        If (convert.ToDecimal(CashLabel.Text.Split("$")(1)) + CashNumeric.Value) < 0    Then Throw New Exception("The adjustment is too high for the cash register's current amount")
    End Sub
#End Region

#Region "Pizza adjustment button"
    Private Sub PizzaAdjustmentbtn_Click(sender As Object, e As EventArgs) Handles PizzaAdjustmentbtn.Click
        Dim f As New AdjustPizza
        f.Show()
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