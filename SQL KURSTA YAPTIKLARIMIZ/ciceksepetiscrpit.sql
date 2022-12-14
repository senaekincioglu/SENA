USE [CicekSepeti]
GO
/****** Object:  Table [dbo].[TBL_Fiyat]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Fiyat](
	[FiyatId] [int] IDENTITY(1,1) NOT NULL,
	[Kdv] [decimal](18, 2) NOT NULL,
	[Kar_Orani] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Fiyat] PRIMARY KEY CLUSTERED 
(
	[FiyatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Kategori]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Kategori](
	[Kategori_Id] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAd] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TBL_Kategori] PRIMARY KEY CLUSTERED 
(
	[Kategori_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Marka]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Marka](
	[Marka_Id] [int] IDENTITY(1,1) NOT NULL,
	[Marka_Adi] [nvarchar](50) NOT NULL,
	[Aciklama] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Marka] PRIMARY KEY CLUSTERED 
(
	[Marka_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Musteri]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Musteri](
	[Musteri_Id] [int] IDENTITY(1,1) NOT NULL,
	[Musteri_Ad] [nchar](30) NOT NULL,
	[Musteri_Soyad] [nchar](30) NOT NULL,
	[MusteriAdres] [varchar](50) NOT NULL,
	[MusteriTelNo] [char](11) NOT NULL,
 CONSTRAINT [PK_TBL_Musteri] PRIMARY KEY CLUSTERED 
(
	[Musteri_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Siparis]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Siparis](
	[SiparisId] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [nchar](10) NULL,
 CONSTRAINT [PK_TBL_SiparisId] PRIMARY KEY CLUSTERED 
(
	[SiparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Stok]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Stok](
	[StokId] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [varchar](50) NOT NULL,
	[Adet] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Stok] PRIMARY KEY CLUSTERED 
(
	[StokId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Urun]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Urun](
	[FiyatId] [int] NOT NULL,
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[Urun_Id] [varchar](50) NOT NULL,
	[Ad] [nchar](10) NOT NULL,
	[Kategori_Id] [int] NOT NULL,
	[Marka_Id] [int] NOT NULL,
	[Siparis_Id] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Urun] PRIMARY KEY CLUSTERED 
(
	[Urun_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Yorum]    Script Date: 18.10.2022 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Yorum](
	[YorumId] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [varchar](50) NOT NULL,
	[Yorum] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TBL_Yorum] PRIMARY KEY CLUSTERED 
(
	[YorumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Fiyat] ON 

INSERT [dbo].[TBL_Fiyat] ([FiyatId], [Kdv], [Kar_Orani]) VALUES (1, CAST(1.00 AS Decimal(18, 2)), 50)
INSERT [dbo].[TBL_Fiyat] ([FiyatId], [Kdv], [Kar_Orani]) VALUES (2, CAST(8.00 AS Decimal(18, 2)), 20)
INSERT [dbo].[TBL_Fiyat] ([FiyatId], [Kdv], [Kar_Orani]) VALUES (3, CAST(15.00 AS Decimal(18, 2)), 12)
INSERT [dbo].[TBL_Fiyat] ([FiyatId], [Kdv], [Kar_Orani]) VALUES (4, CAST(18.00 AS Decimal(18, 2)), 20)
SET IDENTITY_INSERT [dbo].[TBL_Fiyat] OFF
SET IDENTITY_INSERT [dbo].[TBL_Kategori] ON 

INSERT [dbo].[TBL_Kategori] ([Kategori_Id], [KategoriAd]) VALUES (1, N'Çicek')
INSERT [dbo].[TBL_Kategori] ([Kategori_Id], [KategoriAd]) VALUES (2, N'Oyuncak')
INSERT [dbo].[TBL_Kategori] ([Kategori_Id], [KategoriAd]) VALUES (3, N'Teknoloji')
INSERT [dbo].[TBL_Kategori] ([Kategori_Id], [KategoriAd]) VALUES (4, N'Temizlik')
INSERT [dbo].[TBL_Kategori] ([Kategori_Id], [KategoriAd]) VALUES (5, N'Sağlık')
INSERT [dbo].[TBL_Kategori] ([Kategori_Id], [KategoriAd]) VALUES (6, N'Gıda')
SET IDENTITY_INSERT [dbo].[TBL_Kategori] OFF
SET IDENTITY_INSERT [dbo].[TBL_Marka] ON 

INSERT [dbo].[TBL_Marka] ([Marka_Id], [Marka_Adi], [Aciklama]) VALUES (1, N'Mavi', N'Kıyafet')
INSERT [dbo].[TBL_Marka] ([Marka_Id], [Marka_Adi], [Aciklama]) VALUES (2, N'Ülker', N'Gıda')
INSERT [dbo].[TBL_Marka] ([Marka_Id], [Marka_Adi], [Aciklama]) VALUES (3, N'Eti', N'Gıda')
INSERT [dbo].[TBL_Marka] ([Marka_Id], [Marka_Adi], [Aciklama]) VALUES (4, N'Faber Castel', N'Kırtasiye')
SET IDENTITY_INSERT [dbo].[TBL_Marka] OFF
SET IDENTITY_INSERT [dbo].[TBL_Musteri] ON 

INSERT [dbo].[TBL_Musteri] ([Musteri_Id], [Musteri_Ad], [Musteri_Soyad], [MusteriAdres], [MusteriTelNo]) VALUES (1, N'sena                          ', N'ekincioğlu                    ', N'ümraniye', N'5541139826 ')
INSERT [dbo].[TBL_Musteri] ([Musteri_Id], [Musteri_Ad], [Musteri_Soyad], [MusteriAdres], [MusteriTelNo]) VALUES (2, N'mısra                         ', N'yılmaz                        ', N'Kurtköy', N'5412369874 ')
INSERT [dbo].[TBL_Musteri] ([Musteri_Id], [Musteri_Ad], [Musteri_Soyad], [MusteriAdres], [MusteriTelNo]) VALUES (3, N'Büşra                         ', N'Söyünmez                      ', N'Ortaköy', N'5364127896 ')
INSERT [dbo].[TBL_Musteri] ([Musteri_Id], [Musteri_Ad], [Musteri_Soyad], [MusteriAdres], [MusteriTelNo]) VALUES (4, N'Neval                         ', N'Türkdönmez                    ', N'ümraniye', N'5421476325 ')
SET IDENTITY_INSERT [dbo].[TBL_Musteri] OFF
SET IDENTITY_INSERT [dbo].[TBL_Siparis] ON 

INSERT [dbo].[TBL_Siparis] ([SiparisId], [UrunId]) VALUES (1, N'1         ')
INSERT [dbo].[TBL_Siparis] ([SiparisId], [UrunId]) VALUES (2, N'2         ')
INSERT [dbo].[TBL_Siparis] ([SiparisId], [UrunId]) VALUES (3, N'3         ')
INSERT [dbo].[TBL_Siparis] ([SiparisId], [UrunId]) VALUES (4, N'1         ')
SET IDENTITY_INSERT [dbo].[TBL_Siparis] OFF
SET IDENTITY_INSERT [dbo].[TBL_Stok] ON 

INSERT [dbo].[TBL_Stok] ([StokId], [UrunId], [Adet]) VALUES (4, N'1', 2)
INSERT [dbo].[TBL_Stok] ([StokId], [UrunId], [Adet]) VALUES (5, N'1', 3)
INSERT [dbo].[TBL_Stok] ([StokId], [UrunId], [Adet]) VALUES (7, N'1', 3)
SET IDENTITY_INSERT [dbo].[TBL_Stok] OFF
SET IDENTITY_INSERT [dbo].[TBL_Urun] ON 

INSERT [dbo].[TBL_Urun] ([FiyatId], [MusteriId], [Urun_Id], [Ad], [Kategori_Id], [Marka_Id], [Siparis_Id]) VALUES (1, 1, N'1', N'Lavanta   ', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[TBL_Urun] OFF
SET IDENTITY_INSERT [dbo].[TBL_Yorum] ON 

INSERT [dbo].[TBL_Yorum] ([YorumId], [UrunId], [Yorum]) VALUES (3, N'1', N'urun')
INSERT [dbo].[TBL_Yorum] ([YorumId], [UrunId], [Yorum]) VALUES (8, N'1', N'urun')
SET IDENTITY_INSERT [dbo].[TBL_Yorum] OFF
ALTER TABLE [dbo].[TBL_Stok]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Stok_TBL_Urun] FOREIGN KEY([UrunId])
REFERENCES [dbo].[TBL_Urun] ([Urun_Id])
GO
ALTER TABLE [dbo].[TBL_Stok] CHECK CONSTRAINT [FK_TBL_Stok_TBL_Urun]
GO
ALTER TABLE [dbo].[TBL_Urun]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Urun_TBL_Fiyat] FOREIGN KEY([FiyatId])
REFERENCES [dbo].[TBL_Fiyat] ([FiyatId])
GO
ALTER TABLE [dbo].[TBL_Urun] CHECK CONSTRAINT [FK_TBL_Urun_TBL_Fiyat]
GO
ALTER TABLE [dbo].[TBL_Urun]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Urun_TBL_Kategori] FOREIGN KEY([Kategori_Id])
REFERENCES [dbo].[TBL_Kategori] ([Kategori_Id])
GO
ALTER TABLE [dbo].[TBL_Urun] CHECK CONSTRAINT [FK_TBL_Urun_TBL_Kategori]
GO
ALTER TABLE [dbo].[TBL_Urun]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Urun_TBL_Marka] FOREIGN KEY([Marka_Id])
REFERENCES [dbo].[TBL_Marka] ([Marka_Id])
GO
ALTER TABLE [dbo].[TBL_Urun] CHECK CONSTRAINT [FK_TBL_Urun_TBL_Marka]
GO
ALTER TABLE [dbo].[TBL_Urun]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Urun_TBL_Musteri] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[TBL_Musteri] ([Musteri_Id])
GO
ALTER TABLE [dbo].[TBL_Urun] CHECK CONSTRAINT [FK_TBL_Urun_TBL_Musteri]
GO
ALTER TABLE [dbo].[TBL_Urun]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Urun_TBL_Siparis] FOREIGN KEY([Siparis_Id])
REFERENCES [dbo].[TBL_Siparis] ([SiparisId])
GO
ALTER TABLE [dbo].[TBL_Urun] CHECK CONSTRAINT [FK_TBL_Urun_TBL_Siparis]
GO
ALTER TABLE [dbo].[TBL_Yorum]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Yorum_TBL_Urun] FOREIGN KEY([UrunId])
REFERENCES [dbo].[TBL_Urun] ([Urun_Id])
GO
ALTER TABLE [dbo].[TBL_Yorum] CHECK CONSTRAINT [FK_TBL_Yorum_TBL_Urun]
GO
