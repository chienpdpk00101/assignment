Imports System.Data
Imports System.Data.SqlClient
Public Class frmchitiethoadon
    Dim ketnoidulieu As New SqlConnection("Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=chienpdpk00101_Assignment;Integrated Security=True")
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select * from ChiTietHoaDon", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lsvdanhsach.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lsvdanhsach.Items.Add(hang("MaChiTietHoaDon").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("MaHoaDon").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("MaSanPham").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("SoLuong").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("Gia").ToString())
            i += 1
        Next
    End Sub

    Private Sub frmchitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try
            ketnoidulieu.Open()
            Dim MaChiTietHoaDon As String = txtmachitiethoadon.Text
            Dim MaHoaDon As String = txtmahoadon.Text
            Dim MaSanPham As String = txtmasanpham.Text
            Dim SoLuong As String = txtsoluong.Text
            Dim Gia As String = txtgia.Text
            Dim truyvan1 As New SqlCommand("insert into ChiTietHoaDon values (N'" + MaHoaDon + "',N'" + MaSanPham + "', N'" + SoLuong + "', N'" + Gia + "')", ketnoidulieu)
            truyvan1.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsvdanhsach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvdanhsach.SelectedIndexChanged
        For Each List As ListViewItem In lsvdanhsach.SelectedItems
            txtmachitiethoadon.Text = List.SubItems(0).Text
            txtmahoadon.Text = List.SubItems(1).Text
            txtmasanpham.Text = List.SubItems(2).Text
            txtsoluong.Text = List.SubItems(3).Text
            txtgia.Text = List.SubItems(4).Text
        Next
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            ketnoidulieu.Open()
            Dim MaChiTietHoaDon As String = txtmachitiethoadon.Text
            Dim MaHoaDon As String = txtmahoadon.Text
            Dim MaSanPham As String = txtmasanpham.Text
            Dim SoLuong As String = txtsoluong.Text
            Dim Gia As String = txtgia.Text
            Dim truyvan2 As New SqlCommand("Update ChiTietHoaDon set MaHoaDon='" + MaHoaDon + "',MaSanPham='" + MaSanPham + "',Soluong='" + SoLuong + "',Gia='" + Gia + "' where MaChiTietHoaDon='" + MaChiTietHoaDon + "'", ketnoidulieu)
            truyvan2.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtmachitiethoadon.Text
            Dim truyvan1 As New SqlCommand("delete from ChiTietHoaDon where MaChiTietHoaDon = '" + ID + "'", ketnoidulieu)
            truyvan1.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class