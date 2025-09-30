CREATE DATABASE QuanLyThuVienA;
GO

USE QuanLyThuVienA;
GO

-- 2. Bảng tài khoản người dùng (dùng cho đăng nhập/đăng ký)
CREATE TABLE TaiKhoan (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL,
    Quyen NVARCHAR(20) NOT NULL  -- VD: 'Admin', 'User'
);
GO

-- 3. Bảng sách
CREATE TABLE Sach (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(100) NOT NULL,
    MaTacGia NVARCHAR(50),
    TheLoai NVARCHAR(50),
    NhaXuatBan NVARCHAR(100),
    NgayXuatBan DATE,
    SoLuong INT DEFAULT 0,
    GiaTien DECIMAL(18,2) DEFAULT 0
);
GO

-- 4. Bảng tác giả (tùy chọn)
CREATE TABLE TacGia (
    MaTacGia NVARCHAR(50) PRIMARY KEY,
    TenTacGia NVARCHAR(100)
);
GO

-- 5. Chèn một tài khoản mẫu
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen)
VALUES (N'admin', N'123456', N'Admin');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen)
VALUES (N'user1', N'123456', N'User');

-- 6. Chèn dữ liệu mẫu vào bảng Sách
INSERT INTO Sach (TenSach, MaTacGia, TheLoai, NhaXuatBan, NgayXuatBan, SoLuong, GiaTien)
VALUES (N'Lập Trình VB.NET Cơ Bản', N'TG01', N'Tin Học', N'NXB Giáo Dục', '2023-01-10', 20, 75000);

INSERT INTO Sach (TenSach, MaTacGia, TheLoai, NhaXuatBan, NgayXuatBan, SoLuong, GiaTien)
VALUES (N'Cơ Sở Dữ Liệu SQL Server', N'TG02', N'Tin Học', N'NXB Trẻ', '2022-09-15', 15, 95000);
go
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen)
VALUES (@tk, @mk, @quyen)
