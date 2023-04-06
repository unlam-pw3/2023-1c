namespace Clase2.Logica
{
    public class JuegoAhorcado
    {
        private static List<string> PalabrasPosibles = new List<string>()
        {
            //Cosas que pueden estar en la cocina
            "Cuchillo",
            "Cuchara",
            "Tenedor",
            "Plato",
            "Vaso",
            "Mesa",
            "Sarten",
            "Cucharon",
            "Mantel",
            "Copa",
            "Cafetera",
            "Microondas",
            "Refrigerador",
            "Taza",
            "Jarra",
        };
       
        private List<string> LetrasAdivinadas = new List<string>();
        private int IntentosRestantes = 6;
        public void Ejecutar()
        {
            //Crear lista de palabras posibles con alguna tematica

            //empezar juego y elegir una palabra
            string palabraElegida = PalabrasPosibles[new Random().Next(PalabrasPosibles.Count())];

            //usuario ingresa una letra y se valida si pertenece a la palabra, si no pertenece se dibuja una parte del cuerpo del ahorcado
            do
            {
                DibujarPalabra(palabraElegida, LetrasAdivinadas);
                Console.WriteLine("Ingrese una letra");
                string letraIngresada = Console.ReadLine();

                bool perteneceAPalabra = PerteneceAPalabra(letraIngresada, palabraElegida);
                if (perteneceAPalabra)
                {
                    LetrasAdivinadas.Add(letraIngresada);
                    if (!ObtenerDibujoPalabra(palabraElegida, LetrasAdivinadas).Contains("_"))
                    {
                        Console.WriteLine("Ganaste!");
                        Console.WriteLine($"La palabra era {palabraElegida}");
                        break;
                    }
                }
                else
                {
                    //si no pertenece se dibuja una parte del cuerpo del ahorcado
                    //dibujar parte del cuerpo del ahorcado
                    DibujarAhorcado();
                    IntentosRestantes--;
                }
                //dibujar como se encuentra la palabra ctual con las incognitas y las letras ya descubiertas
                DibujarPalabra(palabraElegida, LetrasAdivinadas);

            } while (QuedanMasVidas(IntentosRestantes));
            Console.WriteLine("Has perdido. La palabra era: " + palabraElegida);
        }

        private bool QuedanMasVidas(int IntentosRestantes)
        {
            return IntentosRestantes >= 0;
        }

        private void DibujarPalabra(string palabraElegida, List<string> letrasAdivinadas)
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

        private void DibujarAhorcado()
        {
            switch (IntentosRestantes)
            {
                case 6:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 5:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 4:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 3:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 2:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|\\");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 1:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|\\");
                    Console.WriteLine("|      /");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 0:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|\\");
                    Console.WriteLine("|      / \\");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    Console.ReadLine();
                    return;
            }
        }

        private static bool PerteneceAPalabra(string letraIngresada, string palabraElegida)
        {
            return palabraElegida.Contains(letraIngresada, StringComparison.OrdinalIgnoreCase);
        }
    }
}