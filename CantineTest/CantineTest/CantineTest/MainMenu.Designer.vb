<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Clientbtn = New System.Windows.Forms.Button()
        Me.Caissebtn = New System.Windows.Forms.Button()
        Me.Usersbtn = New System.Windows.Forms.Button()
        Me.CloseAppbutton = New System.Windows.Forms.Button()
        Me.Inventorybutton = New System.Windows.Forms.Button()
        Me.Checkoutbtn = New System.Windows.Forms.Button()
        Me.StockTakingbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Clientbtn
        '
        Me.Clientbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Clientbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Clientbtn.Image = Global.CantineTest.My.Resources.Resources.Icons_Land_Vista_People_Groups_Military_Personnel_Light_128
        Me.Clientbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Clientbtn.Location = New System.Drawing.Point(731, 12)
        Me.Clientbtn.Name = "Clientbtn"
        Me.Clientbtn.Size = New System.Drawing.Size(199, 161)
        Me.Clientbtn.TabIndex = 14
        Me.Clientbtn.Text = "Clients"
        Me.Clientbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Clientbtn.UseVisualStyleBackColor = true
        '
        'Caissebtn
        '
        Me.Caissebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Caissebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Caissebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Caissebtn.Image = Global.CantineTest.My.Resources.Resources.Aha_Soft_Universal_Shop_Cash_register_128
        Me.Caissebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Caissebtn.Location = New System.Drawing.Point(1209, 12)
        Me.Caissebtn.Name = "Caissebtn"
        Me.Caissebtn.Size = New System.Drawing.Size(199, 161)
        Me.Caissebtn.TabIndex = 16
        Me.Caissebtn.Text = "Cash Register"
        Me.Caissebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Caissebtn.UseVisualStyleBackColor = true
        '
        'Usersbtn
        '
        Me.Usersbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Usersbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Usersbtn.Image = Global.CantineTest.My.Resources.Resources.Dario_Arnaez_Genesis_3G_User_Files_128
        Me.Usersbtn.Location = New System.Drawing.Point(968, 12)
        Me.Usersbtn.Name = "Usersbtn"
        Me.Usersbtn.Size = New System.Drawing.Size(199, 161)
        Me.Usersbtn.TabIndex = 15
        Me.Usersbtn.Text = "Users"
        Me.Usersbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Usersbtn.UseVisualStyleBackColor = true
        '
        'CloseAppbutton
        '
        Me.CloseAppbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseAppbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseAppbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CloseAppbutton.Image = Global.CantineTest.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close_96
        Me.CloseAppbutton.Location = New System.Drawing.Point(604, 234)
        Me.CloseAppbutton.Name = "CloseAppbutton"
        Me.CloseAppbutton.Size = New System.Drawing.Size(199, 161)
        Me.CloseAppbutton.TabIndex = 17
        Me.CloseAppbutton.Text = "Close"
        Me.CloseAppbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CloseAppbutton.UseVisualStyleBackColor = true
        '
        'Inventorybutton
        '
        Me.Inventorybutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inventorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Inventorybutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Inventorybutton.Image = Global.CantineTest.My.Resources.Resources.box_open_icon_barcode_128X128
        Me.Inventorybutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Inventorybutton.Location = New System.Drawing.Point(250, 12)
        Me.Inventorybutton.Name = "Inventorybutton"
        Me.Inventorybutton.Size = New System.Drawing.Size(199, 161)
        Me.Inventorybutton.TabIndex = 12
        Me.Inventorybutton.Text = "Inventory"
        Me.Inventorybutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Inventorybutton.UseVisualStyleBackColor = true
        '
        'Checkoutbtn
        '
        Me.Checkoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Checkoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Checkoutbtn.Image = Global.CantineTest.My.Resources.Resources.Aha_Soft_Large_Business_Cash_register_128__1_
        Me.Checkoutbtn.Location = New System.Drawing.Point(12, 12)
        Me.Checkoutbtn.Name = "Checkoutbtn"
        Me.Checkoutbtn.Size = New System.Drawing.Size(199, 161)
        Me.Checkoutbtn.TabIndex = 11
        Me.Checkoutbtn.Text = "Checkout"
        Me.Checkoutbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Checkoutbtn.UseVisualStyleBackColor = true
        '
        'StockTakingbtn
        '
        Me.StockTakingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StockTakingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StockTakingbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.StockTakingbtn.Image = Global.CantineTest.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Inventory_maintenance4
        Me.StockTakingbtn.Location = New System.Drawing.Point(491, 12)
        Me.StockTakingbtn.Name = "StockTakingbtn"
        Me.StockTakingbtn.Size = New System.Drawing.Size(199, 161)
        Me.StockTakingbtn.TabIndex = 13
        Me.StockTakingbtn.Text = "Stocktaking"
        Me.StockTakingbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StockTakingbtn.UseVisualStyleBackColor = true
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1420, 426)
        Me.Controls.Add(Me.Clientbtn)
        Me.Controls.Add(Me.Caissebtn)
        Me.Controls.Add(Me.Usersbtn)
        Me.Controls.Add(Me.CloseAppbutton)
        Me.Controls.Add(Me.Inventorybutton)
        Me.Controls.Add(Me.Checkoutbtn)
        Me.Controls.Add(Me.StockTakingbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Checkoutbtn As Button
    Friend WithEvents StockTakingbtn As Button
    Friend WithEvents Inventorybutton As Button
    Friend WithEvents CloseAppbutton As Button
    Friend WithEvents Usersbtn As Button
    Friend WithEvents Caissebtn As Button
    Friend WithEvents Clientbtn As Button
End Class
