using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    public class Aguila : Animal
    {
     
        public bool poseeAlasProminentes { get; set; }

        public Aguila(bool poseeAlasProminentes)
        {
            this.poseeAlasProminentes = poseeAlasProminentes;
        }

        public override bool PuedeEscapar(Animal depredador)
        {
            bool lograEscapar = base.PuedeEscapar(depredador);

            if (!lograEscapar)
            {
                if (poseeAlasProminentes && this.Velocidad + 2>= depredador.Velocidad )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{this.Nombre} fue atrapado por {depredador.Nombre}, pero logro escapar por sus alas!");
                    return true;
                }
                else
                { 
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine($"{Nombre} fue atrapado por {depredador.Nombre},{Nombre} no fue lo suficientemente rapido para despegar!");
                  return false;
                }
            }

            return lograEscapar;
        }
    }
}
