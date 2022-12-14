USE [Okull]
GO
/****** Object:  Table [dbo].[TBL_Bolum]    Script Date: 13.10.2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Bolum](
	[bid] [int] IDENTITY(1,1) NOT NULL,
	[badi] [varchar](30) NOT NULL,
	[aciklama] [varchar](50) NOT NULL,
	[eposta] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TBL_Bolum_1] PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Ders]    Script Date: 13.10.2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Ders](
	[did] [int] IDENTITY(1,1) NOT NULL,
	[dadi] [varchar](30) NOT NULL,
	[dkodu] [varchar](30) NOT NULL,
	[kredi] [int] NOT NULL,
	[bid] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Ders] PRIMARY KEY CLUSTERED 
(
	[did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Ogrenci]    Script Date: 13.10.2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Ogrenci](
	[ono] [int] IDENTITY(1,1) NOT NULL,
	[adi] [varchar](30) NOT NULL,
	[soyadi] [varchar](30) NOT NULL,
	[dyeri] [varchar](30) NOT NULL,
	[bid] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[ono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_OgrenciDers]    Script Date: 13.10.2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_OgrenciDers](
	[ono] [int] NOT NULL,
	[did] [int] NOT NULL,
	[not] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Ogretmen]    Script Date: 13.10.2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Ogretmen](
	[oid] [int] IDENTITY(1,1) NOT NULL,
	[adi] [varchar](30) NOT NULL,
	[soyadi] [varchar](30) NOT NULL,
	[dyeri] [varchar](50) NOT NULL,
	[bid] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Ogretmen] PRIMARY KEY CLUSTERED 
(
	[oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_OgretmenDers]    Script Date: 13.10.2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_OgretmenDers](
	[oid] [int] IDENTITY(1,1) NOT NULL,
	[did] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Bolum] ON 

INSERT [dbo].[TBL_Bolum] ([bid], [badi], [aciklama], [eposta]) VALUES (1, N'Bil.Muh', N'Bilgisayar Mühendisliği Bölümü', N'ceng@fatih.edu.tr')
INSERT [dbo].[TBL_Bolum] ([bid], [badi], [aciklama], [eposta]) VALUES (4, N'Elo.Muh', N'Elektronik Mühendisliği Bölümü', N'ee@fatih.edu.tr')
INSERT [dbo].[TBL_Bolum] ([bid], [badi], [aciklama], [eposta]) VALUES (5, N'Çev.Muh', N'Çevre Mühendisliği ', N'env@fatih.edu.tr')
INSERT [dbo].[TBL_Bolum] ([bid], [badi], [aciklama], [eposta]) VALUES (7, N'End.Muh', N'Endüstri Mühendisliği', N'ie@fatih.edu.tr')
INSERT [dbo].[TBL_Bolum] ([bid], [badi], [aciklama], [eposta]) VALUES (8, N'wtk', N'Web Tasarımı Ve Kodlama', N'se@fatih.edu.tr')
INSERT [dbo].[TBL_Bolum] ([bid], [badi], [aciklama], [eposta]) VALUES (9, N'jkuh', N'hjh', N'hyjh')
SET IDENTITY_INSERT [dbo].[TBL_Bolum] OFF
SET IDENTITY_INSERT [dbo].[TBL_Ders] ON 

INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (1, N'Veri Tabanı', N'CENG351', 3, 1)
INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (4, N'İşletim Sistemleri', N'CENG341', 3, 1)
INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (7, N'Programlamaya Giriş', N'CENG101', 4, 1)
INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (8, N'Elektroniğe Giriş ', N'EE101', 2, 2)
INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (11, N'İstatistik', N'İs202', 3, 2)
INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (12, N'Çevre Bilgisi', N'Çb405', 2, 3)
INSERT [dbo].[TBL_Ders] ([did], [dadi], [dkodu], [kredi], [bid]) VALUES (13, N'ngn', N'ghg', 3, 2)
SET IDENTITY_INSERT [dbo].[TBL_Ders] OFF
SET IDENTITY_INSERT [dbo].[TBL_Ogrenci] ON 

INSERT [dbo].[TBL_Ogrenci] ([ono], [adi], [soyadi], [dyeri], [bid]) VALUES (1, N'Sena', N'Ekincioğlu', N'İstanbul', 1)
INSERT [dbo].[TBL_Ogrenci] ([ono], [adi], [soyadi], [dyeri], [bid]) VALUES (3, N'Beyza', N'Ekincioğlu', N'İstanbul', 1)
INSERT [dbo].[TBL_Ogrenci] ([ono], [adi], [soyadi], [dyeri], [bid]) VALUES (5, N'Öznur', N'Yeşilyurt', N'Gümüşhane', 1)
INSERT [dbo].[TBL_Ogrenci] ([ono], [adi], [soyadi], [dyeri], [bid]) VALUES (6, N'Can', N'Türkoğlu', N'Manisa', 2)
INSERT [dbo].[TBL_Ogrenci] ([ono], [adi], [soyadi], [dyeri], [bid]) VALUES (7, N'Talat', N'Şanlı', N'İzmir', 3)
INSERT [dbo].[TBL_Ogrenci] ([ono], [adi], [soyadi], [dyeri], [bid]) VALUES (8, N'Turgut', N'Cemal', N'Bursa', 4)
SET IDENTITY_INSERT [dbo].[TBL_Ogrenci] OFF
INSERT [dbo].[TBL_OgrenciDers] ([ono], [did], [not]) VALUES (3, 1, 3)
INSERT [dbo].[TBL_OgrenciDers] ([ono], [did], [not]) VALUES (7, 1, 3)
SET IDENTITY_INSERT [dbo].[TBL_Ogretmen] ON 

INSERT [dbo].[TBL_Ogretmen] ([oid], [adi], [soyadi], [dyeri], [bid]) VALUES (1, N'esma', N'akar', N'istanbul', 1)
INSERT [dbo].[TBL_Ogretmen] ([oid], [adi], [soyadi], [dyeri], [bid]) VALUES (2, N'şeyma', N'kaya', N'balıkesir', 2)
INSERT [dbo].[TBL_Ogretmen] ([oid], [adi], [soyadi], [dyeri], [bid]) VALUES (3, N'ezgi ', N'keçici', N'erzincan', 3)
SET IDENTITY_INSERT [dbo].[TBL_Ogretmen] OFF
SET IDENTITY_INSERT [dbo].[TBL_OgretmenDers] ON 

INSERT [dbo].[TBL_OgretmenDers] ([oid], [did]) VALUES (1, 1)
INSERT [dbo].[TBL_OgretmenDers] ([oid], [did]) VALUES (2, 2)
INSERT [dbo].[TBL_OgretmenDers] ([oid], [did]) VALUES (3, 3)
INSERT [dbo].[TBL_OgretmenDers] ([oid], [did]) VALUES (4, 4)
INSERT [dbo].[TBL_OgretmenDers] ([oid], [did]) VALUES (5, 5)
SET IDENTITY_INSERT [dbo].[TBL_OgretmenDers] OFF
