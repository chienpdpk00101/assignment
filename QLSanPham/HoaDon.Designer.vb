<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.lblmahoadon = New System.Windows.Forms.Label()
        Me.lblmakhachhang = New System.Windows.Forms.Label()
        Me.lblngayviethoadon = New System.Windows.Forms.Label()
        Me.lblthanhtien = New System.Windows.Forms.Label()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.txtthanhtien = New System.Windows.Forms.TextBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.lsvdanhsach = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtngayviethoadon = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmahoadon
        '
        Me.lblmahoadon.AutoSize = True
        Me.lblmahoadon.Location = New System.Drawing.Point(21, 26)
        Me.lblmahoadon.Name = "lblmahoadon"
        Me.lblmahoadon.Size = New System.Drawing.Size(65, 13)
        Me.lblmahoadon.TabIndex = 0
        Me.lblmahoadon.Text = "Mã hóa đơn"
        '
        'lblmakhachhang
        '
        Me.lblmakhachhang.AutoSize = True
        Me.lblmakhachhang.Location = New System.Drawing.Point(21, 68)
        Me.lblmakhachhang.Name = "lblmakhachhang"
        Me.lblmakhachhang.Size = New System.Drawing.Size(82, 13)
        Me.lblmakhachhang.TabIndex = 1
        Me.lblmakhachhang.Text = "Mã khách hàng"
        '
        'lblngayviethoadon
        '
        Me.lblngayviethoadon.AutoSize = True
        Me.lblngayviethoadon.Location = New System.Drawing.Point(21, 112)
        Me.lblngayviethoadon.Name = "lblngayviethoadon"
        Me.lblngayviethoadon.Size = New System.Drawing.Size(95, 13)
        Me.lblngayviethoadon.TabIndex = 1
        Me.lblngayviethoadon.Text = "Ngày viết hóa đơn"
        '
        'lblthanhtien
        '
        Me.lblthanhtien.AutoSize = True
        Me.lblthanhtien.Location = New System.Drawing.Point(21, 157)
        Me.lblthanhtien.Name = "lblthanhtien"
        Me.lblthanhtien.Size = New System.Drawing.Size(58, 13)
        Me.lblthanhtien.TabIndex = 1
        Me.lblthanhtien.Text = "Thành tiền"
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(142, 23)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(136, 20)
        Me.txtmahoadon.TabIndex = 2
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(142, 65)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(136, 20)
        Me.txtmakhachhang.TabIndex = 2
        '
        'txtthanhtien
        '
        Me.txtthanhtien.Location = New System.Drawing.Point(142, 155)
        Me.txtthanhtien.Name = "txtthanhtien"
        Me.txtthanhtien.Size = New System.Drawing.Size(136, 20)
        Me.txtthanhtien.TabIndex = 2
        '
        'btnsua
        '
        Me.btnsua.Image = Global.QLSanPham.My.Resources.Resources._1425234381_configuration_11
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsua.Location = New System.Drawing.Point(322, 142)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(76, 43)
        Me.btnsua.TabIndex = 3
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'lsvdanhsach
        '
        Me.lsvdanhsach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvdanhsach.FullRowSelect = True
        Me.lsvdanhsach.GridLines = True
        Me.lsvdanhsach.Location = New System.Drawing.Point(20, 240)
        Me.lsvdanhsach.Name = "lsvdanhsach"
        Me.lsvdanhsach.Size = New System.Drawing.Size(585, 199)
        Me.lsvdanhsach.TabIndex = 21
        Me.lsvdanhsach.UseCompatibleStateImageBehavior = False
        Me.lsvdanhsach.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã hóa đơn"
        Me.ColumnHeader1.Width = 97
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã khách hàng"
        Me.ColumnHeader2.Width = 125
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ngày viết hóa đơn"
        Me.ColumnHeader3.Width = 142
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Thành tiền"
        Me.ColumnHeader4.Width = 216
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtngayviethoadon)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.lblmahoadon)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.lblmakhachhang)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.lblngayviethoadon)
        Me.GroupBox1.Controls.Add(Me.lblthanhtien)
        Me.GroupBox1.Controls.Add(Me.txtthanhtien)
        Me.GroupBox1.Controls.Add(Me.txtmahoadon)
        Me.GroupBox1.Controls.Add(Me.txtmakhachhang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 206)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'txtngayviethoadon
        '
        Me.txtngayviethoadon.Location = New System.Drawing.Point(142, 109)
        Me.txtngayviethoadon.Name = "txtngayviethoadon"
        Me.txtngayviethoadon.Size = New System.Drawing.Size(136, 20)
        Me.txtngayviethoadon.TabIndex = 7
        '
        'btnthem
        '
        Me.btnthem.Image = Global.QLSanPham.My.Resources.Resources._1425218590_insert_object41
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(322, 23)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(76, 43)
        Me.btnthem.TabIndex = 5
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.QLSanPham.My.Resources.Resources._1425234288_Remove1
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(322, 82)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(76, 43)
        Me.btnxoa.TabIndex = 4
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 458)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lsvdanhsach)
        Me.Name = "frmhoadon"
        Me.Text = "HoaDon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblmahoadon As System.Windows.Forms.Label
    Friend WithEvents lblmakhachhang As System.Windows.Forms.Label
    Friend WithEvents lblngayviethoadon As System.Windows.Forms.Label
    Friend WithEvents lblthanhtien As System.Windows.Forms.Label
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtthanhtien As System.Windows.Forms.TextBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents lsvdanhsach As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtngayviethoadon As System.Windows.Forms.TextBox
End Class
