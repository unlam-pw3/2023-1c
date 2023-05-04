using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    public class Gato : Animal
    {
        public bool PoseeGarrasAfiladas { get; set; }
        public override bool PuedeEscapar(Animal depredador)
        {
            bool lograEscapar = base.PuedeEscapar(depredador);

            if (!lograEscapar)
            {
                if (PoseeGarrasAfiladas)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{this.Nombre} fue atrapado por {depredador.Nombre}, pero logro escapar por sus garras afiladas!");
                    return true;
                }
            }

            return lograEscapar;
        }
    }
}
