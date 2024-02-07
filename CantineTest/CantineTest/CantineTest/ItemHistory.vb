Public Class ItemHistory
    Implements IFormDatagridview
    Private ReadOnly History As New HISTORIQUE_ASSEMBLER_SQL

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshGrid()
        ChangeDgdataColumnHeaderText()
        ResizeDgdataColumns()
    End Sub

#Region "Change dgdata column header text"
    Private Sub ChangeDgdataColumnHeaderText()
        dgData.Columns(HISTORY_DTO.FIELD_Desc).HeaderText               = "Product Name"
        dgData.Columns(HISTORY_DTO.FIELD_Remarques).HeaderText          = "Adjustment Reason"
    End Sub
#End Region

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns(HISTORY_DTO.FIELD_BeforeValue).AutoSizeMode      = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(HISTORY_DTO.FIELD_BeforeValue).Width             = 80
        dgData.Columns(HISTORY_DTO.FIELD_AfterValue).AutoSizeMode       = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(HISTORY_DTO.FIELD_AfterValue).Width              = 80
    End Sub
#End Region

#Region "RefreshGrid"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
        dgData.DataSource                  = History.GetItemHistorique(Me.Text.Split(" ")(0))
        RecordsToolStripMenuItem.Text      = dgData.Rows.GetRowCount(0).ToString() & " Records"
    End Sub
#End Region

#Region "Key shortcuts"
 Private Sub CantineAdd_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
#End Region

#Region "ShowForm"
    Public Shared Sub ShowForm(Byval upc As String)
        Try
            Dim HistoryAssembler                As New HISTORIQUE_ASSEMBLER_SQL
            Dim ProductHistoryInfo              As DataTable = HistoryAssembler.GetItemHistorique(upc)
            Dim f                               As New ItemHistory

            f.dgData.DataSource                 = ProductHistoryInfo
            f.Text                              = upc & " History"
            f.RecordsToolStripMenuItem.Text     = f.dgData.Rows.GetRowCount(0).ToString() & " Records"
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region

#Region "ShowForm"
    Public Shared Sub ShowUserForm(Byval username As String)
        Try
            Dim HistoryAssembler                As New HISTORIQUE_ASSEMBLER_SQL
            Dim UserHistoryInfo                 As DataTable = HistoryAssembler.GetUserItemHistorique(username)
            Dim f                               As New ItemHistory

            f.dgData.DataSource                 = UserHistoryInfo
            f.Text                              = username & " History"
            f.RecordsToolStripMenuItem.Text     = f.dgData.Rows.GetRowCount(0).ToString() & " Records"
            f.Show()
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub
#End Region
End Class