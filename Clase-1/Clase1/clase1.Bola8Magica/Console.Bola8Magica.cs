// See https://aka.ms/new-console-template for more information
using Clase1.Bola8Magica;

Console.WriteLine("Hola, bienvenido a 'Magic 8-Ball'");
Console.WriteLine("Ingrese su pregunta: ");

string pregunta = Console.ReadLine();

Bola8Magica bola1 = new Bola8Magica();

Console.WriteLine($"Su respuesta es: {bola1.RespuestaMagica()}");



