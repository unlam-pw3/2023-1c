
string pregunta = "";

do
{
    Console.WriteLine("Ingrese una pregunta o apriete enter para finalizar: ");
    pregunta = Console.ReadLine();
    if (pregunta != "")
        Console.WriteLine(Respuesta());

}while(pregunta != "");

string Respuesta()
{
    string respuesta = "";
    Random rand = new Random();
    int random = rand.Next(1,8);//devuelve un número aleatorio entre el rango de 2 números

    switch (random)
    {
        case 1:
            respuesta = "Es cierto";
            break;
        case 2:
            respuesta = "Sin lugar a dudas";
            break;
        case 3:
            respuesta = "Lo más probable";
            break;
        case 4:
            respuesta = "Si";
            break;
        case 5:
            respuesta = "Respuesta confusa, vuelve a intentarlo";
            break;
        case 6:
            respuesta = "Vuelve a preguntar más tarde";
            break;
        case 7:
            respuesta = "No se puede predecir ahora";
            break;
        case 8:
            respuesta = "No cuentes con ello";
            break;
    }

    return respuesta;
}