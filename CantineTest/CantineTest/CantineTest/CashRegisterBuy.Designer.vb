<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashRegisterBuy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashRegisterBuy))
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prixunitaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prixvente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.MatriculeLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = false
        Me.dgData.AllowUserToDeleteRows = false
        Me.dgData.AllowUserToResizeColumns = false
        Me.dgData.AllowUserToResizeRows = false
        Me.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgData.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.UPC, Me.Quantité, Me.Prixunitaire, Me.Prixvente, Me.SaleReason, Me.Image})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgData.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgData.Location = New System.Drawing.Point(-1, -1)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = true
        Me.dgData.RowHeadersVisible = false
        Me.dgData.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgData.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgData.Size = New System.Drawing.Size(1347, 793)
        Me.dgData.TabIndex = 0
        '
        'Nom
        '
        Me.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nom.HeaderText = "Product Name"
        Me.Nom.MinimumWidth = 6
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = true
        '
        'UPC
        '
        Me.UPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UPC.HeaderText = "UPC"
        Me.UPC.MinimumWidth = 6
        Me.UPC.Name = "UPC"
        Me.UPC.ReadOnly = true
        '
        'Quantité
        '
        Me.Quantité.HeaderText = "Qty"
        Me.Quantité.MinimumWidth = 6
        Me.Quantité.Name = "Quantité"
        Me.Quantité.ReadOnly = true
        '
        'Prixunitaire
        '
        Me.Prixunitaire.HeaderText = "Unit Price"
        Me.Prixunitaire.MinimumWidth = 6
        Me.Prixunitaire.Name = "Prixunitaire"
        Me.Prixunitaire.ReadOnly = true
        '
        'Prixvente
        '
        Me.Prixvente.HeaderText = "Sub Total"
        Me.Prixvente.MinimumWidth = 6
        Me.Prixvente.Name = "Prixvente"
        Me.Prixvente.ReadOnly = true
        '
        'SaleReason
        '
        Me.SaleReason.HeaderText = "Sale Reason"
        Me.SaleReason.MinimumWidth = 6
        Me.SaleReason.Name = "SaleReason"
        Me.SaleReason.ReadOnly = true
        '
        'Image
        '
        Me.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Image.HeaderText = ""
        Me.Image.MinimumWidth = 6
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(1261, 893)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TOTAL:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = true
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(1349, 893)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(71, 29)
        Me.TotalLabel.TabIndex = 2
        Me.TotalLabel.Text = "$0.00"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = true
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DateLabel.Location = New System.Drawing.Point(49, 67)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(63, 29)
        Me.DateLabel.TabIndex = 3
        Me.DateLabel.Text = "Date"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = true
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NameLabel.Location = New System.Drawing.Point(49, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(146, 29)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Client Name"
        '
        'MatriculeLabel
        '
        Me.MatriculeLabel.AutoSize = true
        Me.MatriculeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MatriculeLabel.Location = New System.Drawing.Point(49, 9)
        Me.MatriculeLabel.Name = "MatriculeLabel"
        Me.MatriculeLabel.Size = New System.Drawing.Size(111, 29)
        Me.MatriculeLabel.TabIndex = 5
        Me.MatriculeLabel.Text = "Matricule"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgData)
        Me.Panel1.Location = New System.Drawing.Point(55, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 793)
        Me.Panel1.TabIndex = 6
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.CantineTest.My.Resources.Resources.Iconarchive_Wild_Camping_Water_Bottle_512
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = true
        '
        'CashRegisterBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 951)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MatriculeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(1472, 998)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(1472, 998)
        Me.Name = "CashRegisterBuy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cart"
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents MatriculeLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents UPC As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prixunitaire As DataGridViewTextBoxColumn
    Friend WithEvents Prixvente As DataGridViewTextBoxColumn
    Friend WithEvents SaleReason As DataGridViewTextBoxColumn
    Friend WithEvents Image As DataGridViewImageColumn
End Class
