<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthYearFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthYearFilter))
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Filterbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'MonthComboBox
        '
        Me.MonthComboBox.FormattingEnabled = true
        Me.MonthComboBox.Location = New System.Drawing.Point(41, 61)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(82, 21)
        Me.MonthComboBox.TabIndex = 0
        Me.MonthComboBox.Text = "Month"
        '
        'YearComboBox
        '
        Me.YearComboBox.FormattingEnabled = true
        Me.YearComboBox.Location = New System.Drawing.Point(217, 61)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(82, 21)
        Me.YearComboBox.TabIndex = 1
        Me.YearComboBox.Text = "Year"
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbtn.Image = Global.CantineTest.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close_32
        Me.Cancelbtn.Location = New System.Drawing.Point(224, 121)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(75, 59)
        Me.Cancelbtn.TabIndex = 3
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbtn.UseVisualStyleBackColor = true
        '
        'Filterbtn
        '
        Me.Filterbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Filterbtn.Image = Global.CantineTest.My.Resources.Resources.Double_J_Design_Ravenna_3d_Filter_List_32
        Me.Filterbtn.Location = New System.Drawing.Point(41, 121)
        Me.Filterbtn.Name = "Filterbtn"
        Me.Filterbtn.Size = New System.Drawing.Size(75, 59)
        Me.Filterbtn.TabIndex = 2
        Me.Filterbtn.Text = "Filter"
        Me.Filterbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Filterbtn.UseVisualStyleBackColor = true
        '
        'MonthYearFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 210)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Filterbtn)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.MonthComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximumSize = New System.Drawing.Size(352, 249)
        Me.MinimumSize = New System.Drawing.Size(352, 249)
        Me.Name = "MonthYearFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Best Sellers"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents MonthComboBox As ComboBox
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents Filterbtn As Button
    Friend WithEvents Cancelbtn As Button
End Class
