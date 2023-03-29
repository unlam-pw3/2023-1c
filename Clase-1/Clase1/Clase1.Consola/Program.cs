// See https://aka.ms/new-console-template for more information

using Clase1.Logica;

Console.WriteLine("Ingrese 2 numeros: ");
Console.WriteLine("nro 1: ");
string nro1 = Console.ReadLine();

Console.WriteLine("nro 2: ");
string nro2 = Console.ReadLine();

//string interpolation $"texto {variable}"
Console.WriteLine($"La suma de estos nros es: {Calculadora.Sumar(nro1, nro2)}");
