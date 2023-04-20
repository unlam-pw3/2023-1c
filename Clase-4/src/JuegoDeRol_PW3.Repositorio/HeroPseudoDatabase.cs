using JuegoDeRol_PW3.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeRol_PW3.Repositorio
{
    public class HeroPseudoDatabase
    {
        public static List<Hero> heroes = new List<Hero>() {
            new Hero { Id = 1 ,
                       Nombre = "Batman",
                       Creador = "Bob Kane",
                       FechaAlta = DateOnly.Parse("27/05/1939"),
                       Descripcion = "Bruno Díaz, Alias Batman, Es un legendario vigilante que lucha contra el crimen en Ciudad Gótica, y un miembro fundador de la Liga de la Justicia. Él es el mentor de Robin, y es responsable de asignar las misiones a El Equipo",
                       Imagen = "\\Batman.jpg",
                       Editorial= 2} 
                     };

        public static List<Hero> GetHeroes() => heroes;
    }
}
