using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Velocidad { get; set; }

        public virtual bool PuedeEscapar(Animal depredador)
        {
            Console.WriteLine($"{Nombre} está intentando escapar...");
            return depredador.Velocidad < this.Velocidad;
        }
    }
}
