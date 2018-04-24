CREATE TABLE [dbo].[ordenDesayuno](
	[idOrdenDesayuno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[fecha] [date] NULL,
	[idDesayuno] [int] NULL,
	[total] [decimal](18, 0) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_ordenDesayuno] PRIMARY KEY CLUSTERED 
(
	[idOrdenDesayuno] ASC
)
)

GO

CREATE TABLE [dbo].[desayuno](
	[idDesayuno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[descripcion] [text] NULL,
	[precio8] [decimal](18, 0) NULL,
	[precio9] [decimal](18, 0) NULL,
 CONSTRAINT [PK_desayuno] PRIMARY KEY CLUSTERED 
(
	[idDesayuno] ASC
)
)

GO
SET IDENTITY_INSERT [dbo].[ordenDesayuno] ON 

GO
INSERT [dbo].[ordenDesayuno] ([idOrdenDesayuno], [nombre], [fecha], [idDesayuno],  [total], [cantidad]) VALUES (1, N'Andrey Quesada', CAST(N'2017-04-05' AS Date), 1,  CAST(14 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[ordenDesayuno] ([idOrdenDesayuno], [nombre], [fecha], [idDesayuno], [total], [cantidad]) VALUES (2, N'Gabriela Castro', CAST(N'2017-04-07' AS Date), 5,  CAST(30 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[ordenDesayuno] ([idOrdenDesayuno], [nombre], [fecha], [idDesayuno],  [total], [cantidad]) VALUES (3, N'Viviana Lor√≠a', CAST(N'2017-04-07' AS Date), 4,  CAST(28 AS Decimal(18, 0)), 4)
GO
INSERT [dbo].[ordenDesayuno] ([idOrdenDesayuno], [nombre], [fecha], [idDesayuno],  [total], [cantidad]) VALUES (4, N'Fernando Arias', CAST(N'2017-04-07' AS Date), 3,  CAST(28 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[ordenDesayuno] ([idOrdenDesayuno], [nombre], [fecha], [idDesayuno],  [total], [cantidad]) VALUES (5, N'Karla Guzman C.', CAST(N'2017-04-06' AS Date), 5, CAST(20 AS Decimal(18, 0)), 2)
GO
SET IDENTITY_INSERT [dbo].[ordenDesayuno] OFF
GO
SET IDENTITY_INSERT [dbo].[desayuno] ON 

GO
INSERT [dbo].[desayuno] ([idDesayuno], [nombre], [descripcion], [precio8], [precio9]) VALUES (1, N'B·sico', N'Pinto con huevos revueltos', CAST(7 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)))
GO
INSERT [dbo].[desayuno] ([idDesayuno], [nombre], [descripcion], [precio8], [precio9]) VALUES (2, N'Campesino', N'Pinto con huevos revueltos y dos porciones adicionales', CAST(8 AS Decimal(18, 0)), CAST(13 AS Decimal(18, 0)))
GO
INSERT [dbo].[desayuno] ([idDesayuno], [nombre], [descripcion], [precio8], [precio9]) VALUES (3, N'Ranchero', N'Pinto con huevos rancheros picante', CAST(9 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)))
GO
INSERT [dbo].[desayuno] ([idDesayuno], [nombre], [descripcion], [precio8], [precio9]) VALUES (4, N'Continental', N'Huevos y jamon', CAST(7 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)))
GO
INSERT [dbo].[desayuno] ([idDesayuno], [nombre], [descripcion], [precio8], [precio9]) VALUES (5, N'Europeo', N'Frutas de temporada', CAST(10 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[desayuno] OFF
GO
ALTER TABLE [dbo].[ordenDesayuno]  WITH CHECK ADD  CONSTRAINT [FK_ordenDesayuno_desayuno] FOREIGN KEY([idDesayuno])
REFERENCES [dbo].[desayuno] ([idDesayuno])
GO
ALTER TABLE [dbo].[ordenDesayuno] CHECK CONSTRAINT [FK_ordenDesayuno_desayuno]