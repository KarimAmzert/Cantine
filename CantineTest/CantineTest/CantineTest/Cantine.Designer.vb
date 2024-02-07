<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cantine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cantine))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.NameFilterSearch = New System.Windows.Forms.TextBox()
        Me.ProductCountLabel = New System.Windows.Forms.Label()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.Adjustbtn = New System.Windows.Forms.Button()
        Me.Historybtn = New System.Windows.Forms.Button()
        Me.SearchPictureBox = New System.Windows.Forms.PictureBox()
        Me.CreateItembtn = New System.Windows.Forms.Button()
        Me.AddStockbtn = New System.Windows.Forms.Button()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.EditProductbtn = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SearchPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = true
        Me.FileSystemWatcher1.SynchronizingObject = Me
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1597, 922)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 14
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412!))
        Me.TableLayoutPanel2.Controls.Add(Me.Adjustbtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Historybtn, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NameFilterSearch, 13, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SearchPictureBox, 12, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CreateItembtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ProductCountLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.AddStockbtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Refreshbtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.EditProductbtn, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1591, 130)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'NameFilterSearch
        '
        Me.NameFilterSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameFilterSearch.Location = New System.Drawing.Point(1182, 106)
        Me.NameFilterSearch.Name = "NameFilterSearch"
        Me.NameFilterSearch.Size = New System.Drawing.Size(406, 20)
        Me.NameFilterSearch.TabIndex = 11
        Me.NameFilterSearch.Text = "SEARCH BY NAME/UPC"
        '
        'ProductCountLabel
        '
        Me.ProductCountLabel.AutoSize = true
        Me.ProductCountLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProductCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProductCountLabel.Location = New System.Drawing.Point(3, 103)
        Me.ProductCountLabel.Name = "ProductCountLabel"
        Me.ProductCountLabel.Size = New System.Drawing.Size(61, 27)
        Me.ProductCountLabel.TabIndex = 13
        Me.ProductCountLabel.Text = "Products :"
        Me.ProductCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgData.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(3, 139)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = true
        Me.dgData.RowHeadersWidth = 51
        Me.dgData.Size = New System.Drawing.Size(1591, 780)
        Me.dgData.TabIndex = 2
        '
        'Adjustbtn
        '
        Me.Adjustbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adjustbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Adjustbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Adjustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Adjustbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Adjustbtn.Image = Global.CantineTest.My.Resources.Resources.box_open_icon_barcode_48X48
        Me.Adjustbtn.Location = New System.Drawing.Point(342, 3)
        Me.Adjustbtn.Name = "Adjustbtn"
        Me.Adjustbtn.Size = New System.Drawing.Size(107, 97)
        Me.Adjustbtn.TabIndex = 3
        Me.Adjustbtn.Text = "Adjust Qty"
        Me.Adjustbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Adjustbtn.UseVisualStyleBackColor = true
        '
        'Historybtn
        '
        Me.Historybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historybtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Historybtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Historybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Historybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Historybtn.Image = Global.CantineTest.My.Resources.Resources.Clipboard_Paste_icon_48x48
        Me.Historybtn.Location = New System.Drawing.Point(455, 3)
        Me.Historybtn.Name = "Historybtn"
        Me.Historybtn.Size = New System.Drawing.Size(107, 97)
        Me.Historybtn.TabIndex = 4
        Me.Historybtn.Text = "History"
        Me.Historybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Historybtn.UseVisualStyleBackColor = true
        '
        'SearchPictureBox
        '
        Me.SearchPictureBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchPictureBox.Image = Global.CantineTest.My.Resources.Resources.Gakuseisean_Ivista_2_Start_Menu_Search_24
        Me.SearchPictureBox.Location = New System.Drawing.Point(1150, 106)
        Me.SearchPictureBox.Name = "SearchPictureBox"
        Me.SearchPictureBox.Size = New System.Drawing.Size(26, 21)
        Me.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SearchPictureBox.TabIndex = 12
        Me.SearchPictureBox.TabStop = false
        '
        'CreateItembtn
        '
        Me.CreateItembtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateItembtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateItembtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.CreateItembtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateItembtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CreateItembtn.Image = Global.CantineTest.My.Resources.Resources.Actions_tag_new_icon_48x48
        Me.CreateItembtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CreateItembtn.Location = New System.Drawing.Point(229, 3)
        Me.CreateItembtn.Name = "CreateItembtn"
        Me.CreateItembtn.Size = New System.Drawing.Size(107, 97)
        Me.CreateItembtn.TabIndex = 2
        Me.CreateItembtn.Text = "Add New Product"
        Me.CreateItembtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CreateItembtn.UseVisualStyleBackColor = true
        '
        'AddStockbtn
        '
        Me.AddStockbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddStockbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddStockbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.AddStockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddStockbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.AddStockbtn.Image = Global.CantineTest.My.Resources.Resources.fork_1_icon
        Me.AddStockbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddStockbtn.Location = New System.Drawing.Point(116, 3)
        Me.AddStockbtn.Name = "AddStockbtn"
        Me.AddStockbtn.Size = New System.Drawing.Size(107, 97)
        Me.AddStockbtn.TabIndex = 1
        Me.AddStockbtn.Text = "Receive Stock"
        Me.AddStockbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddStockbtn.UseVisualStyleBackColor = true
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
        Me.Refreshbtn.Size = New System.Drawing.Size(107, 97)
        Me.Refreshbtn.TabIndex = 0
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Refreshbtn.UseVisualStyleBackColor = true
        '
        'EditProductbtn
        '
        Me.EditProductbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditProductbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditProductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditProductbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.EditProductbtn.Image = Global.CantineTest.My.Resources.Resources.Designcontest_Ecommerce_Business_Edit_48
        Me.EditProductbtn.Location = New System.Drawing.Point(568, 3)
        Me.EditProductbtn.Name = "EditProductbtn"
        Me.EditProductbtn.Size = New System.Drawing.Size(107, 97)
        Me.EditProductbtn.TabIndex = 6
        Me.EditProductbtn.Text = "Edit Product"
        Me.EditProductbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditProductbtn.UseVisualStyleBackColor = true
        '
        'Cantine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1597, 922)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Name = "Cantine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        CType(Me.FileSystemWatcher1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SearchPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgData As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Adjustbtn As Button
    Friend WithEvents Historybtn As Button
    Friend WithEvents NameFilterSearch As TextBox
    Friend WithEvents SearchPictureBox As PictureBox
    Friend WithEvents AddStockbtn As Button
    Friend WithEvents CreateItembtn As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents ProductCountLabel As Label
    Friend WithEvents EditProductbtn As Button
End Class
