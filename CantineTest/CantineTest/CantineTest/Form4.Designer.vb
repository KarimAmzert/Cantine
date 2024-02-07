<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditItem))
        Me.ItemPriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ItemMinNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ItemMaxNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ActifCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UPCLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Clipboardbutton = New System.Windows.Forms.Button()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductImagebutton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.Historybtn = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ProductOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemMinNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemMaxNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.ProductPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ItemPriceNumericUpDown
        '
        Me.ItemPriceNumericUpDown.DecimalPlaces = 2
        Me.ItemPriceNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemPriceNumericUpDown.Location = New System.Drawing.Point(497, 93)
        Me.ItemPriceNumericUpDown.Name = "ItemPriceNumericUpDown"
        Me.ItemPriceNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemPriceNumericUpDown.TabIndex = 5
        '
        'ItemMinNumericUpDown
        '
        Me.ItemMinNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemMinNumericUpDown.Location = New System.Drawing.Point(497, 189)
        Me.ItemMinNumericUpDown.Name = "ItemMinNumericUpDown"
        Me.ItemMinNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemMinNumericUpDown.TabIndex = 11
        '
        'ItemMaxNumericUpDown
        '
        Me.ItemMaxNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemMaxNumericUpDown.Location = New System.Drawing.Point(497, 240)
        Me.ItemMaxNumericUpDown.Name = "ItemMaxNumericUpDown"
        Me.ItemMaxNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemMaxNumericUpDown.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "UPC"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Minimum"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Maximum"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(164, 534)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Designcontest_Ecommerce_Business_Edit_128
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = false
        '
        'ActifCheckBox
        '
        Me.ActifCheckBox.AutoSize = true
        Me.ActifCheckBox.Location = New System.Drawing.Point(497, 287)
        Me.ActifCheckBox.Name = "ActifCheckBox"
        Me.ActifCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActifCheckBox.TabIndex = 22
        Me.ActifCheckBox.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Active"
        '
        'UPCLabel
        '
        Me.UPCLabel.AutoSize = true
        Me.UPCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UPCLabel.Location = New System.Drawing.Point(297, 108)
        Me.UPCLabel.Name = "UPCLabel"
        Me.UPCLabel.Size = New System.Drawing.Size(42, 20)
        Me.UPCLabel.TabIndex = 24
        Me.UPCLabel.Text = "UPC"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = true
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NameLabel.Location = New System.Drawing.Point(297, 16)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(51, 20)
        Me.NameLabel.TabIndex = 25
        Me.NameLabel.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Clipboardbutton)
        Me.Panel1.Controls.Add(Me.ProductPictureBox)
        Me.Panel1.Controls.Add(Me.ProductImagebutton)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.UPCLabel)
        Me.Panel1.Controls.Add(Me.NameLabel)
        Me.Panel1.Location = New System.Drawing.Point(195, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 369)
        Me.Panel1.TabIndex = 26
        '
        'Clipboardbutton
        '
        Me.Clipboardbutton.Location = New System.Drawing.Point(301, 323)
        Me.Clipboardbutton.Name = "Clipboardbutton"
        Me.Clipboardbutton.Size = New System.Drawing.Size(93, 23)
        Me.Clipboardbutton.TabIndex = 29
        Me.Clipboardbutton.Text = "From Clipboard"
        Me.Clipboardbutton.UseVisualStyleBackColor = true
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductPictureBox.Location = New System.Drawing.Point(452, 228)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(150, 136)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 27
        Me.ProductPictureBox.TabStop = false
        '
        'ProductImagebutton
        '
        Me.ProductImagebutton.Location = New System.Drawing.Point(301, 283)
        Me.ProductImagebutton.Name = "ProductImagebutton"
        Me.ProductImagebutton.Size = New System.Drawing.Size(93, 23)
        Me.ProductImagebutton.TabIndex = 28
        Me.ProductImagebutton.Text = "Search"
        Me.ProductImagebutton.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Product Image"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(214, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Product Information"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ConfirmButton.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x481
        Me.ConfirmButton.Location = New System.Drawing.Point(195, 425)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(86, 87)
        Me.ConfirmButton.TabIndex = 19
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmButton.UseVisualStyleBackColor = true
        '
        'Historybtn
        '
        Me.Historybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Historybtn.Image = Global.CantineTest.My.Resources.Resources.Clipboard_Paste_icon_48x481
        Me.Historybtn.Location = New System.Drawing.Point(458, 425)
        Me.Historybtn.Name = "Historybtn"
        Me.Historybtn.Size = New System.Drawing.Size(86, 87)
        Me.Historybtn.TabIndex = 20
        Me.Historybtn.Text = "History"
        Me.Historybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Historybtn.UseVisualStyleBackColor = true
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CancelButton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.CancelButton.Location = New System.Drawing.Point(716, 425)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(86, 87)
        Me.CancelButton.TabIndex = 21
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'EditItem
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 534)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Historybtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ActifCheckBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemMaxNumericUpDown)
        Me.Controls.Add(Me.ItemMinNumericUpDown)
        Me.Controls.Add(Me.ItemPriceNumericUpDown)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Location = New System.Drawing.Point(844, 573)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(844, 573)
        Me.MinimizeBox = false
        Me.Name = "EditItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Product"
        Me.TopMost = true
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemMinNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemMaxNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.ProductPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ItemPriceNumericUpDown As NumericUpDown
    Friend WithEvents ItemMinNumericUpDown As NumericUpDown
    Friend WithEvents ItemMaxNumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ActifCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Historybtn As Button
    Friend WithEvents UPCLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProductImagebutton As Button
    Friend WithEvents ProductOpenFileDialog As OpenFileDialog
    Friend WithEvents ProductPictureBox As PictureBox
    Friend WithEvents Clipboardbutton As Button
End Class
