
CREATE TABLE [dbo].[TBL_Departman](
	[Departman_Id] [int] IDENTITY(1,1) NOT NULL,
	[Muhasebe] [nvarchar](50) NOT NULL,
	[Vezne] [nvarchar](50) NOT NULL,
	[Arge] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Departman] PRIMARY KEY CLUSTERED 
(
	[Departman_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Doktor]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Doktor](
	[Doktor_Id] [int] IDENTITY(1,1) NOT NULL,
	[Doktor_Adi] [nvarchar](50) NOT NULL,
	[Doktor_Soyadi] [nvarchar](50) NOT NULL,
	[Doktor_Tc] [nvarchar](50) NOT NULL,
	[Doktor_Brans] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Doktor] PRIMARY KEY CLUSTERED 
(
	[Doktor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_HastaBilgileri]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_HastaBilgileri](
	[Hasta_Id] [int] IDENTITY(1,1) NOT NULL,
	[Hasta_Adi] [nvarchar](50) NOT NULL,
	[Hasta_Soyadi] [nvarchar](50) NOT NULL,
	[Hasta_Tc] [nchar](11) NOT NULL,
	[Hasta_Adress] [nvarchar](50) NULL,
	[Hasta_Tel] [nchar](11) NOT NULL,
 CONSTRAINT [PK_TBL_HastaBilgileri] PRIMARY KEY CLUSTERED 
(
	[Hasta_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Hastane]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Hastane](
	[Hastane_Id] [int] IDENTITY(1,1) NOT NULL,
	[Hastane_No] [int] NULL,
	[Hastane_Adi] [nchar](10) NULL,
	[Hastane_Adres] [nchar](10) NULL,
	[Hastane_Tel] [nchar](10) NULL,
 CONSTRAINT [PK_TBL_Hastane] PRIMARY KEY CLUSTERED 
(
	[Hastane_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Poliklinikler]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Poliklinikler](
	[Poliklinik_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cildiye] [nvarchar](50) NOT NULL,
	[BeslenmeveDiyet] [nvarchar](50) NOT NULL,
	[FizikTedaviveRehabilitasyon] [nvarchar](50) NOT NULL,
	[BeyinveSinirCerrahisi] [nvarchar](50) NOT NULL,
	[Gastroenteroloji] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Poliklinikler] PRIMARY KEY CLUSTERED 
(
	[Poliklinik_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Randevu]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Randevu](
	[Randevu_Id] [int] IDENTITY(1,1) NOT NULL,
	[Randevu_Tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_TBL_Randevu] PRIMARY KEY CLUSTERED 
(
	[Randevu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Teshis]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Teshis](
	[Teshis_Id] [int] IDENTITY(1,1) NOT NULL,
	[Hasta_Tc] [nchar](11) NOT NULL,
	[Doktor_Sicil] [nchar](11) NOT NULL,
	[Teshis] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Teshis] PRIMARY KEY CLUSTERED 
(
	[Teshis_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Vezne]    Script Date: 10.10.2022 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Vezne](
	[Vezne Id] [int] IDENTITY(1,1) NOT NULL,
	[Vezne] [nvarchar](50) NOT NULL,
	[Alinan_Para] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_Vezne] PRIMARY KEY CLUSTERED 
(
	[Vezne Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBL_Hastane]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Hastane_TBL_HastaBilgileri] FOREIGN KEY([Hastane_Id])
REFERENCES [dbo].[TBL_HastaBilgileri] ([Hasta_Id])
GO
ALTER TABLE [dbo].[TBL_Hastane] CHECK CONSTRAINT [FK_TBL_Hastane_TBL_HastaBilgileri]
GO
ALTER TABLE [dbo].[TBL_Hastane]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Hastane_TBL_Poliklinikler] FOREIGN KEY([Hastane_Id])
REFERENCES [dbo].[TBL_Poliklinikler] ([Poliklinik_Id])
GO
ALTER TABLE [dbo].[TBL_Hastane] CHECK CONSTRAINT [FK_TBL_Hastane_TBL_Poliklinikler]
GO
