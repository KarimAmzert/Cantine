<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clients))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RecordCountLabel = New System.Windows.Forms.Label()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.NewUserbutton = New System.Windows.Forms.Button()
        Me.EditUserbutton = New System.Windows.Forms.Button()
        Me.NameFilterSearch = New System.Windows.Forms.TextBox()
        Me.SearchPictureBox = New System.Windows.Forms.PictureBox()
        Me.Creditbutton = New System.Windows.Forms.Button()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.SearchPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgData, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7561!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2439!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1429, 857)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 36
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321!))
        Me.TableLayoutPanel2.Controls.Add(Me.RecordCountLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Refreshbtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NewUserbutton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.EditUserbutton, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NameFilterSearch, 35, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SearchPictureBox, 34, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Creditbutton, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1423, 120)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'RecordCountLabel
        '
        Me.RecordCountLabel.AutoSize = true
        Me.RecordCountLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.RecordCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RecordCountLabel.Location = New System.Drawing.Point(3, 93)
        Me.RecordCountLabel.Name = "RecordCountLabel"
        Me.RecordCountLabel.Size = New System.Drawing.Size(61, 27)
        Me.RecordCountLabel.TabIndex = 13
        Me.RecordCountLabel.Text = "Products :"
        Me.RecordCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Refreshbtn
        '
        Me.Refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Refreshbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Refreshbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Refreshbtn.Image = Global.CantineTest.My.Resources.Resources.Actions_view_refresh_icon_48x48
        Me.Refreshbtn.Location = New System.Drawing.Point(3, 3)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(97, 87)
        Me.Refreshbtn.TabIndex = 14
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Refreshbtn.UseVisualStyleBackColor = true
        '
        'NewUserbutton
        '
        Me.NewUserbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewUserbutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewUserbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.NewUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewUserbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.NewUserbutton.Image = Global.CantineTest.My.Resources.Resources.asd
        Me.NewUserbutton.Location = New System.Drawing.Point(106, 3)
        Me.NewUserbutton.Name = "NewUserbutton"
        Me.NewUserbutton.Size = New System.Drawing.Size(97, 87)
        Me.NewUserbutton.TabIndex = 1
        Me.NewUserbutton.Text = "New Client"
        Me.NewUserbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NewUserbutton.UseVisualStyleBackColor = true
        '
        'EditUserbutton
        '
        Me.EditUserbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditUserbutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditUserbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.EditUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditUserbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.EditUserbutton.Image = Global.CantineTest.My.Resources.Resources.Icons_Land_Vista_People_Office_Client_Male_Light_48new
        Me.EditUserbutton.Location = New System.Drawing.Point(209, 3)
        Me.EditUserbutton.Name = "EditUserbutton"
        Me.EditUserbutton.Size = New System.Drawing.Size(97, 87)
        Me.EditUserbutton.TabIndex = 2
        Me.EditUserbutton.Text = "Edit Client"
        Me.EditUserbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditUserbutton.UseVisualStyleBackColor = true
        '
        'NameFilterSearch
        '
        Me.NameFilterSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameFilterSearch.Location = New System.Drawing.Point(1098, 96)
        Me.NameFilterSearch.Name = "NameFilterSearch"
        Me.NameFilterSearch.Size = New System.Drawing.Size(322, 20)
        Me.NameFilterSearch.TabIndex = 4
        Me.NameFilterSearch.Text = "SEARCH BY FIRST/LAST NAME"
        '
        'SearchPictureBox
        '
        Me.SearchPictureBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchPictureBox.Image = Global.CantineTest.My.Resources.Resources.Gakuseisean_Ivista_2_Start_Menu_Search_24
        Me.SearchPictureBox.Location = New System.Drawing.Point(1066, 96)
        Me.SearchPictureBox.Name = "SearchPictureBox"
        Me.SearchPictureBox.Size = New System.Drawing.Size(26, 21)
        Me.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SearchPictureBox.TabIndex = 46
        Me.SearchPictureBox.TabStop = false
        '
        'Creditbutton
        '
        Me.Creditbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Creditbutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Creditbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Creditbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Creditbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Creditbutton.Image = Global.CantineTest.My.Resources.Resources.Double_J_Design_Ravenna_3d_Credit_Card_48
        Me.Creditbutton.Location = New System.Drawing.Point(312, 3)
        Me.Creditbutton.Name = "Creditbutton"
        Me.Creditbutton.Size = New System.Drawing.Size(97, 87)
        Me.Creditbutton.TabIndex = 3
        Me.Creditbutton.Text = "Credit"
        Me.Creditbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Creditbutton.UseVisualStyleBackColor = true
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = false
        Me.dgData.AllowUserToDeleteRows = false
        Me.dgData.AllowUserToResizeColumns = false
        Me.dgData.AllowUserToResizeRows = false
        Me.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgData.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(3, 129)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = true
        Me.dgData.RowHeadersWidth = 51
        Me.dgData.Size = New System.Drawing.Size(1423, 725)
        Me.dgData.TabIndex = 2
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1429, 857)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Clients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clients"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        CType(Me.SearchPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RecordCountLabel As Label
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents NewUserbutton As Button
    Friend WithEvents EditUserbutton As Button
    Friend WithEvents NameFilterSearch As TextBox
    Friend WithEvents SearchPictureBox As PictureBox
    Friend WithEvents dgData As DataGridView
    Friend WithEvents Creditbutton As Button
End Class
