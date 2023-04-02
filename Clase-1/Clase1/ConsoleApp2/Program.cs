using ConsoleApp2;

Console.WriteLine("Ingrese una pregunta: ");
string question = Console.ReadLine();
Console.WriteLine(MagicBall.GetResponse(question));