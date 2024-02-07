Public Class EditItem
    Private ReadOnly Assembler As New INVENTAIRE_ASSEMBLER_SQL
    Private ReadOnly History As New HISTORIQUE_ASSEMBLER_SQL

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Try
            CheckChanges()
            UpdateInventory()
            InsertImage()
            MsgBox("Record Updated", MsgBoxStyle.Information, "Item: " & NameLabel.Text & " updated!")
            Close()
            SyncManager(New ArrayList From {GetType(Cantine), GetType(ItemHistory), GetType(UserHistory)})
        Catch ex As Exception
            If ex.Message.IndexOf("duplicate") > -1 Then
                DisplayErrorMessage("Name and/or UPC code is already inside the inventory.")
            Else
                DisplayErrorMessage(ex.Message)
            End If
        End Try
    End Sub    

    Private Sub CheckChanges()
        Dim ProductInfo As INVENTORY_DTO = Assembler.GetProductByUPC(UPCLabel.Text)
        Dim destinationImagePath =  IMAGE_LOCATION & "\Resources\" & UPCLabel.Text & ".jpg"

        If Not ItemPriceNumericUpDown.Value = ProductInfo.Prixvente Then
            UpdateHistory(ProductInfo.Prixvente.ToString("c"), Convert.ToDecimal(ItemPriceNumericUpDown.Value).ToString("c"), INVENTORY_DTO.FIELD_Prixvente)
        End If

        If Not ItemMinNumericUpDown.Value = ProductInfo.Minimum Then
            UpdateHistory(ProductInfo.Minimum.ToString(), ItemMinNumericUpDown.Value.ToString(), INVENTORY_DTO.FIELD_Minimum)
        End If

        If Not ItemMaxNumericUpDown.Value = ProductInfo.Maximum Then
            UpdateHistory(ProductInfo.Maximum.ToString(), ItemMaxNumericUpDown.Value.ToString(), INVENTORY_DTO.FIELD_Maximum)
        End If

        If Not ActifCheckBox.Checked = ProductInfo.Actif Then
            UpdateHistory(ProductInfo.Actif.ToString(), ActifCheckBox.Checked.ToString(), INVENTORY_DTO.FIELD_Actif)
        End If

        If ProductPictureBox.ImageLocation = "" Then
            UpdateHistory("", "", "Product Image")
        End If
    End Sub

    Private Sub UpdateHistory(ByVal oldValue As String, ByVal newValue As String, ByVal field As String)
        Dim Historyeditrecord As New HISTORY_DTO With {
            .UPC                    = UPCLabel.Text,
            .Desc                   = NameLabel.Text,
            .User                   = My.User.Name,
            .Action                 = "Edit " & field,
            .Remarques              = "",
            .BeforeValue            = oldValue,
            .AfterValue             = newValue
        }
        History.InsertHistory(Historyeditrecord)
    End Sub

    Private Sub UpdateInventory()
        Dim UpdateItemRecord As New INVENTORY_DTO With {
            .UPC                    = UPCLabel.Text,
            .NOM                    = NameLabel.Text,
            .UOI                    = "EA",
            .Actif                  = ActifCheckBox.Checked,
            .Minimum                = ItemMinNumericUpDown.Value,
            .Maximum                = ItemMaxNumericUpDown.Value,
            .LastModifiedBy         = My.User.Name,
            .Prixvente              = ItemPriceNumericUpDown.Value
        }
        Assembler.UpdateInventory(UpdateItemRecord)
    End Sub

    Private Sub InsertImage()
        If ProductPictureBox.Image IsNot Nothing Then
            Dim destinationImagePath =  IMAGE_LOCATION & "\Resources\" & UPCLabel.Text & ".jpg"
            Dim productImageSize As New Size(150, 150)
            Dim imageSizeBitmap As New Bitmap(ProductPictureBox.Image, productImageSize)
            imageSizeBitmap.Save(destinationImagePath, Imaging.ImageFormat.Jpeg)
            imageSizeBitmap.Dispose()
        End If
    End Sub
#End Region

#Region "Cancel button"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
         Me.DialogResult = DialogResult.Cancel
         Me.Close()
    End Sub
#End Region

#Region "Product history button"
    Private Sub Historybtn_Click(sender As Object, e As EventArgs) Handles Historybtn.Click
        ItemHistory.ShowForm(UPCLabel.Text)
    End Sub
#End Region

#Region "Product Image button"
    Private Sub ProductImagebutton_Click(sender As Object, e As EventArgs) Handles ProductImagebutton.Click
        If ProductOpenFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = ProductOpenFileDialog.FileName
            ProductPictureBox.ImageLocation = imagePath
        End If
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub EditItemAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then CancelButton_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "ShowForm"
    Public Shared Sub ShowForm(Byval dgData As DataGridView)
        Dim f As New EditItem
        f.NameLabel.Text                    = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_NOM).Value
        f.ItemPriceNumericUpDown.Value      = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_Prixvente).Value
        f.UPCLabel.Text                     = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_UPC).Value
        f.ItemMinNumericUpDown.Value        = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_Minimum).Value
        f.ItemMaxNumericUpDown.Value        = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_Maximum).Value
        f.ActifCheckBox.Checked             = dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_Actif).Value
        Try
            Dim stream As New System.IO.FileStream( IMAGE_LOCATION & "\Resources\" & dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_UPC).Value & ".jpg", IO.FileMode.Open)
            Dim image As Image = image.FromStream(stream)
            f.ProductPictureBox.Image = image
            f.ProductPictureBox.ImageLocation = IMAGE_LOCATION & "\Resources\" & dgData.CurrentRow.Cells(INVENTORY_DTO.FIELD_UPC).Value & ".jpg"
            stream.Close()
            f.ShowDialog()
        Catch ex As Exception
            Dim stream As New System.IO.FileStream( IMAGE_LOCATION & "\Resources\" & IMAGE_TEMPLATE, IO.FileMode.Open)
            Dim image As Image = image.FromStream(stream)
            f.ProductPictureBox.Image = image 
            f.ProductPictureBox.ImageLocation =  IMAGE_LOCATION & "\Resources\" & IMAGE_TEMPLATE
            stream.Close()
            f.ShowDialog()
        End Try
    End Sub

    Private Sub Clipboardbutton_Click(sender As Object, e As EventArgs) Handles Clipboardbutton.Click
        If My.Computer.Clipboard.ContainsImage Then
            ProductPictureBox.Image = My.Computer.Clipboard.GetImage
            ProductPictureBox.ImageLocation = ""
        End If
    End Sub
#End Region
End Class