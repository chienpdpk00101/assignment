<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.lblmasanpham = New System.Windows.Forms.Label()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.lblmaloaisanpham = New System.Windows.Forms.Label()
        Me.txtmaloaisanpham = New System.Windows.Forms.TextBox()
        Me.lblsanpham = New System.Windows.Forms.Label()
        Me.txttensanpham = New System.Windows.Forms.TextBox()
        Me.lblgia = New System.Windows.Forms.Label()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvdanhsach = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmasanpham
        '
        Me.lblmasanpham.AutoSize = True
        Me.lblmasanpham.Location = New System.Drawing.Point(21, 26)
        Me.lblmasanpham.Name = "lblmasanpham"
        Me.lblmasanpham.Size = New System.Drawing.Size(74, 13)
        Me.lblmasanpham.TabIndex = 2
        Me.lblmasanpham.Text = "Mã Sản Phẩm"
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(135, 22)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(134, 20)
        Me.txtmasanpham.TabIndex = 3
        '
        'lblmaloaisanpham
        '
        Me.lblmaloaisanpham.AutoSize = True
        Me.lblmaloaisanpham.Location = New System.Drawing.Point(21, 70)
        Me.lblmaloaisanpham.Name = "lblmaloaisanpham"
        Me.lblmaloaisanpham.Size = New System.Drawing.Size(97, 13)
        Me.lblmaloaisanpham.TabIndex = 2
        Me.lblmaloaisanpham.Text = "Mã Loại Sản Phẩm"
        '
        'txtmaloaisanpham
        '
        Me.txtmaloaisanpham.Location = New System.Drawing.Point(135, 67)
        Me.txtmaloaisanpham.Name = "txtmaloaisanpham"
        Me.txtmaloaisanpham.Size = New System.Drawing.Size(134, 20)
        Me.txtmaloaisanpham.TabIndex = 3
        '
        'lblsanpham
        '
        Me.lblsanpham.AutoSize = True
        Me.lblsanpham.Location = New System.Drawing.Point(21, 119)
        Me.lblsanpham.Name = "lblsanpham"
        Me.lblsanpham.Size = New System.Drawing.Size(78, 13)
        Me.lblsanpham.TabIndex = 2
        Me.lblsanpham.Text = "Tên Sản Phẩm"
        '
        'txttensanpham
        '
        Me.txttensanpham.Location = New System.Drawing.Point(135, 116)
        Me.txttensanpham.Name = "txttensanpham"
        Me.txttensanpham.Size = New System.Drawing.Size(134, 20)
        Me.txttensanpham.TabIndex = 3
        '
        'lblgia
        '
        Me.lblgia.AutoSize = True
        Me.lblgia.Location = New System.Drawing.Point(21, 165)
        Me.lblgia.Name = "lblgia"
        Me.lblgia.Size = New System.Drawing.Size(23, 13)
        Me.lblgia.TabIndex = 2
        Me.lblgia.Text = "Giá"
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(135, 165)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(134, 20)
        Me.txtgia.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblsanpham)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.lblgia)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.txttensanpham)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.lblmasanpham)
        Me.GroupBox1.Controls.Add(Me.txtmaloaisanpham)
        Me.GroupBox1.Controls.Add(Me.txtmasanpham)
        Me.GroupBox1.Controls.Add(Me.lblmaloaisanpham)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 206)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'lsvdanhsach
        '
        Me.lsvdanhsach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvdanhsach.FullRowSelect = True
        Me.lsvdanhsach.GridLines = True
        Me.lsvdanhsach.Location = New System.Drawing.Point(22, 249)
        Me.lsvdanhsach.Name = "lsvdanhsach"
        Me.lsvdanhsach.Size = New System.Drawing.Size(585, 199)
        Me.lsvdanhsach.TabIndex = 24
        Me.lsvdanhsach.UseCompatibleStateImageBehavior = False
        Me.lsvdanhsach.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã sản phẩm"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã loại sản phẩm"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên sản phẩm"
        Me.ColumnHeader3.Width = 145
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Giá"
        Me.ColumnHeader4.Width = 172
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.SystemColors.Control
        Me.btnthem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnthem.Image = Global.QLSanPham.My.Resources.Resources._1425218590_insert_object4
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(318, 22)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(74, 43)
        Me.btnthem.TabIndex = 0
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.QLSanPham.My.Resources.Resources._1425234288_Remove
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(318, 78)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(74, 43)
        Me.btnxoa.TabIndex = 0
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Image = Global.QLSanPham.My.Resources.Resources._1425234381_configuration_1
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsua.Location = New System.Drawing.Point(318, 142)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(74, 43)
        Me.btnsua.TabIndex = 0
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 467)
        Me.Controls.Add(Me.lsvdanhsach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmsanpham"
        Me.Text = "Sản Phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents lblmasanpham As System.Windows.Forms.Label
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblmaloaisanpham As System.Windows.Forms.Label
    Friend WithEvents txtmaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblsanpham As System.Windows.Forms.Label
    Friend WithEvents txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblgia As System.Windows.Forms.Label
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvdanhsach As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
