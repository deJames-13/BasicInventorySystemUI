<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindowPage1
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
        Me.WindowPanel = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNewInvent = New System.Windows.Forms.Button()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PageContainer = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.inventName = New System.Windows.Forms.Label()
        Me.dtInvent = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WindowPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.PageContainer.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dtInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowPanel
        '
        Me.WindowPanel.Controls.Add(Me.Panel6)
        Me.WindowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowPanel.Location = New System.Drawing.Point(0, 0)
        Me.WindowPanel.Name = "WindowPanel"
        Me.WindowPanel.Size = New System.Drawing.Size(812, 461)
        Me.WindowPanel.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel22)
        Me.Panel6.Controls.Add(Me.PageContainer)
        Me.Panel6.Controls.Add(Me.Panel17)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(812, 461)
        Me.Panel6.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnNewInvent)
        Me.Panel4.Location = New System.Drawing.Point(681, 52)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(120, 39)
        Me.Panel4.TabIndex = 9
        '
        'btnNewInvent
        '
        Me.btnNewInvent.BackColor = System.Drawing.Color.LightBlue
        Me.btnNewInvent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNewInvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnNewInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewInvent.Location = New System.Drawing.Point(5, 5)
        Me.btnNewInvent.Name = "btnNewInvent"
        Me.btnNewInvent.Size = New System.Drawing.Size(110, 29)
        Me.btnNewInvent.TabIndex = 0
        Me.btnNewInvent.Text = "New Inventory"
        Me.btnNewInvent.UseVisualStyleBackColor = False
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.btnSearch)
        Me.Panel22.Controls.Add(Me.txtSearch)
        Me.Panel22.Location = New System.Drawing.Point(5, 61)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel22.Size = New System.Drawing.Size(367, 30)
        Me.Panel22.TabIndex = 8
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightBlue
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(3, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 24)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Azure
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(87, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Enter an ID"
        Me.txtSearch.Size = New System.Drawing.Size(277, 22)
        Me.txtSearch.TabIndex = 3
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageContainer.Controls.Add(Me.Panel3)
        Me.PageContainer.Controls.Add(Me.Panel2)
        Me.PageContainer.Controls.Add(Me.Panel1)
        Me.PageContainer.Controls.Add(Me.Panel13)
        Me.PageContainer.Controls.Add(Me.Panel19)
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PageContainer.Location = New System.Drawing.Point(5, 94)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.PageContainer.Size = New System.Drawing.Size(800, 360)
        Me.PageContainer.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Location = New System.Drawing.Point(549, 295)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(120, 50)
        Me.Panel3.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(5, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 40)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Location = New System.Drawing.Point(409, 295)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(120, 50)
        Me.Panel2.TabIndex = 9
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightBlue
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(5, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 40)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update Item"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRead)
        Me.Panel1.Location = New System.Drawing.Point(269, 295)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(120, 50)
        Me.Panel1.TabIndex = 8
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.LightBlue
        Me.btnRead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRead.Location = New System.Drawing.Point(5, 5)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(110, 40)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "Read Item"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.btnCreate)
        Me.Panel13.Location = New System.Drawing.Point(129, 295)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel13.Size = New System.Drawing.Size(120, 50)
        Me.Panel13.TabIndex = 7
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.LightBlue
        Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Location = New System.Drawing.Point(5, 5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(110, 40)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Item"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(5, 5)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel19.Size = New System.Drawing.Size(788, 270)
        Me.Panel19.TabIndex = 4
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Panel5)
        Me.Panel20.Controls.Add(Me.dtInvent)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(5, 5)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(776, 258)
        Me.Panel20.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.inventName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel5.Size = New System.Drawing.Size(776, 30)
        Me.Panel5.TabIndex = 2
        '
        'inventName
        '
        Me.inventName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.inventName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.inventName.Location = New System.Drawing.Point(3, 3)
        Me.inventName.Name = "inventName"
        Me.inventName.Size = New System.Drawing.Size(770, 24)
        Me.inventName.TabIndex = 0
        Me.inventName.Text = "Inventory Name: "
        Me.inventName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtInvent
        '
        Me.dtInvent.AllowUserToAddRows = False
        Me.dtInvent.AllowUserToDeleteRows = False
        Me.dtInvent.AllowUserToResizeColumns = False
        Me.dtInvent.AllowUserToResizeRows = False
        Me.dtInvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtInvent.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtInvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtInvent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dtInvent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtInvent.Location = New System.Drawing.Point(0, 30)
        Me.dtInvent.Name = "dtInvent"
        Me.dtInvent.ReadOnly = True
        Me.dtInvent.RowTemplate.Height = 25
        Me.dtInvent.Size = New System.Drawing.Size(776, 228)
        Me.dtInvent.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Transparent
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.Label1)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel17.Location = New System.Drawing.Point(5, 5)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel17.Size = New System.Drawing.Size(800, 40)
        Me.Panel17.TabIndex = 6
        '
        'openFile
        '
        Me.openFile.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(788, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INVENTORY MANAGEMENT FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainWindowPage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(812, 461)
        Me.Controls.Add(Me.WindowPanel)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindowPage1"
        Me.ShowIcon = False
        Me.Text = "Welcome to my Form!"
        Me.WindowPanel.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.PageContainer.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dtInvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents PageContainer As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents dtInvent As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRead As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnCreate As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnNewInvent As Button
    Friend WithEvents Panel22 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents inventName As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents openFile As OpenFileDialog
    Friend WithEvents Label1 As Label
End Class
