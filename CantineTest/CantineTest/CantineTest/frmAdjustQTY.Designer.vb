<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdjustQTY
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjustQTY))
        Me.AdjustNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.UPCLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProductnameLabel = New System.Windows.Forms.Label()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QtyLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReasonListComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.AdjustNumeric,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'AdjustNumeric
        '
        Me.AdjustNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AdjustNumeric.Location = New System.Drawing.Point(180, 219)
        Me.AdjustNumeric.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdjustNumeric.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.AdjustNumeric.Name = "AdjustNumeric"
        Me.AdjustNumeric.Size = New System.Drawing.Size(155, 30)
        Me.AdjustNumeric.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(5, 222)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Adjust Qty"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(244, 347)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reason"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(189, 583)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CantineTest.My.Resources.Resources.box_open_icon_barcode_128X128
        Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(176, 182)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = false
        '
        'UPCLabel
        '
        Me.UPCLabel.AutoSize = true
        Me.UPCLabel.BackColor = System.Drawing.SystemColors.Window
        Me.UPCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UPCLabel.Location = New System.Drawing.Point(175, 154)
        Me.UPCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UPCLabel.Name = "UPCLabel"
        Me.UPCLabel.Size = New System.Drawing.Size(54, 25)
        Me.UPCLabel.TabIndex = 12
        Me.UPCLabel.Text = "UPC"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "UPC"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Label7.Location = New System.Drawing.Point(6, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Product Name"
        '
        'ProductnameLabel
        '
        Me.ProductnameLabel.AutoSize = true
        Me.ProductnameLabel.BackColor = System.Drawing.SystemColors.Window
        Me.ProductnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ProductnameLabel.Location = New System.Drawing.Point(175, 86)
        Me.ProductnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductnameLabel.Name = "ProductnameLabel"
        Me.ProductnameLabel.Size = New System.Drawing.Size(49, 25)
        Me.ProductnameLabel.TabIndex = 16
        Me.ProductnameLabel.Text = "Item"
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x481
        Me.Cancelbtn.Location = New System.Drawing.Point(716, 448)
        Me.Cancelbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(115, 105)
        Me.Cancelbtn.TabIndex = 8
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'Confirmbtn
        '
        Me.Confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x48
        Me.Confirmbtn.Location = New System.Drawing.Point(237, 448)
        Me.Confirmbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(115, 105)
        Me.Confirmbtn.TabIndex = 6
        Me.Confirmbtn.Text = "Save"
        Me.Confirmbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Confirmbtn.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Label3.Location = New System.Drawing.Point(244, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Current Qty"
        '
        'QtyLabel
        '
        Me.QtyLabel.AutoSize = true
        Me.QtyLabel.BackColor = System.Drawing.SystemColors.Window
        Me.QtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.QtyLabel.Location = New System.Drawing.Point(413, 63)
        Me.QtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.QtyLabel.Name = "QtyLabel"
        Me.QtyLabel.Size = New System.Drawing.Size(43, 25)
        Me.QtyLabel.TabIndex = 18
        Me.QtyLabel.Text = "Qty"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ReasonListComboBox)
        Me.Panel1.Controls.Add(Me.AdjustNumeric)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ProductnameLabel)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.UPCLabel)
        Me.Panel1.Location = New System.Drawing.Point(237, 43)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 370)
        Me.Panel1.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(259, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Product Adjustment"
        '
        'ReasonListComboBox
        '
        Me.ReasonListComboBox.AutoCompleteCustomSource.AddRange(New String() {"Loss", "Expired", "Count Error Correction"})
        Me.ReasonListComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ReasonListComboBox.FormattingEnabled = true
        Me.ReasonListComboBox.Items.AddRange(New Object() {"Loss", "Expired", "Count Error Correction"})
        Me.ReasonListComboBox.Location = New System.Drawing.Point(180, 300)
        Me.ReasonListComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReasonListComboBox.Name = "ReasonListComboBox"
        Me.ReasonListComboBox.Size = New System.Drawing.Size(197, 33)
        Me.ReasonListComboBox.TabIndex = 21
        '
        'frmAdjustQTY
        '
        Me.AcceptButton = Me.Confirmbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancelbtn
        Me.ClientSize = New System.Drawing.Size(876, 583)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.QtyLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(894, 630)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(894, 630)
        Me.Name = "frmAdjustQTY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjust Qty"
        CType(Me.AdjustNumeric,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents AdjustNumeric As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Confirmbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UPCLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ProductnameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QtyLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ReasonListComboBox As ComboBox
End Class
