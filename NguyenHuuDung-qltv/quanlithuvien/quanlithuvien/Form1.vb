Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form1
    Dim conn As New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyThuVienA;Integrated Security=True;Trust Server Certificate=True")

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles BtnDangNhap.Click
        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM TaiKhoan WHERE TenDangNhap=@tk AND MatKhau=@mk"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@tk", TxtTenDangNhap.Text)
            cmd.Parameters.AddWithValue("@mk", TxtMatKhau.Text)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            If rd.Read() Then
                Dim quyen As String = rd("Quyen").ToString()
                MessageBox.Show("Đăng nhập thành công với quyền: " & quyen)

                Dim f As New QuanLiThuVien()
                f.Tag = quyen
                f.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles BtnDangXuat.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
