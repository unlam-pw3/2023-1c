/****** Object:  Database [PW3-2023-1C-EF-IslaDelTesoro]    Script Date: 5/24/2023 8:20:27 PM ******/
CREATE DATABASE [PW3-2023-1C-EF-IslaDelTesoro]
GO
USE [PW3-2023-1C-EF-IslaDelTesoro]
GO
/****** Object:  Table [dbo].[Tesoro]    Script Date: 5/24/2023 8:20:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tesoro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Descripcion] [varchar](255) NULL,
	[ImagenUrl] [varchar](1000) NULL,
	[Ubicacion] [int] NULL,
	[Valor] [decimal](10, 2) NULL,
 CONSTRAINT [PK__Tesoro__3214EC077890E188] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
