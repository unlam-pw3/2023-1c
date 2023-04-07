using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.Logica
{
    public class DibujadorPalabra
    {
        public void DibujarPalabraSegunModoDeJuego(string palabraElegida, List<string> letrasAdivinadas, int modoJuego)
        {
            if (1 == modoJuego)
            {
                letrasAdivinadas.Add(ObtenerPrimerLetra(palabraElegida));
            }
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

        public string ObtenerPrimerLetra(string palabraElegida)
        {
            return palabraElegida.Substring(0,1);
        }

    }
}
