Public Class Cantine
    Implements IFormDatagridview
    Private ReadOnly Assembler    As New INVENTAIRE_ASSEMBLER_SQL
    Private ReadOnly Client       As New CLIENT_ASSEMBLER_SQL
    ReadOnly bsData               As New BindingSource
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()
        DisableButtonsOnRole()
        ChangeDgdataCellFormat()
        ChangeDgdataHeaderText()
        ResizeDgdataColumns()

        dgData.Columns(INVENTORY_DTO.FIELD_ID).Visible = False
    End Sub

#Region "Disable buttons on role"  
    Private Sub DisableButtonsOnRole()
        If Not My.User.IsInRole(USER_DTO.FIELD_Inventory) Then
            AddStockbtn.Enabled     = False
            Adjustbtn.Enabled       = False
            EditProductbtn.Enabled  = False
            CreateItembtn.Enabled   = False
        End If
    End Sub
#End Region

#Region "Change dgdata cell format"
    Private Sub ChangeDgdataCellFormat()
        dgData.Columns(INVENTORY_DTO.FIELD_Minimum).DefaultCellStyle.Format         = "0"
        dgData.Columns(INVENTORY_DTO.FIELD_Maximum).DefaultCellStyle.Format         = "0"
        dgData.Columns(INVENTORY_DTO.FIELD_Prixvente).DefaultCellStyle.Format       = "c"
    End Sub
#End Region

#Region "Change dgdata header text"
    Private Sub ChangeDgdataHeaderText()
        dgData.Columns(INVENTORY_DTO.FIELD_Prixvente).HeaderText                    = "Unit Price"
        dgData.Columns(INVENTORY_DTO.FIELD_NOM).HeaderText                          = "Product Name"
        dgData.Columns(INVENTORY_DTO.FIELD_Actif).HeaderText                        = "Active"
        dgData.Columns(INVENTORY_DTO.FIELD_Quantite).HeaderText                     = "Qty"
    End Sub
#End Region

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns(INVENTORY_DTO.FIELD_Actif).AutoSizeMode                      = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_Actif).Width                             = 60

        dgData.Columns(INVENTORY_DTO.FIELD_Quantite).AutoSizeMode                   = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_Quantite).Width                          = 60

        dgData.Columns(INVENTORY_DTO.FIELD_Prixvente).AutoSizeMode                  = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_Prixvente).Width                         = 60

        dgData.Columns(INVENTORY_DTO.FIELD_Minimum).AutoSizeMode                    = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_Minimum).Width                           = 60

        dgData.Columns(INVENTORY_DTO.FIELD_Maximum).AutoSizeMode                    = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_Maximum).Width                           = 60

        dgData.Columns(INVENTORY_DTO.FIELD_UOI).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_UOI).Width                               = 60

        dgData.Columns(INVENTORY_DTO.FIELD_UPC).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_UPC).Width                               = 150

        dgData.Columns(INVENTORY_DTO.FIELD_NOM).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(INVENTORY_DTO.FIELD_NOM).Width                               = 500
    End Sub
#End Region

#Region "Refresh datagridview"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
        dgData.DataSource           = Assembler.GetInventory()
        bsData.DataSource           = dgData.DataSource
        ProductCountLabel.Text      = dgData.Rows.GetRowCount(0).ToString() & " Records"
        CheckQty()
    End Sub

    Private Sub DgData_Sorted(sender As Object, e As EventArgs) Handles dgData.Sorted
        CheckQty()
    End Sub

    Private Sub CheckQty()
        For Each row As DataGridViewRow In dgData.Rows
            If row.Cells(INVENTORY_DTO.FIELD_Quantite).Value < row.Cells(INVENTORY_DTO.FIELD_Minimum).Value AndAlso row.Cells(INVENTORY_DTO.FIELD_Actif).Value = True Then
                row.Cells(INVENTORY_DTO.FIELD_Quantite).Style.ForeColor = Color.Red
            End If
        Next
    End Sub
#End Region

#Region "Create Item form button"
    Private Sub CreateItembtn_Click(sender As Object, e As EventArgs) Handles CreateItembtn.Click
        Dim reponse As String = InputBox("Scan Barcode", "Scan Barcode", " ")
        If reponse = "" Then Exit Sub
        Try
            Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(reponse)
            ValidateUPC(productInfo)
            ShowCreateItem(reponse)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub ValidateUPC(byval productinfo As INVENTORY_DTO)
        If not productInfo.UPC.Length = 0 Then Throw New Exception("This UPC code is already inside the inventory.")
    End Sub

    Private Sub ShowCreateItem(ByVal reponse As String)
        Dim f As New FrmInventoryAdd
        f.ItemUPCTextBox.Text = reponse
        If reponse = " " Then f.ItemUPCTextBox.Text = ""
        f.Show()
    End Sub
#End Region

#Region "Add stock form button"
    Private Sub AddStockbtn_Click(sender As Object, e As EventArgs) Handles AddStockbtn.Click  
        Dim reponse As String = InputBox("Scan Barcode")
        If reponse = "" Then Exit Sub
        Try
            Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(reponse)
            If productInfo.UPC.Length = 0
                Dim prompt = MsgBox("No product inside the inventory associated with this UPC. Create a new product?", vbYesNo + vbExclamation, "UPC not found")
                If prompt = MsgBoxResult.Yes
                    ShowFrmInventoryAdd(reponse)
                End If
                Exit Sub
            End If
            ShowAddItem(productInfo)
        Catch ex As Exception
            DisplayErrorMessage("Enter a valid UPC code")
        End Try
    End Sub

    Private Sub ShowFrmInventoryAdd(ByVal reponse As String)
        Dim frm                     As New FrmInventoryAdd
        frm.ItemUPCTextBox.Text     = reponse
        frm.Show()
    End Sub

    Private sub ShowAddItem(ByVal productInfo As INVENTORY_DTO)
        Dim f                       As New AddItem
        f.UPCLabel.Text             = productInfo.UPC
        f.ProductNameLabel.Text     = productInfo.NOM
        f.ShowDialog()
    End sub
#End Region

#Region "Adjust quantity form button"
    Private Sub Adjustbtn_Click(sender As Object, e As EventArgs) Handles Adjustbtn.Click
        if dgData.DisplayedRowCount(True) = 0 Then Exit Sub
        Try
            Dim reponse As Object              = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_UPC).Value
            Dim productInfo As INVENTORY_DTO   = Assembler.GetProductByUPC(reponse)
            ShowAdjustQty(productInfo)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub ShowAdjustQty(ByVal productInfo As INVENTORY_DTO)
        Dim f As New frmAdjustQTY
        f.UPCLabel.Text                    = productInfo.UPC
        f.ProductnameLabel.Text            = productInfo.NOM
        f.QtyLabel.Text                    = productInfo.Quantité
        f.ShowDialog()
    End Sub
#End Region

#Region "history form button"
    Private Sub Historybtn_Click(sender As Object, e As EventArgs) Handles Historybtn.Click
        If dgData.DisplayedRowCount(True) = 0 Then Exit Sub
        ItemHistory.ShowForm(dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_UPC).Value)
    End Sub
#End Region

#Region "Transaction button"
    Private Sub Transactionbtn_Click(sender As Object, e As EventArgs) 
        Dim f As New Transactions
        f.Show()
    End Sub
#End Region

#Region "Edit Product button"
    Private Sub EditProductbtn_Click(sender As Object, e As EventArgs) Handles EditProductbtn.Click
        If dgData.DisplayedRowCount(True) = 0 Then Exit Sub
        EditItem.ShowForm(dgData)
    End Sub
#End Region


#Region "SearchBar"
    Private Sub NameFilterSearch_TextChanged(sender As Object, e As EventArgs) Handles NameFilterSearch.TextChanged 
        If NameFilterSearch.Text = "SEARCH BY NAME/UPC" Then
            SearchPictureBox.ImageLocation = IMAGE_LOCATION & "\Resources\Gakuseisean-Ivista-2-Start-Menu-Search.24.png"
            Exit Sub
        End If
        bsData.Filter                       = String.Format( INVENTORY_DTO.FIELD_NOM & " Like '%{0}%' or " & INVENTORY_DTO.FIELD_UPC & " Like '%{0}%' ", NameFilterSearch.Text)
        ProductCountLabel.Text              = dgData.Rows.GetRowCount(0).ToString() & " Records"
        CheckQty()
        SearchPictureBox.ImageLocation = IMAGE_LOCATION & "\Resources\Oxygen-Icons.org-Oxygen-Actions-application-exit.24.png"
    End Sub

    Private Sub NameFilterSearch_GotFocus(sender As Object, e As EventArgs) Handles NameFilterSearch.GotFocus
        If NameFilterSearch.Text = "SEARCH BY NAME/UPC" Then
            NameFilterSearch.Text = ""
        End If
    End Sub

    Private Sub NameFilterSearch_LostFocus(sender As Object, e As EventArgs) Handles NameFilterSearch.LostFocus
        If String.IsNullOrEmpty(NameFilterSearch.Text) Then
            NameFilterSearch.Text = "SEARCH BY NAME/UPC"
        End If
    End Sub
#End Region

#Region "Searchbar picturebox change"
    Private Sub SearchPictureBox_Click(sender As Object, e As EventArgs) Handles SearchPictureBox.Click
        If SearchPictureBox.ImageLocation =  IMAGE_LOCATION & "\Resources\Oxygen-Icons.org-Oxygen-Actions-application-exit.24.png" Then
            NameFilterSearch.Text = ""
        End If
    End Sub
#End Region

#Region "datagridview cell click"
    Private Sub DgData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellDoubleClick 
        If e.RowIndex <= 0 AndAlso e.ColumnIndex <= 0 Then Exit Sub
        If Not My.User.IsInRole(USER_DTO.FIELD_Inventory) Then Exit Sub
        EditItem.ShowForm(dgData)
    End Sub
#End Region

#Region "Refresh datagridview button"
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        RefreshGrid()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then Refreshbtn_Click(Nothing, Nothing)
        If e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control Then NameFilterSearch.Focus()
    End Sub

    Private Sub Cantine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then Close()
    End Sub
#End Region
End Class
