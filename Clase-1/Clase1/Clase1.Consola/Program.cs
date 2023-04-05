// See https://aka.ms/new-console-template for more information


using Clase1.Logica.Ejercicios;

//CalculadoraEjercicio.Ejecutar();
//await ChatGPTEjercicio.Ejecutar();


public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                string? pregunta = GetPregunta();

                GenerarRespuesta(pregunta);

                if (!QuiereSeguir()) break;
            }
            catch
            {
                Console.WriteLine("Ups. No pude contestar tu pregunta. Volve a preguntar \n");
            }
        }

    }

    private static string? GetPregunta()
    {
        Console.WriteLine("Bienvenido a la Bola del 8. Haceme una pregunta.");
        return Console.ReadLine();
    }



    private static void GenerarRespuesta(string? pregunta)
    {
        string respuesta = new BolaOcho().ContestarPregunta(pregunta);

        GenerarEspera();

        Console.WriteLine($"Mi respuesta es: {respuesta}");
    }

    private static void GenerarEspera()
    {
        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(500);

            Console.WriteLine($"{new string('.', i)} \n");
        }
    }

    private static bool QuiereSeguir()
    {
        Console.WriteLine("¿Queres seguir preguntando?");
        return Console.ReadLine().ToLower().Equals("si");
    }
}