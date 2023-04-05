using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica.Ejercicios;
public static class BolaMagica
{
    public static void Ejecutar()
    {
        var rand = new Random();

        string[] respuestas = new string[] {
            "Es cierto",
            "Es decididamente así",
            "Sin lugar a dudas",
            "Sí, definitivamente",
            "Puedes confiar en ello",
            "Como yo lo veo, sí",
            "Lo más probable",
            "Perspectiva buena",
            "Sí",
            "Las señales apuntan a que sí",
            "Respuesta confusa, vuelve a intentarlo",
            "Vuelve a preguntar más tarde",
            "Mejor no decirte ahora",
            "No se puede predecir ahora",
            "Concéntrate y vuelve a preguntar",
            "No cuentes con ello",
            "Mi respuesta es no",
            "Mis fuentes dicen que no",
            "Las perspectivas no son muy buenas",
            "Muy dudoso"
        };

        string pregunta = "";

        do
        {
            if (string.IsNullOrEmpty(pregunta))
            {
                Console.WriteLine("Ingrese su pregunta: ");
            } else
            {
                Console.WriteLine("Debe ingresar una pregunta de Si/No: ");
            }

            pregunta = Console.ReadLine();
        
        } while (!pregunta.EndsWith("?"));
        
        Console.WriteLine($"\n {respuestas[rand.Next(respuestas.Length)]}");
    }
}
