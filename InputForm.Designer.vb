<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputForm
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
        Me.PageContainer = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paneltitel = New System.Windows.Forms.Panel()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.PageContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.paneltitel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageContainer.Controls.Add(Me.GroupBox1)
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageContainer.Location = New System.Drawing.Point(0, 0)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.PageContainer.Size = New System.Drawing.Size(384, 452)
        Me.PageContainer.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel9)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel22)
        Me.GroupBox1.Controls.Add(Me.paneltitel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(372, 440)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(20, 319)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(10, 30, 10, 30)
        Me.Panel9.Size = New System.Drawing.Size(332, 111)
        Me.Panel9.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnCancel)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(10, 30)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel10.Size = New System.Drawing.Size(120, 51)
        Me.Panel10.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightBlue
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(5, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 41)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.btnSave)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(202, 30)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel14.Size = New System.Drawing.Size(120, 51)
        Me.Panel14.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(5, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 41)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtTotal)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(20, 216)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel7.Size = New System.Drawing.Size(332, 30)
        Me.Panel7.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Azure
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(172, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(150, 23)
        Me.txtTotal.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(10, 3)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel8.Size = New System.Drawing.Size(150, 24)
        Me.Panel8.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(137, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtQuantity)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(20, 186)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel5.Size = New System.Drawing.Size(332, 30)
        Me.Panel5.TabIndex = 7
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.Azure
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtQuantity.Location = New System.Drawing.Point(172, 3)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 23)
        Me.txtQuantity.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(10, 3)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel6.Size = New System.Drawing.Size(150, 24)
        Me.Panel6.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(137, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtPrice)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(20, 156)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Size = New System.Drawing.Size(332, 30)
        Me.Panel3.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Azure
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtPrice.Location = New System.Drawing.Point(172, 3)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(150, 23)
        Me.txtPrice.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(10, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel4.Size = New System.Drawing.Size(150, 24)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 126)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel1.Size = New System.Drawing.Size(332, 30)
        Me.Panel1.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Azure
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtName.Location = New System.Drawing.Point(172, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 23)
        Me.txtName.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(10, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel2.Size = New System.Drawing.Size(150, 24)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.txtID)
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(20, 96)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel22.Size = New System.Drawing.Size(332, 30)
        Me.Panel22.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Azure
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtID.Location = New System.Drawing.Point(172, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(150, 23)
        Me.txtID.TabIndex = 3
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Label2)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(10, 3)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel23.Size = New System.Drawing.Size(150, 24)
        Me.Panel23.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'paneltitel
        '
        Me.paneltitel.Controls.Add(Me.labelTitle)
        Me.paneltitel.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltitel.Location = New System.Drawing.Point(20, 26)
        Me.paneltitel.Margin = New System.Windows.Forms.Padding(10)
        Me.paneltitel.Name = "paneltitel"
        Me.paneltitel.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.paneltitel.Size = New System.Drawing.Size(332, 70)
        Me.paneltitel.TabIndex = 2
        '
        'labelTitle
        '
        Me.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelTitle.Font = New System.Drawing.Font("Arial", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labelTitle.Location = New System.Drawing.Point(10, 20)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(312, 30)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Title"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.PageContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "InputForm"
        Me.Text = "Input Form"
        Me.PageContainer.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.paneltitel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents PageContainer As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents paneltitel As Panel
    Friend WithEvents labelTitle As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnCancel As Button
End Class
