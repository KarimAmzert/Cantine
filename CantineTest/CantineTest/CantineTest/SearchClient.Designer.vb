<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchClient))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RecordCountLabel = New System.Windows.Forms.Label()
        Me.NameFilterSearch = New System.Windows.Forms.TextBox()
        Me.SearchPictureBox = New System.Windows.Forms.PictureBox()
        Me.Confirmbutton = New System.Windows.Forms.Button()
        Me.Cancelbutton = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.TabIndex = 6
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
        Me.TableLayoutPanel2.Controls.Add(Me.NameFilterSearch, 35, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SearchPictureBox, 34, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Confirmbutton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cancelbutton, 35, 0)
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
        'Confirmbutton
        '
        Me.Confirmbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirmbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Confirmbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Confirmbutton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_ok_apply_icon_48X48
        Me.Confirmbutton.Location = New System.Drawing.Point(3, 3)
        Me.Confirmbutton.Name = "Confirmbutton"
        Me.Confirmbutton.Size = New System.Drawing.Size(97, 86)
        Me.Confirmbutton.TabIndex = 1
        Me.Confirmbutton.Text = "Confirm"
        Me.Confirmbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Confirmbutton.UseVisualStyleBackColor = true
        '
        'Cancelbutton
        '
        Me.Cancelbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancelbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.Cancelbutton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x481
        Me.Cancelbutton.Location = New System.Drawing.Point(1322, 3)
        Me.Cancelbutton.Name = "Cancelbutton"
        Me.Cancelbutton.Size = New System.Drawing.Size(98, 86)
        Me.Cancelbutton.TabIndex = 2
        Me.Cancelbutton.Text = "Cancel"
        Me.Cancelbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelbutton.UseVisualStyleBackColor = true
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
        'SearchClient
        '
        Me.AcceptButton = Me.Confirmbutton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1429, 857)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SearchClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Client"
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
    Friend WithEvents NameFilterSearch As TextBox
    Friend WithEvents SearchPictureBox As PictureBox
    Friend WithEvents Confirmbutton As Button
    Friend WithEvents Cancelbutton As Button
    Friend WithEvents dgData As DataGridView
End Class
