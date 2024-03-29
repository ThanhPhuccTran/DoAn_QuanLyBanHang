USE [QL_BanHang_DienTu]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[machitiet] [int] IDENTITY(1,1) NOT NULL,
	[masanpham] [nvarchar](50) NOT NULL,
	[mahdban] [int] NOT NULL,
	[tensanpham] [nvarchar](50) NULL,
	[soluong] [decimal](18, 0) NULL,
	[dongia] [decimal](28, 0) NULL,
	[thanhtien] [decimal](38, 0) NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[machitiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDBan]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDBan](
	[mahdban] [int] IDENTITY(1,1) NOT NULL,
	[manhanvien] [nvarchar](50) NULL,
	[ngayban] [datetime] NULL,
 CONSTRAINT [PK_HDBan] PRIMARY KEY CLUSTERED 
(
	[mahdban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach](
	[makhach] [nvarchar](50) NOT NULL,
	[tenkhach] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khach] PRIMARY KEY CLUSTERED 
(
	[makhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[maloai] [nvarchar](50) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[manhanvien] [nvarchar](50) NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[masanpham] [nvarchar](50) NOT NULL,
	[tensanpham] [nvarchar](50) NULL,
	[maloai] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[dongiaban] [float] NULL,
	[anh] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/14/2024 2:40:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[phanquyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHD] ON 

INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (1, N'20t102', 15, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (2, N'sp1', 15, N'LapTop Dell', CAST(22 AS Decimal(18, 0)), CAST(30000000 AS Decimal(28, 0)), CAST(660000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (3, N'20t102', 16, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (4, N'sp1', 16, N'LapTop Dell', CAST(4 AS Decimal(18, 0)), CAST(30000000 AS Decimal(28, 0)), CAST(120000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (5, N'20t102', 17, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (6, N'20t102', 18, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (7, N'sp1', 19, N'LapTop Dell', CAST(2 AS Decimal(18, 0)), CAST(30000000 AS Decimal(28, 0)), CAST(60000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (8, N'20t102', 20, N'Laptopp22', CAST(2 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(6000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (9, N'20t102', 21, N'Laptopp22', CAST(2 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(6000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (10, N'20t102', 22, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (11, N'20t102', 23, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (12, N'sp3', 23, N'Laptop Asus', CAST(3 AS Decimal(18, 0)), CAST(14300000 AS Decimal(28, 0)), CAST(42900000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (13, N'20t102', 24, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (14, N'20t102', 25, N'Laptopp22', CAST(3 AS Decimal(18, 0)), CAST(3000000 AS Decimal(28, 0)), CAST(9000000 AS Decimal(38, 0)))
INSERT [dbo].[ChiTietHD] ([machitiet], [masanpham], [mahdban], [tensanpham], [soluong], [dongia], [thanhtien]) VALUES (15, N'sp1', 25, N'LapTop Dell', CAST(2 AS Decimal(18, 0)), CAST(30000000 AS Decimal(28, 0)), CAST(60000000 AS Decimal(38, 0)))
SET IDENTITY_INSERT [dbo].[ChiTietHD] OFF
GO
SET IDENTITY_INSERT [dbo].[HDBan] ON 

INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (1, N'thanhphuc', CAST(N'2022-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (2, N'thanhphuc', CAST(N'2022-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (3, N'thanhphuc', CAST(N'2024-01-07T21:14:20.007' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (4, N'thanhphuc', CAST(N'2024-01-07T22:38:10.153' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (5, N'thanhphuc', CAST(N'2024-01-07T22:40:44.017' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (6, N'thanhphuc', CAST(N'2024-01-07T22:43:14.133' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (7, N'thanhphuc', CAST(N'2024-01-07T22:46:28.630' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (8, N'thanhphuc', CAST(N'2024-01-07T22:48:39.607' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (9, N'thanhphuc', CAST(N'2024-01-07T22:56:54.003' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (10, N'thanhphuc', CAST(N'2024-01-07T22:56:54.003' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (11, N'thanhphuc', CAST(N'2024-01-07T22:57:46.600' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (12, N'thanhphuc', CAST(N'2024-01-07T22:57:46.600' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (13, N'thanhphuc', CAST(N'2024-01-07T23:01:08.830' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (14, N'thanhphuc', CAST(N'2024-01-07T23:41:32.980' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (15, N'thanhphuc', CAST(N'2024-01-07T23:42:25.740' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (16, N'thanhphuc', CAST(N'2024-01-07T23:52:55.280' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (17, N'thanhphuc', CAST(N'2024-01-08T00:45:17.847' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (18, N'thanhphuc', CAST(N'2024-01-08T00:46:05.367' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (19, N'thanhphuc', CAST(N'2024-01-08T03:58:13.660' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (20, N'thanhphuc', CAST(N'2024-01-08T03:59:24.860' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (21, N'thanhphuc', CAST(N'2024-01-08T04:00:16.267' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (22, N'thanhphuc', CAST(N'2024-01-08T04:03:41.583' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (23, N'thanhphuc', CAST(N'2024-01-08T08:11:29.157' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (24, N'thanhphuc', CAST(N'2024-01-08T08:15:12.113' AS DateTime))
INSERT [dbo].[HDBan] ([mahdban], [manhanvien], [ngayban]) VALUES (25, N'thanhphuc', CAST(N'2024-01-08T08:52:34.790' AS DateTime))
SET IDENTITY_INSERT [dbo].[HDBan] OFF
GO
INSERT [dbo].[LoaiHang] ([maloai], [tenloai]) VALUES (N'ml1', N'Máy tính')
INSERT [dbo].[LoaiHang] ([maloai], [tenloai]) VALUES (N'ml2', N'Điện thoại 2')
INSERT [dbo].[LoaiHang] ([maloai], [tenloai]) VALUES (N'ml3', N'Tai nghe')
GO
INSERT [dbo].[NhanVien] ([manhanvien], [tennhanvien], [gioitinh], [diachi], [dienthoai], [ngaysinh]) VALUES (N'nhonviet', N'Trần Nhơn Viết2', N'Nam', N'Thành Phố Huế', N'01313131', CAST(N'2024-01-21T18:47:53.000' AS DateTime))
INSERT [dbo].[NhanVien] ([manhanvien], [tennhanvien], [gioitinh], [diachi], [dienthoai], [ngaysinh]) VALUES (N'thanhphuc', N'Trần Lê Thanh Phúc', N'Nữ', N'Huế', N'3810831', CAST(N'2024-01-09T18:44:35.000' AS DateTime))
INSERT [dbo].[NhanVien] ([manhanvien], [tennhanvien], [gioitinh], [diachi], [dienthoai], [ngaysinh]) VALUES (N'yyyy', N'Trần Lê Thanh Phúc', N'Nam', N'20t1020078', N'0788505110', CAST(N'2024-01-03T18:58:18.203' AS DateTime))
GO
INSERT [dbo].[SanPham] ([masanpham], [tensanpham], [maloai], [soluong], [dongiaban], [anh]) VALUES (N'20t102', N'Laptopp22', N'ml3', 36, 3000000, N'C:\Users\ADMIN\Pictures\Saved Pictures\1685914.jpg')
INSERT [dbo].[SanPham] ([masanpham], [tensanpham], [maloai], [soluong], [dongiaban], [anh]) VALUES (N'sp1', N'LapTop Dell', N'ml1', 48, 30000000, N'C:\Users\ADMIN\Desktop\Flutter\image\asus1.1.png')
INSERT [dbo].[SanPham] ([masanpham], [tensanpham], [maloai], [soluong], [dongiaban], [anh]) VALUES (N'sp2', N'LapTop Hp ', N'ml1', 30, 12300000, N'C:\Users\ADMIN\Desktop\Flutter\image\hp1.png')
INSERT [dbo].[SanPham] ([masanpham], [tensanpham], [maloai], [soluong], [dongiaban], [anh]) VALUES (N'sp3', N'Laptop Asus', N'ml1', 47, 14300000, N'C:\Users\ADMIN\Desktop\Flutter\image\asus1.png')
INSERT [dbo].[SanPham] ([masanpham], [tensanpham], [maloai], [soluong], [dongiaban], [anh]) VALUES (N'sp4', N'LapTop MSI', N'ml1', 50, 12000000, N'C:\Users\ADMIN\Desktop\Flutter\image\msi1.png')
GO
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'Admin', N'admin', N'0')
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'nhonviet', N'123', N'1')
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'Phuoc thi', N'123', N'1')
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'thanhphuc', N'123', N'1')
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'viet123', N'123', N'1')
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'yyyy', N'123', N'1')
INSERT [dbo].[User] ([username], [password], [phanquyen]) VALUES (N'yyyyy', N'123', N'1')
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HDBan1] FOREIGN KEY([mahdban])
REFERENCES [dbo].[HDBan] ([mahdban])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HDBan1]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_SanPham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[SanPham] ([masanpham])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_SanPham]
GO
ALTER TABLE [dbo].[HDBan]  WITH CHECK ADD  CONSTRAINT [FK_HDBan_NhanVien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[NhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[HDBan] CHECK CONSTRAINT [FK_HDBan_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_User] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[User] ([username])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_User]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiHang] FOREIGN KEY([maloai])
REFERENCES [dbo].[LoaiHang] ([maloai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiHang]
GO
