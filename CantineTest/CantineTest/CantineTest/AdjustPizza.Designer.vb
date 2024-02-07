<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustPizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdjustPizza))
        Me.CashLabel = New System.Windows.Forms.Label()
        Me.CashRegisterLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CashNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PizzaNumeric = New System.Windows.Forms.NumericUpDown()
        Me.PoutineNumeric = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.CashNumeric,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PizzaNumeric,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PoutineNumeric,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CashLabel
        '
        Me.CashLabel.AutoSize = true
        Me.CashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CashLabel.Location = New System.Drawing.Point(371, 73)
        Me.CashLabel.Name = "CashLabel"
        Me.CashLabel.Size = New System.Drawing.Size(49, 20)
        Me.CashLabel.TabIndex = 38
        Me.CashLabel.Text = "$0.00"
        '
        'CashRegisterLabel
        '
        Me.CashRegisterLabel.AutoSize = true
        Me.CashRegisterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.CashRegisterLabel.Location = New System.Drawing.Point(168, 28)
        Me.CashRegisterLabel.Name = "CashRegisterLabel"
        Me.CashRegisterLabel.Size = New System.Drawing.Size(84, 15)
        Me.CashRegisterLabel.TabIndex = 37
        Me.CashRegisterLabel.Text = "Cash Register"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(148, 419)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Lemon_Liu_Recipes_Recipe_pizza_128
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PoutineNumeric)
        Me.Panel1.Controls.Add(Me.PizzaNumeric)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CashNumeric)
        Me.Panel1.Location = New System.Drawing.Point(157, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 253)
        Me.Panel1.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Adjustment"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Current Amount"
        '
        'CashNumeric
        '
        Me.CashNumeric.DecimalPlaces = 2
        Me.CashNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CashNumeric.Location = New System.Drawing.Point(217, 85)
        Me.CashNumeric.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.CashNumeric.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.CashNumeric.Name = "CashNumeric"
        Me.CashNumeric.Size = New System.Drawing.Size(122, 26)
        Me.CashNumeric.TabIndex = 13
        '
        'Confirmbtn
        '
        Me.Confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_ok_apply_icon_48X48
        Me.Confirmbtn.Location = New System.Drawing.Point(157, 313)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(103, 94)
        Me.Confirmbtn.TabIndex = 34
        Me.Confirmbtn.Text = "Confirm"
        Me.Confirmbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Confirmbtn.UseVisualStyleBackColor = true
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.Cancelbtn.Location = New System.Drawing.Point(460, 313)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(103, 94)
        Me.Cancelbtn.TabIndex = 36
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Pizza Slice Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Poutine Qty"
        '
        'PizzaNumeric
        '
        Me.PizzaNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PizzaNumeric.Location = New System.Drawing.Point(217, 141)
        Me.PizzaNumeric.Name = "PizzaNumeric"
        Me.PizzaNumeric.Size = New System.Drawing.Size(122, 26)
        Me.PizzaNumeric.TabIndex = 31
        '
        'PoutineNumeric
        '
        Me.PoutineNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PoutineNumeric.Location = New System.Drawing.Point(217, 203)
        Me.PoutineNumeric.Name = "PoutineNumeric"
        Me.PoutineNumeric.Size = New System.Drawing.Size(122, 26)
        Me.PoutineNumeric.TabIndex = 32
        '
        'AdjustPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 419)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.CashLabel)
        Me.Controls.Add(Me.CashRegisterLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "AdjustPizza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Adjustment"
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.CashNumeric,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PizzaNumeric,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PoutineNumeric,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Confirmbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents CashLabel As Label
    Friend WithEvents CashRegisterLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CashNumeric As NumericUpDown
    Friend WithEvents PoutineNumeric As NumericUpDown
    Friend WithEvents PizzaNumeric As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
