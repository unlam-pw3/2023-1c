using System;

namespace Clase1.Logica;

public class Bola
{
    public static void Responder(string pregunta)
    {

        string[] respuestas = new string[] {
            
            "Es decididamente así",
            "Las señales apuntan a que sí",
            "Sin lugar a dudas",
            "Sí, definitivamente",
            "Es cierto",
            "Puedes confiar en ello",
            "Como yo lo veo, sí",
            "Lo más probable",
            "Perspectiva buena",
            "Sí",
            "Respuesta confusa, vuelve a intentarlo",
            "Vuelve a preguntar más tarde",
            "Mejor no decirte ahora",
            "No se puede predecir ahora",
            "Concéntrate y vuelve a preguntar",
            "No cuentes con ello",
            "Mi respuesta es no",
            "Mis fuentes dicen que no",
            "Muy dudoso",
            "Las perspectivas no son muy buenas"
            
        };

       
                Random rand = new Random();
                Console.WriteLine($"\n {respuestas[rand.Next(respuestas.Length)]}");
    }

}