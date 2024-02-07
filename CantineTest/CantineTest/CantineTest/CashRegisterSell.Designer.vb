<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashRegisterSell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashRegisterSell))
        Me.ProductNameTextbox = New System.Windows.Forms.TextBox()
        Me.UPCTextbox = New System.Windows.Forms.TextBox()
        Me.ItemPriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ItemQTYNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SearchClientbutton = New System.Windows.Forms.Button()
        Me.Creditbtn = New System.Windows.Forms.Button()
        Me.EditCartbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Scanbtn = New System.Windows.Forms.Button()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemQTYNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'ProductNameTextbox
        '
        Me.ProductNameTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProductNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ProductNameTextbox.Location = New System.Drawing.Point(364, 12)
        Me.ProductNameTextbox.Name = "ProductNameTextbox"
        Me.ProductNameTextbox.Size = New System.Drawing.Size(256, 26)
        Me.ProductNameTextbox.TabIndex = 5
        '
        'UPCTextbox
        '
        Me.UPCTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UPCTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UPCTextbox.Location = New System.Drawing.Point(364, 82)
        Me.UPCTextbox.Name = "UPCTextbox"
        Me.UPCTextbox.Size = New System.Drawing.Size(256, 26)
        Me.UPCTextbox.TabIndex = 6
        '
        'ItemPriceNumericUpDown
        '
        Me.ItemPriceNumericUpDown.DecimalPlaces = 2
        Me.ItemPriceNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemPriceNumericUpDown.Location = New System.Drawing.Point(364, 153)
        Me.ItemPriceNumericUpDown.Name = "ItemPriceNumericUpDown"
        Me.ItemPriceNumericUpDown.Size = New System.Drawing.Size(106, 26)
        Me.ItemPriceNumericUpDown.TabIndex = 7
        '
        'ItemQTYNumericUpDown
        '
        Me.ItemQTYNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemQTYNumericUpDown.Location = New System.Drawing.Point(364, 225)
        Me.ItemQTYNumericUpDown.Name = "ItemQTYNumericUpDown"
        Me.ItemQTYNumericUpDown.Size = New System.Drawing.Size(106, 26)
        Me.ItemQTYNumericUpDown.TabIndex = 8
        Me.ItemQTYNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "UPC"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Qty"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TotalLabel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(136, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 151)
        Me.Panel1.TabIndex = 15
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = true
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(344, 60)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(82, 31)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "$0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TOTAL :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ProductNameTextbox)
        Me.Panel2.Controls.Add(Me.UPCTextbox)
        Me.Panel2.Controls.Add(Me.ItemPriceNumericUpDown)
        Me.Panel2.Controls.Add(Me.ItemQTYNumericUpDown)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(136, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 265)
        Me.Panel2.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(156, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Product Information"
        '
        'SearchClientbutton
        '
        Me.SearchClientbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchClientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchClientbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.SearchClientbutton.Image = Global.CantineTest.My.Resources.Resources.Icojam_Blue_Bits_User_search_96
        Me.SearchClientbutton.Location = New System.Drawing.Point(10, 12)
        Me.SearchClientbutton.Name = "SearchClientbutton"
        Me.SearchClientbutton.Size = New System.Drawing.Size(198, 141)
        Me.SearchClientbutton.TabIndex = 30
        Me.SearchClientbutton.Text = "Search Client"
        Me.SearchClientbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SearchClientbutton.UseVisualStyleBackColor = true
        '
        'Creditbtn
        '
        Me.Creditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Creditbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Creditbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Creditbtn.Image = Global.CantineTest.My.Resources.Resources.Double_J_Design_Ravenna_3d_Credit_Card_128
        Me.Creditbtn.Location = New System.Drawing.Point(708, 12)
        Me.Creditbtn.Name = "Creditbtn"
        Me.Creditbtn.Size = New System.Drawing.Size(198, 141)
        Me.Creditbtn.TabIndex = 4
        Me.Creditbtn.Text = "Pay Credit"
        Me.Creditbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Creditbtn.UseVisualStyleBackColor = true
        '
        'EditCartbtn
        '
        Me.EditCartbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditCartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditCartbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.EditCartbtn.Image = Global.CantineTest.My.Resources.Resources.Designcontest_Ecommerce_Business_Shopping_128
        Me.EditCartbtn.Location = New System.Drawing.Point(477, 12)
        Me.EditCartbtn.Name = "EditCartbtn"
        Me.EditCartbtn.Size = New System.Drawing.Size(198, 141)
        Me.EditCartbtn.TabIndex = 3
        Me.EditCartbtn.Text = "Edit cart"
        Me.EditCartbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditCartbtn.UseVisualStyleBackColor = true
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x482
        Me.Cancelbtn.Location = New System.Drawing.Point(644, 693)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(138, 108)
        Me.Cancelbtn.TabIndex = 18
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'Scanbtn
        '
        Me.Scanbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Scanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Scanbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Scanbtn.Image = Global.CantineTest.My.Resources.Resources.Double_J_Design_Diagram_Free_Barcode_128
        Me.Scanbtn.Location = New System.Drawing.Point(245, 12)
        Me.Scanbtn.Name = "Scanbtn"
        Me.Scanbtn.Size = New System.Drawing.Size(198, 141)
        Me.Scanbtn.TabIndex = 2
        Me.Scanbtn.Text = "Scan product"
        Me.Scanbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Scanbtn.UseVisualStyleBackColor = true
        '
        'Confirmbtn
        '
        Me.Confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbtn.Image = Global.CantineTest.My.Resources.Resources.Webiconset_Application_Invoice_64
        Me.Confirmbtn.Location = New System.Drawing.Point(136, 694)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(138, 108)
        Me.Confirmbtn.TabIndex = 17
        Me.Confirmbtn.Text = "Purchase"
        Me.Confirmbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Confirmbtn.UseVisualStyleBackColor = true
        '
        'CashRegisterSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 825)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.SearchClientbutton)
        Me.Controls.Add(Me.Creditbtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EditCartbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Scanbtn)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(934, 864)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(934, 864)
        Me.Name = "CashRegisterSell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Register"
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemQTYNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Scanbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents EditCartbtn As Button
    Friend WithEvents ProductNameTextbox As TextBox
    Friend WithEvents UPCTextbox As TextBox
    Friend WithEvents ItemPriceNumericUpDown As NumericUpDown
    Friend WithEvents ItemQTYNumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Creditbtn As Button
    Friend WithEvents SearchClientbutton As Button
    Friend WithEvents Confirmbtn As Button
End Class
