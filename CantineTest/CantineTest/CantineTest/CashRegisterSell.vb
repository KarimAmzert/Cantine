Imports System.IO
Public Class CashRegisterSell
    Private ReadOnly Assembler      As New INVENTAIRE_ASSEMBLER_SQL
    Private ReadOnly History        As New HISTORIQUE_ASSEMBLER_SQL
    Private ReadOnly Facture        As New FACTURE_ASSEMBLER_SQL
    Private ReadOnly Client         As New CLIENT_ASSEMBLER_SQL
    Private ReadOnly GUEST_NAME     As String = "GUEST"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        HideCreditButtonOnNewClient()
        ' Add any initialization after the InitializeComponent() call.
        ComputeSum()
    End Sub

#Region "Hide credit button on new client"
    Private Sub HideCreditButtonOnNewClient()
        If CashRegisterBuy.MatriculeLabel.Text = "GUEST" Then
            Creditbtn.Enabled = False
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
        Me.TotalLabel.Text              = total.ToString("c")
    End Sub
#End Region

#Region "Scan button"
    Private Sub Scanbtn_Click(sender As Object, e As EventArgs) Handles Scanbtn.Click
        If not CashRegisterBuy.Visible Then Exit Sub

        Dim upc As String = InputBox("Scan Barcode")

        If upc.Contains("!") Then
            Try
                If ContainsNumbers(upc) Then
                    ContainsmultipleNames(upc.Substring(2, upc.Length -3))
                    CheckForGuest()
                Else
                    ContainsmultipleNames(upc)
                    CheckForGuest()
                End If
            Catch ex As Exception
                Dim prompt = MsgBox("No client associated with this matricule/name found. Create a new client?", vbYesNo + vbExclamation, "Client not found")
                    If prompt = MsgBoxResult.Yes
                        Dim f As New NewClient
                        f.Show()
                    End If
                    Exit Sub
            End Try
        End If
        AddScanInfo(upc)
    End Sub

    Private Sub AddScanInfo(ByVal upc As String)
        If upc = "" Then Exit Sub

        Try
            Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(upc)
            ValidateScan(productInfo)

            ProductNameTextbox.Text             = productInfo.NOM
            UPCTextbox.Text                     = productInfo.UPC
            ItemPriceNumericUpDown.Value        = productInfo.Prixvente
            ItemQTYNumericUpDown.Value          = 1
            Addbtn_Click(Nothing, Nothing)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub ValidateScan(ByVal productInfo As INVENTORY_DTO)
        If productInfo.UPC.Length           = 0 Then Throw New Exception("Invalid UPC code")
        If productInfo.Quantité             = 0 Then Throw New Exception("Out of stock")
    End Sub
#End Region

#Region "Start checkout button"
    Private Sub StartCheckoutbtn_Click(sender As Object, e As EventArgs) 
        If cashRegisterBuy.Visible Then Exit Sub
        Dim reponse As String = InputBox("Scan Client Card", "Client")
        If reponse = "" Then Exit Sub

        Try
            If ContainsNumbers(reponse) Then
                'Substring(2, reponse.Length -3) removes the extra characters from the scanned client cards
                ContainsmultipleNames(reponse.Substring(2, reponse.Length -3))
                CheckForGuest()
            Else
                ContainsmultipleNames(reponse)
                CheckForGuest()
            End If

        Catch ex As Exception
            Dim prompt = MsgBox("No client associated with this matricule/name found. Create a new client?", vbYesNo + vbExclamation, "Client not found")
                If prompt = MsgBoxResult.Yes
                    Dim f As New NewClient
                    f.Show()
                End If
                Exit Sub
        End Try
    End Sub

    Private Sub CheckForGuest()
        If CashRegisterBuy.MatriculeLabel.Text = GUEST_NAME Then
            Creditbtn.Enabled = False
        Else
            Creditbtn.Enabled = True
        End If
    End Sub

    Private Sub ContainsmultipleNames(ByVal reponse As String)
        Dim clientInfo As CLIENT_DTO
        Dim ClientsCount As CLIENT_COLLECTION = Client.getClientByMatricule(reponse)
        If ClientsCount.Count = 0 Then Throw New Exception("Client does not exist.")

        If ClientsCount.Count > 1 Then

            Dim f As New ReasonChange
            f.ProductNameLabel.Text     = reponse
            f.Label1.Text               = "Multiple clients found with name: "
            f.Label3.Text               = "Select Client:"

            f.ReasonListComboBox.Items.Clear()

            For each client As CLIENT_DTO In ClientsCount
                f.ReasonListComboBox.Items.Add(client.Client_FirstName & " " & client.Nom)
            Next

            f.ShowDialog()
            If f.ReasonListComboBox.SelectedItem = Nothing Then Exit Sub
            clientInfo = Client.getClientByName(f.ReasonListComboBox.SelectedItem.ToString.Split(" ")(0), f.ReasonListComboBox.SelectedItem.ToString.Split(" ")(1))(0)
            ShowCashRegisterBuy(clientInfo)
            Exit Sub
       Else
            clientInfo = Client.getClientByMatricule(reponse)(0)
            ShowCashRegisterBuy(clientInfo)
        End If
    End Sub

    Private Sub ShowCashRegisterBuy(ByVal clientInfo As CLIENT_DTO)
        CashRegisterBuy.NameLabel.Text              = clientInfo.Client_FirstName & " " & clientInfo.Nom & " " & clientInfo.Matricule
        CashRegisterBuy.MatriculeLabel.Text         = clientInfo.Matricule
        CashRegisterBuy.MatriculeLabel.Visible      = False
        CashRegisterBuy.Show()
    End Sub
#End Region

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        If not CashRegisterBuy.Visible Then Exit Sub

        Dim Res As DialogResult = DialogResult.Yes
        
        If CartHasItem()            Then Res = MsgBox("Clear cart?", vbYesNo + vbExclamation, "Warning")
        If Res = MsgBoxResult.Yes   Then Clearcheckout()
    End Sub
    Private Function CartHasItem() As Boolean
        Return Not CashRegisterBuy.dgData.Rows.Count = 0
    End Function
    Private sub Clearcheckout()
        CashRegisterBuy.dgData.Rows.Clear()
        CashRegisterBuy.TotalLabel.Text         = "$0.00"
        Me.TotalLabel.Text                      = "$0.00"
    End sub
#End Region

#Region "Confirm button"
    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        If CashRegisterBuy.dgData.Rows.Count = 0 Then Exit Sub
        Dim clientMatricule             = CashRegisterBuy.MatriculeLabel.Text
        Dim clientInfo As CLIENT_DTO    = Client.getClientByMatricule(clientMatricule)(0)
        ShowCheckout(clientInfo)
    End Sub

    Private Sub ShowCheckout(byval clientInfo As CLIENT_DTO)
        Dim f As New Checkout

        f.ClientNameLabel.Text          = CashRegisterBuy.NameLabel.Text.Split(" ")(1)
        f.CreditLabel.Text              = clientInfo.Credit.ToString("c")
        f.ShowDialog()
    End Sub
#End Region

#Region "Add to cart button"
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) 
        If Not cashRegisterBuy.Visible Then Exit Sub
        Try
            Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(UPCTextbox.Text)
            
            ValidForm(productInfo)            

            Dim ExistingRow As DataGridViewRow = GetExistingRow()

            If ExistingRow Is Nothing Then
                AddToRegisterBuy(productInfo)
            Else
                UpdateRegisterBuyerRow(ExistingRow)             
            End If

            Scanbtn_Click(Nothing,Nothing)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Function GetExistingRow() As DataGridViewRow
        Dim rowExisting As DataGridViewRow  = Nothing
        Dim productInfo As INVENTORY_DTO    = Assembler.GetProductByUPC(UPCTextbox.Text)

        For Each row As DataGridViewRow In CashRegisterBuy.dgData.Rows
            If row.Cells(INVENTORY_DTO.FIELD_UPC).Value.ToString() = UPCTextbox.Text AndAlso CDbl(row.Cells("Prixunitaire").Value) = ItemPriceNumericUpDown.Value Then

                If CheckQuantity() + ItemQTYNumericUpDown.Value > productInfo.Quantité Then Throw New Exception("Not enough stock in the inventory for this amount.")
                rowExisting = row

            End If
        Next

        Return RowExisting
    End Function

    Private Sub AddToRegisterBuy(ByVal productInfo As INVENTORY_DTO)
        Dim imagePath As String =  IMAGE_LOCATION & "\Resources\" & productInfo.UPC & ".jpg"

        Try
            Using fileStream As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                Using productImage As Image = Image.FromStream(fileStream)
                    CashRegisterBuy.dgData.Rows.Add(ProductNameTextbox.Text, UPCTextbox.Text, ItemQTYNumericUpDown.Value, ItemPriceNumericUpDown.Value, ItemPriceNumericUpDown.Value * ItemQTYNumericUpDown.Value, GetReasonChange(productInfo), CloneImage(productImage))
                End Using
            End Using
        Catch ex As Exception
            Dim defaultImagePath As String =  IMAGE_LOCATION & "\Resources\" & IMAGE_TEMPLATE
            Using defaultImage As Image = Image.FromFile(defaultImagePath)
                CashRegisterBuy.dgData.Rows.Add(ProductNameTextbox.Text, UPCTextbox.Text, ItemQTYNumericUpDown.Value, ItemPriceNumericUpDown.Value, ItemPriceNumericUpDown.Value * ItemQTYNumericUpDown.Value, GetReasonChange(productInfo), CloneImage(defaultImage))
            End Using
        End Try

        ComputeSum()

        If CashRegisterBuy.dgData.Rows.Count > 3 Then
            Dim middleRowIndex As Integer = CashRegisterBuy.dgData.Rows.Count \ 2
            CashRegisterBuy.dgData.FirstDisplayedScrollingRowIndex = middleRowIndex
        End If
    End Sub

    Private Function CloneImage(ByVal originalImage As Image) As Image
        Using stream As New MemoryStream()
            originalImage.Save(stream, originalImage.RawFormat)
            Return Image.FromStream(stream)
        End Using
    End Function

    Private sub UpdateRegisterBuyerRow(ByVal row As DataGridViewRow)
        row.Cells(INVENTORY_DTO.FIELD_Quantite).Value       += ItemQTYNumericUpDown.Value
        row.Cells(INVENTORY_DTO.FIELD_Prixvente).Value      = CDbl(row.Cells("Prixunitaire").Value) * CDbl(row.Cells(INVENTORY_DTO.FIELD_Quantite).Value)
        ComputeSum()
    End sub

    Private Sub ValidForm(ByVal productInfo As INVENTORY_DTO)
            If productInfo.UPC.Length = 0                               Then Throw New Exception("Invalid UPC code.")            
            If productInfo.Quantité = 0                                 Then Throw New Exception("Out of stock.")
            If not productInfo.NOM = ProductNameTextbox.Text            Then Throw New Exception("Name does not match with the one in the inventory.")
            If ItemPriceNumericUpDown.Value > productInfo.Prixvente     Then Throw New Exception("Product price can't be more than the one listed in inventory.")
            If ItemQTYNumericUpDown.Value = 0                           Then Throw New Exception("Quantity can't be 0.")            
            If ItemQTYNumericUpDown.Value > productInfo.Quantité        Then Throw New Exception("Not enough stock in the inventory for this amount.")
    End Sub

    Private Function CheckQuantity()
        Dim stock As New Integer

        For each row In CashRegisterBuy.dgData.Rows
            If row.Cells(INVENTORY_DTO.FIELD_UPC).Value.Equals(UPCTextbox.Text)
                stock += row.Cells(INVENTORY_DTO.FIELD_Quantite).Value
            End If
        Next

        Return stock
    End Function

    Private Function GetReasonChange(ByVal productInfo As INVENTORY_DTO) As String
        Dim f As New ReasonChange

        If Not ItemPriceNumericUpDown.Value.Equals(productInfo.Prixvente) Then
            f.ProductNameLabel.Text = ProductNameTextbox.Text
            f.ShowDialog()

            If f.DialogResult = DialogResult.OK AndAlso Not f.ReasonListComboBox.SelectedIndex = -1 Then Return f.ReasonListComboBox.SelectedItem

        End If

        Return "N/A"
    End Function
#End Region

#Region "Edit cart button"
    Private Sub EditCartbtn_Click(sender As Object, e As EventArgs) Handles EditCartbtn.Click
        If CashRegisterBuy.dgData.Rows.Count = 0 Then Exit Sub
        ShowEditCart()
    End Sub

    Private Sub ShowEditCart()
        Dim f As New frmEditCart
        f.ItemListbox.BeginUpdate()

        For each row In CashRegisterBuy.dgData.Rows()
            f.ItemListbox.Items.Add(row.cells(INVENTORY_DTO.FIELD_NOM).Value)
        Next

        f.ItemListbox.EndUpdate()
        f.ShowDialog()
    End Sub
#End Region

#Region "Search client button"
    Private Sub SearchClientbutton_Click(sender As Object, e As EventArgs) Handles SearchClientbutton.Click
        Dim f As New SearchClient
        f.ShowDialog()
    End Sub
#End Region

#Region "Credit button"
    Private Sub Creditbtn_Click(sender As Object, e As EventArgs) Handles Creditbtn.Click
        Dim clientMatricule As String = CashRegisterBuy.NameLabel.Text.Split(" ")(2)
        Dim clientInfo As CLIENT_DTO = Client.getClientByMatricule(clientMatricule)(0)
        IndividualClient.ShowForm(clientInfo)
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If ActiveForm IsNot Nothing AndAlso e.KeyCode = Keys.Enter Then Addbtn_Click(Nothing, Nothing)
    End Sub
#End Region
End Class