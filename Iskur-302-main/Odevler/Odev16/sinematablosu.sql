USE [Sinema Bileti]
GO
/****** Object:  Table [dbo].[TBL_Bilet]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Bilet](
	[Bilet_Id] [int] IDENTITY(1,1) NOT NULL,
	[BiletAdı] [varchar](30) NOT NULL,
	[FilmId] [int] NOT NULL,
	[KoltukId] [int] NOT NULL,
	[SalonId] [int] NOT NULL,
	[seansId] [int] NOT NULL,
	[MusteriId] [int] NOT NULL,
	[PersonelId] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Bilet] PRIMARY KEY CLUSTERED 
(
	[Bilet_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Filmler]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Filmler](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [varchar](30) NOT NULL,
	[FilmTuruId] [int] NOT NULL,
	[FilmYonetmen] [varchar](50) NOT NULL,
	[FilmOyuncularıId] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Filmler] PRIMARY KEY CLUSTERED 
(
	[FilmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_FilmOyunculari]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_FilmOyunculari](
	[FilmOyuncuId] [int] IDENTITY(1,1) NOT NULL,
	[FilmOyuncuAdi] [varchar](30) NOT NULL,
	[FilmOyuncuSoyadi] [varchar](40) NOT NULL,
	[FilmOyuncuTelefon] [char](11) NOT NULL,
	[FilmOyuncuMail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_FilmOyunculari] PRIMARY KEY CLUSTERED 
(
	[FilmOyuncuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_FilmSeanslari]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_FilmSeanslari](
	[FilmId] [int] NOT NULL,
	[SeansId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_FilmTur]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_FilmTur](
	[FilmTurId] [int] IDENTITY(1,1) NOT NULL,
	[turu] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_FilmTur] PRIMARY KEY CLUSTERED 
(
	[FilmTurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Koltuk]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Koltuk](
	[KoltukId] [int] IDENTITY(1,1) NOT NULL,
	[SalonId] [int] NOT NULL,
	[KoltukHarf] [varchar](2) NOT NULL,
	[KoltukRakam] [tinyint] NOT NULL,
 CONSTRAINT [PK_TBL_Koltuk] PRIMARY KEY CLUSTERED 
(
	[KoltukId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Musteri]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Musteri](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [varchar](30) NOT NULL,
	[MusteriSoyadi] [varchar](40) NOT NULL,
	[MusteriTelefon] [char](11) NOT NULL,
	[MusteriKullaniciAdi] [varchar](40) NOT NULL,
	[MusteriSifre] [varchar](50) NOT NULL,
	[MusteriTipi] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Musteri] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_MusteriTipi]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_MusteriTipi](
	[MusteriTipiId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriTipi] [varchar](40) NOT NULL,
 CONSTRAINT [PK_TBL_MusteriTipi] PRIMARY KEY CLUSTERED 
(
	[MusteriTipiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Personel]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Personel](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAd] [varchar](30) NOT NULL,
	[PersonelSoyad] [varchar](40) NOT NULL,
	[PersonelTel] [char](11) NOT NULL,
	[PersonelMail] [varchar](50) NOT NULL,
	[PersonelSifre] [varchar](30) NOT NULL,
	[PersonelDoğumTarihi] [date] NOT NULL,
 CONSTRAINT [PK_TBL_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Salon]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Salon](
	[Salon_Id] [int] IDENTITY(1,1) NOT NULL,
	[Salon_Adi] [varchar](30) NOT NULL,
	[FilmId] [int] NOT NULL,
	[kapasite] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Salon] PRIMARY KEY CLUSTERED 
(
	[Salon_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SalonSeans]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SalonSeans](
	[SalonId] [int] NOT NULL,
	[seansId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Seanslar]    Script Date: 17.10.2022 23:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Seanslar](
	[SeansId] [int] IDENTITY(1,1) NOT NULL,
	[SeansZamani] [datetime] NOT NULL,
 CONSTRAINT [PK_TBL_Seanslar] PRIMARY KEY CLUSTERED 
(
	[SeansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Bilet] ON 

INSERT [dbo].[TBL_Bilet] ([Bilet_Id], [BiletAdı], [FilmId], [KoltukId], [SalonId], [seansId], [MusteriId], [PersonelId]) VALUES (4, N'Sinemax', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[TBL_Bilet] ([Bilet_Id], [BiletAdı], [FilmId], [KoltukId], [SalonId], [seansId], [MusteriId], [PersonelId]) VALUES (7, N'Biletix', 1, 2, 2, 2, 1, 2)
INSERT [dbo].[TBL_Bilet] ([Bilet_Id], [BiletAdı], [FilmId], [KoltukId], [SalonId], [seansId], [MusteriId], [PersonelId]) VALUES (12, N'Oscar', 1, 2, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[TBL_Bilet] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Filmler] ON 

INSERT [dbo].[TBL_Filmler] ([FilmId], [FilmAdi], [FilmTuruId], [FilmYonetmen], [FilmOyuncularıId]) VALUES (1, N'Katliam günü', 12, N'NickJongerius', 2)
INSERT [dbo].[TBL_Filmler] ([FilmId], [FilmAdi], [FilmTuruId], [FilmYonetmen], [FilmOyuncularıId]) VALUES (4, N'Katliam günü', 12, N'Nick Jongerius', 3)
INSERT [dbo].[TBL_Filmler] ([FilmId], [FilmAdi], [FilmTuruId], [FilmYonetmen], [FilmOyuncularıId]) VALUES (5, N'Katliam günü', 12, N'Nick Jongerius', 4)
SET IDENTITY_INSERT [dbo].[TBL_Filmler] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_FilmOyunculari] ON 

INSERT [dbo].[TBL_FilmOyunculari] ([FilmOyuncuId], [FilmOyuncuAdi], [FilmOyuncuSoyadi], [FilmOyuncuTelefon], [FilmOyuncuMail]) VALUES (2, N'ben', N'batt', N'5515547553 ', N'benbatt@gmail.com')
INSERT [dbo].[TBL_FilmOyunculari] ([FilmOyuncuId], [FilmOyuncuAdi], [FilmOyuncuSoyadi], [FilmOyuncuTelefon], [FilmOyuncuMail]) VALUES (3, N'Charlotte ', N'Beaumont', N'5422156987 ', N'charlette@gmail.com')
INSERT [dbo].[TBL_FilmOyunculari] ([FilmOyuncuId], [FilmOyuncuAdi], [FilmOyuncuSoyadi], [FilmOyuncuTelefon], [FilmOyuncuMail]) VALUES (4, N'Fiona ', N'Hampton', N'5422912763 ', N'fionahampton@gmail.com')
INSERT [dbo].[TBL_FilmOyunculari] ([FilmOyuncuId], [FilmOyuncuAdi], [FilmOyuncuSoyadi], [FilmOyuncuTelefon], [FilmOyuncuMail]) VALUES (6, N'Patrick', N'Baladi', N'5067160480 ', N'baladi@gmail.com')
SET IDENTITY_INSERT [dbo].[TBL_FilmOyunculari] OFF
GO
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 1)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 2)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 3)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 4)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 5)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 6)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 7)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 8)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 9)
INSERT [dbo].[TBL_FilmSeanslari] ([FilmId], [SeansId]) VALUES (1, 10)
GO
SET IDENTITY_INSERT [dbo].[TBL_FilmTur] ON 

INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (1, N'Aile ')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (2, N'Aksiyon')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (3, N'Animasyon')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (4, N'Belgesel')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (5, N'Bilim-Kurgu')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (6, N'Çizgiflim')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (7, N'Dram')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (8, N'Fantastik')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (9, N'Gerilim')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (10, N'Gizem')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (11, N'Komedi')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (12, N'Korku')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (13, N'Macera')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (14, N'Müzikal')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (15, N'Polisiye')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (16, N'Psikolojik')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (17, N'Romantik')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (18, N'Savaş')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (19, N'Suç')
INSERT [dbo].[TBL_FilmTur] ([FilmTurId], [turu]) VALUES (20, N'Tarih')
SET IDENTITY_INSERT [dbo].[TBL_FilmTur] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Koltuk] ON 

INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (1, 1, N'a', 1)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (2, 1, N'b', 2)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (4, 1, N'c', 3)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (5, 2, N'a', 1)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (6, 2, N'b', 2)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (7, 2, N'c', 3)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (8, 3, N'a', 1)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (9, 3, N'b', 2)
INSERT [dbo].[TBL_Koltuk] ([KoltukId], [SalonId], [KoltukHarf], [KoltukRakam]) VALUES (10, 3, N'b', 3)
SET IDENTITY_INSERT [dbo].[TBL_Koltuk] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Musteri] ON 

INSERT [dbo].[TBL_Musteri] ([MusteriId], [MusteriAdi], [MusteriSoyadi], [MusteriTelefon], [MusteriKullaniciAdi], [MusteriSifre], [MusteriTipi]) VALUES (1, N'Mehmet Rafii', N'Akkuş', N'5418963256 ', N'mehmetrafii', N'123', 3)
INSERT [dbo].[TBL_Musteri] ([MusteriId], [MusteriAdi], [MusteriSoyadi], [MusteriTelefon], [MusteriKullaniciAdi], [MusteriSifre], [MusteriTipi]) VALUES (3, N'Mısra', N'Yılmaz', N'5421589632 ', N'misrayilmaz', N'458', 2)
INSERT [dbo].[TBL_Musteri] ([MusteriId], [MusteriAdi], [MusteriSoyadi], [MusteriTelefon], [MusteriKullaniciAdi], [MusteriSifre], [MusteriTipi]) VALUES (4, N'Büşra', N'Söyünmez', N'4785156987 ', N'büşrasöyünmez', N'4789', 1)
INSERT [dbo].[TBL_Musteri] ([MusteriId], [MusteriAdi], [MusteriSoyadi], [MusteriTelefon], [MusteriKullaniciAdi], [MusteriSifre], [MusteriTipi]) VALUES (5, N'Erhan', N'Topçu', N'5412369845 ', N'ErhanTopcu', N'423', 1)
SET IDENTITY_INSERT [dbo].[TBL_Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_MusteriTipi] ON 

INSERT [dbo].[TBL_MusteriTipi] ([MusteriTipiId], [MusteriTipi]) VALUES (1, N'Öğrenci')
INSERT [dbo].[TBL_MusteriTipi] ([MusteriTipiId], [MusteriTipi]) VALUES (2, N'Tam')
INSERT [dbo].[TBL_MusteriTipi] ([MusteriTipiId], [MusteriTipi]) VALUES (3, N'Personel')
SET IDENTITY_INSERT [dbo].[TBL_MusteriTipi] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Personel] ON 

INSERT [dbo].[TBL_Personel] ([PersonelId], [PersonelAd], [PersonelSoyad], [PersonelTel], [PersonelMail], [PersonelSifre], [PersonelDoğumTarihi]) VALUES (1, N'sena', N'ekincioğlu', N'5541139826 ', N'senaekncc@gmail.com', N'ekincioglusena1', CAST(N'2000-04-01' AS Date))
INSERT [dbo].[TBL_Personel] ([PersonelId], [PersonelAd], [PersonelSoyad], [PersonelTel], [PersonelMail], [PersonelSifre], [PersonelDoğumTarihi]) VALUES (2, N'devrim', N'pattabanoğlu', N'5541236987 ', N'devrim@gmail.com', N'devrim1223', CAST(N'1993-08-20' AS Date))
INSERT [dbo].[TBL_Personel] ([PersonelId], [PersonelAd], [PersonelSoyad], [PersonelTel], [PersonelMail], [PersonelSifre], [PersonelDoğumTarihi]) VALUES (4, N'mert', N'kutlu', N'5369874563 ', N'mertkutlu@gmail.com', N'mert4545', CAST(N'1995-06-01' AS Date))
SET IDENTITY_INSERT [dbo].[TBL_Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Salon] ON 

INSERT [dbo].[TBL_Salon] ([Salon_Id], [Salon_Adi], [FilmId], [kapasite]) VALUES (1, N'1.Salon', 1, 100)
INSERT [dbo].[TBL_Salon] ([Salon_Id], [Salon_Adi], [FilmId], [kapasite]) VALUES (2, N'2.Salon', 1, 100)
INSERT [dbo].[TBL_Salon] ([Salon_Id], [Salon_Adi], [FilmId], [kapasite]) VALUES (3, N'3.Salon', 1, 50)
SET IDENTITY_INSERT [dbo].[TBL_Salon] OFF
GO
INSERT [dbo].[TBL_SalonSeans] ([SalonId], [seansId]) VALUES (1, 1)
INSERT [dbo].[TBL_SalonSeans] ([SalonId], [seansId]) VALUES (2, 1)
INSERT [dbo].[TBL_SalonSeans] ([SalonId], [seansId]) VALUES (3, 2)
INSERT [dbo].[TBL_SalonSeans] ([SalonId], [seansId]) VALUES (3, 1)
GO
SET IDENTITY_INSERT [dbo].[TBL_Seanslar] ON 

INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (1, CAST(N'2022-12-17T08:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (2, CAST(N'2022-10-17T10:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (3, CAST(N'2022-10-17T12:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (4, CAST(N'2022-09-13T14:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (5, CAST(N'2022-10-17T16:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (6, CAST(N'2022-10-17T18:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (7, CAST(N'2022-10-17T20:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (8, CAST(N'2022-11-17T22:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (9, CAST(N'2022-10-12T13:00:00.000' AS DateTime))
INSERT [dbo].[TBL_Seanslar] ([SeansId], [SeansZamani]) VALUES (10, CAST(N'2022-05-06T02:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TBL_Seanslar] OFF
GO
ALTER TABLE [dbo].[TBL_Bilet]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Bilet_TBL_Filmler] FOREIGN KEY([FilmId])
REFERENCES [dbo].[TBL_Filmler] ([FilmId])
GO
ALTER TABLE [dbo].[TBL_Bilet] CHECK CONSTRAINT [FK_TBL_Bilet_TBL_Filmler]
GO
ALTER TABLE [dbo].[TBL_Bilet]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Bilet_TBL_Koltuk] FOREIGN KEY([KoltukId])
REFERENCES [dbo].[TBL_Koltuk] ([KoltukId])
GO
ALTER TABLE [dbo].[TBL_Bilet] CHECK CONSTRAINT [FK_TBL_Bilet_TBL_Koltuk]
GO
ALTER TABLE [dbo].[TBL_Bilet]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Bilet_TBL_Musteri] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[TBL_Musteri] ([MusteriId])
GO
ALTER TABLE [dbo].[TBL_Bilet] CHECK CONSTRAINT [FK_TBL_Bilet_TBL_Musteri]
GO
ALTER TABLE [dbo].[TBL_Bilet]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Bilet_TBL_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[TBL_Personel] ([PersonelId])
GO
ALTER TABLE [dbo].[TBL_Bilet] CHECK CONSTRAINT [FK_TBL_Bilet_TBL_Personel]
GO
ALTER TABLE [dbo].[TBL_Bilet]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Bilet_TBL_Salon] FOREIGN KEY([SalonId])
REFERENCES [dbo].[TBL_Salon] ([Salon_Id])
GO
ALTER TABLE [dbo].[TBL_Bilet] CHECK CONSTRAINT [FK_TBL_Bilet_TBL_Salon]
GO
ALTER TABLE [dbo].[TBL_Bilet]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Bilet_TBL_Seanslar] FOREIGN KEY([seansId])
REFERENCES [dbo].[TBL_Seanslar] ([SeansId])
GO
ALTER TABLE [dbo].[TBL_Bilet] CHECK CONSTRAINT [FK_TBL_Bilet_TBL_Seanslar]
GO
ALTER TABLE [dbo].[TBL_Filmler]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Filmler_TBL_FilmOyunculari] FOREIGN KEY([FilmOyuncularıId])
REFERENCES [dbo].[TBL_FilmOyunculari] ([FilmOyuncuId])
GO
ALTER TABLE [dbo].[TBL_Filmler] CHECK CONSTRAINT [FK_TBL_Filmler_TBL_FilmOyunculari]
GO
ALTER TABLE [dbo].[TBL_Filmler]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Filmler_TBL_FilmTur] FOREIGN KEY([FilmTuruId])
REFERENCES [dbo].[TBL_FilmTur] ([FilmTurId])
GO
ALTER TABLE [dbo].[TBL_Filmler] CHECK CONSTRAINT [FK_TBL_Filmler_TBL_FilmTur]
GO
ALTER TABLE [dbo].[TBL_FilmSeanslari]  WITH CHECK ADD  CONSTRAINT [FK_TBL_FilmSeanslari_TBL_Filmler] FOREIGN KEY([FilmId])
REFERENCES [dbo].[TBL_Filmler] ([FilmId])
GO
ALTER TABLE [dbo].[TBL_FilmSeanslari] CHECK CONSTRAINT [FK_TBL_FilmSeanslari_TBL_Filmler]
GO
ALTER TABLE [dbo].[TBL_FilmSeanslari]  WITH CHECK ADD  CONSTRAINT [FK_TBL_FilmSeanslari_TBL_Seanslar] FOREIGN KEY([SeansId])
REFERENCES [dbo].[TBL_Seanslar] ([SeansId])
GO
ALTER TABLE [dbo].[TBL_FilmSeanslari] CHECK CONSTRAINT [FK_TBL_FilmSeanslari_TBL_Seanslar]
GO
ALTER TABLE [dbo].[TBL_Musteri]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Musteri_TBL_MusteriTipi] FOREIGN KEY([MusteriTipi])
REFERENCES [dbo].[TBL_MusteriTipi] ([MusteriTipiId])
GO
ALTER TABLE [dbo].[TBL_Musteri] CHECK CONSTRAINT [FK_TBL_Musteri_TBL_MusteriTipi]
GO
ALTER TABLE [dbo].[TBL_SalonSeans]  WITH CHECK ADD  CONSTRAINT [FK_TBL_SalonSeans_TBL_Salon] FOREIGN KEY([SalonId])
REFERENCES [dbo].[TBL_Salon] ([Salon_Id])
GO
ALTER TABLE [dbo].[TBL_SalonSeans] CHECK CONSTRAINT [FK_TBL_SalonSeans_TBL_Salon]
GO
