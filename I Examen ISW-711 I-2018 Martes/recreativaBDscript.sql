USE [examen]
GO

CREATE TABLE [dbo].[UserEntidad]
(
    [IdUser] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [nombreUser] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(20) NOT NULL
)
go
insert into [dbo].[UserEntidad] (nombreUser,password) values ('admin', '123456'),
('juan', '123456'),
('pedro','1234'),
('pablo','1234')
create table [dbo].[TipoRecreativaEntidad] (
	[idTipoRecreativa] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[descripcion] [text] NOT NULL,
	[costo] [int] NOT NULL,
)
go
insert into [dbo].[TipoRecreativaEntidad] (descripcion,costo) values ('Niños', 0),
('Novato', 4000),
('Master A',3500),
('Master B',3000),
('Competición',8000)
go
CREATE TABLE [dbo].[RecreativaEntidad](
	[idRecreativa] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[descripcion] [text] NOT NULL,
	[tipoRecreativa] [int] NOT NULL,
	[kilometros] [int] NOT NULL,
	[costoAdicionales] [int] NOT NULL,
	[costoTotal] [int] NOT NULL,
	[idUser] [int] NOT NULL,
)
go
insert into [dbo].[RecreativaEntidad] (descripcion,tipoRecreativa,kilometros,costoAdicionales,costoTotal,idUser) 
values ('Miravalles Niños', 1,3,2000,2000,1),
('Miravalles Novato', 2,15,2000,6000,1),
('Vuelta al Lago Master', 2,90,3000,8000,1),
('Vuelta al Lago Competicion', 5,120,10000,15000,1)
go
