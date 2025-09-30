<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quanlithuvien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtMaSach = New TextBox()
        BtnThem = New Button()
        txtTenSach = New TextBox()
        txtTheLoai = New TextBox()
        txtMaTacGia = New TextBox()
        txtSoLuong = New TextBox()
        txtGiaTien = New TextBox()
        txtNhaXuatBan = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        dtpNgayXuatBan = New DateTimePicker()
        Label9 = New Label()
        BtnSua = New Button()
        BtnXoa = New Button()
        BtnHienThi = New Button()
        BtnTimKiem = New Button()
        txtTimKiem = New TextBox()
        Label10 = New Label()
        dgvsach = New DataGridView()
        BtnDangXuat = New Button()
        CType(dgvsach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtMaSach
        ' 
        TxtMaSach.Location = New Point(147, 187)
        TxtMaSach.Name = "TxtMaSach"
        TxtMaSach.Size = New Size(118, 27)
        TxtMaSach.TabIndex = 1
        ' 
        ' BtnThem
        ' 
        BtnThem.Location = New Point(147, 466)
        BtnThem.Name = "BtnThem"
        BtnThem.Size = New Size(94, 29)
        BtnThem.TabIndex = 2
        BtnThem.Text = "Thêm"
        BtnThem.UseVisualStyleBackColor = True
        ' 
        ' txtTenSach
        ' 
        txtTenSach.Location = New Point(147, 243)
        txtTenSach.Name = "txtTenSach"
        txtTenSach.Size = New Size(118, 27)
        txtTenSach.TabIndex = 3
        ' 
        ' txtTheLoai
        ' 
        txtTheLoai.Location = New Point(147, 315)
        txtTheLoai.Name = "txtTheLoai"
        txtTheLoai.Size = New Size(118, 27)
        txtTheLoai.TabIndex = 3
        ' 
        ' txtMaTacGia
        ' 
        txtMaTacGia.Location = New Point(477, 239)
        txtMaTacGia.Name = "txtMaTacGia"
        txtMaTacGia.Size = New Size(164, 27)
        txtMaTacGia.TabIndex = 3
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(477, 318)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(164, 27)
        txtSoLuong.TabIndex = 3
        ' 
        ' txtGiaTien
        ' 
        txtGiaTien.Location = New Point(477, 381)
        txtGiaTien.Name = "txtGiaTien"
        txtGiaTien.Size = New Size(164, 27)
        txtGiaTien.TabIndex = 3
        ' 
        ' txtNhaXuatBan
        ' 
        txtNhaXuatBan.Location = New Point(147, 381)
        txtNhaXuatBan.Name = "txtNhaXuatBan"
        txtNhaXuatBan.Size = New Size(118, 27)
        txtNhaXuatBan.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 4
        Label2.Text = "Mã Sách"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tên Sách"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 4
        Label4.Text = "Thể Loại"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 20)
        Label5.TabIndex = 4
        Label5.Text = "Nhà Xuất Bản"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(347, 250)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 20)
        Label6.TabIndex = 4
        Label6.Text = "Mã Tác Giả"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(352, 321)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 4
        Label7.Text = "Số Lượng "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(347, 388)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 20)
        Label8.TabIndex = 4
        Label8.Text = "Giá Tiền"
        ' 
        ' dtpNgayXuatBan
        ' 
        dtpNgayXuatBan.Location = New Point(477, 187)
        dtpNgayXuatBan.Name = "dtpNgayXuatBan"
        dtpNgayXuatBan.Size = New Size(164, 27)
        dtpNgayXuatBan.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(347, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 20)
        Label9.TabIndex = 4
        Label9.Text = "Ngày Xuất Bản"
        ' 
        ' BtnSua
        ' 
        BtnSua.Location = New Point(289, 466)
        BtnSua.Name = "BtnSua"
        BtnSua.Size = New Size(94, 29)
        BtnSua.TabIndex = 2
        BtnSua.Text = "Sửa"
        BtnSua.UseVisualStyleBackColor = True
        ' 
        ' BtnXoa
        ' 
        BtnXoa.Location = New Point(427, 466)
        BtnXoa.Name = "BtnXoa"
        BtnXoa.Size = New Size(94, 29)
        BtnXoa.TabIndex = 2
        BtnXoa.Text = "Xóa"
        BtnXoa.UseVisualStyleBackColor = True
        ' 
        ' BtnHienThi
        ' 
        BtnHienThi.Location = New Point(571, 466)
        BtnHienThi.Name = "BtnHienThi"
        BtnHienThi.Size = New Size(94, 29)
        BtnHienThi.TabIndex = 2
        BtnHienThi.Text = "Hiển thị"
        BtnHienThi.UseVisualStyleBackColor = True
        ' 
        ' BtnTimKiem
        ' 
        BtnTimKiem.Location = New Point(744, 298)
        BtnTimKiem.Name = "BtnTimKiem"
        BtnTimKiem.Size = New Size(94, 29)
        BtnTimKiem.TabIndex = 2
        BtnTimKiem.Text = "Tìm Kiếm"
        BtnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' txtTimKiem
        ' 
        txtTimKiem.Location = New Point(689, 239)
        txtTimKiem.Name = "txtTimKiem"
        txtTimKiem.Size = New Size(193, 27)
        txtTimKiem.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(699, 174)
        Label10.Name = "Label10"
        Label10.Size = New Size(169, 20)
        Label10.TabIndex = 0
        Label10.Text = "Tìm Kiếm Theo Mã Sách"
        ' 
        ' dgvsach
        ' 
        dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvsach.Location = New Point(46, 23)
        dgvsach.Name = "dgvsach"
        dgvsach.RowHeadersWidth = 51
        dgvsach.Size = New Size(836, 138)
        dgvsach.TabIndex = 6
        ' 
        ' BtnDangXuat
        ' 
        BtnDangXuat.Location = New Point(719, 466)
        BtnDangXuat.Name = "BtnDangXuat"
        BtnDangXuat.Size = New Size(94, 29)
        BtnDangXuat.TabIndex = 2
        BtnDangXuat.Text = "Đăng xuất"
        BtnDangXuat.UseVisualStyleBackColor = True
        ' 
        ' QuanLiThuVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 525)
        Controls.Add(dgvsach)
        Controls.Add(dtpNgayXuatBan)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtNhaXuatBan)
        Controls.Add(txtGiaTien)
        Controls.Add(txtTimKiem)
        Controls.Add(txtSoLuong)
        Controls.Add(txtMaTacGia)
        Controls.Add(txtTheLoai)
        Controls.Add(txtTenSach)
        Controls.Add(BtnTimKiem)
        Controls.Add(BtnDangXuat)
        Controls.Add(BtnHienThi)
        Controls.Add(BtnXoa)
        Controls.Add(BtnSua)
        Controls.Add(BtnThem)
        Controls.Add(TxtMaSach)
        Controls.Add(Label10)
        Name = "QuanLiThuVien"
        Text = "Quản Lí Thư Viện"
        CType(dgvsach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TxtMaSach As TextBox
    Friend WithEvents BtnThem As Button
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents txtMaTacGia As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtGiaTien As TextBox
    Friend WithEvents txtNhaXuatBan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpNgayXuatBan As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSua As Button
    Friend WithEvents BtnXoa As Button
    Friend WithEvents BtnHienThi As Button
    Friend WithEvents BtnTimKiem As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents BtnDangXuat As Button

End Class
