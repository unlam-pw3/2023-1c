using JuegoDeRol_PW3.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeRol_PW3.Repositorio
{
    public class EditorialPseudoDatabase
    {
        public static List<Editorial> editoriales = new List<Editorial>()
        {
            new Editorial
            {
                Id = 1,
                Nombre = "Marvel",
                Descripcion = "Marvel Worldwide, Inc., conocida como Marvel Comics, es una editorial de historietas estadounidense creada en 1939, inicialmente con el nombre de Timely Publications."

            },

            new Editorial{
                  Id = 2,
                Nombre = "DC",
                Descripcion = "DC Comics es una editorial de cómics estadounidense. Forma parte de DC Entertainment,1​ una de las empresas que conforman Warner Bros. Entertainment, la cual a su vez es propiedad de Warner Bros. Discovery. Fue fundada en 1934 bajo el nombre National Allied Publications, para luego tomar el nombre de DC Comics en 1937.\r\n\r\nEntre algunos de sus personajes más emblemáticos se encuentran Superman, Batman, Mujer Maravilla, Flash, Linterna Verde, Aquaman, Hombre Halcón, Chica Halcón, Flecha Verde, Shazam, Detective Marciano, Starfire, Nightwing, Raven, Cyborg, Canario Negro, Doctor Destino, Robin, Chico Bestia, Zatanna, Hombre Plástico, Catwoman, Supergirl, El Joker y Harley Quinn. Su sede principal estuvo situada históricamente en la ciudad de Nueva York, pero desde 2015 mudaron sus oficinas a la ciudad de Burbank2​."
            }

        };


        public static List<Editorial> GetEditoriales() => editoriales;
    }
}


