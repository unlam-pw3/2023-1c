using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    internal class Serpiente:Animal
    {
        public override bool PuedeEscapar(Animal depredador)
        {
            bool lograEscapar = base.PuedeEscapar(depredador);

            if (!lograEscapar)
            {
               
                    Console.WriteLine($"{this.Nombre} fue atrapado por {depredador.Nombre}!");
                    return false;

            }

            return lograEscapar;
        }

    }
}
