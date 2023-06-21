CREATE DATABASE [PW3-2023-1c-Modelo-2do-parcial2]
GO
USE [PW3-2023-1c-Modelo-2do-parcial2]
GO
/****** Object:  Table [dbo].[Cadena]    Script Date: 6/21/2023 7:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadena](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Razon_social] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cadena] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 6/21/2023 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Ciudad] [nvarchar](50) NOT NULL,
	[IdCadena] [int] NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_Cadena] FOREIGN KEY([IdCadena])
REFERENCES [dbo].[Cadena] ([Id])
GO
ALTER TABLE [dbo].[Sucursal] CHECK CONSTRAINT [FK_Sucursal_Cadena]
GO
