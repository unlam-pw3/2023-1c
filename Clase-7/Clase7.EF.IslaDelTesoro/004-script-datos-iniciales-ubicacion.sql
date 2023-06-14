

SET IDENTITY_INSERT [dbo].[Ubicacion] ON 
GO
INSERT [dbo].[Ubicacion] ([Id], [Nombre], ImagenUrl) VALUES (1, N'Playa Rocosa', 'https://rb.gy/o19cv')
GO
INSERT [dbo].[Ubicacion] ([Id], [Nombre], ImagenUrl) VALUES (2, N'Barco Hundido', 'https://rb.gy/6122e')
GO
INSERT [dbo].[Ubicacion] ([Id], [Nombre], ImagenUrl) VALUES (3, N'Montañas', 'https://rb.gy/enzso')
GO
INSERT [dbo].[Ubicacion] ([Id], [Nombre], ImagenUrl) VALUES (4, N'Bosque Encantado', 'https://rb.gy/31zrs')
GO
INSERT [dbo].[Ubicacion] ([Id], [Nombre], ImagenUrl) VALUES (5, N'Arrecifes', 'https://rb.gy/ko02t')
GO
SET IDENTITY_INSERT [dbo].[Ubicacion] OFF
GO

--ASIGNAMOS UBICACION ALEATORIA A CADA TESORO
UPDATE [dbo].[Tesoro]
   SET 
      [IdUbicacion] = floor(RAND()*(5)+1)
	WHERE Id IN (SELECT tOP 2 id FROM [dbo].[Tesoro] order BY NEWID())
GO
UPDATE [dbo].[Tesoro]
   SET 
      [IdUbicacion] = floor(RAND()*(5)+1)
	WHERE Id IN (SELECT tOP 2 id FROM [dbo].[Tesoro] order BY NEWID())
GO
UPDATE [dbo].[Tesoro]
   SET 
      [IdUbicacion] = floor(RAND()*(5)+1)
	WHERE Id IN (SELECT tOP 2 id FROM [dbo].[Tesoro] order BY NEWID())
GO
UPDATE [dbo].[Tesoro]
   SET 
      [IdUbicacion] = floor(RAND()*(5)+1)
	WHERE Id IN (SELECT tOP 2 id FROM [dbo].[Tesoro] order BY NEWID())
GO
UPDATE [dbo].[Tesoro]
   SET 
      [IdUbicacion] = floor(RAND()*(5)+1)
	WHERE Id IN (SELECT tOP 2 id FROM [dbo].[Tesoro] order BY NEWID())
GO