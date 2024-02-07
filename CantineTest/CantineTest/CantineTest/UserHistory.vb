Public Class UserHistory
    Implements IFormDatagridview
    Private ReadOnly History As New HISTORIQUE_ASSEMBLER_SQL

    Public Sub New(Byval Username As String)
        
        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = Username
        RefreshGrid()
    End Sub

#Region "RefreshGrid"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
       dgData.DataSource = History.GetUserItemHistorique(Me.Text)
    End Sub
#End Region

#Region "Refresh button"
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        RefreshGrid()
    End Sub
#End Region

#Region "Key shortcuts"
    Private Sub CantineNewUser_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region
End Class