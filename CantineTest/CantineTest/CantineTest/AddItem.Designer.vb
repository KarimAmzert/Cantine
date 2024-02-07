<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItem))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.QTYNumeric = New System.Windows.Forms.NumericUpDown()
        Me.UPCLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.QTYNumeric,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(226, 320)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'QTYNumeric
        '
        Me.QTYNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.QTYNumeric.Location = New System.Drawing.Point(327, 142)
        Me.QTYNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QTYNumeric.Name = "QTYNumeric"
        Me.QTYNumeric.Size = New System.Drawing.Size(136, 26)
        Me.QTYNumeric.TabIndex = 4
        Me.QTYNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'UPCLabel
        '
        Me.UPCLabel.AutoSize = true
        Me.UPCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UPCLabel.Location = New System.Drawing.Point(323, 91)
        Me.UPCLabel.Name = "UPCLabel"
        Me.UPCLabel.Size = New System.Drawing.Size(50, 20)
        Me.UPCLabel.TabIndex = 6
        Me.UPCLabel.Text = "UPC :"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "UPC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Qty:"
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = true
        Me.ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ProductNameLabel.Location = New System.Drawing.Point(262, 44)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(51, 20)
        Me.ProductNameLabel.TabIndex = 10
        Me.ProductNameLabel.Text = "Name"
        '
        'Confirmbtn
        '
        Me.Confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x48
        Me.Confirmbtn.Location = New System.Drawing.Point(269, 216)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(92, 94)
        Me.Confirmbtn.TabIndex = 2
        Me.Confirmbtn.Text = "Save"
        Me.Confirmbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Confirmbtn.UseVisualStyleBackColor = true
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.Cancelbtn.Location = New System.Drawing.Point(458, 214)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(92, 94)
        Me.Cancelbtn.TabIndex = 3
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.fork_1_icon_256x2562
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 268)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = false
        '
        'AddItem
        '
        Me.AcceptButton = Me.Confirmbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.Cancelbtn
        Me.ClientSize = New System.Drawing.Size(592, 320)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UPCLabel)
        Me.Controls.Add(Me.QTYNumeric)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(608, 359)
        Me.MinimumSize = New System.Drawing.Size(608, 359)
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Stock"
        Me.TopMost = true
        CType(Me.QTYNumeric,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Confirmbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents QTYNumeric As NumericUpDown
    Friend WithEvents UPCLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductNameLabel As Label
End Class
