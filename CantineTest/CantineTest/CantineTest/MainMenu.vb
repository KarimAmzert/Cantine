Public Class MainMenu
    Private ReadOnly User As New USER_ASSEMBLER_SQL

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "Checkout button"
    Private Sub Checkoutbtn_Click(sender As Object, e As EventArgs) Handles Checkoutbtn.Click
        If CashRegisterSell.Visible Then Exit Sub
        Try
            If Not My.User.IsInRole(USER_DTO.FIELD_Cashier) Then Throw New Exception("The current user does not have the permission needed to access this.")
            ShowCashRegisterBuy()
            ShowCashRegisterSell()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub ShowCashRegisterSell()
        CashRegisterSell.Creditbtn.Enabled = False
        CashRegisterSell.Show()
    End Sub

    Private Sub ShowCashRegisterBuy()
        CashRegisterBuy.NameLabel.Text              = "GUEST CLIENT GUEST"
        CashRegisterBuy.MatriculeLabel.Text         = "GUEST"
        CashRegisterBuy.MatriculeLabel.Visible      = False
        CashRegisterBuy.Show()
    End Sub
#End Region

#Region "Users button"
    Private Sub Usersbutton_Click(sender As Object, e As EventArgs) Handles Usersbtn.Click
        Try
            If Not My.User.IsInRole(USER_DTO.FIELD_Admin) Then Throw New Exception("The current user does not have the permission needed to access this.")
            Dim f As New UsersInfo
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "Inventory button"
    Private Sub Inventorybutton_Click(sender As Object, e As EventArgs) Handles Inventorybutton.Click
        Try
            Dim f As New Cantine
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "StockTaking button"
    Private Sub StockTakingbtn_Click(sender As Object, e As EventArgs) Handles StockTakingbtn.Click
        Try
            Dim f As New StocktakingMenu
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "Client button"
    Private Sub Clientbtn_Click(sender As Object, e As EventArgs) Handles Clientbtn.Click
        Dim f As New Clients
        Clients.Show()
    End Sub
#End Region

#Region "Close app button"
    Private Sub CloseAppbutton_Click(sender As Object, e As EventArgs) Handles CloseAppbutton.Click
        Application.Exit()
    End Sub
#End Region

#Region "Main menu form closing event"
    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim reponse = MsgBox("Close the application?", vbYesNo + vbExclamation, "Close Application")
        If reponse = MsgBoxResult.Yes Then
            RemoveHandler Me.FormClosing, AddressOf MainMenu_FormClosing
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Caissebtn_Click(sender As Object, e As EventArgs) Handles Caissebtn.Click
        Try
            If Not My.User.IsInRole(USER_DTO.FIELD_Cashier) Then Throw New Exception("The current user does not have the permission needed to access this.")
            Dim f As New Caisse
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region
End Class