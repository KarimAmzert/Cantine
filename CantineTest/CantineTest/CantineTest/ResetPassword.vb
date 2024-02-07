Imports System.Text.RegularExpressions

Public Class ResetPassword
    Private ReadOnly User As New USER_ASSEMBLER_SQL
    Dim regexUpperCase As String = ("[A-Z]")
    Dim regexNumber As String = (".*\d.*")
    Dim regexSpecial As String = (".*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-].*")
    Dim regexLength As String = ("^.{10,}$")
    Dim regexTotal As String = ("^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]).{10,}$")
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        CheckRegEx(regexUpperCase, "Password must contain at least one upper case letter", UppercaseLabel)
        CheckRegEx(regexNumber, "Password must contain at least one number", NumberLabel)
        CheckRegEx(regexSpecial, "Password must contain at least one special character", SpecialLabel)
        CheckRegEx(regexLength, "Password must be at least 10 characters long", LengthLabel)
    End Sub

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Try
            If Not Regex.IsMatch(NewPasswordTextBox.Text, regexTotal) Or Not ConfirmPasswordTextBox.Text.Equals(NewPasswordTextBox.Text) Then Throw New Exception("Invalid password or/and passwords do not match.")
            Dim userInfo As USER_DTO = User.GetUserByName(CantineLogin.UsernameTextBox.Text)
            Dim UserRecord As New USER_DTO With {
                .Username = CantineLogin.UsernameTextBox.Text,
                .Password = SecurityHelper.HashPassword(NewPasswordTextBox.Text, userInfo.Salt, 10101, 70)
            }

            User.ResetUserPassword(UserRecord, False)
            Me.DialogResult = DialogResult.Yes
            MsgBox("Your password has been reset.", MsgBoxStyle.Information, "Record Updated")
            Close()
            CantineLogin.Show()
            CantineLogin.PasswordTextBox.Text = ""
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub


    Private Sub NewPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles NewPasswordTextBox.TextChanged
        CheckRegEx(regexUpperCase, "Password must contain at least one upper case letter", UppercaseLabel)
        CheckRegEx(regexNumber, "Password must contain at least one number", NumberLabel)
        CheckRegEx(regexSpecial, "Password must contain at least one special character", SpecialLabel)
        CheckRegEx(regexLength, "Password must be at least 10 characters long", LengthLabel)
    End Sub

    Private Sub CheckRegEx(ByVal regExStr As String, ByVal labelText As String, ByVal label As Label)
        If Regex.IsMatch(NewPasswordTextBox.Text, regExStr) Then
            label.ForeColor = Color.Green
            label.Text = "✅ " & labelText
            Else
            label.ForeColor = Color.Red
            label.Text = "❌ " & labelText
        End If
    End Sub
    
    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged, NewPasswordTextBox.TextChanged
        If ConfirmPasswordTextBox.Text.Equals(NewPasswordTextBox.Text) Then
            ConfirmLabel.ForeColor = Color.Green
            ConfirmLabel.Text = "✅ Passwords must match"
            Else
            ConfirmLabel.ForeColor = Color.Red
            ConfirmLabel.Text = "❌ Passwords must match"
        End If
    End Sub
#End Region

#Region "Cancel button"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = DialogResult.No
        Close()
    End Sub
#End Region

    Private Sub ResetPassword_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Me.DialogResult = DialogResult.No
    End Sub
End Class