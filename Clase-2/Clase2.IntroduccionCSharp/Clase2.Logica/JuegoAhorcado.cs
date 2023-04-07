namespace Clase2.Logica
{
    public class JuegoAhorcado
    {
        private static List<string> PalabrasNivelPrincipiante = new List<string>()
        {
            //Cosas que pueden estar en la cocina
            "Perro",
            "Gato",
            "Auto",
            "Casa",
            "Vaso",
            "Mesa",
            "Pasto",
        };

        private static List<string> PalabrasNivelAvanzado = new List<string>()
        {
            //Cosas que pueden estar en la cocina
            "Galaxya",
            "Interprete",
            "Introspeccion",
            "Ambar",
            "Jugueteria",
            "Ambientalista",
            "Xylofon",
        };

        private static List<string> listaActual = new List<string>();

        private List<string> LetrasAdivinadas = new List<string>();
        public void Ejecutar()
        {
            var dibujoAhorcado = new DibujoAhorcadoTradicional();
            var dibujadorPalabra = new DibujadorPalabra();
            Console.WriteLine("Ingrese 1 para nivel principante | 2 para nivel avanzado | 0 Para cerrar");
            string nivelIngresado = Console.ReadLine();
            int nivelIngresadoInt = int.Parse(nivelIngresado);
            bool continuar = true;

            while (continuar)
            {
                if (nivelIngresadoInt == 1)
                {
                    listaActual = PalabrasNivelPrincipiante;
                    continuar = false;
                }
                else if (nivelIngresadoInt == 2)
                {
                    listaActual = PalabrasNivelAvanzado;
                    continuar = false;
                }
                else if (nivelIngresadoInt == 0)
                {
                    Console.WriteLine("Hasta la proxima");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ingrese 1 para nivel principante | 2 para nivel avanzado | 0 Para cerrar");
                    nivelIngresado = Console.ReadLine();
                    nivelIngresadoInt = int.Parse(nivelIngresado);
                }
            }                     

           
            //Crear lista de palabras posibles con alguna tematica

            //empezar juego y elegir una palabra
            string palabraElegida = listaActual[new Random().Next(listaActual.Count())];

            //usuario ingresa una letra y se valida si pertenece a la palabra, si no pertenece se dibuja una parte del cuerpo del ahorcado
            do
            {
                //dibujar como se encuentra la palabra ctual con las incognitas y las letras ya descubiertas
                dibujadorPalabra.DibujarPalabra(palabraElegida, LetrasAdivinadas);
                Console.WriteLine("Ingrese una letra");
                string letraIngresada = Console.ReadLine();

                bool perteneceAPalabra = PerteneceAPalabra(letraIngresada, palabraElegida);
                if (perteneceAPalabra)
                {
                    LetrasAdivinadas.Add(letraIngresada);
                    if (!dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida, LetrasAdivinadas).Contains("_"))
                    {
                        Console.WriteLine("Ganaste!");
                        Console.WriteLine($"La palabra era {palabraElegida}");
                        return;
                    }
                }
                else
                {
                    //si no pertenece se dibuja una parte del cuerpo del ahorcado
                    //dibujar parte del cuerpo del ahorcado
                    dibujoAhorcado.DibujarAhorcado();
                    dibujoAhorcado.RestarIntento(nivelIngresadoInt);
                }

            } while (dibujoAhorcado.QuedanIntentos());
            Console.WriteLine("Has perdido. La palabra era: " + palabraElegida);
        }

        public static bool PerteneceAPalabra(string letraIngresada, string palabraElegida)
        {
            return palabraElegida.Contains(letraIngresada, StringComparison.OrdinalIgnoreCase);
        }
    }
}