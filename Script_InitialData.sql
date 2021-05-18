USE QLKTX;
GO

-- Initial Data
--------------------------------------------------------------
INSERT [dbo].[Toa] ([TenToa], [SLPhong]) VALUES (N'D01', 100)
INSERT [dbo].[Toa] ([TenToa], [SLPhong]) VALUES (N'D02', 100)
GO

INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai]) VALUES (1, N'Nam')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai]) VALUES (2, N'Nữ')
GO

INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-101', 4, 2, 1, N'D01')
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
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-301', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-302', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-303', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-304', 4, 0, 1, N'D01')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D01-305', 4, 0, 1, N'D01')
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
GO

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
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-301', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-302', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-303', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-304', 4, 0, 2, N'D02')
INSERT [dbo].[Phong] ([MaPhong], [SucChuaSV], [SLDangO], [MaLoai], [TenToa]) VALUES (N'D02-305', 4, 0, 2, N'D02')
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

INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110276', N'221521676', N'Phan Thanh Sang', N'Nam', CAST(N'2001-06-17' AS DATE), N'Phú Yên', N'0327285263', N'D01-101')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110031', N'215512158', N'Nguyễn Hoàng Nhật', N'Nam', CAST(N'2001-02-04' AS Date), N'Bình Định', N'0762539444', N'D01-101')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110220', N'658569856', N'Bùi Lê Quốc Hưng', N'Nam', CAST(N'2001-09-09' AS Date), N'Quảng Ngãi', N'0987568564', N'D01-102')
INSERT [dbo].[SinhVien] ([MaSV], [CMND], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaPhong]) VALUES (N'19110255', N'325658568', N'Nguyễn Minh Nhật', N'Nam', CAST(N'2001-11-24' AS Date), N'Kon Tum', N'0785965877', N'D01-102')
GO

SET IDENTITY_INSERT [dbo].[HopDong_SV] ON
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (1, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110276')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (2, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110031')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (3, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110220')
INSERT [dbo].[HopDong_SV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [ThanhTien], [MaSV]) VALUES (4, CAST(N'2019-05-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2019-04-04' AS Date), 4000000, N'19110255')
SET IDENTITY_INSERT [dbo].[HopDong_SV] OFF
GO

INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456786', N'Ba của Hưng', N'Nam', N'Cha của sinh viên', N'Lâm Đồng', N'0369857852', N'19110220')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456787', N'Ba của M Nhật', N'Nam', N'Cha của sinh viên', N'Kon Tum', N'0369857854', N'19110255')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456788', N'Ba của H Nhật', N'Nam', N'Cha của sinh viên', N'Bình Định', N'0328296555', N'19110031')
INSERT [dbo].[ThanNhan] ([CMND], [HoTen], [GioiTinh], [QuanHeVoiSV], [DiaChi], [DienThoai], [MaSV]) VALUES (N'123456789', N'Ba của Sang', N'Nam', N'Cha của sinh viên', N'Phú Yên', N'0322145623', N'19110276')
GO

SET IDENTITY_INSERT [dbo].[KhenThuong_KyLuat] ON 
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (1, N'Khen Thưởng', N'Nhận 50 triệu VND', CAST(N'2021-06-06' AS Date), N'19110276')
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (2, N'Khen Thưởng', N'Nhận 30 triệu VND', CAST(N'2021-09-09' AS Date), N'19110031')
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (3, N'Khen Thưởng', N'Nhận 3 triệu VND', CAST(N'2021-05-19' AS Date), N'19110255')
INSERT [dbo].[KhenThuong_KyLuat] ([MaKTKL], [HinhThuc], [MoTa], [NgayTao], [MaSV]) VALUES (4, N'Khen Thưởng', N'Giấy khen thưởng', CAST(N'2021-05-19' AS Date), N'19110220')
SET IDENTITY_INSERT [dbo].[KhenThuong_KyLuat] OFF
GO

SET IDENTITY_INSERT [dbo].[HoaDonDienNuoc] ON
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (1, 5, 180, 200000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-101')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (3, 4.5, 160, 250000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-102')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (4, 4.5, 170, 260000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-103')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (5, 3, 160, 190000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-104')
INSERT [dbo].[HoaDonDienNuoc] ([MaHoaDon], [SoDien], [SoNuoc], [ThanhTien], [NgayLap], [TrangThai], [MaPhong]) VALUES (6, 6, 200, 350000, CAST(N'2021-09-09' AS Date), N'Đã Thanh Toán', N'D01-105')
SET IDENTITY_INSERT [dbo].[HoaDonDienNuoc] OFF
GO

SET IDENTITY_INSERT [dbo].[ChucVu] ON
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (1, N'Trưởng tòa')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (2, N'Bảo vệ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (3, N'Lao công')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO

SET IDENTITY_INSERT [dbo].[NhanVien] ON 
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (1, N'Phan Thanh A', CAST(N'1980-07-17' AS Date), N'Hồ Chí Minh', N'0965369999', N'D01', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (2, N'Nguyễn Văn B', CAST(N'1990-04-01' AS Date), N'Bình Định', N'0856985645', N'D01', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (3, N'Trần Thanh C', CAST(N'1995-09-08' AS Date), N'Tiền Giang', N'0965865478', N'D01', 3)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (4, N'Trần Thị E', CAST(N'1987-09-08' AS Date), N'Tiền Giang', N'0965865478', N'D01', 3)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [DienThoai], [TenToa], [MaChucVu]) VALUES (5, N'Văn Trần K', CAST(N'1990-05-04' AS Date), N'Hồ Chí Minh', N'0965854785', N'D01', 2)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO

SET IDENTITY_INSERT [dbo].[HopDong_NV] ON
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (1, CAST(N'2010-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 1000000000, 1)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (2, CAST(N'2011-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 2000000, 2)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (3, CAST(N'2012-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 1000000000, 3)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (4, CAST(N'2010-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 1000000000, 4)
INSERT [dbo].[HopDong_NV] ([MaHD], [NgayBatDau], [NgayKetThuc], [NgayLap], [LuongThang], [MaNV]) VALUES (5, CAST(N'2011-09-19' AS Date), CAST(N'2020-09-19' AS Date), CAST(N'2010-08-18' AS Date), 2000000, 5)
SET IDENTITY_INSERT [dbo].[HopDong_NV] OFF
GO


-- Tai Khoan

SET IDENTITY_INSERT [dbo].[LoaiQuyen] ON
INSERT [dbo].[LoaiQuyen] ([IDLoaiQuyen], [TenQuyen], [MoTa]) VALUES (1, N'Ban Quản Lý', N'Ban Quản lý KTX')
INSERT [dbo].[LoaiQuyen] ([IDLoaiQuyen], [TenQuyen], [MoTa]) VALUES (2, N'Trưởng Tòa', N'Trưởng tòa trong KTX')
SET IDENTITY_INSERT [dbo].[LoaiQuyen] OFF
GO

INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [IDLoaiQuyen]) VALUES (N'banquanly', N'admin', 1)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [IDLoaiQuyen]) VALUES (N'truongtoad01', N'matkhau', 2)
GO