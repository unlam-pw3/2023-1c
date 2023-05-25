namespace Bola8Magica;

class Bola8MagicaMain
{
    static void Main(string[] args)
    {
        Bola bola = new Bola();
        string pregunta = "";
        Console.WriteLine("Bienvenido al juego de Bola 8 Mágico.\nEscriba a continuación la pregunta, recuerde que debe ser de respuesta si o no.");

        while (true) 
        {
            string ingreso = Console.ReadLine();
            switch (ingreso)
            {
                case "":
                    break;
                case "1":
                    Console.WriteLine(pregunta);
                    Console.WriteLine($"\n{bola.obtenerRespuesta()}");
                    Console.WriteLine("\nIngrese nueva pregunta. Para repetirla puede presionar 1. Si desea salir del juego presione 9.");
                    break;
                case "9":
                    Console.WriteLine("\nGracias por jugar.");
                    Environment.Exit(0);
                    break;
                default:
                    pregunta = ingreso;
                    Console.WriteLine(bola.obtenerRespuesta());
                    Console.WriteLine("\nIngrese nueva pregunta. Para repetirla puede presionar 1. Si desea salir del juego presione 9.");
                    break;
            }
        }
    }
}
