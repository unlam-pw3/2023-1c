using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.Logica
{
    public class DibujadorPalabra
    {
        public void DibujarPalabra(string palabraElegida, List<string> letrasAdivinadas)
        {
            string palabraADibujar = ObtenerDibujoPalabra(palabraElegida, letrasAdivinadas);
            Console.WriteLine(palabraADibujar);
        }

        public string ObtenerDibujoPalabra(string palabraElegida, List<string> letrasAdivinadas)
        {
            string palabraADibujar = "";
            foreach (char letra in palabraElegida)
            {
                if (letrasAdivinadas.Contains(letra.ToString(), StringComparer.OrdinalIgnoreCase))
                {
                    palabraADibujar += $"{letra} ";
                }
                else
                {
                    palabraADibujar += "_ ";
                }
            }
            return palabraADibujar.Trim();
        }

    }
}
