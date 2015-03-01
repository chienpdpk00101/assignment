<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethoadon
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
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txtmachitiethoadon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblsoluong = New System.Windows.Forms.Label()
        Me.lblmasanpham = New System.Windows.Forms.Label()
        Me.lblmahoadon = New System.Windows.Forms.Label()
        Me.lblmachitiethoadon = New System.Windows.Forms.Label()
        Me.lblgia = New System.Windows.Forms.Label()
        Me.lsvdanhsach = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(146, 195)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(136, 20)
        Me.txtgia.TabIndex = 11
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(146, 151)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(136, 20)
        Me.txtsoluong.TabIndex = 12
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(146, 107)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(136, 20)
        Me.txtmasanpham.TabIndex = 13
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(146, 64)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(136, 20)
        Me.txtmahoadon.TabIndex = 14
        '
        'txtmachitiethoadon
        '
        Me.txtmachitiethoadon.Location = New System.Drawing.Point(146, 24)
        Me.txtmachitiethoadon.Name = "txtmachitiethoadon"
        Me.txtmachitiethoadon.Size = New System.Drawing.Size(136, 20)
        Me.txtmachitiethoadon.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-82, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Giá"
        '
        'lblsoluong
        '
        Me.lblsoluong.AutoSize = True
        Me.lblsoluong.Location = New System.Drawing.Point(25, 153)
        Me.lblsoluong.Name = "lblsoluong"
        Me.lblsoluong.Size = New System.Drawing.Size(49, 13)
        Me.lblsoluong.TabIndex = 8
        Me.lblsoluong.Text = "Số lượng"
        '
        'lblmasanpham
        '
        Me.lblmasanpham.AutoSize = True
        Me.lblmasanpham.Location = New System.Drawing.Point(25, 109)
        Me.lblmasanpham.Name = "lblmasanpham"
        Me.lblmasanpham.Size = New System.Drawing.Size(74, 13)
        Me.lblmasanpham.TabIndex = 9
        Me.lblmasanpham.Text = "Mã Sản Phẩm"
        '
        'lblmahoadon
        '
        Me.lblmahoadon.AutoSize = True
        Me.lblmahoadon.Location = New System.Drawing.Point(25, 67)
        Me.lblmahoadon.Name = "lblmahoadon"
        Me.lblmahoadon.Size = New System.Drawing.Size(65, 13)
        Me.lblmahoadon.TabIndex = 10
        Me.lblmahoadon.Text = "Mã hóa đơn"
        '
        'lblmachitiethoadon
        '
        Me.lblmachitiethoadon.AutoSize = True
        Me.lblmachitiethoadon.Location = New System.Drawing.Point(25, 27)
        Me.lblmachitiethoadon.Name = "lblmachitiethoadon"
        Me.lblmachitiethoadon.Size = New System.Drawing.Size(99, 13)
        Me.lblmachitiethoadon.TabIndex = 6
        Me.lblmachitiethoadon.Text = "Mã chi tiết hóa đơn"
        '
        'lblgia
        '
        Me.lblgia.AutoSize = True
        Me.lblgia.Location = New System.Drawing.Point(25, 198)
        Me.lblgia.Name = "lblgia"
        Me.lblgia.Size = New System.Drawing.Size(23, 13)
        Me.lblgia.TabIndex = 19
        Me.lblgia.Text = "Giá"
        '
        'lsvdanhsach
        '
        Me.lsvdanhsach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvdanhsach.FullRowSelect = True
        Me.lsvdanhsach.GridLines = True
        Me.lsvdanhsach.Location = New System.Drawing.Point(20, 281)
        Me.lsvdanhsach.Name = "lsvdanhsach"
        Me.lsvdanhsach.Size = New System.Drawing.Size(585, 199)
        Me.lsvdanhsach.TabIndex = 20
        Me.lsvdanhsach.UseCompatibleStateImageBehavior = False
        Me.lsvdanhsach.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã chi tiết hóa đơn"
        Me.ColumnHeader1.Width = 137
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã hóa đơn"
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mã sản phẩm"
        Me.ColumnHeader3.Width = 115
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Số lượng"
        Me.ColumnHeader4.Width = 92
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Giá"
        Me.ColumnHeader5.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.lblmachitiethoadon)
        Me.GroupBox1.Controls.Add(Me.lblgia)
        Me.GroupBox1.Controls.Add(Me.lblmahoadon)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.lblmasanpham)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.lblsoluong)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.txtmachitiethoadon)
        Me.GroupBox1.Controls.Add(Me.txtmahoadon)
        Me.GroupBox1.Controls.Add(Me.txtsoluong)
        Me.GroupBox1.Controls.Add(Me.txtmasanpham)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 236)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'btnsua
        '
        Me.btnsua.Image = Global.QLSanPham.My.Resources.Resources._1425234381_configuration_12
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsua.Location = New System.Drawing.Point(328, 155)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(76, 43)
        Me.btnsua.TabIndex = 16
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.QLSanPham.My.Resources.Resources._1425234288_Remove2
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(328, 89)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(76, 43)
        Me.btnxoa.TabIndex = 17
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Image = Global.QLSanPham.My.Resources.Resources._1425218590_insert_object43
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(328, 25)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(76, 43)
        Me.btnthem.TabIndex = 18
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'frmchitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lsvdanhsach)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmchitiethoadon"
        Me.Text = "ChiTietHoaDon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtmachitiethoadon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsoluong As System.Windows.Forms.Label
    Friend WithEvents lblmasanpham As System.Windows.Forms.Label
    Friend WithEvents lblmahoadon As System.Windows.Forms.Label
    Friend WithEvents lblmachitiethoadon As System.Windows.Forms.Label
    Friend WithEvents lblgia As System.Windows.Forms.Label
    Friend WithEvents lsvdanhsach As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
