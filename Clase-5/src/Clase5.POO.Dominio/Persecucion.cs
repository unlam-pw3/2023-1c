using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase5.POO.Dominio.Entidades;

namespace Clase5.POO.Dominio
{
    public class Persecucion
    {
        public void Ejecutar(Animal depredador, Animal presa)
        {
            Console.WriteLine("");

            Console.WriteLine($"{depredador.Nombre} está persiguiendo a {presa.Nombre}...");

            bool pudoEscapar = presa.PuedeEscapar(depredador);

            if (pudoEscapar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{presa.Nombre} logro escapar de {depredador.Nombre}!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{depredador.Nombre} atrapó a {presa.Nombre}!");
                Console.ResetColor();
            }
        }
    }
}
