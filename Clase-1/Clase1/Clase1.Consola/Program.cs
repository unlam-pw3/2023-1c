// See https://aka.ms/new-console-template for more information

using Clase1.Logica;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using Clase1.Logica.Ejercicios;
using Ejercicio01;

//Bola.init();
bool repeat = true;
while (repeat)
{
    Console.WriteLine("----------------");
    Console.WriteLine("Haga una pregunta: ");
    string pregunta = Console.ReadLine();
    string respuesta = Bola.preguntar(pregunta);
    Console.WriteLine(respuesta);
}
