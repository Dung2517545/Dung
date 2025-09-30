Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class QuanLiThuVien
    Dim conn As New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyThuVienA;Integrated Security=True;Trust Server Certificate=True")

    Private Sub QuanLiThuVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThi()
        ' Phân quyền
        Dim quyen As String = Me.Tag.ToString()
        If quyen = "User" Then
            BtnThem.Enabled = False
            BtnSua.Enabled = False
            BtnXoa.Enabled = False
        End If
    End Sub

    Private Sub HienThi()
        Dim da As New SqlDataAdapter("SELECT * FROM Sach", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvsach.DataSource = dt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        Dim sql As String = "INSERT INTO Sach VALUES(@ma,@ten,@tl,@nxb,@tg,@ngay,@sl,@gia)"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", TxtMaSach.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenSach.Text)
        cmd.Parameters.AddWithValue("@tl", txtTheLoai.Text)
        cmd.Parameters.AddWithValue("@nxb", txtNhaXuatBan.Text)
        cmd.Parameters.AddWithValue("@tg", txtTenSach.Text)
        cmd.Parameters.AddWithValue("@ngay", dtpNgayXuatBan.Value)
        cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text)
        cmd.Parameters.AddWithValue("@gia", txtGiaTien.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        HienThi()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim sql As String = "UPDATE Sach SET TenSach=@ten,TheLoai=@tl,NhaXuatBan=@nxb,MaTacGia=@tg,NgayXuatBan=@ngay,SoLuong=@sl,GiaTien=@gia WHERE MaSach=@ma"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", TxtMaSach.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenSach.Text)
        cmd.Parameters.AddWithValue("@tl", txtTheLoai.Text)
        cmd.Parameters.AddWithValue("@nxb", txtNhaXuatBan.Text)
        cmd.Parameters.AddWithValue("@tg", txtTenSach.Text)
        cmd.Parameters.AddWithValue("@ngay", dtpNgayXuatBan.Value)
        cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text)
        cmd.Parameters.AddWithValue("@gia", txtGiaTien.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        HienThi()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim sql As String = "DELETE FROM Sach WHERE MaSach=@ma"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", TxtMaSach.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        HienThi()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles BtnTimKiem.Click
        Dim sql As String = "SELECT * FROM Sach WHERE MaSach=@ma"
        Dim da As New SqlDataAdapter(sql, conn)
        da.SelectCommand.Parameters.AddWithValue("@ma", txtTimKiem.Text)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvsach.DataSource = dt
    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles BtnDangXuat.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
