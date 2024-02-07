<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUser))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UPCLabel = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.CashierCheckBox = New System.Windows.Forms.CheckBox()
        Me.InventoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.StockTakingCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Passwordbutton = New System.Windows.Forms.Button()
        Me.Historybutton = New System.Windows.Forms.Button()
        Me.Cancelbutton = New System.Windows.Forms.Button()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(213, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "User Information"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(164, 469)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Sign_up_128
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "StockTaking"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Inventory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Cashier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UPCLabel)
        Me.Panel1.Controls.Add(Me.ActiveCheckBox)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Location = New System.Drawing.Point(194, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 86)
        Me.Panel1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Active"
        '
        'UPCLabel
        '
        Me.UPCLabel.AutoSize = True
        Me.UPCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPCLabel.Location = New System.Drawing.Point(297, 108)
        Me.UPCLabel.Name = "UPCLabel"
        Me.UPCLabel.Size = New System.Drawing.Size(42, 20)
        Me.UPCLabel.TabIndex = 24
        Me.UPCLabel.Text = "UPC"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(301, 58)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 44
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(297, 16)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(51, 20)
        Me.UsernameLabel.TabIndex = 25
        Me.UsernameLabel.Text = "Name"
        '
        'CashierCheckBox
        '
        Me.CashierCheckBox.AutoSize = True
        Me.CashierCheckBox.Location = New System.Drawing.Point(496, 179)
        Me.CashierCheckBox.Name = "CashierCheckBox"
        Me.CashierCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CashierCheckBox.TabIndex = 46
        Me.CashierCheckBox.UseVisualStyleBackColor = True
        '
        'InventoryCheckBox
        '
        Me.InventoryCheckBox.AutoSize = True
        Me.InventoryCheckBox.Location = New System.Drawing.Point(496, 227)
        Me.InventoryCheckBox.Name = "InventoryCheckBox"
        Me.InventoryCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.InventoryCheckBox.TabIndex = 47
        Me.InventoryCheckBox.UseVisualStyleBackColor = True
        '
        'StockTakingCheckBox
        '
        Me.StockTakingCheckBox.AutoSize = True
        Me.StockTakingCheckBox.Location = New System.Drawing.Point(496, 278)
        Me.StockTakingCheckBox.Name = "StockTakingCheckBox"
        Me.StockTakingCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.StockTakingCheckBox.TabIndex = 48
        Me.StockTakingCheckBox.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AdminCheckBox)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(194, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 199)
        Me.Panel2.TabIndex = 46
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.AutoSize = True
        Me.AdminCheckBox.Location = New System.Drawing.Point(301, 168)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.AdminCheckBox.TabIndex = 51
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "User Roles"
        '
        'Passwordbutton
        '
        Me.Passwordbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Passwordbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Passwordbutton.Image = Global.CantineTest.My.Resources.Resources.Aha_Soft_Security_Secrecy_48
        Me.Passwordbutton.Location = New System.Drawing.Point(487, 374)
        Me.Passwordbutton.Name = "Passwordbutton"
        Me.Passwordbutton.Size = New System.Drawing.Size(86, 87)
        Me.Passwordbutton.TabIndex = 43
        Me.Passwordbutton.Text = "Password"
        Me.Passwordbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Passwordbutton.UseVisualStyleBackColor = True
        '
        'Historybutton
        '
        Me.Historybutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historybutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Historybutton.Image = Global.CantineTest.My.Resources.Resources.Clipboard_Paste_icon_48x481
        Me.Historybutton.Location = New System.Drawing.Point(338, 374)
        Me.Historybutton.Name = "Historybutton"
        Me.Historybutton.Size = New System.Drawing.Size(86, 87)
        Me.Historybutton.TabIndex = 37
        Me.Historybutton.Text = "History"
        Me.Historybutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Historybutton.UseVisualStyleBackColor = True
        '
        'Cancelbutton
        '
        Me.Cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Cancelbutton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.Cancelbutton.Location = New System.Drawing.Point(633, 374)
        Me.Cancelbutton.Name = "Cancelbutton"
        Me.Cancelbutton.Size = New System.Drawing.Size(86, 87)
        Me.Cancelbutton.TabIndex = 44
        Me.Cancelbutton.Text = "Cancel"
        Me.Cancelbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbutton.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ConfirmButton.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x481
        Me.ConfirmButton.Location = New System.Drawing.Point(194, 374)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(86, 87)
        Me.ConfirmButton.TabIndex = 35
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'EditUser
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 469)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StockTakingCheckBox)
        Me.Controls.Add(Me.InventoryCheckBox)
        Me.Controls.Add(Me.CashierCheckBox)
        Me.Controls.Add(Me.Passwordbutton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Historybutton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Cancelbutton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(761, 508)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(761, 508)
        Me.Name = "EditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User"
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Historybutton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cancelbutton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UPCLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Passwordbutton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents CashierCheckBox As CheckBox
    Friend WithEvents InventoryCheckBox As CheckBox
    Friend WithEvents StockTakingCheckBox As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents AdminCheckBox As CheckBox
    Friend WithEvents Label8 As Label
End Class
