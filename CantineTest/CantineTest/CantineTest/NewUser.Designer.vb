<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CashierCheckBox = New System.Windows.Forms.CheckBox()
        Me.InventoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.StockTakingCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(207, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "New User Information"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(169, 565)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 327)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "StockTaking"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(203, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Cashier"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(203, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(371, 68)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernameTextBox.MaxLength = 50
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(273, 30)
        Me.UsernameTextBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Location = New System.Drawing.Point(189, 49)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 118)
        Me.Panel1.TabIndex = 36
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(180, 70)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordTextBox.MaxLength = 80
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(273, 30)
        Me.PasswordTextBox.TabIndex = 2
        '
        'CashierCheckBox
        '
        Me.CashierCheckBox.AutoSize = true
        Me.CashierCheckBox.Location = New System.Drawing.Point(180, 25)
        Me.CashierCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CashierCheckBox.Name = "CashierCheckBox"
        Me.CashierCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.CashierCheckBox.TabIndex = 3
        Me.CashierCheckBox.UseVisualStyleBackColor = true
        '
        'InventoryCheckBox
        '
        Me.InventoryCheckBox.AutoSize = true
        Me.InventoryCheckBox.Location = New System.Drawing.Point(371, 272)
        Me.InventoryCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InventoryCheckBox.Name = "InventoryCheckBox"
        Me.InventoryCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.InventoryCheckBox.TabIndex = 4
        Me.InventoryCheckBox.UseVisualStyleBackColor = true
        '
        'StockTakingCheckBox
        '
        Me.StockTakingCheckBox.AutoSize = true
        Me.StockTakingCheckBox.Location = New System.Drawing.Point(371, 332)
        Me.StockTakingCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StockTakingCheckBox.Name = "StockTakingCheckBox"
        Me.StockTakingCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.StockTakingCheckBox.TabIndex = 5
        Me.StockTakingCheckBox.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AdminCheckBox)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.CashierCheckBox)
        Me.Panel2.Location = New System.Drawing.Point(189, 194)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 244)
        Me.Panel2.TabIndex = 37
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.AutoSize = true
        Me.AdminCheckBox.Location = New System.Drawing.Point(180, 202)
        Me.AdminCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.AdminCheckBox.TabIndex = 6
        Me.AdminCheckBox.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 196)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(207, 186)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "New User Roles"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ConfirmButton.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x48
        Me.ConfirmButton.Location = New System.Drawing.Point(189, 454)
        Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(116, 108)
        Me.ConfirmButton.TabIndex = 7
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmButton.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_contact_new_96
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CancelButton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.CancelButton.Location = New System.Drawing.Point(556, 454)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(116, 108)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'NewUser
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 565)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StockTakingCheckBox)
        Me.Controls.Add(Me.InventoryCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(703, 612)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(703, 612)
        Me.Name = "NewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CashierCheckBox As CheckBox
    Friend WithEvents InventoryCheckBox As CheckBox
    Friend WithEvents StockTakingCheckBox As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents AdminCheckBox As CheckBox
    Friend WithEvents Label8 As Label
End Class
