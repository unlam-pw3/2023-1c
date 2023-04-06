#  Clase 2 - Intro a C#

## En Clase
- Desarrollamos la lógica del juego "**Ahorcado**" ([Wikipedia](https://es.wikipedia.org/wiki/Ahorcado_%28juego%29)).
- Utilizamos:
-- Proyecto de consola
```
![Ahorcado](captura-juego.png?raw=true "Ahorcado")
```
-- Separamos la lógica en clases
-- Introdujimos el concepto de **unit testing** utilizando [XUnit](https://xunit.net/).
```
![Unit Tests](captura-unit-tests.png?raw=true "Unit Tests")
```
## Tarea - Modo Principiante +  Tests
- Agregar logica para poder elegir ingresar en "Modo Principiante" o "Modo Avanzado".
	- Modo Principiante: Se le presenta al usuario la primer letra de la palabra ya visible (junto con sus otras apariciones en la palabra) y ademas solo serán palabras de máximo 6 letras.
	- Modo Avanzado: Ninguna letra se le muestra al usuario y las palabras tendrán un mínimo de 7 letras.