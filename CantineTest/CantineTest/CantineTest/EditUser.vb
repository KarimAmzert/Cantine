Public Class EditUser
    Private ReadOnly User       As New USER_ASSEMBLER_SQL
    Private ReadOnly History    As New HISTORIQUE_ASSEMBLER_SQL

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Try
            ValidateForm()
            User.UpdateUser(UserRecord())
            MsgBox("User: " & UsernameLabel.Text & " updated!", MsgBoxStyle.Information, "Record Updated")
            Close()
            SyncManager(New ArrayList From {GetType(UsersInfo)})
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Function UserRecord() As USER_DTO
        Return New USER_DTO With {
            .Username       = UsernameLabel.Text,
            .Active         = ActiveCheckBox.Checked,
            .Cashier        = CashierCheckBox.Checked,
            .Inventory      = InventoryCheckBox.Checked,
            .StockTaking    = StockTakingCheckBox.Checked,
            .Admin          = AdminCheckBox.Checked
        }
    End Function

    Private Sub ValidateForm()
        If CashierCheckBox.Checked      = False AndAlso 
           InventoryCheckBox.Checked    = False AndAlso 
           StockTakingCheckBox.Checked  = False AndAlso 
           AdminCheckBox.Checked        = False Then Throw New Exception("New user must have at least one role.")
    End Sub
#End Region

#Region "Cancel button"
    Private Sub Cancelbutton_Click(sender As Object, e As EventArgs) Handles Cancelbutton.Click
        Close()
    End Sub
#End Region

#Region "Password button"
    Private Sub Passwordbutton_Click(sender As Object, e As EventArgs) Handles Passwordbutton.Click
        Dim reponse As New Password
        reponse.ShowDialog()
        If reponse.DialogResult = DialogResult.Yes Then
        Try
            Dim NewPassword             = GenerateResetPassword()
            Dim generateHashPassword    = generatedHashPassword(NewPassword)
            Dim passwordRecord          = ResetPasswordRecord(generateHashPassword)
            User.ResetUserPassword(passwordRecord, True)

            MsgBox("New Password: " & NewPassword, MsgBoxStyle.Information, "User: " & UsernameLabel.Text & " New Password.")
            My.Computer.Clipboard.SetText(NewPassword)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
        End If
    End Sub

    Private Function generatedHashPassword(ByVal NewPassword As String) As String
        Dim userInfo As USER_DTO    = User.GetUserByName(UsernameLabel.Text)
        Dim generatePassword        = SecurityHelper.HashPassword(NewPassword, userInfo.Salt, 10101, 70)
        Return generatePassword
    End Function

    Private Function ResetPasswordRecord(ByVal generatedPassword As String) As USER_DTO
        Return New USER_DTO With {
                .Username = UsernameLabel.Text,
                .Password = generatedPassword
               }
    End Function

    Private Function GenerateResetPassword()
        Dim random          As New Random()
        Dim length          As Integer = 10
        Dim randomString    As String = ""

        For i As Integer = 1 To length
            randomString &= ChrW(random.Next(97, 123))
        Next

        Return randomString
    End Function
#End Region

#Region "Show Form"
    Public Sub showForm(byval row As DataGridViewRow)
        Dim f As New EditUser
        f.UsernameLabel.Text            = row.Cells(USER_DTO.FIELD_Username).Value
        f.ActiveCheckBox.Checked        = row.Cells(USER_DTO.FIELD_Active).Value
        f.CashierCheckBox.Checked       = row.Cells(USER_DTO.FIELD_Cashier).Value
        f.InventoryCheckBox.Checked     = row.Cells(USER_DTO.FIELD_Inventory).Value
        f.StockTakingCheckBox.Checked   = row.Cells(USER_DTO.FIELD_StockTaking).Value
        f.AdminCheckBox.Checked         = row.Cells(USER_DTO.FIELD_Admin).Value

        f.ShowDialog()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineNewUser_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region

#Region "User History button"
    Private Sub Historybutton_Click(sender As Object, e As EventArgs) Handles Historybutton.Click
        Dim f As New UserHistory(UsernameLabel.Text)
        f.Show()
    End Sub
#End Region
End Class