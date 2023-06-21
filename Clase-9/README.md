#  Clase 9: Modelo 2do Parcial "Sucursales y Cadenas"

## En Clase
Hicimos ejemplo de modelo de 2do parcial

## Enunciado
1) a) Crear en SQL Server las siguientes tablas:
- Cadena: con los siguientes campos (Id integer, Razon_social nvarchar(50))
- Sucursal: (Id integer, Direccion nvarchar(50), Ciudad nvarchar(50), IdCadena integer)
Recordar agregar la relación para que un Sucursal esté relacionado a una Cadena a través de IdCadena. Recordar establecer las claves primarias como identity.
b) Crear un proyecto MVC como vimos en clase llamado SistemaDeCadenasAlimenticias.Web; pueden separar en capas usando carpetas dentro del proyecto web o en diferentes proyectos SistemaDeCadenasAlimenticias.Data, SistemaDeCadenasAlimenticias.Servicios.
c) Utilizando EF (enfoque DatabaseFirst), crear el modelo conceptual, en una carpeta llamada “EF”.
d) Generar script para creación de base de datos, tablas e insert de 2 Cadenas para que puedan crear Sucursales.
2) a) Crear una aplicación asp.net que tenga una funcionalidad de crear nuevas Sucursale s, esta página o vista tendrá los controles Cadena (combo o select option de html ordenados por Nombre de A a Z), Dirección de sucursal (input text) y Ciudad (input text) correspondientes a la entidad Sucursal, con un botón grabar Nueva Sucursal.
b) Generar el código necesario para almacenar una nueva Sucursal por medio del botón grabar.
3) Una vez grabado la Sucursal, se debe redirigir a una funcionalidad (página o vista) que muestre todas las sucursales grabadas y su cadena, visualizando Cadena, Ciudad y Dirección.
4) Crear una nueva funcionalidad “Filtrar” en esta misma página/vista agregando un combo de Cadenas (ordenados por Nombre de A a Z) y un botón Filtrar. El mismo traería solo las sucursales que pertenecen a esa cadena, si no se elige ninguna cadena, debería traer todas las sucursales.

Aclaraciones:
- Se debe utilizar EF y LINQ o expresiones Lambda sin excepción.
- No es obligatorio controlar las validaciones de ingreso de información.
- Eliminar aquellas vistas que no tienen que ver con el enunciado, como por ejemplo privacy y demás.
- Entregar un .zip con el formato Apellido-Nombre-Parcial-2.zip, recordar incluir script de sql creando la base de datos y tablas. Recordar excluir del .zip las carpetas /bin y /obj.
- Validar con el profesor que la entrega llegó.
- Tener abierta la solución y estar preparado para compartir pantalla para mostrar la resolución del ejercicio en caso de que el profesor así lo indique.

## Utilizamos:
- Proyecto de MVC
- Proyecto de Biblioteca de clases
- Entity Framework Core

## Tarea - Realizar un ejemplo Similar y tener en cuenta que puede tambien entrar el hacer un servicio web api como vimos en la clase anterior.

## Como generar entidades al agregar nuevas tablas en la Base de Datos
- En la consola de manejo de paquetes, elegir en el combo arriba a la derecha el proyecto donde crear las clases (el que es .Data)
- Editar el siguiente comando con la connectionstring a su base de datos.
- Ejecutar el comando
` Scaffold-DbContext "Server=.;Database=PW3-2023-1c-Modelo-2do-parcial;Trusted_Connection=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir EF`
