USE [master]
GO
/****** Object:  Database [svtest]    Script Date: 4/13/2019 2:12:50 PM ******/
CREATE DATABASE [svtest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'svtest', FILENAME = N'E:\audi\Microsoft SQL Server\Microsoft SQL Server\MSSQL14.NONAME\MSSQL\DATA\svtest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'svtest_log', FILENAME = N'E:\audi\Microsoft SQL Server\Microsoft SQL Server\MSSQL14.NONAME\MSSQL\DATA\svtest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [svtest] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [svtest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [svtest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [svtest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [svtest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [svtest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [svtest] SET ARITHABORT OFF 
GO
ALTER DATABASE [svtest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [svtest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [svtest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [svtest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [svtest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [svtest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [svtest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [svtest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [svtest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [svtest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [svtest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [svtest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [svtest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [svtest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [svtest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [svtest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [svtest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [svtest] SET RECOVERY FULL 
GO
ALTER DATABASE [svtest] SET  MULTI_USER 
GO
ALTER DATABASE [svtest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [svtest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [svtest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [svtest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [svtest] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'svtest', N'ON'
GO
ALTER DATABASE [svtest] SET QUERY_STORE = OFF
GO
USE [svtest]
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
USE [svtest]
GO
/****** Object:  Table [dbo].[tblKhoa]    Script Date: 4/13/2019 2:12:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhoa](
	[MaKhoa] [varchar](250) NOT NULL,
	[TenKhoa] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[Email] [nvarchar](250) NULL,
	[SDT] [varchar](50) NULL,
	[NgayThanhLap] [datetime] NULL,
 CONSTRAINT [PK_tblKhoa_1] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 4/13/2019 2:12:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLop](
	[MaLop] [nvarchar](250) NOT NULL,
	[MaKhoa] [varchar](250) NULL,
	[TenLop] [nvarchar](250) NULL,
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 4/13/2019 2:12:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MaSV] [varchar](250) NOT NULL,
	[MaKhoa] [varchar](250) NOT NULL,
	[TenSV] [nvarchar](250) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[SoThich] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'4444', N'44444', N'dfsdagafgdfg', N'dsfsdf', N'32343424', CAST(N'2019-03-19T00:00:00.000' AS DateTime))
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'a', N'b', N'e', N'c', N'd', CAST(N'1997-02-03T00:00:00.000' AS DateTime))
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'CNTT', N'Công Nghệ Thông Tin', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'KiemToan', N'kiểm toán', N'fdsgdfg', N'ewreqwer', N'dfsgfg', CAST(N'1984-05-06T00:00:00.000' AS DateTime))
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'TaiChinh', N'tài chính', N'fdsgdfgdfg', N'sdfgdsfg', N'52345432', CAST(N'1992-04-06T00:00:00.000' AS DateTime))
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'Toan', N'toán', N'gfdsgdfg', N'dfsgf', N'52345', CAST(N'1995-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChi], [Email], [SDT], [NgayThanhLap]) VALUES (N'Van', N'Văn', N'2222', N'222', N'2222', CAST(N'2019-03-19T00:00:00.000' AS DateTime))
INSERT [dbo].[tblLop] ([MaLop], [MaKhoa], [TenLop]) VALUES (N'Lop1', N'a', N'Toán 1')
INSERT [dbo].[tblLop] ([MaLop], [MaKhoa], [TenLop]) VALUES (N'lop2', N'KiemToan', N'kiểm toán 1')
INSERT [dbo].[tblLop] ([MaLop], [MaKhoa], [TenLop]) VALUES (N'lop3', N'KiemToan', N'kiểm toán 2')
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'aaaaa', N'CNTT', N'dfasdfasdf', CAST(N'2019-03-19T00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'fsdafdf', N'4444', N'sdafsdfd', CAST(N'2019-03-26T00:00:00.000' AS DateTime), 0, N'Chơi Game,')
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'gggg', N'4444', N'ggggg', CAST(N'2019-03-26T00:00:00.000' AS DateTime), 0, N'Chơi Game,nghe nhạc')
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'sss', N'a', N'ssss', CAST(N'2019-03-13T00:00:00.000' AS DateTime), 1, N'nghe nhạc')
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'SV01', N'KiemToan', N'Nguyễn văn a', CAST(N'1994-06-05T00:00:00.000' AS DateTime), 1, N'Chơi Game,')
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'SV02', N'TaiChinh', N'Hà Minh Sơn', CAST(N'1993-03-05T00:00:00.000' AS DateTime), 1, N'nghe nhạc')
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'SV03', N'CNTT', N'nguyễn hoài hồng', CAST(N'1995-03-11T00:00:00.000' AS DateTime), 0, NULL)
INSERT [dbo].[tblSinhVien] ([MaSV], [MaKhoa], [TenSV], [NgaySinh], [GioiTinh], [SoThich]) VALUES (N'SV04', N'TaiChinh', N'phạm thị hương', CAST(N'1992-04-05T00:00:00.000' AS DateTime), 0, NULL)
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblKhoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[tblKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblKhoa]
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblKhoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[tblKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblKhoa]
GO
USE [master]
GO
ALTER DATABASE [svtest] SET  READ_WRITE 
GO
