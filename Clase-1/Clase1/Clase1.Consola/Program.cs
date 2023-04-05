using Clase1.Logica;

Bola bola = new Bola();

Boolean continue_ = true;

while (continue_)
{
    Console.WriteLine("Ingrese una pregunta por si o por no, pulse 0 para salir");
    string input = Console.ReadLine();

    switch (input)
    {
        case "":
            break;
        case "0":
            Console.WriteLine("\nAdios.");
            continue_ = false;
            break;
        default:
            bola.Agitar();
            break;
    } 
}
    

