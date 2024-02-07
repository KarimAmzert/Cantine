<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceDetails))
        Me.ClientNameLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.CashLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CreditLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ClientNameLabel
        '
        Me.ClientNameLabel.AutoSize = true
        Me.ClientNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ClientNameLabel.Location = New System.Drawing.Point(39, 14)
        Me.ClientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClientNameLabel.Name = "ClientNameLabel"
        Me.ClientNameLabel.Size = New System.Drawing.Size(98, 20)
        Me.ClientNameLabel.TabIndex = 30
        Me.ClientNameLabel.Text = "Client name"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = true
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DateLabel.Location = New System.Drawing.Point(39, 36)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(45, 20)
        Me.DateLabel.TabIndex = 29
        Me.DateLabel.Text = "Date"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = true
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(567, 535)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(76, 29)
        Me.TotalLabel.TabIndex = 28
        Me.TotalLabel.Text = "$0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 535)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "TOTAL:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgData)
        Me.Panel1.Location = New System.Drawing.Point(43, 60)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 471)
        Me.Panel1.TabIndex = 27
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = false
        Me.dgData.AllowUserToDeleteRows = false
        Me.dgData.AllowUserToResizeColumns = false
        Me.dgData.AllowUserToResizeRows = false
        Me.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Location = New System.Drawing.Point(-1, 1)
        Me.dgData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = true
        Me.dgData.RowHeadersVisible = false
        Me.dgData.RowHeadersWidth = 51
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgData.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgData.Size = New System.Drawing.Size(609, 469)
        Me.dgData.TabIndex = 2
        '
        'CashLabel
        '
        Me.CashLabel.AutoSize = true
        Me.CashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CashLabel.Location = New System.Drawing.Point(113, 540)
        Me.CashLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CashLabel.Name = "CashLabel"
        Me.CashLabel.Size = New System.Drawing.Size(61, 25)
        Me.CashLabel.TabIndex = 32
        Me.CashLabel.Text = "$0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 542)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cash:"
        '
        'CreditLabel
        '
        Me.CreditLabel.AutoSize = true
        Me.CreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CreditLabel.Location = New System.Drawing.Point(113, 581)
        Me.CreditLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CreditLabel.Name = "CreditLabel"
        Me.CreditLabel.Size = New System.Drawing.Size(61, 25)
        Me.CreditLabel.TabIndex = 34
        Me.CreditLabel.Text = "$0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 581)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Credit:"
        '
        'InvoiceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 597)
        Me.Controls.Add(Me.CreditLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CashLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClientNameLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(711, 644)
        Me.MinimumSize = New System.Drawing.Size(711, 644)
        Me.Name = "InvoiceDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Details"
        Me.Panel1.ResumeLayout(false)
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ClientNameLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgData As DataGridView
    Friend WithEvents CashLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CreditLabel As Label
    Friend WithEvents Label5 As Label
End Class
