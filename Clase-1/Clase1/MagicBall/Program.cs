// write a String list

String[] responses = { "No", "Si", "Tal vez", "Definitivamente" };
String prompt = "Preguntame algo: ";

Console.WriteLine(prompt);
String question = Console.ReadLine();

int rng = new Random().Next(0, responses.Length);

Console.WriteLine("La respuesta a tu pregunta " + question + " es...");
Console.WriteLine(responses[rng]);

Console.ReadKey();

