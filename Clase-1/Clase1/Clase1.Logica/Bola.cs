using System;

namespace Clase1.Logica;

public class Bola
{
    public static void Responder(string pregunta)
    {

        string[] respuestas = new string[] {
            
            "Es decididamente as�",
            "Las se�ales apuntan a que s�",
            "Sin lugar a dudas",
            "S�, definitivamente",
            "Es cierto",
            "Puedes confiar en ello",
            "Como yo lo veo, s�",
            "Lo m�s probable",
            "Perspectiva buena",
            "S�",
            "Respuesta confusa, vuelve a intentarlo",
            "Vuelve a preguntar m�s tarde",
            "Mejor no decirte ahora",
            "No se puede predecir ahora",
            "Conc�ntrate y vuelve a preguntar",
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