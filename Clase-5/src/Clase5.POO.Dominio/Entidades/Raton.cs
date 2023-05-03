using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    public class Raton : Animal
    {
        public bool PoseeColaLarga { get; set; }

        public Raton(bool poseeColaLarga)
        {
            this.PoseeColaLarga = poseeColaLarga;
        }

        public override bool PuedeEscapar(Animal depredador)
        {
            bool lograEscapar = base.PuedeEscapar(depredador);

            if (lograEscapar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (PoseeColaLarga && (depredador.Velocidad >= this.Velocidad - 2))
                {
                    Console.WriteLine($"{this.Nombre} fue atrapado por {depredador.Nombre} por su cola larga!");
                    return false;
                }
            }

            return lograEscapar;
        }
    }
}
