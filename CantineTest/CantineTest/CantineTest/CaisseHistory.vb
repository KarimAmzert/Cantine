Public Class CaisseHistory
    Implements IFormDatagridview
    Private ReadOnly Caisse As New CAISSE_ASSEMBLER_SQL

    Public Sub New()
        
        ' This call is required by the designer.
        InitializeComponent()
        RefreshGrid()

        ChangeDgdataCellStyleToCurrency()
        ChangeDgdataColumnHeaderText()
        ResizeDgdataColumns()
    End Sub

#Region "Change dgdata cellstyle to currency"
    Private Sub ChangeDgdataCellStyleToCurrency()
        dgData.Columns(CAISSE_DTO.FIELD_AMOUNT).DefaultCellStyle.Format             = "c"
        dgData.Columns(CAISSE_DTO.FIELD_BEFORE_VALUE).DefaultCellStyle.Format       = "c"
        dgData.Columns(CAISSE_DTO.FIELD_AFTER_VALUE).DefaultCellStyle.Format        = "c"
    End Sub
#End Region

#Region "Change dgdata column header text"
    Private Sub ChangeDgdataColumnHeaderText()
        dgData.Columns(CAISSE_DTO.FIELD_DESC).HeaderText = "Adjustment Reason"
    End Sub
#End Region

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns(CAISSE_DTO.FIELD_ID).AutoSizeMode                            = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CAISSE_DTO.FIELD_ID).Width                                   = 60

        dgData.Columns(CAISSE_DTO.FIELD_BEFORE_VALUE).AutoSizeMode                  = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CAISSE_DTO.FIELD_BEFORE_VALUE).Width                         = 80

        dgData.Columns(CAISSE_DTO.FIELD_AFTER_VALUE).AutoSizeMode                   = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CAISSE_DTO.FIELD_AFTER_VALUE).Width                          = 80

        dgData.Columns(CAISSE_DTO.FIELD_AMOUNT).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        dgData.Columns(CAISSE_DTO.FIELD_AMOUNT).Width                               = 80
    End Sub
#End Region

#Region "RefreshGrid"
    Public Sub RefreshGrid() Implements IFormDatagridview.RefreshGrid
       dgData.DataSource = Caisse.GetHistory()
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