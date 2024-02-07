Public Class Caisse
    Private Sub Adjustbtn_Click(sender As Object, e As EventArgs) Handles Adjustbtn.Click
        Dim f As New AdjustRegister
        f.Show()
    End Sub

    Private Sub Transactionsbtn_Click(sender As Object, e As EventArgs) Handles Transactionsbtn.Click
        Dim f As New Transactions
        f.Show()
    End Sub

    Private Sub Historybtn_Click(sender As Object, e As EventArgs) Handles Historybtn.Click
        Dim f As New CaisseHistory
        f.Show()
    End Sub

#Region "Key shortcuts"
    Private Sub Caisse_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class