
CREATE TABLE [dbo].[BinaTipleri](
	[BinaTipId] [int] IDENTITY(1,1) NOT NULL,
	[BinaTipAdi] [nvarchar](50) NOT NULL,
	[TipRiskOrani] [int] NOT NULL,
 CONSTRAINT [PK_BinaTipleri] PRIMARY KEY CLUSTERED 
(
	[BinaTipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Birimler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Birimler](
	[BirimId] [int] IDENTITY(1,1) NOT NULL,
	[BirimAdi] [nvarchar](50) NOT NULL,
	[AktifPasif] [bit] NULL,
 CONSTRAINT [PK_Birimler] PRIMARY KEY CLUSTERED 
(
	[BirimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BolumDonanimlari]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BolumDonanimlari](
	[BDId] [int] IDENTITY(1,1) NOT NULL,
	[PBId] [int] NOT NULL,
	[DonanimId] [int] NOT NULL,
	[DMiktar] [decimal](6, 2) NULL,
	[BirimId] [int] NULL,
	[YuzeyId] [int] NOT NULL,
	[YMiktar] [decimal](6, 2) NULL,
 CONSTRAINT [PK_BolumDonanimlari] PRIMARY KEY CLUSTERED 
(
	[BDId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[BolumId] [int] IDENTITY(1,1) NOT NULL,
	[BolumAdi] [nvarchar](50) NOT NULL,
	[BolumTipId] [int] NOT NULL,
 CONSTRAINT [PK_Bolumler_1] PRIMARY KEY CLUSTERED 
(
	[BolumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BolumTipleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BolumTipleri](
	[BolumTipId] [int] IDENTITY(1,1) NOT NULL,
	[BolumTipiAdi] [nvarchar](50) NOT NULL,
	[BolumRiskOrani] [int] NOT NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[BolumTipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donanimlar]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donanimlar](
	[DonanimId] [int] IDENTITY(1,1) NOT NULL,
	[DonanimAdi] [nvarchar](50) NOT NULL,
	[DonanimResim] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Donanimlar] PRIMARY KEY CLUSTERED 
(
	[DonanimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FiyatListesi]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiyatListesi](
	[FiyatListesiId] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeId] [int] NULL,
	[MakineId] [int] NULL,
	[KimyasalId] [int] NULL,
	[MeslekId] [int] NULL,
	[miktar] [decimal](6, 2) NULL,
	[BirimId] [int] NULL,
	[Tutar] [decimal](7, 2) NULL,
	[ListeGecerlilikTarihi] [date] NULL,
	[Aktif] [bit] NULL,
 CONSTRAINT [PK_FiyatListesi] PRIMARY KEY CLUSTERED 
(
	[FiyatListesiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[IlceId] [int] IDENTITY(1,1) NOT NULL,
	[IlceAdi] [nvarchar](50) NOT NULL,
	[IlId] [int] NOT NULL,
 CONSTRAINT [PK_Ilceler] PRIMARY KEY CLUSTERED 
(
	[IlceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iller]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iller](
	[IlId] [int] IDENTITY(1,1) NOT NULL,
	[IlAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Iller] PRIMARY KEY CLUSTERED 
(
	[IlId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kimyasallar]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kimyasallar](
	[Kimyasalld] [int] IDENTITY(1,1) NOT NULL,
	[KimyasalAdi] [nvarchar](50) NOT NULL,
	[Ph] [nvarchar](50) NOT NULL,
	[UreticiId] [int] NOT NULL,
 CONSTRAINT [PK_Kimyasallar] PRIMARY KEY CLUSTERED 
(
	[Kimyasalld] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Makineler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Makineler](
	[MakineId] [int] IDENTITY(1,1) NOT NULL,
	[MakineAdi] [nvarchar](50) NOT NULL,
	[Aktif] [bit] NOT NULL,
	[AlimTarihi] [date] NULL,
	[AmortismanSuresi] [int] NULL,
 CONSTRAINT [PK_Makineler] PRIMARY KEY CLUSTERED 
(
	[MakineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Malzemeler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Malzemeler](
	[MalzemeId] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeAdi] [nvarchar](50) NOT NULL,
	[UreticiId] [int] NOT NULL,
	[BirimId] [int] NOT NULL,
 CONSTRAINT [PK_Malzemeler] PRIMARY KEY CLUSTERED 
(
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meslekler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meslekler](
	[MeslekId] [int] IDENTITY(1,1) NOT NULL,
	[MeslekAdi] [nvarchar](50) NOT NULL,
	[Yeterlilik] [bit] NOT NULL,
 CONSTRAINT [PK_Meslekler] PRIMARY KEY CLUSTERED 
(
	[MeslekId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriHareketleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriHareketleri](
	[MusteriHarketId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriId] [int] NOT NULL,
	[IslemTipi] [bit] NOT NULL,
	[Tutar] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_MusteriHareketleri] PRIMARY KEY CLUSTERED 
(
	[MusteriHarketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [nvarchar](250) NOT NULL,
	[MusteriAdresi] [nvarchar](250) NOT NULL,
	[MusteriVergiDairesi] [nvarchar](20) NOT NULL,
	[MusteriVergiNo] [nvarchar](11) NOT NULL,
	[MusteriYetkiliAdi] [nvarchar](150) NOT NULL,
	[MusteriYetkiliTelefon] [nchar](15) NOT NULL,
	[MusteriYetkiliDahili] [nchar](10) NULL,
	[MusteriWebAdresi] [nvarchar](50) NULL,
	[MusteriMersisNo] [nvarchar](20) NULL,
	[MusteriTehlikeSinifi] [int] NULL,
	[MusteriEPosta] [nvarchar](150) NULL,
	[AboneBaşlama] [datetime] NULL,
	[AboneBitis] [datetime] NULL,
	[Aktif] [bit] NOT NULL,
	[MaksimumProjeSayisi] [int] NOT NULL,
	[KullanilanProjeSayisi] [int] NOT NULL,
	[Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriId] [int] NOT NULL,
	[PersonelAdi] [nvarchar](50) NOT NULL,
	[PersonelSoyadi] [nvarchar](50) NOT NULL,
	[PersonelTc] [char](12) NOT NULL,
	[MeslekId] [int] NOT NULL,
	[PersonelTelefon] [char](15) NOT NULL,
	[PersonelMail] [nvarchar](50) NOT NULL,
	[PersonelCinsiyet] [bit] NOT NULL,
	[PersonelEgitim] [int] NOT NULL,
	[PersonelMedeni] [bit] NOT NULL,
	[PersonelCocuk] [int] NOT NULL,
	[PersonelDogumTarihi] [date] NOT NULL,
	[PersonelAciklama] [nvarchar](max) NULL,
	[IseBaslamaTarihi] [date] NOT NULL,
	[IstenAyrilmaTarihi] [date] NULL,
	[Alerji] [bit] NULL,
	[AlerjiDetay] [nvarchar](max) NULL,
	[Sifre] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeBinalari]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeBinalari](
	[BinaId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[BinaAdi] [nvarchar](50) NOT NULL,
	[BinaAdresi] [nvarchar](max) NOT NULL,
	[BinaIl] [int] NOT NULL,
	[BinaIlce] [int] NOT NULL,
	[BinaTipId] [int] NOT NULL,
	[BinaPersonelId] [int] NOT NULL,
 CONSTRAINT [PK_ProjeBinalari] PRIMARY KEY CLUSTERED 
(
	[BinaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeBolumleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeBolumleri](
	[PBId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[PBolumID] [int] NOT NULL,
	[PBolumMiktar] [decimal](6, 2) NOT NULL,
	[BirimId] [int] NOT NULL,
 CONSTRAINT [PK_ProjeBolumleri] PRIMARY KEY CLUSTERED 
(
	[PBId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeBolumTamamlama]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeBolumTamamlama](
	[PKontrolId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[BolumId] [int] NOT NULL,
	[PersonelId] [int] NOT NULL,
	[BaslamaZamani] [datetime] NULL,
	[BitisZamani] [datetime] NULL,
 CONSTRAINT [PK_ProjeBolumTamamlama] PRIMARY KEY CLUSTERED 
(
	[PKontrolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeDonanimTamamlama]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeDonanimTamamlama](
	[PDonanimId] [int] IDENTITY(1,1) NOT NULL,
	[PKontrolId] [int] NOT NULL,
	[DonanimId] [int] NOT NULL,
	[TamamlamaZamani] [datetime] NOT NULL,
	[BaslamaZamani] [datetime] NULL,
 CONSTRAINT [PK_ProjeDonanimTamamlama] PRIMARY KEY CLUSTERED 
(
	[PDonanimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeKimyasallari]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeKimyasallari](
	[PKimyasalId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[KimyasalId] [int] NOT NULL,
	[Miktar] [decimal](6, 2) NOT NULL,
	[BirimId] [int] NOT NULL,
 CONSTRAINT [PK_ProjeKimyallari] PRIMARY KEY CLUSTERED 
(
	[PKimyasalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projeler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projeler](
	[ProjeId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeAdi] [nvarchar](50) NOT NULL,
	[MusteriId] [int] NOT NULL,
	[ProjeFirmaUnvani] [nvarchar](150) NOT NULL,
	[ProjeAdresi] [nvarchar](250) NOT NULL,
	[ProjeVergiDairesi] [nvarchar](50) NOT NULL,
	[ProjeVergiNo] [nvarchar](11) NOT NULL,
	[ProjeIl] [int] NOT NULL,
	[ProjeIlce] [int] NOT NULL,
	[ProjeIk] [int] NOT NULL,
	[ProjeYetkiliAdi] [nvarchar](50) NOT NULL,
	[ProjeYetkiliTel] [nvarchar](15) NOT NULL,
	[ProjeYetkiliMail] [nvarchar](100) NOT NULL,
	[ProjeTehlikeSinifi] [int] NOT NULL,
	[Aciklama] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Projeler] PRIMARY KEY CLUSTERED 
(
	[ProjeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeMakineleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeMakineleri](
	[PMakineId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[MakineId] [int] NOT NULL,
	[BaslamaTarihi] [date] NOT NULL,
	[BitisTarihi] [date] NULL,
 CONSTRAINT [PK_ProjeMakineleri] PRIMARY KEY CLUSTERED 
(
	[PMakineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeMalzemeleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeMalzemeleri](
	[PMalzemeId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[MalzemeId] [int] NOT NULL,
	[Miktar] [decimal](6, 2) NOT NULL,
	[BirimId] [int] NULL,
 CONSTRAINT [PK_ProjeMalzemeleri] PRIMARY KEY CLUSTERED 
(
	[PMalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjePersonelleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjePersonelleri](
	[ProjeIkId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[PersonelId] [int] NULL,
	[BaslamaTarihi] [date] NOT NULL,
	[AyrılmaTarihi] [date] NULL,
 CONSTRAINT [PK_ProjePersonelleri] PRIMARY KEY CLUSTERED 
(
	[ProjeIkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjeTeklifleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjeTeklifleri](
	[TeklifId] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [int] NOT NULL,
	[YuzeyId] [int] NULL,
	[DonanimId] [int] NULL,
	[MalzemeId] [int] NULL,
	[KimyasalId] [int] NULL,
	[MakineId] [int] NULL,
	[Miktar] [decimal](6, 2) NOT NULL,
	[BirimId] [int] NOT NULL,
 CONSTRAINT [PK_ProjeTeklifleri] PRIMARY KEY CLUSTERED 
(
	[TeklifId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokHareketleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokHareketleri](
	[StokHareketId] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeId] [int] NOT NULL,
	[HareketTarihi] [date] NOT NULL,
	[AlimMiktari] [decimal](6, 2) NULL,
	[KullanimMiktari] [decimal](6, 2) NULL,
	[ProjeId] [int] NULL,
	[UreticiId] [int] NULL,
	[BirimId] [int] NOT NULL,
 CONSTRAINT [PK_StokHareketleri] PRIMARY KEY CLUSTERED 
(
	[StokHareketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UreticiHareketleri]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UreticiHareketleri](
	[UreticiHareketId] [int] IDENTITY(1,1) NOT NULL,
	[UreticiId] [int] NULL,
	[HareketTarihi] [date] NOT NULL,
	[IslemTipi] [bit] NOT NULL,
	[MalzemeId] [int] NULL,
	[MakineId] [int] NULL,
	[KimyasalId] [int] NULL,
	[Miktar] [decimal](8, 2) NOT NULL,
	[BirimId] [int] NOT NULL,
	[Tutar] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_UreticiHareketleri] PRIMARY KEY CLUSTERED 
(
	[UreticiHareketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ureticiler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ureticiler](
	[UreticiId] [int] IDENTITY(1,1) NOT NULL,
	[UreticiAdi] [nvarchar](250) NOT NULL,
	[UreticiAdresi] [nvarchar](250) NOT NULL,
	[UreticiVergiDairesi] [nvarchar](20) NOT NULL,
	[UreticiVergiNo] [nvarchar](11) NOT NULL,
	[UreticiYetkiliAdi] [nvarchar](50) NOT NULL,
	[UreticiYetkiliTelefon] [nchar](15) NOT NULL,
	[UreticiYetkiliDahili] [nchar](10) NOT NULL,
	[UreticiWebAdresi] [nvarchar](50) NULL,
	[UreticiMersisNo] [nvarchar](20) NOT NULL,
	[UreticiTehlikeSinifi] [int] NOT NULL,
 CONSTRAINT [PK_Ureticiler] PRIMARY KEY CLUSTERED 
(
	[UreticiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yuzeyler]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yuzeyler](
	[YuzeyId] [int] IDENTITY(1,1) NOT NULL,
	[YuzeyAdi] [nvarchar](50) NOT NULL,
	[SertZemin] [bit] NOT NULL,
	[Tekstil] [bit] NOT NULL,
	[Antika] [bit] NOT NULL,
	[Aciklama] [nvarchar](max) NOT NULL,
	[ResimYol] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Yuzeyler] PRIMARY KEY CLUSTERED 
(
	[YuzeyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YuzeyStandartlari]    Script Date: 10.10.2022 14:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YuzeyStandartlari](
	[YStandartId] [int] IDENTITY(1,1) NOT NULL,
	[YId] [int] NOT NULL,
	[KimyasalId] [int] NULL,
	[MakineId] [int] NULL,
	[YMalzemeId] [int] NULL,
	[StandartDeger] [decimal](6, 2) NOT NULL,
	[BirimId] [int] NOT NULL,
 CONSTRAINT [PK_YuzeyStandartlari] PRIMARY KEY CLUSTERED 
(
	[YStandartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BinaTipleri] ON 

INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (1, N'avm', 1)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (2, N'sinema', 2)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (3, N'okul', 3)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (8, N'avm', 1)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (9, N'avm', 81)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (2002, N'LunaPark', 10)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (2003, N'fabrika', 5)
INSERT [dbo].[BinaTipleri] ([BinaTipId], [BinaTipAdi], [TipRiskOrani]) VALUES (3003, N'fabrika', 12)
SET IDENTITY_INSERT [dbo].[BinaTipleri] OFF
SET IDENTITY_INSERT [dbo].[Birimler] ON 

INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (1, N'Adet2222', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (2, N'Düzine', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (3, N'Saat', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (4, N'Dakika', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (5, N'Saniye', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (6, N'Gram', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (7, N'Kilogram', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (1002, N'Metre Kare', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (1003, N'Adam / Saat', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (2002, N'Litre', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (2003, N'Metre', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (2004, N'Km', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (2005, N'Mili Litre', 1)
INSERT [dbo].[Birimler] ([BirimId], [BirimAdi], [AktifPasif]) VALUES (3002, N'YAREN', 1)
SET IDENTITY_INSERT [dbo].[Birimler] OFF
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([BolumId], [BolumAdi], [BolumTipId]) VALUES (2, N'sınıf', 1)
INSERT [dbo].[Bolumler] ([BolumId], [BolumAdi], [BolumTipId]) VALUES (3, N'laboratuvar', 2)
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
SET IDENTITY_INSERT [dbo].[BolumTipleri] ON 

INSERT [dbo].[BolumTipleri] ([BolumTipId], [BolumTipiAdi], [BolumRiskOrani]) VALUES (1, N'korıdor', 3)
INSERT [dbo].[BolumTipleri] ([BolumTipId], [BolumTipiAdi], [BolumRiskOrani]) VALUES (2, N'mutfak', 4)
INSERT [dbo].[BolumTipleri] ([BolumTipId], [BolumTipiAdi], [BolumRiskOrani]) VALUES (3, N'salon', 5)
SET IDENTITY_INSERT [dbo].[BolumTipleri] OFF
SET IDENTITY_INSERT [dbo].[Donanimlar] ON 

INSERT [dbo].[Donanimlar] ([DonanimId], [DonanimAdi], [DonanimResim]) VALUES (1, N'bilgisyar ', N'1')
INSERT [dbo].[Donanimlar] ([DonanimId], [DonanimAdi], [DonanimResim]) VALUES (2, N'tahta', N'1')
INSERT [dbo].[Donanimlar] ([DonanimId], [DonanimAdi], [DonanimResim]) VALUES (3, N'masa', N'2')
INSERT [dbo].[Donanimlar] ([DonanimId], [DonanimAdi], [DonanimResim]) VALUES (5, N'sandalye', N'1')
SET IDENTITY_INSERT [dbo].[Donanimlar] OFF
SET IDENTITY_INSERT [dbo].[FiyatListesi] ON 

INSERT [dbo].[FiyatListesi] ([FiyatListesiId], [MalzemeId], [MakineId], [KimyasalId], [MeslekId], [miktar], [BirimId], [Tutar], [ListeGecerlilikTarihi], [Aktif]) VALUES (1, 1, 1, 1, 1, CAST(254.00 AS Decimal(6, 2)), 1, CAST(258.00 AS Decimal(7, 2)), CAST(N'2025-01-01' AS Date), 1)
INSERT [dbo].[FiyatListesi] ([FiyatListesiId], [MalzemeId], [MakineId], [KimyasalId], [MeslekId], [miktar], [BirimId], [Tutar], [ListeGecerlilikTarihi], [Aktif]) VALUES (2, 2, 2, 2, 2, CAST(3695.00 AS Decimal(6, 2)), 2, CAST(589.00 AS Decimal(7, 2)), CAST(N'2028-04-07' AS Date), 1)
SET IDENTITY_INSERT [dbo].[FiyatListesi] OFF
SET IDENTITY_INSERT [dbo].[Ilceler] ON 

INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (1, N'ALADAĞ', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (2, N'CEYHAN', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (3, N'ÇUKUROVA', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (4, N'FEKE', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (5, N'İMAMOĞLU', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (6, N'KARAİSALI', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (7, N'KARATAŞ', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (8, N'KOZAN', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (9, N'POZANTI', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (10, N'SAİMBEYLİ', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (11, N'SARIÇAM', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (12, N'SEYHAN', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (13, N'TUFANBEYLİ', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (14, N'YUMURTALIK', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (15, N'YÜREĞİR', 1)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (16, N'BESNİ', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (17, N'ÇELİKHAN', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (18, N'GERGER', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (19, N'GÖLBAŞI', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (20, N'KAHTA', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (21, N'MERKEZ', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (22, N'SAMSAT', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (23, N'SİNCİK', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (24, N'TUT', 2)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (25, N'BAŞMAKÇI', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (26, N'BAYAT', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (27, N'BOLVADİN', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (28, N'ÇAY', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (29, N'ÇOBANLAR', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (30, N'DAZKIRI', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (31, N'DİNAR', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (32, N'EMİRDAĞ', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (33, N'EVCİLER', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (34, N'HOCALAR', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (35, N'İHSANİYE', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (36, N'İSCEHİSAR', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (37, N'KIZILÖREN', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (38, N'MERKEZ', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (39, N'SANDIKLI', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (40, N'SİNANPAŞA', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (41, N'SULTANDAĞI', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (42, N'ŞUHUT', 3)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (43, N'AĞAÇÖREN', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (44, N'ESKİL', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (45, N'GÜLAĞAÇ', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (46, N'GÜZELYURT', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (47, N'MERKEZ', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (48, N'ORTAKÖY', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (49, N'SARIYAHŞİ', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (50, N'SULTANHANI', 68)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (51, N'GÖYNÜCEK', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (52, N'GÜMÜŞHACIKÖY', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (53, N'HAMAMÖZÜ', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (54, N'MERKEZ', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (55, N'MERZİFON', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (56, N'SULUOVA', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (57, N'TAŞOVA', 5)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (58, N'AKYURT', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (59, N'ALTINDAĞ', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (60, N'AYAŞ', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (61, N'BALA', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (62, N'BEYPAZARI', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (63, N'ÇAMLIDERE', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (64, N'ÇANKAYA', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (65, N'ÇUBUK', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (66, N'ELMADAĞ', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (67, N'ETİMESGUT', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (68, N'EVREN', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (69, N'GÖLBAŞI', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (70, N'GÜDÜL', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (71, N'HAYMANA', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (72, N'KAHRAMANKAZAN', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (73, N'KALECİK', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (74, N'KEÇİÖREN', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (75, N'KIZILCAHAMAM', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (76, N'MAMAK', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (77, N'NALLIHAN', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (78, N'POLATLI', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (79, N'PURSAKLAR', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (80, N'SİNCAN', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (81, N'ŞEREFLİKOÇHİSAR', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (82, N'YENİMAHALLE', 6)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (83, N'AKSEKİ', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (84, N'AKSU', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (85, N'ALANYA', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (86, N'DEMRE', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (87, N'DÖŞEMEALTI', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (88, N'ELMALI', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (89, N'FİNİKE', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (90, N'GAZİPAŞA', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (91, N'GÜNDOĞMUŞ', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (92, N'İBRADI', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (93, N'KAŞ', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (94, N'KEMER', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (95, N'KEPEZ', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (96, N'KONYAALTI', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (97, N'KORKUTELİ', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (98, N'KUMLUCA', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (99, N'MANAVGAT', 7)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (100, N'MURATPAŞA', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (101, N'SERİK', 7)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (102, N'ÇILDIR', 75)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (103, N'DAMAL', 75)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (104, N'GÖLE', 75)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (105, N'HANAK', 75)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (106, N'MERKEZ', 75)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (107, N'POSOF', 75)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (108, N'ARDANUÇ', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (109, N'ARHAVİ', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (110, N'BORÇKA', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (111, N'HOPA', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (112, N'KEMALPAŞA', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (113, N'MERKEZ', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (114, N'MURGUL', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (115, N'ŞAVŞAT', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (116, N'YUSUFELİ', 8)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (117, N'BOZDOĞAN', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (118, N'BUHARKENT', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (119, N'ÇİNE', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (120, N'DİDİM', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (121, N'EFELER', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (122, N'GERMENCİK', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (123, N'İNCİRLİOVA', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (124, N'KARACASU', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (125, N'KARPUZLU', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (126, N'KOÇARLI', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (127, N'KÖŞK', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (128, N'KUŞADASI', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (129, N'KUYUCAK', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (130, N'NAZİLLİ', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (131, N'SÖKE', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (132, N'SULTANHİSAR', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (133, N'YENİPAZAR', 9)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (134, N'ALTIEYLÜL', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (135, N'AYVALIK', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (136, N'BALYA', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (137, N'BANDIRMA', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (138, N'BİGADİÇ', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (139, N'BURHANİYE', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (140, N'DURSUNBEY', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (141, N'EDREMİT', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (142, N'ERDEK', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (143, N'GÖMEÇ', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (144, N'GÖNEN', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (145, N'HAVRAN', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (146, N'İVRİNDİ', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (147, N'KARESİ', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (148, N'KEPSUT', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (149, N'MANYAS', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (150, N'MARMARA', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (151, N'SAVAŞTEPE', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (152, N'SINDIRGI', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (153, N'SUSURLUK', 10)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (154, N'AMASRA', 74)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (155, N'KURUCAŞİLE', 74)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (156, N'MERKEZ', 74)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (157, N'ULUS', 74)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (158, N'BEŞİRİ', 72)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (159, N'GERCÜŞ', 72)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (160, N'HASANKEYF', 72)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (161, N'KOZLUK', 72)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (162, N'MERKEZ', 72)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (163, N'SASON', 72)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (164, N'AYDINTEPE', 69)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (165, N'DEMİRÖZÜ', 69)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (166, N'MERKEZ', 69)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (167, N'BOZÜYÜK', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (168, N'GÖLPAZARI', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (169, N'İNHİSAR', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (170, N'MERKEZ', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (171, N'OSMANELİ', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (172, N'PAZARYERİ', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (173, N'SÖĞÜT', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (174, N'YENİPAZAR', 11)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (175, N'ADAKLI', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (176, N'GENÇ', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (177, N'KARLIOVA', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (178, N'KİĞI', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (179, N'MERKEZ', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (180, N'SOLHAN', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (181, N'YAYLADERE', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (182, N'YEDİSU', 12)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (183, N'ADİLCEVAZ', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (184, N'AHLAT', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (185, N'GÜROYMAK', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (186, N'HİZAN', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (187, N'MERKEZ', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (188, N'MUTKİ', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (189, N'TATVAN', 13)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (190, N'DÖRTDİVAN', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (191, N'GEREDE', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (192, N'GÖYNÜK', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (193, N'KIBRISCIK', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (194, N'MENGEN', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (195, N'MERKEZ', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (196, N'MUDURNU', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (197, N'SEBEN', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (198, N'YENİÇAĞA', 14)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (199, N'AĞLASUN', 15)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (200, N'ALTINYAYLA', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (201, N'BUCAK', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (202, N'ÇAVDIR', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (203, N'ÇELTİKÇİ', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (204, N'GÖLHİSAR', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (205, N'KARAMANLI', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (206, N'KEMER', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (207, N'MERKEZ', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (208, N'TEFENNİ', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (209, N'YEŞİLOVA', 15)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (210, N'BÜYÜKORHAN', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (211, N'GEMLİK', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (212, N'GÜRSU', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (213, N'HARMANCIK', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (214, N'İNEGÖL', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (215, N'İZNİK', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (216, N'KARACABEY', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (217, N'KELES', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (218, N'KESTEL', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (219, N'MUDANYA', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (220, N'MUSTAFAKEMALPAŞA', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (221, N'NİLÜFER', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (222, N'ORHANELİ', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (223, N'ORHANGAZİ', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (224, N'OSMANGAZİ', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (225, N'YENİŞEHİR', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (226, N'YILDIRIM', 16)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (227, N'AYVACIK', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (228, N'BAYRAMİÇ', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (229, N'BİGA', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (230, N'BOZCAADA', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (231, N'ÇAN', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (232, N'ECEABAT', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (233, N'EZİNE', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (234, N'GELİBOLU', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (235, N'GÖKÇEADA', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (236, N'LAPSEKİ', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (237, N'MERKEZ', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (238, N'YENİCE', 17)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (239, N'ATKARACALAR', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (240, N'BAYRAMÖREN', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (241, N'ÇERKEŞ', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (242, N'ELDİVAN', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (243, N'ILGAZ', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (244, N'KIZILIRMAK', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (245, N'KORGUN', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (246, N'KURŞUNLU', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (247, N'MERKEZ', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (248, N'ORTA', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (249, N'ŞABANÖZÜ', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (250, N'YAPRAKLI', 18)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (251, N'ALACA', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (252, N'BAYAT', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (253, N'BOĞAZKALE', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (254, N'DODURGA', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (255, N'İSKİLİP', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (256, N'KARGI', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (257, N'LAÇİN', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (258, N'MECİTÖZÜ', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (259, N'MERKEZ', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (260, N'OĞUZLAR', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (261, N'ORTAKÖY', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (262, N'OSMANCIK', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (263, N'SUNGURLU', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (264, N'UĞURLUDAĞ', 19)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (265, N'ACIPAYAM', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (266, N'BABADAĞ', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (267, N'BAKLAN', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (268, N'BEKİLLİ', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (269, N'BEYAĞAÇ', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (270, N'BOZKURT', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (271, N'BULDAN', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (272, N'ÇAL', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (273, N'ÇAMELİ', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (274, N'ÇARDAK', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (275, N'ÇİVRİL', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (276, N'GÜNEY', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (277, N'HONAZ', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (278, N'KALE', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (279, N'MERKEZEFENDİ', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (280, N'PAMUKKALE', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (281, N'SARAYKÖY', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (282, N'SERİNHİSAR', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (283, N'TAVAS', 20)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (284, N'BAĞLAR', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (285, N'BİSMİL', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (286, N'ÇERMİK', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (287, N'ÇINAR', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (288, N'ÇÜNGÜŞ', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (289, N'DİCLE', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (290, N'EĞİL', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (291, N'ERGANİ', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (292, N'HANİ', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (293, N'HAZRO', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (294, N'KAYAPINAR', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (295, N'KOCAKÖY', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (296, N'KULP', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (297, N'LİCE', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (298, N'SİLVAN', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (299, N'SUR', 21)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (300, N'YENİŞEHİR', 21)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (301, N'AKÇAKOCA', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (302, N'CUMAYERİ', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (303, N'ÇİLİMLİ', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (304, N'GÖLYAKA', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (305, N'GÜMÜŞOVA', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (306, N'KAYNAŞLI', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (307, N'MERKEZ', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (308, N'YIĞILCA', 81)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (309, N'ENEZ', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (310, N'HAVSA', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (311, N'İPSALA', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (312, N'KEŞAN', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (313, N'LALAPAŞA', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (314, N'MERİÇ', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (315, N'MERKEZ', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (316, N'SÜLOĞLU', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (317, N'UZUNKÖPRÜ', 22)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (318, N'AĞIN', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (319, N'ALACAKAYA', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (320, N'ARICAK', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (321, N'BASKİL', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (322, N'KARAKOÇAN', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (323, N'KEBAN', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (324, N'KOVANCILAR', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (325, N'MADEN', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (326, N'MERKEZ', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (327, N'PALU', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (328, N'SİVRİCE', 23)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (329, N'ÇAYIRLI', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (330, N'İLİÇ', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (331, N'KEMAH', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (332, N'KEMALİYE', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (333, N'MERKEZ', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (334, N'OTLUKBELİ', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (335, N'REFAHİYE', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (336, N'TERCAN', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (337, N'ÜZÜMLÜ', 24)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (338, N'AŞKALE', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (339, N'AZİZİYE', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (340, N'ÇAT', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (341, N'HINIS', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (342, N'HORASAN', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (343, N'İSPİR', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (344, N'KARAÇOBAN', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (345, N'KARAYAZI', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (346, N'KÖPRÜKÖY', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (347, N'NARMAN', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (348, N'OLTU', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (349, N'OLUR', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (350, N'PALANDÖKEN', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (351, N'PASİNLER', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (352, N'PAZARYOLU', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (353, N'ŞENKAYA', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (354, N'TEKMAN', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (355, N'TORTUM', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (356, N'UZUNDERE', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (357, N'YAKUTİYE', 25)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (358, N'ALPU', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (359, N'BEYLİKOVA', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (360, N'ÇİFTELER', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (361, N'GÜNYÜZÜ', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (362, N'HAN', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (363, N'İNÖNÜ', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (364, N'MAHMUDİYE', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (365, N'MİHALGAZİ', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (366, N'MİHALIÇÇIK', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (367, N'ODUNPAZARI', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (368, N'SARICAKAYA', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (369, N'SEYİTGAZİ', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (370, N'SİVRİHİSAR', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (371, N'TEPEBAŞI', 26)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (372, N'ARABAN', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (373, N'İSLAHİYE', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (374, N'KARKAMIŞ', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (375, N'NİZİP', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (376, N'NURDAĞI', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (377, N'OĞUZELİ', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (378, N'ŞAHİNBEY', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (379, N'ŞEHİTKAMİL', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (380, N'YAVUZELİ', 27)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (381, N'ALUCRA', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (382, N'BULANCAK', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (383, N'ÇAMOLUK', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (384, N'ÇANAKÇI', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (385, N'DERELİ', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (386, N'DOĞANKENT', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (387, N'ESPİYE', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (388, N'EYNESİL', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (389, N'GÖRELE', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (390, N'GÜCE', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (391, N'KEŞAP', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (392, N'MERKEZ', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (393, N'PİRAZİZ', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (394, N'ŞEBİNKARAHİSAR', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (395, N'TİREBOLU', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (396, N'YAĞLIDERE', 28)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (397, N'KELKİT', 29)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (398, N'KÖSE', 29)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (399, N'KÜRTÜN', 29)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (400, N'MERKEZ', 29)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (401, N'ŞİRAN', 29)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (402, N'TORUL', 29)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (403, N'ÇUKURCA', 30)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (404, N'DERECİK', 30)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (405, N'MERKEZ', 30)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (406, N'ŞEMDİNLİ', 30)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (407, N'YÜKSEKOVA', 30)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (408, N'ALTINÖZÜ', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (409, N'ANTAKYA', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (410, N'ARSUZ', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (411, N'BELEN', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (412, N'DEFNE', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (413, N'DÖRTYOL', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (414, N'ERZİN', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (415, N'HASSA', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (416, N'İSKENDERUN', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (417, N'KIRIKHAN', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (418, N'KUMLU', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (419, N'PAYAS', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (420, N'REYHANLI', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (421, N'SAMANDAĞ', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (422, N'YAYLADAĞI', 31)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (423, N'ARALIK', 76)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (424, N'KARAKOYUNLU', 76)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (425, N'MERKEZ', 76)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (426, N'TUZLUCA', 76)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (427, N'AKSU', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (428, N'ATABEY', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (429, N'EĞİRDİR', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (430, N'GELENDOST', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (431, N'GÖNEN', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (432, N'KEÇİBORLU', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (433, N'MERKEZ', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (434, N'SENİRKENT', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (435, N'SÜTÇÜLER', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (436, N'ŞARKİKARAAĞAÇ', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (437, N'ULUBORLU', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (438, N'YALVAÇ', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (439, N'YENİŞARBADEMLİ', 32)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (440, N'ADALAR', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (441, N'ARNAVUTKÖY', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (442, N'ATAŞEHİR', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (443, N'AVCILAR', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (444, N'BAĞCILAR', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (445, N'BAHÇELİEVLER', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (446, N'BAKIRKÖY', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (447, N'BAŞAKŞEHİR', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (448, N'BAYRAMPAŞA', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (449, N'BEŞİKTAŞ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (450, N'BEYKOZ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (451, N'BEYLİKDÜZÜ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (452, N'BEYOĞLU', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (453, N'BÜYÜKÇEKMECE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (454, N'ÇATALCA', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (455, N'ÇEKMEKÖY', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (456, N'ESENLER', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (457, N'ESENYURT', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (458, N'EYÜPSULTAN', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (459, N'FATİH', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (460, N'GAZİOSMANPAŞA', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (461, N'GÜNGÖREN', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (462, N'KADIKÖY', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (463, N'KAĞITHANE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (464, N'KARTAL', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (465, N'KÜÇÜKÇEKMECE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (466, N'MALTEPE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (467, N'PENDİK', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (468, N'SANCAKTEPE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (469, N'SARIYER', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (470, N'SİLİVRİ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (471, N'SULTANBEYLİ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (472, N'SULTANGAZİ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (473, N'ŞİLE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (474, N'ŞİŞLİ', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (475, N'TUZLA', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (476, N'ÜMRANİYE', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (477, N'ÜSKÜDAR', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (478, N'ZEYTİNBURNU', 34)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (479, N'ALİAĞA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (480, N'BALÇOVA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (481, N'BAYINDIR', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (482, N'BAYRAKLI', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (483, N'BERGAMA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (484, N'BEYDAĞ', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (485, N'BORNOVA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (486, N'BUCA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (487, N'ÇEŞME', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (488, N'ÇİĞLİ', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (489, N'DİKİLİ', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (490, N'FOÇA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (491, N'GAZİEMİR', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (492, N'GÜZELBAHÇE', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (493, N'KARABAĞLAR', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (494, N'KARABURUN', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (495, N'KARŞIYAKA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (496, N'KEMALPAŞA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (497, N'KINIK', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (498, N'KİRAZ', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (499, N'KONAK', 35)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (500, N'MENDERES', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (501, N'MENEMEN', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (502, N'NARLIDERE', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (503, N'ÖDEMİŞ', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (504, N'SEFERİHİSAR', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (505, N'SELÇUK', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (506, N'TİRE', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (507, N'TORBALI', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (508, N'URLA', 35)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (509, N'AFŞİN', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (510, N'ANDIRIN', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (511, N'ÇAĞLAYANCERİT', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (512, N'DULKADİROĞLU', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (513, N'EKİNÖZÜ', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (514, N'ELBİSTAN', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (515, N'GÖKSUN', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (516, N'NURHAK', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (517, N'ONİKİŞUBAT', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (518, N'PAZARCIK', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (519, N'TÜRKOĞLU', 46)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (520, N'EFLANİ', 78)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (521, N'ESKİPAZAR', 78)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (522, N'MERKEZ', 78)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (523, N'OVACIK', 78)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (524, N'SAFRANBOLU', 78)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (525, N'YENİCE', 78)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (526, N'AYRANCI', 70)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (527, N'BAŞYAYLA', 70)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (528, N'ERMENEK', 70)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (529, N'KAZIMKARABEKİR', 70)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (530, N'MERKEZ', 70)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (531, N'SARIVELİLER', 70)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (532, N'AKYAKA', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (533, N'ARPAÇAY', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (534, N'DİGOR', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (535, N'KAĞIZMAN', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (536, N'MERKEZ', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (537, N'SARIKAMIŞ', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (538, N'SELİM', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (539, N'SUSUZ', 36)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (540, N'ABANA', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (541, N'AĞLI', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (542, N'ARAÇ', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (543, N'AZDAVAY', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (544, N'BOZKURT', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (545, N'CİDE', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (546, N'ÇATALZEYTİN', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (547, N'DADAY', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (548, N'DEVREKANİ', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (549, N'DOĞANYURT', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (550, N'HANÖNÜ', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (551, N'İHSANGAZİ', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (552, N'İNEBOLU', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (553, N'KÜRE', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (554, N'MERKEZ', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (555, N'PINARBAŞI', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (556, N'SEYDİLER', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (557, N'ŞENPAZAR', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (558, N'TAŞKÖPRÜ', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (559, N'TOSYA', 37)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (560, N'AKKIŞLA', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (561, N'BÜNYAN', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (562, N'DEVELİ', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (563, N'FELAHİYE', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (564, N'HACILAR', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (565, N'İNCESU', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (566, N'KOCASİNAN', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (567, N'MELİKGAZİ', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (568, N'ÖZVATAN', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (569, N'PINARBAŞI', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (570, N'SARIOĞLAN', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (571, N'SARIZ', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (572, N'TALAS', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (573, N'TOMARZA', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (574, N'YAHYALI', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (575, N'YEŞİLHİSAR', 38)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (576, N'BAHŞILI', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (577, N'BALIŞEYH', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (578, N'ÇELEBİ', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (579, N'DELİCE', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (580, N'KARAKEÇİLİ', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (581, N'KESKİN', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (582, N'MERKEZ', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (583, N'SULAKYURT', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (584, N'YAHŞİHAN', 71)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (585, N'BABAESKİ', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (586, N'DEMİRKÖY', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (587, N'KOFÇAZ', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (588, N'LÜLEBURGAZ', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (589, N'MERKEZ', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (590, N'PEHLİVANKÖY', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (591, N'PINARHİSAR', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (592, N'VİZE', 39)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (593, N'AKÇAKENT', 40)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (594, N'AKPINAR', 40)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (595, N'BOZTEPE', 40)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (596, N'ÇİÇEKDAĞI', 40)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (597, N'KAMAN', 40)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (598, N'MERKEZ', 40)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (599, N'MUCUR', 40)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (600, N'ELBEYLİ', 79)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (601, N'MERKEZ', 79)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (602, N'MUSABEYLİ', 79)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (603, N'POLATELİ', 79)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (604, N'BAŞİSKELE', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (605, N'ÇAYIROVA', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (606, N'DARICA', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (607, N'DERİNCE', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (608, N'DİLOVASI', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (609, N'GEBZE', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (610, N'GÖLCÜK', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (611, N'İZMİT', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (612, N'KANDIRA', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (613, N'KARAMÜRSEL', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (614, N'KARTEPE', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (615, N'KÖRFEZ', 41)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (616, N'AHIRLI', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (617, N'AKÖREN', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (618, N'AKŞEHİR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (619, N'ALTINEKİN', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (620, N'BEYŞEHİR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (621, N'BOZKIR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (622, N'CİHANBEYLİ', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (623, N'ÇELTİK', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (624, N'ÇUMRA', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (625, N'DERBENT', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (626, N'DEREBUCAK', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (627, N'DOĞANHİSAR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (628, N'EMİRGAZİ', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (629, N'EREĞLİ', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (630, N'GÜNEYSINIR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (631, N'HADİM', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (632, N'HALKAPINAR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (633, N'HÜYÜK', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (634, N'ILGIN', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (635, N'KADINHANI', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (636, N'KARAPINAR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (637, N'KARATAY', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (638, N'KULU', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (639, N'MERAM', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (640, N'SARAYÖNÜ', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (641, N'SELÇUKLU', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (642, N'SEYDİŞEHİR', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (643, N'TAŞKENT', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (644, N'TUZLUKÇU', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (645, N'YALIHÜYÜK', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (646, N'YUNAK', 42)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (647, N'ALTINTAŞ', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (648, N'ASLANAPA', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (649, N'ÇAVDARHİSAR', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (650, N'DOMANİÇ', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (651, N'DUMLUPINAR', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (652, N'EMET', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (653, N'GEDİZ', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (654, N'HİSARCIK', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (655, N'MERKEZ', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (656, N'PAZARLAR', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (657, N'SİMAV', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (658, N'ŞAPHANE', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (659, N'TAVŞANLI', 43)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (660, N'AKÇADAĞ', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (661, N'ARAPGİR', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (662, N'ARGUVAN', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (663, N'BATTALGAZİ', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (664, N'DARENDE', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (665, N'DOĞANŞEHİR', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (666, N'DOĞANYOL', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (667, N'HEKİMHAN', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (668, N'KALE', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (669, N'KULUNCAK', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (670, N'PÜTÜRGE', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (671, N'YAZIHAN', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (672, N'YEŞİLYURT', 44)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (673, N'AHMETLİ', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (674, N'AKHİSAR', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (675, N'ALAŞEHİR', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (676, N'DEMİRCİ', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (677, N'GÖLMARMARA', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (678, N'GÖRDES', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (679, N'KIRKAĞAÇ', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (680, N'KÖPRÜBAŞI', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (681, N'KULA', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (682, N'SALİHLİ', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (683, N'SARIGÖL', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (684, N'SARUHANLI', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (685, N'SELENDİ', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (686, N'SOMA', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (687, N'ŞEHZADELER', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (688, N'TURGUTLU', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (689, N'YUNUSEMRE', 45)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (690, N'ARTUKLU', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (691, N'DARGEÇİT', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (692, N'DERİK', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (693, N'KIZILTEPE', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (694, N'MAZIDAĞI', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (695, N'MİDYAT', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (696, N'NUSAYBİN', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (697, N'ÖMERLİ', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (698, N'SAVUR', 47)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (699, N'YEŞİLLİ', 47)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (700, N'AKDENİZ', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (701, N'ANAMUR', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (702, N'AYDINCIK', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (703, N'BOZYAZI', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (704, N'ÇAMLIYAYLA', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (705, N'ERDEMLİ', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (706, N'GÜLNAR', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (707, N'MEZİTLİ', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (708, N'MUT', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (709, N'SİLİFKE', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (710, N'TARSUS', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (711, N'TOROSLAR', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (712, N'YENİŞEHİR', 33)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (713, N'BODRUM', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (714, N'DALAMAN', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (715, N'DATÇA', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (716, N'FETHİYE', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (717, N'KAVAKLIDERE', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (718, N'KÖYCEĞİZ', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (719, N'MARMARİS', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (720, N'MENTEŞE', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (721, N'MİLAS', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (722, N'ORTACA', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (723, N'SEYDİKEMER', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (724, N'ULA', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (725, N'YATAĞAN', 48)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (726, N'BULANIK', 49)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (727, N'HASKÖY', 49)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (728, N'KORKUT', 49)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (729, N'MALAZGİRT', 49)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (730, N'MERKEZ', 49)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (731, N'VARTO', 49)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (732, N'ACIGÖL', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (733, N'AVANOS', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (734, N'DERİNKUYU', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (735, N'GÜLŞEHİR', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (736, N'HACIBEKTAŞ', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (737, N'KOZAKLI', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (738, N'MERKEZ', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (739, N'ÜRGÜP', 50)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (740, N'ALTUNHİSAR', 51)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (741, N'BOR', 51)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (742, N'ÇAMARDI', 51)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (743, N'ÇİFTLİK', 51)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (744, N'MERKEZ', 51)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (745, N'ULUKIŞLA', 51)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (746, N'AKKUŞ', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (747, N'ALTINORDU', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (748, N'AYBASTI', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (749, N'ÇAMAŞ', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (750, N'ÇATALPINAR', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (751, N'ÇAYBAŞI', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (752, N'FATSA', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (753, N'GÖLKÖY', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (754, N'GÜLYALI', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (755, N'GÜRGENTEPE', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (756, N'İKİZCE', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (757, N'KABADÜZ', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (758, N'KABATAŞ', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (759, N'KORGAN', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (760, N'KUMRU', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (761, N'MESUDİYE', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (762, N'PERŞEMBE', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (763, N'ULUBEY', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (764, N'ÜNYE', 52)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (765, N'BAHÇE', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (766, N'DÜZİÇİ', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (767, N'HASANBEYLİ', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (768, N'KADİRLİ', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (769, N'MERKEZ', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (770, N'SUMBAS', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (771, N'TOPRAKKALE', 80)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (772, N'ARDEŞEN', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (773, N'ÇAMLIHEMŞİN', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (774, N'ÇAYELİ', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (775, N'DEREPAZARI', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (776, N'FINDIKLI', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (777, N'GÜNEYSU', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (778, N'HEMŞİN', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (779, N'İKİZDERE', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (780, N'İYİDERE', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (781, N'KALKANDERE', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (782, N'MERKEZ', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (783, N'PAZAR', 53)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (784, N'ADAPAZARI', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (785, N'AKYAZI', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (786, N'ARİFİYE', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (787, N'ERENLER', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (788, N'FERİZLİ', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (789, N'GEYVE', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (790, N'HENDEK', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (791, N'KARAPÜRÇEK', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (792, N'KARASU', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (793, N'KAYNARCA', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (794, N'KOCAALİ', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (795, N'PAMUKOVA', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (796, N'SAPANCA', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (797, N'SERDİVAN', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (798, N'SÖĞÜTLÜ', 54)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (799, N'TARAKLI', 54)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (800, N'19 MAYIS', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (801, N'ALAÇAM', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (802, N'ASARCIK', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (803, N'ATAKUM', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (804, N'AYVACIK', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (805, N'BAFRA', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (806, N'CANİK', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (807, N'ÇARŞAMBA', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (808, N'HAVZA', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (809, N'İLKADIM', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (810, N'KAVAK', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (811, N'LADİK', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (812, N'SALIPAZARI', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (813, N'TEKKEKÖY', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (814, N'TERME', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (815, N'VEZİRKÖPRÜ', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (816, N'YAKAKENT', 55)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (817, N'BAYKAN', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (818, N'ERUH', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (819, N'KURTALAN', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (820, N'MERKEZ', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (821, N'PERVARİ', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (822, N'ŞİRVAN', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (823, N'TİLLO', 56)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (824, N'AYANCIK', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (825, N'BOYABAT', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (826, N'DİKMEN', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (827, N'DURAĞAN', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (828, N'ERFELEK', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (829, N'GERZE', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (830, N'MERKEZ', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (831, N'SARAYDÜZÜ', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (832, N'TÜRKELİ', 57)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (833, N'AKINCILAR', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (834, N'ALTINYAYLA', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (835, N'DİVRİĞİ', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (836, N'DOĞANŞAR', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (837, N'GEMEREK', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (838, N'GÖLOVA', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (839, N'GÜRÜN', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (840, N'HAFİK', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (841, N'İMRANLI', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (842, N'KANGAL', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (843, N'KOYULHİSAR', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (844, N'MERKEZ', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (845, N'SUŞEHRİ', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (846, N'ŞARKIŞLA', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (847, N'ULAŞ', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (848, N'YILDIZELİ', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (849, N'ZARA', 58)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (850, N'AKÇAKALE', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (851, N'BİRECİK', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (852, N'BOZOVA', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (853, N'CEYLANPINAR', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (854, N'EYYÜBİYE', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (855, N'HALFETİ', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (856, N'HALİLİYE', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (857, N'HARRAN', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (858, N'HİLVAN', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (859, N'KARAKÖPRÜ', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (860, N'SİVEREK', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (861, N'SURUÇ', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (862, N'VİRANŞEHİR', 63)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (863, N'BEYTÜŞŞEBAP', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (864, N'CİZRE', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (865, N'GÜÇLÜKONAK', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (866, N'İDİL', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (867, N'MERKEZ', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (868, N'SİLOPİ', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (869, N'ULUDERE', 73)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (870, N'ÇERKEZKÖY', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (871, N'ÇORLU', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (872, N'ERGENE', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (873, N'HAYRABOLU', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (874, N'KAPAKLI', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (875, N'MALKARA', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (876, N'MARMARAEREĞLİSİ', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (877, N'MURATLI', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (878, N'SARAY', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (879, N'SÜLEYMANPAŞA', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (880, N'ŞARKÖY', 59)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (881, N'ALMUS', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (882, N'ARTOVA', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (883, N'BAŞÇİFTLİK', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (884, N'ERBAA', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (885, N'MERKEZ', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (886, N'NİKSAR', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (887, N'PAZAR', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (888, N'REŞADİYE', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (889, N'SULUSARAY', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (890, N'TURHAL', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (891, N'YEŞİLYURT', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (892, N'ZİLE', 60)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (893, N'AKÇAABAT', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (894, N'ARAKLI', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (895, N'ARSİN', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (896, N'BEŞİKDÜZÜ', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (897, N'ÇARŞIBAŞI', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (898, N'ÇAYKARA', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (899, N'DERNEKPAZARI', 61)
GO
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (900, N'DÜZKÖY', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (901, N'HAYRAT', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (902, N'KÖPRÜBAŞI', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (903, N'MAÇKA', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (904, N'OF', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (905, N'ORTAHİSAR', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (906, N'SÜRMENE', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (907, N'ŞALPAZARI', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (908, N'TONYA', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (909, N'VAKFIKEBİR', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (910, N'YOMRA', 61)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (911, N'ÇEMİŞGEZEK', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (912, N'HOZAT', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (913, N'MAZGİRT', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (914, N'MERKEZ', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (915, N'NAZIMİYE', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (916, N'OVACIK', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (917, N'PERTEK', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (918, N'PÜLÜMÜR', 62)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (919, N'BANAZ', 64)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (920, N'EŞME', 64)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (921, N'KARAHALLI', 64)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (922, N'MERKEZ', 64)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (923, N'SİVASLI', 64)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (924, N'ULUBEY', 64)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (925, N'BAHÇESARAY', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (926, N'BAŞKALE', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (927, N'ÇALDIRAN', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (928, N'ÇATAK', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (929, N'EDREMİT', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (930, N'ERCİŞ', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (931, N'GEVAŞ', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (932, N'GÜRPINAR', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (933, N'İPEKYOLU', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (934, N'MURADİYE', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (935, N'ÖZALP', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (936, N'SARAY', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (937, N'TUŞBA', 65)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (938, N'ALTINOVA', 77)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (939, N'ARMUTLU', 77)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (940, N'ÇINARCIK', 77)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (941, N'ÇİFTLİKKÖY', 77)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (942, N'MERKEZ', 77)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (943, N'TERMAL', 77)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (944, N'AKDAĞMADENİ', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (945, N'AYDINCIK', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (946, N'BOĞAZLIYAN', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (947, N'ÇANDIR', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (948, N'ÇAYIRALAN', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (949, N'ÇEKEREK', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (950, N'KADIŞEHRİ', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (951, N'MERKEZ', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (952, N'SARAYKENT', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (953, N'SARIKAYA', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (954, N'SORGUN', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (955, N'ŞEFAATLİ', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (956, N'YENİFAKILI', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (957, N'YERKÖY', 66)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (958, N'ALAPLI', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (959, N'ÇAYCUMA', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (960, N'DEVREK', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (961, N'EREĞLİ', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (962, N'GÖKÇEBEY', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (963, N'KİLİMLİ', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (964, N'KOZLU', 67)
INSERT [dbo].[Ilceler] ([IlceId], [IlceAdi], [IlId]) VALUES (965, N'MERKEZ', 67)
SET IDENTITY_INSERT [dbo].[Ilceler] OFF
SET IDENTITY_INSERT [dbo].[Iller] ON 

INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (1, N'ADANA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (2, N'ADIYAMAN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (3, N'AFYON')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (4, N'AĞRI')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (5, N'AMASYA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (6, N'ANKARA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (7, N'ANTALYA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (8, N'ARTVİN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (9, N'AYDIN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (10, N'BALIKESİR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (11, N'BİLECİK')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (12, N'BİNGÖL')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (13, N'BİTLİS')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (14, N'BOLU')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (15, N'BURDUR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (16, N'BURSA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (17, N'ÇANAKKALE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (18, N'ÇANKIRI')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (19, N'ÇORUM')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (20, N'DENİZLİ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (21, N'DİYARBAKIR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (22, N'EDİRNE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (23, N'ELAZIĞ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (24, N'ERZİNCAN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (25, N'ERZURUM')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (26, N'ESKİŞEHİR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (27, N'GAZİANTEP')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (28, N'GİRESUN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (29, N'GÜMÜŞHANE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (30, N'HAKKARİ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (31, N'HATAY')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (32, N'ISPARTA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (33, N'İÇEL')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (34, N'İSTANBUL')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (35, N'İZMİR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (36, N'KARS')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (37, N'KASTAMONU')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (38, N'KAYSERİ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (39, N'KIRKLARELİ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (40, N'KIRŞEHİR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (41, N'KOCAELİ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (42, N'KONYA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (43, N'KÜTAHYA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (44, N'MALATYA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (45, N'MANİSA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (46, N'KAHRAMANMARAŞ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (47, N'MARDİN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (48, N'MUĞLA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (49, N'MUŞ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (50, N'NEVŞEHİR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (51, N'NİĞDE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (52, N'ORDU')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (53, N'RİZE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (54, N'SAKARYA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (55, N'SAMSUN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (56, N'SİİRT')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (57, N'SİNOP')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (58, N'SİVAS')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (59, N'TEKİRDAĞ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (60, N'TOKAT')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (61, N'TRABZON')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (62, N'TUNCELİ')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (63, N'ŞANLIURFA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (64, N'UŞAK')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (65, N'VAN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (66, N'YOZGAT')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (67, N'ZONGULDAK')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (68, N'AKSARAY')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (69, N'BAYBURT')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (70, N'KARAMAN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (71, N'KIRIKKALE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (72, N'BATMAN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (73, N'ŞIRNAK')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (74, N'BARTIN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (75, N'ARDAHAN')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (76, N'IĞDIR')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (77, N'YALOVA')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (78, N'KARABÜK')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (79, N'KİLİS')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (80, N'OSMANİYE')
INSERT [dbo].[Iller] ([IlId], [IlAdi]) VALUES (81, N'DÜZCE')
SET IDENTITY_INSERT [dbo].[Iller] OFF
SET IDENTITY_INSERT [dbo].[Kimyasallar] ON 

INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (2, N'amonyok', N'6.80', 1)
INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (3, N'tuz ruhu', N'9.60', 2)
INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (4, N'yuzey temızleyıcı', N'10.40', 2)
INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (6, N'tuzzzz', N'9,8', 1)
INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (7, N'tuzzzz99111', N'9,475', 1)
INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (8, N' felaketii', N'9.47', 2)
INSERT [dbo].[Kimyasallar] ([Kimyasalld], [KimyasalAdi], [Ph], [UreticiId]) VALUES (1006, N'sıvı sabun', N'9.47', 1)
SET IDENTITY_INSERT [dbo].[Kimyasallar] OFF
SET IDENTITY_INSERT [dbo].[Meslekler] ON 

INSERT [dbo].[Meslekler] ([MeslekId], [MeslekAdi], [Yeterlilik]) VALUES (1, N'Test', 0)
SET IDENTITY_INSERT [dbo].[Meslekler] OFF
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriId], [MusteriAdi], [MusteriAdresi], [MusteriVergiDairesi], [MusteriVergiNo], [MusteriYetkiliAdi], [MusteriYetkiliTelefon], [MusteriYetkiliDahili], [MusteriWebAdresi], [MusteriMersisNo], [MusteriTehlikeSinifi], [MusteriEPosta], [AboneBaşlama], [AboneBitis], [Aktif], [MaksimumProjeSayisi], [KullanilanProjeSayisi], [Aciklama]) VALUES (1, N'MZM 44444', N'Sakarya', N'Gümrükönü', N'55511122211', N'Turan Erdoğan', N'541 232 50 28  ', N'5551      ', N'www.turanerdogan.com', N'21215464564 ', 0, N'turan@turanerdogan.com', CAST(N'2022-04-18T00:00:00.000' AS DateTime), CAST(N'2022-04-25T00:00:00.000' AS DateTime), 1, 15, 1, N'hfdhfg')
INSERT [dbo].[Musteriler] ([MusteriId], [MusteriAdi], [MusteriAdresi], [MusteriVergiDairesi], [MusteriVergiNo], [MusteriYetkiliAdi], [MusteriYetkiliTelefon], [MusteriYetkiliDahili], [MusteriWebAdresi], [MusteriMersisNo], [MusteriTehlikeSinifi], [MusteriEPosta], [AboneBaşlama], [AboneBitis], [Aktif], [MaksimumProjeSayisi], [KullanilanProjeSayisi], [Aciklama]) VALUES (7, N'Abdullah', N'Adres', N'VD', N'VN', N'Abdullah 33333333', N'5412325028     ', N'1111      ', N'web adresi gdfgdfg ddfgdfg fdg fg fgdfg', N'Mersis', 0, N'ffdgksdfşkf@dfgsdf.com', CAST(N'2022-04-06T00:00:00.000' AS DateTime), CAST(N'2022-04-22T00:00:00.000' AS DateTime), 1, 10, 1, N'dfsdfadf')
INSERT [dbo].[Musteriler] ([MusteriId], [MusteriAdi], [MusteriAdresi], [MusteriVergiDairesi], [MusteriVergiNo], [MusteriYetkiliAdi], [MusteriYetkiliTelefon], [MusteriYetkiliDahili], [MusteriWebAdresi], [MusteriMersisNo], [MusteriTehlikeSinifi], [MusteriEPosta], [AboneBaşlama], [AboneBitis], [Aktif], [MaksimumProjeSayisi], [KullanilanProjeSayisi], [Aciklama]) VALUES (1007, N'Yeni Müşteri', N'gdfgxdfgsfgsd', N'Vergi Dairesi', N'Vergi No', N'Abdullah', N'5412325028     ', N'iç hat    ', N'web adresi gdfgdfg ddfgdfg fdg fg fgdfg', N'Mersis', 0, N'dfldkjls@dfkdş.com', CAST(N'2022-04-11T00:00:00.000' AS DateTime), CAST(N'2022-04-25T00:00:00.000' AS DateTime), 0, 10, 1, N'sdfsdfasdf')
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PersonelId], [MusteriId], [PersonelAdi], [PersonelSoyadi], [PersonelTc], [MeslekId], [PersonelTelefon], [PersonelMail], [PersonelCinsiyet], [PersonelEgitim], [PersonelMedeni], [PersonelCocuk], [PersonelDogumTarihi], [PersonelAciklama], [IseBaslamaTarihi], [IstenAyrilmaTarihi], [Alerji], [AlerjiDetay], [Sifre]) VALUES (2, 1, N'Turan', N'Erdoğan', N'12345678901 ', 1, N'5555555        ', N'mail', 1, 0, 1, 0, CAST(N'1969-06-10' AS Date), N'dfgdf', CAST(N'2022-01-01' AS Date), NULL, 0, N'xcfvsd', N'111')
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[Projeler] ON 

INSERT [dbo].[Projeler] ([ProjeId], [ProjeAdi], [MusteriId], [ProjeFirmaUnvani], [ProjeAdresi], [ProjeVergiDairesi], [ProjeVergiNo], [ProjeIl], [ProjeIlce], [ProjeIk], [ProjeYetkiliAdi], [ProjeYetkiliTel], [ProjeYetkiliMail], [ProjeTehlikeSinifi], [Aciklama]) VALUES (1, N'Proje Test 1', 1, N'Unvan', N'Adres', N'Vergi Dairesi', N'12345678901', 1, 1, 1, N'Yetkili', N'5555555', N'mail', 2, N'Açıklama')
INSERT [dbo].[Projeler] ([ProjeId], [ProjeAdi], [MusteriId], [ProjeFirmaUnvani], [ProjeAdresi], [ProjeVergiDairesi], [ProjeVergiNo], [ProjeIl], [ProjeIlce], [ProjeIk], [ProjeYetkiliAdi], [ProjeYetkiliTel], [ProjeYetkiliMail], [ProjeTehlikeSinifi], [Aciklama]) VALUES (6, N'Yeni Proje', 1, N'Firma Ünvanı', N'eewrwerewar werf wearawerawe', N'Vergi Dairesi', N'12398765412', 43, 2, 1, N'Yetkili 2', N'3335555', N'mail@mail', 2, N'defsdrf')
INSERT [dbo].[Projeler] ([ProjeId], [ProjeAdi], [MusteriId], [ProjeFirmaUnvani], [ProjeAdresi], [ProjeVergiDairesi], [ProjeVergiNo], [ProjeIl], [ProjeIlce], [ProjeIk], [ProjeYetkiliAdi], [ProjeYetkiliTel], [ProjeYetkiliMail], [ProjeTehlikeSinifi], [Aciklama]) VALUES (8, N'Yeni Proje', 1, N'Firma Ünvanı', N'sdfsdf', N'Vergi Dairesi', N'12398765412', 9, 1, 1, N'Yetkili 2', N'3335555', N'mail@mail', 2, N'sdfsdfsd')
INSERT [dbo].[Projeler] ([ProjeId], [ProjeAdi], [MusteriId], [ProjeFirmaUnvani], [ProjeAdresi], [ProjeVergiDairesi], [ProjeVergiNo], [ProjeIl], [ProjeIlce], [ProjeIk], [ProjeYetkiliAdi], [ProjeYetkiliTel], [ProjeYetkiliMail], [ProjeTehlikeSinifi], [Aciklama]) VALUES (9, N'Yeni Proje', 1, N'Firma Ünvanı', N'sdfsdfsadfad', N'Vergi Dairesi', N'12398765412', 60, 888, 1, N'Yetkili 2', N'3335555', N'mail@mail', 2, N'sdfasdf')
INSERT [dbo].[Projeler] ([ProjeId], [ProjeAdi], [MusteriId], [ProjeFirmaUnvani], [ProjeAdresi], [ProjeVergiDairesi], [ProjeVergiNo], [ProjeIl], [ProjeIlce], [ProjeIk], [ProjeYetkiliAdi], [ProjeYetkiliTel], [ProjeYetkiliMail], [ProjeTehlikeSinifi], [Aciklama]) VALUES (10, N'test966', 1, N'ozel', N'denızli', N'idil', N'33', 19, 251, 2, N'turan erdogan', N'77', N'aploex@gmail.com', 3, N'ff')
SET IDENTITY_INSERT [dbo].[Projeler] OFF
SET IDENTITY_INSERT [dbo].[Ureticiler] ON 

INSERT [dbo].[Ureticiler] ([UreticiId], [UreticiAdi], [UreticiAdresi], [UreticiVergiDairesi], [UreticiVergiNo], [UreticiYetkiliAdi], [UreticiYetkiliTelefon], [UreticiYetkiliDahili], [UreticiWebAdresi], [UreticiMersisNo], [UreticiTehlikeSinifi]) VALUES (1, N'karagiler a.ş', N'serik', N'kaş', N'58', N'samet akın', N'666699         ', N'14        ', N'www.karagiler.com', N'58', 1)
INSERT [dbo].[Ureticiler] ([UreticiId], [UreticiAdi], [UreticiAdresi], [UreticiVergiDairesi], [UreticiVergiNo], [UreticiYetkiliAdi], [UreticiYetkiliTelefon], [UreticiYetkiliDahili], [UreticiWebAdresi], [UreticiMersisNo], [UreticiTehlikeSinifi]) VALUES (2, N'mavigiler a.ş', N'idil ', N'idil', N'96', N'abdullah', N'98574          ', N'12        ', N'www.apolex.com', N'69', 2)
SET IDENTITY_INSERT [dbo].[Ureticiler] OFF
SET IDENTITY_INSERT [dbo].[Yuzeyler] ON 

INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (1, N'Mermer', 1, 0, 0, N'Test Verisi', N'images/Mermer.jpg')
INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (2, N'Tahta', 1, 0, 0, N'Ahşap .... dskfsjdf', N'Images/ahsap.jpg')
INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (6, N'Halı', 1, 1, 0, N'Halı Döşeme', N'images/hali.jpg')
INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (2002, N'Perde33333', 0, 0, 0, N'Kadife Perde 333', N'images/perde.jpg')
INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (2006, N'ewewq', 0, 0, 0, N'weqwe', N'images/mopsil.png')
INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (2008, N'duvar', 1, 1, 1, N'store perde', N'images/Ekran görüntüsü 2022-03-10 210656.jpg.png')
INSERT [dbo].[Yuzeyler] ([YuzeyId], [YuzeyAdi], [SertZemin], [Tekstil], [Antika], [Aciklama], [ResimYol]) VALUES (2009, N'duvar', 0, 0, 0, N'store perde', N'../images/Ekran Görüntüsü (6).png')
SET IDENTITY_INSERT [dbo].[Yuzeyler] OFF
ALTER TABLE [dbo].[BolumDonanimlari]  WITH CHECK ADD  CONSTRAINT [FK_BolumDonanimlari_Donanimlar] FOREIGN KEY([DonanimId])
REFERENCES [dbo].[Donanimlar] ([DonanimId])
GO
ALTER TABLE [dbo].[BolumDonanimlari] CHECK CONSTRAINT [FK_BolumDonanimlari_Donanimlar]
GO
ALTER TABLE [dbo].[BolumDonanimlari]  WITH CHECK ADD  CONSTRAINT [FK_BolumDonanimlari_ProjeBolumleri] FOREIGN KEY([PBId])
REFERENCES [dbo].[ProjeBolumleri] ([PBId])
GO
ALTER TABLE [dbo].[BolumDonanimlari] CHECK CONSTRAINT [FK_BolumDonanimlari_ProjeBolumleri]
GO
ALTER TABLE [dbo].[Bolumler]  WITH CHECK ADD  CONSTRAINT [FK_Bolumler_BolumlerTipleri] FOREIGN KEY([BolumTipId])
REFERENCES [dbo].[BolumTipleri] ([BolumTipId])
GO
ALTER TABLE [dbo].[Bolumler] CHECK CONSTRAINT [FK_Bolumler_BolumlerTipleri]
GO
ALTER TABLE [dbo].[FiyatListesi]  WITH CHECK ADD  CONSTRAINT [FK_FiyatListesi_Birimler] FOREIGN KEY([BirimId])
REFERENCES [dbo].[Birimler] ([BirimId])
GO
ALTER TABLE [dbo].[FiyatListesi] CHECK CONSTRAINT [FK_FiyatListesi_Birimler]
GO
ALTER TABLE [dbo].[Kimyasallar]  WITH CHECK ADD  CONSTRAINT [FK_Kimyasallar_Ureticiler] FOREIGN KEY([UreticiId])
REFERENCES [dbo].[Ureticiler] ([UreticiId])
GO
ALTER TABLE [dbo].[Kimyasallar] CHECK CONSTRAINT [FK_Kimyasallar_Ureticiler]
GO
ALTER TABLE [dbo].[Malzemeler]  WITH CHECK ADD  CONSTRAINT [FK_Malzemeler_Birimler] FOREIGN KEY([BirimId])
REFERENCES [dbo].[Birimler] ([BirimId])
GO
ALTER TABLE [dbo].[Malzemeler] CHECK CONSTRAINT [FK_Malzemeler_Birimler]
GO
ALTER TABLE [dbo].[Malzemeler]  WITH CHECK ADD  CONSTRAINT [FK_Malzemeler_Ureticiler] FOREIGN KEY([UreticiId])
REFERENCES [dbo].[Ureticiler] ([UreticiId])
GO
ALTER TABLE [dbo].[Malzemeler] CHECK CONSTRAINT [FK_Malzemeler_Ureticiler]
GO
ALTER TABLE [dbo].[MusteriHareketleri]  WITH CHECK ADD  CONSTRAINT [FK_MusteriHareketleri_Musteriler] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteriler] ([MusteriId])
GO
ALTER TABLE [dbo].[MusteriHareketleri] CHECK CONSTRAINT [FK_MusteriHareketleri_Musteriler]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Meslekler] FOREIGN KEY([MeslekId])
REFERENCES [dbo].[Meslekler] ([MeslekId])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Meslekler]
GO
ALTER TABLE [dbo].[ProjeBinalari]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBinalari_BinaTipleri] FOREIGN KEY([BinaTipId])
REFERENCES [dbo].[BinaTipleri] ([BinaTipId])
GO
ALTER TABLE [dbo].[ProjeBinalari] CHECK CONSTRAINT [FK_ProjeBinalari_BinaTipleri]
GO
ALTER TABLE [dbo].[ProjeBinalari]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBinalari_Personel] FOREIGN KEY([BinaPersonelId])
REFERENCES [dbo].[Personel] ([PersonelId])
GO
ALTER TABLE [dbo].[ProjeBinalari] CHECK CONSTRAINT [FK_ProjeBinalari_Personel]
GO
ALTER TABLE [dbo].[ProjeBinalari]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBinalari_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjeBinalari] CHECK CONSTRAINT [FK_ProjeBinalari_Projeler]
GO
ALTER TABLE [dbo].[ProjeBolumleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBolumleri_Bolumler] FOREIGN KEY([PBolumID])
REFERENCES [dbo].[Bolumler] ([BolumId])
GO
ALTER TABLE [dbo].[ProjeBolumleri] CHECK CONSTRAINT [FK_ProjeBolumleri_Bolumler]
GO
ALTER TABLE [dbo].[ProjeBolumTamamlama]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBolumTamamlama_Bolumler] FOREIGN KEY([BolumId])
REFERENCES [dbo].[Bolumler] ([BolumId])
GO
ALTER TABLE [dbo].[ProjeBolumTamamlama] CHECK CONSTRAINT [FK_ProjeBolumTamamlama_Bolumler]
GO
ALTER TABLE [dbo].[ProjeBolumTamamlama]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBolumTamamlama_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([PersonelId])
GO
ALTER TABLE [dbo].[ProjeBolumTamamlama] CHECK CONSTRAINT [FK_ProjeBolumTamamlama_Personel]
GO
ALTER TABLE [dbo].[ProjeBolumTamamlama]  WITH CHECK ADD  CONSTRAINT [FK_ProjeBolumTamamlama_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjeBolumTamamlama] CHECK CONSTRAINT [FK_ProjeBolumTamamlama_Projeler]
GO
ALTER TABLE [dbo].[ProjeDonanimTamamlama]  WITH CHECK ADD  CONSTRAINT [FK_ProjeDonanimTamamlama_Donanimlar] FOREIGN KEY([DonanimId])
REFERENCES [dbo].[Donanimlar] ([DonanimId])
GO
ALTER TABLE [dbo].[ProjeDonanimTamamlama] CHECK CONSTRAINT [FK_ProjeDonanimTamamlama_Donanimlar]
GO
ALTER TABLE [dbo].[ProjeDonanimTamamlama]  WITH CHECK ADD  CONSTRAINT [FK_ProjeDonanimTamamlama_ProjeBolumTamamlama] FOREIGN KEY([PKontrolId])
REFERENCES [dbo].[ProjeBolumTamamlama] ([PKontrolId])
GO
ALTER TABLE [dbo].[ProjeDonanimTamamlama] CHECK CONSTRAINT [FK_ProjeDonanimTamamlama_ProjeBolumTamamlama]
GO
ALTER TABLE [dbo].[ProjeKimyasallari]  WITH CHECK ADD  CONSTRAINT [FK_ProjeKimyallari_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjeKimyasallari] CHECK CONSTRAINT [FK_ProjeKimyallari_Projeler]
GO
ALTER TABLE [dbo].[ProjeKimyasallari]  WITH CHECK ADD  CONSTRAINT [FK_ProjeKimyasallari_Birimler] FOREIGN KEY([BirimId])
REFERENCES [dbo].[Birimler] ([BirimId])
GO
ALTER TABLE [dbo].[ProjeKimyasallari] CHECK CONSTRAINT [FK_ProjeKimyasallari_Birimler]
GO
ALTER TABLE [dbo].[ProjeKimyasallari]  WITH CHECK ADD  CONSTRAINT [FK_ProjeKimyasallari_Kimyasallar] FOREIGN KEY([KimyasalId])
REFERENCES [dbo].[Kimyasallar] ([Kimyasalld])
GO
ALTER TABLE [dbo].[ProjeKimyasallari] CHECK CONSTRAINT [FK_ProjeKimyasallari_Kimyasallar]
GO
ALTER TABLE [dbo].[Projeler]  WITH CHECK ADD  CONSTRAINT [FK_Projeler_Musteriler] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteriler] ([MusteriId])
GO
ALTER TABLE [dbo].[Projeler] CHECK CONSTRAINT [FK_Projeler_Musteriler]
GO
ALTER TABLE [dbo].[ProjeMakineleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjeMakineleri_Makineler] FOREIGN KEY([MakineId])
REFERENCES [dbo].[Makineler] ([MakineId])
GO
ALTER TABLE [dbo].[ProjeMakineleri] CHECK CONSTRAINT [FK_ProjeMakineleri_Makineler]
GO
ALTER TABLE [dbo].[ProjeMakineleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjeMakineleri_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjeMakineleri] CHECK CONSTRAINT [FK_ProjeMakineleri_Projeler]
GO
ALTER TABLE [dbo].[ProjeMalzemeleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjeMalzemeleri_Malzemeler] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzemeler] ([MalzemeId])
GO
ALTER TABLE [dbo].[ProjeMalzemeleri] CHECK CONSTRAINT [FK_ProjeMalzemeleri_Malzemeler]
GO
ALTER TABLE [dbo].[ProjeMalzemeleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjeMalzemeleri_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjeMalzemeleri] CHECK CONSTRAINT [FK_ProjeMalzemeleri_Projeler]
GO
ALTER TABLE [dbo].[ProjePersonelleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjePersonelleri_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([PersonelId])
GO
ALTER TABLE [dbo].[ProjePersonelleri] CHECK CONSTRAINT [FK_ProjePersonelleri_Personel]
GO
ALTER TABLE [dbo].[ProjePersonelleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjePersonelleri_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjePersonelleri] CHECK CONSTRAINT [FK_ProjePersonelleri_Projeler]
GO
ALTER TABLE [dbo].[ProjeTeklifleri]  WITH CHECK ADD  CONSTRAINT [FK_ProjeTeklifleri_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[ProjeTeklifleri] CHECK CONSTRAINT [FK_ProjeTeklifleri_Projeler]
GO
ALTER TABLE [dbo].[StokHareketleri]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleri_Birimler] FOREIGN KEY([BirimId])
REFERENCES [dbo].[Birimler] ([BirimId])
GO
ALTER TABLE [dbo].[StokHareketleri] CHECK CONSTRAINT [FK_StokHareketleri_Birimler]
GO
ALTER TABLE [dbo].[StokHareketleri]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleri_Malzemeler] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzemeler] ([MalzemeId])
GO
ALTER TABLE [dbo].[StokHareketleri] CHECK CONSTRAINT [FK_StokHareketleri_Malzemeler]
GO
ALTER TABLE [dbo].[StokHareketleri]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleri_Projeler] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[Projeler] ([ProjeId])
GO
ALTER TABLE [dbo].[StokHareketleri] CHECK CONSTRAINT [FK_StokHareketleri_Projeler]
GO
ALTER TABLE [dbo].[StokHareketleri]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleri_Ureticiler] FOREIGN KEY([UreticiId])
REFERENCES [dbo].[Ureticiler] ([UreticiId])
GO
ALTER TABLE [dbo].[StokHareketleri] CHECK CONSTRAINT [FK_StokHareketleri_Ureticiler]
GO
ALTER TABLE [dbo].[UreticiHareketleri]  WITH CHECK ADD  CONSTRAINT [FK_UreticiHareketleri_Ureticiler] FOREIGN KEY([UreticiId])
REFERENCES [dbo].[Ureticiler] ([UreticiId])
GO
ALTER TABLE [dbo].[UreticiHareketleri] CHECK CONSTRAINT [FK_UreticiHareketleri_Ureticiler]
GO
ALTER TABLE [dbo].[YuzeyStandartlari]  WITH CHECK ADD  CONSTRAINT [FK_YuzeyStandartlari_Yuzeyler] FOREIGN KEY([YId])
REFERENCES [dbo].[Yuzeyler] ([YuzeyId])
GO
ALTER TABLE [dbo].[YuzeyStandartlari] CHECK CONSTRAINT [FK_YuzeyStandartlari_Yuzeyler]
GO
