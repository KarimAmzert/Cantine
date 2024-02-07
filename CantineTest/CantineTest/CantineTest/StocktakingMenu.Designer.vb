<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocktakingMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StocktakingMenu))
        Me.CountSheetbtn = New System.Windows.Forms.Button()
        Me.Adjustbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'CountSheetbtn
        '
        Me.CountSheetbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CountSheetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CountSheetbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CountSheetbtn.Image = Global.CantineTest.My.Resources.Resources.Hopstarter_Soft_Scraps_Adobe_PDF_Document_72
        Me.CountSheetbtn.Location = New System.Drawing.Point(316, 74)
        Me.CountSheetbtn.Name = "CountSheetbtn"
        Me.CountSheetbtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CountSheetbtn.Size = New System.Drawing.Size(156, 133)
        Me.CountSheetbtn.TabIndex = 11
        Me.CountSheetbtn.Text = "Count Sheet"
        Me.CountSheetbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CountSheetbtn.UseVisualStyleBackColor = true
        '
        'Adjustbtn
        '
        Me.Adjustbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adjustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Adjustbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Adjustbtn.Image = Global.CantineTest.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Inventory_maintenance_64
        Me.Adjustbtn.Location = New System.Drawing.Point(59, 74)
        Me.Adjustbtn.Name = "Adjustbtn"
        Me.Adjustbtn.Size = New System.Drawing.Size(156, 133)
        Me.Adjustbtn.TabIndex = 10
        Me.Adjustbtn.Text = "Adjust Qty"
        Me.Adjustbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Adjustbtn.UseVisualStyleBackColor = true
        '
        'StocktakingMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 278)
        Me.Controls.Add(Me.CountSheetbtn)
        Me.Controls.Add(Me.Adjustbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(550, 317)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(550, 317)
        Me.Name = "StocktakingMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stocktaking"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Adjustbtn As Button
    Friend WithEvents CountSheetbtn As Button
End Class
