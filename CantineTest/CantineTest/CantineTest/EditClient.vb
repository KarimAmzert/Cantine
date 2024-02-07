Public Class EditClient
    Private ReadOnly Client As New CLIENT_ASSEMBLER_SQL

#Region "Cancel button"
    Private Sub Cancelbutton_Click(sender As Object, e As EventArgs) Handles Cancelbutton.Click
        Close()
    End Sub
#End Region

#Region "Confirm button"
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
         Try
            ValidateForm()
            Client.UpdateClient(NewClientRecord())
            MsgBox("Client: " & FirstNameTextBox.Text & " " & LastNameTextBox.Text & " updated!", MsgBoxStyle.Information, "Record Updated")
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
        If FirstNameTextBox.Text.Length = 0     Then Throw New Exception("First Name cannot be empty.")
        If LastNameTextbox.Text.Length = 0      Then Throw New Exception("Last Name cannot be empty.")
        If RankListComboBox.SelectedIndex = -1  Then Throw New Exception("Rank cannot be empty.")
    End Sub

    Private Function NewClientRecord() As CLIENT_DTO 
          Return New CLIENT_DTO With {
            .Client_FirstName   = FirstNameTextBox.Text,
            .Nom                = LastNameTextBox.Text,
            .Credit             = 0.00,
            .Matricule          = MatriculeLabel.Text,
            .Rank               = RankListComboBox.SelectedItem
            }
    End Function
#End Region

#Region "Show Form"
    Public Sub showForm(byval row As DataGridViewRow)
        Dim f As New EditClient
        f.MatriculeLabel.Text               = row.Cells(CLIENT_DTO.FIELD_Matricule).Value
        f.FirstNameTextBox.Text             = row.Cells(CLIENT_DTO.FIELD_Client_FirstName).Value
        f.LastNameTextBox.Text              = row.Cells(CLIENT_DTO.FIELD_Nom).Value
        f.RankListComboBox.SelectedItem     = row.Cells(CLIENT_DTO.FIELD_Rank).Value

        f.ShowDialog()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineNewUser_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub Historybutton_Click(sender As Object, e As EventArgs) Handles Creditbutton.Click
        Dim clientInfo As CLIENT_DTO = Client.getClientByMatricule(MatriculeLabel.Text)(0)
        IndividualClient.ShowForm(clientInfo)
    End Sub
#End Region
End Class