Public Class FrmScrrenSize
   Private ReadOnly Assembler    As New INVENTAIRE_ASSEMBLER

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
         FontDialog1.ShowDialog()
        Try
            Dim SettingsFont As New Font(FontDialog1.Font.FontFamily, FontDialog1.Font.Size, fontdialog1.Font.Style)

            For each form In Application.OpenForms
                form.Font = SettingsFont

                For each c As Control In form.Controls
                    If (TypeOf c Is Button) Then
                        c.Font = SettingsFont
                    End If
                    c.Font = SettingsFont
                Next
            Next

        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
        End Try
    End Sub

    Private Sub FrmScrrenSize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource                                                           = Assembler.GetInventory()

        DataGridView1.Columns(INVENTORY_DTO.FIELD_Prixvente).DefaultCellStyle.Format       = "c"
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Prixvente).HeaderText                    = "Unit Price"
        DataGridView1.Columns(INVENTORY_DTO.FIELD_NOM).HeaderText                          = "Product Name"
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Actif).HeaderText                        = "Active"
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Quantite).HeaderText                     = "Qty"

        DataGridView1.Columns(INVENTORY_DTO.FIELD_Actif).AutoSizeMode                      = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Actif).Width                             = 60

        DataGridView1.Columns(INVENTORY_DTO.FIELD_Quantite).AutoSizeMode                   = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Quantite).Width                          = 60

        DataGridView1.Columns(INVENTORY_DTO.FIELD_Prixvente).AutoSizeMode                  = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Prixvente).Width                         = 60

        DataGridView1.Columns(INVENTORY_DTO.FIELD_Minimum).AutoSizeMode                    = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Minimum).Width                           = 60

        DataGridView1.Columns(INVENTORY_DTO.FIELD_Maximum).AutoSizeMode                    = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_Maximum).Width                           = 60

        DataGridView1.Columns(INVENTORY_DTO.FIELD_UOI).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_UOI).Width                               = 60

        DataGridView1.Columns(INVENTORY_DTO.FIELD_UPC).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_UPC).Width                               = 150

        DataGridView1.Columns(INVENTORY_DTO.FIELD_NOM).AutoSizeMode                        = DataGridViewAutoSizeColumnMode.None
        DataGridView1.Columns(INVENTORY_DTO.FIELD_NOM).Width                               = 500

        DataGridView1.Columns(INVENTORY_DTO.FIELD_ID).Visible                              = False
    End Sub
End Class