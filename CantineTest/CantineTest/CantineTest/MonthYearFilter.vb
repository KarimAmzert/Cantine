Public Class MonthYearFilter
    Private ReadOnly Facture      As New FACTURE_ASSEMBLER_SQL
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        YearComboBox.DataSource         = Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse.ToList()
        MonthComboBox.DataSource        = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        YearComboBox.SelectedItem       = DateTime.UtcNow.Year
        MonthComboBox.SelectedIndex     = DateTime.UtcNow.Month - 1
    End Sub

#Region "Filter button"
    Private Sub Filterbtn_Click(sender As Object, e As EventArgs) Handles Filterbtn.Click
        ShowFilter()
        Me.Close()
    End Sub

    Private Sub ShowFilter()
        Dim f                                           As New bestsellers

        f.dgData.DataSource                             = Facture.GetBestSellers((MonthComboBox.SelectedIndex + 1).ToString(), YearComboBox.SelectedItem)
        f.Text                                          = "Best Sellers " & MonthComboBox.SelectedItem & " " & YearComboBox.SelectedItem
        f.dgData.Columns("Qty_sold").HeaderText         = "Qty Sold"
        f.dgData.Columns("Qty_sold").AutoSizeMode       = DataGridViewAutoSizeColumnMode.None
        f.dgData.Columns("Qty_sold").Width              = 60
        f.dgData.Columns("ProductName").HeaderText     = "Product Name"
        f.dgData.Columns("Qty_sold").SortMode           = False

        f.Show()
    End Sub
#End Region

#Region "Cancel button"
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Close()
    End Sub
#End Region

#Region "Key shortcuts"
 Private Sub MonthYearFilter_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Cancelbtn_Click(Nothing, Nothing)
    End Sub
#End Region
End Class