Public Class IndividualClient
    Private ReadOnly Facture    As New FACTURE_ASSEMBLER_SQL
    Private ReadOnly Client     As New CLIENT_ASSEMBLER_SQL
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "ShowForm"
    Public Shared Sub ShowForm(ByVal clientInfo As CLIENT_DTO)
        Try
            Dim f As New IndividualClient
            f.Text = clientInfo.Client_FirstName & " " & clientInfo.Nom
            f.dgData.DataSource = f.Facture.GetFacturesByID(clientInfo.ID)
            f.dgData.Columns("Client_FirstName").HeaderText = "First Name"
            f.dgData.Columns("Total").DefaultCellStyle.Format = "c"
            f.dgData.Columns("Nom").HeaderText = "Last Name"
            f.dgData.Columns("Payment_Type").HeaderText = "Payment Type"
            f.dgData.Columns("Payment_Type").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            f.dgData.Columns("Payment_Type").Width = 120
            f.dgData.Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            f.dgData.Columns("Total").Width = 90
            f.RecordCountLabel.Text = f.dgData.Rows.GetRowCount(0).ToString() & " Records"
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "datagridview cell click"
    Private Sub DgData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellDoubleClick
        If e.RowIndex <= 0 AndAlso e.ColumnIndex <= 0 Then Exit Sub

        Dim ID = Convert.ToInt32(dgData.CurrentRow.Cells("ID").Value)
        Dim factureDetails As DataTable = Facture.GetFactureByID(ID)
        Dim cashCredit As CASHCREDIT_DTO = Facture.GetCashCredit(ID)
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

#Region "Pay credit button"
    Private Sub PayCreditbutton_Click(sender As Object, e As EventArgs) Handles PayCreditbutton.Click
        Dim firstName As String         = Me.Text.Split(" ")(0)
        Dim lastName As String          = Me.Text.Split(" ")(1)
        Dim clientInfo As CLIENT_DTO    = Client.getClientByName(firstName, lastName)(0)
        ShowPayCredit(clientInfo)
    End Sub

    Private Sub ShowPayCredit(byval clientInfo As CLIENT_DTO)
        Dim f As New PayCredit
        f.ClientNameLabel.Text = Me.Text
        f.CreditLabel.Text     = clientInfo.Credit.ToString("c")
        f.ShowDialog()
    End Sub
#End Region
End Class