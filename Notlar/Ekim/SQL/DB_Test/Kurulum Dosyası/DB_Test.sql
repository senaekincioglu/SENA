USE [master]
GO
/****** Object:  Database [DB_Test]    Script Date: 14.10.2022 14:06:30 ******/
CREATE DATABASE [DB_Test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\DB_Test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\DB_Test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DB_Test] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Test] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_Test] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Test] SET QUERY_STORE = OFF
GO
USE [DB_Test]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DB_Test]
GO
/****** Object:  Table [dbo].[tb_ogrenci]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ogrenci](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[tc] [nvarchar](50) NULL,
	[sinifID] [tinyint] NULL,
	[ogretmenID] [tinyint] NULL,
	[dogumYili] [smallint] NULL,
	[cinsiyet] [bit] NULL,
 CONSTRAINT [PK_tb_ogrenci] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Ogretmen]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Ogretmen](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[alan] [tinyint] NULL,
 CONSTRAINT [PK_tb_Ogretmen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[OgrenciOgretmen]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create VIEW [dbo].[OgrenciOgretmen] as
select o.ad+' '+o.soyad as Ogrenci,
m.ad+' '+m.soyad as Ogretmen
from tb_ogrenci o
INNER JOIN tb_Ogretmen m
ON M.ID=o.ogretmenID
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciID] [int] NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[KullaniciAd] [varchar](20) NULL,
 CONSTRAINT [PKC_KullaniciID] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenci]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenci](
	[ogrenci_no] [int] NULL,
	[ogrenci_ad] [varchar](20) NULL,
	[ogrenci_soyad] [varchar](20) NULL,
	[ogrenci_sehir] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[KullaniciID] [varchar](20) NOT NULL,
	[Email] [varchar](50) NULL,
	[Adres] [varchar](255) NULL,
	[Sehir] [varchar](50) NULL,
	[KayitTarihi] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_alan]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_alan](
	[ad] [nchar](50) NOT NULL,
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tb_alan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_sinif]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_sinif](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](10) NOT NULL,
	[kat] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_sinif] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[temp]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temp](
	[a] [varchar](80) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ogrenci] ([ogrenci_no], [ogrenci_ad], [ogrenci_soyad], [ogrenci_sehir]) VALUES (1, N'Veysel', N'Peru', N'Sivas')
INSERT [dbo].[ogrenci] ([ogrenci_no], [ogrenci_ad], [ogrenci_soyad], [ogrenci_sehir]) VALUES (2, N'Aysel', N'Temiz', N'Ankara')
INSERT [dbo].[ogrenci] ([ogrenci_no], [ogrenci_ad], [ogrenci_soyad], [ogrenci_sehir]) VALUES (15, N'Huseyin', N'Aktar', N'Yozgat')
INSERT [dbo].[ogrenci] ([ogrenci_no], [ogrenci_ad], [ogrenci_soyad], [ogrenci_sehir]) VALUES (452, N'Kerem', N'Perü', N'Istanbul')
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (1, N'Veysel', N'Perü', N'VP', N'vp@vp.com', N'dasdsasadsada', N'İstanbul', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (2, N'Ahmet', N'Temiz', N'AT', N'at@at.com', N'Fatih', N'İstanbul', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (3, N'Rüstem ', N'Karayel', N'RK', N'rk@rk.com', N'Kaynarca', N'İstanbul', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (4, N'Arda', N'Taş', N'AT', N'at2@at.com', N'Fatih', N'dsaadsad', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (5, N'Ramazan', N'Kaya', N'RK', N'rk2@rk.com', N'Fatih', N'sadsad', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (7, N'Vahap', N'Pars', N'VP', N'vp2@vp.com', N'sds', N'adsadasda', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (10, N'Ahmet', N'Taş', N'At', N'at26@at.com', N'dsdadsa', N'sdas', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (11, N'Recep', N'Kul', N'RK', N'rkk@rkk.com', N'dsadada', N'sdsada', NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (12, N'Batuhan', N'Akbulut', N'BK', N'bk@bk.com', N'assadas', N'dsadg', CAST(N'2022-10-13T09:28:00' AS SmallDateTime))
INSERT [dbo].[Personeller] ([PersonelID], [Ad], [Soyad], [KullaniciID], [Email], [Adres], [Sehir], [KayitTarihi]) VALUES (13, N'Kasım', N'Aslan', N'KA', N'ka@ka.com', N'asdsadsad', N'dasdsa', CAST(N'2022-10-13T09:33:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Personeller] OFF
SET IDENTITY_INSERT [dbo].[tb_alan] ON 

INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Bilgisayar                                        ', 1)
INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Kimya                                             ', 2)
INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Biyoloji                                          ', 3)
INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Fizik                                             ', 4)
INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Elektrik&Elektronik                               ', 5)
INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Metalurji                                         ', 6)
INSERT [dbo].[tb_alan] ([ad], [ID]) VALUES (N'Raylı Sistemler Mühendisliği                      ', 7)
SET IDENTITY_INSERT [dbo].[tb_alan] OFF
SET IDENTITY_INSERT [dbo].[tb_ogrenci] ON 

INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (1, N'Veysel', N'Bakır', N'111', N'111', 1, 1, 1990, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (2, N'Terry', N'Merry', N'333', N'333', 2, 2, 1991, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (5, N'Özge', N'Tunç', N'2233', N'3344', 3, 3, 1990, 0)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (6, N'Ela', N'Ala', N'23234', N'34345', 1, 66, 1991, 0)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (7, N'Nuran', N'Demir', N'1212', N'2121', 2, 2, 1990, 0)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (8, N'Faik', N'Çelik', N'556', N'556', 3, 3, 1990, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (9, N'Selim', N'GÜR', NULL, NULL, 1, 1, 1990, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (10, N'Hercai', N'KILIÇ', NULL, NULL, 1, 2, 1980, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (11, N'Mürsel', N'TORBA', NULL, NULL, 2, 3, 1997, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (12, N'Hüsmen', N'ÇORBA', NULL, NULL, 3, 2, 1995, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (13, N'Tekin', N'Yılmaz', N'5321211212', N'67309105720', NULL, NULL, NULL, 1)
INSERT [dbo].[tb_ogrenci] ([ID], [ad], [soyad], [telefon], [tc], [sinifID], [ogretmenID], [dogumYili], [cinsiyet]) VALUES (14, N'Salih', N'Atmaca', N'532 4545667', N'65656565656', NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_ogrenci] OFF
SET IDENTITY_INSERT [dbo].[tb_Ogretmen] ON 

INSERT [dbo].[tb_Ogretmen] ([ID], [ad], [soyad], [telefon], [alan]) VALUES (1, N'Süreyya', N'Kaçar', N'05321000000', 1)
INSERT [dbo].[tb_Ogretmen] ([ID], [ad], [soyad], [telefon], [alan]) VALUES (2, N'Necla ', N'Keser', N'05322000000', 2)
INSERT [dbo].[tb_Ogretmen] ([ID], [ad], [soyad], [telefon], [alan]) VALUES (3, N'Süha', N'Gezer', N'05323000000', 3)
INSERT [dbo].[tb_Ogretmen] ([ID], [ad], [soyad], [telefon], [alan]) VALUES (5, N'Meliha', N'Delice', N'05325000000', 5)
INSERT [dbo].[tb_Ogretmen] ([ID], [ad], [soyad], [telefon], [alan]) VALUES (6, N'Dursun', N'Sadık', N'05325000000', 4)
INSERT [dbo].[tb_Ogretmen] ([ID], [ad], [soyad], [telefon], [alan]) VALUES (7, N'Mehmet', N'Gürses', N'05326000000', 3)
SET IDENTITY_INSERT [dbo].[tb_Ogretmen] OFF
SET IDENTITY_INSERT [dbo].[tb_sinif] ON 

INSERT [dbo].[tb_sinif] ([ID], [ad], [kat]) VALUES (1, N'd101      ', 1)
INSERT [dbo].[tb_sinif] ([ID], [ad], [kat]) VALUES (2, N'd102      ', 1)
INSERT [dbo].[tb_sinif] ([ID], [ad], [kat]) VALUES (3, N'd203      ', 2)
INSERT [dbo].[tb_sinif] ([ID], [ad], [kat]) VALUES (4, N'd303      ', 3)
SET IDENTITY_INSERT [dbo].[tb_sinif] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_PersonelEmail]    Script Date: 14.10.2022 14:06:30 ******/
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [UQ_PersonelEmail] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PersonelID]    Script Date: 14.10.2022 14:06:30 ******/
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [UQ_PersonelID] UNIQUE NONCLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Personeller] ADD  DEFAULT (getdate()) FOR [KayitTarihi]
GO
ALTER TABLE [dbo].[tb_ogrenci] ADD  CONSTRAINT [DF_tb_ogrenci_cinsiyet]  DEFAULT ((1)) FOR [cinsiyet]
GO
/****** Object:  StoredProcedure [dbo].[SP_OgrenciEkle]    Script Date: 14.10.2022 14:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   Procedure [dbo].[SP_OgrenciEkle](
@ad varchar(50),
@soyad varchar(50),
@telefon varchar(50),
@tc varchar(50))
-- Exec SP_OgrenciEkle 'Tekin','Yılmaz','5321211212','67309105720'
AS
DECLARE @id bigint;
SELECT @id=ISNULL(MAX(ID),0) + 1 FROM tb_ogrenci;
INSERT INTO tb_ogrenci(ad,soyad,telefon,tc) VALUES (@ad,@soyad,@telefon,@tc)
SELECT MAX(ID) FROM tb_ogrenci

GO
USE [master]
GO
ALTER DATABASE [DB_Test] SET  READ_WRITE 
GO
