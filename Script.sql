CREATE DATABASE QLKTX;
GO

USE QLKTX;
GO


CREATE TABLE Toa
(
	TenToa VARCHAR(15),
	SLPhong INT NOT NULL

	CONSTRAINT PK_Toa_TenToa PRIMARY KEY (TenToa)
)
GO

CREATE TABLE LoaiPhong
(
	MaLoai INT,
	TenLoai NVARCHAR(10) NOT NULL

	CONSTRAINT PK_LoaiPhong_MaLoai PRIMARY KEY (MaLoai)
)
GO

CREATE TABLE Phong
(
	MaPhong VARCHAR(15),
	SucChuaSV TINYINT NOT NULL,
	SLDangO TINYINT NOT NULL,

	MaLoai INT,
	TenToa VARCHAR(15)

	CONSTRAINT PK_Phong_MaPhong PRIMARY KEY (MaPhong),
	--CONSTRAINT FK_Phong_MaLoai FOREIGN KEY (MaLoai) REFERENCES dbo.LoaiPhong(MaLoai),
	--CONSTRAINT FK_Phong_TenToa FOREIGN KEY (TenToa) REFERENCES dbo.Toa(TenToa)
)
GO

CREATE TABLE SinhVien
(
	MaSV VARCHAR(15),
	CMND VARCHAR(12) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
	DienThoai VARCHAR(15),

	MaPhong VARCHAR(15),
	
	CONSTRAINT PK_SinhVien_MaSV PRIMARY KEY (MaSV),
	--CONSTRAINT FK_SinhVien_MaPhong FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
)
GO

CREATE TABLE KhenThuong_KyLuat
(
	MaKTKL INT IDENTITY(1,1),
	HinhThuc NVARCHAR(50) NOT NULL,
	MoTa NVARCHAR(200) NOT NULL,
	NgayTao DATE NOT NULL,

	MaSV VARCHAR(15)

	CONSTRAINT PK_KTKL_MaKTKL PRIMARY KEY (MaKTKL),
	--CONSTRAINT FK_KTKL_MaSV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV) ON DELETE CASCADE
)
GO

CREATE TABLE ThanNhan
(
	CMND VARCHAR(12),
	HoTen NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	QuanHeVoiSV NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
	DienThoai VARCHAR(15) NOT NULL,

	MaSV VARCHAR(15)

	CONSTRAINT PK_ThanNhan_CMND PRIMARY KEY (CMND)
	--CONSTRAINT FK_ThanNhan_MaSV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV) ON DELETE CASCADE
)
GO

CREATE TABLE HopDong_SV
(
	MaHD INT IDENTITY(1,1),
	NgayBatDau DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	NgayLap DATE NOT NULL,
	ThanhTien FLOAT NOT NULL,	-- (VND)

	MaSV VARCHAR(15)

	CONSTRAINT PK_HopDongSV_MaHD PRIMARY KEY (MaHD)
	--CONSTRAINT FK_HopDongSV_MaSV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV) ON DELETE CASCADE
)
GO

CREATE TABLE HoaDonDienNuoc
(
	MaHoaDon INT IDENTITY(1,1),
	SoDien FLOAT NOT NULL,
	SoNuoc FLOAT NOT NULL,
	ThanhTien FLOAT NOT NULL,
	NgayLap DATE NOT NULL,
	TrangThai NVARCHAR(50) NOT NULL,

	MaPhong VARCHAR(15)

	CONSTRAINT PK_HDDN_MaHoaDon PRIMARY KEY (MaHoaDon),
	--CONSTRAINT FK_HDDN_MaPhong FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
)
GO

CREATE TABLE ChucVu
(
	MaChucVu INT IDENTITY(1,1),
	TenChucVu NVARCHAR(100)

	CONSTRAINT PK_ChucVu_MaChucVu PRIMARY KEY (MaChucVu)
)
GO

CREATE TABLE NhanVien
(
	MaNV INT IDENTITY(1,1),
	HoTen NVARCHAR(50) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
	DienThoai VARCHAR(15) NOT NULL,

	TenToa VARCHAR(15),
	MaChucVu INT

	CONSTRAINT PK_NhanVien_MaNV PRIMARY KEY (MaNV),
	--CONSTRAINT FK_NhanVien_TenToa FOREIGN KEY (TenToa) REFERENCES dbo.Toa(TenToa),
	--CONSTRAINT FK_NhanVien_MaChucVu FOREIGN KEY (MaChucVu) REFERENCES dbo.ChucVu(MaChucVu)
)
GO

CREATE TABLE HopDong_NV
(
	MaHD INT IDENTITY(1,1),
	NgayBatDau DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	NgayLap DATE NOT NULL,
	LuongThang FLOAT NOT NULL,

	MaNV INT

	CONSTRAINT PK_HopDongNV_MaHD PRIMARY KEY (MaHD),
	--CONSTRAINT FK_HopDongNV_MaNV FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV) ON DELETE CASCADE
)
GO

CREATE TABLE TaiKhoan
(
	TenTaiKhoan VARCHAR(15),
	MatKhau VARCHAR(1000) NOT NULL,

	IDLoaiQuyen INT

	CONSTRAINT PK_TaiKhoan_TenTaiKhoan PRIMARY KEY (TenTaiKhoan),
	-- CONSTRAINT FK_TaiKhoan_IDLoaiQuyen FOREIGN KEY (IDLoaiQuyen) REFERENCES dbo.LoaiQuyen(IDLoaiQuyen)
)
GO

CREATE TABLE LoaiQuyen
(
	IDLoaiQuyen INT IDENTITY(1,1),
	TenQuyen NVARCHAR(30) NOT NULL,
	MoTa NVARCHAR(200)

	CONSTRAINT PK_LoaiQuyen_IDLoaiQuyen PRIMARY KEY (IDLoaiQuyen)
)
GO


-- ADD FOREIGN KEY INTO EACH TABLE
ALTER TABLE dbo.Phong ADD CONSTRAINT FK_Phong_MaLoai FOREIGN KEY (MaLoai) REFERENCES dbo.LoaiPhong(MaLoai);
ALTER TABLE dbo.Phong ADD CONSTRAINT FK_Phong_TenToa FOREIGN KEY (TenToa) REFERENCES dbo.Toa(TenToa);
ALTER TABLE dbo.SinhVien ADD CONSTRAINT FK_SinhVien_MaPhong FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong);
ALTER TABLE dbo.KhenThuong_KyLuat ADD CONSTRAINT FK_KTKL_MaSV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV) ON DELETE CASCADE;
ALTER TABLE dbo.ThanNhan ADD CONSTRAINT FK_ThanNhan_MaSV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV) ON DELETE CASCADE;
ALTER TABLE dbo.HopDong_SV ADD CONSTRAINT FK_HopDongSV_MaSV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV) ON DELETE CASCADE;
ALTER TABLE dbo.HoaDonDienNuoc ADD CONSTRAINT FK_HDDN_MaPhong FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong);
ALTER TABLE dbo.NhanVien ADD CONSTRAINT FK_NhanVien_TenToa FOREIGN KEY (TenToa) REFERENCES dbo.Toa(TenToa);
ALTER TABLE dbo.NhanVien ADD CONSTRAINT FK_NhanVien_MaChucVu FOREIGN KEY (MaChucVu) REFERENCES dbo.ChucVu(MaChucVu);
ALTER TABLE dbo.HopDong_NV ADD CONSTRAINT FK_HopDongNV_MaNV FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV) ON DELETE CASCADE;
ALTER TABLE dbo.TaiKhoan ADD CONSTRAINT FK_TaiKhoan_IDLoaiQuyen FOREIGN KEY (IDLoaiQuyen) REFERENCES dbo.LoaiQuyen(IDLoaiQuyen);
GO




-- TRIGGERS
CREATE OR ALTER TRIGGER trgXoaSinhVien ON dbo.SinhVien FOR DELETE AS
BEGIN
	UPDATE dbo.Phong SET SLDangO = (SELECT COUNT(MaSV) FROM dbo.SinhVien
	WHERE SinhVien.MaPhong = Phong.MaPhong)
	FROM Phong, Deleted WHERE Phong.MaPhong = Deleted.MaPhong;
END
GO

CREATE OR ALTER TRIGGER trgThemSinhVien ON dbo.SinhVien AFTER INSERT AS
BEGIN
	UPDATE dbo.Phong SET SLDangO = (SELECT COUNT(MaSV) FROM dbo.SinhVien
	WHERE SinhVien.MaPhong = Phong.MaPhong)
	FROM Phong, Inserted WHERE Phong.MaPhong = Inserted.MaPhong;
END
GO

CREATE OR ALTER TRIGGER trgSuaSinhVien ON dbo.SinhVien AFTER UPDATE AS
BEGIN
	UPDATE dbo.Phong
	SET SLDangO =
	(SELECT COUNT(MaSV) FROM dbo.SinhVien
	WHERE SinhVien.MaPhong = Phong.MaPhong)
	FROM Phong, Inserted, Deleted
	WHERE Phong.MaPhong = Inserted.MaPhong OR
	Phong.MaPhong = Deleted.MaPhong;
END
GO

CREATE OR ALTER TRIGGER trgThemTaiKhoan ON dbo.TaiKhoan FOR INSERT AS
BEGIN
	BEGIN TRANSACTION ThemTaiKhoan;
	DECLARE @taiKhoan VARCHAR(15), @matKhau VARCHAR(1000), @IDLoaiQuyen INT;
	SELECT @taiKhoan = TenTaiKhoan,	@matKhau = MatKhau,	@IDLoaiQuyen = IDLoaiQuyen	FROM Inserted;

	-- Them login
	EXECUTE('CREATE LOGIN [' + @taiKhoan + '] WITH PASSWORD = ''' + @matKhau +	'''' + ', DEFAULT_DATABASE=[QLKTX]');

	-- Them user
	EXECUTE('CREATE USER [' + @taiKhoan + '] FOR LOGIN [' + @taiKhoan + ']');

	-- Gan role
	IF (@IDLoaiQuyen = 1) EXECUTE sp_addrolemember 'rlBanQuanLy', @taiKhoan;
	ELSE IF (@IDLoaiQuyen = 2) EXECUTE sp_addrolemember 'rlTruongToa', @taiKhoan;

	IF (@@ERROR <> 0)
	BEGIN
		RAISERROR('Lỗi, không thêm được!', 16, 1);
		ROLLBACK TRANSACTION ThemTaiKhoan;
	END
	ELSE COMMIT TRANSACTION ThemTaiKhoan;
END
GO

CREATE OR ALTER TRIGGER trgXoaTaiKhoan ON dbo.TaiKhoan FOR DELETE AS
BEGIN
	BEGIN TRANSACTION XoaTaiKhoan;
	DECLARE @taiKhoan VARCHAR(15), @IDLoaiQuyen INT;
	SELECT @taiKhoan = TenTaiKhoan, @IDLoaiQuyen = IDLoaiQuyen FROM Deleted;

	-- Xoa user
	EXECUTE('DROP USER ' + @taiKhoan);

	-- Xoa login
	EXECUTE('DROP LOGIN ' + @taiKhoan);

	IF (@@ERROR <> 0)
	BEGIN
		RAISERROR('Lỗi, không xóa được!', 16, 1);
		ROLLBACK TRANSACTION XoaTaiKhoan;
	END
	ELSE COMMIT TRANSACTION XoaTaiKhoan;
END
GO

CREATE OR ALTER TRIGGER trgSuaTaiKhoan ON dbo.TaiKhoan FOR UPDATE AS
BEGIN
	DECLARE @tenTK VARCHAR(15), @newPass VARCHAR(1000), @oldPass VARCHAR(1000);
	SELECT @tenTK = TenTaiKhoan, @oldPass = MatKhau FROM Deleted;
	SELECT @newPass = MatKhau FROM Inserted;
	IF (@oldPass = @newPass)	RETURN;

	BEGIN TRANSACTION SuaTaiKhoan;
	-- Cap nhat login
	EXECUTE('ALTER LOGIN [' + @tenTK + '] WITH PASSWORD = ''' + @newPass +	'''');

	IF (@@ERROR <> 0)
	BEGIN
		RAISERROR(N'Lỗi, không sửa được!', 16, 1);
		ROLLBACK TRANSACTION SuaTaiKhoan;
		RETURN
	END COMMIT TRANSACTION SuaTaiKhoan;
END
GO



-- FUNCTIONS
CREATE OR ALTER FUNCTION dbo.fuConvertToUnsign1 (@strInput NVARCHAR(4000))
RETURNS NVARCHAR(4000) AS
BEGIN
	IF @strInput IS NULL RETURN @strInput;
	IF @strInput = '' RETURN @strInput;
	DECLARE @RT NVARCHAR(4000), @SIGN_CHARS NCHAR(136), @UNSIGN_CHARS NCHAR (136);
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208);
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD';
	DECLARE @COUNTER INT, @COUNTER1 INT;
	SET @COUNTER = 1;
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1;
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1)) 
			BEGIN
				IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1);
				ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER); 
				BREAK;
			END
			SET @COUNTER1 = @COUNTER1 +1;
		END
		SET @COUNTER = @COUNTER +1; 
	END 
	SET @strInput = replace(@strInput,' ','-');
	RETURN @strInput;
END
GO

CREATE OR ALTER FUNCTION fulTenSinhVien (@maSV VARCHAR(15))
RETURNS NVARCHAR(50) AS
BEGIN
	DECLARE @tenSV NVARCHAR(50);
	SET @tenSV = (SELECT HoTen FROM dbo.SinhVien WHERE MaSV = @maSV);
	RETURN @tenSV;
END
GO

CREATE OR ALTER FUNCTION fulTenChucVu (@maChucVu INT)
RETURNS NVARCHAR(100) AS
BEGIN
	DECLARE @tenChucVu NVARCHAR(100);
	SET @tenChucVu = (SELECT TenChucVu FROM dbo.ChucVu WHERE MaChucVu = @maChucVu);
	RETURN @tenChucVu;
END
GO

CREATE OR ALTER FUNCTION fulTenLoaiPhong (@maLoai INT)
RETURNS NVARCHAR(50) AS
BEGIN
	DECLARE @tenLoai NVARCHAR(50);
	SET @tenLoai = (SELECT TenLoai FROM dbo.LoaiPhong WHERE MaLoai = @maLoai);
	RETURN @tenLoai;
END
GO

CREATE OR ALTER FUNCTION fulTenLoaiQuyen (@IDLoaiQuyen INT)
RETURNS NVARCHAR(30) AS
BEGIN
	DECLARE @tenLoai NVARCHAR(30);
	SET @tenLoai = (SELECT TenQuyen FROM dbo.LoaiQuyen WHERE IDLoaiQuyen = @IDLoaiQuyen);
	RETURN @tenLoai;
END
GO



-- VIEWS
CREATE OR ALTER VIEW viewKTKL_DGV AS
	SELECT MaKTKL, HinhThuc, NgayTao, MaSV FROM dbo.KhenThuong_KyLuat;
GO

CREATE OR ALTER VIEW viewHoaDonDienNuoc_DGV AS
	SELECT MaPhong, MaHoaDon, ThanhTien, NgayLap, TrangThai FROM dbo.HoaDonDienNuoc;
GO

CREATE OR ALTER VIEW viewPhong_DGV AS
	SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai, SucChuaSV, SLDangO, TenToa FROM dbo.Phong;
GO

CREATE OR ALTER VIEW viewNhanVien_DGV AS
	SELECT MaNV, HoTen, NgaySinh, TenToa, dbo.fulTenChucVu(maChucVu) AS TenChucVu FROM dbo.NhanVien;
GO

CREATE OR ALTER VIEW viewSinhVien_DGV AS
	SELECT MaSV, HoTen, GioiTinh, NgaySinh, DienThoai, MaPhong FROM dbo.SinhVien;
GO



-- STORED PROCEDURES

--TongQuan
CREATE OR ALTER PROCEDURE spLayTongSoSinhVien AS
	SELECT COUNT(MaSV) FROM dbo.SinhVien;
GO

CREATE OR ALTER PROCEDURE spLayTongSoToa AS
	SELECT COUNT(TenToa) FROM dbo.Toa;
GO

CREATE OR ALTER PROCEDURE spLayTongSoPhong AS
	SELECT COUNT(MaPhong) FROM dbo.Phong;
GO

CREATE OR ALTER PROCEDURE spLaySoPhongConTrong AS
	SELECT COUNT(MaPhong) FROM dbo.Phong WHERE SLDangO = 0;
GO

CREATE OR ALTER PROCEDURE spLayTongSucChua AS
	SELECT SUM(SucChuaSV) FROM dbo.Phong;
GO

-- SinhVien
CREATE OR ALTER PROCEDURE spLaySinhVien_TimKiem_DGV (@str NVARCHAR(200)) AS
BEGIN
	SELECT MaSV, HoTen, GioiTinh, NgaySinh, DienThoai, MaPhong
	FROM dbo.SinhVien WHERE MaSV LIKE @str OR
	dbo.fuConvertToUnsign1(HoTen) LIKE dbo.fuConvertToUnsign1(@str) OR
	dbo.fuConvertToUnsign1(GioiTinh )LIKE dbo.fuConvertToUnsign1(@str) OR
	NgaySinh LIKE @str OR
	DienThoai LIKE @str OR
	MaPhong LIKE @str;
END
GO

CREATE OR ALTER PROCEDURE spLaySinhVien_DGV AS
	SELECT * FROM dbo.viewSinhVien_DGV;
GO

CREATE OR ALTER PROCEDURE spLaySinhVien_TheoPhong_DGV (@maPhong VARCHAR(15)) AS
	SELECT MaSV, HoTen, DienThoai FROM dbo.SinhVien WHERE MaPhong = @maPhong;
GO

CREATE OR ALTER PROCEDURE spLaySinhVien_TheoMaSV (@maSV VARCHAR(15)) AS
BEGIN
	SELECT *,
	(SELECT MaHD FROM dbo.HopDong_SV WHERE MaSV = @maSV) AS MaHD,
	(SELECT CMND FROM dbo.ThanNhan WHERE MaSV = @maSV) AS CMND_TN
	FROM dbo.SinhVien WHERE MaSV = @maSV;
END
GO

CREATE OR ALTER PROCEDURE spXoaSinhVien_TheoMaSV (@maSV VARCHAR(15)) AS
	DELETE FROM dbo.SinhVien WHERE MaSV = @maSV;
GO

CREATE OR ALTER PROCEDURE spThemSinhVien
(@maSV VARCHAR(15), @CMND VARCHAR(12), @hoTen NVARCHAR(50),
@gioiTinh NVARCHAR(10), @ngaySinh VARCHAR(15), @diaChi NVARCHAR(150),
@dienThoai VARCHAR(15), @CMND_TN VARCHAR(12), @hoTen_TN NVARCHAR(50),
@gioiTinh_TN NVARCHAR(10), @quanHeSV NVARCHAR(50), @diaChi_TN NVARCHAR(150),
@dienThoai_TN VARCHAR(15), @maPhong VARCHAR(15), @ngayBatDau VARCHAR(15),
@ngayKetThuc VARCHAR(15), @ngayLap VARCHAR(15), @thanhTien FLOAT) AS
BEGIN
	BEGIN TRANSACTION ThemSV;

	INSERT INTO dbo.SinhVien VALUES
	(@maSV, @CMND, @hoTen, @gioiTinh, @ngaySinh, @diaChi, @dienThoai, @maPhong);

	INSERT INTO dbo.ThanNhan VALUES
	(@CMND_TN, @hoTen_TN, @gioiTinh_TN, @quanHeSV, @diaChi_TN, @dienThoai_TN, @maSV);

	INSERT INTO dbo.HopDong_SV VALUES
	(@ngayBatDau, @ngayKetThuc, @ngayLap, @thanhTien, @maSV);

	IF ((SELECT COUNT(MaSV) FROM dbo.SinhVien
	WHERE MaPhong = @maPhong) > (SELECT SucChuaSV
	FROM dbo.Phong WHERE MaPhong = @maPhong))
	BEGIN
		RAISERROR ('Phòng này đầy rồi!!!', 16, 1);
		ROLLBACK TRANSACTION ThemSV;
	END
	ELSE IF ((SELECT dbo.fulTenLoaiPhong(MaLoai) FROM dbo.Phong WHERE MaPhong = @maPhong) <> @gioiTinh)
	BEGIN
		RAISERROR ('Hãy chọn đúng loại phòng!!!', 16, 1);
		ROLLBACK TRANSACTION ThemSV;
	END
	ELSE COMMIT TRANSACTION ThemSV;
END
GO

CREATE OR ALTER PROCEDURE spSuaSinhVien
(@maSV VARCHAR(15), @CMND VARCHAR(12), @hoTen NVARCHAR(50), @gioiTinh NVARCHAR(10),
@ngaySinh VARCHAR(15), @diaChi NVARCHAR(150), @dienThoai VARCHAR(15),
@CMND_TN VARCHAR(12), @hoTen_TN NVARCHAR(50),@gioiTinh_TN NVARCHAR(10),
@quanHeSV NVARCHAR(50), @diaChi_TN NVARCHAR(150), @dienThoai_TN VARCHAR(15),
@maPhong VARCHAR(15), @ngayBatDau VARCHAR(15), @ngayKetThuc VARCHAR(15),
@ngayLap VARCHAR(15), @thanhTien FLOAT) AS
BEGIN
	BEGIN TRANSACTION SuaSV
		UPDATE dbo.SinhVien SET CMND = @CMND, HoTen = @hoTen, GioiTinh = @gioiTinh,
		NgaySinh = @ngaySinh, DiaChi = @diaChi, DienThoai = @dienThoai, MaPhong = @maPhong
		WHERE MaSV = @maSV;

		UPDATE dbo.ThanNhan SET CMND = @CMND_TN, HoTen = @hoTen_TN, GioiTinh = @gioiTinh_TN,
		QuanHeVoiSV = @quanHeSV, DiaChi = @diaChi_TN, DienThoai = @dienThoai_TN
		WHERE MaSV = @maSV;

		IF (EXISTS(SELECT MaHD FROM dbo.HopDong_SV
		WHERE MaSV = @maSV AND (NgayBatDau <> @ngayBatDau OR NgayKetThuc <> @ngayKetThuc OR
		NgayLap <> @ngayLap OR ThanhTien <> @thanhTien)))
		BEGIN
			DELETE FROM dbo.HopDong_SV WHERE MaSV = @maSV;
			INSERT INTO dbo.HopDong_SV VALUES(@ngayBatDau, @ngayKetThuc, @ngayLap, @thanhTien, @maSV);
		END

		IF ((SELECT COUNT(MaSV) FROM dbo.SinhVien WHERE MaPhong = @maPhong) > (SELECT SucChuaSV
		FROM dbo.Phong WHERE MaPhong = @maPhong))
		BEGIN
			RAISERROR ('Phòng này đầy rồi!!!', 16, 1);
			ROLLBACK TRANSACTION SuaSV;
		END
		ELSE IF ((SELECT dbo.fulTenLoaiPhong(MaLoai) FROM dbo.Phong WHERE MaPhong = @maPhong) <> @gioiTinh)
		BEGIN
			RAISERROR ('Hãy chọn đúng loại phòng!!!', 16, 1);
			ROLLBACK TRANSACTION SuaSV;
		END
		ELSE COMMIT TRANSACTION SuaSV;
END
GO

CREATE OR ALTER PROCEDURE spLayHDSV_TheoMaHD (@maHD INT) AS
	SELECT * FROM dbo.HopDong_SV WHERE MaHD = @maHD;
GO

CREATE OR ALTER PROCEDURE spLayThanNhan_TheoCMNDTN (@CMNDTN VARCHAR(12)) AS
	SELECT * FROM dbo.ThanNhan WHERE CMND = @CMNDTN;
GO

-- KTKL
CREATE OR ALTER PROCEDURE spLayKTKL_TimKiem_DGV (@str NVARCHAR(200)) AS
BEGIN
	SELECT MaKTKL, HinhThuc, NgayTao, MaSV FROM dbo.KhenThuong_KyLuat
	WHERE MaKTKL LIKE @str OR
	dbo.fuConvertToUnsign1(HinhThuc) LIKE dbo.fuConvertToUnsign1(@str) OR
	NgayTao LIKE @str OR
	MaSV LIKE @str;
END
GO

CREATE OR ALTER PROCEDURE spLayKTKL_DGV AS
	SELECT * FROM dbo.viewKTKL_DGV;
GO

CREATE OR ALTER PROCEDURE spLayKTKL_TheoMaKTKL (@maKTKL INT) AS
	SELECT *, dbo.fulTenSinhVien(MaSV) AS TenSV
	FROM dbo.KhenThuong_KyLuat WHERE MaKTKL = @maKTKL;
GO

CREATE OR ALTER PROCEDURE spLayKTKL_TheoMaSV_DGV (@maSV VARCHAR(15)) AS
	SELECT MaKTKL, HinhThuc, NgayTao
	FROM dbo.KhenThuong_KyLuat WHERE MaSV = @maSV;
GO

CREATE OR ALTER PROCEDURE spXoaKTKL_TheoMaKTKL (@maKTKL INT) AS
	DELETE FROM dbo.KhenThuong_KyLuat WHERE MaKTKL = @maKTKL;
GO


CREATE OR ALTER PROCEDURE spThemKTKL
(@hinhThuc NVARCHAR(50), @moTa NVARCHAR(200), @ngayTao VARCHAR(15), @maSV VARCHAR(15)) AS
	INSERT INTO dbo.KhenThuong_KyLuat VALUES(@hinhThuc, @moTa, @ngayTao, @maSV);
GO

-- Phong
CREATE OR ALTER PROCEDURE spLayPhong_TheoToa (@tenToa VARCHAR(15)) AS
BEGIN
	SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai, SucChuaSV, SLDangO
	FROM dbo.Phong WHERE TenToa = @tenToa;
END
GO

CREATE OR ALTER PROCEDURE spLayPhong_TimKiem_DGV
(@str NVARCHAR(200))
AS
BEGIN
	SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai, SucChuaSV, SLDangO, TenToa
	FROM dbo.Phong WHERE MaPhong LIKE @str OR
	dbo.fuConvertToUnsign1(dbo.fulTenLoaiPhong(MaLoai)) LIKE dbo.fuConvertToUnsign1(@str) OR
	SucChuaSV LIKE @str OR
	SLDangO LIKE @str OR
	TenToa LIKE @str;
END
GO

CREATE OR ALTER PROCEDURE spLayPhong_DGV AS
	SELECT * FROM dbo.viewPhong_DGV;
GO

CREATE OR ALTER PROCEDURE spLayPhong_TheoMaPhong (@maPhong VARCHAR(15)) AS
	SELECT MaPhong, SucChuaSV, SLDangO, MaLoai,
	dbo.fulTenLoaiPhong(MaLoai) AS TenLoai, TenToa
	FROM dbo.Phong WHERE MaPhong = @maPhong;
GO

CREATE OR ALTER PROCEDURE spLayLoaiPhong AS
SELECT * FROM dbo.LoaiPhong;
GO

CREATE OR ALTER PROCEDURE spSuaPhong (@maPhong VARCHAR(15), @maLoai INT, @sucChua TINYINT) AS
BEGIN
	BEGIN TRANSACTION SuaPhong;

	UPDATE dbo.Phong SET MaLoai = @maLoai, SucChuaSV = @sucChua WHERE MaPhong = @maPhong;

	IF (EXISTS(SELECT MaSV FROM dbo.SinhVien, dbo.Phong
	WHERE SinhVien.MaPhong = @maPhong AND SinhVien.GioiTinh <> (SELECT dbo.fulTenLoaiPhong(MaLoai)
	FROM dbo.Phong WHERE MaPhong = @maPhong)))
	BEGIN
		RAISERROR('Chỉ được đổi loại phòng khi phòng trống!', 16, 1);
		ROLLBACK TRANSACTION SuaPhong;
	END
	ELSE IF (@sucChua < (SELECT SLDangO FROM dbo.Phong WHERE MaPhong = @maPhong))
	BEGIN
		RAISERROR('Sức chứa mới sửa ít nhất phải bằng số lượng sinh viên đang ở trong phòng!', 16, 1);
		ROLLBACK TRANSACTION SuaPhong;
	END
	ELSE COMMIT TRANSACTION SuaPhong;
END
GO

CREATE OR ALTER PROCEDURE spLayToa AS
	SELECT * FROM dbo.Toa;
GO

-- HoaDonDienNuoc
CREATE OR ALTER PROCEDURE spLayHoaDonDienNuoc_TimKiem_DGV (@str NVARCHAR(200)) AS
BEGIN
	SELECT MaPhong, MaHoaDon, ThanhTien, NgayLap, TrangThai FROM dbo.HoaDonDienNuoc
	WHERE MaPhong LIKE @str OR
	MaHoaDon LIKE @str OR
	ThanhTien LIKE @str OR
	NgayLap LIKE @str OR
	dbo.fuConvertToUnsign1(TrangThai) LIKE dbo.fuConvertToUnsign1(@str);
END
GO

CREATE OR ALTER PROCEDURE spLayHoaDonDienNuoc_DGV AS
	SELECT * FROM dbo.viewHoaDonDienNuoc_DGV;
GO

CREATE OR ALTER PROCEDURE spLayHoaDonDienNuoc_TheoMaHoaDon (@maHoaDon INT) AS
	SELECT * FROM dbo.HoaDonDienNuoc WHERE MaHoaDon = @maHoaDon;
GO

CREATE OR ALTER PROCEDURE spLayHoaDonDienNuoc_TheoPhong_DGV (@maPhong VARCHAR(15)) AS
BEGIN
	SELECT MaHoaDon, ThanhTien, NgayLap, TrangThai
	FROM dbo.HoaDonDienNuoc WHERE MaPhong = @maPhong;
END
GO

CREATE OR ALTER PROCEDURE spXoaHoaDonDienNuoc_TheoMaHoaDon (@maHoaDon INT) AS
	DELETE FROM dbo.HoaDonDienNuoc WHERE MaHoaDon = @maHoaDon;
GO

CREATE OR ALTER PROCEDURE spThemHoaDonDienNuoc
(@soDien FLOAT, @soNuoc FLOAT, @thanhTien FLOAT, @ngayLap VARCHAR(15),
@trangThai NVARCHAR(50), @maPhong VARCHAR(15)) AS
	INSERT INTO dbo.HoaDonDienNuoc VALUES
	(@soDien, @soNuoc, @thanhTien, @ngayLap, @trangThai, @maPhong);
GO

CREATE OR ALTER PROCEDURE spThemTaiKhoan
(@tenTaiKhoan VARCHAR(15), @matKhau VARCHAR(1000), @IDLoaiQuyen INT) AS
	INSERT INTO dbo.TaiKhoan VALUES(@tenTaiKhoan, @matKhau, @IDLoaiQuyen);
GO

CREATE OR ALTER PROCEDURE spSuaHoaDonDienNuoc (@maHoaDon INT, @trangThai NVARCHAR(50)) AS
	UPDATE dbo.HoaDonDienNuoc SET TrangThai = @trangThai WHERE MaHoaDon = @maHoaDon;
GO

-- NhanVien
CREATE OR ALTER PROCEDURE spLayNhanVien_TimKiem_DGV (@str NVARCHAR(200)) AS
BEGIN
	SELECT MaNV, HoTen, NgaySinh, TenToa, dbo.fulTenChucVu(MaChucVu) AS TenChucVu
	FROM dbo.NhanVien WHERE MaNV LIKE @str OR
	dbo.fuConvertToUnsign1(HoTen) LIKE dbo.fuConvertToUnsign1(@str) OR
	NgaySinh LIKE @str OR
	TenToa LIKE @str OR
	dbo.fuConvertToUnsign1(dbo.fulTenChucVu(MaChucVu)) LIKE dbo.fuConvertToUnsign1(@str);
END
GO

CREATE OR ALTER PROCEDURE spLayNhanVien_TheoMaNV (@maNV INT) AS
BEGIN
	SELECT MaNV, HoTen, NgaySinh, DiaChi, DienThoai,
	TenToa, MaChucVu, dbo.fulTenChucVu(MaChucVu) AS TenChucVu,
	(SELECT MaHD FROM dbo.HopDong_NV WHERE HopDong_NV.MaNV = NhanVien.MaNV) AS MaHD
	FROM dbo.NhanVien WHERE MaNV = @maNV;
END
GO

CREATE OR ALTER PROCEDURE spLayNhanVien_DGV AS
	SELECT * FROM dbo.viewNhanVien_DGV;
GO

CREATE OR ALTER PROCEDURE spXoaNhanVien_TheoMaNV (@maNV INT) AS
	DELETE FROM dbo.NhanVien WHERE MaNV = @maNV;
GO

CREATE OR ALTER PROCEDURE spThemNhanVien
(@hoTen NVARCHAR(50), @ngaySinh VARCHAR(15), @diaChi NVARCHAR(150),
@dienThoai VARCHAR(15), @tenToa VARCHAR(15), @maChucVu INT, @ngayBatDau VARCHAR(15),
@ngayKetThuc VARCHAR(15), @ngayLap VARCHAR(15), @luongThang FLOAT) AS
BEGIN
	BEGIN TRANSACTION ThemNV;

	INSERT INTO dbo.NhanVien VALUES
	(@hoTen, @ngaySinh, @diaChi, @dienThoai, @tenToa, @maChucVu);

	INSERT INTO dbo.HopDong_NV VALUES
	(@ngayBatDau, @ngayKetThuc, @ngayLap, @luongThang, (SELECT MAX(MaNV) FROM dbo.NhanVien));

	COMMIT TRANSACTION ThemNV;
END
GO

CREATE OR ALTER PROCEDURE spSuaNhanVien
(@maNV INT, @hoTen NVARCHAR(50), @ngaySinh VARCHAR(15), @diaChi NVARCHAR(150),
@dienThoai VARCHAR(15), @tenToa VARCHAR(15), @maChucVu INT, @ngayBatDau VARCHAR(15),
@ngayKetThuc VARCHAR(15), @ngayLap VARCHAR(15), @luongThang FLOAT) AS
BEGIN
	BEGIN TRANSACTION SuaNV;

	UPDATE dbo.NhanVien SET HoTen = @hoTen, NgaySinh = @ngaySinh,
	DiaChi = @diaChi, DienThoai = @dienThoai, TenToa = @tenToa, MaChucVu = @maChucVu
	WHERE MaNV = @maNV;

	IF (EXISTS(SELECT MaHD FROM dbo.HopDong_NV
		WHERE MaNV = @maNV AND (NgayBatDau <> @ngayBatDau OR NgayKetThuc <> @ngayKetThuc OR
		NgayLap <> @ngayLap OR LuongThang <> @luongThang)))
		BEGIN
			DELETE FROM dbo.HopDong_NV WHERE MaNV = @maNV;
			INSERT INTO dbo.HopDong_NV VALUES(@ngayBatDau, @ngayKetThuc, @ngayLap, @luongThang, @maNV);
		END

	COMMIT TRANSACTION SuaNV;
END
GO

CREATE OR ALTER PROCEDURE spLayLoaiChucVu AS
	SELECT * FROM dbo.ChucVu;
GO

CREATE OR ALTER PROCEDURE spLayHDNV_TheoMaHD (@maHD INT) AS
	SELECT * FROM dbo.HopDong_NV WHERE MaHD = @maHD;
GO

-- TaiKhoan
CREATE OR ALTER PROCEDURE spLayTaiKhoan_TheoTKMK
(@taiKhoan VARCHAR(15), @matKhau VARCHAR(1000)) AS
	SELECT * FROM dbo.TaiKhoan
	WHERE TenTaiKhoan = @taiKhoan AND
	MatKhau = @matKhau;
GO

CREATE OR ALTER PROCEDURE spLayTaiKhoan_TheoTenTK
(@taiKhoan VARCHAR(15))
AS
BEGIN
	SELECT TenTaiKhoan, MatKhau, IDLoaiQuyen,
	(SELECT TenQuyen FROM dbo.LoaiQuyen
	WHERE IDLoaiQuyen = TaiKhoan.IDLoaiQuyen) AS TenLoaiQuyen,
	(SELECT MoTa FROM dbo.LoaiQuyen
	WHERE IDLoaiQuyen = TaiKhoan.IDLoaiQuyen) AS MoTa
	FROM dbo.TaiKhoan WHERE TenTaiKhoan = @taiKhoan;
END
GO

CREATE OR ALTER PROCEDURE spLayTaiKhoan_DGV AS
	SELECT TenTaiKhoan,	dbo.fulTenLoaiQuyen(IDLoaiQuyen) AS TenQuyen FROM dbo.TaiKhoan;
GO

CREATE OR ALTER PROCEDURE spLayTaiKhoan_TimKiem_DGV (@str NVARCHAR(200)) AS
	SELECT TenTaiKhoan, dbo.fulTenLoaiQuyen(IDLoaiQuyen) AS TenQuyen
	FROM dbo.TaiKhoan WHERE TenTaiKhoan LIKE @str OR
	dbo.fuConvertToUnsign1(dbo.fulTenLoaiQuyen(IDLoaiQuyen)) LIKE dbo.fuConvertToUnsign1(@str);
GO

CREATE OR ALTER PROCEDURE spSuaTaiKhoan_TheoTenTK
(@tenTK VARCHAR(15), @matKhau VARCHAR(1000), @IDLoaiQuyen INT) AS
BEGIN
	BEGIN TRANSACTION SuaTaiKhoan;
	UPDATE dbo.TaiKhoan SET MatKhau = @matKhau, IDLoaiQuyen = @IDLoaiQuyen
	WHERE TenTaiKhoan = @tenTK;
	COMMIT TRANSACTION SuaTaiKhoan;
END
GO

CREATE OR ALTER PROCEDURE spThemTaiKhoan
(@tenTK VARCHAR(15), @matKhau VARCHAR(1000), @IDLoaiQuyen INT) AS
	INSERT INTO dbo.TaiKhoan VALUES(@tenTK, @matKhau, @IDLoaiQuyen);
GO

CREATE OR ALTER PROCEDURE spXoaTaiKhoan_TheoTenTK (@tenTK VARCHAR(15)) AS
	IF (@tenTK <> 'admin') DELETE FROM dbo.TaiKhoan WHERE TenTaiKhoan = @tenTK;
	ELSE RAISERROR('Không xóa được tài khoản Admin!', 16, 1);
GO

CREATE OR ALTER PROCEDURE spLayLoaiTK AS
	SELECT * FROM dbo.LoaiQuyen;
GO




-- TẠO ROLE
----------------------------------------------------------
CREATE ROLE rlBanQuanLy;
GO
GRANT EXECUTE ON [dbo].[spLayHDNV_TheoMaHD] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayHDSV_TheoMaHD] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_TheoMaHoaDon] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_TheoPhong_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_TimKiem_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayKTKL_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayKTKL_TheoMaKTKL] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayKTKL_TheoMaSV_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayKTKL_TimKiem_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayLoaiChucVu] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayLoaiPhong] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spLayLoaiTK] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayNhanVien_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayNhanVien_TheoMaNV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayNhanVien_TimKiem_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayPhong_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayPhong_TheoMaPhong] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayPhong_TheoToa] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayPhong_TimKiem_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLaySinhVien_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLaySinhVien_TheoMaSV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLaySinhVien_TheoPhong_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLaySinhVien_TimKiem_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLaySoPhongConTrong] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_DGV] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_TheoTenTK] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_TheoTKMK] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_TimKiem_DGV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayThanNhan_TheoCMNDTN] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayToa] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayTongSoPhong] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayTongSoSinhVien] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayTongSoToa] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spLayTongSucChua] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spSuaHoaDonDienNuoc] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spSuaNhanVien] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spSuaPhong] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spSuaSinhVien] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spSuaTaiKhoan_TheoTenTK] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spThemHoaDonDienNuoc] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spThemKTKL] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spThemNhanVien] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spThemSinhVien] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spThemTaiKhoan] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spXoaHoaDonDienNuoc_TheoMaHoaDon] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spXoaKTKL_TheoMaKTKL] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spXoaNhanVien_TheoMaNV] TO rlBanQuanLy;
GRANT EXECUTE ON [dbo].[spXoaSinhVien_TheoMaSV] TO rlBanQuanLy;
--GRANT EXECUTE ON [dbo].[spXoaTaiKhoan_TheoTenTK] TO rlBanQuanLy;
GO


CREATE ROLE rlTruongToa;
GO
GRANT EXECUTE ON [dbo].[spLayHDNV_TheoMaHD] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayHDSV_TheoMaHD] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_TheoMaHoaDon] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_TheoPhong_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayHoaDonDienNuoc_TimKiem_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayKTKL_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayKTKL_TheoMaKTKL] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayKTKL_TheoMaSV_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayKTKL_TimKiem_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayLoaiChucVu] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayLoaiPhong] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spLayLoaiTK] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayNhanVien_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayNhanVien_TheoMaNV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayNhanVien_TimKiem_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayPhong_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayPhong_TheoMaPhong] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayPhong_TheoToa] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayPhong_TimKiem_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLaySinhVien_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLaySinhVien_TheoMaSV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLaySinhVien_TheoPhong_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLaySinhVien_TimKiem_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLaySoPhongConTrong] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_DGV] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_TheoTenTK] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_TheoTKMK] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spLayTaiKhoan_TimKiem_DGV] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayThanNhan_TheoCMNDTN] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayToa] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayTongSoPhong] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayTongSoSinhVien] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayTongSoToa] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spLayTongSucChua] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spSuaHoaDonDienNuoc] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spSuaNhanVien] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spSuaPhong] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spSuaSinhVien] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spSuaTaiKhoan_TheoTenTK] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spThemHoaDonDienNuoc] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spThemKTKL] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spThemNhanVien] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spThemSinhVien] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spThemTaiKhoan] TO rlTruongToa;
GRANT EXECUTE ON [dbo].[spXoaHoaDonDienNuoc_TheoMaHoaDon] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spXoaKTKL_TheoMaKTKL] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spXoaNhanVien_TheoMaNV] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spXoaSinhVien_TheoMaSV] TO rlTruongToa;
--GRANT EXECUTE ON [dbo].[spXoaTaiKhoan_TheoTenTK] TO rlTruongToa;
GO