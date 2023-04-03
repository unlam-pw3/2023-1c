
// obtengo la pregunta
// determino la rta, eligiendo aleatoriamente de una lista
// la muestro
// repito


Random randomOBJ = new Random();

string[] respuestasAfirmativas =
    {
    "Es cierto.",
    "Es decididamente así.",
    "Sin lugar a dudas.",
    "Sí, definitivamente.",
    "Puedes confiar en ello.",
    "Como yo lo veo, sí.",
    "Lo más probable.",
    "Perspectiva buena.",
    "Sí.",
    "Las señales apuntan a que sí."
    };
string[] respuestasNegativas =
    {
    "No cuentes con ello.",
    "Mi respuesta es no.",
    "Mis fuentes dicen que no.",
    "Las perspectivas no son muy buenas.",
    "Muy dudoso."
    };
string[] respuestasNoComprometidas =
    { 
    "Respuesta confusa, vuelve a intentarlo.",
    "Vuelve a preguntar más tarde.",
    "Mejor no decirte ahora.",
    "No se puede predecir ahora.",
    "Concéntrate y vuelve a preguntar."
    };

string[][] respuestasPosibles = { respuestasAfirmativas, respuestasNegativas, respuestasNoComprometidas };


string pregunta;
do
{

    Console.Write("Ingrese una pregunta que se pueda resolver con un si o un no --> ");
    pregunta = Console.ReadLine();
    Console.WriteLine( "La Bola Mágica 8 dice: " + ObtenerRespuesta(pregunta) + "\n");

} while (pregunta != "");

string ObtenerRespuesta(string pregunta)
{
    int tipoDeRta;
    int indexDeRta;

    if ( pregunta != "" && pregunta != null )
    {
        tipoDeRta = randomOBJ.Next(0, respuestasPosibles.Length);
        indexDeRta = randomOBJ.Next(0, respuestasPosibles[tipoDeRta].Length);
    }
    else
    {
        tipoDeRta = 2; //seteo a rtas. no comprometidas
        indexDeRta = randomOBJ.Next(0, respuestasPosibles[tipoDeRta].Length);
    }
    return respuestasPosibles[tipoDeRta][indexDeRta];
}