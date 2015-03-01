Imports System.Data
Imports System.Data.SqlClient
Public Class frmhoadon
    Dim ketnoidulieu As New SqlConnection("Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=chienpdpk00101_Assignment;Integrated Security=True")
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select * from HoaDon", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lsvdanhsach.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lsvdanhsach.Items.Add(hang("MaHoaDon").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("MaKhachHang").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("NgayVietHoaDon").ToString())
            lsvdanhsach.Items(i).SubItems.Add(hang("ThanhTien").ToString())
            i += 1
        Next
    End Sub
    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try
            ketnoidulieu.Open()
            Dim MaHoaDon As String = txtmahoadon.Text
            Dim MaKhachHang As String = txtmakhachhang.Text
            Dim NgayVietHoaDon As String = txtngayviethoadon.Text
            Dim ThanhTien As String = txtthanhtien.Text
            Dim truyvan1 As New SqlCommand("insert into HoaDon values (N'" + MaKhachHang + "',N'" + NgayVietHoaDon + "', N'" + ThanhTien + "')", ketnoidulieu)
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
            txtmahoadon.Text = List.SubItems(0).Text
            txtmakhachhang.Text = List.SubItems(1).Text
            txtngayviethoadon.Text = List.SubItems(2).Text
            txtthanhtien.Text = List.SubItems(3).Text
        Next
    End Sub
  
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            ketnoidulieu.Open()
            Dim MaHoaDon As String = txtmahoadon.Text
            Dim MaKhachHang As String = txtmakhachhang.Text
            Dim NgayVietHoaDon As String = txtngayviethoadon.Text
            Dim ThanhTien As String = txtthanhtien.Text
            Dim truyvan2 As New SqlCommand("Update HoaDon set MaKhachHang='" + MaKhachHang + "',NgayVietHoaDon='" + NgayVietHoaDon + "',ThanhTien='" + ThanhTien + "' where MaHoaDon='" + MaHoaDon + "'", ketnoidulieu)
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
            Dim ID As String = txtmahoadon.Text
            Dim truyvan1 As New SqlCommand("delete from HoaDon where MaHoaDon = '" + ID + "'", ketnoidulieu)
            truyvan1.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class