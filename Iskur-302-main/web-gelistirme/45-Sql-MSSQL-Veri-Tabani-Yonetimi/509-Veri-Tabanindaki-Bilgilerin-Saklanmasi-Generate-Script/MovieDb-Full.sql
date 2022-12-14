USE [MovieDb]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](45) NOT NULL,
	[Surname] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](45) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Duration] [nvarchar](10) NULL,
	[ImageUrl] [nvarchar](45) NULL,
	[Trailer] [nvarchar](45) NULL,
	[DirectorId] [int] NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie_Category]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Category](
	[MovieId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Movie_Category] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie_Star]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Star](
	[MovieId] [int] NOT NULL,
	[StarId] [int] NOT NULL,
 CONSTRAINT [PK_Movie_Star] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC,
	[StarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieDetail]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieDetail](
	[Id] [int] NOT NULL,
	[Country] [nvarchar](45) NOT NULL,
	[Publish_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_MovieDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Star]    Script Date: 23.10.2022 14:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Star](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](45) NOT NULL,
	[Surname] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_Star] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Macera')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Romantik')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Bilim Kurgu')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Korku')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Director] ON 

INSERT [dbo].[Director] ([Id], [Name], [Surname]) VALUES (1, N'Yönetmen1', N'YönetmenSurname1')
INSERT [dbo].[Director] ([Id], [Name], [Surname]) VALUES (4, N'Yönetmen2', N'YönetmenSurname2')
SET IDENTITY_INSERT [dbo].[Director] OFF
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([Id], [Name], [Description], [Duration], [ImageUrl], [Trailer], [DirectorId]) VALUES (1, N'Film 1', N'Film 1 Açıklama', N'120', N'1.jpg', N'1.mp4', 1)
INSERT [dbo].[Movie] ([Id], [Name], [Description], [Duration], [ImageUrl], [Trailer], [DirectorId]) VALUES (2, N'Film 2', N'Film 2 Açıklama', N'90', N'2.jpg', N'2.mp4', 4)
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (1, 1)
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (1, 3)
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (2, 1)
GO
INSERT [dbo].[Movie_Star] ([MovieId], [StarId]) VALUES (1, 1)
INSERT [dbo].[Movie_Star] ([MovieId], [StarId]) VALUES (1, 2)
INSERT [dbo].[Movie_Star] ([MovieId], [StarId]) VALUES (2, 1)
GO
INSERT [dbo].[MovieDetail] ([Id], [Country], [Publish_Date]) VALUES (1, N'Türkiye', CAST(N'2022-10-23T14:16:00.770' AS DateTime))
INSERT [dbo].[MovieDetail] ([Id], [Country], [Publish_Date]) VALUES (2, N'Türkiye', CAST(N'2020-10-01T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Star] ON 

INSERT [dbo].[Star] ([Id], [Name], [Surname]) VALUES (1, N'Oyuncu 1', N'Oyuncu1Surname')
INSERT [dbo].[Star] ([Id], [Name], [Surname]) VALUES (2, N'Oyuncu 2', N'Oyuncu2Surname')
SET IDENTITY_INSERT [dbo].[Star] OFF
GO
ALTER TABLE [dbo].[MovieDetail] ADD  CONSTRAINT [DF_MovieDetail_Publish_Date]  DEFAULT (getdate()) FOR [Publish_Date]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Director] FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Director] ([Id])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Director]
GO
ALTER TABLE [dbo].[Movie_Category]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Category_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Movie_Category] CHECK CONSTRAINT [FK_Movie_Category_Category]
GO
ALTER TABLE [dbo].[Movie_Category]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Category_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[Movie_Category] CHECK CONSTRAINT [FK_Movie_Category_Movie]
GO
ALTER TABLE [dbo].[Movie_Star]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Star_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[Movie_Star] CHECK CONSTRAINT [FK_Movie_Star_Movie]
GO
ALTER TABLE [dbo].[Movie_Star]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Star_Star] FOREIGN KEY([StarId])
REFERENCES [dbo].[Star] ([Id])
GO
ALTER TABLE [dbo].[Movie_Star] CHECK CONSTRAINT [FK_Movie_Star_Star]
GO
ALTER TABLE [dbo].[MovieDetail]  WITH CHECK ADD  CONSTRAINT [FK_MovieDetail_Movie] FOREIGN KEY([Id])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[MovieDetail] CHECK CONSTRAINT [FK_MovieDetail_Movie]
GO
