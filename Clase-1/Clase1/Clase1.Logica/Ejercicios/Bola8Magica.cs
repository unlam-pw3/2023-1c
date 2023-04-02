using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica.Ejercicios;
public static class Bola8Magica
{
    private static readonly string[] standardResponseList = {
                                                        "Es cierto.",
                                                        "Es decididamente así.",
                                                        "Sin lugar a dudas.",
                                                        "Sí, definitivamente.",
                                                        "Puedes confiar en ello.",
                                                        "Como yo lo veo, sí.",
                                                        "Lo más probable.",
                                                        "Perspectiva buena.",
                                                        "Sí.",
                                                        "Las señales apuntan a que sí.",
                                                        "Respuesta confusa, vuelve a intentarlo.",
                                                        "Vuelve a preguntar más tarde.",
                                                        "Mejor no decirte ahora.",
                                                        "No se puede predecir ahora.",
                                                        "Concéntrate y vuelve a preguntar.",
                                                        "No cuentes con ello.",
                                                        "Mi respuesta es no.",
                                                        "Mis fuentes dicen que no.",
                                                        "Las perspectivas no son muy buenas.",
                                                        "Muy dudoso."
                                                    };

    private static string getStandardResponseByIndex(int index)
    {
        return standardResponseList[index];
    }

    private static int getRandomIndex()
    {
        Random random = new();
        return random.Next(standardResponseList.Length);
    }

    private static string generateRandomResponse()
    {
        int rIndex = getRandomIndex();
        string response = getStandardResponseByIndex(rIndex);
        return response;
    }

    public static void Ejecutar()
    {
        string? request;
        Console.WriteLine("Bienvenido al juego Bola Magica 8");
        Console.WriteLine("Escriba una pregunta que espere un tipo de respuesta si/no: ");
        Console.WriteLine("Para salir ingrese la letra s ");
        do
        {
            request = Console.ReadLine();
            if (request != null && !(("s").Equals(request.ToLower()) || ("").Equals(request.ToLower())))
            {
                Console.WriteLine(generateRandomResponse());
            }
        } while (request != null && !("s").Equals(request.ToLower()));
    }
}
