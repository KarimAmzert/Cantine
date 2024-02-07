<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventoryAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventoryAdd))
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemPriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemQTYNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemUPCTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemMinNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ItemMaxNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Clipboardbutton = New System.Windows.Forms.Button()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductImagebutton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ItemBarcodeButton = New System.Windows.Forms.Button()
        Me.ProductOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemQTYNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemMinNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemMaxNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.ProductPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FileSystemWatcher1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(276, 35)
        Me.ItemNameTextBox.MaxLength = 50
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(233, 26)
        Me.ItemNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(150, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Name"
        '
        'ItemPriceNumericUpDown
        '
        Me.ItemPriceNumericUpDown.DecimalPlaces = 2
        Me.ItemPriceNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemPriceNumericUpDown.Location = New System.Drawing.Point(276, 122)
        Me.ItemPriceNumericUpDown.Name = "ItemPriceNumericUpDown"
        Me.ItemPriceNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemPriceNumericUpDown.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unit Price"
        '
        'ItemQTYNumericUpDown
        '
        Me.ItemQTYNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemQTYNumericUpDown.Location = New System.Drawing.Point(276, 165)
        Me.ItemQTYNumericUpDown.Name = "ItemQTYNumericUpDown"
        Me.ItemQTYNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemQTYNumericUpDown.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Qty"
        '
        'ItemUPCTextBox
        '
        Me.ItemUPCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ItemUPCTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemUPCTextBox.Location = New System.Drawing.Point(276, 78)
        Me.ItemUPCTextBox.MaxLength = 255
        Me.ItemUPCTextBox.Name = "ItemUPCTextBox"
        Me.ItemUPCTextBox.Size = New System.Drawing.Size(233, 26)
        Me.ItemUPCTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(150, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "UPC"
        '
        'ItemMinNumericUpDown
        '
        Me.ItemMinNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemMinNumericUpDown.Location = New System.Drawing.Point(276, 214)
        Me.ItemMinNumericUpDown.Name = "ItemMinNumericUpDown"
        Me.ItemMinNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemMinNumericUpDown.TabIndex = 4
        '
        'ItemMaxNumericUpDown
        '
        Me.ItemMaxNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemMaxNumericUpDown.Location = New System.Drawing.Point(276, 262)
        Me.ItemMaxNumericUpDown.Name = "ItemMaxNumericUpDown"
        Me.ItemMaxNumericUpDown.Size = New System.Drawing.Size(93, 26)
        Me.ItemMaxNumericUpDown.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Minimum"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(150, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Maximum"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(127, 588)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Actions_tag_new_icon_96x96
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Clipboardbutton)
        Me.Panel1.Controls.Add(Me.ProductPictureBox)
        Me.Panel1.Controls.Add(Me.ProductImagebutton)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(140, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 443)
        Me.Panel1.TabIndex = 18
        '
        'Clipboardbutton
        '
        Me.Clipboardbutton.Location = New System.Drawing.Point(135, 349)
        Me.Clipboardbutton.Name = "Clipboardbutton"
        Me.Clipboardbutton.Size = New System.Drawing.Size(93, 23)
        Me.Clipboardbutton.TabIndex = 2
        Me.Clipboardbutton.Text = "From Clipboard"
        Me.Clipboardbutton.UseVisualStyleBackColor = true
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductPictureBox.Location = New System.Drawing.Point(234, 302)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(150, 136)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 21
        Me.ProductPictureBox.TabStop = false
        '
        'ProductImagebutton
        '
        Me.ProductImagebutton.Location = New System.Drawing.Point(135, 302)
        Me.ProductImagebutton.Name = "ProductImagebutton"
        Me.ProductImagebutton.Size = New System.Drawing.Size(93, 23)
        Me.ProductImagebutton.TabIndex = 0
        Me.ProductImagebutton.Text = "Search"
        Me.ProductImagebutton.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Product Image"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(153, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "New Product Information"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ConfirmButton.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x48
        Me.ConfirmButton.Location = New System.Drawing.Point(140, 482)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(87, 88)
        Me.ConfirmButton.TabIndex = 8
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmButton.UseVisualStyleBackColor = true
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CancelButton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.CancelButton.Location = New System.Drawing.Point(442, 482)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(87, 88)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'ItemBarcodeButton
        '
        Me.ItemBarcodeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemBarcodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ItemBarcodeButton.Image = Global.CantineTest.My.Resources.Resources.Double_J_Design_Diagram_Free_Barcode_64
        Me.ItemBarcodeButton.Location = New System.Drawing.Point(289, 482)
        Me.ItemBarcodeButton.Name = "ItemBarcodeButton"
        Me.ItemBarcodeButton.Size = New System.Drawing.Size(93, 88)
        Me.ItemBarcodeButton.TabIndex = 9
        Me.ItemBarcodeButton.Text = "Scan UPC"
        Me.ItemBarcodeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ItemBarcodeButton.UseVisualStyleBackColor = true
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = true
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FrmInventoryAdd
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 588)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ItemMaxNumericUpDown)
        Me.Controls.Add(Me.ItemMinNumericUpDown)
        Me.Controls.Add(Me.ItemBarcodeButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ItemUPCTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ItemQTYNumericUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ItemPriceNumericUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(557, 627)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(557, 627)
        Me.Name = "FrmInventoryAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new product"
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemQTYNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemMinNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemMaxNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.ProductPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FileSystemWatcher1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItemPriceNumericUpDown As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ItemQTYNumericUpDown As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ItemUPCTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ItemBarcodeButton As Button
    Friend WithEvents ItemMinNumericUpDown As NumericUpDown
    Friend WithEvents ItemMaxNumericUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ProductImagebutton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ProductOpenFileDialog As OpenFileDialog
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents ProductPictureBox As PictureBox
    Friend WithEvents Clipboardbutton As Button
End Class
