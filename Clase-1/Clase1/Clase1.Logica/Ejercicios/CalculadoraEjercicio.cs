using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica.Ejercicios;
public static class CalculadoraEjercicio
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese 2 numeros: ");
        Console.WriteLine("nro 1: ");
        string nro1 = Console.ReadLine();

        Console.WriteLine("nro 2: ");
        string nro2 = Console.ReadLine();

        //string interpolation $"texto {variable}"
        Console.WriteLine($"La suma de estos nros es: {Calculadora.Sumar(nro1, nro2)}");
    }
}
