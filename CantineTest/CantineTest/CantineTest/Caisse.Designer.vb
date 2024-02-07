<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caisse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caisse))
        Me.Adjustbtn = New System.Windows.Forms.Button()
        Me.Historybtn = New System.Windows.Forms.Button()
        Me.Transactionsbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Adjustbtn
        '
        Me.Adjustbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adjustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Adjustbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Adjustbtn.Image = Global.CantineTest.My.Resources.Resources.Aha_Soft_Universal_Shop_Cash_register_72
        Me.Adjustbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Adjustbtn.Location = New System.Drawing.Point(12, 73)
        Me.Adjustbtn.Name = "Adjustbtn"
        Me.Adjustbtn.Size = New System.Drawing.Size(139, 125)
        Me.Adjustbtn.TabIndex = 6
        Me.Adjustbtn.Text = "Adjust Cash Register"
        Me.Adjustbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Adjustbtn.UseVisualStyleBackColor = true
        '
        'Historybtn
        '
        Me.Historybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historybtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Historybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Historybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Historybtn.Image = Global.CantineTest.My.Resources.Resources.Tribalmarkings_Aquave_Cash_Dollar_folder_72
        Me.Historybtn.Location = New System.Drawing.Point(380, 73)
        Me.Historybtn.Name = "Historybtn"
        Me.Historybtn.Size = New System.Drawing.Size(142, 125)
        Me.Historybtn.TabIndex = 8
        Me.Historybtn.Text = "History"
        Me.Historybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Historybtn.UseVisualStyleBackColor = true
        '
        'Transactionsbtn
        '
        Me.Transactionsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transactionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Transactionsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Transactionsbtn.Image = Global.CantineTest.My.Resources.Resources.Designcontest_Ecommerce_Business_Invoice_72
        Me.Transactionsbtn.Location = New System.Drawing.Point(198, 73)
        Me.Transactionsbtn.Name = "Transactionsbtn"
        Me.Transactionsbtn.Size = New System.Drawing.Size(139, 125)
        Me.Transactionsbtn.TabIndex = 7
        Me.Transactionsbtn.Text = "Transactions"
        Me.Transactionsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Transactionsbtn.UseVisualStyleBackColor = true
        '
        'Caisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 278)
        Me.Controls.Add(Me.Adjustbtn)
        Me.Controls.Add(Me.Historybtn)
        Me.Controls.Add(Me.Transactionsbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(550, 317)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(550, 317)
        Me.Name = "Caisse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Register"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Transactionsbtn As Button
    Friend WithEvents Historybtn As Button
    Friend WithEvents Adjustbtn As Button
End Class
