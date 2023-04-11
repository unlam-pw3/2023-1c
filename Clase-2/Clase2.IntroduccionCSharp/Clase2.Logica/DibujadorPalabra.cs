using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.Logica
{
    internal class DibujadorPalabra
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
            return palabraADibujar;
        }


        //Para los faciles/principiantes pense que mostrar las letras ingresadas
        public string ObtenerDibujoLetras(string palabraElegida, List<string> letrasAdivinadas)
        {
            string palabraADibujar = "";
            foreach (string letra in letrasAdivinadas)
            {
                
                    palabraADibujar += $"{letra} ";
            
            }
            return palabraADibujar;
        }

      
        public void DibujarLetrasEntrantes(string palabraElegida, List<string> letrasAdivinadas)
        {
            string palabraADibujar = ObtenerDibujoLetras(palabraElegida, letrasAdivinadas);
            Console.WriteLine(palabraADibujar);
        }
    }
}
