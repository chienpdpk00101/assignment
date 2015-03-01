<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsanpham = New System.Windows.Forms.Button()
        Me.btnchitiethoadon = New System.Windows.Forms.Button()
        Me.btnhoadon = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLSanPham.My.Resources.Resources._55356875_1296651481_hoa_co_mua_xuan_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(422, 279)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnsanpham
        '
        Me.btnsanpham.Location = New System.Drawing.Point(53, 159)
        Me.btnsanpham.Name = "btnsanpham"
        Me.btnsanpham.Size = New System.Drawing.Size(102, 57)
        Me.btnsanpham.TabIndex = 1
        Me.btnsanpham.Text = "Sản Phẩm"
        Me.btnsanpham.UseVisualStyleBackColor = True
        '
        'btnchitiethoadon
        '
        Me.btnchitiethoadon.Location = New System.Drawing.Point(172, 159)
        Me.btnchitiethoadon.Name = "btnchitiethoadon"
        Me.btnchitiethoadon.Size = New System.Drawing.Size(102, 57)
        Me.btnchitiethoadon.TabIndex = 1
        Me.btnchitiethoadon.Text = "Chi tiết hóa đơn"
        Me.btnchitiethoadon.UseVisualStyleBackColor = True
        '
        'btnhoadon
        '
        Me.btnhoadon.Location = New System.Drawing.Point(295, 159)
        Me.btnhoadon.Name = "btnhoadon"
        Me.btnhoadon.Size = New System.Drawing.Size(103, 57)
        Me.btnhoadon.TabIndex = 1
        Me.btnhoadon.Text = "Hóa đơn"
        Me.btnhoadon.UseVisualStyleBackColor = True
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(446, 303)
        Me.Controls.Add(Me.btnhoadon)
        Me.Controls.Add(Me.btnchitiethoadon)
        Me.Controls.Add(Me.btnsanpham)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmmenu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnsanpham As System.Windows.Forms.Button
    Friend WithEvents btnchitiethoadon As System.Windows.Forms.Button
    Friend WithEvents btnhoadon As System.Windows.Forms.Button
End Class
