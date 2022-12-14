USE [MovieDb]
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
SET IDENTITY_INSERT [dbo].[Star] ON 

INSERT [dbo].[Star] ([Id], [Name], [Surname]) VALUES (1, N'Oyuncu 1', N'Oyuncu1Surname')
INSERT [dbo].[Star] ([Id], [Name], [Surname]) VALUES (2, N'Oyuncu 2', N'Oyuncu2Surname')
SET IDENTITY_INSERT [dbo].[Star] OFF
GO
INSERT [dbo].[Movie_Star] ([MovieId], [StarId]) VALUES (1, 1)
INSERT [dbo].[Movie_Star] ([MovieId], [StarId]) VALUES (1, 2)
INSERT [dbo].[Movie_Star] ([MovieId], [StarId]) VALUES (2, 1)
GO
INSERT [dbo].[MovieDetail] ([Id], [Country], [Publish_Date]) VALUES (1, N'Türkiye', CAST(N'2022-10-23T14:16:00.770' AS DateTime))
INSERT [dbo].[MovieDetail] ([Id], [Country], [Publish_Date]) VALUES (2, N'Türkiye', CAST(N'2020-10-01T00:00:00.000' AS DateTime))
GO
