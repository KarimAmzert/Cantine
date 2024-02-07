Public Class StocktakingMenu
    Private ReadOnly Assembler    As New INVENTAIRE_ASSEMBLER_SQL
    Private ReadOnly PDF          As StockTakingReportCollection = Assembler.GetActiveInventory()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not My.User.IsInRole(USER_DTO.FIELD_StockTaking) Then
            Adjustbtn.Enabled = False
        End If
    End Sub

#Region "Adjust Button"
    Private Sub Adjustbtn_Click(sender As Object, e As EventArgs) Handles Adjustbtn.Click
        Dim Barcode = InputBox("Scan StockTaking Code","StockTaking")
        If Barcode = "" Then Exit Sub
        Try
            StockTaking.ShowForm(PDF.LoadFrom2DBarcode(Barcode))
        Catch ex As Exception
            DisplayErrorMessage("Invalid count sheet code.")
        End Try
    End Sub
#End Region

#Region "Count Sheet Button"
    Private Sub CountSheetbtn_Click(sender As Object, e As EventArgs) Handles CountSheetbtn.Click
        PDF.CreateCountSheet()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub Cantine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then Close()
    End Sub
#End Region
End Class