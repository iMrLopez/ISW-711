USE [master]
GO
/****** Object:  Database [prj_marnylopez]    Script Date: 3/27/2018 6:06:54 PM ******/
CREATE DATABASE [prj_marnylopez]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'prj_marnylopez', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\prj_marnylopez.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'prj_marnylopez_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\prj_marnylopez_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [prj_marnylopez] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [prj_marnylopez].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [prj_marnylopez] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [prj_marnylopez] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [prj_marnylopez] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [prj_marnylopez] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [prj_marnylopez] SET ARITHABORT OFF 
GO
ALTER DATABASE [prj_marnylopez] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [prj_marnylopez] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [prj_marnylopez] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [prj_marnylopez] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [prj_marnylopez] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [prj_marnylopez] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [prj_marnylopez] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [prj_marnylopez] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [prj_marnylopez] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [prj_marnylopez] SET  DISABLE_BROKER 
GO
ALTER DATABASE [prj_marnylopez] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [prj_marnylopez] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [prj_marnylopez] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [prj_marnylopez] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [prj_marnylopez] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [prj_marnylopez] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [prj_marnylopez] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [prj_marnylopez] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [prj_marnylopez] SET  MULTI_USER 
GO
ALTER DATABASE [prj_marnylopez] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [prj_marnylopez] SET DB_CHAINING OFF 
GO
ALTER DATABASE [prj_marnylopez] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [prj_marnylopez] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [prj_marnylopez] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [prj_marnylopez] SET QUERY_STORE = OFF
GO
USE [prj_marnylopez]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [prj_marnylopez]
GO
/****** Object:  Table [dbo].[cat_master]    Script Date: 3/27/2018 6:06:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cat_master](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_dsc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cat_master] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_master](
	[dtb_id] [int] IDENTITY(1,1) NOT NULL,
	[dtb_status] [bit] NOT NULL,
	[dtb_descr] [varchar](50) NULL,
 CONSTRAINT [PK_dtb_master] PRIMARY KEY CLUSTERED 
(
	[dtb_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pay_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pay_master](
	[pay_id] [int] NOT NULL,
	[pay_dsc] [varchar](20) NOT NULL,
 CONSTRAINT [PK_pay_master] PRIMARY KEY CLUSTERED 
(
	[pay_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prd_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prd_master](
	[prd_id] [int] IDENTITY(1,1) NOT NULL,
	[prd_shdsc] [varchar](20) NOT NULL,
	[prd_lgdsc] [varchar](50) NULL,
	[prd_price] [money] NOT NULL,
	[cat_id] [int] NOT NULL,
	[sts_id] [int] NOT NULL,
 CONSTRAINT [PK_prd_master] PRIMARY KEY CLUSTERED 
(
	[prd_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol_master](
	[rol_id] [int] IDENTITY(1,1) NOT NULL,
	[rol_dsc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_rol_master] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[srv_detail]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[srv_detail](
	[srv_id] [int] NOT NULL,
	[srv_qty] [int] NOT NULL,
	[srv_notes] [varchar](50) NULL,
	[prd_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[srv_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[srv_master](
	[srv_id] [int] IDENTITY(1,1) NOT NULL,
	[srv_date] [date] NOT NULL,
	[srv_total] [money] NOT NULL,
	[dtb_id] [int] NOT NULL,
	[pay_id] [int] NULL,
	[sts_id] [int] NOT NULL,
	[usr_id] [varchar](50) NOT NULL,
 CONSTRAINT [PK_srv_master] PRIMARY KEY CLUSTERED 
(
	[srv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sts_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sts_master](
	[sts_id] [int] IDENTITY(1,1) NOT NULL,
	[sts_dsc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_sts_master] PRIMARY KEY CLUSTERED 
(
	[sts_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usr_master]    Script Date: 3/27/2018 6:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usr_master](
	[usr_id] [varchar](50) NOT NULL,
	[usr_password] [varchar](50) NOT NULL,
	[sts_id] [int] NOT NULL,
	[rol_id] [int] NOT NULL,
 CONSTRAINT [PK_usr_master] PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cat_master] ON 

INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (1, N'Entradas')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (2, N'Entremeses')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (3, N'Platos principales')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (4, N'Postres')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (5, N'Bebidas')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (6, N'Pastas')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (7, N'Ensaladas')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (8, N'Pescados')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (9, N'Carnes')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (10, N'Guarniciones')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (11, N'Verduras')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (12, N'Sopas')
INSERT [dbo].[cat_master] ([cat_id], [cat_dsc]) VALUES (13, N'Bebidas artesanales')
SET IDENTITY_INSERT [dbo].[cat_master] OFF
SET IDENTITY_INSERT [dbo].[dtb_master] ON 

INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (1, 1, N'mesa 1')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (2, 1, N'mesa 2')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (3, 1, N'mesa 3')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (4, 1, N'mesa 4')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (5, 1, N'mesa 5')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (6, 1, N'mesa 6')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (7, 1, N'mesa 7')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (8, 1, N'mesa 8')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (9, 1, N'mesa 9')
INSERT [dbo].[dtb_master] ([dtb_id], [dtb_status], [dtb_descr]) VALUES (10, 1, N'mesa 10')
SET IDENTITY_INSERT [dbo].[dtb_master] OFF
SET IDENTITY_INSERT [dbo].[prd_master] ON 

INSERT [dbo].[prd_master] ([prd_id], [prd_shdsc], [prd_lgdsc], [prd_price], [cat_id], [sts_id]) VALUES (1, N'Ens. Atun', N'Deliciosa ensalada de atun', 2500.0000, 7, 1)
INSERT [dbo].[prd_master] ([prd_id], [prd_shdsc], [prd_lgdsc], [prd_price], [cat_id], [sts_id]) VALUES (2, N'Filete TBone', N'Servido con hongos salsa y esparragos', 5000.0000, 9, 1)
INSERT [dbo].[prd_master] ([prd_id], [prd_shdsc], [prd_lgdsc], [prd_price], [cat_id], [sts_id]) VALUES (3, N'Gaseosa', N'Gaseosa en lata de Coca Cola FEMSA', 1000.0000, 5, 1)
SET IDENTITY_INSERT [dbo].[prd_master] OFF
SET IDENTITY_INSERT [dbo].[rol_master] ON 

INSERT [dbo].[rol_master] ([rol_id], [rol_dsc]) VALUES (1, N'admin')
INSERT [dbo].[rol_master] ([rol_id], [rol_dsc]) VALUES (2, N'cajero')
INSERT [dbo].[rol_master] ([rol_id], [rol_dsc]) VALUES (3, N'salonero')
SET IDENTITY_INSERT [dbo].[rol_master] OFF
SET IDENTITY_INSERT [dbo].[sts_master] ON 

INSERT [dbo].[sts_master] ([sts_id], [sts_dsc]) VALUES (1, N'Activo')
INSERT [dbo].[sts_master] ([sts_id], [sts_dsc]) VALUES (2, N'Inactivo')
SET IDENTITY_INSERT [dbo].[sts_master] OFF
INSERT [dbo].[usr_master] ([usr_id], [usr_password], [sts_id], [rol_id]) VALUES (N'admin', N'admin', 1, 1)
INSERT [dbo].[usr_master] ([usr_id], [usr_password], [sts_id], [rol_id]) VALUES (N'cajero', N'cajero', 1, 2)
INSERT [dbo].[usr_master] ([usr_id], [usr_password], [sts_id], [rol_id]) VALUES (N'salonero', N'salonero', 1, 3)
ALTER TABLE [dbo].[prd_master]  WITH CHECK ADD  CONSTRAINT [FK_prd_master_cat_master] FOREIGN KEY([cat_id])
REFERENCES [dbo].[cat_master] ([cat_id])
GO
ALTER TABLE [dbo].[prd_master] CHECK CONSTRAINT [FK_prd_master_cat_master]
GO
ALTER TABLE [dbo].[prd_master]  WITH CHECK ADD  CONSTRAINT [FK_prd_master_sts_master] FOREIGN KEY([sts_id])
REFERENCES [dbo].[sts_master] ([sts_id])
GO
ALTER TABLE [dbo].[prd_master] CHECK CONSTRAINT [FK_prd_master_sts_master]
GO
ALTER TABLE [dbo].[srv_detail]  WITH CHECK ADD  CONSTRAINT [FK_srv_detail_prd_master] FOREIGN KEY([prd_id])
REFERENCES [dbo].[prd_master] ([prd_id])
GO
ALTER TABLE [dbo].[srv_detail] CHECK CONSTRAINT [FK_srv_detail_prd_master]
GO
ALTER TABLE [dbo].[srv_detail]  WITH CHECK ADD  CONSTRAINT [FK_srv_detail_srv_master] FOREIGN KEY([srv_id])
REFERENCES [dbo].[srv_master] ([srv_id])
GO
ALTER TABLE [dbo].[srv_detail] CHECK CONSTRAINT [FK_srv_detail_srv_master]
GO
ALTER TABLE [dbo].[srv_master]  WITH CHECK ADD  CONSTRAINT [FK_srv_master_dtb_master] FOREIGN KEY([dtb_id])
REFERENCES [dbo].[dtb_master] ([dtb_id])
GO
ALTER TABLE [dbo].[srv_master] CHECK CONSTRAINT [FK_srv_master_dtb_master]
GO
ALTER TABLE [dbo].[srv_master]  WITH CHECK ADD  CONSTRAINT [FK_srv_master_pay_master] FOREIGN KEY([pay_id])
REFERENCES [dbo].[pay_master] ([pay_id])
GO
ALTER TABLE [dbo].[srv_master] CHECK CONSTRAINT [FK_srv_master_pay_master]
GO
ALTER TABLE [dbo].[srv_master]  WITH CHECK ADD  CONSTRAINT [FK_srv_master_sts_master] FOREIGN KEY([sts_id])
REFERENCES [dbo].[sts_master] ([sts_id])
GO
ALTER TABLE [dbo].[srv_master] CHECK CONSTRAINT [FK_srv_master_sts_master]
GO
ALTER TABLE [dbo].[srv_master]  WITH CHECK ADD  CONSTRAINT [FK_srv_master_usr_master] FOREIGN KEY([usr_id])
REFERENCES [dbo].[usr_master] ([usr_id])
GO
ALTER TABLE [dbo].[srv_master] CHECK CONSTRAINT [FK_srv_master_usr_master]
GO
ALTER TABLE [dbo].[usr_master]  WITH CHECK ADD  CONSTRAINT [FK_usr_master_rol_master] FOREIGN KEY([rol_id])
REFERENCES [dbo].[rol_master] ([rol_id])
GO
ALTER TABLE [dbo].[usr_master] CHECK CONSTRAINT [FK_usr_master_rol_master]
GO
ALTER TABLE [dbo].[usr_master]  WITH CHECK ADD  CONSTRAINT [FK_usr_master_sts_master] FOREIGN KEY([sts_id])
REFERENCES [dbo].[sts_master] ([sts_id])
GO
ALTER TABLE [dbo].[usr_master] CHECK CONSTRAINT [FK_usr_master_sts_master]
GO
USE [master]
GO
ALTER DATABASE [prj_marnylopez] SET  READ_WRITE 
GO
