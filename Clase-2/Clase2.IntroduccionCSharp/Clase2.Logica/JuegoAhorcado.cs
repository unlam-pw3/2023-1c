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

        private static List<string> PalabrasPosiblesPrincipiantes = new List<string>()
        {
            //Cosas que pueden estar en la cocina
            "Plato",
            "Vaso",
            "Mesa",
            "Sarten",
            "Mantel",
            "Copa",
            "Taza",
            "Jarra",
        };

        private static List<string> PalabrasPosiblesAvanzado = new List<string>()
        {
            //Cosas que pueden estar en la cocina
            "Cuchillo",
            "Cuchara",
            "Tenedor",
            "Cucharon",
            "Cafetera",
            "Microondas",
            "Refrigerador",
        };

        private Boolean esPrincipiante = false;

        private List<string> LetrasAdivinadas = new List<string>();
        private List<string> LetrasIngresadas = new List<string>();
        public void Ejecutar()
        {
            var dibujoAhorcado = new DibujoAhorcadoTradicional();
            var dibujadorPalabra = new DibujadorPalabra();
            //Crear lista de palabras posibles con alguna tematica

            //Se solicita el nivel 1 vez para empezar eljuego
            Console.WriteLine("Ingrese  nivel de dificultas Principiante (P) o avanzado (A)");
            string nivelIngresado = Console.ReadLine()
                                           .ToUpper();
            
            if (nivelIngresado != "P" && nivelIngresado != "A")
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione P o A");
                return;
            }
           
           string palabraElegida = SelectorDeNivel(nivelIngresado ,LetrasAdivinadas);

            //string palabraElegida = PalabrasPosibles[new Random().Next(PalabrasPosibles.Count())];

            //usuario ingresa una letra y se valida si pertenece a la palabra, si no pertenece se dibuja una parte del cuerpo del ahorcado
            do
            {
                //dibujar como se encuentra la palabra ctual con las incognitas y las letras ya descubiertas
                dibujadorPalabra.DibujarPalabra(palabraElegida, LetrasAdivinadas);
                Console.WriteLine("Ingrese una letra");
                string letraIngresada = Console.ReadLine();

                bool perteneceAPalabra = PerteneceAPalabra(letraIngresada, palabraElegida);
                LetrasIngresadas.Add(letraIngresada);
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
                    dibujoAhorcado.RestarIntento();
                }
                //dibujar como se encuentra la palabra ctual con las incognitas y las letras ya descubiertas
                dibujadorPalabra.DibujarPalabra(palabraElegida, LetrasAdivinadas);

                //Ayuda Memoria en principiante para sus letras ingresadas
                //Console.WriteLine("\n\n\nRecuerde estas letras ingresadas \n****");
                //dibujadorPalabra.DibujarLetrasEntrantes(palabraElegida, LetrasIngresadas);
                //Console.WriteLine("****");

            } while (dibujoAhorcado.QuedanIntentos());

            //Verificar si salio por perdida o que realmente gano..
            if (!dibujoAhorcado.QuedanIntentos()) {
               Console.WriteLine("Has perdido. La palabra era: " + palabraElegida);
            }
           
        }

        public static bool PerteneceAPalabra(string letraIngresada, string palabraElegida)
        {
            return palabraElegida.Contains(letraIngresada, StringComparison.OrdinalIgnoreCase);
        }

        public static string SelectorDeNivel(string nivelIngresado,List<string> LetrasAdivinadas) {

            //empezar juego y elegir una palabra dependoiendo del nivel
            string palabraElegida;
            if (nivelIngresado == "P")
            {                   
                palabraElegida = PalabrasPosiblesPrincipiantes[new Random().Next(PalabrasPosiblesPrincipiantes.Count())];
                LetrasAdivinadas.Add(palabraElegida[..1][0].ToString());
             
            }
            else
            {
                palabraElegida = PalabrasPosiblesAvanzado[new Random().Next(PalabrasPosiblesAvanzado.Count())];
            }
            return palabraElegida;
        }
    }
}