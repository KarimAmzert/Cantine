Public Class InvoiceDetails
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "Compute Total sum"
    Public Sub ComputeSum()
        Dim total As Decimal = 0
            For each row As DataGridViewRow In dgData.Rows
               total += row.Cells("Sale_Price").value * row.Cells("Qty").Value
            Next
        TotalLabel.Text = total.ToString("c")
        dgData.Columns("Sale_Price").DefaultCellStyle.format = "c"
        dgData.Columns("Beforesale").DefaultCellStyle.format = "c"
        dgData.Columns("Sub_total").DefaultCellStyle.format = "c"
        dgData.Columns("Product_name").HeaderText = "Product Name"
        dgData.Columns("Sale_Price").HeaderText = "Sale Price"
        dgData.Columns("Beforesale").HeaderText = "Unit Price"
        dgData.Columns("Sub_total").HeaderText = "Sub Total"
    End Sub
#End Region

#Region "Key shortcuts"
 Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class