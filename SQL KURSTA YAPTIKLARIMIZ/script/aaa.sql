
CREATE TABLE [dbo].[Dersler](
	[DersNo] [int] NULL,
	[DersKodu] [char](11) NULL,
	[DersAdı] [varchar](20) NULL,
	[DersKredisi] [int] NULL,
	[DersAKTS] [int] NULL,
	[DersAciklama] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hocalar]    Script Date: 10.10.2022 14:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hocalar](
	[HocaNo] [int] NULL,
	[HocaAdı] [nvarchar](20) NULL,
	[HocaBolum] [nvarchar](15) NULL,
	[HocaAdres] [text] NULL,
	[HocaMaas] [money] NULL,
	[HocaİseBaslama] [datetime] NULL,
	[HocaBoy] [decimal](18, 0) NULL,
	[Hocakilo] [varchar](20) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 10.10.2022 14:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[OgrenciNo] [int] NULL,
	[OgrenciAdsoyad] [varchar](50) NULL,
	[tcNo] [char](11) NULL,
	[ailesırano] [nchar](11) NULL,
	[telno] [char](11) NULL,
	[yas] [int] NULL,
	[adres] [text] NULL,
	[cinsiyet] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
