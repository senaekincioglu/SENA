USE [Kitaplik]
GO
/****** Object:  Table [dbo].[TBL_Kitap]    Script Date: 16.10.2022 09:55:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Kitap](
	[KitapNo] [int] NULL,
	[KitapAd] [varchar](50) NULL,
	[KitapYazar] [varchar](50) NULL,
	[KitapSayfa] [smallint] NULL,
	[KitapFiyat] [int] NULL,
	[KitapTarih] [date] NULL,
	[KitapYayınEvi] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[TBL_Kitap] ([KitapNo], [KitapAd], [KitapYazar], [KitapSayfa], [KitapFiyat], [KitapTarih], [KitapYayınEvi]) VALUES (1, N'Çalışkuşu', N'Reşat Nuri Güntekin', 200, 10, CAST(N'2015-01-05' AS Date), N'Güneş ')
INSERT [dbo].[TBL_Kitap] ([KitapNo], [KitapAd], [KitapYazar], [KitapSayfa], [KitapFiyat], [KitapTarih], [KitapYayınEvi]) VALUES (2, N'Palto', N'Gogol', 80, 5, CAST(N'2015-01-08' AS Date), N'Yıldız')
INSERT [dbo].[TBL_Kitap] ([KitapNo], [KitapAd], [KitapYazar], [KitapSayfa], [KitapFiyat], [KitapTarih], [KitapYayınEvi]) VALUES (3, N'Son Ada', N'Zülfü Linaveli', 300, 12, CAST(N'2015-02-08' AS Date), N'Yıldız')
INSERT [dbo].[TBL_Kitap] ([KitapNo], [KitapAd], [KitapYazar], [KitapSayfa], [KitapFiyat], [KitapTarih], [KitapYayınEvi]) VALUES (4, N'Toros Canavarı', N'Aziz Nesin', 75, 6, CAST(N'2015-03-03' AS Date), N'Merkür')
INSERT [dbo].[TBL_Kitap] ([KitapNo], [KitapAd], [KitapYazar], [KitapSayfa], [KitapFiyat], [KitapTarih], [KitapYayınEvi]) VALUES (5, N'Siyah Lale', N'Alexander Duman', 220, 7, CAST(N'2015-05-05' AS Date), N'Jüpiter')
INSERT [dbo].[TBL_Kitap] ([KitapNo], [KitapAd], [KitapYazar], [KitapSayfa], [KitapFiyat], [KitapTarih], [KitapYayınEvi]) VALUES (6, N'Beyaz Zambaklar Ülkesinde', N'Grigory Petrov', 210, 5, CAST(N'2015-04-08' AS Date), N'Ay')
GO
