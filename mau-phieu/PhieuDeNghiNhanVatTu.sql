USE [HWS_QLVT]
GO
/****** Object:  Table [dbo].[PhieuNhanVatTu]    Script Date: 10/23/2023 3:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhanVatTu](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[MaKeHoach] [bigint] NOT NULL,
	[MaHangMuc] [bigint] NOT NULL,
	[MaDonVi] [bigint] NOT NULL,
	[Nam] [smallint] NOT NULL,
	[Quy] [smallint] NOT NULL,
	[Thang] [smallint] NOT NULL,
	[LyDoNhan] [nvarchar](2000) NOT NULL,
	[MaNguoiNhan] [bigint] NOT NULL,
	[TenNguoiNhan] [nvarchar](500) NOT NULL,
	[MaTruongBoPhan] [bigint] NOT NULL,
	[TenTruongBoPhan] [nvarchar](500) NOT NULL,
	[MaKeToanVanTu] [bigint] NOT NULL,
	[TenKeToanVatTu] [nvarchar](500) NOT NULL,
	[MaKeHoachKyThuat] [bigint] NOT NULL,
	[TenKeHoachKyThuat] [nvarchar](500) NOT NULL,
	[MaKeToanTruong] [bigint] NOT NULL,
	[TenKeToanTruong] [nvarchar](500) NOT NULL,
	[MaLanhDaoPheDuyet] [bigint] NOT NULL,
	[TenLanhDaoPheDuyet] [nvarchar](500) NOT NULL,
	[TrangThai] [smallint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
	[UpdatedBy] [bigint] NOT NULL,
	[UpdatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhanVatTu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhanVatTu_ChiTiet]    Script Date: 10/23/2023 3:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhanVatTu_ChiTiet](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[MaPhieuNhanVatTu] [bigint] NOT NULL,
	[MaKeHoach] [bigint] NOT NULL,
	[MaDonVi] [bigint] NOT NULL,
	[Quy] [smallint] NOT NULL,
	[MaKeHoachChiTiet] [bigint] NOT NULL,
	[MaHangMuc] [bigint] NOT NULL,
	[MaKeHoachCongViec] [bigint] NOT NULL,
	[MaVatTu] [bigint] NOT NULL,
	[TenVatTu] [nvarchar](1000) NOT NULL,
	[MaVatTuThamChieu] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](50) NOT NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
	[NhomVatTu1Id] [bigint] NOT NULL,
	[TenNhomVatTu1] [nvarchar](500) NOT NULL,
	[NhomVatTu2Id] [bigint] NOT NULL,
	[TenNhomVatTu2] [nvarchar](500) NOT NULL,
	[NhomVatTu3Id] [bigint] NOT NULL,
	[TenNhomVatTu3] [nvarchar](500) NOT NULL,
	[SoLuong_KeHoach] [decimal](18, 2) NOT NULL,
	[SoLuong_DaNhan] [decimal](18, 2) NOT NULL,
	[SoLuong_ConLai] [decimal](18, 2) NOT NULL,
	[SoLuong_XinNhan] [decimal](18, 2) NOT NULL,
	[SoLuong_ThucNhan] [decimal](18, 2) NOT NULL,
	[DienGiai] [nvarchar](1000) NOT NULL,
	[TrangThai] [smallint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
	[UpdatedBy] [bigint] NOT NULL,
	[UpdatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhanVatTu_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PhieuNhanVatTu] ADD  CONSTRAINT [DF_PhieuNhanVatTu_Guid]  DEFAULT (newid()) FOR [Guid]
GO
ALTER TABLE [dbo].[PhieuNhanVatTu_ChiTiet] ADD  CONSTRAINT [DF_PhieuNhanVatTu_ChiTiet_Guid]  DEFAULT (newid()) FOR [Guid]
GO
