<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewClient))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RankListComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(159, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 15)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "New Client Information"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(127, 423)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(10, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(156, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "First Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(135, 14)
        Me.FirstNameTextBox.MaxLength = 50
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(206, 30)
        Me.FirstNameTextBox.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RankListComboBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MatriculeTextBox)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(146, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 258)
        Me.Panel1.TabIndex = 53
        '
        'RankListComboBox
        '
        Me.RankListComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RankListComboBox.FormattingEnabled = true
        Me.RankListComboBox.Items.AddRange(New Object() {"Civ", "Cpl", "MCpl", "Sgt", "MWO", "WO", "Capt", "2Lt", "Pte", "Pte(B)", "S1", "LCdr", "Lt(N)", "PO 2", "N/A"})
        Me.RankListComboBox.Location = New System.Drawing.Point(135, 197)
        Me.RankListComboBox.Name = "RankListComboBox"
        Me.RankListComboBox.Size = New System.Drawing.Size(113, 33)
        Me.RankListComboBox.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(10, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Rank"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(10, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Matricule"
        '
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MatriculeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MatriculeTextBox.Location = New System.Drawing.Point(135, 136)
        Me.MatriculeTextBox.MaxLength = 50
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(141, 30)
        Me.MatriculeTextBox.TabIndex = 58
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(135, 73)
        Me.LastNameTextBox.MaxLength = 50
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(206, 30)
        Me.LastNameTextBox.TabIndex = 57
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.ConfirmButton.Image = Global.CantineTest.My.Resources.Resources.Actions_document_save_icon_48x48
        Me.ConfirmButton.Location = New System.Drawing.Point(146, 324)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(87, 88)
        Me.ConfirmButton.TabIndex = 45
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmButton.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CantineTest.My.Resources.Resources.Icons_Land_Vista_People_Office_Client_Male_Light_96
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.CancelButton.Image = Global.CantineTest.My.Resources.Resources.Actions_dialog_cancel_icon_48x48
        Me.CancelButton.Location = New System.Drawing.Point(423, 324)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(87, 88)
        Me.CancelButton.TabIndex = 46
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'NewClient
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 423)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "NewClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Client"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MatriculeTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RankListComboBox As ComboBox
End Class
