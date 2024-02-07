Public Class NewClient
    Private ReadOnly Client As New CLIENT_ASSEMBLER_SQL

#Region "Cancel button"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub
#End Region

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
         Try
            ValidateForm()
            Client.InsertClient(NewClientRecord())
            MsgBox("Client: " & FirstNameTextBox.Text & " " & LastNameTextBox.Text & " added!", MsgBoxStyle.Information, "Record Appended")
            Close()
            SyncManager(New ArrayList From {GetType(Clients)})
        Catch ex As Exception
            If ex.Message.IndexOf("duplicate") > -1 Then
                DisplayErrorMessage("Matricule entered is already inside the database.")
            Else
                DisplayErrorMessage(ex.Message)
            End If
        End Try
    End Sub

    Private Sub ValidateForm()
        If MatriculeTextBox.Text.Length = 0     Then Throw New Exception("Matricule cannot be empty.")
        If FirstNameTextBox.Text.Length = 0     Then Throw New Exception("First Name cannot be empty.")
        If LastNameTextbox.Text.Length = 0      Then Throw New Exception("Last Name cannot be empty.")
        If RankListComboBox.SelectedIndex = -1  Then Throw New Exception("Rank cannot be empty.")
    End Sub

    Private Function NewClientRecord() As CLIENT_DTO 
          Return New CLIENT_DTO With {
            .Client_FirstName   = FirstNameTextBox.Text,
            .Nom                = LastNameTextBox.Text,
            .Credit             = 0.00,
            .Matricule          = MatriculeTextBox.Text,
            .Rank               = RankListComboBox.SelectedItem
            }
    End Function
#End Region

#Region "Key shortcuts"
    Private Sub CantineNewUser_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class