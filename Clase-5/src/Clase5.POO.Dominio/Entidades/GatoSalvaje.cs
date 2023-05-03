using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.POO.Dominio.Entidades
{
    internal class GatoSalvaje:Gato
    {
        public bool poseeDientesDesarrollados { get; set; }

        public override bool PuedeEscapar(Animal depredador)
        {
            bool lograEscapar = base.PuedeEscapar(depredador);

            if (!lograEscapar)
            {
                if (poseeDientesDesarrollados)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{this.Nombre} fue atrapado por {depredador.Nombre}, pero logro escapar por sus Dentadura desarrollada!");
                    return true;
                }
            }

            return lograEscapar;
        }
    }
}
