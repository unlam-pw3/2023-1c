using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clase1.Logica.Ejercicios
{
    public class Ball8Ejercicio
    {

        public static void Ejecutar()
        {

            string[] rspBolaMagica;
            rspBolaMagica = new string[] {"Es cierto.","Es decididamente así.","Sin lugar a dudas.","Sí, definitivamente.","Puedes confiar en ello.","Como yo lo veo, sí.","Lo más probable.","Perspectiva buena.","Sí.","Las señales apuntan a que sí.",
" Respuesta confusa, vuelve a intentarlo."," Vuelve a preguntar más tarde.", "Mejor no decirte ahora.","No se puede predecir ahora.", " Concéntrate y vuelve a preguntar."," No cuentes con ello.",
 "Mi respuesta es no.","Mis fuentes dicen que no.","Las perspectivas no son muy buenas.","Las perspectivas no son muy buenas.","Muy dudoso."
};
            var random = new Random();

            Console.WriteLine("Bienvenido al juego de La Bola Magica ");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("Ingrese su pregunta para obtener una respuesta magica:");
            Console.WriteLine("Para terminar ingrese la letra 'S'(Salir)");
            string pregunta = Console.ReadLine();

            while (pregunta != "S")
            {
                var value = random.Next(0, 19);

                //string interpolation $"texto {variable}"
                //Console.WriteLine($"Numero random Obtinido es: {value}");
                Console.WriteLine($"{rspBolaMagica[value]}");
                Console.WriteLine("---Ingrese su nueva pregunta:");
                pregunta = Console.ReadLine();
            }

        }
    }
}
