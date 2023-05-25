#  Clase-7-Practica Entity Framework "Isla del Tesoro"

## En Clase
Hicimos ejemplos Alta, Baja, Modificacion y Listado de la entidad "Tesoro"

![Lista Tesoros](captura-lista-tesoros.png?raw=true "Lista Tesoros")

## Modelo de datos
Tesoro
- [Id] [int] IDENTITY(1,1) NOT NULL,
- Nombre VARCHAR(255),
- Descripcion VARCHAR(255),
- ImagenUrl VARCHAR(1000),
- Ubicacion INT NULL,
- Valor DECIMAL(10, 2)
);

## Utilizamos:
- Proyecto de MVC
- Proyecto de Biblioteca de clases
- Entity Framework Core

## Tarea - Agregar "Ubicacion"
- Crear Tabla "Ubicacion" (Id, Nombre)
- Crear script de datos iniciales
- Agregar las operaciones de Alta, Baja, Modificacion y Listado de la entidad "Ubicacion"

## Como generar entidades al agregar nuevas tablas en la Base de Datos
- En la consola de manejo de paquetes, elegir en el combo arriba a la derecha el proyecto donde crear las clases (el que es .Data)
- Editar el siguiente comando con la connectionstring a su base de datos.
- Ejecutar el comando
`Scaffold-DbContext "Server=.;Database=PW3-2023-1C-EF-IslaDelTesoro;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entidades`
