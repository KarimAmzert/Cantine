Public Class StockTaking
    Private Const FIELD_COUNT_INDEX     As Integer = 3
    Private ReadOnly Assembler          As New INVENTAIRE_ASSEMBLER_SQL
    Dim dataTable                       As New DataTable()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "lets only numbers inside dgdata cell"
    Private Sub DgData_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgData.EditingControlShowing
        If IsCountField() Then AddHandler CType(e.Control, TextBox).KeyPress, AddressOf dgData_keyPress
    End Sub

    Private Function IsCountField() As Boolean
        Return dgData.CurrentCell.ColumnIndex = FIELD_COUNT_INDEX
    End Function

    Private Sub DgData_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim pressedChar As Char = e.KeyChar
        If Not Char.IsDigit(pressedChar) AndAlso Not Char.IsControl(pressedChar) Then e.Handled = True
    End Sub
#End Region

#Region "Insert count sheet data"
    Private Sub InsertData(ByVal inputData As String)
        Dim productRecords() As String = inputData.Split("!")

        '-3 step 3 for 3 cells per row (-4 step 4 for 4 cells, 5 etc)       
        For i As Integer = 0 To productRecords.Length - 3 Step 3 
            Dim productName As String   = productRecords(i)
            Dim upc As String           = productRecords(i + 1)
            Dim qty As Integer          = Integer.Parse(productRecords(i + 2))            

            Dim newRow As DataRow       = dataTable.NewRow()
            newRow("ProductName")       = productName
            newRow("UPC")               = upc
            newRow("Qty")               = qty
            dataTable.Rows.Add(newRow)
        Next
    End Sub
#End Region

#Region "Save button"
    Private Sub Savebutton_Click(sender As Object, e As EventArgs) Handles Savebutton.Click
        Try
            For Each row As DataGridViewRow In dgData.Rows
                Dim countCellValue = If(row.Cells("Count").Value IsNot Nothing, row.Cells("Count").Value.ToString(), String.Empty)

                If String.IsNullOrWhiteSpace(countCellValue) Then Throw New Exception("Every product must have a count number.")

                Dim QtyHistoryrecord As New HISTORY_DTO With {
                    .Desc        = row.Cells("ProductName").Value,
                    .UPC         = row.Cells("UPC").Value,
                    .BeforeValue = row.Cells("Qty").Value,
                    .AfterValue  = countCellValue,
                    .Action      = "Adjustment",
                    .Remarques   = "StockTaking",
                    .User        = My.User.Name
                }
                Assembler.AdjustQTY(QtyHistoryrecord)
            Next

            MsgBox("Record Adjusted", MsgBoxStyle.Information, "Quantity adjusted.")
            Close()
            SyncManager(New ArrayList From {GetTYpe(Cantine), GetType(ItemHistory), GetType(UserHistory)})
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "ShowForm"
    Public Shared Sub ShowForm(ByVal inputData As String)
        Try
            Dim f As New StockTaking

            f.AddColumn("ProductName", 500, GetType(String))
            f.AddColumn("UPC", 150, GetType(String))
            f.AddColumn("Qty", 60, GetType(Integer))
            f.AddColumn("Count", 60, GetType(Integer))

            f.dataTable.Columns("ProductName").ReadOnly   = True
            f.dataTable.Columns("UPC").ReadOnly           = True
            f.dataTable.Columns("Qty").ReadOnly           = True
            f.dataTable.Columns("Count").ReadOnly         = False

            f.InsertData(inputData)
            f.Show()
            f.SetCursorToFirstCountInGrid()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub SetCursorToFirstCountInGrid()
            dgData.CurrentCell = dgData(FIELD_COUNT_INDEX, 0)
            dgData.Select()
    End Sub

    Private Sub AddColumn(Byval colName As String, ByVal Width As Integer, ByVal dataType As Type)
        dataTable.Columns.Add(colName, dataType)

        dgData.DataSource                       = dataTable
        dgData.Columns(colName).AutoSizeMode    = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(colName).Width           = Width
    End Sub
#End Region

#Region "Cancel button"
    Private Sub Cancelbutton_Click(sender As Object, e As EventArgs) Handles Cancelbutton.Click
        Close()
    End Sub
#End Region
End Class