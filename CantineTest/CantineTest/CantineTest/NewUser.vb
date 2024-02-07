Public Class NewUser
    Private ReadOnly User As New USER_ASSEMBLER_SQL

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
         Try
            ValidateForm()
            User.InsertUser(GenerateHashedPassword())
            MsgBox("User: " & UsernameTextBox.Text & " added!", MsgBoxStyle.Information, "Record Appended")
            Close()
            SyncManager(New ArrayList From {GetType(UsersInfo)})
        Catch ex As Exception
            If ex.Message.IndexOf("duplicate") > -1 Then
                DisplayErrorMessage("Username entered is already inside the database.")
            Else
                DisplayErrorMessage(ex.Message)
            End If
        End Try
    End Sub

    Private Sub ValidateForm()
        If PasswordTextBox.Text.Length = 0  Then Throw New Exception("Password cannot be empty.")
        If CashierCheckBox.Checked      = False AndAlso 
           InventoryCheckBox.Checked    = False AndAlso 
           StockTakingCheckBox.Checked  = False AndAlso 
           AdminCheckBox.Checked        = False Then Throw New Exception("New user must have at least one role.")
    End Sub

    Private Function GenerateHashedPassword() As USER_DTO
        Dim salt As String              = SecurityHelper.GenerateSalt(10)
        Dim HashedPassword As String    = SecurityHelper.HashPassword(PasswordTextBox.Text, salt, 10101, 70)

        Return NewUserRecord(salt, HashedPassword)
    End Function

    Private Function NewUserRecord(ByVal salt As String, ByVal HashedPassword As String) As USER_DTO 
          Return New USER_DTO With {
                .Active         = True,
                .Cashier        = CashierCheckBox.Checked,
                .Password       = HashedPassword,
                .Salt           = salt,
                .Inventory      = InventoryCheckBox.Checked,
                .StockTaking    = StockTakingCheckBox.Checked,
                .Username       = UsernameTextBox.Text,
                .Admin          = AdminCheckBox.Checked
            }
    End Function
#End Region

#Region "Cancel button"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineNewUser_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class