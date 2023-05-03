using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    public class Perro : Animal
    {
        public bool PoseeAmigos { get; set; }

        public override bool PuedeEscapar(Animal depredador)
        {
            bool lograEscapar = base.PuedeEscapar(depredador);

            if (!lograEscapar)
            {
                if (PoseeAmigos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{this.Nombre} fue atrapado por {depredador.Nombre} pero logro escapar gracias a sus amigos!");
                    return true;
                }
            }

            return lograEscapar;
        }
    }
}
