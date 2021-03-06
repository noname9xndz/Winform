USE [master]
GO
/****** Object:  Database [DemoQLKyTuc]    Script Date: 4/13/2019 2:05:22 PM ******/
CREATE DATABASE [DemoQLKyTuc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DemoQLKyTuc', FILENAME = N'E:\audi\Microsoft SQL Server\Microsoft SQL Server\MSSQL14.NONAME\MSSQL\DATA\DemoQLKyTuc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DemoQLKyTuc_log', FILENAME = N'E:\audi\Microsoft SQL Server\Microsoft SQL Server\MSSQL14.NONAME\MSSQL\DATA\DemoQLKyTuc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DemoQLKyTuc] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DemoQLKyTuc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DemoQLKyTuc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET ARITHABORT OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DemoQLKyTuc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DemoQLKyTuc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DemoQLKyTuc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DemoQLKyTuc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET RECOVERY FULL 
GO
ALTER DATABASE [DemoQLKyTuc] SET  MULTI_USER 
GO
ALTER DATABASE [DemoQLKyTuc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DemoQLKyTuc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DemoQLKyTuc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DemoQLKyTuc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DemoQLKyTuc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DemoQLKyTuc', N'ON'
GO
ALTER DATABASE [DemoQLKyTuc] SET QUERY_STORE = OFF
GO
USE [DemoQLKyTuc]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [DemoQLKyTuc]
GO
/****** Object:  Table [dbo].[tbl_ChiPhiKhac]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiPhiKhac](
	[MaChiPhi] [varchar](50) NOT NULL,
	[TenChiPhi] [nvarchar](250) NULL,
	[MaPhong] [varchar](50) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_ChiPhiKhac] PRIMARY KEY CLUSTERED 
(
	[MaChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DAY]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DAY](
	[MaDay] [varchar](50) NOT NULL,
	[TenDay] [nvarchar](200) NULL,
	[SoLuongPhong] [int] NULL,
	[MaKTX] [varchar](50) NULL,
 CONSTRAINT [PK_DAY] PRIMARY KEY CLUSTERED 
(
	[MaDay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DienNuoc]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DienNuoc](
	[MaDienNuoc] [varchar](50) NOT NULL,
	[MaPhong] [varchar](50) NULL,
	[NgayGhiSo] [smalldatetime] NULL,
	[ChiSoDauKy] [float] NULL,
	[ChiSoCuoiKy] [float] NULL,
	[GiaDien] [float] NULL,
	[GiaNuoc] [float] NULL,
	[TongTienDien] [decimal](18, 0) NULL,
	[TongTienNuoc] [decimal](18, 0) NULL,
 CONSTRAINT [PK_tbl_DienNuoc] PRIMARY KEY CLUSTERED 
(
	[MaDienNuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[MaHoaDon] [varchar](50) NOT NULL,
	[NgayLap] [smalldatetime] NULL,
	[MaPhong] [varchar](50) NULL,
	[NguoiLap] [varchar](50) NULL,
	[MaChiPhi] [varchar](50) NULL,
	[MaDienNuoc] [varchar](50) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[NguoiThu] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_HopDong]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HopDong](
	[MaHopDong] [varchar](50) NOT NULL,
	[MaSinhVien] [varchar](50) NULL,
	[MaNhanVien] [varchar](50) NULL,
	[MaPhong] [varchar](50) NULL,
	[MaDay] [varchar](50) NULL,
	[MaKTX] [varchar](50) NULL,
	[NgayBatDau] [smalldatetime] NULL,
	[NgayKetThuc] [smalldatetime] NULL,
 CONSTRAINT [PK_tbl_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Khoa]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Khoa](
	[MaKhoa] [varchar](50) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KTX]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KTX](
	[MaKTX] [varchar](50) NOT NULL,
	[TenKTX] [nvarchar](200) NULL,
	[SoLuongDay] [int] NULL,
 CONSTRAINT [PK_KTX] PRIMARY KEY CLUSTERED 
(
	[MaKTX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[MaNhanVien] [varchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Phong]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Phong](
	[MaPhong] [varchar](50) NOT NULL,
	[SoNguoi] [int] NULL,
	[TinhTrangPhong] [nvarchar](50) NULL,
	[MaDay] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_SinhVien]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SinhVien](
	[MaSinhVien] [varchar](50) NOT NULL,
	[TenSV] [nvarchar](250) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](250) NULL,
	[TenNguoiThan] [nvarchar](100) NULL,
	[SDTNguoiThan] [int] NULL,
	[CMT] [varchar](50) NULL,
	[SDT] [int] NULL,
	[Hinh] [nvarchar](500) NULL,
	[MaKhoa] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TaiSan]    Script Date: 4/13/2019 2:05:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TaiSan](
	[MaTaiSan] [varchar](50) NOT NULL,
	[TenTaiSan] [nvarchar](50) NULL,
	[MaPhong] [varchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_TaiSan] PRIMARY KEY CLUSTERED 
(
	[MaTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_DAY] ([MaDay], [TenDay], [SoLuongPhong], [MaKTX]) VALUES (N'day1', N'dãy số 1 - ktx 1', 8, N'ktx1')
INSERT [dbo].[tbl_DAY] ([MaDay], [TenDay], [SoLuongPhong], [MaKTX]) VALUES (N'day2', N'dãy số 2 - ktx 2', 8, N'ktx2')
INSERT [dbo].[tbl_DAY] ([MaDay], [TenDay], [SoLuongPhong], [MaKTX]) VALUES (N'day3', N'dãy số 3 - ktx 2', 8, N'ktx2')
INSERT [dbo].[tbl_DAY] ([MaDay], [TenDay], [SoLuongPhong], [MaKTX]) VALUES (N'day4', N'dãy số 4 - ktx 2', 8, N'ktx2')
INSERT [dbo].[tbl_DAY] ([MaDay], [TenDay], [SoLuongPhong], [MaKTX]) VALUES (N'day5', N'dãy số 5 - ktx 1', 8, N'ktx1')
INSERT [dbo].[tbl_Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT [dbo].[tbl_Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'KT', N'Kinh Tế')
INSERT [dbo].[tbl_Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'NN', N'Ngoại Ngữ')
INSERT [dbo].[tbl_KTX] ([MaKTX], [TenKTX], [SoLuongDay]) VALUES (N'ktx1', N'ký túc xá số 1', 7)
INSERT [dbo].[tbl_KTX] ([MaKTX], [TenKTX], [SoLuongDay]) VALUES (N'ktx2', N'ký túc xá số 2', 7)
INSERT [dbo].[tbl_Phong] ([MaPhong], [SoNguoi], [TinhTrangPhong], [MaDay]) VALUES (N'p001', 8, N'Mới', N'day1')
INSERT [dbo].[tbl_Phong] ([MaPhong], [SoNguoi], [TinhTrangPhong], [MaDay]) VALUES (N'p002', 8, N'mới', N'day2')
INSERT [dbo].[tbl_Phong] ([MaPhong], [SoNguoi], [TinhTrangPhong], [MaDay]) VALUES (N'p003', 8, N'Mới', N'day2')
INSERT [dbo].[tbl_Phong] ([MaPhong], [SoNguoi], [TinhTrangPhong], [MaDay]) VALUES (N'p004', 8, N'Mới', N'day5')
INSERT [dbo].[tbl_SinhVien] ([MaSinhVien], [TenSV], [NgaySinh], [GioiTinh], [QueQuan], [TenNguoiThan], [SDTNguoiThan], [CMT], [SDT], [Hinh], [MaKhoa]) VALUES (N'SV02', N'Hà Quang Chính', CAST(N'1993-05-06T00:00:00' AS SmallDateTime), N'Nam', N'Quảng Ngãi', N'B', 32412, N'2342342444', 243524525, N'/Upload/dssfdfsd.jpg', N'CNTT')
INSERT [dbo].[tbl_SinhVien] ([MaSinhVien], [TenSV], [NgaySinh], [GioiTinh], [QueQuan], [TenNguoiThan], [SDTNguoiThan], [CMT], [SDT], [Hinh], [MaKhoa]) VALUES (N'SV03', N'Trần Thị Minh', CAST(N'1994-04-03T00:00:00' AS SmallDateTime), N'Nữ', N'Hà Tĩnh', N'C', 23141, N'6576756577', 243252435, N'/Upload/dssfdfsd.jpg', N'KT')
INSERT [dbo].[tbl_SinhVien] ([MaSinhVien], [TenSV], [NgaySinh], [GioiTinh], [QueQuan], [TenNguoiThan], [SDTNguoiThan], [CMT], [SDT], [Hinh], [MaKhoa]) VALUES (N'SV04', N'Nguyễn Minh Ngọc', CAST(N'1993-04-06T00:00:00' AS SmallDateTime), N'Nữ', N'Quảng Ninh', N'D', 23414, N'5663435634', 4325245, N'/Upload/dssfdfsd.jpg', N'NN')
INSERT [dbo].[tbl_SinhVien] ([MaSinhVien], [TenSV], [NgaySinh], [GioiTinh], [QueQuan], [TenNguoiThan], [SDTNguoiThan], [CMT], [SDT], [Hinh], [MaKhoa]) VALUES (N'sv1', N'sv1', CAST(N'2019-04-13T11:18:00' AS SmallDateTime), N'Nam', N'sv1', N'sv1', 54656, N'sv1', 52345345, N'/Upload/avatar.jpg', N'NN')
INSERT [dbo].[tbl_SinhVien] ([MaSinhVien], [TenSV], [NgaySinh], [GioiTinh], [QueQuan], [TenNguoiThan], [SDTNguoiThan], [CMT], [SDT], [Hinh], [MaKhoa]) VALUES (N'sv2', N'sv2', CAST(N'2019-04-13T11:23:00' AS SmallDateTime), N'Nam', N'sv2', N'sv2', 4352345, N'rtregte54352345', 4332534, N'/Upload/avatar.jpg', N'KT')
INSERT [dbo].[tbl_SinhVien] ([MaSinhVien], [TenSV], [NgaySinh], [GioiTinh], [QueQuan], [TenNguoiThan], [SDTNguoiThan], [CMT], [SDT], [Hinh], [MaKhoa]) VALUES (N'sv5', N'sv4', CAST(N'2019-04-13T11:26:00' AS SmallDateTime), N'Nữ', N'sv4', N'sv4', 544325432, N'sv4', 454352345, N'/Upload/avatar.jpg', N'CNTT')
ALTER TABLE [dbo].[tbl_DAY]  WITH CHECK ADD  CONSTRAINT [FK_DAY_KTX] FOREIGN KEY([MaKTX])
REFERENCES [dbo].[tbl_KTX] ([MaKTX])
GO
ALTER TABLE [dbo].[tbl_DAY] CHECK CONSTRAINT [FK_DAY_KTX]
GO
ALTER TABLE [dbo].[tbl_DienNuoc]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DienNuoc_tbl_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tbl_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tbl_DienNuoc] CHECK CONSTRAINT [FK_tbl_DienNuoc_tbl_Phong]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_ChiPhiKhac] FOREIGN KEY([MaChiPhi])
REFERENCES [dbo].[tbl_ChiPhiKhac] ([MaChiPhi])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_ChiPhiKhac]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_DienNuoc] FOREIGN KEY([MaDienNuoc])
REFERENCES [dbo].[tbl_DienNuoc] ([MaDienNuoc])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_DienNuoc]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_NhanVien] FOREIGN KEY([NguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_NhanVien1] FOREIGN KEY([NguoiThu])
REFERENCES [dbo].[tbl_NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_NhanVien1]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tbl_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_Phong]
GO
ALTER TABLE [dbo].[tbl_HopDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDong_DAY] FOREIGN KEY([MaDay])
REFERENCES [dbo].[tbl_DAY] ([MaDay])
GO
ALTER TABLE [dbo].[tbl_HopDong] CHECK CONSTRAINT [FK_tbl_HopDong_DAY]
GO
ALTER TABLE [dbo].[tbl_HopDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDong_KTX] FOREIGN KEY([MaKTX])
REFERENCES [dbo].[tbl_KTX] ([MaKTX])
GO
ALTER TABLE [dbo].[tbl_HopDong] CHECK CONSTRAINT [FK_tbl_HopDong_KTX]
GO
ALTER TABLE [dbo].[tbl_HopDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDong_tbl_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tbl_NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tbl_HopDong] CHECK CONSTRAINT [FK_tbl_HopDong_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_HopDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDong_tbl_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tbl_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tbl_HopDong] CHECK CONSTRAINT [FK_tbl_HopDong_tbl_Phong]
GO
ALTER TABLE [dbo].[tbl_HopDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDong_tbl_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[tbl_SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[tbl_HopDong] CHECK CONSTRAINT [FK_tbl_HopDong_tbl_SinhVien]
GO
ALTER TABLE [dbo].[tbl_Phong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Phong_DAY] FOREIGN KEY([MaDay])
REFERENCES [dbo].[tbl_DAY] ([MaDay])
GO
ALTER TABLE [dbo].[tbl_Phong] CHECK CONSTRAINT [FK_tbl_Phong_DAY]
GO
ALTER TABLE [dbo].[tbl_SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SinhVien_tbl_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[tbl_Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[tbl_SinhVien] CHECK CONSTRAINT [FK_tbl_SinhVien_tbl_Khoa]
GO
ALTER TABLE [dbo].[tbl_TaiSan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TaiSan_tbl_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tbl_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tbl_TaiSan] CHECK CONSTRAINT [FK_tbl_TaiSan_tbl_Phong]
GO
USE [master]
GO
ALTER DATABASE [DemoQLKyTuc] SET  READ_WRITE 
GO
