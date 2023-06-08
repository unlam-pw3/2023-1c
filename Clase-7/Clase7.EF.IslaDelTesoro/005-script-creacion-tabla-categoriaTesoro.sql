

CREATE TABLE [dbo].[CategoriaTesoro](
	[IdCategoriaTesoro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_CategoriaTesoro] PRIMARY KEY CLUSTERED 
(
	[IdCategoriaTesoro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TesoroCategoriaTesoro](
	[IdTesoro] [int] NOT NULL,
	[IdCategoriaTesoro] [int] NOT NULL,
 CONSTRAINT [PK_TesoroCategoriaTesoro] PRIMARY KEY CLUSTERED 
(
	[IdTesoro] ASC,
	[IdCategoriaTesoro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TesoroCategoriaTesoro]  WITH CHECK ADD  CONSTRAINT [FK_TesoroCategoriaTesoro_CategoriaTesoro] FOREIGN KEY([IdCategoriaTesoro])
REFERENCES [dbo].[CategoriaTesoro] ([IdCategoriaTesoro])
GO

ALTER TABLE [dbo].[TesoroCategoriaTesoro] CHECK CONSTRAINT [FK_TesoroCategoriaTesoro_CategoriaTesoro]
GO

ALTER TABLE [dbo].[TesoroCategoriaTesoro]  WITH CHECK ADD  CONSTRAINT [FK_TesoroCategoriaTesoro_Tesoro] FOREIGN KEY([IdTesoro])
REFERENCES [dbo].[Tesoro] ([Id])
GO

ALTER TABLE [dbo].[TesoroCategoriaTesoro] CHECK CONSTRAINT [FK_TesoroCategoriaTesoro_Tesoro]
GO



INSERT INTO CategoriaTesoro (Nombre) VALUES ('Joyas');
INSERT INTO CategoriaTesoro (Nombre) VALUES ('Monedas');
INSERT INTO CategoriaTesoro (Nombre) VALUES ('Arte');
INSERT INTO CategoriaTesoro (Nombre) VALUES ('Documentos históricos');
INSERT INTO CategoriaTesoro (Nombre) VALUES ('Objetos antiguos');