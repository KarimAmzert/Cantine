<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdjustRegister))
        Me.CashLabel = New System.Windows.Forms.Label()
        Me.CashRegisterLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CashNumeric = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReasonListComboBox = New System.Windows.Forms.ComboBox()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        Me.PizzaAdjustmentbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.CashNumeric,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CashLabel
        '
        Me.CashLabel.AutoSize = true
        Me.CashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CashLabel.Location = New System.Drawing.Point(368, 73)
        Me.CashLabel.Name = "CashLabel"
        Me.CashLabel.Size = New System.Drawing.Size(49, 20)
        Me.CashLabel.TabIndex = 30
        Me.CashLabel.Text = "$0.00"
        '
        'CashRegisterLabel
        '
        Me.CashRegisterLabel.AutoSize = true
        Me.CashRegisterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.CashRegisterLabel.Location = New System.Drawing.Point(165, 28)
        Me.CashRegisterLabel.Name = "CashRegisterLabel"
        Me.CashRegisterLabel.Size = New System.Drawing.Size(84, 15)
        Me.CashRegisterLabel.TabIndex = 29
        Me.CashRegisterLabel.Text = "Cash Register"
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
        Me.CashNumeric.Size = New System.Drawing.Size(81, 26)
        Me.CashNumeric.TabIndex = 13
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(148, 369)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CashNumeric)
        Me.Panel1.Location = New System.Drawing.Point(154, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 200)
        Me.Panel1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Reason"
        '
        'ReasonListComboBox
        '
        Me.ReasonListComboBox.FormattingEnabled = true
        Me.ReasonListComboBox.Items.AddRange(New Object() {"Sale", "Withdrawal", "Event"})
        Me.ReasonListComboBox.Location = New System.Drawing.Point(372, 185)
        Me.ReasonListComboBox.Name = "ReasonListComboBox"
        Me.ReasonListComboBox.Size = New System.Drawing.Size(149, 21)
        Me.ReasonListComboBox.TabIndex = 14
        '
        'Confirmbtn
        '
        Me.Confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_ok_apply_icon_48X48
        Me.Confirmbtn.Location = New System.Drawing.Point(154, 263)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(103, 94)
        Me.Confirmbtn.TabIndex = 23
        Me.Confirmbtn.Text = "Confirm"
        Me.Confirmbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Confirmbtn.UseVisualStyleBackColor = true
        '
        'PizzaAdjustmentbtn
        '
        Me.PizzaAdjustmentbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PizzaAdjustmentbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PizzaAdjustmentbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.PizzaAdjustmentbtn.Image = Global.CantineTest.My.Resources.Resources.Lemon_Liu_Recipes_Recipe_pizza_48
        Me.PizzaAdjustmentbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PizzaAdjustmentbtn.Location = New System.Drawing.Point(304, 263)
        Me.PizzaAdjustmentbtn.Name = "PizzaAdjustmentbtn"
        Me.PizzaAdjustmentbtn.Size = New System.Drawing.Size(103, 94)
        Me.PizzaAdjustmentbtn.TabIndex = 24
        Me.PizzaAdjustmentbtn.Text = "Pizza Adjustment"
        Me.PizzaAdjustmentbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PizzaAdjustmentbtn.UseVisualStyleBackColor = true
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.Cancelbtn.Location = New System.Drawing.Point(457, 263)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(103, 94)
        Me.Cancelbtn.TabIndex = 25
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Aha_Soft_Universal_Shop_Cash_register_128
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'AdjustRegister
        '
        Me.AcceptButton = Me.Confirmbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 369)
        Me.Controls.Add(Me.PizzaAdjustmentbtn)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.ReasonListComboBox)
        Me.Controls.Add(Me.CashLabel)
        Me.Controls.Add(Me.CashRegisterLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(583, 408)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(583, 408)
        Me.Name = "AdjustRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjust Cash Register"
        CType(Me.CashNumeric,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents CashLabel As Label
    Friend WithEvents CashRegisterLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CashNumeric As NumericUpDown
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Confirmbtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ReasonListComboBox As ComboBox
    Friend WithEvents PizzaAdjustmentbtn As Button
End Class
