// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// create an array of integers with 5 elements
string[] respuestasArray = new string[21];

// assign values to the array
respuestasArray[0] = "Es cierto";
respuestasArray[1] = "Es decididamente así";
respuestasArray[2] = "Sin lugar a dudas";
respuestasArray[3] = "Si, definitivamente";
respuestasArray[4] = "Puedes confiar en ello";
respuestasArray[5] = "Como yo lo veo, sí";
respuestasArray[6] = "Lo más probable";
respuestasArray[7] = "Perspectiva buena";
respuestasArray[8] = "Si";
respuestasArray[9] = "Las señales apuntan a que sí";
respuestasArray[10] = "Respuesta confusa, vuelve a intentarlo";
respuestasArray[11] = "Vuelve a preguntar más tarde";
respuestasArray[12] = "Mejor no decirte ahora";
respuestasArray[13] = "No se puede predecir ahora";
respuestasArray[14] = "Concentrate y vuelve a preguntar";
respuestasArray[15] = "No cuentes con ello";
respuestasArray[16] = "Mi respuesta es no";
respuestasArray[17] = "Mis fuentes dicen que no";
respuestasArray[18] = "Las perspectivas no son muy buenas";
respuestasArray[19] = "Muy dudoso";
respuestasArray[20] = "Absolutamente";

string pregunta = "";

do
{
    Console.WriteLine("Escribe una pregunta para la bola mágica... - 0 para salir");
    pregunta = Console.ReadLine();
    if(pregunta != "0")
    {
        Random random = new Random();
        int randomIndex = random.Next(respuestasArray.Length);
        Console.WriteLine(respuestasArray[randomIndex]);
    }
    
} while (pregunta != "0");