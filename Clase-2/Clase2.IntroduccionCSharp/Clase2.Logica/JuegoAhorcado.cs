namespace Clase2.Logica;

public class JuegoAhorcado
{
    private List<string> LetrasAdivinadas = new List<string>();

    public void Ejecutar()
    {
        var modoJuego = ObtenerModoJuego();
        var dibujoAhorcado = new DibujoAhorcadoTradicional();
        var dibujadorPalabra = new DibujadorPalabra(LetrasAdivinadas);

        //Crear lista de palabras posibles con alguna tematica
        string palabraElegida = ObtenerPalabraElegida(modoJuego);

        if (modoJuego.Equals(ModoJuego.PRINCIPIANTE))
        {
            char letraVisible = palabraElegida[new Random().Next(palabraElegida.Count())];

            LetrasAdivinadas.Add(letraVisible.ToString());
        }

        //empezar juego y elegir una palabra
        //usuario ingresa una letra y se valida si pertenece a la palabra, si no pertenece se dibuja una parte del cuerpo del ahorcado
        do
        {
            //dibujar como se encuentra la palabra ctual con las incognitas y las letras ya descubiertas
            dibujadorPalabra.DibujarPalabra(palabraElegida);
            Console.WriteLine("Ingrese una letra");
            string letraIngresada = Console.ReadLine();

            bool perteneceAPalabra = PerteneceAPalabra(letraIngresada, palabraElegida);
            if (perteneceAPalabra)
            {
                LetrasAdivinadas.Add(letraIngresada);
                if (!dibujadorPalabra.ObtenerDibujoPalabra(palabraElegida).Contains("_"))
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

        } while (dibujoAhorcado.QuedanIntentos());
        Console.WriteLine("Has perdido. La palabra era: " + palabraElegida);
    }


    private static string ObtenerPalabraElegida(ModoJuego modoJuego)
    {
        var palabrasPosibles = modoJuego.Equals(ModoJuego.PRINCIPIANTE)
                ? DiccionarioPalabras.palabrasPrincipiante
                : DiccionarioPalabras.palabrasAvanzado;

        return palabrasPosibles[new Random().Next(palabrasPosibles.Count())];
    }

    private static ModoJuego ObtenerModoJuego ()
    {
        Console.WriteLine("Elija un modo de juego:\n 1- Principiante \n 2- Avanzado");

        return Console.ReadLine().Equals("1") 
            ? ModoJuego.PRINCIPIANTE 
            : ModoJuego.AVANZADO;
    }

    public static bool PerteneceAPalabra(string letraIngresada, string palabraElegida)
    {
        return palabraElegida.Contains(letraIngresada, StringComparison.OrdinalIgnoreCase);
    }
}