Public Class frmmenu

    Private Sub btnsanpham_Click(sender As Object, e As EventArgs) Handles btnsanpham.Click
        Dim SanPham As New frmsanpham()
        SanPham.Show()
    End Sub

    Private Sub btnchitiethoadon_Click(sender As Object, e As EventArgs) Handles btnchitiethoadon.Click
        Dim ChiTietHD As New frmchitiethoadon()
        ChiTietHD.Show()
    End Sub

    Private Sub btnhoadon_Click(sender As Object, e As EventArgs) Handles btnhoadon.Click
        Dim HoaDon As New frmhoadon()
        HoaDon.Show()
    End Sub
End Class