// See https://aka.ms/new-console-template for more information


using Clase1.Logica.Ejercicios;

//CalculadoraEjercicio.Ejecutar();
//await ChatGPTEjercicio.Ejecutar();

while (true)
{
    try
    {
        Console.WriteLine("Bienvenido a la Bola del 8. Haceme una pregunta.");
        string? pregunta = Console.ReadLine();

        string respuesta = new BolaOcho().ContestarPregunta(pregunta);

        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(500);

            Console.WriteLine($"{new string('.', i)} \n");
        }

        Console.WriteLine($"Mi respuesta es: {respuesta}");

        Console.WriteLine("¿Queres seguir preguntando?");

        bool quiereSeguir = Console.ReadLine().ToLower().Equals("si");

        if (!quiereSeguir) break;
    }
    catch
    {
        Console.WriteLine("Ups. No pude contestar tu pregunta. Volve a preguntar \n");

    }
}