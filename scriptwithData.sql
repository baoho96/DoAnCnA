USE [master]
GO
/****** Object:  Database [PhongKham]    Script Date: 02-Jul-18 3:30:41 PM ******/
CREATE DATABASE [PhongKham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PhongKham', FILENAME = N'D:\PhongKham.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PhongKham_log', FILENAME = N'D:\PhongKham_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PhongKham] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PhongKham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PhongKham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PhongKham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PhongKham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PhongKham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PhongKham] SET ARITHABORT OFF 
GO
ALTER DATABASE [PhongKham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PhongKham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PhongKham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PhongKham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PhongKham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PhongKham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PhongKham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PhongKham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PhongKham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PhongKham] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PhongKham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PhongKham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PhongKham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PhongKham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PhongKham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PhongKham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PhongKham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PhongKham] SET RECOVERY FULL 
GO
ALTER DATABASE [PhongKham] SET  MULTI_USER 
GO
ALTER DATABASE [PhongKham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PhongKham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PhongKham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PhongKham] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PhongKham] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PhongKham', N'ON'
GO
USE [PhongKham]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaSoBenhNhan] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[NamSinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[GioiTinh] [nchar](10) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[CheckDaKham] [bit] NULL,
	[CanNang] [int] NULL,
	[TenNguoiThan] [nvarchar](max) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaSoBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachThuoc]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachThuoc](
	[MaSoDonThuoc] [int] NOT NULL,
	[MaSoThuoc] [int] NOT NULL,
	[SoLuong] [bigint] NULL,
	[CachDung] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaSoDonThuoc] [int] IDENTITY(1,1) NOT NULL,
	[MaSoKhamBenh] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[TongTienThuoc] [bigint] NULL,
	[KiemTraLayThuoc] [bit] NULL,
	[NgayKeDon] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonThuoc_1] PRIMARY KEY CLUSTERED 
(
	[MaSoDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayGioLap] [nvarchar](50) NULL,
	[MaNguoiLap] [int] NULL,
	[MaSoKhamBenh] [int] NULL,
	[MaSoDonThuoc] [int] NULL,
	[TongTien] [bigint] NULL,
	[KiemTraThanhToan] [bit] NULL,
	[KiemTraLayThuoc] [bit] NULL,
	[KiemTraDaLayThuoc] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoKhamBenh]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoKhamBenh](
	[MaSoKhamBenh] [int] IDENTITY(1,1) NOT NULL,
	[MaSoBenhNhan] [int] NULL,
	[NgayGioKham] [nvarchar](50) NULL,
	[MaSoBacSi] [int] NULL,
	[LiDoKham] [nvarchar](max) NULL,
	[ChuanDoan] [nvarchar](max) NULL,
	[XetNghiem] [nvarchar](max) NULL,
	[KetQuaXetNghiem] [nvarchar](max) NULL,
	[TienKham] [bigint] NULL,
	[NgayTaiKham] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[KiemTraKham] [bit] NULL,
	[KiemTraTaiKham] [bit] NULL,
	[CheckChoKham] [bit] NULL,
 CONSTRAINT [PK_DanhSachKham] PRIMARY KEY CLUSTERED 
(
	[MaSoKhamBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoTaiKham]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoTaiKham](
	[MaSoTaiKham] [int] NOT NULL,
	[MaSoKhamBenh] [int] NULL,
	[MaSoBenhNhan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThuoc]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThuoc](
	[MaSoLoaiThuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiThuoc] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiThuoc] PRIMARY KEY CLUSTERED 
(
	[MaSoLoaiThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaSoNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[ViTri] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[QuyenTruyCap] [int] NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[NgayTao] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[Luong] [bigint] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaSoNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaSoThuoc] [int] IDENTITY(1,1) NOT NULL,
	[MaSoLoaiThuoc] [int] NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [bigint] NULL,
	[DonViTinh] [nvarchar](max) NULL,
	[NgayNhap] [nvarchar](50) NULL,
	[CachDung] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[DonGiaNhoNhat] [bigint] NULL,
	[DonViTinhNhoNhat] [nvarchar](max) NULL,
	[SoLuongNhoNhat] [int] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaSoThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VatDung]    Script Date: 02-Jul-18 3:30:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatDung](
	[MaSoVatDung] [int] IDENTITY(1,1) NOT NULL,
	[TenVatDung] [nvarchar](max) NULL,
	[SoLuong] [int] NULL,
	[SoNamSuDung] [int] NULL,
	[NgayTao] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](max) NULL,
 CONSTRAINT [PK_VatDung] PRIMARY KEY CLUSTERED 
(
	[MaSoVatDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (1, N'Hà Thành', N'Thúy', N'18/05/2001', N'47 Phan Huy Ích P.12 H.Nhà Bè TPHCM', N'0934024091', N'Nữ        ', N'1.jpg', 1, 29, N'Bùi Minh Trâm')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (2, N'Trương Ngọc', N'Vương', N'04/12/2007', N'280 Lạc Hồng P.7 Q.Tân Bình TPHCM', N'01670817674', N'Nam       ', N'2.jpg', 1, 30, N'Phạm Hiếu Phong')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (3, N'Phan Thành', N'Vũ', N'08/02/2012', N'18 Lạc Hồng P.13 Q.3 TPHCM', N'01221270360', N'Nữ        ', N'3.jpg', 1, 18, N'Tống Văn Đào')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (4, N'Phan Văn', N'Thắng', N'07/05/2012', N'105 Nguyễn Cư Trinh P.15 Q.2 TPHCM', N'0948832971', N'Nữ        ', N'4.jpg', 1, 27, N'Trần Hiếu Cúc')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (5, N'Nguyễn Hiếu', N'Tiến', N'11/02/2007', N'70 Quang Trung P.15 Q.10 TPHCM', N'01681024605', N'Nam       ', N'5.jpg', 1, 13, N'Lưu Thành Hải')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (6, N'Cao Minh', N'Phát', N'18/10/2002', N'29 Trần Phú P.13 Q.11 TPHCM', N'01651459795', N'Nam       ', N'6.jpg', 1, 35, N'Hồ Thị Thanh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (7, N'Huỳnh Hiếu', N'Thiện', N'03/04/2001', N'187 Lê Lợi P.15 Q.11 TPHCM', N'01623044213', N'Nữ        ', N'7.jpg', 1, 39, N'Nguyễn Quốc Lộc')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (8, N'Phan Ngọc', N'Vũ', N'25/06/2007', N'121 Tân Sơn Nhất P.9 Q.5 TPHCM', N'01240477930', N'Nữ        ', N'8.jpg', 1, 17, N'Đỗ Minh Mạnh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (9, N'Huỳnh Quang', N'Phát', N'08/01/2006', N'197 Trường Sa P.3 Q.12 TPHCM', N'01244571672', N'Nữ        ', N'9.jpg', 1, 25, N'Trần Ngọc Quỳnh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (10, N'Trần Quốc', N'Vy', N'05/10/1999', N'15 D4 P.15 H.Nhà Bè TPHCM', N'01271730081', N'Nữ        ', N'10.jpg', 1, 20, N'Vũ Hiếu Mạnh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (11, N'Hà Quốc', N'Quỳnh', N'10/01/2001', N'57 Lê Văn Sĩ P.9 Q.8 TPHCM', N'01215376589', N'Nam       ', N'11.jpg', 1, 20, N'Trần Minh Trinh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (12, N'Hồ Ngọc', N'Tiến', N'07/01/2000', N'161 Hoàng Sa P.6 Q.Gò Vấp TPHCM', N'01204426893', N'Nam       ', N'12.jpg', 1, 36, N'Phạm Thành Vũ')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (13, N'Đặng Văn', N'Thúy', N'20/03/2006', N'267 Phan Đình Giót P.10 Q.Thủ Đức TPHCM', N'0964670636', N'Nam       ', N'13.jpg', 1, 29, N'Huỳnh Thành Hải')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (14, N'Phạm Quang', N'Bảo', N'12/05/2012', N'1 Nguyễn Thái Tông P.13 Q.Bình Tân TPHCM', N'01685531684', N'Nam       ', N'14.jpg', 1, 15, N'Đặng Minh Thanh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (15, N'Trần Ngọc', N'Thông', N'17/06/2012', N'33 Trần Phú P.20 Q.4 TPHCM', N'01653367534', N'Nam       ', N'15.jpg', 1, 11, N'Nguyễn Hiếu Cúc')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (16, N'Huỳnh Thành', N'Bảo', N'28/07/2009', N'113 D5 P.17 Q.8 TPHCM', N'01245734779', N'Nữ        ', N'16.jpg', 1, 35, N'Trần Minh An')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (17, N'Lưu Văn', N'Vy', N'04/02/1998', N'158 Nguyễn Cư Trinh P.2 H.Nhà Bè TPHCM', N'01634035787', N'Nam       ', N'17.jpg', 1, 29, N'Đặng Quốc Chi')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (18, N'Phan Ngọc', N'Minh', N'14/10/2010', N'33 Lũy Bán Bích P.16 Q.Thủ Đức TPHCM', N'0904702670', N'Nam       ', N'18.jpg', 1, 28, N'Đặng Ngọc Khánh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (19, N'Vương Thị', N'Tuyết', N'22/03/2011', N'59 Nguyễn Văn Trỗi P.9 Q.5 TPHCM', N'0971829977', N'Nữ        ', N'19.jpg', 1, 35, N'Huỳnh Văn Hiếu')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (20, N'Lê Quốc', N'Trinh', N'31/05/2010', N'25 Nguyễn Hồng Đào P.10 Q.3 TPHCM', N'01282511580', N'Nam       ', N'20.jpg', 1, 10, N'Vương Minh Phong')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (21, N'Lê Minh', N'Quyết', N'21/09/2000', N'263 Âu Cơ P.14 Q.4 TPHCM', N'0905221875', N'Nam       ', N'21.jpg', 1, 24, N'Lê Thị Mạnh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (22, N'Hà Minh', N'Kiệt', N'15/02/2006', N'29 Trần Phú P.2 Q.Thủ Đức TPHCM', N'01670110613', N'Nam       ', N'22.jpg', 1, 14, N'Ngô Thị Vy')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (23, N'Tống Thị', N'An', N'26/05/2008', N'132 Xa Lộ Hà Nội P.1 Q.6 TPHCM', N'01298773564', N'Nữ        ', N'23.jpg', 1, 23, N'Đặng Ngọc Đức')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (24, N'Phạm Thái', N'Tiến', N'21/05/2001', N'265 D1 P.15 Q.Tân Bình TPHCM', N'01678690116', N'Nữ        ', N'24.jpg', 1, 15, N'Vương Văn Nghi')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (25, N'Ngô Thành', N'Minh', N'07/08/2005', N'259 Nguyễn Trãi P.10 Q.3 TPHCM', N'01257954633', N'Nam       ', N'25.jpg', 1, 36, N'Phạm Thái Minh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (26, N'Hồ Thị', N'Tiên', N'21/01/2010', N'202 Lạc Hồng P.11 Q.1 TPHCM', N'01200340601', N'Nam       ', N'26.jpg', 1, 29, N'Đặng Thị Tuyết')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (27, N'Phạm Minh', N'Vinh', N'02/12/2005', N'219 Lương Thế Vinh P.4 Q.7 TPHCM', N'0986465989', N'Nam       ', N'27.jpg', 1, 33, N'Ngô Ngọc Mạnh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (28, N'Đặng Ngọc', N'Tùng', N'20/09/2001', N'119 Sầm Sơn P.12 Q.2 TPHCM', N'01214496611', N'Nam       ', N'28.jpg', 1, 22, N'Nguyễn Văn Thông')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (29, N'Trương Minh', N'Tâm', N'23/05/2007', N'220 Trường Sa P.7 H.Nhà Bè TPHCM', N'0969018619', N'Nữ        ', N'29.jpg', 1, 32, N'Trần Thành Trang')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (30, N'Lê Hiếu', N'Hà', N'16/02/2002', N'162 Cộng Hòa P.5 Q.6 TPHCM', N'01674176226', N'Nữ        ', N'30.jpg', 1, 17, N'Bùi Minh Hà')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (31, N'Đỗ Thành', N'Kiên', N'18/10/2003', N'290 Nguyễn Thái Tổ P.15 Q.11 TPHCM', N'0907639619', N'Nam       ', N'31.jpg', 1, 37, N'Huỳnh Ngọc Xuân')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (32, N'Đặng Văn', N'Phát', N'08/08/2006', N'37 Lê Văn Sĩ P.15 Q.7 TPHCM', N'0860518128', N'Nam       ', N'32.jpg', 1, 36, N'Phan Đức Vinh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (33, N'Tống Thị', N'Đào', N'17/01/2011', N'78 Nguyễn Thái Tổ P.4 Q.Bình Tân TPHCM', N'01236404933', N'Nữ        ', N'33.jpg', 1, 33, N'Cao Quốc Cúc')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (34, N'Vũ Quang', N'Tuyết', N'15/12/2006', N'220 Phạm Văn Đồng P.5 Q.Thủ Đức TPHCM', N'0942901246', N'Nữ        ', N'34.jpg', 1, 23, N'Trần Thái Linh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (35, N'Tống Quang', N'Vinh', N'18/02/2004', N'283 Nguyễn Huệ P.2 Q.1 TPHCM', N'0935084766', N'Nữ        ', N'35.jpg', 1, 17, N'Hồ Ngọc Tiến')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (36, N'Vũ Hiếu', N'Trúc', N'04/03/2008', N'222 Lê Lợi P.18 Q.Gò Vấp TPHCM', N'01249898145', N'Nam       ', N'36.jpg', 1, 16, N'Nguyễn Thị Đào')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (37, N'Tống Hiếu', N'Tuyết', N'02/11/2011', N'105 Ba Vì P.15 Q.6 TPHCM', N'01268291791', N'Nam       ', N'37.jpg', 1, 34, N'Cao Đức Xuân')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (38, N'Hà Minh', N'Như', N'05/04/2008', N'237 Nguyễn Huệ P.10 Q.5 TPHCM', N'0973325203', N'Nữ        ', N'38.jpg', 1, 20, N'Hồ Minh Vinh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (39, N'Đỗ Hiếu', N'Quyết', N'21/03/2002', N'300 Trường Sa P.9 Q.5 TPHCM', N'0862375557', N'Nam       ', N'39.jpg', 1, 26, N'Phan Quang Long')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (40, N'Bùi Quốc', N'Vũ', N'31/08/2005', N'159 D3 P.2 Q.4 TPHCM', N'01274165235', N'Nữ        ', N'40.jpg', 1, 21, N'Vương Văn Tiến')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (41, N'Trần Thị', N'Thanh', N'22/08/2009', N'147 Phạm Văn Đồng P.11 Q.4 TPHCM', N'0986235285', N'Nữ        ', N'41.jpg', 1, 11, N'Đỗ Thị Trâm')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (42, N'Ngô Thị', N'Như', N'28/11/2007', N'278 D5 P.18 Q.2 TPHCM', N'01240038083', N'Nam       ', N'42.jpg', 1, 17, N'Trương Minh Hiếu')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (43, N'Lê Đức', N'Tiến', N'19/10/2012', N'136 D5 P.4 Q.9 TPHCM', N'01213991062', N'Nam       ', N'43.jpg', 1, 36, N'Lê Đức Thanh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (44, N'Nguyễn Hiếu', N'Như', N'02/06/2004', N'44 Lương Thế Vinh P.7 Q.5 TPHCM', N'01639590262', N'Nam       ', N'44.jpg', 1, 39, N'Đặng Hiếu Phát')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (45, N'Ngô Thị', N'An', N'23/01/2010', N'91 Trần Nhân Tông P.17 Q.6 TPHCM', N'0911624698', N'Nam       ', N'45.jpg', 1, 38, N'Đặng Đức Đào')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (46, N'Bùi Hiếu', N'Bảo', N'22/10/2006', N'100 Phan Đình Giót P.1 Q.Bình Tân TPHCM', N'01205093772', N'Nữ        ', N'46.jpg', 1, 25, N'Lê Văn Đức')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (47, N'Huỳnh Quốc', N'Phong', N'06/01/2008', N'150 Phan Đình Giót P.14 Q.4 TPHCM', N'0910664430', N'Nam       ', N'47.jpg', 1, 14, N'Lưu Đức Trúc')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (48, N'Vương Thị', N'Quỳnh', N'25/06/2011', N'288 Lê Lai P.3 Q.1 TPHCM', N'01267276293', N'Nam       ', N'48.jpg', 1, 11, N'Phan Thị Xuân')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (49, N'Trần Thành', N'Khánh', N'16/11/2003', N'11 Phan Đình Phùng P.4 Q.1 TPHCM', N'0946136334', N'Nữ        ', N'49.jpg', 1, 18, N'Mai Ngọc Thanh')
INSERT [dbo].[BenhNhan] ([MaSoBenhNhan], [Ho], [Ten], [NamSinh], [DiaChi], [SoDienThoai], [GioiTinh], [HinhAnh], [CheckDaKham], [CanNang], [TenNguoiThan]) VALUES (50, N'Lưu Quốc', N'Sương', N'18/06/2012', N'96 Âu Cơ P.7 Q.Bình Thạnh TPHCM', N'01625242160', N'Nam       ', N'50.jpg', 1, 27, N'Cao Thị Quỳnh')
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (50, 20, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (50, 66, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (50, 81, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (50, 74, 14, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (50, 67, 15, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (49, 108, 5, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (49, 99, 1, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (49, 46, 19, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (49, 85, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (49, 81, 9, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (48, 34, 9, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (48, 78, 16, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (48, 80, 1, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (48, 23, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (48, 118, 3, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (47, 64, 14, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (47, 7, 12, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (47, 114, 16, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (47, 20, 5, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (47, 27, 14, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (46, 66, 13, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (46, 102, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (46, 38, 18, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (46, 75, 19, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (46, 45, 14, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (45, 82, 9, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (45, 22, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (45, 9, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (45, 66, 4, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (45, 69, 8, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (44, 100, 19, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (44, 42, 11, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (44, 106, 16, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (44, 118, 16, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (44, 67, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (43, 104, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (43, 2, 15, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (43, 93, 9, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (43, 38, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (43, 64, 4, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (42, 99, 16, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (42, 8, 20, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (42, 29, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (42, 103, 14, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (42, 35, 2, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (41, 92, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (41, 34, 4, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (41, 49, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (41, 18, 17, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (41, 64, 12, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (40, 24, 5, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (40, 17, 19, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (40, 111, 19, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (40, 64, 3, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (40, 93, 20, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (39, 35, 3, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (39, 21, 18, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (39, 45, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (39, 8, 1, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (39, 53, 18, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (38, 62, 7, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (38, 22, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (38, 18, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (38, 4, 9, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (38, 85, 12, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (37, 120, 6, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (37, 53, 6, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (37, 22, 3, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (37, 5, 11, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (37, 73, 20, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (36, 66, 8, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (36, 37, 7, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (36, 79, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (36, 71, 20, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (36, 108, 17, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (35, 9, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (35, 115, 16, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (35, 83, 17, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (35, 35, 13, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (35, 108, 1, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (34, 97, 9, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (34, 69, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (34, 54, 1, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (34, 90, 20, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (34, 40, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (33, 51, 2, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (33, 71, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (33, 13, 17, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (33, 111, 3, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (33, 91, 5, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (32, 35, 1, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (32, 32, 8, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (32, 54, 10, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (32, 55, 15, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (32, 71, 5, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (31, 32, 17, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (31, 60, 17, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (31, 22, 3, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (31, 11, 5, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (31, 76, 3, N'1 lần/ngày')
GO
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (30, 37, 3, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (30, 113, 20, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (30, 80, 2, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (30, 101, 2, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (30, 63, 16, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (29, 84, 4, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (29, 59, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (29, 115, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (29, 114, 20, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (29, 116, 17, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (28, 33, 13, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (28, 47, 8, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (28, 58, 11, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (28, 52, 6, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (28, 67, 3, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (27, 49, 6, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (27, 67, 16, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (27, 118, 6, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (27, 111, 9, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (27, 9, 17, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (26, 26, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (26, 92, 9, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (26, 96, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (26, 7, 14, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (26, 87, 18, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (25, 59, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (25, 35, 7, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (25, 81, 6, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (25, 82, 9, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (25, 55, 1, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (24, 92, 18, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (24, 37, 5, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (24, 104, 11, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (24, 15, 6, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (24, 10, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (23, 61, 8, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (23, 34, 20, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (23, 87, 3, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (23, 23, 1, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (23, 70, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (22, 2, 14, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (22, 55, 11, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (22, 99, 9, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (22, 76, 13, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (22, 23, 3, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (21, 73, 12, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (21, 84, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (21, 85, 20, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (21, 47, 20, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (21, 44, 3, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (20, 16, 19, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (20, 72, 1, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (20, 18, 14, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (20, 54, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (20, 13, 7, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (19, 44, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (19, 48, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (19, 54, 12, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (19, 30, 1, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (19, 33, 17, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (18, 36, 8, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (18, 67, 7, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (18, 31, 11, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (18, 101, 1, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (18, 48, 9, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (17, 46, 6, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (17, 120, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (17, 86, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (17, 15, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (17, 57, 1, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (16, 102, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (16, 6, 11, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (16, 17, 11, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (16, 52, 17, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (16, 31, 17, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (15, 45, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (15, 100, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (15, 36, 5, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (15, 95, 18, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (15, 72, 12, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (14, 19, 18, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (14, 57, 10, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (14, 30, 14, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (14, 2, 7, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (14, 25, 5, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (13, 101, 4, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (13, 88, 5, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (13, 47, 2, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (13, 1, 1, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (13, 73, 17, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (12, 91, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (12, 1, 11, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (12, 24, 10, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (12, 64, 3, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (12, 27, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (11, 110, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (11, 63, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (11, 20, 1, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (11, 59, 10, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (11, 81, 5, N'3 lần/ngày')
GO
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (10, 59, 8, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (10, 17, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (10, 33, 4, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (10, 26, 15, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (10, 92, 15, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (9, 113, 15, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (9, 112, 5, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (9, 108, 3, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (9, 29, 6, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (9, 93, 8, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (8, 10, 6, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (8, 37, 2, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (8, 30, 14, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (8, 25, 11, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (8, 120, 10, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (7, 115, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (7, 17, 5, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (7, 54, 18, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (7, 50, 20, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (7, 32, 2, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (6, 119, 12, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (6, 2, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (6, 116, 15, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (6, 66, 5, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (6, 99, 4, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (5, 9, 13, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (5, 112, 20, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (5, 21, 14, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (5, 33, 11, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (5, 92, 9, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (4, 107, 11, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (4, 56, 16, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (4, 90, 17, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (4, 64, 8, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (4, 65, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (3, 70, 13, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (3, 30, 7, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (3, 92, 10, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (3, 59, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (3, 66, 2, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (2, 108, 4, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (2, 61, 20, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (2, 74, 13, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (2, 110, 2, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (2, 86, 4, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (1, 58, 2, N'1 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (1, 55, 12, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (1, 85, 17, N'2 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (1, 27, 16, N'3 lần/ngày')
INSERT [dbo].[DanhSachThuoc] ([MaSoDonThuoc], [MaSoThuoc], [SoLuong], [CachDung]) VALUES (1, 4, 9, N'1 lần/ngày')
SET IDENTITY_INSERT [dbo].[DonThuoc] ON 

INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (1, 50, N'uống sau khi ăn', 3843000, 1, N'13/04/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (2, 49, N'uống liên tục', 2875000, 1, N'29/11/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (3, 48, N'uống sau khi ăn', 1722000, 1, N'20/03/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (4, 47, N'uống thuốc đúng giờ', 4667000, 1, N'20/10/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (5, 46, N'uống đúng liều lượng', 3603000, 1, N'02/09/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (6, 45, N'uống sau khi ăn', 2941000, 1, N'19/03/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (7, 44, N'uống sau khi ăn', 2297000, 1, N'26/03/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (8, 43, N'uống thuốc đúng giờ', 1818000, 1, N'05/01/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (9, 42, N'uống trước khi ăn', 2560000, 1, N'29/02/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (10, 41, N'uống thuốc đúng giờ', 2667000, 1, N'17/12/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (11, 40, N'uống liên tục', 2303000, 1, N'02/07/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (12, 39, N'uống thuốc đều dặn', 2918000, 1, N'19/03/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (13, 38, N'uống thuốc đều dặn', 1416000, 1, N'04/04/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (14, 37, N'uống liên tục', 2315000, 1, N'26/11/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (15, 36, N'uống đúng liều lượng', 3641000, 1, N'06/07/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (16, 35, N'uống trước khi ăn', 2160000, 1, N'30/04/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (17, 34, N'uống trước khi ăn', 1482000, 1, N'13/08/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (18, 33, N'uống trước khi ăn', 1653000, 1, N'12/07/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (19, 32, N'uống đúng liều lượng', 3594000, 1, N'04/12/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (20, 31, N'uống liên tục', 3147000, 1, N'21/07/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (21, 30, N'uống sau khi ăn', 4895000, 1, N'12/09/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (22, 29, N'uống thuốc đúng giờ', 2527000, 1, N'27/03/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (23, 28, N'uống sau khi ăn', 1252000, 1, N'21/11/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (24, 27, N'uống thuốc đều dặn', 3616000, 1, N'07/09/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (25, 26, N'uống sau khi ăn', 1200000, 1, N'17/05/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (26, 25, N'uống thuốc đều dặn', 1816000, 1, N'01/10/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (27, 24, N'uống đúng liều lượng', 1556000, 1, N'24/11/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (28, 23, N'uống liên tục', 2493000, 1, N'17/02/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (29, 22, N'uống thuốc đều dặn', 3838000, 1, N'02/06/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (30, 21, N'uống thuốc đều dặn', 3467000, 1, N'08/08/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (31, 20, N'uống trước khi ăn', 2039000, 1, N'17/12/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (32, 19, N'uống trước khi ăn', 2049000, 1, N'27/03/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (33, 18, N'uống sau khi ăn', 1713000, 1, N'14/09/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (34, 17, N'uống liên tục', 3116000, 1, N'07/03/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (35, 16, N'uống đúng liều lượng', 1794000, 1, N'22/12/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (36, 15, N'uống thuốc đúng giờ', 3102000, 1, N'26/05/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (37, 14, N'uống thuốc đều dặn', 2271000, 1, N'19/05/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (38, 13, N'uống đúng liều lượng', 3753000, 1, N'27/03/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (39, 12, N'uống trước khi ăn', 2608000, 1, N'22/12/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (40, 11, N'uống đúng liều lượng', 3033000, 1, N'04/01/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (41, 10, N'uống liên tục', 3381000, 1, N'11/09/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (42, 9, N'uống liên tục', 1202000, 1, N'13/08/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (43, 8, N'uống đúng liều lượng', 2378000, 1, N'03/10/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (44, 7, N'uống liên tục', 3157000, 1, N'11/07/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (45, 6, N'uống thuốc đúng giờ', 2123000, 1, N'26/08/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (46, 5, N'uống trước khi ăn', 3400000, 1, N'02/02/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (47, 4, N'uống đúng liều lượng', 3565000, 1, N'01/10/2015')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (48, 3, N'uống thuốc đều dặn', 2881000, 1, N'29/09/2017')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (49, 2, N'uống đúng liều lượng', 2179000, 1, N'29/06/2016')
INSERT [dbo].[DonThuoc] ([MaSoDonThuoc], [MaSoKhamBenh], [GhiChu], [TongTienThuoc], [KiemTraLayThuoc], [NgayKeDon]) VALUES (50, 1, N'uống liên tục', 3256000, 1, N'03/08/2015')
SET IDENTITY_INSERT [dbo].[DonThuoc] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (1, N'13/04/2016', 6, 50, 50, 4186000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (2, N'29/11/2017', 5, 49, 49, 2259000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (3, N'20/03/2017', 5, 48, 48, 3301000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (4, N'20/10/2015', 6, 47, 47, 4065000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (5, N'02/09/2015', 5, 46, 46, 3490000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (6, N'19/03/2015', 6, 45, 45, 2333000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (7, N'26/03/2015', 6, 44, 44, 3387000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (8, N'05/01/2016', 5, 43, 43, 2668000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (9, N'29/02/2016', 5, 42, 42, 2182000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (10, N'17/12/2017', 6, 41, 41, 3671000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (11, N'02/07/2015', 5, 40, 40, 3203000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (12, N'19/03/2015', 5, 39, 39, 3138000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (13, N'04/04/2017', 5, 38, 38, 4463000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (14, N'26/11/2016', 5, 37, 37, 2601000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (15, N'06/07/2016', 6, 36, 36, 3872000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (16, N'30/04/2016', 5, 35, 35, 2084000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (17, N'13/08/2016', 5, 34, 34, 3696000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (18, N'12/07/2017', 6, 33, 33, 2283000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (19, N'04/12/2017', 5, 32, 32, 2859000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (20, N'21/07/2016', 5, 31, 31, 2959000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (21, N'12/09/2017', 5, 30, 30, 3987000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (22, N'27/03/2016', 5, 29, 29, 4018000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (23, N'21/11/2015', 5, 28, 28, 3023000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (24, N'07/09/2017', 5, 27, 27, 1856000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (25, N'17/05/2016', 5, 26, 26, 2486000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (26, N'01/10/2017', 5, 25, 25, 1900000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (27, N'24/11/2015', 5, 24, 24, 4526000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (28, N'17/02/2015', 6, 23, 23, 1742000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (29, N'02/06/2017', 6, 22, 22, 3317000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (30, N'08/08/2016', 6, 21, 21, 5865000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (31, N'17/12/2015', 6, 20, 20, 3367000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (32, N'27/03/2016', 5, 19, 19, 4444000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (33, N'14/09/2016', 5, 18, 18, 2313000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (34, N'07/03/2015', 6, 17, 17, 2052000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (35, N'22/12/2017', 5, 16, 16, 2510000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (36, N'26/05/2017', 5, 15, 15, 4521000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (37, N'19/05/2016', 5, 14, 14, 2365000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (38, N'27/03/2016', 5, 13, 13, 2136000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (39, N'22/12/2015', 5, 12, 12, 3508000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (40, N'04/01/2017', 5, 11, 11, 3253000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (41, N'11/09/2015', 5, 10, 10, 2777000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (42, N'13/08/2017', 6, 9, 9, 3100000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (43, N'03/10/2015', 5, 8, 8, 2458000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (44, N'11/07/2017', 6, 7, 7, 2417000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (45, N'26/08/2016', 5, 6, 6, 3911000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (46, N'02/02/2015', 6, 5, 5, 4413000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (47, N'01/10/2015', 5, 4, 4, 5487000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (48, N'29/09/2017', 5, 3, 3, 1792000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (49, N'29/06/2016', 5, 2, 2, 3145000, 1, 1, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayGioLap], [MaNguoiLap], [MaSoKhamBenh], [MaSoDonThuoc], [TongTien], [KiemTraThanhToan], [KiemTraLayThuoc], [KiemTraDaLayThuoc]) VALUES (50, N'03/08/2015', 6, 1, 1, 4103000, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[HoSoKhamBenh] ON 

INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (1, 50, N'03/08/2015', 2, N'chảy máu mũi,hắt xì', N'viêm đại tràng,viêm khớp', N'chụp X-quang', N'bình thường', 930000, N'3/8/2015', N'ngủ đúng giờ,ngủ thường xuyên,ngủ đúng cách', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (2, 49, N'29/06/2016', 2, N'đau tay,tê đầu gối', N'cúm gà,thiếu chất Sắt', N'xét nghiệm nước tiểu', N'bị bệnh', 80000, NULL, N'tập thể dục,ăn nhiều tinh bột,không uống rượu', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (3, 48, N'29/09/2017', 1, N'nhức xương,ù tai', N'máu nhiễm mỡ,viêm đại tràng', N'chụp X-quang', N'nứt xương', 420000, N'29/9/2017', N'vận động,chích thuốc thường xuyên,ăn nhiều tinh bột', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (4, 47, N'01/10/2015', 2, N'ho ra máu,trầy', N'viêm dạ dày,thiếu máu', N'xét nghiệm máu', N'nhóm máu B', 500000, NULL, N'hít thở sâu,ăn nhiều cà chua,ăn nhiều muối', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (5, 46, N'02/02/2015', 1, N'khô mắt,đau bụng', N'chảy máu trong,ngộ độc thức ăn', N'xét nghiệm nước tiểu', N'bình thường', 90000, N'2/2/2015', N'tập thể dục,hạn chế tiếp xúc côn trùng,chích thuốc thường xuyên', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (6, 45, N'26/08/2016', 2, N'ho,nhức xương', N'sốt siêu vi,ngộ độc hô hấp', N'xét nghiệm máu', N'nhóm máu A', 210000, NULL, N'chích thuốc thường xuyên,ăn kiêng,hạn chế tiếp xúc côn trùng', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (7, 44, N'11/07/2017', 1, N'đỏ da,mờ mắt', N'dị ứng,suy dinh dưỡng', N'chụp X-quang', N'nứt xương', 230000, NULL, N'khám định kì thường xuyên,uống nhiều nước,ăn uống đầy đủ', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (8, 43, N'03/10/2015', 2, N'đau ngực,đau đầu gối', N'thiếu dinh dưỡng,ong đốt', N'xét nghiệm máu', N'nhóm máu AB', 290000, N'3/10/2015', N'ngủ thường xuyên,ăn nhiều tinh bột,hít thở đều', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (9, 42, N'13/08/2017', 2, N'nổi mụn,khó ngủ', N'viêm khớp,nhện cắn', N'xét nghiệm máu', N'nhóm máu O', 980000, NULL, N'ngủ đúng cách,hạn chế tiếp xúc côn trùng,ăn nhiều thịt', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (10, 41, N'11/09/2015', 2, N'ói,chóng mặt', N'ung thư gan,nứt xương', N'chụp X-quang', N'nứt xương', 290000, NULL, N'ăn nhiều muối,không rượu bia,hạn chế tiếp xúc côn trùng', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (11, 40, N'04/01/2017', 2, N'chảy máu miệng,tê tay', N'thiếu vitamin,viêm ruột thừa', N'xét nghiệm nước tiểu', N'bình thường', 170000, NULL, N'ăn đồ chín,ăn nhiều cá,ngủ đúng cách', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (12, 39, N'22/12/2015', 1, N'ngứa,đau bụng', N'viêm ruột thừa,ngộ độc hô hấp', N'xét nghiệm máu', N'nhóm máu O', 530000, N'22/12/2015', N'ăn đủ chất,không ăn đồ sống,hít thở đều', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (13, 38, N'27/03/2016', 1, N'ho ra máu,ho', N'viêm gan,viêm mũi', N'xét nghiệm máu', N'nhóm máu B', 710000, N'27/3/2016', N'hạn chế tiếp xúc côn trùng,ăn nhiều cà rốt,tập thể dục', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (14, 37, N'19/05/2016', 2, N'hắt xì,ngứa', N'viêm màng não,cúm gà', N'xét nghiệm máu', N'nhóm máu O', 330000, NULL, N'ngủ thường xuyên,tái khám định kì,tập dưỡng sinh', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (15, 36, N'26/05/2017', 1, N'đau bụng,chảy máu miệng', N'dị ứng côn trùng,chảy máu trong', N'xét nghiệm nước tiểu', N'bị bệnh', 770000, NULL, N'tránh ánh nắng,ngủ đúng cách,hạn chế ra đường', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (16, 35, N'22/12/2017', 2, N'chóng mặt,sốt', N'viêm màng não,suy thận', N'xét nghiệm máu', N'nhóm máu B', 290000, NULL, N'ăn nhiều thịt,ăn uống đầy đủ,ăn nhiều cà chua', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (17, 34, N'07/03/2015', 2, N'buồn ngủ,đau đầu gối', N'vỡ xương,ung thư não', N'xét nghiệm máu', N'nhóm máu O', 580000, NULL, N'ăn ngủ đều dặn,không uống rượu,tập dưỡng sinh', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (18, 33, N'14/09/2016', 2, N'đau cơ,sốt', N'loãng xương,viêm khớp', N'xét nghiệm nước tiểu', N'bình thường', 570000, NULL, N'ăn ngủ đều dặn,ngủ đều đặn,ngủ đúng cách', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (19, 32, N'27/03/2016', 2, N'khô miệng,mẩn đỏ', N'mù màu,ho gà', N'xét nghiệm máu', N'nhóm máu A', 810000, NULL, N'ngủ đều đặn,chích thuốc thường xuyên,ngủ đủ giấc', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (20, 31, N'17/12/2015', 1, N'đau đầu gối,chảy máu miệng', N'xơ gan,trúng gió', N'xét nghiệm máu', N'nhóm máu A', 920000, NULL, N'chơi thể thao,không uống rượu,không ăn đồ sống', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (21, 30, N'08/08/2016', 1, N'sốt,khó thở', N'cúm gà,thiếu dinh dưỡng', N'xét nghiệm nước tiểu', N'bình thường', 520000, N'8/8/2016', N'tái khám định kì,uống thuốc đầy đủ,ăn kiêng', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (22, 29, N'02/06/2017', 1, N'mệt mỏi,khô miệng', N'cận thị,viêm khớp', N'chụp X-quang', N'nứt xương', 180000, NULL, N'tập dưỡng sinh,ngủ đúng cách,hít thở sâu', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (23, 28, N'17/02/2015', 2, N'tê chân,đau đầu gối', N'nhện cắn,ngộ độc thức ăn', N'xét nghiệm nước tiểu', N'bình thường', 530000, NULL, N'bôi thuốc thường xuyên,hạn chế dùng thuốc,không uống rượu', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (24, 27, N'24/11/2015', 2, N'đau cổ,khô miệng', N'máu nhiễm mỡ,phong thấp', N'xét nghiệm máu', N'nhóm máu B', 300000, NULL, N'tập thể dục,vận động,ngủ đúng giờ', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (25, 26, N'01/10/2017', 1, N'đau tim,đau cơ', N'xương thủy tinh,viễn thị', N'xét nghiệm nước tiểu', N'bình thường', 670000, N'1/10/2017', N'uống nhiều nước,ăn nhiều cá,chơi thể thao', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (26, 25, N'17/05/2016', 1, N'ngứa,ù tai', N'viêm mũi,tai biến mạch máu não', N'xét nghiệm máu', N'nhóm máu A', 700000, N'17/5/2016', N'hít thở sâu,ngủ đủ giấc,tái khám định kì', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (27, 24, N'07/09/2017', 2, N'nhức xương,đau chân', N'viêm gan,hạ huyết áp', N'xét nghiệm nước tiểu', N'bình thường', 910000, NULL, N'vận động,ăn nhiều muối,khám định kì thường xuyên', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (28, 23, N'21/11/2015', 2, N'nhức đầu,buồn ngủ', N'ung thư phổi,trúng gió', N'xét nghiệm máu', N'nhóm máu A', 490000, NULL, N'ăn nhiều muối,tái khám định kì,ăn nhiều cà chua', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (29, 22, N'27/03/2016', 2, N'mẩn đỏ,khó ngủ', N'viêm khớp,chấn thương trong', N'xét nghiệm nước tiểu', N'bình thường', 790000, N'27/3/2016', N'hạn chế ra đường,ăn nhiều muối,ăn nhiều thịt', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (30, 21, N'12/09/2017', 2, N'khó thở,đau tay', N'mất máu,ung thư dạ dày', N'xét nghiệm máu', N'nhóm máu B', 970000, NULL, N'uống nhiều nước,ăn nhiều tinh bột,ăn nhiều thịt', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (31, 20, N'21/07/2016', 2, N'đau cơ,tê chân', N'tai biến mạch máu não,sốt siêu vi', N'xét nghiệm máu', N'nhóm máu B', 220000, N'21/7/2016', N'bôi thuốc thường xuyên,ngủ đúng cách,tái khám định kì', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (32, 19, N'04/12/2017', 2, N'ho ra máu,chảy máu mũi', N'sốt siêu vi,xương thủy tinh', N'xét nghiệm nước tiểu', N'bình thường', 850000, NULL, N'ít hút thuốc,ngủ đủ giấc,ăn nhiều cá', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (33, 18, N'12/07/2017', 1, N'đau họng,co thắt bụng', N'suy thận,ngộ độc hô hấp', N'xét nghiệm nước tiểu', N'bình thường', 660000, N'12/7/2017', N'ăn uống đầy đủ,chích thuốc thường xuyên,không ăn đồ tươi', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (34, 17, N'13/08/2016', 2, N'ho đờm,mờ mắt', N'suy gan,lở miệng', N'xét nghiệm máu', N'nhóm máu B', 570000, N'13/8/2016', N'hạn chế tiếp xúc côn trùng,không rượu bia,ăn nhiều cà chua', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (35, 16, N'30/04/2016', 1, N'mệt mỏi,khó thở', N'ung thư phổi,viêm đại tràng', N'xét nghiệm nước tiểu', N'bị bệnh', 350000, NULL, N'ăn nhiều cà chua,tái khám định kì,ăn kiêng', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (36, 15, N'06/07/2016', 1, N'đau tay,tê chân', N'ung thư não,ngộ độc thức ăn', N'xét nghiệm máu', N'nhóm máu AB', 880000, N'6/7/2016', N'ngủ đủ giấc,không ăn đồ sống,ăn ngủ đều dặn', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (37, 14, N'26/11/2016', 1, N'sỗ mũi,khó thở', N'thiếu máu,vỡ mật', N'xét nghiệm nước tiểu', N'bình thường', 50000, NULL, N'ăn nhiều tinh bột,không rượu bia,ăn uống đầy đủ', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (38, 13, N'04/04/2017', 1, N'chảy máu miệng,tê đầu gối', N'rắn cắn,ung thư dạ dày', N'chụp X-quang', N'gãy xương', 720000, N'4/4/2017', N'vận động,hạn chế dùng thuốc,ăn nhiều rau', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (39, 12, N'19/03/2015', 2, N'đau cơ,nôn', N'viêm đại tràng,xơ gan', N'chụp X-quang', N'bình thường', 590000, NULL, N'hạn chế dùng thuốc,ăn đồ chín,ngủ đều đặn', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (40, 11, N'02/07/2015', 2, N'mệt mỏi,đau tay', N'chấn thương ngoài,H1N1', N'chụp X-quang', N'bình thường', 950000, NULL, N'ăn nhiều cà rốt,ăn ngủ đều dặn,ăn nhiều cá', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (41, 10, N'17/12/2017', 1, N'nổi mụn,tróc da', N'thiếu máu,suy dinh dưỡng', N'xét nghiệm nước tiểu', N'bị bệnh', 110000, NULL, N'không hút thuốc,chơi thể thao,không uống rượu', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (42, 9, N'29/02/2016', 2, N'nhức xương,tê chân', N'cúm gà,ung thư gan', N'xét nghiệm máu', N'nhóm máu A', 540000, N'29/2/2016', N'hít thở sâu,đến bệnh viện thường xuyên,bôi thuốc thường xuyên', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (43, 8, N'05/01/2016', 2, N'ho ra máu,đau cổ', N'cao huyết áp,H5N1', N'xét nghiệm máu', N'nhóm máu AB', 640000, N'5/1/2016', N'khám định kì thường xuyên,hít thở đều,hạn chế ra đường', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (44, 7, N'26/03/2015', 2, N'khó ngủ,đau cổ', N'suy thận,tai biến', N'chụp X-quang', N'gãy xương', 120000, NULL, N'ăn uống đầy đủ,hít thở sâu,ngủ đúng giờ', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (45, 6, N'19/03/2015', 2, N'chảy máu mũi,đau bụng', N'viêm đại tràng,ung thư não', N'xét nghiệm máu', N'nhóm máu O', 970000, N'19/3/2015', N'không ăn quà vặt,chơi thể thao,tiêm phòng thường xuyên', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (46, 5, N'02/09/2015', 1, N'mệt mỏi,tróc da', N'thiếu dinh dưỡng,vỡ xương', N'chụp X-quang', N'gãy xương', 810000, N'2/9/2015', N'không rượu bia,tiêm phòng thường xuyên,ăn kiêng', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (47, 4, N'20/10/2015', 2, N'đau cổ,ho ra máu', N'xương thủy tinh,ho gà', N'chụp X-quang', N'bình thường', 820000, N'20/10/2015', N'ngủ thường xuyên,ngủ đủ giấc,ăn ngủ đều dặn', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (48, 3, N'20/03/2017', 2, N'sỗ mũi,co thắt bụng', N'viễn thị,suy dinh dưỡng', N'chụp X-quang', N'bình thường', 70000, NULL, N'ngủ đúng cách,ăn ngủ đều dặn,uống nhiều nước', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (49, 2, N'29/11/2017', 2, N'ngứa,đau cổ', N'thiếu máu,rắn cắn', N'xét nghiệm nước tiểu', N'bình thường', 270000, N'29/11/2017', N'ăn ngủ đều dặn,bôi thuốc thường xuyên,chơi thể thao', 1, NULL, 0)
INSERT [dbo].[HoSoKhamBenh] ([MaSoKhamBenh], [MaSoBenhNhan], [NgayGioKham], [MaSoBacSi], [LiDoKham], [ChuanDoan], [XetNghiem], [KetQuaXetNghiem], [TienKham], [NgayTaiKham], [GhiChu], [KiemTraKham], [KiemTraTaiKham], [CheckChoKham]) VALUES (50, 1, N'13/04/2016', 2, N'nôn,trầy', N'H5N1,viêm gan', N'xét nghiệm máu', N'nhóm máu AB', 260000, N'13/4/2016', N'ăn nhiều tinh bột,ít hút thuốc,ngủ đều đặn', 1, NULL, 0)
SET IDENTITY_INSERT [dbo].[HoSoKhamBenh] OFF
SET IDENTITY_INSERT [dbo].[LoaiThuoc] ON 

INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (1, N'An thần', N'Zolpidem')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (2, N'Bổ sung vitamin D', N'Vitamin D')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (3, N'Bổ sung acid folic', N'Folic Acid')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (4, N'Chẹn kênh canxi', N'Amlodipine')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (5, N'Chống co giật', N'Pregabalin Lyrica')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (6, N'Chống loạn thần', N'Quetiapine')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (7, N'Chống nôn', N'Meclizine')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (8, N'Chống trầm cảm', N'Escitalopram')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (9, N'Chống trào ngược dạ dày thực quản', N'Ranitidine Zantac')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (10, N'Điều trị Tăng huyết áp', N'Clonidine')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (11, N'Giảm cân', N'Lorcaserin')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (12, N'Hạ Cholesterol', N'Atorvastatin')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (13, N'Kháng sinh', N'Clindamycin')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (14, N'Loãng xương', N'Risedronate')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (15, N'Lợi tiểu', N'Furosemide')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (16, N'Thuốc chống đông', N'Warfarin')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (17, N'Kháng khuẩn', N'Moxifloxacin')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (18, N'Giảm đau', N'Tramadol')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (19, N'Giảm ho', N'Benzonatate')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (20, N'Điều trị Đái tháo đường', N'Pioglitazone')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (21, N'Chống viêm', N'Prednisone')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (22, N'Chống động kinh', N'Lamotrigine')
INSERT [dbo].[LoaiThuoc] ([MaSoLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (23, N'Chống kết tập tiểu cầu', N'Clopidogrel')
SET IDENTITY_INSERT [dbo].[LoaiThuoc] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (1, N'Lưu Thái Tuyết', N'01/01/1979', N'Bác Sĩ', N'238 Hoàng Sa P.11 Q.5 TPHCM', N'01675467251', 3, N'bacsi0', N'e99a18c428cb38d5f260853678922e3', N'14/03/2014', N'Nam       ', N'1.jpg', 12000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (2, N'Mai Thái Tài', N'21/05/1993', N'Bác Sĩ', N'121 Lạc Long Quân P.5 Q.1 TPHCM', N'01244707711', 3, N'bacsi1', N'e99a18c428cb38d5f260853678922e3', N'20/11/2017', N'Nam       ', N'2.jpg', 13000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (3, N'Đặng Thị Đức', N'20/05/1978', N'Điều Dưỡng', N'151 Nguyễn Huệ P.4 Q.5 TPHCM', N'0972644514', 2, N'dieuduong0', N'e99a18c428cb38d5f260853678922e3', N'24/12/2017', N'Nam       ', N'3.jpg', 16000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (4, N'Cao Quốc Tài', N'23/05/1988', N'Điều Dưỡng', N'169 Hoàng Sa P.6 Q.6 TPHCM', N'0912010539', 2, N'dieuduong1', N'e99a18c428cb38d5f260853678922e3', N'19/09/2013', N'Nam       ', N'4.jpg', 10000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (5, N'Vũ Thành Xuân', N'04/05/1978', N'Dược Sĩ', N'22 Cộng Hòa P.10 Q.1 TPHCM', N'0984452414', 4, N'duocsi0', N'e99a18c428cb38d5f260853678922e3', N'28/10/2016', N'Nữ        ', N'5.jpg', 15000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (6, N'Phan Hiếu Thảo', N'08/01/1974', N'Dược Sĩ', N'299 Lạc Hồng P.4 Q.Bình Tân TPHCM', N'01655035450', 4, N'duocsi1', N'e99a18c428cb38d5f260853678922e3', N'15/07/2013', N'Nữ        ', N'6.jpg', 15000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (7, N'Phan Hiếu Sương', N'18/10/1970', N'Thu Ngân', N'263 Nguyễn Thái Tổ P.10 Q.Tân Bình TPHCM', N'01207838614', 5, N'thungan0', N'e99a18c428cb38d5f260853678922e3', N'03/03/2014', N'Nữ        ', N'7.jpg', 9000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (8, N'Hà Minh Vương', N'15/07/1984', N'Thu Ngân', N'245 Trương Định P.7 Q.3 TPHCM', N'0984571968', 5, N'thungan1', N'e99a18c428cb38d5f260853678922e3', N'06/02/2014', N'Nữ        ', N'8.jpg', 9000000)
INSERT [dbo].[NhanVien] ([MaSoNhanVien], [TenNhanVien], [NgaySinh], [ViTri], [DiaChi], [SoDienThoai], [QuyenTruyCap], [TaiKhoan], [MatKhau], [NgayTao], [GioiTinh], [HinhAnh], [Luong]) VALUES (9, N'Vương Hiếu Khánh', N'25/02/1974', N'Admin', N'64 Thành Thái P.15 Q.11 TPHCM', N'01237196301', 1, N'admin0', N'e99a18c428cb38d5f260853678922e3', N'25/11/2016', N'Nam       ', N'9.jpg', 16000000)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (1, 17, N'Cholestan', 4, 340000, N'Lon', N'10/01/2015', N'viên sủi', N'1.jpg', 49000, N'Tuýp', 17)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (2, 10, N'Cifex', 3, 760000, N'Hộp', N'10/09/2017', N'thuốc uống', N'2.jpg', 49000, N'Vĩ', 39)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (3, 11, N'Cetirizin', 2, 930000, N'Thùng', N'14/12/2016', N'thuốc ngậm', N'3.jpg', 25000, N'Bình', 35)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (4, 7, N'Cimetidin', 8, 750000, N'Hộp', N'21/03/2015', N'thuốc uống', N'4.jpg', 70000, N'Tuýp', 43)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (5, 19, N'Cetirizin', 5, 590000, N'Lon', N'26/09/2014', N'thuốc ngậm', N'5.jpg', 51000, N'Tuýp', 23)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (6, 20, N'Cholestin', 9, 330000, N'Lon', N'01/03/2017', N'thuốc ngậm', N'6.jpg', 92000, N'Lọ', 20)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (7, 18, N'Chloram H', 1, 390000, N'Thùng', N'03/10/2015', N'thuốc uống', N'7.jpg', 61000, N'Viên', 39)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (8, 10, N'Chloramphenicol', 2, 880000, N'Lon', N'01/10/2017', N'viên sủi', N'8.jpg', 11000, N'Viên', 24)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (9, 17, N'Chericof', 7, 490000, N'Thùng', N'03/07/2017', N'viên sủi', N'9.jpg', 19000, N'Vĩ', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (10, 1, N'Cerepril', 6, 940000, N'Hộp', N'02/10/2016', N'thuốc uống', N'10.jpg', 81000, N'Bình', 33)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (11, 20, N'Cevit', 7, 650000, N'Thùng', N'16/06/2017', N'viên sủi', N'11.jpg', 15000, N'Tuýp', 20)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (12, 14, N'Cephalexin', 2, 360000, N'Lon', N'20/10/2016', N'viên sủi', N'12.jpg', 45000, N'Vĩ', 25)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (13, 8, N'Cerebrolysin', 9, 530000, N'Thùng', N'07/03/2014', N'thuốc uống', N'13.jpg', 66000, N'Vĩ', 50)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (14, 22, N'Cemofar', 7, 850000, N'Thùng', N'29/11/2015', N'thuốc ngậm', N'14.jpg', 20000, N'Bình', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (15, 20, N'Cent’Housand', 7, 920000, N'Thùng', N'23/08/2016', N'thuốc ngậm', N'15.jpg', 41000, N'Viên', 14)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (16, 3, N'Celgar', 10, 910000, N'Thùng', N'11/01/2017', N'thuốc uống', N'16.jpg', 66000, N'Viên', 19)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (17, 16, N'Cemax powder', 6, 810000, N'Hộp', N'30/12/2015', N'viên sủi', N'17.jpg', 34000, N'Bình', 32)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (18, 17, N'Cefuroxim stada', 5, 950000, N'Hộp', N'25/06/2014', N'thuốc uống', N'18.jpg', 93000, N'Lọ', 14)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (19, 5, N'Celecoxib', 9, 530000, N'Lon', N'20/11/2016', N'thuốc uống', N'19.jpg', 17000, N'Lọ', 26)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (20, 14, N'Centrivit ginseng', 4, 610000, N'Hộp', N'22/10/2016', N'thuốc ngậm', N'20.jpg', 5000, N'Bình', 17)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (21, 3, N'Cefixim MKP', 4, 360000, N'Lon', N'06/09/2016', N'viên sủi', N'21.jpg', 33000, N'Chai', 47)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (22, 12, N'Carbimazol', 2, 740000, N'Thùng', N'10/10/2016', N'thuốc uống', N'22.jpg', 86000, N'Viên', 27)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (23, 11, N'Cefaclor', 10, 340000, N'Hộp', N'20/08/2014', N'viên sủi', N'23.jpg', 76000, N'Tuýp', 39)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (24, 6, N'Avelox', 5, 630000, N'Thùng', N'12/07/2017', N'viên sủi', N'24.jpg', 42000, N'Viên', 42)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (25, 1, N'Avodart', 2, 680000, N'Lon', N'12/10/2016', N'thuốc ngậm', N'25.jpg', 24000, N'Lọ', 18)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (26, 12, N'Axepin', 2, 430000, N'Thùng', N'23/04/2015', N'viên sủi', N'26.jpg', 67000, N'Chai', 33)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (27, 1, N'Azathioprin', 5, 910000, N'Hộp', N'25/02/2014', N'thuốc ngậm', N'27.jpg', 36000, N'Chai', 32)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (28, 22, N'Axid', 1, 980000, N'Lon', N'28/03/2017', N'thuốc uống', N'28.jpg', 6000, N'Lọ', 28)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (29, 4, N'Azithromycin', 2, 650000, N'Lon', N'17/05/2017', N'viên sủi', N'29.jpg', 48000, N'Chai', 13)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (30, 20, N'Acid Tranexamic', 3, 730000, N'Hộp', N'19/06/2014', N'thuốc ngậm', N'30.jpg', 54000, N'Viên', 22)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (31, 2, N'A 313', 9, 500000, N'Thùng', N'04/07/2017', N'viên sủi', N'31.jpg', 13000, N'Lọ', 43)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (32, 18, N'A Gram', 1, 600000, N'Hộp', N'02/01/2016', N'viên sủi', N'32.jpg', 41000, N'Tuýp', 22)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (33, 15, N'Arduan', 3, 990000, N'Lon', N'07/03/2016', N'thuốc ngậm', N'33.jpg', 82000, N'Tuýp', 20)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (34, 16, N'Arginine Veyron', 6, 890000, N'Lon', N'30/11/2017', N'viên sủi', N'34.jpg', 14000, N'Vĩ', 35)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (35, 15, N'Artemether', 8, 490000, N'Hộp', N'25/01/2015', N'thuốc ngậm', N'35.jpg', 26000, N'Vĩ', 50)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (36, 2, N'Artemisinin', 1, 360000, N'Hộp', N'09/07/2017', N'viên sủi', N'36.jpg', 53000, N'Chai', 26)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (37, 21, N'Asparaginase', 5, 910000, N'Thùng', N'25/09/2016', N'thuốc ngậm', N'37.jpg', 91000, N'Vĩ', 35)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (38, 1, N'Aspirine PH8', 9, 360000, N'Hộp', N'04/10/2016', N'viên sủi', N'38.jpg', 71000, N'Viên', 27)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (39, 23, N'Atorvastatin', 2, 640000, N'Hộp', N'14/05/2017', N'viên sủi', N'39.jpg', 59000, N'Tuýp', 23)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (40, 11, N'Acid iopanoic', 8, 500000, N'Hộp', N'15/11/2017', N'thuốc ngậm', N'40.jpg', 39000, N'Chai', 32)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (41, 7, N'Acid Nalidixic', 9, 600000, N'Lon', N'18/03/2015', N'thuốc ngậm', N'41.jpg', 66000, N'Bình', 41)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (42, 17, N'Acid Para Aminobenzoic', 2, 330000, N'Hộp', N'01/03/2016', N'viên sủi', N'42.jpg', 19000, N'Tuýp', 50)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (43, 15, N'Act Hib', 1, 570000, N'Hộp', N'03/09/2014', N'viên sủi', N'43.jpg', 46000, N'Tuýp', 33)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (44, 8, N'Activated chacoal', 3, 320000, N'Thùng', N'08/02/2017', N'thuốc uống', N'44.jpg', 73000, N'Bình', 24)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (45, 4, N'AC Vax', 2, 350000, N'Thùng', N'27/02/2016', N'thuốc ngậm', N'45.jpg', 11000, N'Vĩ', 38)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (46, 22, N'Acetazolamid', 8, 620000, N'Lon', N'12/05/2015', N'thuốc ngậm', N'46.jpg', 37000, N'Vĩ', 27)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (47, 6, N'Acid ascorbic', 3, 590000, N'Hộp', N'17/08/2016', N'viên sủi', N'47.jpg', 91000, N'Chai', 27)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (48, 14, N'Acid Chenodeoxycholic', 10, 430000, N'Lon', N'02/04/2015', N'thuốc ngậm', N'48.jpg', 93000, N'Lọ', 45)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (49, 9, N'Biseptol', 7, 850000, N'Thùng', N'25/10/2017', N'thuốc ngậm', N'49.jpg', 31000, N'Chai', 32)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (50, 2, N'Bismuth subcitrat', 2, 350000, N'Thùng', N'09/06/2017', N'viên sủi', N'50.jpg', 49000, N'Lọ', 19)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (51, 18, N'Blephamide', 3, 970000, N'Lon', N'27/10/2016', N'thuốc uống', N'51.jpg', 29000, N'Vĩ', 44)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (52, 7, N'Bromocriptin', 1, 860000, N'Hộp', N'07/12/2016', N'thuốc uống', N'52.jpg', 23000, N'Chai', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (53, 19, N'Bupivacain hydrochlorid', 3, 600000, N'Hộp', N'30/04/2017', N'thuốc ngậm', N'53.jpg', 99000, N'Viên', 31)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (54, 9, N'A Hydrocort', 5, 450000, N'Thùng', N'13/11/2014', N'viên sủi', N'54.jpg', 20000, N'Tuýp', 28)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (55, 22, N'A Methapred', 3, 360000, N'Lon', N'10/12/2017', N'viên sủi', N'55.jpg', 98000, N'Lọ', 50)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (56, 8, N'A.P.L', 3, 750000, N'Lon', N'06/02/2015', N'viên sủi', N'56.jpg', 80000, N'Tuýp', 32)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (57, 18, N'Contractubex', 4, 910000, N'Lon', N'22/11/2017', N'thuốc ngậm', N'57.jpg', 79000, N'Vĩ', 16)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (58, 16, N'Coramine Glucose', 7, 940000, N'Thùng', N'29/06/2014', N'thuốc ngậm', N'58.jpg', 42000, N'Tuýp', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (59, 8, N'Cyclophosphamid', 8, 510000, N'Hộp', N'28/01/2017', N'viên sủi', N'59.jpg', 47000, N'Vĩ', 14)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (60, 12, N'Cystine B6 Bailleul', 2, 760000, N'Lon', N'09/09/2016', N'thuốc uống', N'60.jpg', 56000, N'Tuýp', 18)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (61, 21, N'Diamicron', 9, 890000, N'Lon', N'21/04/2014', N'thuốc ngậm', N'61.jpg', 69000, N'Bình', 34)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (62, 6, N'Diethylcarbamazin', 9, 990000, N'Thùng', N'15/02/2017', N'thuốc ngậm', N'62.jpg', 22000, N'Tuýp', 42)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (63, 11, N'Differin Gel', 4, 380000, N'Lon', N'22/03/2015', N'viên sủi', N'63.jpg', 83000, N'Chai', 37)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (64, 9, N'Dexambutol INH', 1, 510000, N'Lon', N'10/09/2016', N'viên sủi', N'64.jpg', 96000, N'Tuýp', 16)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (65, 16, N'Dextromethorphan', 7, 950000, N'Lon', N'27/06/2016', N'thuốc uống', N'65.jpg', 45000, N'Lọ', 17)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (66, 22, N'Di Antalvic', 2, 890000, N'Hộp', N'20/09/2017', N'viên sủi', N'66.jpg', 99000, N'Tuýp', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (67, 21, N'Hyperium', 3, 420000, N'Lon', N'07/04/2015', N'thuốc ngậm', N'67.jpg', 33000, N'Lọ', 46)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (68, 23, N'Hyposulfene', 2, 910000, N'Thùng', N'02/03/2017', N'thuốc uống', N'68.jpg', 17000, N'Viên', 15)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (69, 15, N'Gastropulgite', 2, 820000, N'Lon', N'30/04/2016', N'viên sủi', N'69.jpg', 43000, N'Tuýp', 28)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (70, 10, N'Homatropin hydrobromid', 8, 520000, N'Thùng', N'23/08/2014', N'thuốc uống', N'70.jpg', 44000, N'Viên', 30)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (71, 9, N'Hydrocortison Richter', 7, 360000, N'Thùng', N'08/08/2015', N'thuốc uống', N'71.jpg', 5000, N'Lọ', 39)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (72, 15, N'Motilium', 10, 370000, N'Lon', N'18/12/2014', N'thuốc ngậm', N'72.jpg', 89000, N'Lọ', 37)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (73, 1, N'Mucusan suspension', 1, 640000, N'Lon', N'03/03/2014', N'viên sủi', N'73.jpg', 39000, N'Bình', 15)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (74, 14, N'Labetalol hydroclorid', 10, 820000, N'Hộp', N'09/02/2016', N'viên sủi', N'74.jpg', 71000, N'Viên', 31)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (75, 15, N'Lacteol fort', 2, 830000, N'Lon', N'21/02/2015', N'thuốc uống', N'75.jpg', 6000, N'Vĩ', 33)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (76, 12, N'Micostat 7', 1, 420000, N'Hộp', N'03/01/2017', N'thuốc ngậm', N'76.jpg', 19000, N'Vĩ', 10)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (77, 12, N'Mikrofollin Forte', 6, 300000, N'Hộp', N'21/03/2017', N'thuốc ngậm', N'77.jpg', 31000, N'Bình', 25)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (78, 1, N'Mitomycin C Kyowa', 2, 500000, N'Thùng', N'27/06/2016', N'viên sủi', N'78.jpg', 97000, N'Viên', 47)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (79, 15, N'Moriamin S 2', 5, 940000, N'Lon', N'08/09/2017', N'thuốc ngậm', N'79.jpg', 55000, N'Lọ', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (80, 17, N'Pyrimethamin', 3, 450000, N'Lon', N'16/07/2016', N'thuốc uống', N'80.jpg', 95000, N'Vĩ', 43)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (81, 14, N'Obimin', 5, 850000, N'Thùng', N'25/06/2016', N'viên sủi', N'81.jpg', 19000, N'Viên', 29)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (82, 2, N'Oframax', 2, 390000, N'Thùng', N'06/09/2014', N'thuốc uống', N'82.jpg', 53000, N'Vĩ', 15)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (83, 23, N'Propofol', 5, 510000, N'Hộp', N'28/09/2016', N'thuốc uống', N'83.jpg', 31000, N'Vĩ', 47)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (84, 3, N'Propofol Abbott', 8, 990000, N'Hộp', N'01/04/2017', N'thuốc uống', N'84.jpg', 48000, N'Chai', 15)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (85, 21, N'Pulvo 47 Neomycine', 10, 380000, N'Lon', N'27/01/2014', N'viên sủi', N'85.jpg', 81000, N'Lọ', 18)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (86, 1, N'Pyridoxin, Vitamin B6', 10, 470000, N'Hộp', N'13/08/2016', N'thuốc uống', N'86.jpg', 63000, N'Lọ', 46)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (87, 17, N'Primolut Nor', 10, 880000, N'Thùng', N'10/06/2014', N'thuốc ngậm', N'87.jpg', 12000, N'Vĩ', 36)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (88, 12, N'Proctolog', 6, 520000, N'Hộp', N'25/08/2016', N'viên sủi', N'88.jpg', 90000, N'Vĩ', 48)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (89, 12, N'Profenid Gelule', 8, 480000, N'Lon', N'13/05/2017', N'thuốc ngậm', N'89.jpg', 67000, N'Vĩ', 47)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (90, 15, N'Polydexa a la Phenylephrine', 1, 560000, N'Thùng', N'25/01/2017', N'thuốc ngậm', N'90.jpg', 91000, N'Lọ', 32)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (91, 16, N'Polydexa solution auriculaire', 10, 660000, N'Lon', N'17/09/2017', N'thuốc ngậm', N'91.jpg', 73000, N'Bình', 28)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (92, 6, N'Polymyxin B', 5, 950000, N'Hộp', N'15/10/2016', N'thuốc uống', N'92.jpg', 48000, N'Bình', 31)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (93, 18, N'Trihexyphenidyl', 9, 890000, N'Thùng', N'16/05/2016', N'viên sủi', N'93.jpg', 65000, N'Tuýp', 44)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (94, 9, N'Trivastal Retard', 7, 380000, N'Hộp', N'09/09/2015', N'thuốc ngậm', N'94.jpg', 34000, N'Bình', 13)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (95, 13, N'Trymo', 6, 970000, N'Thùng', N'25/01/2015', N'thuốc ngậm', N'95.jpg', 87000, N'Chai', 49)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (96, 14, N'Tamoxifen', 1, 620000, N'Lon', N'12/05/2017', N'viên sủi', N'96.jpg', 12000, N'Lọ', 47)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (97, 21, N'Tobramycin', 9, 500000, N'Hộp', N'04/01/2016', N'viên sủi', N'97.jpg', 52000, N'Lọ', 33)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (98, 16, N'Tri Regol', 1, 490000, N'Hộp', N'18/07/2015', N'viên sủi', N'98.jpg', 37000, N'Viên', 25)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (99, 20, N'Triamcinolon', 6, 450000, N'Lon', N'23/12/2014', N'thuốc ngậm', N'99.jpg', 32000, N'Viên', 36)
GO
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (100, 7, N'Thiamin (Vitamin B1)', 4, 790000, N'Thùng', N'11/03/2016', N'thuốc ngậm', N'100.jpg', 95000, N'Chai', 12)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (101, 3, N'Tioconazol', 2, 300000, N'Thùng', N'27/06/2015', N'viên sủi', N'101.jpg', 18000, N'Vĩ', 35)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (102, 14, N'Tobramicina IBI', 10, 360000, N'Thùng', N'23/07/2016', N'thuốc ngậm', N'102.jpg', 81000, N'Lọ', 22)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (103, 6, N'Utrogestan', 9, 430000, N'Lon', N'19/04/2017', N'viên sủi', N'103.jpg', 23000, N'Lọ', 34)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (104, 2, N'Uvimag B6', 2, 430000, N'Lon', N'17/06/2017', N'thuốc uống', N'104.jpg', 76000, N'Bình', 36)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (105, 10, N'Tegretol (CR)', 5, 680000, N'Lon', N'01/03/2017', N'viên sủi', N'105.jpg', 71000, N'Viên', 19)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (106, 4, N'Tenoxicam', 6, 670000, N'Thùng', N'29/08/2014', N'thuốc uống', N'106.jpg', 17000, N'Bình', 38)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (107, 22, N'Terneurine H 5000', 3, 790000, N'Hộp', N'11/06/2015', N'thuốc ngậm', N'107.jpg', 32000, N'Chai', 31)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (108, 17, N'Tetraco Q', 3, 490000, N'Lon', N'18/07/2017', N'thuốc uống', N'108.jpg', 44000, N'Viên', 47)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (109, 7, N'Xorim', 1, 790000, N'Hộp', N'07/07/2016', N'thuốc ngậm', N'109.jpg', 16000, N'Tuýp', 13)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (110, 17, N'Warfarin', 6, 640000, N'Lon', N'22/12/2015', N'thuốc ngậm', N'110.jpg', 72000, N'Viên', 15)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (111, 14, N'Wellferon', 2, 470000, N'Thùng', N'16/02/2017', N'thuốc uống', N'111.jpg', 31000, N'Tuýp', 15)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (112, 22, N'Ulfon', 3, 850000, N'Lon', N'15/05/2014', N'viên sủi', N'112.jpg', 78000, N'Tuýp', 41)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (113, 22, N'Ultra Levure', 2, 750000, N'Lon', N'14/12/2017', N'viên sủi', N'113.jpg', 82000, N'Tuýp', 22)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (114, 3, N'Ure Carbarmide', 2, 710000, N'Hộp', N'11/04/2015', N'thuốc uống', N'114.jpg', 60000, N'Bình', 24)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (115, 21, N'Uromitexan', 2, 320000, N'Thùng', N'18/01/2016', N'thuốc uống', N'115.jpg', 47000, N'Bình', 34)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (116, 15, N'Aciclovir Meyer', 3, 890000, N'Thùng', N'26/08/2016', N'viên sủi', N'116.jpg', 72000, N'Tuýp', 46)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (117, 13, N'Acetylcystein Stada', 6, 820000, N'Hộp', N'29/05/2016', N'thuốc uống', N'117.jpg', 37000, N'Tuýp', 10)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (118, 2, N'Kiisin', 9, 790000, N'Thùng', N'15/01/2017', N'thuốc uống', N'118.jpg', 40000, N'Tuýp', 20)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (119, 23, N'Viabiovit', 9, 740000, N'Thùng', N'23/11/2017', N'thuốc ngậm', N'119.jpg', 95000, N'Viên', 10)
INSERT [dbo].[Thuoc] ([MaSoThuoc], [MaSoLoaiThuoc], [TenThuoc], [SoLuong], [DonGia], [DonViTinh], [NgayNhap], [CachDung], [HinhAnh], [DonGiaNhoNhat], [DonViTinhNhoNhat], [SoLuongNhoNhat]) VALUES (120, 23, N'Xatral SR', 10, 620000, N'Lon', N'03/02/2015', N'thuốc ngậm', N'120.jpg', 13000, N'Tuýp', 13)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
SET IDENTITY_INSERT [dbo].[VatDung] ON 

INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (1, N'máy x-quang', 6, 6, N'21/01/2010', N'1.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (2, N'đèn pin', 6, 10, N'21/08/2016', N'2.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (3, N'kim tiêm', 13, 6, N'17/10/2014', N'3.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (4, N'ống nghiệm', 18, 7, N'06/06/2015', N'4.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (5, N'ống nghe', 15, 8, N'30/01/2015', N'5.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (6, N'kính lúp', 2, 5, N'29/09/2011', N'6.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (7, N'khay', 9, 6, N'29/07/2011', N'7.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (8, N'tủ đựng', 16, 8, N'29/11/2010', N'8.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (9, N'giường nằm', 19, 5, N'09/08/2014', N'9.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (10, N'ghế xoay', 2, 9, N'25/09/2015', N'10.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (11, N'ghế dài', 20, 8, N'27/07/2017', N'11.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (12, N'ghế dựa', 11, 10, N'23/12/2013', N'12.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (13, N'đồng phục', 7, 10, N'25/09/2016', N'13.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (14, N'mũ', 9, 5, N'13/11/2017', N'14.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (15, N'thẻ tên', 12, 10, N'25/12/2010', N'15.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (16, N'máy đo nhịp tim', 6, 10, N'26/10/2008', N'16.jpg')
INSERT [dbo].[VatDung] ([MaSoVatDung], [TenVatDung], [SoLuong], [SoNamSuDung], [NgayTao], [HinhAnh]) VALUES (17, N'máy đo huyết áp', 1, 7, N'17/12/2017', N'17.jpg')
SET IDENTITY_INSERT [dbo].[VatDung] OFF
ALTER TABLE [dbo].[DanhSachThuoc]  WITH NOCHECK ADD  CONSTRAINT [FK_DanhSachThuoc_DonThuoc] FOREIGN KEY([MaSoDonThuoc])
REFERENCES [dbo].[DonThuoc] ([MaSoDonThuoc])
GO
ALTER TABLE [dbo].[DanhSachThuoc] NOCHECK CONSTRAINT [FK_DanhSachThuoc_DonThuoc]
GO
ALTER TABLE [dbo].[DanhSachThuoc]  WITH NOCHECK ADD  CONSTRAINT [FK_DanhSachThuoc_Thuoc] FOREIGN KEY([MaSoThuoc])
REFERENCES [dbo].[Thuoc] ([MaSoThuoc])
GO
ALTER TABLE [dbo].[DanhSachThuoc] NOCHECK CONSTRAINT [FK_DanhSachThuoc_Thuoc]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH NOCHECK ADD  CONSTRAINT [FK_DonThuoc_HoSoKhamBenh] FOREIGN KEY([MaSoKhamBenh])
REFERENCES [dbo].[HoSoKhamBenh] ([MaSoKhamBenh])
GO
ALTER TABLE [dbo].[DonThuoc] NOCHECK CONSTRAINT [FK_DonThuoc_HoSoKhamBenh]
GO
ALTER TABLE [dbo].[HoaDon]  WITH NOCHECK ADD  CONSTRAINT [FK_HoaDon_DonThuoc] FOREIGN KEY([MaSoDonThuoc])
REFERENCES [dbo].[DonThuoc] ([MaSoDonThuoc])
GO
ALTER TABLE [dbo].[HoaDon] NOCHECK CONSTRAINT [FK_HoaDon_DonThuoc]
GO
ALTER TABLE [dbo].[HoaDon]  WITH NOCHECK ADD  CONSTRAINT [FK_HoaDon_HoSoKhamBenh] FOREIGN KEY([MaSoKhamBenh])
REFERENCES [dbo].[HoSoKhamBenh] ([MaSoKhamBenh])
GO
ALTER TABLE [dbo].[HoaDon] NOCHECK CONSTRAINT [FK_HoaDon_HoSoKhamBenh]
GO
ALTER TABLE [dbo].[HoaDon]  WITH NOCHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNguoiLap])
REFERENCES [dbo].[NhanVien] ([MaSoNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] NOCHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoSoKhamBenh]  WITH NOCHECK ADD  CONSTRAINT [FK_HoSoKhamBenh_BenhNhan] FOREIGN KEY([MaSoBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaSoBenhNhan])
GO
ALTER TABLE [dbo].[HoSoKhamBenh] NOCHECK CONSTRAINT [FK_HoSoKhamBenh_BenhNhan]
GO
ALTER TABLE [dbo].[HoSoKhamBenh]  WITH NOCHECK ADD  CONSTRAINT [FK_HoSoKhamBenh_NhanVien] FOREIGN KEY([MaSoBacSi])
REFERENCES [dbo].[NhanVien] ([MaSoNhanVien])
GO
ALTER TABLE [dbo].[HoSoKhamBenh] NOCHECK CONSTRAINT [FK_HoSoKhamBenh_NhanVien]
GO
ALTER TABLE [dbo].[HoSoTaiKham]  WITH NOCHECK ADD  CONSTRAINT [FK_HoSoTaiKham_HoSoKhamBenh] FOREIGN KEY([MaSoKhamBenh])
REFERENCES [dbo].[HoSoKhamBenh] ([MaSoKhamBenh])
GO
ALTER TABLE [dbo].[HoSoTaiKham] NOCHECK CONSTRAINT [FK_HoSoTaiKham_HoSoKhamBenh]
GO
ALTER TABLE [dbo].[Thuoc]  WITH NOCHECK ADD  CONSTRAINT [FK_Thuoc_LoaiThuoc] FOREIGN KEY([MaSoLoaiThuoc])
REFERENCES [dbo].[LoaiThuoc] ([MaSoLoaiThuoc])
GO
ALTER TABLE [dbo].[Thuoc] NOCHECK CONSTRAINT [FK_Thuoc_LoaiThuoc]
GO
USE [master]
GO
ALTER DATABASE [PhongKham] SET  READ_WRITE 
GO
