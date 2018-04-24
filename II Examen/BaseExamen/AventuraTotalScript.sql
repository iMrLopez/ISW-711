CREATE TABLE [dbo].[Paquete](
	[idPaquete] [int] NOT NULL,
	[nombre] [nvarchar](200) NULL,
	[incluye] [text] NULL,
	[checkin] [nvarchar](5) NULL,
	[checkout] [nvarchar](5) NULL,
	[cantidadPersonas] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[personaExtra] [decimal](18, 0) NULL,
 CONSTRAINT [PK_paquete] PRIMARY KEY CLUSTERED 
(
	[idPaquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tour]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tour](
	[idTour] [int] NOT NULL,
	[idPaquete] [int] NOT NULL,
	[idCliente] [varchar](20) NOT NULL,
	[fecha] [date] NOT NULL,
	[cantidadPersonasExtra] [int] NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_tour] PRIMARY KEY CLUSTERED 
(
	[idTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

INSERT [dbo].[paquete] ([idPaquete], [nombre], [incluye], [checkin], [checkout], [cantidadPersonas], [precio], [personaExtra]) VALUES (1, 'Caño Negro', '2 días, 1 noche Cabaña Rústica: cama king size, baño completo, balcón', '14:00', '12:00', 2, CAST(1000 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)))
GO
INSERT [dbo].[paquete] ([idPaquete], [nombre], [incluye], [checkin], [checkout], [cantidadPersonas], [precio], [personaExtra]) VALUES (2, 'Paquete extremo Mont VErde', '2 días, 1 noche Cabaña Rústica: cama king size, baño completo, balcón Comidas típicas de la región: comida, cena y desayuno. Estacionamiento y vigilancia las 24 hrs.', '14:00', '12:00', 2, CAST(2500 AS Decimal(18, 0)), CAST(1300 AS Decimal(18, 0)))
GO
INSERT [dbo].[paquete] ([idPaquete], [nombre], [incluye], [checkin], [checkout], [cantidadPersonas], [precio], [personaExtra]) VALUES (3, 'Paquete Camping Selva Verde', '2 días, 1 noche Zona de Acampar, Baños, Regaderas, Vestidores, Asadores Estacionamietno y vigilancia las 24 hrs. Extra: Tienda de Campaña', '8', '18', 2, CAST(500 AS Decimal(18, 0)), CAST(130 AS Decimal(18, 0)))
GO
INSERT [dbo].[tour] ([idTour], [idPaquete], [idCliente], [fecha], [cantidadPersonasExtra], [total]) VALUES (1, 2, '325', CAST('2018-04-09' AS Date), 2, CAST(5500 AS Decimal(18, 0)))
GO
INSERT [dbo].[tour] ([idTour], [idPaquete], [idCliente], [fecha], [cantidadPersonasExtra], [total]) VALUES (2, 1, '554', CAST('2018-04-20' AS Date), 0, CAST(2570 AS Decimal(18, 0)))
GO
INSERT [dbo].[tour] ([idTour], [idPaquete], [idCliente], [fecha], [cantidadPersonasExtra], [total]) VALUES (3, 3, '655', CAST('2018-04-26' AS Date), 0, CAST(500 AS Decimal(18, 0)))
GO
INSERT [dbo].[tour] ([idTour], [idPaquete], [idCliente], [fecha], [cantidadPersonasExtra], [total]) VALUES (4, 2, '7382', CAST('2018-05-20' AS Date), 2, CAST(5500 AS Decimal(18, 0)))
GO
INSERT [dbo].[tour] ([idTour], [idPaquete], [idCliente], [fecha], [cantidadPersonasExtra], [total]) VALUES (5, 1, '4507', CAST('2018-04-18' AS Date), 0, CAST(1070 AS Decimal(18, 0)))
GO
INSERT [dbo].[tour] ([idTour], [idPaquete], [idCliente], [fecha], [cantidadPersonasExtra], [total]) VALUES (6, 3, '832', CAST('2018-04-15' AS Date), 2, CAST(1100 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[tour] OFF
GO
ALTER TABLE [dbo].[tour]  WITH CHECK ADD  CONSTRAINT [FK_tour_paquete] FOREIGN KEY([idPaquete])
REFERENCES [dbo].[paquete] ([idPaquete])
GO
ALTER TABLE [dbo].[tour] CHECK CONSTRAINT [FK_tour_paquete]
GO
USE [master]
GO
ALTER DATABASE [paquetes_at] SET  READ_WRITE 
GO