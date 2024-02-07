Public Class SearchClient
    Implements IFormDatagridview

    Private ReadOnly Client     As New CLIENT_ASSEMBLER_SQL
    ReadOnly bsData             As New BindingSource

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()

        ChangeCreditCellStyleToCurrency()
        ChangeDgdataColumnHeaderText()
        ResizeDgdataColumns()
    End Sub

#Region "Change credit cellstyle to currency"
    Private Sub ChangeCreditCellStyleToCurrency()
        dgData.Columns(CLIENT_DTO.FIELD_Credit).DefaultCellStyle.Format = "c"
    End Sub
#End Region

#Region "Change dgdata column header text"
    Private Sub ChangeDgdataColumnHeaderText()
        dgData.Columns(CLIENT_DTO.FIELD_Client_FirstName).HeaderText        = "First Name"
        dgData.Columns(CLIENT_DTO.FIELD_Nom).HeaderText                     = "Last Name"
        dgData.Columns(CLIENT_DTO.FIELD_Rank).HeaderText                    = "Rank"
    End Sub
#End Region

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns(CLIENT_DTO.FIELD_Rank).AutoSizeMode                  = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CLIENT_DTO.FIELD_Rank).Width                         = 90

        dgData.Columns(CLIENT_DTO.FIELD_Credit).AutoSizeMode                = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CLIENT_DTO.FIELD_Credit).Width                       = 90

        dgData.Columns(CLIENT_DTO.FIELD_ID).AutoSizeMode                    = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CLIENT_DTO.FIELD_ID).Width                           = 90

        dgData.Columns(CLIENT_DTO.FIELD_Matricule).AutoSizeMode             = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CLIENT_DTO.FIELD_Matricule).Width                    = 150
    End Sub
#End Region

#Region "Refresh dgData"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
        dgData.DataSource       = Client.GetAllClients()
        RecordCountLabel.Text   = dgData.Rows.GetRowCount(0).ToString() & " Records"
        bsData.DataSource       = dgData.DataSource
    End Sub
#End Region

    Private Sub Confirmbutton_Click(sender As Object, e As EventArgs) Handles Confirmbutton.Click
        If dgData.RowCount = 0 Then Exit Sub
        CashRegisterBuy.MatriculeLabel.Text = dgData.CurrentRow.Cells(CLIENT_DTO.FIELD_Matricule).Value
        CashRegisterBuy.NameLabel.Text = dgData.CurrentRow.Cells(CLIENT_DTO.FIELD_Client_FirstName).Value & " " & dgData.CurrentRow.Cells(CLIENT_DTO.FIELD_Nom).Value & " " & dgData.CurrentRow.Cells(CLIENT_DTO.FIELD_Matricule).Value
        If Not dgData.CurrentRow.Cells(CLIENT_DTO.FIELD_Client_FirstName).Value = "GUEST" Then
            CashRegisterSell.Creditbtn.Enabled = True
            Close()
            Else
            CashRegisterSell.Creditbtn.Enabled = False
            Close()
        End If
    End Sub

#Region "Cancel button"
    Private Sub Cancelbutton_Click(sender As Object, e As EventArgs) Handles Cancelbutton.Click
        Close()
    End Sub
#End Region

#Region "datagridview cell click"
    Private Sub dgData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellDoubleClick
        If e.RowIndex <= 0 AndAlso e.ColumnIndex <= 0 Then Exit Sub
        Confirmbutton_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "SearchBar"
    Private Sub NameFilterSearch_TextChanged(sender As Object, e As EventArgs) Handles NameFilterSearch.TextChanged
        If NameFilterSearch.Text = "SEARCH BY FIRST/LAST NAME" Then
            SearchPictureBox.ImageLocation = IMAGE_LOCATION & "\Resources\Gakuseisean-Ivista-2-Start-Menu-Search.24.png"
            Exit Sub
        End If

        bsData.Filter                   = String.Format(CLIENT_DTO.FIELD_Client_FirstName & " Like '%{0}%' OR " & CLIENT_DTO.FIELD_Nom & " Like '%{0}%'", NameFilterSearch.Text)
        RecordCountLabel.Text           = dgData.Rows.GetRowCount(0).ToString() & " Records"
        SearchPictureBox.ImageLocation  = IMAGE_LOCATION & "\Resources\Oxygen-Icons.org-Oxygen-Actions-application-exit.24.png"
    End Sub

    Private Sub NameFilterSearch_GotFocus(sender As Object, e As EventArgs) Handles NameFilterSearch.GotFocus
        If NameFilterSearch.Text = "SEARCH BY FIRST/LAST NAME" Then
            NameFilterSearch.Text = ""
        End If
    End Sub

    Private Sub NameFilterSearch_LostFocus(sender As Object, e As EventArgs) Handles NameFilterSearch.LostFocus
        If String.IsNullOrEmpty(NameFilterSearch.Text) Then
            NameFilterSearch.Text = "SEARCH BY FIRST/LAST NAME"
        End If
    End Sub
#End Region

#Region "Searchbar picturebox change"
    Private Sub SearchPictureBox_Click(sender As Object, e As EventArgs) Handles SearchPictureBox.Click
        If SearchPictureBox.ImageLocation = IMAGE_LOCATION & "\Resources\Oxygen-Icons.org-Oxygen-Actions-application-exit.24.png" Then
            NameFilterSearch.Text = ""
        End If
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub EditItemAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
        If e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control Then NameFilterSearch.Focus()
    End Sub
#End Region
End Class