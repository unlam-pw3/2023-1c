CREATE TABLE [dbo].[Ubicacion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    Nombre NVARCHAR(200) NOT NULL
)
GO
ALTER TABLE dbo.Tesoro ADD
	IdUbicacion int NULL
GO
ALTER TABLE dbo.Tesoro ADD CONSTRAINT
	FK_Tesoro_Ubicacion FOREIGN KEY
	(
	IdUbicacion
	) REFERENCES dbo.Ubicacion
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tesoro
	DROP COLUMN Ubicacion