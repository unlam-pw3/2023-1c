using System;

namespace JuegoBola8
{
    public class Program {

        static void Main(string[] args)
        {
            string pregunta;

            do
            {
                Respuesta respu = new Respuesta();

                Console.WriteLine("Ingrese una pregunta que pueda responderse con un SI o un No..." +
                "Para finalizar escriba OFF");

                pregunta = Console.ReadLine();
                if (!string.IsNullOrEmpty(pregunta) && !pregunta.Equals("OFF"))
                {
                    Console.WriteLine(respu.getRespuesta());
                }

            } while (!pregunta.Equals("OFF"));
        }
    }
}