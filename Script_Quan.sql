USE [QLKTX]
GO
/****** Object:  StoredProcedure [dbo].[spXoaSinhVien_TheoMaSV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spXoaSinhVien_TheoMaSV]
GO
/****** Object:  StoredProcedure [dbo].[spXoaNhanVien_TheoMaNV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spXoaNhanVien_TheoMaNV]
GO
/****** Object:  StoredProcedure [dbo].[spXoaKTKL_TheoMaKTKL]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spXoaKTKL_TheoMaKTKL]
GO
/****** Object:  StoredProcedure [dbo].[spXoaHoaDonDienNuoc_TheoMaHoaDon]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spXoaHoaDonDienNuoc_TheoMaHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[spThemTaiKhoan]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spThemTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[spThemSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spThemSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[spThemNhanVien]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spThemNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[spThemKTKL]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spThemKTKL]
GO
/****** Object:  StoredProcedure [dbo].[spThemHoaDonDienNuoc]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spThemHoaDonDienNuoc]
GO
/****** Object:  StoredProcedure [dbo].[spSuaSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spSuaSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[spSuaPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spSuaPhong]
GO
/****** Object:  StoredProcedure [dbo].[spSuaNhanVien]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spSuaNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[spSuaHoaDonDienNuoc]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spSuaHoaDonDienNuoc]
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSucChua]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTongSucChua]
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSoToa]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTongSoToa]
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSoSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTongSoSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSoPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTongSoPhong]
GO
/****** Object:  StoredProcedure [dbo].[spLayToa]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayToa]
GO
/****** Object:  StoredProcedure [dbo].[spLayThanNhan_TheoCMNDTN]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayThanNhan_TheoCMNDTN]
GO
/****** Object:  StoredProcedure [dbo].[spLayTaiKhoan_TheoTKMK]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTaiKhoan_TheoTKMK]
GO
/****** Object:  StoredProcedure [dbo].[spLayTaiKhoan_TheoTenTK]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTaiKhoan_TheoTenTK]
GO
/****** Object:  StoredProcedure [dbo].[spLayTaiKhoan_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayTaiKhoan_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLaySoPhongConTrong]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLaySoPhongConTrong]
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLaySinhVien_TimKiem_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_TheoPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLaySinhVien_TheoPhong_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_TheoMaSV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLaySinhVien_TheoMaSV]
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLaySinhVien_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayPhong_TimKiem_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_TheoToa]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayPhong_TheoToa]
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_TheoMaPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayPhong_TheoMaPhong]
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayPhong_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayNhanVien_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayNhanVien_TimKiem_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayNhanVien_TheoMaNV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayNhanVien_TheoMaNV]
GO
/****** Object:  StoredProcedure [dbo].[spLayNhanVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayNhanVien_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayLoaiPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayLoaiPhong]
GO
/****** Object:  StoredProcedure [dbo].[spLayLoaiChucVu]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayLoaiChucVu]
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayKTKL_TimKiem_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_TheoMaSV_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayKTKL_TheoMaSV_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_TheoMaKTKL]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayKTKL_TheoMaKTKL]
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayKTKL_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayHoaDonDienNuoc_TimKiem_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_TheoPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayHoaDonDienNuoc_TheoPhong_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_TheoMaHoaDon]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayHoaDonDienNuoc_TheoMaHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayHoaDonDienNuoc_DGV]
GO
/****** Object:  StoredProcedure [dbo].[spLayHDSV_TheoMaHD]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayHDSV_TheoMaHD]
GO
/****** Object:  StoredProcedure [dbo].[spLayHDNV_TheoMaHD]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP PROCEDURE [dbo].[spLayHDNV_TheoMaHD]
GO
ALTER TABLE [dbo].[ThanNhan] DROP CONSTRAINT [FK_ThanNhan_MaSV]
GO
ALTER TABLE [dbo].[TaiKhoan] DROP CONSTRAINT [FK_TaiKhoan_IDLoaiQuyen]
GO
ALTER TABLE [dbo].[SinhVien] DROP CONSTRAINT [FK_SinhVien_MaPhong]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [FK_Phong_TenToa]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [FK_Phong_MaLoai]
GO
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK_NhanVien_TenToa]
GO
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK_NhanVien_MaChucVu]
GO
ALTER TABLE [dbo].[KhenThuong_KyLuat] DROP CONSTRAINT [FK_KTKL_MaSV]
GO
ALTER TABLE [dbo].[HopDong_SV] DROP CONSTRAINT [FK_HopDongSV_MaSV]
GO
ALTER TABLE [dbo].[HopDong_NV] DROP CONSTRAINT [FK_HopDongNV_MaNV]
GO
ALTER TABLE [dbo].[HoaDonDienNuoc] DROP CONSTRAINT [FK_HDDN_MaPhong]
GO
/****** Object:  Table [dbo].[Toa]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Toa]') AND type in (N'U'))
DROP TABLE [dbo].[Toa]
GO
/****** Object:  Table [dbo].[ThanNhan]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ThanNhan]') AND type in (N'U'))
DROP TABLE [dbo].[ThanNhan]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaiKhoan]') AND type in (N'U'))
DROP TABLE [dbo].[TaiKhoan]
GO
/****** Object:  Table [dbo].[LoaiQuyen]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiQuyen]') AND type in (N'U'))
DROP TABLE [dbo].[LoaiQuyen]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiPhong]') AND type in (N'U'))
DROP TABLE [dbo].[LoaiPhong]
GO
/****** Object:  Table [dbo].[HopDong_SV]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HopDong_SV]') AND type in (N'U'))
DROP TABLE [dbo].[HopDong_SV]
GO
/****** Object:  Table [dbo].[HopDong_NV]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HopDong_NV]') AND type in (N'U'))
DROP TABLE [dbo].[HopDong_NV]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu]') AND type in (N'U'))
DROP TABLE [dbo].[ChucVu]
GO
/****** Object:  View [dbo].[viewSinhVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP VIEW [dbo].[viewSinhVien_DGV]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SinhVien]') AND type in (N'U'))
DROP TABLE [dbo].[SinhVien]
GO
/****** Object:  View [dbo].[viewNhanVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP VIEW [dbo].[viewNhanVien_DGV]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  View [dbo].[viewPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP VIEW [dbo].[viewPhong_DGV]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Phong]') AND type in (N'U'))
DROP TABLE [dbo].[Phong]
GO
/****** Object:  View [dbo].[viewHoaDonDienNuoc_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP VIEW [dbo].[viewHoaDonDienNuoc_DGV]
GO
/****** Object:  Table [dbo].[HoaDonDienNuoc]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoaDonDienNuoc]') AND type in (N'U'))
DROP TABLE [dbo].[HoaDonDienNuoc]
GO
/****** Object:  View [dbo].[viewKTKL_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP VIEW [dbo].[viewKTKL_DGV]
GO
/****** Object:  Table [dbo].[KhenThuong_KyLuat]    Script Date: 5/18/2021 3:05:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhenThuong_KyLuat]') AND type in (N'U'))
DROP TABLE [dbo].[KhenThuong_KyLuat]
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP FUNCTION [dbo].[fulTenSinhVien]
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenLoaiQuyen]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP FUNCTION [dbo].[fulTenLoaiQuyen]
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenLoaiPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP FUNCTION [dbo].[fulTenLoaiPhong]
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenChucVu]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP FUNCTION [dbo].[fulTenChucVu]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP FUNCTION [dbo].[fuConvertToUnsign1]
GO

DECLARE @RoleName sysname
set @RoleName = N'rlTruongToa'

IF @RoleName <> N'public' and (select is_fixed_role from sys.database_principals where name = @RoleName) = 0
BEGIN
    DECLARE @RoleMemberName sysname
    DECLARE Member_Cursor CURSOR FOR
    select [name]
    from sys.database_principals 
    where principal_id in ( 
        select member_principal_id
        from sys.database_role_members
        where role_principal_id in (
            select principal_id
            FROM sys.database_principals where [name] = @RoleName AND type = 'R'))

    OPEN Member_Cursor;

    FETCH NEXT FROM Member_Cursor
    into @RoleMemberName
    
    DECLARE @SQL NVARCHAR(4000)

    WHILE @@FETCH_STATUS = 0
    BEGIN
        
        SET @SQL = 'ALTER ROLE '+ QUOTENAME(@RoleName,'[') +' DROP MEMBER '+ QUOTENAME(@RoleMemberName,'[')
        EXEC(@SQL)
        
        FETCH NEXT FROM Member_Cursor
        into @RoleMemberName
    END;

    CLOSE Member_Cursor;
    DEALLOCATE Member_Cursor;
END
/****** Object:  DatabaseRole [rlTruongToa]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP ROLE [rlTruongToa]
GO

DECLARE @RoleName sysname
set @RoleName = N'rlBanQuanLy'

IF @RoleName <> N'public' and (select is_fixed_role from sys.database_principals where name = @RoleName) = 0
BEGIN
    DECLARE @RoleMemberName sysname
    DECLARE Member_Cursor CURSOR FOR
    select [name]
    from sys.database_principals 
    where principal_id in ( 
        select member_principal_id
        from sys.database_role_members
        where role_principal_id in (
            select principal_id
            FROM sys.database_principals where [name] = @RoleName AND type = 'R'))

    OPEN Member_Cursor;

    FETCH NEXT FROM Member_Cursor
    into @RoleMemberName
    
    DECLARE @SQL NVARCHAR(4000)

    WHILE @@FETCH_STATUS = 0
    BEGIN
        
        SET @SQL = 'ALTER ROLE '+ QUOTENAME(@RoleName,'[') +' DROP MEMBER '+ QUOTENAME(@RoleMemberName,'[')
        EXEC(@SQL)
        
        FETCH NEXT FROM Member_Cursor
        into @RoleMemberName
    END;

    CLOSE Member_Cursor;
    DEALLOCATE Member_Cursor;
END
/****** Object:  DatabaseRole [rlBanQuanLy]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP ROLE [rlBanQuanLy]
GO
/****** Object:  User [truongtoad01]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP USER [truongtoad01]
GO
/****** Object:  User [banquanly]    Script Date: 5/18/2021 3:05:43 PM ******/
DROP USER [banquanly]
GO
/****** Object:  User [banquanly]    Script Date: 5/18/2021 3:05:43 PM ******/
CREATE USER [banquanly] FOR LOGIN [banquanly] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [truongtoad01]    Script Date: 5/18/2021 3:05:43 PM ******/
CREATE USER [truongtoad01] FOR LOGIN [truongtoad01] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [rlBanQuanLy]    Script Date: 5/18/2021 3:05:43 PM ******/
CREATE ROLE [rlBanQuanLy]
GO
/****** Object:  DatabaseRole [rlTruongToa]    Script Date: 5/18/2021 3:05:43 PM ******/
CREATE ROLE [rlTruongToa]
GO
ALTER ROLE [rlBanQuanLy] ADD MEMBER [banquanly]
GO
ALTER ROLE [rlTruongToa] ADD MEMBER [truongtoad01]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- FUNCTIONS
CREATE FUNCTION [dbo].[fuConvertToUnsign1]
(@strInput NVARCHAR(4000))
RETURNS NVARCHAR(4000)
AS
BEGIN
	IF @strInput IS NULL RETURN @strInput
	IF @strInput = '' RETURN @strInput
	DECLARE @RT NVARCHAR(4000)
	DECLARE @SIGN_CHARS NCHAR(136)
	DECLARE @UNSIGN_CHARS NCHAR (136)
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1)) 
			BEGIN
				IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
				BREAK
			END
			SET @COUNTER1 = @COUNTER1 +1
		END
		SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput
END
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenChucVu]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[fulTenChucVu]
(@maChucVu INT)
RETURNS NVARCHAR(100)
AS
BEGIN
	DECLARE @tenChucVu NVARCHAR(100);
	SET @tenChucVu =
	(SELECT TenChucVu
	FROM dbo.ChucVu
	WHERE MaChucVu = @maChucVu);
	RETURN @tenChucVu;
END
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenLoaiPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[fulTenLoaiPhong]
(@maLoai INT)
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @tenLoai NVARCHAR(50);
	SET @tenLoai =
	(SELECT TenLoai
	FROM dbo.LoaiPhong
	WHERE MaLoai = @maLoai);
	RETURN @tenLoai;
END
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenLoaiQuyen]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[fulTenLoaiQuyen]
(@IDLoaiQuyen INT)
RETURNS NVARCHAR(30)
AS
BEGIN
	DECLARE @tenLoai NVARCHAR(30);
	SET @tenLoai =
	(SELECT TenQuyen FROM dbo.LoaiQuyen
	WHERE IDLoaiQuyen = @IDLoaiQuyen);
	RETURN @tenLoai;
END
GO
/****** Object:  UserDefinedFunction [dbo].[fulTenSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[fulTenSinhVien]
(@maSV VARCHAR(15))
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @tenSV NVARCHAR(50);
	SET @tenSV =
	(SELECT HoTen
	FROM dbo.SinhVien
	WHERE MaSV = @maSV);
	RETURN @tenSV;
END
GO
/****** Object:  Table [dbo].[KhenThuong_KyLuat]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong_KyLuat](
	[MaKTKL] [int] IDENTITY(1,1) NOT NULL,
	[HinhThuc] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NOT NULL,
	[NgayTao] [date] NOT NULL,
	[MaSV] [varchar](15) NULL,
 CONSTRAINT [PK_KTKL_MaKTKL] PRIMARY KEY CLUSTERED 
(
	[MaKTKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewKTKL_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- VIEWS
CREATE   VIEW [dbo].[viewKTKL_DGV] AS
SELECT MaKTKL, HinhThuc, NgayTao, MaSV
FROM dbo.KhenThuong_KyLuat;
GO
/****** Object:  Table [dbo].[HoaDonDienNuoc]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonDienNuoc](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[SoDien] [float] NOT NULL,
	[SoNuoc] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MaPhong] [varchar](15) NULL,
 CONSTRAINT [PK_HDDN_MaHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewHoaDonDienNuoc_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW [dbo].[viewHoaDonDienNuoc_DGV] AS
SELECT MaPhong, MaHoaDon,
ThanhTien, NgayLap, TrangThai
FROM dbo.HoaDonDienNuoc;
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](15) NOT NULL,
	[SucChuaSV] [tinyint] NOT NULL,
	[SLDangO] [tinyint] NOT NULL,
	[MaLoai] [int] NULL,
	[TenToa] [varchar](15) NULL,
 CONSTRAINT [PK_Phong_MaPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW [dbo].[viewPhong_DGV] AS
SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai,
SucChuaSV, SLDangO, TenToa
FROM dbo.Phong;
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[TenToa] [varchar](15) NULL,
	[MaChucVu] [int] NULL,
 CONSTRAINT [PK_NhanVien_MaNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewNhanVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW [dbo].[viewNhanVien_DGV] AS
SELECT MaNV, HoTen, NgaySinh, TenToa,
dbo.fulTenChucVu(maChucVu) AS TenChucVu
FROM dbo.NhanVien;
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [varchar](15) NOT NULL,
	[CMND] [varchar](12) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[DienThoai] [varchar](15) NULL,
	[MaPhong] [varchar](15) NULL,
 CONSTRAINT [PK_SinhVien_MaSV] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewSinhVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW [dbo].[viewSinhVien_DGV] AS
SELECT MaSV, HoTen, GioiTinh,
NgaySinh, DienThoai, MaPhong
FROM dbo.SinhVien;
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChucVu_MaChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong_NV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong_NV](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[NgayLap] [date] NOT NULL,
	[LuongThang] [float] NOT NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_HopDongNV_MaHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong_SV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong_SV](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[NgayLap] [date] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[MaSV] [varchar](15) NULL,
 CONSTRAINT [PK_HopDongSV_MaHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_LoaiPhong_MaLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiQuyen]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiQuyen](
	[IDLoaiQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](30) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_LoaiQuyen_IDLoaiQuyen] PRIMARY KEY CLUSTERED 
(
	[IDLoaiQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [varchar](15) NOT NULL,
	[MatKhau] [varchar](1000) NOT NULL,
	[IDLoaiQuyen] [int] NULL,
 CONSTRAINT [PK_TaiKhoan_TenTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanNhan]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanNhan](
	[CMND] [varchar](12) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[QuanHeVoiSV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[MaSV] [varchar](15) NULL,
 CONSTRAINT [PK_ThanNhan_CMND] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toa]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toa](
	[TenToa] [varchar](15) NOT NULL,
	[SLPhong] [int] NOT NULL,
 CONSTRAINT [PK_Toa_TenToa] PRIMARY KEY CLUSTERED 
(
	[TenToa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (1, N'Trưởng tòa')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (2, N'Bảo vệ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (3, N'Lao công')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonDienNuoc] ON 

INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (1, 5, 180, 200000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-101')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (3, 4.5, 160, 250000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-102')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (4, 4.5, 170, 260000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-103')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (5, 3, 160, 190000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-104')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (6, 6, 200, 350000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-105')
SET IDENTITY_INSERT [dbo].[HoaDonDienNuoc] OFF
GO
SET IDENTITY_INSERT [dbo].[HopDong_NV] ON 

INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (1, CAST(N'2010-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 1000000000, 1)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (2, CAST(N'2011-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 2000000, 2)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (3, CAST(N'2012-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 1000000000, 3)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (4, CAST(N'2010-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 1000000000, 4)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (5, CAST(N'2011-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 2000000, 5)
SET IDENTITY_INSERT [dbo].[HopDong_NV] OFF
GO
SET IDENTITY_INSERT [dbo].[HopDong_SV] ON 

INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (1, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110276')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (2, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110031')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (3, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110220')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (4, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110255')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (5, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19119122')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (6, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20147149')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (7, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20147049')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (8, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20147201')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (9, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20147228')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (10, CAST(N'2021-05-18' AS Date), CAST(N'2002-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20147053')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (11, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20145637')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (12, CAST(N'2021-05-18' AS Date), CAST(N'2021-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20147205')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (14, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'17119115')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (15, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20145154')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (16, CAST(N'2021-05-18' AS Date), CAST(N'2022-05-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'18147153')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (17, CAST(N'2021-05-18' AS Date), CAST(N'2022-05-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'17145156')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (18, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'19151317')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (19, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'19154034')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (20, CAST(N'2021-05-18' AS Date), CAST(N'2022-05-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'18125365')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (21, CAST(N'2021-05-18' AS Date), CAST(N'2022-06-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'18151365')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (22, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19125124')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (23, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19151216')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (24, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19125123')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (25, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19147563')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (26, CAST(N'2021-05-18' AS Date), CAST(N'2022-05-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'18109156')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (27, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20109145')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (28, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20151369')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (29, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20110115')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (30, CAST(N'2021-05-18' AS Date), CAST(N'2022-05-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'18116102')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (31, CAST(N'2021-05-18' AS Date), CAST(N'2022-05-18' AS Date), CAST(N'2021-05-18' AS Date), 1000000, N'18124159')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (32, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20145138')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (33, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20125140')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (34, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19109112')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (35, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19106150')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (36, CAST(N'2021-05-18' AS Date), CAST(N'2023-05-18' AS Date), CAST(N'2021-05-18' AS Date), 2000000, N'19116111')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (37, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20116200')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (38, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20125115')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (39, CAST(N'2021-05-18' AS Date), CAST(N'2024-05-18' AS Date), CAST(N'2021-05-18' AS Date), 3000000, N'20124222')
SET IDENTITY_INSERT [dbo].[HopDong_SV] OFF
GO
SET IDENTITY_INSERT [dbo].[KhenThuong_KyLuat] ON 

INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (1, N'Khen Thưởng', N'Nhận 50 triệu VND', CAST(N'2021-06-06' AS Date), N'19110276')
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (2, N'Khen Thưởng', N'Nhận 30 triệu VND', CAST(N'2021-09-09' AS Date), N'19110031')
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (3, N'Khen Thưởng', N'Nhận 3 triệu VND', CAST(N'2021-05-19' AS Date), N'19110255')
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (4, N'Khen Thưởng', N'Giấy khen thưởng', CAST(N'2021-05-19' AS Date), N'19110220')
SET IDENTITY_INSERT [dbo].[KhenThuong_KyLuat] OFF
GO
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai]) VALUES (1, N'Nam')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai]) VALUES (2, N'Nữ')
GO
SET IDENTITY_INSERT [dbo].[LoaiQuyen] ON 

INSERT [dbo].[LoaiQuyen] ([IDLoaiQuyen], [TenQuyen], [MoTa]) VALUES (1, N'Ban Quản Lý', N'Ban Quản lý KTX')
INSERT [dbo].[LoaiQuyen] ([IDLoaiQuyen], [TenQuyen], [MoTa]) VALUES (2, N'Trưởng Tòa', N'Trưởng tòa trong KTX')
SET IDENTITY_INSERT [dbo].[LoaiQuyen] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (1, N'Phan Thanh A', CAST(N'1980-07-17' AS Date), N'Hồ Chí Minh', N'0965369999', N'D01', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (2, N'Nguyễn Văn B', CAST(N'1990-04-01' AS Date), N'Bình Định', N'0856985645', N'D01', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (3, N'Trần Thanh C', CAST(N'1995-09-08' AS Date), N'Tiền Giang', N'0965865478', N'D01', 3)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (4, N'Trần Thị E', CAST(N'1987-09-08' AS Date), N'Tiền Giang', N'0965865478', N'D01', 3)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (5, N'Văn Trần K', CAST(N'1990-05-04' AS Date), N'Hồ Chí Minh', N'0965854785', N'D01', 2)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-101', 4, 3, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-102', 4, 2, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-103', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-104', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-105', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-106', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-107', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-108', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-109', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-110', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-201', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-202', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-203', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-204', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-205', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-206', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-207', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-208', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-209', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-210', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-301', 4, 4, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-302', 4, 4, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-303', 4, 2, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-304', 4, 3, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-305', 4, 4, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-306', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-307', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-308', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-309', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-310', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-401', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-402', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-403', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-404', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-405', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-406', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-407', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-408', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-409', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-410', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-501', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-502', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-503', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-504', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-505', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-506', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-507', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-508', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-509', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-510', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-101', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-102', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-103', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-104', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-105', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-106', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-107', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-108', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-109', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-110', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-201', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-202', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-203', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-204', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-205', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-206', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-207', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-208', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-209', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-210', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-301', 4, 2, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-302', 4, 3, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-303', 4, 3, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-304', 4, 4, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-305', 4, 4, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-306', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-307', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-308', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-309', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-310', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-401', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-402', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-403', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-404', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-405', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-406', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-407', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-408', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-409', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-410', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-501', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-502', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-503', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-504', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-505', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-506', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-507', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-508', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-509', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-510', 4, 0, 2, N'D02')
GO
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'17119115', N'100010111', N'Nguyễn Thành Lanh', N'Nam', CAST(N'1998-01-27' AS Date), N'Đà Lạt', N'0635214569', N'D01-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'17145156', N'100011011', N'Nguyễn Trần Thành Công', N'Nam', CAST(N'1998-06-16' AS Date), N'Quảng Ngãi', N'0365236598', N'D01-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'18109156', N'100101101', N'Trần Kim Ngân', N'Nữ', CAST(N'1999-06-15' AS Date), N'Bình Thuận', N'0325698654', N'D02-303')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'18116102', N'100110101', N'Nguyễn Thị Ngọc Lan', N'Nữ', CAST(N'1999-07-15' AS Date), N'Đồng Nai', N'0965841236', N'D02-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'18124159', N'100111000', N'Trần Thị Thu Hà', N'Nữ', CAST(N'1999-10-20' AS Date), N'Nghệ An', N'0698532659', N'D02-303')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'18125365', N'100100001', N'Nguyễn Nam Phương', N'Nam', CAST(N'1999-07-15' AS Date), N'Vũng Tàu', N'0369658654', N'D01-301')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'18147153', N'100010101', N'Dương Minh Hiếu', N'Nam', CAST(N'1999-02-23' AS Date), N'Đà lạt', N'0158745632', N'D01-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'18151365', N'100100011', N'Võ Văn Lộc', N'Nam', CAST(N'1999-08-10' AS Date), N'Lâm Đồng', N'0326589645', N'D01-301')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19106150', N'100111111', N'Lê Thị Thanh Nga', N'Nữ', CAST(N'2001-07-09' AS Date), N'Nghệ An', N'0965874563', N'D02-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19109112', N'100111101', N'Nguyễn Thị Bích Huyền', N'Nữ', CAST(N'2023-05-18' AS Date), N'Bình Phước ', N'0965846523', N'D02-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110031', N'215512158', N'Nguyễn Hoàng Nhật', N'Nam', CAST(N'2001-02-04' AS Date), N'Bình Định', N'0762539444', N'D01-101')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110220', N'658569856', N'Bùi Lê Quốc Hưng', N'Nam', CAST(N'2001-09-09' AS Date), N'Quảng Ngãi', N'0987568564', N'D01-102')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110255', N'325658568', N'Nguyễn Minh Nhật', N'Nam', CAST(N'2001-11-24' AS Date), N'Kon Tum', N'0785965877', N'D01-102')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110276', N'221521676', N'Phan Thanh Sang', N'Nam', CAST(N'2001-06-17' AS Date), N'Phú Yên', N'0327285263', N'D01-101')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19116111', N'101000011', N'Nguyễn Khánh Vy', N'Nữ', CAST(N'2001-08-23' AS Date), N'Gia Lai', N'0965842364', N'D02-303')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19119122', N'272736334', N'Đỗ Minh Quân', N'Nam', CAST(N'2001-01-28' AS Date), N'Đồng Nai', N'0965809465', N'D01-101')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19125123', N'100101001', N'Nguyễn Thị Hồng Thịnh', N'Nữ', CAST(N'2001-04-01' AS Date), N'Đồng Nai', N'0365241587', N'D02-301')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19125124', N'100100101', N'Phan Trọng Hoàng', N'Nam', CAST(N'2001-01-21' AS Date), N'Đồng Nai', N'0365258796', N'D01-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19147563', N'100101011', N'Nguyễn Thị Dung', N'Nữ', CAST(N'2021-05-18' AS Date), N'Vũng Tàu', N'0321458756', N'D02-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19151216', N'100100111', N'Trần Hoàng Ân', N'Nam', CAST(N'2001-02-01' AS Date), N'Bình Thuận', N'0365326985', N'D01-303')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19151317', N'100011101', N'Dương Hoàng Nam', N'Nam', CAST(N'2001-05-04' AS Date), N'Đồng Nai', N'0965865421', N'D01-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19154034', N'100011111', N'Nguyễn Đăng Khoa', N'Nam', CAST(N'2001-06-04' AS Date), N'Đồng nai', N'0369658214', N'D01-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20109145', N'100101111', N'Lê Như', N'Nữ', CAST(N'2002-06-11' AS Date), N'Vũng Tàu', N'0365258963', N'D02-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20110115', N'100110011', N'Nguyễn Thị Ngọc Bích', N'Nữ', CAST(N'2002-03-02' AS Date), N'Nghệ An', N'0965823654', N'D02-301')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20116200', N'101000101', N'Lê Thị Bích Ly', N'Nữ', CAST(N'2002-01-01' AS Date), N'Quãng Ngãi', N'0965841234', N'D02-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20124222', N'101001001', N'Hoàng hà Anh', N'Nữ', CAST(N'2002-06-02' AS Date), N'Lâm Đồng', N'0965845216', N'D02-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20125115', N'101000111', N'Lê Nguyễn Thuc Quyên', N'Nữ', CAST(N'2002-03-06' AS Date), N'TP.Hồ Chí Minh', N'0936521456', N'D02-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20125140', N'100111011', N'Nguyễn Thị Bích Trâm', N'Nữ', CAST(N'2002-08-06' AS Date), N'Đồng Nai', N'0965841226', N'D02-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20145138', N'100111001', N'Đỗ Hồng Phúc', N'Nữ', CAST(N'2002-03-20' AS Date), N'Quãng Ngãi', N'0369521367', N'D02-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20145154', N'100011001', N'Dương Minh Hiếu', N'Nam', CAST(N'2002-08-13' AS Date), N'Đồng Nai', N'0658945215', N'D01-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20145637', N'100010001', N'Nguyễn Duy Minh Trí  ', N'Nam', CAST(N'2002-02-06' AS Date), N'Đồng Nai', N'0698754125', N'D01-301')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20147049', N'100001001', N'Nguyễn Đình Tân', N'Nam', CAST(N'2001-10-09' AS Date), N'Bình Phước', N'0569874125', N'D01-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20147053', N'100001111', N'Nguyễn Đình Quốc ', N'Nam', CAST(N'2002-07-16' AS Date), N'TP.Hồ Chí Minh', N'0965806412', N'D01-305')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20147149', N'100000111', N'Nguyễn Tiến Dũng', N'Nam', CAST(N'2002-03-20' AS Date), N'Nghệ An', N'0956846134', N'D01-301')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20147201', N'100001011', N'Dương Minh Nhựt', N'Nam', CAST(N'2021-12-30' AS Date), N'Gia Lai', N'0965823546', N'D01-303')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20147205', N'100010011', N'Đỗ Doãn Phương ', N'Nam', CAST(N'2002-07-25' AS Date), N'Đà Nẵng', N'0654785214', N'D01-302')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20147228', N'100001101', N'Đoàn Anh Tuấn      ', N'Nam', CAST(N'2002-07-16' AS Date), N'Quảng Ngãi', N'0569875324', N'D01-304')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'20151369', N'100110001', N'Lê Thị Hạnh', N'Nữ', CAST(N'2002-02-26' AS Date), N'Đà Lạt', N'0695845632', N'D02-305')
GO
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [IDLoaiQuyen]) VALUES (N'banquanly', N'admin', 1)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [IDLoaiQuyen]) VALUES (N'truongtoad01', N'matkhau', 2)
GO
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100001000', N'Nguyễn Văn Ba', N'Nam', N'Cha của sinh viên', N'Nghệ An', N'0236589465', N'20147149')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100001010', N'Nguyễn Thị Bé', N'Nữ', N'Mẹ của sinh viên', N'Bình Phước', N'0987542364', N'20147049')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100001100', N'Dương Minh Hiếu', N'Nam', N'Cha của sinh viên', N'Gia Lai', N'0365896542', N'20147201')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100001110', N'Đoàn Minh Đức', N'Nam', N'Cha của sinh viên', N'Quảng Ngãi', N'0698564216', N'20147228')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100010000', N'Nguyễn Đình Triêm', N'Nam', N'Cha của sinh viên', N'TP.Hồ Chí Minh', N'0658975423', N'20147053')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100010010', N'Nguyễn Thành Lanh', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0369875412', N'20145637')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100010100', N'Đỗ Văn Quốc', N'Nam', N'Cha của sinh viên', N'Đà Nẵng', N'0369852147', N'20147205')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100010110', N'Dương Văn Công', N'Nam', N'Cha của sinh viên', N'Đà Lạt', N'0369586542', N'18147153')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100011000', N'Nguyễn Thành Công', N'Nam', N'Cha của sinh viên', N'Đà Lạt', N'0369658423', N'17119115')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100011010', N'Dương Văn Hồ', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0369658961', N'20145154')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100011100', N'Trần Thị Thu', N'Nữ', N'Mẹ của sinh viên', N'Quảng Ngãi', N'0365256369', N'17145156')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100011110', N'Dương Thái Hưng', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0365254697', N'19151317')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100100000', N'Nguyễn Thị Kim Loan', N'Nữ', N'Mẹ của sinh viên', N'Đồng Nai', N'0365214569', N'19154034')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100100010', N'Nguyễn Văn Phong', N'Nam', N'Cha của sinh viên', N'Vũng tàu', N'0369587456', N'18125365')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100100100', N'Võ Lâm', N'Nam', N'Cha của sinh viên', N'Lâm Đồng', N'0365254698', N'18151365')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100100110', N'Phan Hoàn', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0965478523', N'19125124')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100101000', N'Trần Văn Chí', N'Nam', N'Cha của sinh viên', N'Bình Thuận', N'0325632541', N'19151216')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100101010', N'Nguyễn Văn Sử', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0365214789', N'19125123')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100101100', N'Nguyễn Văn Chiến', N'Nam', N'Cha của sinh viên', N'Vũng Tàu', N'0326565986', N'19147563')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100101110', N'Trần Văn Sĩ', N'Nam', N'Cha của sinh viên', N'Bình Thuận', N'0356996587', N'18109156')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100110000', N'Lê Trần Minh Trí', N'Nam', N'Cha của sinh viên', N'Vũng Tàu', N'096583265', N'20109145')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100110010', N'Lê Thị Lan', N'Nữ', N'Mẹ của sinh viên', N'Đà Lạt', N'0986585632', N'20151369')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100110100', N'Nguyễn Thành Lâm', N'Nam', N'Cha sinh viên', N'Nghệ An', N'0163654623', N'20110115')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100110110', N'Nguyễn Văn Tài', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0965845213', N'18116102')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100110111', N'Trần Thị Thu', N'Nữ', N'Mẹ của sinh viên', N'Nghệ An', N'0635236593', N'18124159')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100111010', N'Đỗ Văn Sơn', N'Nam', N'Cha của sinh viên', N'Quãng Ngãi', N'0354126965', N'20145138')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100111100', N'Nguyễn Văn Đức', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0965832654', N'20125140')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'100111110', N'Nguyễn Đức Huy', N'Nam', N'Cha của sinh viên', N'Bình Phước', N'0635624178', N'19109112')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'101000000', N'Lê Thị hạnh', N'Nữ', N'Mẹ của sinh viên', N'Nghệ An', N'0965894123', N'19106150')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'101000100', N'Nguyễn Văn Cao', N'Nam', N'Cha của sinh viên', N'Gia Lai', N'0163564562', N'19116111')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'101000110', N'Lê Văn Đoan', N'Nam', N'Cha của sinh viên', N'Quãng Ngãi', N'0365914523', N'20116200')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'101001000', N'Lê Quốc Việt', N'Nam', N'Cha của sinh viên', N'TP.Hồ Chí Minh', N'0365421129', N'20125115')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'101001010', N'Hoàng Hà', N'Nữ', N'Mẹ của sinh viên', N'Lâm Đồng', N'0163265217', N'20124222')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456786', N'Ba của Hưng', N'Nam', N'Cha của sinh viên', N'Lâm Đồng', N'0369857852', N'19110220')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456787', N'Ba của M Nhật', N'Nam', N'Cha của sinh viên', N'Kon Tum', N'0369857854', N'19110255')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456788', N'Ba của H Nhật', N'Nam', N'Cha của sinh viên', N'Bình Định', N'0328296555', N'19110031')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456789', N'Ba của Sang', N'Nam', N'Cha của sinh viên', N'Phú Yên', N'0322145623', N'19110276')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'125364864', N'Ba của Quân', N'Nam', N'Cha của sinh viên', N'Đồng Nai', N'0908716681', N'19119122')
GO
INSERT [dbo].[Toa] ([TenToa], [SLPhong]) VALUES (N'D01', 100)
INSERT [dbo].[Toa] ([TenToa], [SLPhong]) VALUES (N'D02', 100)
GO
ALTER TABLE [dbo].[HoaDonDienNuoc]  WITH CHECK ADD  CONSTRAINT [FK_HDDN_MaPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDonDienNuoc] CHECK CONSTRAINT [FK_HDDN_MaPhong]
GO
ALTER TABLE [dbo].[HopDong_NV]  WITH CHECK ADD  CONSTRAINT [FK_HopDongNV_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HopDong_NV] CHECK CONSTRAINT [FK_HopDongNV_MaNV]
GO
ALTER TABLE [dbo].[HopDong_SV]  WITH CHECK ADD  CONSTRAINT [FK_HopDongSV_MaSV] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HopDong_SV] CHECK CONSTRAINT [FK_HopDongSV_MaSV]
GO
ALTER TABLE [dbo].[KhenThuong_KyLuat]  WITH CHECK ADD  CONSTRAINT [FK_KTKL_MaSV] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhenThuong_KyLuat] CHECK CONSTRAINT [FK_KTKL_MaSV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_MaChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TenToa] FOREIGN KEY([TenToa])
REFERENCES [dbo].[Toa] ([TenToa])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TenToa]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiPhong] ([MaLoai])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_MaLoai]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_TenToa] FOREIGN KEY([TenToa])
REFERENCES [dbo].[Toa] ([TenToa])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_TenToa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_MaPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_MaPhong]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_IDLoaiQuyen] FOREIGN KEY([IDLoaiQuyen])
REFERENCES [dbo].[LoaiQuyen] ([IDLoaiQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_IDLoaiQuyen]
GO
ALTER TABLE [dbo].[ThanNhan]  WITH CHECK ADD  CONSTRAINT [FK_ThanNhan_MaSV] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThanNhan] CHECK CONSTRAINT [FK_ThanNhan_MaSV]
GO
/****** Object:  StoredProcedure [dbo].[spLayHDNV_TheoMaHD]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayHDNV_TheoMaHD]
(@maHD INT)
AS
BEGIN
	SELECT *
	FROM dbo.HopDong_NV
	WHERE MaHD = @maHD;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayHDSV_TheoMaHD]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayHDSV_TheoMaHD]
(@maHD INT)
AS
BEGIN
	SELECT *
	FROM dbo.HopDong_SV
	WHERE MaHD = @maHD;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayHoaDonDienNuoc_DGV]
AS
BEGIN
	--SELECT MaPhong, MaHoaDon,
	--ThanhTien, NgayLap, TrangThai
	--FROM dbo.HoaDonDienNuoc;
	SELECT * FROM dbo.viewHoaDonDienNuoc_DGV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_TheoMaHoaDon]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayHoaDonDienNuoc_TheoMaHoaDon]
(@maHoaDon INT)
AS
BEGIN
	SELECT *
	FROM dbo.HoaDonDienNuoc
	WHERE MaHoaDon = @maHoaDon;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_TheoPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayHoaDonDienNuoc_TheoPhong_DGV]
(@maPhong VARCHAR(15))
AS
BEGIN
	SELECT MaHoaDon, ThanhTien, NgayLap, TrangThai
	FROM dbo.HoaDonDienNuoc
	WHERE MaPhong = @maPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayHoaDonDienNuoc_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayHoaDonDienNuoc_TimKiem_DGV]
(@str NVARCHAR(200))
AS
BEGIN
	SELECT MaPhong, MaHoaDon,
	ThanhTien, NgayLap, TrangThai
	FROM dbo.HoaDonDienNuoc
	WHERE MaPhong LIKE @str OR
	MaHoaDon LIKE @str OR
	ThanhTien LIKE @str OR
	NgayLap LIKE @str OR
	dbo.fuConvertToUnsign1(TrangThai) LIKE dbo.fuConvertToUnsign1(@str);
END
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayKTKL_DGV]
AS
BEGIN
	--SELECT MaKTKL, HinhThuc, NgayTao, MaSV
	--FROM dbo.KhenThuong_KyLuat;
	SELECT * FROM dbo.viewKTKL_DGV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_TheoMaKTKL]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayKTKL_TheoMaKTKL]
(@maKTKL INT)
AS
BEGIN
	SELECT *,
	dbo.fulTenSinhVien(MaSV) AS TenSV
	FROM dbo.KhenThuong_KyLuat
	WHERE MaKTKL = @maKTKL;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_TheoMaSV_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayKTKL_TheoMaSV_DGV]
(@maSV VARCHAR(15))
AS
BEGIN
	SELECT MaKTKL, HinhThuc, NgayTao
	FROM dbo.KhenThuong_KyLuat
	WHERE MaSV = @maSV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayKTKL_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayKTKL_TimKiem_DGV]
(@str NVARCHAR(200))
AS
BEGIN
	SELECT MaKTKL, HinhThuc, NgayTao, MaSV
	FROM dbo.KhenThuong_KyLuat
	WHERE MaKTKL LIKE @str OR
	dbo.fuConvertToUnsign1(HinhThuc) LIKE dbo.fuConvertToUnsign1(@str) OR
	NgayTao LIKE @str OR
	MaSV LIKE @str;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayLoaiChucVu]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayLoaiChucVu]
AS
BEGIN
	SELECT * FROM dbo.ChucVu;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayLoaiPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayLoaiPhong]
AS
BEGIN
	SELECT * FROM dbo.LoaiPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayNhanVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayNhanVien_DGV]
AS
BEGIN
	--SELECT MaNV, HoTen, NgaySinh, TenToa,
	--dbo.fulTenChucVu(maChucVu) AS TenChucVu
	--FROM dbo.NhanVien;
	SELECT * FROM dbo.viewNhanVien_DGV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayNhanVien_TheoMaNV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayNhanVien_TheoMaNV]
(@maNV INT)
AS
BEGIN
	SELECT MaNV, HoTen, NgaySinh, DiaChi, DienThoai,
	TenToa, MaChucVu, dbo.fulTenChucVu(MaChucVu) AS TenChucVu,
	(SELECT MaHD FROM dbo.HopDong_NV
	WHERE HopDong_NV.MaNV = NhanVien.MaNV) AS MaHD
	FROM dbo.NhanVien
	WHERE MaNV = @maNV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayNhanVien_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayNhanVien_TimKiem_DGV]
(@str NVARCHAR(200))
AS
BEGIN
	SELECT MaNV, HoTen, NgaySinh, TenToa,
	dbo.fulTenChucVu(MaChucVu) AS TenChucVu
	FROM dbo.NhanVien
	WHERE MaNV LIKE @str OR
	dbo.fuConvertToUnsign1(HoTen) LIKE dbo.fuConvertToUnsign1(@str) OR
	NgaySinh LIKE @str OR
	TenToa LIKE @str OR
	dbo.fuConvertToUnsign1(dbo.fulTenChucVu(MaChucVu)) LIKE dbo.fuConvertToUnsign1(@str);
END
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayPhong_DGV]
AS
BEGIN
	--SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai,
	--SucChuaSV, SLDangO, TenToa
	--FROM dbo.Phong;
	SELECT * FROM dbo.viewPhong_DGV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_TheoMaPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayPhong_TheoMaPhong]
(@maPhong VARCHAR(15))
AS
BEGIN
	SELECT MaPhong, SucChuaSV, SLDangO, MaLoai,
	dbo.fulTenLoaiPhong(MaLoai) AS TenLoai, TenToa
	FROM dbo.Phong
	WHERE MaPhong = @maPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_TheoToa]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[spLayPhong_TheoToa]
(@tenToa VARCHAR(15))
AS
BEGIN
	SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai,
	SucChuaSV, SLDangO
	FROM dbo.Phong
	WHERE TenToa = @tenToa;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayPhong_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayPhong_TimKiem_DGV]
(@str NVARCHAR(200))
AS
BEGIN
	SELECT MaPhong, dbo.fulTenLoaiPhong(MaLoai) AS TenLoai,
	SucChuaSV, SLDangO, TenToa
	FROM dbo.Phong
	WHERE MaPhong LIKE @str OR
	dbo.fuConvertToUnsign1(dbo.fulTenLoaiPhong(MaLoai)) LIKE dbo.fuConvertToUnsign1(@str) OR
	SucChuaSV LIKE @str OR
	SLDangO LIKE @str OR
	TenToa LIKE @str;
END
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLaySinhVien_DGV]
AS
BEGIN
	SELECT * FROM dbo.viewSinhVien_DGV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_TheoMaSV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLaySinhVien_TheoMaSV]
(@maSV VARCHAR(15))
AS
BEGIN
	SELECT *,
	(SELECT MaHD FROM dbo.HopDong_SV WHERE MaSV = @maSV) AS MaHD,
	(SELECT CMND FROM dbo.ThanNhan WHERE MaSV = @maSV) AS CMND_TN
	FROM dbo.SinhVien
	WHERE MaSV = @maSV;
END
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_TheoPhong_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLaySinhVien_TheoPhong_DGV]
(@maPhong VARCHAR(15))
AS
BEGIN
	SELECT MaSV, HoTen, DienThoai
	FROM dbo.SinhVien
	WHERE MaPhong = @maPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[spLaySinhVien_TimKiem_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLaySinhVien_TimKiem_DGV]
(@str NVARCHAR(200))
AS
BEGIN
	SELECT MaSV, HoTen, GioiTinh,
	NgaySinh, DienThoai, MaPhong
	FROM dbo.SinhVien
	WHERE MaSV LIKE @str OR
	dbo.fuConvertToUnsign1(HoTen) LIKE dbo.fuConvertToUnsign1(@str) OR
	dbo.fuConvertToUnsign1(GioiTinh )LIKE dbo.fuConvertToUnsign1(@str) OR
	NgaySinh LIKE @str OR
	DienThoai LIKE @str OR
	MaPhong LIKE @str;
END
GO
/****** Object:  StoredProcedure [dbo].[spLaySoPhongConTrong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLaySoPhongConTrong]
AS SELECT COUNT(MaPhong) FROM dbo.Phong WHERE SLDangO = 0;
GO
/****** Object:  StoredProcedure [dbo].[spLayTaiKhoan_DGV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTaiKhoan_DGV]
AS
BEGIN
	SELECT TenTaiKhoan,	dbo.fulTenLoaiQuyen(IDLoaiQuyen)
	FROM dbo.TaiKhoan;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayTaiKhoan_TheoTenTK]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTaiKhoan_TheoTenTK]
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
/****** Object:  StoredProcedure [dbo].[spLayTaiKhoan_TheoTKMK]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTaiKhoan_TheoTKMK]
(@taiKhoan VARCHAR(15), @matKhau VARCHAR(1000))
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan
	WHERE TenTaiKhoan = @taiKhoan AND
	MatKhau = @matKhau;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayThanNhan_TheoCMNDTN]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayThanNhan_TheoCMNDTN]
(@CMNDTN VARCHAR(12))
AS
BEGIN
	SELECT *
	FROM dbo.ThanNhan
	WHERE CMND = @CMNDTN;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayToa]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayToa]
AS
BEGIN
	SELECT * FROM dbo.Toa;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSoPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTongSoPhong]
AS SELECT COUNT(MaPhong) FROM dbo.Phong;
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSoSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTongSoSinhVien]
AS
BEGIN
	SELECT COUNT(MaSV) FROM dbo.SinhVien;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSoToa]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTongSoToa]
AS
BEGIN
	SELECT COUNT(TenToa) FROM dbo.Toa;
END
GO
/****** Object:  StoredProcedure [dbo].[spLayTongSucChua]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spLayTongSucChua]
AS SELECT SUM(SucChuaSV) FROM dbo.Phong;
GO
/****** Object:  StoredProcedure [dbo].[spSuaHoaDonDienNuoc]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spSuaHoaDonDienNuoc]
(@maHoaDon INT, @trangThai NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.HoaDonDienNuoc
	SET TrangThai = @trangThai
	WHERE MaHoaDon = @maHoaDon;
END
GO
/****** Object:  StoredProcedure [dbo].[spSuaNhanVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spSuaNhanVien]
(@maNV INT, @hoTen NVARCHAR(50), @ngaySinh VARCHAR(15),
@diaChi NVARCHAR(150), @dienThoai VARCHAR(15),
@tenToa VARCHAR(15), @maChucVu INT, @ngayBatDau VARCHAR(15),
@ngayKetThuc VARCHAR(15), @ngayLap VARCHAR(15), @luongThang FLOAT)
AS
BEGIN
	BEGIN TRANSACTION SuaNV;

	UPDATE dbo.NhanVien
	SET HoTen = @hoTen, NgaySinh = @ngaySinh,
	DiaChi = @diaChi, DienThoai = @dienThoai,
	TenToa = @tenToa, MaChucVu = @maChucVu
	WHERE MaNV = @maNV;

	IF (EXISTS(SELECT MaHD FROM dbo.HopDong_NV
		WHERE MaNV = @maNV AND
		(NgayBatDau <> @ngayBatDau OR NgayKetThuc <> @ngayKetThuc OR
		NgayLap <> @ngayLap OR LuongThang <> @luongThang)))
		BEGIN
			DELETE FROM dbo.HopDong_NV WHERE MaNV = @maNV;
			INSERT INTO dbo.HopDong_NV VALUES
			(@ngayBatDau, @ngayKetThuc, @ngayLap, @luongThang, @maNV)
		END

	COMMIT TRANSACTION SuaNV;
END
GO
/****** Object:  StoredProcedure [dbo].[spSuaPhong]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spSuaPhong]
(@maPhong VARCHAR(15), @maLoai INT,
@sucChua TINYINT)
AS
BEGIN
	BEGIN TRANSACTION SuaPhong;

	UPDATE dbo.Phong
	SET MaLoai = @maLoai,
	SucChuaSV = @sucChua
	WHERE MaPhong = @maPhong;

	IF (EXISTS(SELECT MaSV FROM dbo.SinhVien, dbo.Phong
	WHERE SinhVien.MaPhong = @maPhong AND
	SinhVien.GioiTinh <> (SELECT dbo.fulTenLoaiPhong(MaLoai)
	FROM dbo.Phong WHERE MaPhong = @maPhong)))
	BEGIN
		RAISERROR('Chỉ được đổi loại phòng khi phòng trống!', 16, 1);
		ROLLBACK TRANSACTION SuaPhong;
	END
	ELSE IF (@sucChua <
	(SELECT SLDangO FROM dbo.Phong
	WHERE MaPhong = @maPhong))
	BEGIN
		RAISERROR('Sức chứa mới sửa ít nhất phải bằng số lượng sinh viên đang ở trong phòng!', 16, 1);
		ROLLBACK TRANSACTION SuaPhong;
	END
	ELSE
		COMMIT TRANSACTION SuaPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[spSuaSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- UPDATE
--------------------------------------------------------------
CREATE   PROCEDURE [dbo].[spSuaSinhVien]
(@maSV VARCHAR(15), @CMND VARCHAR(12), @hoTen NVARCHAR(50),
@gioiTinh NVARCHAR(10), @ngaySinh VARCHAR(15), @diaChi NVARCHAR(150),
@dienThoai VARCHAR(15),	@CMND_TN VARCHAR(12), @hoTen_TN NVARCHAR(50),
@gioiTinh_TN NVARCHAR(10), @quanHeSV NVARCHAR(50), @diaChi_TN NVARCHAR(150),
@dienThoai_TN VARCHAR(15), @maPhong VARCHAR(15), @ngayBatDau VARCHAR(15),
@ngayKetThuc VARCHAR(15), @ngayLap VARCHAR(15), @thanhTien FLOAT)
AS
BEGIN
	BEGIN TRANSACTION SuaSV
		UPDATE dbo.SinhVien
		SET CMND = @CMND, HoTen = @hoTen, GioiTinh = @gioiTinh,
		NgaySinh = @ngaySinh, DiaChi = @diaChi, DienThoai = @dienThoai,
		MaPhong = @maPhong
		WHERE MaSV = @maSV;

		UPDATE dbo.ThanNhan
		SET CMND = @CMND_TN, HoTen = @hoTen_TN, GioiTinh = @gioiTinh_TN,
		QuanHeVoiSV = @quanHeSV, DiaChi = @diaChi_TN,
		DienThoai = @dienThoai_TN
		WHERE MaSV = @maSV;

		IF (EXISTS(SELECT MaHD FROM dbo.HopDong_SV
		WHERE MaSV = @maSV AND
		(NgayBatDau <> @ngayBatDau OR NgayKetThuc <> @ngayKetThuc OR
		NgayLap <> @ngayLap OR ThanhTien <> @thanhTien)))
		BEGIN
			DELETE FROM dbo.HopDong_SV WHERE MaSV = @maSV;
			INSERT INTO dbo.HopDong_SV VALUES
			(@ngayBatDau, @ngayKetThuc, @ngayLap, @thanhTien, @maSV)
		END

		IF ((SELECT COUNT(MaSV) FROM dbo.SinhVien
		WHERE MaPhong = @maPhong) > (SELECT SucChuaSV
		FROM dbo.Phong WHERE MaPhong = @maPhong))
		BEGIN
			RAISERROR ('Phòng này đầy rồi!!!', 16, 1);
			ROLLBACK TRANSACTION SuaSV;
		END
		ELSE IF ((SELECT dbo.fulTenLoaiPhong(MaLoai) FROM dbo.Phong
		WHERE MaPhong = @maPhong) <> @gioiTinh)
		BEGIN
			RAISERROR ('Hãy chọn đúng loại phòng!!!', 16, 1);
			ROLLBACK TRANSACTION SuaSV;
		END
		ELSE
			COMMIT TRANSACTION SuaSV;
END
GO
/****** Object:  StoredProcedure [dbo].[spThemHoaDonDienNuoc]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spThemHoaDonDienNuoc]
(@soDien FLOAT, @soNuoc FLOAT,
@thanhTien FLOAT, @ngayLap VARCHAR(15),
@trangThai NVARCHAR(50), @maPhong VARCHAR(15))
AS
BEGIN
	INSERT INTO dbo.HoaDonDienNuoc VALUES
	(@soDien, @soNuoc, @thanhTien,
	@ngayLap, @trangThai, @maPhong);
END
GO
/****** Object:  StoredProcedure [dbo].[spThemKTKL]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spThemKTKL]
(@hinhThuc NVARCHAR(50), @moTa NVARCHAR(200),
@ngayTao VARCHAR(15), @maSV VARCHAR(15))
AS
BEGIN
	INSERT INTO dbo.KhenThuong_KyLuat VALUES
	(@hinhThuc, @moTa, @ngayTao, @maSV);
END
GO
/****** Object:  StoredProcedure [dbo].[spThemNhanVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spThemNhanVien]
(@hoTen NVARCHAR(50), @ngaySinh VARCHAR(15), @diaChi NVARCHAR(150),
@dienThoai VARCHAR(15), @tenToa VARCHAR(15), @maChucVu INT,
@ngayBatDau VARCHAR(15), @ngayKetThuc VARCHAR(15),
@ngayLap VARCHAR(15), @luongThang FLOAT)
AS
BEGIN
	BEGIN TRANSACTION ThemNV;

	INSERT INTO dbo.NhanVien VALUES
	(@hoTen, @ngaySinh, @diaChi, @dienThoai, @tenToa, @maChucVu);

	INSERT INTO dbo.HopDong_NV VALUES
	(@ngayBatDau, @ngayKetThuc, @ngayLap, @luongThang,
	(SELECT MAX(MaNV) FROM dbo.NhanVien));

	COMMIT TRANSACTION ThemNV;
END
GO
/****** Object:  StoredProcedure [dbo].[spThemSinhVien]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- INSERT
----------------------------------------------------------
CREATE   PROCEDURE [dbo].[spThemSinhVien]
(@maSV VARCHAR(15), @CMND VARCHAR(12), @hoTen NVARCHAR(50),
@gioiTinh NVARCHAR(10), @ngaySinh VARCHAR(15), @diaChi NVARCHAR(150),
@dienThoai VARCHAR(15),	@CMND_TN VARCHAR(12), @hoTen_TN NVARCHAR(50),
@gioiTinh_TN NVARCHAR(10), @quanHeSV NVARCHAR(50), @diaChi_TN NVARCHAR(150),
@dienThoai_TN VARCHAR(15), @maPhong VARCHAR(15), @ngayBatDau VARCHAR(15),
@ngayKetThuc VARCHAR(15), @ngayLap VARCHAR(15), @thanhTien FLOAT)
AS
BEGIN
	BEGIN TRANSACTION ThemSV;

	INSERT INTO dbo.SinhVien VALUES
	(@maSV, @CMND, @hoTen, @gioiTinh, @ngaySinh,
	@diaChi, @dienThoai, @maPhong);

	INSERT INTO dbo.ThanNhan VALUES
	(@CMND_TN, @hoTen_TN, @gioiTinh_TN, @quanHeSV,
	@diaChi_TN, @dienThoai_TN, @maSV);

	INSERT INTO dbo.HopDong_SV VALUES
	(@ngayBatDau, @ngayKetThuc, @ngayLap,
	@thanhTien, @maSV);

	IF ((SELECT COUNT(MaSV) FROM dbo.SinhVien
	WHERE MaPhong = @maPhong) > (SELECT SucChuaSV
	FROM dbo.Phong WHERE MaPhong = @maPhong))
	BEGIN
		RAISERROR ('Phòng này đầy rồi!!!', 16, 1);
		ROLLBACK TRANSACTION ThemSV;
	END
	ELSE IF ((SELECT dbo.fulTenLoaiPhong(MaLoai) FROM dbo.Phong
	WHERE MaPhong = @maPhong) <> @gioiTinh)
	BEGIN
		RAISERROR ('Hãy chọn đúng loại phòng!!!', 16, 1);
		ROLLBACK TRANSACTION ThemSV;
	END
	ELSE
		COMMIT TRANSACTION ThemSV;
END
GO
/****** Object:  StoredProcedure [dbo].[spThemTaiKhoan]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spThemTaiKhoan]
(@tenTaiKhoan VARCHAR(15), @matKhau VARCHAR(1000),
@IDLoaiQuyen INT)
AS
BEGIN
	INSERT INTO dbo.TaiKhoan VALUES
	(@tenTaiKhoan, @matKhau, @IDLoaiQuyen);
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaHoaDonDienNuoc_TheoMaHoaDon]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spXoaHoaDonDienNuoc_TheoMaHoaDon]
(@maHoaDon INT)
AS
BEGIN
	DELETE FROM dbo.HoaDonDienNuoc
	WHERE MaHoaDon = @maHoaDon;
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaKTKL_TheoMaKTKL]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spXoaKTKL_TheoMaKTKL]
(@maKTKL INT)
AS
BEGIN
	DELETE FROM dbo.KhenThuong_KyLuat
	WHERE MaKTKL = @maKTKL;
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaNhanVien_TheoMaNV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spXoaNhanVien_TheoMaNV]
(@maNV INT)
AS
BEGIN
	DELETE FROM dbo.NhanVien WHERE MaNV = @maNV;
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaSinhVien_TheoMaSV]    Script Date: 5/18/2021 3:05:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- DELETE
-------------------------------------------------------------
CREATE   PROCEDURE [dbo].[spXoaSinhVien_TheoMaSV]
(@maSV VARCHAR(15))
AS
BEGIN
	DELETE FROM dbo.SinhVien WHERE MaSV = @maSV;
END
GO
