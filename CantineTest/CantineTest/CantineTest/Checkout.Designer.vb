<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checkout))
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ClientNameLabel = New System.Windows.Forms.Label()
        Me.ClientAmountNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChangeLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CreditLabel = New System.Windows.Forms.Label()
        Me.PayLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RemainingLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Creditbtn = New System.Windows.Forms.Button()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.ClientAmountNumeric,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.dgData.Location = New System.Drawing.Point(-1, 1)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = true
        Me.dgData.RowHeadersVisible = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgData.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgData.Size = New System.Drawing.Size(575, 381)
        Me.dgData.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgData)
        Me.Panel1.Location = New System.Drawing.Point(51, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 383)
        Me.Panel1.TabIndex = 3
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = true
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(575, 445)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(49, 20)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "$0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(476, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TOTAL:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = true
        Me.DateLabel.Location = New System.Drawing.Point(48, 40)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(30, 13)
        Me.DateLabel.TabIndex = 24
        Me.DateLabel.Text = "Date"
        '
        'ClientNameLabel
        '
        Me.ClientNameLabel.AutoSize = true
        Me.ClientNameLabel.Location = New System.Drawing.Point(48, 20)
        Me.ClientNameLabel.Name = "ClientNameLabel"
        Me.ClientNameLabel.Size = New System.Drawing.Size(62, 13)
        Me.ClientNameLabel.TabIndex = 25
        Me.ClientNameLabel.Text = "Client name"
        '
        'ClientAmountNumeric
        '
        Me.ClientAmountNumeric.DecimalPlaces = 2
        Me.ClientAmountNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ClientAmountNumeric.InterceptArrowKeys = false
        Me.ClientAmountNumeric.Location = New System.Drawing.Point(484, 502)
        Me.ClientAmountNumeric.Name = "ClientAmountNumeric"
        Me.ClientAmountNumeric.Size = New System.Drawing.Size(140, 26)
        Me.ClientAmountNumeric.TabIndex = 26
        '
        'Resetbtn
        '
        Me.Resetbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Resetbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Resetbtn.Location = New System.Drawing.Point(540, 540)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(86, 48)
        Me.Resetbtn.TabIndex = 29
        Me.Resetbtn.Text = "Reset"
        Me.Resetbtn.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(477, 651)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Change:"
        '
        'ChangeLabel
        '
        Me.ChangeLabel.AutoSize = true
        Me.ChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ChangeLabel.Location = New System.Drawing.Point(575, 651)
        Me.ChangeLabel.Name = "ChangeLabel"
        Me.ChangeLabel.Size = New System.Drawing.Size(49, 20)
        Me.ChangeLabel.TabIndex = 32
        Me.ChangeLabel.Text = "$0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Current credit"
        '
        'CreditLabel
        '
        Me.CreditLabel.AutoSize = true
        Me.CreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CreditLabel.Location = New System.Drawing.Point(47, 470)
        Me.CreditLabel.Name = "CreditLabel"
        Me.CreditLabel.Size = New System.Drawing.Size(49, 20)
        Me.CreditLabel.TabIndex = 34
        Me.CreditLabel.Text = "$0.00"
        '
        'PayLabel
        '
        Me.PayLabel.AutoSize = true
        Me.PayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PayLabel.Location = New System.Drawing.Point(575, 471)
        Me.PayLabel.Name = "PayLabel"
        Me.PayLabel.Size = New System.Drawing.Size(49, 20)
        Me.PayLabel.TabIndex = 35
        Me.PayLabel.Text = "$0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(555, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(442, 591)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "-----------------------------------"
        '
        'RemainingLabel
        '
        Me.RemainingLabel.AutoSize = true
        Me.RemainingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RemainingLabel.Location = New System.Drawing.Point(575, 611)
        Me.RemainingLabel.Name = "RemainingLabel"
        Me.RemainingLabel.Size = New System.Drawing.Size(49, 20)
        Me.RemainingLabel.TabIndex = 39
        Me.RemainingLabel.Text = "$0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(477, 611)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Remaining:"
        '
        'Addbtn
        '
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Addbtn.Location = New System.Drawing.Point(446, 541)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(86, 48)
        Me.Addbtn.TabIndex = 28
        Me.Addbtn.Text = "Add Cash"
        Me.Addbtn.UseVisualStyleBackColor = true
        '
        'Creditbtn
        '
        Me.Creditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Creditbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Creditbtn.Image = Global.CantineTest.My.Resources.Resources.Double_J_Design_Ravenna_3d_Credit_Card_48
        Me.Creditbtn.Location = New System.Drawing.Point(51, 508)
        Me.Creditbtn.Name = "Creditbtn"
        Me.Creditbtn.Size = New System.Drawing.Size(86, 76)
        Me.Creditbtn.TabIndex = 30
        Me.Creditbtn.Text = "Use credit"
        Me.Creditbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Creditbtn.UseVisualStyleBackColor = true
        '
        'Confirmbtn
        '
        Me.Confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_ok_apply_icon_48X48
        Me.Confirmbtn.Location = New System.Drawing.Point(178, 693)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(86, 87)
        Me.Confirmbtn.TabIndex = 22
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
        Me.Cancelbtn.Location = New System.Drawing.Point(412, 693)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(86, 87)
        Me.Cancelbtn.TabIndex = 23
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 792)
        Me.Controls.Add(Me.RemainingLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PayLabel)
        Me.Controls.Add(Me.CreditLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChangeLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Creditbtn)
        Me.Controls.Add(Me.Resetbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.ClientAmountNumeric)
        Me.Controls.Add(Me.ClientNameLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(694, 831)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(694, 831)
        Me.Name = "Checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        CType(Me.ClientAmountNumeric,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Confirmbtn As Button
    Friend WithEvents DateLabel As Label
    Friend WithEvents ClientNameLabel As Label
    Friend WithEvents ClientAmountNumeric As NumericUpDown
    Friend WithEvents Addbtn As Button
    Friend WithEvents Resetbtn As Button
    Friend WithEvents Creditbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ChangeLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CreditLabel As Label
    Friend WithEvents PayLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RemainingLabel As Label
    Friend WithEvents Label7 As Label
End Class
