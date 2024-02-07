Public Class Transactions
    Implements IFormDatagridview

    Private ReadOnly Facture As New FACTURE_ASSEMBLER_SQL

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()
        ChangeTotalColumnToCurrency()
        ChangeDgdataColumnNames()
        ResizeDgdataColumns()
    End Sub

#Region "Change total column to currency"
    Private Sub ChangeTotalColumnToCurrency()
        dgData.Columns("Total").DefaultCellStyle.format     = "c"
    End Sub
#End Region

#Region "Change dgdata column names"
    Private Sub ChangeDgdataColumnNames()
        dgData.Columns("Client_FirstName").HeaderText       = "First Name"
        dgData.Columns("Nom").HeaderText                    = "Last Name"
        dgData.Columns("Payment_Type").HeaderText           = "Payment Type"
    End Sub
#End Region

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns("Payment_Type").AutoSizeMode         = DataGridViewAutoSizeColumnMode.None
        dgData.Columns("Payment_Type").Width                = 120
        dgData.Columns("Total").AutoSizeMode                = DataGridViewAutoSizeColumnMode.None
        dgData.Columns("Total").Width                       = 90
    End Sub
#End Region

#Region "RefreshGrid"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
        dgData.DataSource                    = Facture.GetFactures()
        RecordCountLabel.Text                = dgData.Rows.GetRowCount(0).ToString() & " Records"
    End Sub
#End Region

#Region "datagridview cell click"
    Private Sub DgData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellDoubleClick
        If e.RowIndex <= 0 AndAlso e.ColumnIndex <= 0 Then Exit Sub

        Dim ID                              = Convert.ToInt32(dgData.CurrentRow.Cells("ID").Value)
        Dim factureDetails As DataTable     = Facture.GetFactureByID(ID)
        Dim cashCredit As CASHCREDIT_DTO    = Facture.GetCashCredit(ID)
        Dim f As New InvoiceDetails

        f.dgData.DataSource = factureDetails
        f.ComputeSum()
        InvoiceDetailsInfo(f)
    End Sub

    Private Sub InvoiceDetailsInfo(ByVal f As InvoiceDetails)
        Dim ID                              = Convert.ToInt32(dgData.CurrentRow.Cells("ID").Value)
        Dim cashCredit As CASHCREDIT_DTO    = Facture.GetCashCredit(ID)
        f.DateLabel.Text                    = dgData.CurrentRow.Cells("InvoiceDate").Value
        f.ClientNameLabel.Text              = dgData.CurrentRow.Cells("Nom").value & ", " & dgData.CurrentRow.Cells("Client_FirstName").Value

        If dgData.CurrentRow.Cells("Payment_Type").Value = "Cash" Then
            ShowInvoiceDetails(f, f.TotalLabel.Text, cashCredit.CreditPayment.ToString("c"))

        ElseIf dgData.CurrentRow.Cells("Payment_Type").Value = "Credit"
            ShowInvoiceDetails(f, cashCredit.CashPayment.ToString("c"), f.TotalLabel.Text)

        Else
            ShowInvoiceDetails(f, cashCredit.CashPayment.ToString("c"), cashCredit.CreditPayment.ToString("c"))

        End If
    End Sub

    Private Sub ShowInvoiceDetails(ByVal f As InvoiceDetails, ByVal cashLabel As String, ByVal creditLabel As String)
        f.CashLabel.Text = cashLabel
        f.CreditLabel.Text = creditLabel
        f.Show()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region

#Region "Best sellers"
    Private Sub BestSellersbutton_Click(sender As Object, e As EventArgs) Handles BestSellersbutton.Click
        Dim f As New MonthYearFilter
        f.ShowDialog()
    End Sub
#End Region
End Class