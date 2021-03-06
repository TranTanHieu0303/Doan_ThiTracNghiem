USE [master]
GO
/****** Object:  Database [QL_ThiTracNghiem]    Script Date: 25/07/2021 7:13:22 CH ******/
CREATE DATABASE [QL_ThiTracNghiem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_ThiTracNghiem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_ThiTracNghiem.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_ThiTracNghiem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_ThiTracNghiem_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_ThiTracNghiem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_ThiTracNghiem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_ThiTracNghiem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET  MULTI_USER 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_ThiTracNghiem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_ThiTracNghiem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_ThiTracNghiem]
GO
/****** Object:  Table [dbo].[BaiLam]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaiLam](
	[MaTK] [char](5) NOT NULL,
	[MaDe] [char](5) NOT NULL,
	[MaCH] [char](5) NOT NULL,
	[CauChon] [char](1) NULL,
 CONSTRAINT [PK_BaiLam] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC,
	[MaDe] ASC,
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucNang](
	[MaCN] [char](5) NOT NULL,
	[TenCN] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucNangTaiKhoan]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucNangTaiKhoan](
	[MaTK] [char](5) NOT NULL,
	[MaCN] [char](5) NOT NULL,
 CONSTRAINT [PK_ChucNangTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC,
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeThi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeThi](
	[MaDe] [char](5) NOT NULL,
	[MaMon] [char](5) NULL,
	[ThoiGian] [int] NULL,
	[TenDe] [nvarchar](100) NULL,
	[SoCau] [int] NULL,
 CONSTRAINT [PK_DeThi] PRIMARY KEY CLUSTERED 
(
	[MaDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichSuThi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichSuThi](
	[MaTK] [char](5) NOT NULL,
	[MaLT] [char](5) NOT NULL,
	[Diem] [float] NULL,
	[MaDe] [char](5) NULL,
	[NgayThi] [datetime] NULL,
	[SoCauDung] [int] NULL,
 CONSTRAINT [PK_LichSuThi] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC,
	[MaLT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichThi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichThi](
	[MaLT] [char](5) NOT NULL,
	[MaGV] [char](5) NULL,
	[MaDe] [char](5) NULL,
	[NgayThi] [datetime] NULL,
	[TenKyThi] [nvarchar](50) NULL,
 CONSTRAINT [PK_LichThi] PRIMARY KEY CLUSTERED 
(
	[MaLT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[Maloai] [char](5) NOT NULL,
	[Tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonThi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonThi](
	[MaMon] [char](5) NOT NULL,
	[TenMon] [nvarchar](100) NULL,
 CONSTRAINT [PK_MonThi] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NganHangCauHoi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NganHangCauHoi](
	[MaCH] [char](5) NOT NULL,
	[MaMon] [char](5) NULL,
	[NoiDung] [nvarchar](500) NULL,
	[A] [nvarchar](500) NULL,
	[B] [nvarchar](500) NULL,
	[C] [nvarchar](500) NULL,
	[D] [nvarchar](500) NULL,
	[DapAn] [char](1) NULL,
 CONSTRAINT [PK_NganHangCauHoi] PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NoiDungDe]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NoiDungDe](
	[MaDe] [char](5) NOT NULL,
	[MaCH] [char](5) NOT NULL,
 CONSTRAINT [PK_NoiDungDe] PRIMARY KEY CLUSTERED 
(
	[MaDe] ASC,
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaUse] [char](5) NOT NULL,
	[Usename] [varchar](50) NULL,
	[Pass] [varchar](20) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](500) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[HinhAnh] [nvarchar](500) NULL,
	[LoaiTK] [char](5) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaUse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThamGiaThi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThamGiaThi](
	[MaLT] [char](5) NOT NULL,
	[MaTK] [char](5) NOT NULL,
 CONSTRAINT [PK_ThamGiaThi] PRIMARY KEY CLUSTERED 
(
	[MaLT] ASC,
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_LichSuThi]    Script Date: 25/07/2021 7:13:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_LichSuThi]
AS
SELECT       dbo.LichSuThi.MaLT, dbo.LichSuThi.MaTK, dbo.LichSuThi.Diem, dbo.LichSuThi.NgayThi, dbo.LichSuThi.SoCauDung, dbo.MonThi.TenMon, dbo.DeThi.ThoiGian, dbo.DeThi.SoCau
FROM            dbo.DeThi INNER JOIN
                         dbo.LichSuThi ON dbo.DeThi.MaDe = dbo.LichSuThi.MaDe INNER JOIN
                         dbo.MonThi ON dbo.DeThi.MaMon = dbo.MonThi.MaMon

GO
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH001', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH002', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH003', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH004', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH005', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH006', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH007', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH008', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH009', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT009', N'CH010', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH001', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH002', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH003', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH004', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH005', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH006', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH007', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH008', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH010', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH012', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH013', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH014', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH016', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH017', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH018', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT011', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH001', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH002', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH003', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH004', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH005', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH006', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH007', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH008', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH010', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH011', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH012', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH013', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH014', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH016', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH017', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH018', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH019', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK002', N'DT012', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH001', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH002', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH003', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH004', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH005', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH006', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH007', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH008', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH010', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH012', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH013', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH014', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH015', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH016', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH017', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH018', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK008', N'DT011', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH001', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH002', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH003', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH004', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH005', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH006', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH007', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH008', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH009', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH010', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH011', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH012', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH013', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH014', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH015', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH016', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH017', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH018', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK009', N'DT011', N'CH020', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH001', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH002', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH003', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH004', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH005', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH006', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH007', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH008', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH009', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH010', N'A')
GO
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH012', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH013', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH014', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH016', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH017', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH018', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK010', N'DT011', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH001', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH002', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH003', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH004', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH005', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH006', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH007', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH008', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH009', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH010', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH012', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH013', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH014', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH016', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH017', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH018', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK011', N'DT011', N'CH020', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH001', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH002', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH003', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH004', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH005', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH006', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH007', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH008', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH009', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH010', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH012', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH013', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH014', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH016', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH017', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH018', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK012', N'DT011', N'CH020', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH001', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH002', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH003', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH004', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH005', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH006', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH007', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH008', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH010', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH012', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH013', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH014', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH015', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH016', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH017', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH018', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK013', N'DT011', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH001', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH002', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH003', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH004', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH005', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH006', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH007', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH008', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH009', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH010', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH011', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH012', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH013', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH014', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH016', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH017', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH018', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK014', N'DT011', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH001', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH002', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH003', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH004', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH005', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH006', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH007', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH008', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH010', N'C')
GO
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH011', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH012', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH013', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH014', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH015', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH016', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH017', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH018', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH019', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK015', N'DT011', N'CH020', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH001', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH002', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH003', N'D')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH004', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH005', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH006', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH007', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH008', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH010', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH011', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH012', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH013', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH014', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH015', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH016', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH017', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH018', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH019', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK016', N'DT011', N'CH020', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH001', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH002', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH003', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH004', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH005', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH006', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH007', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH008', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH009', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH010', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH011', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH012', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH013', N'C')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH014', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH015', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH016', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH017', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH018', N'B')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH019', N'A')
INSERT [dbo].[BaiLam] ([MaTK], [MaDe], [MaCH], [CauChon]) VALUES (N'TK017', N'DT011', N'CH020', N'B')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN001', N'Làm Bài Thi')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN002', N'Lịch sử thi')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN003', N'Thống Kê')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN004', N'Quản Lý')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN005', N'Quản Lý Tài Khoản')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN006', N'Quản Lý Dữ Liệu')
INSERT [dbo].[ChucNang] ([MaCN], [TenCN]) VALUES (N'CN007', N'Tạo Kì Thi')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN003')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN005')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN006')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK001', N'CN007')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK002', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK002', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK008', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK008', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK009', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK009', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK010', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK010', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK011', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK011', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK012', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK012', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK013', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK013', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK014', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK014', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK015', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK015', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK016', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK016', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK017', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK017', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK018', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK018', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK018', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK019', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK019', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK019', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK020', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK020', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK020', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK021', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK021', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK021', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK022', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK022', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK022', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK023', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK023', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK023', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK024', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK024', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK024', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK025', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK025', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK025', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK026', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK026', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK026', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK027', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK027', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK027', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK028', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK028', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK028', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK030', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK030', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK030', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK031', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK031', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK031', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK032', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK032', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK032', N'CN003')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK032', N'CN004')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK032', N'CN006')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK032', N'CN007')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK033', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK033', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK034', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK034', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK035', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK035', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK036', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK036', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK037', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK037', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK038', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK038', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK039', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK039', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK040', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK040', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK041', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK041', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK042', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK042', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK043', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK043', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK044', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK044', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK045', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK045', N'CN002')
GO
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK046', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK046', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK047', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK047', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK048', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK048', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK049', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK049', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK050', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK050', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK051', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK051', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK052', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK052', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK053', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK053', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK054', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK054', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK055', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK055', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK056', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK056', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK057', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK057', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK058', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK058', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK059', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK059', N'CN002')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK060', N'CN001')
INSERT [dbo].[ChucNangTaiKhoan] ([MaTK], [MaCN]) VALUES (N'TK060', N'CN002')
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT001', N'MT001', 15, N'Đề Thi Môn Hóa', 10)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT002', N'MT001', 15, N'Đề 3', 10)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT003', N'MT001', 20, N'Đề 4', 10)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT004', N'MT001', 17, N'Đề', 6)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT005', N'MT001', 10, N'Đề 1', 7)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT006', N'MT001', 30, N'Đề Thi 1', 6)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT007', N'MT001', 10, N'Đề 1', 5)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT008', N'MT001', 30, N'Đề 1', 10)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT009', N'MT001', 20, N'Đề 20 phút', 10)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT010', N'MT001', 2, N'Đề Thi Môn Hóa 2', 20)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT011', N'MT001', 20, N'Đề Thi Môn Hóa', 20)
INSERT [dbo].[DeThi] ([MaDe], [MaMon], [ThoiGian], [TenDe], [SoCau]) VALUES (N'DT012', N'MT001', 30, N'Đề Thi Báo Cáo', 20)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK002', N'LT007', 6, N'DT009', CAST(0x0000AD6A01173001 AS DateTime), 6)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK002', N'LT011', 1.5, N'DT012', CAST(0x0000AD6B01564395 AS DateTime), 3)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK002', N'LT012', 2.5, N'DT011', CAST(0x0000AD7000F4B59E AS DateTime), 5)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK008', N'LT012', 1.5, N'DT011', CAST(0x0000AD7000F55C8F AS DateTime), 3)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK009', N'LT012', 2.5, N'DT011', CAST(0x0000AD7000F5B2BF AS DateTime), 5)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK010', N'LT012', 1, N'DT011', CAST(0x0000AD7000F5FC4D AS DateTime), 2)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK011', N'LT012', 1.5, N'DT011', CAST(0x0000AD7000F647A3 AS DateTime), 3)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK012', N'LT012', 3, N'DT011', CAST(0x0000AD7000F68467 AS DateTime), 6)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK013', N'LT012', 3, N'DT011', CAST(0x0000AD7000F6CE7E AS DateTime), 6)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK014', N'LT012', 0, N'DT011', CAST(0x0000AD7000F7133D AS DateTime), 0)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK015', N'LT012', 3, N'DT011', CAST(0x0000AD7000F7818C AS DateTime), 6)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK016', N'LT012', 3.5, N'DT011', CAST(0x0000AD7000F81E71 AS DateTime), 7)
INSERT [dbo].[LichSuThi] ([MaTK], [MaLT], [Diem], [MaDe], [NgayThi], [SoCauDung]) VALUES (N'TK017', N'LT012', 2, N'DT011', CAST(0x0000AD7000F886AF AS DateTime), 4)
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT001', N'TK001', N'DT003', CAST(0x0000AD64012D052A AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT002', N'TK001', N'DT004', CAST(0x0000AD64013C0DC4 AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT003', N'TK001', N'DT005', CAST(0x0000AD650036DCFC AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT004', N'TK001', N'DT006', CAST(0x0000AD65003B89AE AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT005', N'TK001', N'DT007', CAST(0x0000AD65003BED81 AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT006', N'TK001', N'DT008', CAST(0x0000AD65007B98A0 AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT007', N'TK001', N'DT009', CAST(0x0000AD6A011567A0 AS DateTime), N'Kỳ Thi 1')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT008', N'TK001', N'DT011', CAST(0x0000AD6B01444B24 AS DateTime), N'Kỳ thi 2')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT009', N'TK001', N'DT010', CAST(0x0000AD6C0144D4DF AS DateTime), N'Kỳ Thi 3')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT010', N'TK001', N'DT006', CAST(0x0000AD6B0145CF08 AS DateTime), N'Kỳ Thi 4')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT011', N'TK001', N'DT012', CAST(0x0000AD6B0154C710 AS DateTime), N'Kỳ Thi  Báo Cáo')
INSERT [dbo].[LichThi] ([MaLT], [MaGV], [MaDe], [NgayThi], [TenKyThi]) VALUES (N'LT012', N'TK001', N'DT011', CAST(0x0000AD700133A2B0 AS DateTime), N'Kỳ Thi 25/7')
INSERT [dbo].[LoaiTaiKhoan] ([Maloai], [Tenloai]) VALUES (N'LTK01', N'Admin')
INSERT [dbo].[LoaiTaiKhoan] ([Maloai], [Tenloai]) VALUES (N'LTK02', N'Thí Sinh')
INSERT [dbo].[LoaiTaiKhoan] ([Maloai], [Tenloai]) VALUES (N'LTK03', N'Giảng Viên')
INSERT [dbo].[MonThi] ([MaMon], [TenMon]) VALUES (N'MT001', N'Hóa 12')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH001', N'MT001', N'Ứng với công thức C4H8O2 có bao nhiêu este là đồng phân của nhau ?', N'2', N'3', N'4', N'5', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH002', N'MT001', N'Este có mùi dứa là', N'isoamyl axetat', N'etyl butirat.', N'etyl axetat', N'geranyl axctat.', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH003', N'MT001', N'Đun nóng este HCOOCH3 với một lượng vừa đủ dung dịch NaOH, sản phẩm thu được là', N'CH3COONa và C2H5OH', N'HCOONa và CH3OH', N'HCOONa và C2H5OH', N'CH3COOC6H5 (phenyl axetat)', N'D')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH004', N'MT001', N'Thuỷ phân hoàn toàn 3,7 gam chất X có công thức phân tử C3H6O2 trong 100 gam dung dịch NaOH 4%, cô cạn dung dịch sau phản ứng thu được 5,4 gam chất rắn. Công thức cấu tạo của X là', N'HCOOC2H5.', N'HCOOC3H7', N'CH3COOCH3', N'CH3COOC2H5', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH005', N'MT001', N'Thuỷ phân hoàn toàn hai este đơn chức X và Y là đồng phân cấu tạo của nhau cần 100 ml dung dịch NaOH IM, thu được 7,64 gam hỗn hợp 2 muối và 3,76 gam hồn hợp P gồm hai ancol Z và T (MZ < MT). Phần trăm khối lượng của Z trong P là', N'0,51', N'0,49', N'0,66', N'0,34', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH006', N'MT001', N'Este X chứa vòng benzen có công thức phân từ là C8H8C2. số công thức cấu tạo của X là ', N'3', N'4', N'5', N'6', N'D')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH007', N'MT001', N'Este đơn chức X có tỉ khối hơi so với CH4 là 6,25. Cho 20 gam X tác dụng với 300 ml dung dịch KOH 1M (đun nóng). Cô cạn dung dịch sau phản ứng thu được 28 gam chất rắn khan. Công thức của X là', N'HCOOC4H7', N'CH3COOC3H5', N'C2H3COOC2H5', N'C2H5COOC2H3', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH008', N'MT001', N'Cho 13,6 gam phenyl axetat tác dụng với 250 ml dung dịch NaOH 1M, cô cạn dung dịch sau phản ứng được m gam chất rắn. Giá trị của m là', N'19,8', N'21,8', N'14,2', N'11,6', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH009', N'MT001', N'Este X không no, mạch hở, có tỉ khối hơi so với oxi bằng 3,125. Cho X tác dụng hoàn toàn với NaOH thu được một anđehit và một muối của axit hữu cơ. Số công thức cấu tạo phù hợp với X là', N'2', N'3', N'4', N'5', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH010', N'MT001', N'Este nào sau đây khi phản ứng với dung dịch NaOH dư, đun nóng không tạo ra hai muối ?', N'C6H5COOC6H5 (phenyl benzoat', N'CH3COO-[CH2]2-OOCCH2CH3', N'CH3OOC-COOCH3', N'CH3COOC6H5 (phenyl axetat)', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH011', N'MT001', N'Ứng với công thức C4H8O2 có bao nhiêu este là đồng phân của nhau ?', N'2', N'2', N'3', N'4', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH012', N'MT001', N'Este có mùi dứa là', N'isoamyl axetat', N'isoamyl axetat', N'etyl butirat.', N'etyl axetat', N'B')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH013', N'MT001', N'Đun nóng este HCOOCH3 với một lượng vừa đủ dung dịch NaOH, sản phẩm thu được là', N'CH3COONa và C2H5OH', N'CH3COONa và C2H5OH', N'HCOONa và CH3OH', N'HCOONa và C2H5OH', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH014', N'MT001', N'Thuỷ phân hoàn toàn 3,7 gam chất X có công thức phân tử C3H6O2 trong 100 gam dung dịch NaOH 4%, cô cạn dung dịch sau phản ứng thu được 5,4 gam chất rắn. Công thức cấu tạo của X là', N'HCOOC2H5.', N'HCOOC2H5.', N'HCOOC3H7', N'CH3COOCH3', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH015', N'MT001', N'Thuỷ phân hoàn toàn hai este đơn chức X và Y là đồng phân cấu tạo của nhau cần 100 ml dung dịch NaOH IM, thu được 7,64 gam hỗn hợp 2 muối và 3,76 gam hồn hợp P gồm hai ancol Z và T (MZ < MT). Phần trăm khối lượng của Z trong P là', N'0,51', N'0,51', N'0,49', N'0,66', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH016', N'MT001', N'Este X chứa vòng benzen có công thức phân từ là C8H8C2. số công thức cấu tạo của X là ', N'3', N'3', N'4', N'5', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH017', N'MT001', N'Este đơn chức X có tỉ khối hơi so với CH4 là 6,25. Cho 20 gam X tác dụng với 300 ml dung dịch KOH 1M (đun nóng). Cô cạn dung dịch sau phản ứng thu được 28 gam chất rắn khan. Công thức của X là', N'HCOOC4H7', N'HCOOC4H7', N'CH3COOC3H5', N'C2H3COOC2H5', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH018', N'MT001', N'Cho 13,6 gam phenyl axetat tác dụng với 250 ml dung dịch NaOH 1M, cô cạn dung dịch sau phản ứng được m gam chất rắn. Giá trị của m là', N'19,8', N'19,8', N'21,8', N'14,2', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH019', N'MT001', N'Este X không no, mạch hở, có tỉ khối hơi so với oxi bằng 3,125. Cho X tác dụng hoàn toàn với NaOH thu được một anđehit và một muối của axit hữu cơ. Số công thức cấu tạo phù hợp với X là', N'2', N'2', N'3', N'4', N'D')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH020', N'MT001', N'Este nào sau đây khi phản ứng với dung dịch NaOH dư, đun nóng không tạo ra hai muối ?', N'C6H5COOC6H5 (phenyl benzoat', N'C6H5COOC6H5 (phenyl benzoat', N'CH3COO-[CH2]2-OOCCH2CH3', N'CH3OOC-COOCH3', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH021', N'MT001', N'A', N'a', N'b', N'c', N'b', N'D')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH022', N'MT001', N'Ứng với công thức C4H8O2 có bao nhiêu este là đồng phân của nhau ?', N'2', N'2', N'3', N'4', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH023', N'MT001', N'Este có mùi dứa là', N'isoamyl axetat', N'isoamyl axetat', N'etyl butirat.', N'etyl axetat', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH024', N'MT001', N'Đun nóng este HCOOCH3 với một lượng vừa đủ dung dịch NaOH, sản phẩm thu được là', N'CH3COONa và C2H5OH', N'CH3COONa và C2H5OH', N'HCOONa và CH3OH', N'HCOONa và C2H5OH', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH025', N'MT001', N'Thuỷ phân hoàn toàn 3,7 gam chất X có công thức phân tử C3H6O2 trong 100 gam dung dịch NaOH 4%, cô cạn dung dịch sau phản ứng thu được 5,4 gam chất rắn. Công thức cấu tạo của X là', N'HCOOC2H5.', N'HCOOC2H5.', N'HCOOC3H7', N'CH3COOCH3', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH026', N'MT001', N'Thuỷ phân hoàn toàn hai este đơn chức X và Y là đồng phân cấu tạo của nhau cần 100 ml dung dịch NaOH IM, thu được 7,64 gam hỗn hợp 2 muối và 3,76 gam hồn hợp P gồm hai ancol Z và T (MZ < MT). Phần trăm khối lượng của Z trong P là', N'0,51', N'0,51', N'0,49', N'0,66', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH027', N'MT001', N'Este X chứa vòng benzen có công thức phân từ là C8H8C2. số công thức cấu tạo của X là ', N'3', N'3', N'4', N'5', N'B')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH028', N'MT001', N'Este đơn chức X có tỉ khối hơi so với CH4 là 6,25. Cho 20 gam X tác dụng với 300 ml dung dịch KOH 1M (đun nóng). Cô cạn dung dịch sau phản ứng thu được 28 gam chất rắn khan. Công thức của X là', N'HCOOC4H7', N'HCOOC4H7', N'CH3COOC3H5', N'C2H3COOC2H5', N'C')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH029', N'MT001', N'Cho 13,6 gam phenyl axetat tác dụng với 250 ml dung dịch NaOH 1M, cô cạn dung dịch sau phản ứng được m gam chất rắn. Giá trị của m là', N'19,8', N'19,8', N'21,8', N'14,2', N'B')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH030', N'MT001', N'Este X không no, mạch hở, có tỉ khối hơi so với oxi bằng 3,125. Cho X tác dụng hoàn toàn với NaOH thu được một anđehit và một muối của axit hữu cơ. Số công thức cấu tạo phù hợp với X là', N'2', N'2', N'3', N'4', N'A')
INSERT [dbo].[NganHangCauHoi] ([MaCH], [MaMon], [NoiDung], [A], [B], [C], [D], [DapAn]) VALUES (N'CH031', N'MT001', N'Este nào sau đây khi phản ứng với dung dịch NaOH dư, đun nóng không tạo ra hai muối ?', N'C6H5COOC6H5 (phenyl benzoat', N'C6H5COOC6H5 (phenyl benzoat', N'CH3COO-[CH2]2-OOCCH2CH3', N'CH3OOC-COOCH3', N'C')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT002', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT003', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT004', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT005', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT005', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT005', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT005', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT005', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT005', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT006', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT007', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT007', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT007', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT007', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT007', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT008', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT009', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH011')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH012')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH013')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH014')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH015')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH016')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH017')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH018')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH019')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT010', N'CH020')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH011')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH012')
GO
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH013')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH014')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH015')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH016')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH017')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH018')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH019')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT011', N'CH020')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH001')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH002')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH003')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH004')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH005')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH006')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH007')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH008')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH009')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH010')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH011')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH012')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH013')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH014')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH015')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH016')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH017')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH018')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH019')
INSERT [dbo].[NoiDungDe] ([MaDe], [MaCH]) VALUES (N'DT012', N'CH020')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK001', N'Admin', N'123', N'Trần Tấn Hiếu', CAST(0x45240B00 AS Date), N'Quảng Ngãi', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/Image%2F999logo_2.jpg?alt=media&token=58e357b7-37f3-4c04-8186-cd198aa221ee', N'LTK01')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK002', N'TS', N'123', N'Thí Sinh', CAST(0x50240B00 AS Date), N'Quảng Ngãi', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/Image%2F601Logofilm.jpg?alt=media&token=8273d84c-469a-44ad-8c61-bcc3f69e8348', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK008', N'TK008', N'19032000', N'Trần Trấn Hiếu 6', CAST(0x55240B00 AS Date), N'Quảng Ngãi 6', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK009', N'TK009', N'20032000', N'Trần Trấn Hiếu 7', CAST(0x56240B00 AS Date), N'Quảng Ngãi 7', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK010', N'TK010', N'21032000', N'Trần Trấn Hiếu 8', CAST(0x57240B00 AS Date), N'Quảng Ngãi 8', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK011', N'TK011', N'22032000', N'Nhật Anh', CAST(0x58240B00 AS Date), N'TP.HCM', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK012', N'TK012', N'23032000', N'Trần Trấn Hiếu 10', CAST(0x59240B00 AS Date), N'Quảng Ngãi 10', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK013', N'TK013', N'24032000', N'Trần Trấn Hiếu 11', CAST(0x5A240B00 AS Date), N'Quảng Ngãi 11', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK014', N'TK014', N'25032000', N'Trần Trấn Hiếu', CAST(0x5B240B00 AS Date), N'Quảng Ngãi 12', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK015', N'TK015', N'26032000', N'Trần Trấn Hiếu 13', CAST(0x5C240B00 AS Date), N'Quảng Ngãi 13', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK016', N'TK016', N'27032000', N'Trần Trấn Hiếu 14', CAST(0x5D240B00 AS Date), N'Quảng Ngãi 14', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK017', N'TTS', N'123', N'TranTan Hieu', CAST(0x45240B00 AS Date), N'Quảng Ngãi', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/Image%2F840logo_3%20-%20Copy.jpg?alt=media&token=668bd78f-7719-4cdd-a4a4-8b0efb7985e3', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK018', N'TK018', N'14032000', N'Trần Trấn Hiếu 1', CAST(0x50240B00 AS Date), N'Quảng Ngãi 1', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK019', N'TK019', N'15032000', N'Trần Trấn Hiếu 2', CAST(0x51240B00 AS Date), N'Quảng Ngãi 2', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK020', N'TK020', N'16032000', N'Trần Trấn Hiếu 3', CAST(0x52240B00 AS Date), N'Quảng Ngãi 3', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK021', N'TK021', N'17032000', N'Trần Trấn Hiếu 4', CAST(0x53240B00 AS Date), N'Quảng Ngãi 4', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK022', N'TK022', N'18032000', N'Trần Trấn Hiếu 5', CAST(0x54240B00 AS Date), N'Quảng Ngãi 5', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK023', N'TK023', N'19032000', N'Trần Trấn Hiếu 6', CAST(0x55240B00 AS Date), N'Quảng Ngãi 6', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK024', N'TK024', N'20032000', N'Trần Trấn Hiếu 7', CAST(0x56240B00 AS Date), N'Quảng Ngãi 7', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK025', N'TK025', N'21032000', N'Trần Trấn Hiếu 8', CAST(0x57240B00 AS Date), N'Quảng Ngãi 8', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK026', N'TK026', N'22032000', N'Trần Trấn Hiếu 9', CAST(0x58240B00 AS Date), N'Quảng Ngãi 9', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK027', N'TK027', N'23032000', N'Trần Trấn Hiếu 10', CAST(0x59240B00 AS Date), N'Quảng Ngãi 10', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK028', N'TK028', N'24032000', N'Trần Trấn Hiếu ', CAST(0x5A240B00 AS Date), N'Quảng Ngãi 11', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK030', N'TK030', N'26032000', N'Trần Trấn Hiếu 13', CAST(0x5C240B00 AS Date), N'Quảng Ngãi 13', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK031', N'TK031', N'27032000', N'Trần Trấn Hiếu 14', CAST(0x5D240B00 AS Date), N'Quảng Ngãi 14', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK032', N'NA', N'123', N'Nhật Anh', CAST(0x58240B00 AS Date), N'TP.HCM', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK03')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK033', N'TK033', N'14032000', N'Trần Trấn Hiếu 1', CAST(0x50240B00 AS Date), N'Quảng Ngãi 1', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK034', N'TK034', N'15032000', N'Trần Trấn Hiếu 2', CAST(0x51240B00 AS Date), N'Quảng Ngãi 2', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK035', N'TK035', N'16032000', N'Trần Trấn Hiếu 3', CAST(0x52240B00 AS Date), N'Quảng Ngãi 3', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK036', N'TK036', N'17032000', N'Trần Trấn Hiếu 4', CAST(0x53240B00 AS Date), N'Quảng Ngãi 4', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK037', N'TK037', N'18032000', N'Trần Trấn Hiếu 5', CAST(0x54240B00 AS Date), N'Quảng Ngãi 5', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK038', N'TK038', N'19032000', N'Trần Trấn Hiếu 6', CAST(0x55240B00 AS Date), N'Quảng Ngãi 6', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK039', N'TK039', N'20032000', N'Trần Trấn Hiếu 7', CAST(0x56240B00 AS Date), N'Quảng Ngãi 7', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK040', N'TK040', N'21032000', N'Trần Trấn Hiếu 8', CAST(0x57240B00 AS Date), N'Quảng Ngãi 8', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK041', N'TK041', N'22032000', N'Trần Trấn Hiếu 9', CAST(0x58240B00 AS Date), N'Quảng Ngãi 9', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK042', N'TK042', N'23032000', N'Trần Trấn Hiếu 10', CAST(0x59240B00 AS Date), N'Quảng Ngãi 10', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK043', N'TK043', N'24032000', N'Trần Trấn Hiếu 11', CAST(0x5A240B00 AS Date), N'Quảng Ngãi 11', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK044', N'TK044', N'25032000', N'Trần Trấn Hiếu 12', CAST(0x5B240B00 AS Date), N'Quảng Ngãi 12', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK045', N'TK045', N'26032000', N'Trần Trấn Hiếu 13', CAST(0x5C240B00 AS Date), N'Quảng Ngãi 13', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK046', N'TK046', N'27032000', N'Trần Trấn Hiếu 14', CAST(0x5D240B00 AS Date), N'Quảng Ngãi 14', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK047', N'TK047', N'14032000', N'Trần Trấn Hiếu 1', CAST(0x50240B00 AS Date), N'Quảng Ngãi 1', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK048', N'TK048', N'15032000', N'Trần Trấn Hiếu 2', CAST(0x51240B00 AS Date), N'Quảng Ngãi 2', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK049', N'TK049', N'16032000', N'Trần Trấn Hiếu 3', CAST(0x52240B00 AS Date), N'Quảng Ngãi 3', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK050', N'TK050', N'17032000', N'Trần Trấn Hiếu 4', CAST(0x53240B00 AS Date), N'Quảng Ngãi 4', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK051', N'TK051', N'18032000', N'Trần Trấn Hiếu 5', CAST(0x54240B00 AS Date), N'Quảng Ngãi 5', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK052', N'TK052', N'19032000', N'Trần Trấn Hiếu 6', CAST(0x55240B00 AS Date), N'Quảng Ngãi 6', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK053', N'TK053', N'20032000', N'Trần Trấn Hiếu 7', CAST(0x56240B00 AS Date), N'Quảng Ngãi 7', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK054', N'TK054', N'21032000', N'Trần Trấn Hiếu 8', CAST(0x57240B00 AS Date), N'Quảng Ngãi 8', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK055', N'TK055', N'22032000', N'Trần Trấn Hiếu 9', CAST(0x58240B00 AS Date), N'Quảng Ngãi 9', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK056', N'TK056', N'23032000', N'Trần Trấn Hiếu 10', CAST(0x59240B00 AS Date), N'Quảng Ngãi 10', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK057', N'TK057', N'24032000', N'Trần Trấn Hiếu 11', CAST(0x5A240B00 AS Date), N'Quảng Ngãi 11', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK058', N'TK058', N'25032000', N'Trần Trấn Hiếu 12', CAST(0x5B240B00 AS Date), N'Quảng Ngãi 12', N'Nữ', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK059', N'TK059', N'26032000', N'Trần Trấn Hiếu 13', CAST(0x5C240B00 AS Date), N'Quảng Ngãi 13', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[TaiKhoan] ([MaUse], [Usename], [Pass], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [HinhAnh], [LoaiTK]) VALUES (N'TK060', N'TK060', N'27032000', N'Trần Trấn Hiếu 14', CAST(0x5D240B00 AS Date), N'Quảng Ngãi 14', N'Nam', N'https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f', N'LTK02')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK001')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK008')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK009')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK010')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK011')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK012')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK013')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK014')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK015')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK016')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK017')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK018')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK019')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK020')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK021')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK022')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK023')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK024')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK025')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK026')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK027')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK028')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK030')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK031')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK032')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK033')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK034')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK035')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK036')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK037')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK038')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK039')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK040')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK041')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK042')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK043')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK044')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK045')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK046')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK047')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK048')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK049')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK050')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK051')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK052')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK053')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK054')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK055')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK056')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK057')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK058')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK059')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT001', N'TK060')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT002', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT003', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT005', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT006', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT007', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT008', N'TK001')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT008', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT008', N'TK008')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT009', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT009', N'TK010')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT009', N'TK011')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT009', N'TK012')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT009', N'TK013')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT009', N'TK014')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK008')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK009')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK010')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK011')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK012')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK013')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK014')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK015')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT011', N'TK016')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK002')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK008')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK009')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK010')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK011')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK012')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK013')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK014')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK015')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK016')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK017')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK018')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK019')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK020')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK021')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK022')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK023')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK024')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK025')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK026')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK027')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK028')
GO
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK030')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK031')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK032')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK033')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK034')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK035')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK036')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK037')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK038')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK039')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK040')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK041')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK042')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK043')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK044')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK045')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK046')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK047')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK048')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK049')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK050')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK051')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK052')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK053')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK054')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK055')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK056')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK057')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK058')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK059')
INSERT [dbo].[ThamGiaThi] ([MaLT], [MaTK]) VALUES (N'LT012', N'TK060')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__813EFC5CF24D2C5D]    Script Date: 25/07/2021 7:13:22 CH ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[Usename] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BaiLam]  WITH CHECK ADD  CONSTRAINT [FK_BaiLam_DeThi] FOREIGN KEY([MaDe])
REFERENCES [dbo].[DeThi] ([MaDe])
GO
ALTER TABLE [dbo].[BaiLam] CHECK CONSTRAINT [FK_BaiLam_DeThi]
GO
ALTER TABLE [dbo].[BaiLam]  WITH CHECK ADD  CONSTRAINT [FK_BaiLam_NganHangCauHoi] FOREIGN KEY([MaCH])
REFERENCES [dbo].[NganHangCauHoi] ([MaCH])
GO
ALTER TABLE [dbo].[BaiLam] CHECK CONSTRAINT [FK_BaiLam_NganHangCauHoi]
GO
ALTER TABLE [dbo].[BaiLam]  WITH CHECK ADD  CONSTRAINT [FK_BaiLam_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaUse])
GO
ALTER TABLE [dbo].[BaiLam] CHECK CONSTRAINT [FK_BaiLam_TaiKhoan]
GO
ALTER TABLE [dbo].[ChucNangTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_ChucNangTaiKhoan_ChucNang] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChucNang] ([MaCN])
GO
ALTER TABLE [dbo].[ChucNangTaiKhoan] CHECK CONSTRAINT [FK_ChucNangTaiKhoan_ChucNang]
GO
ALTER TABLE [dbo].[ChucNangTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_ChucNangTaiKhoan_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaUse])
GO
ALTER TABLE [dbo].[ChucNangTaiKhoan] CHECK CONSTRAINT [FK_ChucNangTaiKhoan_TaiKhoan]
GO
ALTER TABLE [dbo].[DeThi]  WITH CHECK ADD  CONSTRAINT [FK_DeThi_MonThi] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonThi] ([MaMon])
GO
ALTER TABLE [dbo].[DeThi] CHECK CONSTRAINT [FK_DeThi_MonThi]
GO
ALTER TABLE [dbo].[LichSuThi]  WITH CHECK ADD  CONSTRAINT [FK_LichSuThi_DeThi] FOREIGN KEY([MaDe])
REFERENCES [dbo].[DeThi] ([MaDe])
GO
ALTER TABLE [dbo].[LichSuThi] CHECK CONSTRAINT [FK_LichSuThi_DeThi]
GO
ALTER TABLE [dbo].[LichSuThi]  WITH CHECK ADD  CONSTRAINT [FK_LichSuThi_LichThi] FOREIGN KEY([MaLT])
REFERENCES [dbo].[LichThi] ([MaLT])
GO
ALTER TABLE [dbo].[LichSuThi] CHECK CONSTRAINT [FK_LichSuThi_LichThi]
GO
ALTER TABLE [dbo].[LichSuThi]  WITH CHECK ADD  CONSTRAINT [FK_LichSuThi_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaUse])
GO
ALTER TABLE [dbo].[LichSuThi] CHECK CONSTRAINT [FK_LichSuThi_TaiKhoan]
GO
ALTER TABLE [dbo].[LichThi]  WITH CHECK ADD  CONSTRAINT [FK_LichThi_DeThi] FOREIGN KEY([MaDe])
REFERENCES [dbo].[DeThi] ([MaDe])
GO
ALTER TABLE [dbo].[LichThi] CHECK CONSTRAINT [FK_LichThi_DeThi]
GO
ALTER TABLE [dbo].[LichThi]  WITH CHECK ADD  CONSTRAINT [FK_LichThi_TaiKhoan1] FOREIGN KEY([MaGV])
REFERENCES [dbo].[TaiKhoan] ([MaUse])
GO
ALTER TABLE [dbo].[LichThi] CHECK CONSTRAINT [FK_LichThi_TaiKhoan1]
GO
ALTER TABLE [dbo].[NoiDungDe]  WITH CHECK ADD  CONSTRAINT [FK_NoiDungDe_DeThi] FOREIGN KEY([MaDe])
REFERENCES [dbo].[DeThi] ([MaDe])
GO
ALTER TABLE [dbo].[NoiDungDe] CHECK CONSTRAINT [FK_NoiDungDe_DeThi]
GO
ALTER TABLE [dbo].[NoiDungDe]  WITH CHECK ADD  CONSTRAINT [FK_NoiDungDe_NganHangCauHoi] FOREIGN KEY([MaCH])
REFERENCES [dbo].[NganHangCauHoi] ([MaCH])
GO
ALTER TABLE [dbo].[NoiDungDe] CHECK CONSTRAINT [FK_NoiDungDe_NganHangCauHoi]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan] FOREIGN KEY([LoaiTK])
REFERENCES [dbo].[LoaiTaiKhoan] ([Maloai])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO
ALTER TABLE [dbo].[ThamGiaThi]  WITH CHECK ADD  CONSTRAINT [FK_ThamGiaThi_LichThi] FOREIGN KEY([MaLT])
REFERENCES [dbo].[LichThi] ([MaLT])
GO
ALTER TABLE [dbo].[ThamGiaThi] CHECK CONSTRAINT [FK_ThamGiaThi_LichThi]
GO
ALTER TABLE [dbo].[ThamGiaThi]  WITH CHECK ADD  CONSTRAINT [FK_ThamGiaThi_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaUse])
GO
ALTER TABLE [dbo].[ThamGiaThi] CHECK CONSTRAINT [FK_ThamGiaThi_TaiKhoan]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LichSuThi"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "MonThi"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DeThi"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_LichSuThi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_LichSuThi'
GO
USE [master]
GO
ALTER DATABASE [QL_ThiTracNghiem] SET  READ_WRITE 
GO
