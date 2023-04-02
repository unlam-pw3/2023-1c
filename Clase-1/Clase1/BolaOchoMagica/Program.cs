/*** Bola ocho mágica ***/

Console.WriteLine("Has una pregunta: ");

string pregunta = Console.ReadLine();

Random rnd = new Random();
int respuestaRandom = rnd.Next(1, 10);

string respuesta = "";

switch (respuestaRandom)
{
    case 1:
        respuesta = "Sin lugar a dudas.";
        break;
    case 2:
        respuesta = "Sí, definitivamente.";
        break;
    case 3:
        respuesta = "Como yo lo veo, sí.";
        break;
    case 4:
        respuesta = "Lo más probable.";
        break;
    case 5:
        respuesta = "Sí.";
        break;
    case 6:
        respuesta = "Mi respuesta es no.";
        break;
    case 7:
        respuesta = "Mis fuentes dicen que no.";
        break;
    case 8:
        respuesta = "Muy dudoso.";
        break;
    case 9:
        respuesta = "No cuentes con ello.";
        break;
    case 10:
        respuesta = "Muy dudoso.";
        break;
}

Console.WriteLine(respuesta);