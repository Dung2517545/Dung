Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form2

    ' ====== NÚT ĐĂNG KÝ ======
    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        Try
            ' Dùng Using để tránh lỗi connection chưa đóng
            Using conn As New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyThuVienA;Integrated Security=True;Trust Server Certificate=True")
                conn.Open()

                ' Câu lệnh thêm tài khoản
                Dim sql As String = "INSERT INTO TaiKhoan(TenDangNhap, MatKhau, Quyen) VALUES(@tk, @mk, @quyen)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@tk", TxtTenDangNhap.Text.Trim())
                    cmd.Parameters.AddWithValue("@mk", TxtMatKhau.Text.Trim())
                    cmd.Parameters.AddWithValue("@quyen", cboQuyen.Text.Trim())

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Đăng ký thành công!", "Thông báo")
                    Else
                        MessageBox.Show("Đăng ký thất bại!", "Thông báo")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Thông báo lỗi")
        End Try
    End Sub

    ' ====== NÚT ĐĂNG NHẬP ======
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles BtnDangNhap.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
