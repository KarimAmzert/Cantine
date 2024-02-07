<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class CantineLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CantineLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ForgotPasswordLabel = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.UsernameLabel.Location = New System.Drawing.Point(141, 32)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(98, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.PasswordLabel.Location = New System.Drawing.Point(141, 71)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(98, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(239, 30)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(265, 26)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(239, 69)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(265, 26)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.OK.Location = New System.Drawing.Point(239, 141)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(265, 39)
        Me.OK.TabIndex = 4
        Me.OK.Text = "Log in"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogoPictureBox.Image = Global.CantineTest.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Inventory_maintenance4
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(129, 197)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = false
        '
        'ForgotPasswordLabel
        '
        Me.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForgotPasswordLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ForgotPasswordLabel.Location = New System.Drawing.Point(236, 102)
        Me.ForgotPasswordLabel.Name = "ForgotPasswordLabel"
        Me.ForgotPasswordLabel.Size = New System.Drawing.Size(141, 23)
        Me.ForgotPasswordLabel.TabIndex = 5
        Me.ForgotPasswordLabel.Text = "Forgot Password ?"
        Me.ForgotPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CantineLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 197)
        Me.Controls.Add(Me.ForgotPasswordLabel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(554, 236)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(554, 236)
        Me.Name = "CantineLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantine"
        Me.TopMost = true
        CType(Me.LogoPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ForgotPasswordLabel As Label
End Class
