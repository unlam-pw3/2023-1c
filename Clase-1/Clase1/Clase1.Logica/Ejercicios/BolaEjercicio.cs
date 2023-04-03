using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica.Ejercicios;
public static class BolaEjercicio
{
    public static void Ejecutar()
    {
        string pregunta = "";
        do
        {
            Console.WriteLine("Ingrese una pregunta cuya respuesta requiera una afirmación o una negación: ");
            pregunta = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(pregunta));

        Bola.Responder(pregunta);
        Console.ReadLine();
    }
}
