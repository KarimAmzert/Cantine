Public Class CantineLogin
    Private ReadOnly User As New USER_ASSEMBLER_SQL

#Region "Confirm button"
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        Try
            Dim userInfo As USER_DTO = User.GetUserByName(UsernameTextBox.Text)
            ValidateForm(userInfo)

            If userInfo.ResetPassword Then
                Me.Hide()
                MsgBox("Your password needs to be reset.", MsgBoxStyle.Information, "Reset Password")
                Dim fr As New ResetPassword
                fr.ShowDialog()
                If fr.DialogResult = DialogResult.No OrElse fr.DialogResult = DialogResult.Yes Then
                    Me.Show()
                    Exit Sub
                End If
            End If
            CustomPrincipal(userInfo)
            ShowMainMenu()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            PasswordTextBox.Text = ""
        End Try
    End Sub

    Private Sub ShowMainMenu()
        Dim f As New MainMenu
        f.Show()
        Me.Hide()
    End Sub

    Private Sub CustomPrincipal(ByVal userInfo As USER_DTO)
        Dim customPrincipal As New CustomPrincipal(userInfo.Username)
        My.User.CurrentPrincipal = customPrincipal
    End Sub

    Private Sub ValidateForm(ByVal userInfo As USER_DTO)
        If UsernameTextBox.Text = ""    Then Throw New Exception("No username entered.")
        If PasswordTextBox.Text = ""    Then Throw New Exception("No password entered.")
        If userInfo.Salt.Length = 0     Then Throw New Exception("Account does not exist.")
        Dim checkPassword As Boolean = SecurityHelper.CheckPassword(PasswordTextBox.Text, userInfo.Password, userInfo.Salt)
        If Not checkPassword            Then Throw New Exception("Login error. Make sure you have entered your username and password correctly.")
        If Not userInfo.Active          Then Throw New Exception("This User account is no longer active.")
    End Sub
#End Region

#Region "Login load"
    Private Sub CantineLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = Environment.UserName
    End Sub
#End Region

#Region "Forgot Password"
    Private Sub ForgotPasswordLabel_Click(sender As Object, e As EventArgs) Handles ForgotPasswordLabel.Click
        Process.Start("mailto:KarimAmzert@hotmail.com?subject=Mot de passe oublié")
    End Sub
#End Region
End Class
