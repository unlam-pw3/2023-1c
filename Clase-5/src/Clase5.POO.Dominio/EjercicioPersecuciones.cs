using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase5.POO.Dominio.Entidades;

namespace Clase5.POO.Dominio
{
    public class EjercicioPersecuciones
    {
        public static void Ejecutar()
        {
            Perro perroLassie = new Perro();
            perroLassie.Nombre = "Lassie";
            perroLassie.PoseeAmigos = true;
            perroLassie.Velocidad = 5;

            Perro perroPluto = new Perro();
            perroPluto.Nombre = "Pluto";
            perroPluto.PoseeAmigos = false;
            perroPluto.Velocidad = 5;

            Gato gatoGarfield = new Gato();
            gatoGarfield.Nombre = "Garfield";
            gatoGarfield.PoseeGarrasAfiladas = false;
            gatoGarfield.Velocidad = 2;

            Gato gatoTom = new Gato();
            gatoTom.Nombre = "Tom";
            gatoTom.PoseeGarrasAfiladas = true;
            gatoTom.Velocidad = 5;

            Raton ratonJerry = new Raton(poseeColaLarga: true);
            ratonJerry.Nombre = "Jerry";
            ratonJerry.Velocidad = 7;

            Raton ratonMickey = new Raton(poseeColaLarga: false);
            ratonMickey.Nombre = "Mickey";
            ratonMickey.Velocidad = 1;

            Persecucion persecucion = new Persecucion();
            persecucion.Ejecutar(perroPluto, gatoGarfield);
            persecucion.Ejecutar(perroPluto, gatoTom);
            
            persecucion.Ejecutar(gatoGarfield, ratonJerry);
            persecucion.Ejecutar(gatoTom, ratonJerry);
            
            persecucion.Ejecutar(gatoGarfield, ratonMickey);
            persecucion.Ejecutar(gatoTom, ratonMickey);

            persecucion.Ejecutar(gatoTom, perroLassie);
        }
    }
}
