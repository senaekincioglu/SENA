USE [Kütüphane]
GO
/****** Object:  Table [dbo].[TBL_Adresler]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Adresler](
	[Uye_Id] [int] NOT NULL,
	[Adres_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ülke] [nvarchar](50) NOT NULL,
	[Şehir] [nvarchar](50) NOT NULL,
	[Cadde] [nvarchar](50) NOT NULL,
	[Mahalle] [nvarchar](50) NOT NULL,
	[Bina_Kodu] [char](4) NOT NULL,
	[Posta_Kodu] [nchar](5) NULL,
 CONSTRAINT [PK_TBL_Adresler] PRIMARY KEY CLUSTERED 
(
	[Adres_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Emanet]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Emanet](
	[Emanet_Id] [int] IDENTITY(1,1) NOT NULL,
	[Emanet_Tarihi] [int] NOT NULL,
	[Teslim_Tarihi] [int] NOT NULL,
	[Emanet_Ogrenci] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Emanet] PRIMARY KEY CLUSTERED 
(
	[Emanet_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Islem]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Islem](
	[Emanet_Id] [int] NULL,
	[Uye_Id] [int] NOT NULL,
	[Personel_Id] [int] NOT NULL,
	[Islem_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenci_No] [nchar](10) NOT NULL,
	[Kitap_No] [nchar](10) NOT NULL,
	[Alinan_Tarih] [int] NOT NULL,
	[Verilen_Tarih] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Islem] PRIMARY KEY CLUSTERED 
(
	[Islem_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Kitaplar]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Kitaplar](
	[Yazar_Id] [int] NULL,
	[Kitap_Id] [int] IDENTITY(1,1) NOT NULL,
	[Kitap_Adi] [nvarchar](50) NOT NULL,
	[Yayin_Tarihi] [int] NOT NULL,
	[Sayfa_Sayisi] [nchar](10) NULL,
 CONSTRAINT [PK_TBL_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[Kitap_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Personel]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Personel](
	[Personel_Id] [int] IDENTITY(1,1) NOT NULL,
	[Personel_Adi] [nchar](20) NOT NULL,
	[Personel_Soyadi] [nchar](20) NOT NULL,
	[Personel_Telefon] [nchar](11) NOT NULL,
	[Personel_Adresi] [nvarchar](50) NULL,
	[Personel_Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Personel] PRIMARY KEY CLUSTERED 
(
	[Personel_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Tur]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Tur](
	[Kitap_Id] [int] NULL,
	[Tür_Id] [int] IDENTITY(1,1) NOT NULL,
	[TürAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Tur] PRIMARY KEY CLUSTERED 
(
	[Tür_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Uyeler]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Uyeler](
	[Emanet_Id] [int] NOT NULL,
	[Uye_Id] [int] IDENTITY(1,1) NOT NULL,
	[Uye_Adi] [nvarchar](50) NOT NULL,
	[Uye_Soyadi] [nvarchar](50) NOT NULL,
	[Uye_TelefonNo] [nchar](11) NOT NULL,
	[Uye_Eposta] [nvarchar](50) NULL,
	[Uye_Cinsiyet] [nchar](5) NULL,
 CONSTRAINT [PK_TBL_Uyeler] PRIMARY KEY CLUSTERED 
(
	[Uye_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Yayınevi]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Yayınevi](
	[Yayınevi_Id] [int] IDENTITY(1,1) NOT NULL,
	[Yayınevi_İsmi] [nvarchar](50) NOT NULL,
	[Yayınevi_Adress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Yayınevi] PRIMARY KEY CLUSTERED 
(
	[Yayınevi_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Yazarlar]    Script Date: 10.10.2022 23:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Yazarlar](
	[Yazar_Id] [int] IDENTITY(1,1) NOT NULL,
	[Yazar_Ad] [nchar](20) NULL,
	[YazarSoyad] [nchar](20) NOT NULL,
 CONSTRAINT [PK_TBL_Yazarlar] PRIMARY KEY CLUSTERED 
(
	[Yazar_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Emanet] ON 

INSERT [dbo].[TBL_Emanet] ([Emanet_Id], [Emanet_Tarihi], [Teslim_Tarihi], [Emanet_Ogrenci]) VALUES (1, 1122022, 12222022, N'202')
INSERT [dbo].[TBL_Emanet] ([Emanet_Id], [Emanet_Tarihi], [Teslim_Tarihi], [Emanet_Ogrenci]) VALUES (2, 1042022, 2042022, N'203')
INSERT [dbo].[TBL_Emanet] ([Emanet_Id], [Emanet_Tarihi], [Teslim_Tarihi], [Emanet_Ogrenci]) VALUES (3, 3062023, 4062023, N'300')
INSERT [dbo].[TBL_Emanet] ([Emanet_Id], [Emanet_Tarihi], [Teslim_Tarihi], [Emanet_Ogrenci]) VALUES (4, 9052023, 10052023, N'245')
SET IDENTITY_INSERT [dbo].[TBL_Emanet] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Islem] ON 

INSERT [dbo].[TBL_Islem] ([Emanet_Id], [Uye_Id], [Personel_Id], [Islem_Id], [Ogrenci_No], [Kitap_No], [Alinan_Tarih], [Verilen_Tarih]) VALUES (1, 2, 4, 7, N'1         ', N'2         ', 2022, 2023)
INSERT [dbo].[TBL_Islem] ([Emanet_Id], [Uye_Id], [Personel_Id], [Islem_Id], [Ogrenci_No], [Kitap_No], [Alinan_Tarih], [Verilen_Tarih]) VALUES (4, 5, 2, 8, N'2         ', N'100       ', 2022, 2022)
SET IDENTITY_INSERT [dbo].[TBL_Islem] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Kitaplar] ON 

INSERT [dbo].[TBL_Kitaplar] ([Yazar_Id], [Kitap_Id], [Kitap_Adi], [Yayin_Tarihi], [Sayfa_Sayisi]) VALUES (NULL, 1, N'Kürt mantolu madonna', 2000, N'105       ')
INSERT [dbo].[TBL_Kitaplar] ([Yazar_Id], [Kitap_Id], [Kitap_Adi], [Yayin_Tarihi], [Sayfa_Sayisi]) VALUES (NULL, 2, N'Kuyucaklı Yusuf', 1985, N'200       ')
INSERT [dbo].[TBL_Kitaplar] ([Yazar_Id], [Kitap_Id], [Kitap_Adi], [Yayin_Tarihi], [Sayfa_Sayisi]) VALUES (NULL, 3, N'Budala', 1900, N'102       ')
INSERT [dbo].[TBL_Kitaplar] ([Yazar_Id], [Kitap_Id], [Kitap_Adi], [Yayin_Tarihi], [Sayfa_Sayisi]) VALUES (NULL, 4, N'Çocukluğum', 1800, N'300       ')
SET IDENTITY_INSERT [dbo].[TBL_Kitaplar] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Personel] ON 

INSERT [dbo].[TBL_Personel] ([Personel_Id], [Personel_Adi], [Personel_Soyadi], [Personel_Telefon], [Personel_Adresi], [Personel_Email]) VALUES (1, N'sena                ', N'ekincioğlu          ', N'5541139826 ', N'inkılapmah.vatancad.no107', N'senaekncc@gmail.com')
INSERT [dbo].[TBL_Personel] ([Personel_Id], [Personel_Adi], [Personel_Soyadi], [Personel_Telefon], [Personel_Adresi], [Personel_Email]) VALUES (2, N'elif                ', N'aynacı              ', N'5422698756 ', N'yunusemremah.', N'elifbetül@gmail.com')
INSERT [dbo].[TBL_Personel] ([Personel_Id], [Personel_Adi], [Personel_Soyadi], [Personel_Telefon], [Personel_Adresi], [Personel_Email]) VALUES (3, N'Öznur               ', N'Yeşilyurt           ', N'5515478965 ', N'İstiklalmah.aynacısok.', N'ekncoznur@gmail.com')
INSERT [dbo].[TBL_Personel] ([Personel_Id], [Personel_Adi], [Personel_Soyadi], [Personel_Telefon], [Personel_Adresi], [Personel_Email]) VALUES (4, N'Şeyma               ', N'Ekincioğlu          ', N'5422912763 ', N'inkılapmah.vatancad.', N'seymaekincioglu@gmail.com')
SET IDENTITY_INSERT [dbo].[TBL_Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Tur] ON 

INSERT [dbo].[TBL_Tur] ([Kitap_Id], [Tür_Id], [TürAdi]) VALUES (NULL, 1, N'Roman')
INSERT [dbo].[TBL_Tur] ([Kitap_Id], [Tür_Id], [TürAdi]) VALUES (NULL, 2, N'Hikaye')
INSERT [dbo].[TBL_Tur] ([Kitap_Id], [Tür_Id], [TürAdi]) VALUES (NULL, 3, N'Anı')
INSERT [dbo].[TBL_Tur] ([Kitap_Id], [Tür_Id], [TürAdi]) VALUES (NULL, 4, N'Gezi')
INSERT [dbo].[TBL_Tur] ([Kitap_Id], [Tür_Id], [TürAdi]) VALUES (NULL, 5, N'Biyografi')
INSERT [dbo].[TBL_Tur] ([Kitap_Id], [Tür_Id], [TürAdi]) VALUES (NULL, 6, N'Şiir')
SET IDENTITY_INSERT [dbo].[TBL_Tur] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Uyeler] ON 

INSERT [dbo].[TBL_Uyeler] ([Emanet_Id], [Uye_Id], [Uye_Adi], [Uye_Soyadi], [Uye_TelefonNo], [Uye_Eposta], [Uye_Cinsiyet]) VALUES (1, 10, N'ipek', N'yeşilturt', N'5454512365 ', N'ipekyesilyurt@gmail.com', N'kadın')
INSERT [dbo].[TBL_Uyeler] ([Emanet_Id], [Uye_Id], [Uye_Adi], [Uye_Soyadi], [Uye_TelefonNo], [Uye_Eposta], [Uye_Cinsiyet]) VALUES (2, 11, N'duru', N'yeşilyurt', N'5366988542 ', N'duruyesilyurt@gmail.com', N'kadın')
INSERT [dbo].[TBL_Uyeler] ([Emanet_Id], [Uye_Id], [Uye_Adi], [Uye_Soyadi], [Uye_TelefonNo], [Uye_Eposta], [Uye_Cinsiyet]) VALUES (3, 13, N'oğuzhan', N'ekincioğlu', N'5369452311 ', N'moekincioglu@gmail.com', N'erkek')
INSERT [dbo].[TBL_Uyeler] ([Emanet_Id], [Uye_Id], [Uye_Adi], [Uye_Soyadi], [Uye_TelefonNo], [Uye_Eposta], [Uye_Cinsiyet]) VALUES (1, 14, N'ezgi', N'kecici', N'5421478699 ', N'keciciezgi@hotmail.com', N'kadın')
SET IDENTITY_INSERT [dbo].[TBL_Uyeler] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Yayınevi] ON 

INSERT [dbo].[TBL_Yayınevi] ([Yayınevi_Id], [Yayınevi_İsmi], [Yayınevi_Adress]) VALUES (1, N' Alfa Yayınları', N'Üsküdar Mimar Sinan Mahallesi Atlas Çıkm')
INSERT [dbo].[TBL_Yayınevi] ([Yayınevi_Id], [Yayınevi_İsmi], [Yayınevi_Adress]) VALUES (2, N'Bilgi Yayınevi', N'Bilgi mahallesi çıkmaz sokak')
INSERT [dbo].[TBL_Yayınevi] ([Yayınevi_Id], [Yayınevi_İsmi], [Yayınevi_Adress]) VALUES (3, N'Cinius Yayınları', N'kahraman mahallesi')
INSERT [dbo].[TBL_Yayınevi] ([Yayınevi_Id], [Yayınevi_İsmi], [Yayınevi_Adress]) VALUES (5, N'Epsilon Yayınevi ', N'kağıt mahallesi')
INSERT [dbo].[TBL_Yayınevi] ([Yayınevi_Id], [Yayınevi_İsmi], [Yayınevi_Adress]) VALUES (7, N'Fecr Yayınları', N'Soğuksu Caddesi')
SET IDENTITY_INSERT [dbo].[TBL_Yayınevi] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Yazarlar] ON 

INSERT [dbo].[TBL_Yazarlar] ([Yazar_Id], [Yazar_Ad], [YazarSoyad]) VALUES (1, N'Jack                ', N'London              ')
INSERT [dbo].[TBL_Yazarlar] ([Yazar_Id], [Yazar_Ad], [YazarSoyad]) VALUES (2, N'Zülfü               ', N' Livaneli           ')
INSERT [dbo].[TBL_Yazarlar] ([Yazar_Id], [Yazar_Ad], [YazarSoyad]) VALUES (3, N'Mehmet Akif         ', N'Ersoy               ')
INSERT [dbo].[TBL_Yazarlar] ([Yazar_Id], [Yazar_Ad], [YazarSoyad]) VALUES (4, N'Ayşe                ', N'Kulin               ')
SET IDENTITY_INSERT [dbo].[TBL_Yazarlar] OFF
GO
ALTER TABLE [dbo].[TBL_Adresler]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Adresler_TBL_Uyeler] FOREIGN KEY([Uye_Id])
REFERENCES [dbo].[TBL_Uyeler] ([Uye_Id])
GO
ALTER TABLE [dbo].[TBL_Adresler] CHECK CONSTRAINT [FK_TBL_Adresler_TBL_Uyeler]
GO
ALTER TABLE [dbo].[TBL_Islem]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Islem_TBL_Emanet] FOREIGN KEY([Emanet_Id])
REFERENCES [dbo].[TBL_Emanet] ([Emanet_Id])
GO
ALTER TABLE [dbo].[TBL_Islem] CHECK CONSTRAINT [FK_TBL_Islem_TBL_Emanet]
GO
ALTER TABLE [dbo].[TBL_Islem]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Islem_TBL_Personel] FOREIGN KEY([Personel_Id])
REFERENCES [dbo].[TBL_Personel] ([Personel_Id])
GO
ALTER TABLE [dbo].[TBL_Islem] CHECK CONSTRAINT [FK_TBL_Islem_TBL_Personel]
GO
ALTER TABLE [dbo].[TBL_Kitaplar]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Kitaplar_TBL_Yazarlar] FOREIGN KEY([Yazar_Id])
REFERENCES [dbo].[TBL_Yazarlar] ([Yazar_Id])
GO
ALTER TABLE [dbo].[TBL_Kitaplar] CHECK CONSTRAINT [FK_TBL_Kitaplar_TBL_Yazarlar]
GO
ALTER TABLE [dbo].[TBL_Tur]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Tur_TBL_Kitaplar] FOREIGN KEY([Kitap_Id])
REFERENCES [dbo].[TBL_Kitaplar] ([Kitap_Id])
GO
ALTER TABLE [dbo].[TBL_Tur] CHECK CONSTRAINT [FK_TBL_Tur_TBL_Kitaplar]
GO
ALTER TABLE [dbo].[TBL_Uyeler]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Uyeler_TBL_Emanet] FOREIGN KEY([Emanet_Id])
REFERENCES [dbo].[TBL_Emanet] ([Emanet_Id])
GO
ALTER TABLE [dbo].[TBL_Uyeler] CHECK CONSTRAINT [FK_TBL_Uyeler_TBL_Emanet]
GO
