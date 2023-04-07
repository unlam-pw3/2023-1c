using System.Diagnostics;

namespace Clase2.Logica
{
    public class JuegoAhorcado
    {
        private static List<string> PalabrasPosiblesPrincipiante = new List<string>()
        {
            //Cosas que pueden estar en la cocina Maximo 6 letras
            "Plato",
            "Vaso",
            "Mesa",
            "Sarten",
            "Mantel",
            "Copa",
            "Taza",
            "Jarra"
        };
        private static List<string> PalabrasPosiblesAvanzado = new List<string>()
        {
            //Cosas que pueden estar en la cocina Mayor a 6 letras
            "Cuchillo",
            "Cuchara",
            "Tenedor",
            "Cucharon",
            "Cafetera",
            "Microondas",
            "Refrigerador"
        };


        public void Ejecutar()
        {
            List<string> LetrasAdivinadas = new List<string>();
            var dibujoAhorcado = new DibujoAhorcadoTradicional();
            var dibujadorPalabra = new DibujadorPalabra();
            //Crear lista de palabras posibles con alguna tematica

            int modoJuego = Iniciarjuego();

            //Termina el juego
            if (modoJuego == 0)
            {
                return;
            }

            //empezar juego y elegir una palabra
            string palabraElegida = ObtenerPalabraSegunModoDeJuego(modoJuego);

            //usuario ingresa una letra y se valida si pertenece a la palabra, si no pertenece se dibuja una parte del cuerpo del ahorcado
            do
            {
                //dibujar como se encuentra la palabra actual con las incognitas y las letras ya descubiertas
                dibujadorPalabra.DibujarPalabraSegunModoDeJuego(palabraElegida, LetrasAdivinadas, modoJuego);
                Console.WriteLine("Ingrese una letra");
                string letraIngresada = Console.ReadLine();

                bool perteneceAPalabra = PerteneceAPalabra(letraIngresada, palabraElegida);
                if (perteneceAPalabra)
                {
                    LetrasAdivinadas.Add(letraIngresada);
                    if (!dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, LetrasAdivinadas).Contains("_"))
                    {
                        break;
                    }
                }
                else
                {
                    //si no pertenece se dibuja una parte del cuerpo del ahorcado
                    //dibujar parte del cuerpo del ahorcado
                    dibujoAhorcado.DibujarAhorcado();
                    dibujoAhorcado.RestarIntento();
                }

            } while (dibujoAhorcado.QuedanIntentos());

            if (dibujoAhorcado.QuedanIntentos())
            {
                Console.WriteLine("Ganaste!");
                Console.WriteLine($"La palabra era {palabraElegida}");
            }
            else {
                Console.WriteLine("Has perdido. La palabra era: " + palabraElegida);
            }
            Ejecutar();
        }

        public static bool PerteneceAPalabra(string letraIngresada, string palabraElegida)
        {
            return palabraElegida.Contains(letraIngresada, StringComparison.OrdinalIgnoreCase);
        }

        public static int Iniciarjuego()
        {
            int modoJuego;
            Console.WriteLine("Bienvenido al juego del ahorcado tematica: Cocina");
            Console.WriteLine("Elija el Modo de juego");
            do
            {
                Console.WriteLine("Ingrese 1 para modo principiante");
                Console.WriteLine("Ingrese 2 para modo avanzado");
                Console.WriteLine("Ingrese 0 para terminar el juego");
                int.TryParse(Console.ReadLine(), out modoJuego);

            }while (!(1==modoJuego || 2==modoJuego || 0 == modoJuego));
            return modoJuego;
        }

        public static string ObtenerPalabraSegunModoDeJuego(int modoJuego) {
            string palabraElegida = "";
            switch (modoJuego)
            {
                case 1:
                    palabraElegida = PalabrasPosiblesPrincipiante[new Random().Next(PalabrasPosiblesPrincipiante.Count())];
                    break;
                case 2:
                    palabraElegida = PalabrasPosiblesAvanzado[new Random().Next(PalabrasPosiblesAvanzado.Count())];
                    break;
            }
            return palabraElegida;
        }
    }
}