USE [master]
GO
/****** Object:  Database [QLBanXe]    Script Date: 07/18/20 3:50:26 PM ******/
CREATE DATABASE [QLBanXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanXe', FILENAME = N'C:\Users\Admin\QLBanXe.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBanXe_log', FILENAME = N'C:\Users\Admin\QLBanXe_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLBanXe] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBanXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBanXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBanXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBanXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBanXe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLBanXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBanXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBanXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBanXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBanXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBanXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBanXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBanXe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLBanXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBanXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBanXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBanXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBanXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBanXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBanXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBanXe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBanXe] SET  MULTI_USER 
GO
ALTER DATABASE [QLBanXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBanXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBanXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBanXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBanXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBanXe] SET QUERY_STORE = OFF
GO
USE [QLBanXe]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [QLBanXe]
GO
/****** Object:  Table [dbo].[cthoadon]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cthoadon](
	[Machitiet] [nvarchar](50) NOT NULL,
	[MaHoadon] [nvarchar](50) NULL,
	[masanpham] [nvarchar](100) NULL,
	[soluong] [int] NULL,
	[tongtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Machitiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPHIEUNHAP]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUNHAP](
	[MaPN] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](100) NOT NULL,
	[GiaNhap] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CTPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaNhom] [nvarchar](100) NOT NULL,
	[TenNhom] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](50) NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[TongTien] [int] NULL,
	[ThanhToan] [nvarchar](50) NULL,
	[MaNV] [nvarchar](100) NULL,
	[MaKH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [int] NULL,
	[Gmail] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTK]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTK](
	[ID] [int] NOT NULL,
	[TenLoaiTK] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](100) NOT NULL,
	[TenNhaCC] [nvarchar](100) NULL,
	[ĐiaChiNCC] [nvarchar](100) NULL,
	[SDTNCC] [int] NULL,
	[GmailNCC] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](100) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
	[NgayVaoLam] [date] NULL,
	[Luong] [int] NULL,
	[Gmail] [nvarchar](20) NULL,
	[SDT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [nvarchar](50) NOT NULL,
	[NgayLapPN] [datetime] NULL,
	[TongTien] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](100) NULL,
	[MaNV] [nvarchar](100) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](100) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[MaNhom] [nvarchar](100) NULL,
	[GiaBan] [int] NULL,
	[SoLuongTon] [int] NULL,
	[HinhAnh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[ID] [int] NULL,
	[MaNV] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD FOREIGN KEY([MaHoadon])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD FOREIGN KEY([masanpham])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP] CHECK CONSTRAINT [FK_CTPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUNHAP_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP] CHECK CONSTRAINT [FK_CTPHIEUNHAP_SanPham]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NhaCungCap]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[DanhMuc] ([MaNhom])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[LoaiTK] ([ID])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
/****** Object:  StoredProcedure [dbo].[danhmuc123]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[danhmuc123] ( @tennhom nvarchar(100))
as
begin
	declare @manhom nvarchar(100)
	IF (SELECT COUNT(MaNhom) FROM DanhMuc ) = 0
		SET @manhom = '0'
	ELSE
	begin
		SELECT @manhom = MAX(MaNhom) FROM DanhMuc
		set @manhom = SUBSTRING(@manhom,2,8)
		SELECT @manhom = CASE
			WHEN @manhom >= 0 and @manhom < 9 THEN 'N0' + CONVERT(CHAR, CONVERT(INT, @manhom) + 1)
			WHEN @manhom >= 9 THEN 'N' + CONVERT(CHAR, CONVERT(INT, @manhom) + 1)
		END
	end
	
	INSERT INTO DanhMuc values (@manhom , @tennhom)
end
GO
/****** Object:  StoredProcedure [dbo].[deletekh]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletekh] (@makh nvarchar(100))
as
begin

delete  HOADON where MaKH = @makh
delete KHACHHANG where MaKH = @makh

end
GO
/****** Object:  StoredProcedure [dbo].[deletenv]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletenv] (@manv nvarchar(100))
as
begin
delete   TaiKhoan where MaNV = @manv
delete  HOADON where MaNV = @manv
delete  PHIEUNHAP where MaNV = @manv
delete NhanVien where MaNV = @manv
end
GO
/****** Object:  StoredProcedure [dbo].[dt]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dt]
as
begin
select month(NgaylapHD) as 'thang' , SUM(TongTien) as 'Tongtien' from HOADON group by (NgayLapHD)
end
GO
/****** Object:  StoredProcedure [dbo].[dttn]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dttn]
as
begin
select Year(NgaylapHD) as 'thang' , SUM(TongTien) as 'Tongtien' from HOADON group by (NgayLapHD)
end
GO
/****** Object:  StoredProcedure [dbo].[insertctphieunhap]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertctphieunhap] (@masp nvarchar(100),@gianhap int,@soluong int,@thanhthien int)
as
begin
	declare @mapn nvarchar(100)
	IF (SELECT COUNT(MaPN) FROM CTPHIEUNHAP ) = 0
		SET @mapn = '0'
	ELSE
	begin
		SELECT @mapn = MAX(MaPN) FROM CTPHIEUNHAP
		set @mapn = SUBSTRING(@mapn,3,8)
		SELECT @mapn = CASE
			WHEN @mapn >= 0 and @mapn < 9 THEN 'PN0' + CONVERT(CHAR, CONVERT(INT, @mapn) + 1)
			WHEN @mapn >= 9 THEN 'PN' + CONVERT(CHAR, CONVERT(INT, @mapn) + 1)
		END
	end
	INSERT INTO CTPHIEUNHAP values (@mapn, @masp, @gianhap,@soluong,@thanhthien)
end
GO
/****** Object:  StoredProcedure [dbo].[insertctphieunhap123]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertctphieunhap123] (@mapn nvarchar(50), @Masp nvarchar(100),@gianhap int,@soluong int, @thanhtien int)
as
begin
	
	
	
	INSERT INTO CTPHIEUNHAP values (@mapn , @Masp ,@gianhap ,@soluong , @thanhtien )
	update PHIEUNHAP set TongTien=@thanhtien where MaPN=@mapn
end
GO
/****** Object:  StoredProcedure [dbo].[insertKH]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertKH] ( @tenkh nvarchar(50),@ngaysinh date,@sdt int,@Gmail nvarchar(50))
as
begin
	declare @manv nvarchar(100)
	IF (SELECT COUNT(MaKH) FROM KHACHHANG ) = 0
		SET @manv = '0'
	ELSE
	begin
		SELECT @manv = MAX(MaKH) FROM KHACHHANG
		set @manv = SUBSTRING(@manv,3,8)
		SELECT @manv = CASE
			WHEN @manv >= 0 and @manv < 9 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @manv) + 1)
			WHEN @manv >= 9 THEN 'KH' + CONVERT(CHAR, CONVERT(INT, @manv) + 1)
		END
	end
	INSERT INTO KHACHHANG values (@manv, @tenkh, @ngaysinh,@sdt,@Gmail)
end
GO
/****** Object:  StoredProcedure [dbo].[insertNV]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertNV] (@tennv nvarchar(100), @chucvu nvarchar(100) , @ngayvaolam date, @luong int,@Gmail nvarchar(20),@sdt int)
as
begin
	declare @manv nvarchar(100)
	IF (SELECT COUNT(MaNV) FROM NhanVien ) = 0
		SET @manv = '0'
	ELSE
	begin
		SELECT @manv = MAX(MaNV) FROM NhanVien
		set @manv = SUBSTRING(@manv,3,8)
		SELECT @manv = CASE
			WHEN @manv >= 0 and @manv < 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @manv) + 1)
			WHEN @manv >= 9 THEN 'NV' + CONVERT(CHAR, CONVERT(INT, @manv) + 1)
		END
	end
	INSERT INTO NhanVien values (@manv, @tennv, @chucvu, @ngayvaolam, @luong,@Gmail,@sdt)
end
GO
/****** Object:  StoredProcedure [dbo].[insertSP]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertSP] (@tensp nvarchar(100),@manhom nvarchar(100),@giaban int,@soluongton int,@hinhanh image)
as
begin
	declare @masp nvarchar(100)
	IF (SELECT COUNT(MaSP) FROM SanPham ) = 0
		SET @masp = '0'
	ELSE
	begin
		SELECT @masp = MAX(MaSP) FROM SanPham
		set @masp = SUBSTRING(@masp,3,8)
		SELECT @masp = CASE
			WHEN @masp >= 0 and @masp < 9 THEN 'SP0' + CONVERT(CHAR, CONVERT(INT, @masp) + 1)
			WHEN @masp >= 9 THEN 'SP' + CONVERT(CHAR, CONVERT(INT, @masp) + 1)
		END
	end
	INSERT INTO SanPham values (@masp, @tensp, @manhom,@giaban,@soluongton,@hinhanh)
end
GO
/****** Object:  StoredProcedure [dbo].[inssertCThoadon]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inssertCThoadon](

		@Machitiet nvarchar(50),
		@mahoadon nvarchar(50),
		@masanpham nvarchar(50),
		@soluong int,
		@tongtien int

	)
as
begin
insert into cthoadon values (
		@Machitiet ,
		@mahoadon ,
		@masanpham, 
		@soluong,
		@tongtien)
end
GO
/****** Object:  StoredProcedure [dbo].[inssertdanhmuc]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[inssertdanhmuc] ( @tennhom nvarchar(100))
as
begin
	declare @manhom nvarchar(100)
	IF (SELECT COUNT(@manhom) FROM DanhMuc ) = 0
		SET @manhom = '0'
	ELSE
	begin
		SELECT @manhom = MAX(MaNhom) FROM DanhMuc
		set @manhom = SUBSTRING(@manhom,3,8)
		SELECT @manhom = CASE
			WHEN @manhom >= 0 and @manhom < 9 THEN 'Nhom0' + CONVERT(CHAR, CONVERT(INT, @manhom) + 1)
			WHEN @manhom >= 9 THEN 'Nhom' + CONVERT(CHAR, CONVERT(INT, @manhom) + 1)
		END
	end
	INSERT INTO DanhMuc values (@manhom, @tennhom)
end
GO
/****** Object:  StoredProcedure [dbo].[INSSERTPN]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[INSSERTPN] (@ngaylappn datetime, @tongtien int , @tinhtrang nvarchar(50), @mancc nvarchar(100),@manv nvarchar(100))
as
begin
	declare @mapn nvarchar(30)
	IF (SELECT COUNT(MaPN) FROM PHIEUNHAP ) = 0
		SET @mapn = '0'
	ELSE
	begin
		SELECT @mapn = MAX(MaPN) FROM PHIEUNHAP
		set @mapn = SUBSTRING(@mapn,4,8)
		SELECT @mapn = CASE
			WHEN @mapn >= 0 and @mapn < 9 THEN 'PN00' + CONVERT(CHAR, CONVERT(INT, @mapn) + 1)
			WHEN @mapn >= 9 THEN 'PN0' + CONVERT(CHAR, CONVERT(INT, @mapn) + 1)
		END
	end
	INSERT INTO PHIEUNHAP values (@mapn, @ngaylappn, @tongtien, @tinhtrang, @mancc,@manv)
end
GO
/****** Object:  StoredProcedure [dbo].[seaching_nv]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_nv](
@valuaToFind nvarchar(50)
)
as
begin 
select *from NhanVien c where 
ConCat( c.MaNV,c.TenNV,c.ChucVu,c.NgayVaoLam,c.Luong,c.Gmail,c.SDT )like  '%' + @valuaToFind + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[seaching_tongtienthang]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[seaching_tongtienthang](
@valuaToFind nvarchar(50)
)
as
begin 
select *from HOADON c where 
ConCat( c.NgayLapHD,c.NgayLapHD)like  '%' + @valuaToFind + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[seaching_tongtienthang1]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[seaching_tongtienthang1](
@valuaToFind nvarchar(50)
)
as
begin 
select* from HOADON c where 
ConCat( c.NgayLapHD,c.NgayLapHD)like  '%' + @valuaToFind + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[update_Hd]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[update_Hd]
 @mahd nvarchar(50),
  @tongtien int
  as begin 
  update HOADON set TongTien=@tongtien where MaHD=@mahd
  end
GO
/****** Object:  StoredProcedure [dbo].[updatePhieuNhap]    Script Date: 07/18/20 3:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatePhieuNhap]
(
	@maphieunhap nvarchar(50),
	@tongtien int
	)
	as begin
	update PHIEUNHAP set MaPN=@maphieunhap where TongTien=@tongtien
	end
GO
USE [master]
GO
ALTER DATABASE [QLBanXe] SET  READ_WRITE 
GO
