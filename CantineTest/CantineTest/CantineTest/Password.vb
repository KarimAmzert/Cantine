
Public Class Password
    Private ReadOnly User As New USER_ASSEMBLER_SQL

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Try
            CheckPassword()
            Me.DialogResult = DialogResult.Yes
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            PasswordTextBox.Text = ""
        End Try
    End Sub

    Private Sub CheckPassword()
        Dim userInfo As USER_DTO = User.GetUserByName(My.User.Name)
        If Not SecurityHelper.CheckPassword(PasswordTextBox.Text, userInfo.Password, userInfo.Salt) Then Throw New Exception("Password is invalid.")
    End Sub
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