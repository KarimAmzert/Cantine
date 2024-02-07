<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPassword))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ConfirmTitleLabel = New System.Windows.Forms.Label()
        Me.NewPasswordTitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmLabel = New System.Windows.Forms.Label()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.SpecialLabel = New System.Windows.Forms.Label()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.UppercaseLabel = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(146, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "New User Password"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(127, 445)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_desktop_user_password_72
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'ConfirmTitleLabel
        '
        Me.ConfirmTitleLabel.AutoSize = true
        Me.ConfirmTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ConfirmTitleLabel.ForeColor = System.Drawing.Color.Black
        Me.ConfirmTitleLabel.Location = New System.Drawing.Point(11, 224)
        Me.ConfirmTitleLabel.Name = "ConfirmTitleLabel"
        Me.ConfirmTitleLabel.Size = New System.Drawing.Size(137, 20)
        Me.ConfirmTitleLabel.TabIndex = 31
        Me.ConfirmTitleLabel.Text = "Confirm Password"
        '
        'NewPasswordTitleLabel
        '
        Me.NewPasswordTitleLabel.AutoSize = true
        Me.NewPasswordTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NewPasswordTitleLabel.ForeColor = System.Drawing.Color.Black
        Me.NewPasswordTitleLabel.Location = New System.Drawing.Point(11, 17)
        Me.NewPasswordTitleLabel.Name = "NewPasswordTitleLabel"
        Me.NewPasswordTitleLabel.Size = New System.Drawing.Size(113, 20)
        Me.NewPasswordTitleLabel.TabIndex = 22
        Me.NewPasswordTitleLabel.Text = "New Password"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NewPasswordTextBox)
        Me.Panel1.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Panel1.Controls.Add(Me.ConfirmLabel)
        Me.Panel1.Controls.Add(Me.NumberLabel)
        Me.Panel1.Controls.Add(Me.NewPasswordTitleLabel)
        Me.Panel1.Controls.Add(Me.SpecialLabel)
        Me.Panel1.Controls.Add(Me.LengthLabel)
        Me.Panel1.Controls.Add(Me.UppercaseLabel)
        Me.Panel1.Controls.Add(Me.ConfirmTitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(133, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 297)
        Me.Panel1.TabIndex = 36
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(203, 14)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(388, 26)
        Me.NewPasswordTextBox.TabIndex = 43
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(203, 221)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(388, 26)
        Me.ConfirmPasswordTextBox.TabIndex = 44
        '
        'ConfirmLabel
        '
        Me.ConfirmLabel.AutoSize = true
        Me.ConfirmLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ConfirmLabel.ForeColor = System.Drawing.Color.Red
        Me.ConfirmLabel.Location = New System.Drawing.Point(199, 260)
        Me.ConfirmLabel.Name = "ConfirmLabel"
        Me.ConfirmLabel.Size = New System.Drawing.Size(197, 20)
        Me.ConfirmLabel.TabIndex = 42
        Me.ConfirmLabel.Text = "❌ Passwords must match."
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = true
        Me.NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NumberLabel.ForeColor = System.Drawing.Color.Red
        Me.NumberLabel.Location = New System.Drawing.Point(199, 166)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(342, 20)
        Me.NumberLabel.TabIndex = 41
        Me.NumberLabel.Text = "❌ Password must contain at least one number."
        '
        'SpecialLabel
        '
        Me.SpecialLabel.AutoSize = true
        Me.SpecialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SpecialLabel.ForeColor = System.Drawing.Color.Red
        Me.SpecialLabel.Location = New System.Drawing.Point(199, 125)
        Me.SpecialLabel.Name = "SpecialLabel"
        Me.SpecialLabel.Size = New System.Drawing.Size(408, 20)
        Me.SpecialLabel.TabIndex = 40
        Me.SpecialLabel.Text = "❌ Password must contain at least one special character."
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = true
        Me.LengthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LengthLabel.ForeColor = System.Drawing.Color.Red
        Me.LengthLabel.Location = New System.Drawing.Point(199, 91)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(354, 20)
        Me.LengthLabel.TabIndex = 39
        Me.LengthLabel.Text = "❌ Password must be at least 10 characters long."
        '
        'UppercaseLabel
        '
        Me.UppercaseLabel.AutoSize = true
        Me.UppercaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UppercaseLabel.ForeColor = System.Drawing.Color.Red
        Me.UppercaseLabel.Location = New System.Drawing.Point(199, 55)
        Me.UppercaseLabel.Name = "UppercaseLabel"
        Me.UppercaseLabel.Size = New System.Drawing.Size(407, 20)
        Me.UppercaseLabel.TabIndex = 38
        Me.UppercaseLabel.Text = "❌ Password must contain at least one upper case letter."
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ConfirmButton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_ok_apply_icon_48X481
        Me.ConfirmButton.Location = New System.Drawing.Point(133, 345)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(95, 88)
        Me.ConfirmButton.TabIndex = 45
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmButton.UseVisualStyleBackColor = true
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CancelButton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x482
        Me.CancelButton.Location = New System.Drawing.Point(673, 345)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(95, 88)
        Me.CancelButton.TabIndex = 46
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'ResetPassword
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 445)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(796, 484)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(796, 484)
        Me.Name = "ResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.TopMost = true
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents ConfirmTitleLabel As Label
    Friend WithEvents NewPasswordTitleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NumberLabel As Label
    Friend WithEvents SpecialLabel As Label
    Friend WithEvents LengthLabel As Label
    Friend WithEvents UppercaseLabel As Label
    Friend WithEvents ConfirmLabel As Label
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
End Class
