Imports System.ComponentModel

Public Class CashRegisterBuy
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ChangeDgdataCellStyle()
        ResizeDgdataColumns()
        ChangeDgdataImageLayout()
        SetDate()
    End Sub

#Region "Set date"
    Private Sub SetDate()
        DateLabel.Text = Now()
    End Sub
#End Region

#Region "Change dgdata image layout"
    Private Sub ChangeDgdataImageLayout()
        DataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub
#End Region

#Region "Change dgdata cell style"
    Private Sub ChangeDgdataCellStyle()
        dgData.DefaultCellStyle.WrapMode                        = DataGridViewTriState.True
        dgData.Columns("Prixunitaire").DefaultCellStyle.Format  = "c"
        dgData.Columns("Prixvente").DefaultCellStyle.Format     = "c"
    End Sub
#End Region

#Region "Resize dgdata columns"
    Private Sub ResizeDgdataColumns()
        dgData.Columns("Prixunitaire").AutoSizeMode             = DataGridViewAutoSizeColumnMode.None
        dgData.Columns("Prixunitaire").Width                    = 80
        dgData.Columns("Quantité").AutoSizeMode                 = DataGridViewAutoSizeColumnMode.None
        dgData.Columns("Quantité").Width                        = 80
    End Sub
#End Region

#Region "Make dgdata unselectable (ReadOnly)"
    Private Sub dgData_SelectionChanged(sender As Object, e As EventArgs) Handles dgData.SelectionChanged
        dgData.ClearSelection()
    End Sub
#End Region

#Region "Remove credit button when the form closes"
    Private Sub CashRegisterBuy_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If CashRegisterSell.Visible Then
            CashRegisterSell.Creditbtn.Enabled = False
        End If
    End Sub
#End Region
End Class