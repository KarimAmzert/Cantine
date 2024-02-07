Public Class UsersInfo
    Implements IFormDatagridview

    Private ReadOnly User         As New USER_ASSEMBLER_SQL
    ReadOnly bsData               As New BindingSource

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()
        ResizeDgdataColumns()
    End Sub

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns(USER_DTO.FIELD_Active).AutoSizeMode          = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(USER_DTO.FIELD_Active).Width                 = 150

        dgData.Columns(USER_DTO.FIELD_Cashier).AutoSizeMode         = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(USER_DTO.FIELD_Cashier).Width                = 150

        dgData.Columns(USER_DTO.FIELD_StockTaking).AutoSizeMode     = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(USER_DTO.FIELD_StockTaking).Width            = 150

        dgData.Columns(USER_DTO.FIELD_Inventory).AutoSizeMode       = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(USER_DTO.FIELD_Inventory).Width              = 150

        dgData.Columns(USER_DTO.FIELD_ID).AutoSizeMode              = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(USER_DTO.FIELD_ID).Width                     = 150

        dgData.Columns(USER_DTO.FIELD_Admin).AutoSizeMode           = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(USER_DTO.FIELD_Admin).Width                  = 150
    End Sub
#End Region

#Region "Refresh dgData"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
        dgData.DataSource       = User.GetAllUsers()
        RecordCountLabel.Text   = dgData.Rows.GetRowCount(0).ToString() & " Records"
        bsData.DataSource       = dgData.DataSource
    End Sub
#End Region

#Region "Refresh button"
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click 
        RefreshGrid()
    End Sub
#End Region

#Region "New user button"
    Private Sub NewUserbutton_Click(sender As Object, e As EventArgs) Handles NewUserbutton.Click 
        Dim f As New NewUser
        f.Show()
    End Sub
#End Region

#Region "Edit user button"
    Private Sub EditUserbutton_Click(sender As Object, e As EventArgs) Handles EditUserbutton.Click 
        Dim reponse As New Password
        reponse.ShowDialog()
        If reponse.DialogResult = DialogResult.Yes Then
            EditUser.showForm(dgData.CurrentRow)
        End If
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

                MsgBox("New Password: " & NewPassword, MsgBoxStyle.Information, "User: " & dgData.CurrentRow.Cells(USER_DTO.FIELD_Username).Value & " New Password.")
                My.Computer.Clipboard.SetText(NewPassword)
            Catch ex As Exception
                DisplayErrorMessage(ex.Message)
            End Try
        End If
    End Sub

    Private Function generatedHashPassword(ByVal NewPassword As String) As String
        Dim userInfo As USER_DTO    = User.GetUserByName(dgData.CurrentRow.Cells(USER_DTO.FIELD_Username).Value)
        Dim generatePassword        = SecurityHelper.HashPassword(NewPassword, userInfo.Salt, 10101, 70)
        Return generatePassword
    End Function

    Private Function ResetPasswordRecord(ByVal generatedPassword As String) As USER_DTO
        Return New USER_DTO With {
                .Username = dgData.CurrentRow.Cells(USER_DTO.FIELD_Username).Value,
                .Password = generatedPassword
               }
    End Function

    Private Function GenerateResetPassword() As String
        Dim random          As New Random()
        Dim length          As Integer = 10
        Dim randomString    As String = ""

        For i As Integer = 1 To length
            randomString &= ChrW(random.Next(97, 123))
        Next

        Return randomString
    End Function
#End Region

#Region "datagridview cell click"
    Private Sub dgData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellDoubleClick 
        If e.RowIndex <= 0 AndAlso e.ColumnIndex <= 0 Then Exit Sub
        Dim reponse As New Password
        reponse.ShowDialog()

        If reponse.DialogResult = DialogResult.Yes Then
            EditUser.showForm(dgData.CurrentRow)
        End If
    End Sub
#End Region

#Region "SearchBar"
    Private Sub NameFilterSearch_TextChanged(sender As Object, e As EventArgs) Handles NameFilterSearch.TextChanged 
        If NameFilterSearch.Text = "SEARCH BY USERNAME" Then
            SearchPictureBox.ImageLocation = IMAGE_LOCATION & "\Resources\Gakuseisean-Ivista-2-Start-Menu-Search.24.png"
            Exit Sub
        End If
        bsData.Filter                       = String.Format( USER_DTO.FIELD_Username & " Like '%{0}%' ", NameFilterSearch.Text)
        RecordCountLabel.Text               = dgData.Rows.GetRowCount(0).ToString() & " Records"
        SearchPictureBox.ImageLocation      =  IMAGE_LOCATION & "\Resources\Oxygen-Icons.org-Oxygen-Actions-application-exit.24.png"
    End Sub

    Private Sub NameFilterSearch_GotFocus(sender As Object, e As EventArgs) Handles NameFilterSearch.GotFocus
        If NameFilterSearch.Text = "SEARCH BY USERNAME" Then
            NameFilterSearch.Text = ""
        End If
    End Sub

    Private Sub NameFilterSearch_LostFocus(sender As Object, e As EventArgs) Handles NameFilterSearch.LostFocus
        If String.IsNullOrEmpty(NameFilterSearch.Text) Then
            NameFilterSearch.Text = "SEARCH BY USERNAME"
        End If
    End Sub
#End Region

#Region "Searchbar picturebox change"
    Private Sub SearchPictureBox_Click(sender As Object, e As EventArgs) Handles SearchPictureBox.Click
        If SearchPictureBox.ImageLocation =  IMAGE_LOCATION & "\Resources\Oxygen-Icons.org-Oxygen-Actions-application-exit.24.png" Then
           NameFilterSearch.Text = ""
        End If
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub EditItemAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
        If e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control Then NameFilterSearch.Focus()
    End Sub
#End Region
End Class