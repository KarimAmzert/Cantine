<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCart))
        Me.ItemListbox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemQTYNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ItemPriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RemoveRowbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReasonComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ItemQTYNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'ItemListbox
        '
        Me.ItemListbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemListbox.FormattingEnabled = true
        Me.ItemListbox.ItemHeight = 20
        Me.ItemListbox.Location = New System.Drawing.Point(418, 30)
        Me.ItemListbox.Name = "ItemListbox"
        Me.ItemListbox.Size = New System.Drawing.Size(274, 224)
        Me.ItemListbox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 22)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Unit Price"
        '
        'ItemQTYNumericUpDown
        '
        Me.ItemQTYNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemQTYNumericUpDown.Location = New System.Drawing.Point(479, 379)
        Me.ItemQTYNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ItemQTYNumericUpDown.Name = "ItemQTYNumericUpDown"
        Me.ItemQTYNumericUpDown.Size = New System.Drawing.Size(104, 26)
        Me.ItemQTYNumericUpDown.TabIndex = 16
        Me.ItemQTYNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ItemPriceNumericUpDown
        '
        Me.ItemPriceNumericUpDown.DecimalPlaces = 2
        Me.ItemPriceNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ItemPriceNumericUpDown.Location = New System.Drawing.Point(479, 315)
        Me.ItemPriceNumericUpDown.Name = "ItemPriceNumericUpDown"
        Me.ItemPriceNumericUpDown.Size = New System.Drawing.Size(104, 26)
        Me.ItemPriceNumericUpDown.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 650)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Designcontest_Ecommerce_Business_Shopping_256
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 253)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'RemoveRowbtn
        '
        Me.RemoveRowbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveRowbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.RemoveRowbtn.Image = Global.CantineTest.My.Resources.Resources.Trash_empty_icon
        Me.RemoveRowbtn.Location = New System.Drawing.Point(495, 523)
        Me.RemoveRowbtn.Name = "RemoveRowbtn"
        Me.RemoveRowbtn.Size = New System.Drawing.Size(111, 100)
        Me.RemoveRowbtn.TabIndex = 19
        Me.RemoveRowbtn.Text = "Remove"
        Me.RemoveRowbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RemoveRowbtn.UseVisualStyleBackColor = true
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.Cancelbtn.Location = New System.Drawing.Point(692, 523)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(111, 100)
        Me.Cancelbtn.TabIndex = 20
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Editbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x48
        Me.Editbtn.Location = New System.Drawing.Point(291, 523)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(111, 100)
        Me.Editbtn.TabIndex = 18
        Me.Editbtn.Text = "Save"
        Me.Editbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Editbtn.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Sale Reason"
        '
        'ReasonComboBox
        '
        Me.ReasonComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ReasonComboBox.FormattingEnabled = true
        Me.ReasonComboBox.Location = New System.Drawing.Point(479, 442)
        Me.ReasonComboBox.Name = "ReasonComboBox"
        Me.ReasonComboBox.Size = New System.Drawing.Size(213, 28)
        Me.ReasonComboBox.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(291, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 180)
        Me.Panel1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(308, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Product Information"
        '
        'frmEditCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReasonComboBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RemoveRowbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.ItemQTYNumericUpDown)
        Me.Controls.Add(Me.ItemPriceNumericUpDown)
        Me.Controls.Add(Me.ItemListbox)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(906, 689)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(906, 689)
        Me.Name = "frmEditCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Cart"
        CType(Me.ItemQTYNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ItemPriceNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ItemListbox As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ItemQTYNumericUpDown As NumericUpDown
    Friend WithEvents ItemPriceNumericUpDown As NumericUpDown
    Friend WithEvents Editbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents RemoveRowbtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReasonComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
