-- Tạo và sử dụng database
create database qlynhansu
use qlynhansu

-- Tạo bảng Phòng
CREATE TABLE Phong (
    MaPhong NVARCHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(255) NOT NULL,
    DiaChiPhong NVARCHAR(255),
    SoDienThoai NVARCHAR(15)
);

-- Tạo bảng ChucVu
CREATE TABLE ChucVu (
    MaChucVu NVARCHAR(10) PRIMARY KEY,
    TenChucVu NVARCHAR(255) NOT NULL,
    HeSoPhuCap DECIMAL(5, 2) CHECK (HeSoPhuCap > 1 AND HeSoPhuCap < 2)
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255) NOT NULL,
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    QueQuan NVARCHAR(255),
    MaPhong NVARCHAR(10),
    MaChucVu NVARCHAR(10),
    MatKhau NVARCHAR(255),
    LoaiNguoiDung NVARCHAR(20),
    HeSoLuong DECIMAL(5, 2), -- Đây là hệ số lương
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);

-- Tạo bảng ChamCong
CREATE TABLE ChamCong (
    MaChamCong NVARCHAR(10) PRIMARY KEY,
    MaNhanVien NVARCHAR(10),
    Thang INT,
    Nam INT,
    SoNgayLamViec INT,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Tạo bảng Luong
CREATE TABLE Luong (
    MaLuong NVARCHAR(10) PRIMARY KEY,
    MaNhanVien NVARCHAR(10),
    Thang INT,
    Nam INT,
    Luong DECIMAL(10, 2),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Tạo hàm tính lương
CREATE FUNCTION dbo.TinhLuong (@MaNhanVien NVARCHAR(10), @Thang INT, @Nam INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Luong DECIMAL(18, 2);

    SELECT @Luong = (
        NhanVien.HeSoLuong * 1500000 +
        ChamCong.SoNgayLamViec * 200000 * ChucVu.HeSoPhuCap
    ) - IIF(ChamCong.SoNgayLamViec < 20, (20 - ChamCong.SoNgayLamViec) * 500000, 0)
    FROM NhanVien
    INNER JOIN ChamCong ON NhanVien.MaNhanVien = ChamCong.MaNhanVien
    INNER JOIN ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu
    WHERE NhanVien.MaNhanVien = @MaNhanVien AND ChamCong.Thang = @Thang AND ChamCong.Nam = @Nam;

    RETURN @Luong;
END;

-- Chọn bảng
SELECT * FROM Phong ORDER BY TenPhong ASC

SELECT * FROM ChucVu ORDER BY TenChucVu ASC

SELECT * FROM NhanVien ORDER BY right(HoTen, charindex(' ', reverse(HoTen)) - 1) ASC;

SELECT C.MaChamCong, C.MaNhanVien, N.HoTen, C.Thang, C.Nam, C.SoNgayLamViec
FROM ChamCong C
INNER JOIN NhanVien N ON C.MaNhanVien = N.MaNhanVien
ORDER BY C.Nam ASC, C.Thang ASC


SELECT L.MaLuong, L.MaNhanVien, N.HoTen, L.Thang, L.Nam, L.Luong, CASE WHEN Luong > 10000000 THEN Luong * 0.1 ELSE 0 END AS ThueThuNhap
FROM Luong L
INNER JOIN NhanVien N ON L.MaNhanVien = N.MaNhanVien
ORDER BY L.Nam ASC, L.Thang ASC

-- Xóa các bản ghi trong bảng
DELETE FROM Phong
DELETE FROM ChucVu
DELETE FROM NhanVien
DELETE FROM ChamCong
DELETE FROM Luong

-- Xóa bảng
DROP TABLE Phong
DROP TABLE ChucVu
DROP TABLE NhanVien
DROP TABLE ChamCong
DROP TABLE Luong

-- Khu vực test câu lệnh
SELECT NV.*
FROM NhanVien NV
JOIN Phong P ON NV.MaPhong = P.MaPhong
WHERE P.MaPhong = 'P53451'
ORDER BY RIGHT(NV.HoTen, CHARINDEX(' ', REVERSE(NV.HoTen)) - 1) ASC;

SELECT MaLuong, MaNhanVien, Thang, Nam, Luong, CASE WHEN Luong > 10000000 THEN Luong * 0.1 ELSE 0 END AS ThueThuNhap
FROM Luong

UPDATE Luong SET Luong = 12340500 WHERE MaLuong = 'L004'

SELECT *
FROM NhanVien
ORDER BY RIGHT(HoTen, CHARINDEX(' ', REVERSE(HoTen)) - 1) ASC;

SELECT * FROM NhanVien WHERE MaNhanVien = 'NV001'

DELETE FROM ChamCong WHERE MaNhanVien = 'NV19091'

DELETE FROM Luong WHERE MaNhanVien = 'NV19091'

SELECT COUNT(*) FROM ChamCong WHERE MaNhanVien = 'NV49601'

SELECT C.MaChamCong, C.MaNhanVien, N.HoTen, C.Thang, C.Nam, C.SoNgayLamViec
FROM ChamCong C
INNER JOIN NhanVien N ON C.MaNhanVien = N.MaNhanVien
WHERE N.MaNhanVien = 'NV19091'
ORDER BY C.Nam ASC, C.Thang ASC

INSERT INTO Luong (MaLuong, MaNhanVien, Thang, Nam, Luong)
VALUES ('L46723', 'NV19091', 8, 2021, (
    SELECT 
        NhanVien.HeSoLuong * 1500000 +
        ChamCong.SoNgayLamViec * 200000 * ChucVu.HeSoPhuCap - 
        IIF(ChamCong.SoNgayLamViec < 20, (20 - ChamCong.SoNgayLamViec) * 500000, 0)
    FROM NhanVien
    INNER JOIN ChamCong ON NhanVien.MaNhanVien = ChamCong.MaNhanVien
    INNER JOIN ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu
    WHERE NhanVien.MaNhanVien = 'NV19091' AND ChamCong.Thang = 8 AND ChamCong.Nam = 2021
));

DELETE FROM Luong WHERE MaLuong = 'L98129';

SELECT L.*
FROM Luong L
INNER JOIN NhanVien NV ON L.MaNhanVien = NV.MaNhanVien
WHERE L.Thang = 11
  AND L.Nam = 2023
  AND NV.MaPhong = 'P53451';

