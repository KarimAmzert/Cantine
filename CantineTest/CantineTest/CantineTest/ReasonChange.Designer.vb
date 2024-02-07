<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReasonChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReasonChange))
        Me.ReasonListComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout
        '
        'ReasonListComboBox
        '
        Me.ReasonListComboBox.FormattingEnabled = true
        Me.ReasonListComboBox.Items.AddRange(New Object() {"Liquidation", "Out of date", "Free Shirt"})
        Me.ReasonListComboBox.Location = New System.Drawing.Point(109, 124)
        Me.ReasonListComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReasonListComboBox.Name = "ReasonListComboBox"
        Me.ReasonListComboBox.Size = New System.Drawing.Size(160, 24)
        Me.ReasonListComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(27, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unit Price change detected for :"
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = true
        Me.ProductNameLabel.Location = New System.Drawing.Point(237, 43)
        Me.ProductNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(96, 17)
        Me.ProductNameLabel.TabIndex = 2
        Me.ProductNameLabel.Text = "Product name"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(136, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select a reason :"
        '
        'OKButton
        '
        Me.OKButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKButton.Location = New System.Drawing.Point(140, 194)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(100, 28)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 238)
        Me.Panel1.TabIndex = 5
        '
        'ReasonChange
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 241)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReasonListComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(368, 241)
        Me.MinimumSize = New System.Drawing.Size(368, 241)
        Me.Name = "ReasonChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select reason for price change"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ReasonListComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents Panel1 As Panel
End Class
