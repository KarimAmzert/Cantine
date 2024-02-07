Public Class FrmInventoryAdd
    Private ReadOnly Assembler  As New INVENTAIRE_ASSEMBLER_SQL
    Private ReadOnly History    As New HISTORIQUE_ASSEMBLER_SQL
    Private _HasBeenModified    As Boolean = False

#Region "Select when numeric control gets focus"
    Private Sub NumericGotFocus(sender As Object, e As EventArgs) Handles ItemPriceNumericUpDown.GotFocus, ItemQTYNumericUpDown.GotFocus, ItemMinNumericUpDown.GotFocus, ItemMaxNumericUpDown.GotFocus
        If TypeOf sender Is NumericUpDown Then
            Dim numericUpDownControl As NumericUpDown = DirectCast(sender, NumericUpDown)
            numericUpDownControl.Select(0, numericUpDownControl.Text.Length)
        End If
    End Sub
#End Region

#Region "form value changed checker"
    Private Sub TxtValueChanged(sender As Object, e As EventArgs) Handles ItemNameTextBox.TextChanged, ItemQTYNumericUpDown.ValueChanged, ItemPriceNumericUpDown.ValueChanged, ItemUPCTextBox.TextChanged, ItemMinNumericUpDown.ValueChanged, ItemMaxNumericUpDown.ValueChanged
        _HasBeenModified = True
    End Sub
#End Region

#Region "Product Image button"
    Private Sub ProductImagebutton_Click(sender As Object, e As EventArgs) Handles ProductImagebutton.Click
        If ProductOpenFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = ProductOpenFileDialog.FileName
            ProductPictureBox.BackgroundImage = Image.FromFile(imagePath)
            ProductPictureBox.ImageLocation = imagePath
        End If
    End Sub

    Private Sub Clipboardbutton_Click(sender As Object, e As EventArgs) Handles Clipboardbutton.Click
        If My.Computer.Clipboard.ContainsImage Then
            ProductPictureBox.Image = My.Computer.Clipboard.GetImage
        End If
    End Sub
#End Region

#Region "Cancel Button"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dim res As DialogResult = DialogResult.Yes

        If _HasBeenModified Then res = MsgBox("The data you entered is currently not saved. Are you sure you want to cancel?", vbYesNo + vbExclamation, "Warning")
            
        If res = MsgBoxResult.Yes
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub
#End Region

#Region "Confirm Button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Try
            Dim newItemRecord As INVENTORY_DTO = CreateInventory()
            newItemRecord.IsValid()
            Dim newItemHistory As HISTORY_DTO = CreateHistory()

            Assembler.InsertInventory(newItemRecord)
            History.InsertHistory(newItemHistory)
            InsertImage()
            MsgBox("Item: " & ItemNameTextBox.Text & " added!", MsgBoxStyle.Information, "Record Appended")
            Close()
            SyncManager(New ArrayList From {GetType(Cantine), GetType(UserHistory)})
        Catch ex As Exception
            If ex.Message.IndexOf("duplicate") > -1 Then
                DisplayErrorMessage("Name and/or UPC code is already inside the inventory.")
            Else
                DisplayErrorMessage(ex.Message)
            End If
        End Try
    End Sub

    Private Sub InsertImage()
        If ProductPictureBox.Image IsNot Nothing Then
            Dim destinationImagePath =  IMAGE_LOCATION & "\Resources\" & ItemUPCTextBox.Text & ".jpg"
            Dim productImageSize As New Size(250, 250)
            Dim imageSizeBitmap As New Bitmap(ProductPictureBox.Image, productImageSize)
            imageSizeBitmap.Save(destinationImagePath, Imaging.ImageFormat.Jpeg)
            imageSizeBitmap.Dispose()
        End If
    End Sub

    Private Function CreateInventory() As INVENTORY_DTO
            Return New INVENTORY_DTO With {
                .NOM            = ItemNameTextBox.Text.ToUpper(),
                .Quantité       = ItemQTYNumericUpDown.Value,
                .UPC            = ItemUPCTextBox.Text.Trim(),
                .UOI            = "EA",
                .Actif          = True,
                .Minimum        = ItemMinNumericUpDown.Value,
                .Maximum        = ItemMaxNumericUpDown.Value,
                .LastModifiedBy = My.User.Name,
                .Prixvente      = ItemPriceNumericUpDown.Value
            }
    End Function

    Private Function CreateHistory() As HISTORY_DTO
            Return New HISTORY_DTO With {
                .User           = My.User.Name,
                .Desc           = ItemNameTextBox.Text,
                .UPC            = ItemUPCTextBox.Text,
                .Action         = "Add New Product",
                .Remarques      = "",
                .BeforeValue    = "N/A",
                .AfterValue     = "New Item " & ItemNameTextBox.Text
            }
    End Function
#End Region
    
#Region "Barcode Scan Button"
    Private Sub ItemBarcodeButton_Click(sender As Object, e As EventArgs) Handles ItemBarcodeButton.Click
        Dim reponse As String = InputBox("Scan barcode")
        If reponse = "" Then Exit Sub
        Try
            Dim productInfo As INVENTORY_DTO = Assembler.GetProductByUPC(reponse)
            If not productInfo.UPC.Length = 0 Then Throw New Exception("This UPC code is already inside the inventory.")
            ItemUPCTextBox.Text = reponse
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub FrmInventoryAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then CancelButton_Click(Nothing, Nothing)
    End Sub
#End Region
End Class