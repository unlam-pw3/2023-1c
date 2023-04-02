using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bola8;

public class Bola
{
    public Respuesta respuestas = new Respuesta();

    public void WelcomeMsg()
    {
        Console.WriteLine("¡Hola, bienvenido!");
        Console.WriteLine("Pregunte lo que desee: ");
        Console.WriteLine("Si desea salir del programa presione la tecla 'X'");
    }

    public string AskMe()
    {
        string question = Console.ReadLine();
        Boolean isNull = IsNull(question);

        while (isNull)
        {
            Console.WriteLine("No ha preguntado nada aún, intente nuevamente.");
            question = Console.ReadLine();
            if (!IsNull(question)) { isNull = false;  }
        }
        return question;
    }
    private bool IsNull(string question)
    {
        if (question == "") { return true; }
        return false;
    }

    public string GetRandomResponse(string question)
    {
        string response; 
        Random r = new Random();
        int random = r.Next(1, 3);
        switch (random)
        {
            case 1:
                return RandomAffirmativeResponse();
                break;
            case 2:
                return RandomNegativeResponse();
                break;
            case 3:
                return  RandomConfuseResponse();
                break;
        }
        return null;
    }

    private string RandomAffirmativeResponse()
    {
        List<string> col = this.respuestas.NewAffirmativeResponse();
        Random r = new Random();
        int random = r.Next(1, col.Count);
        return this.respuestas.AffirmativeResponse[random];
    }

    private string RandomNegativeResponse()
    {
        List<string> col = this.respuestas.NewNegativeResponse();
        this.respuestas.NewNegativeResponse();
        Random r = new Random();
        int random = r.Next(1, col.Count);
        return this.respuestas.NegativeResponse[random];
    }

    private string RandomConfuseResponse()
    {
        List<string> col = this.respuestas.NewConfuseResponse();
        this.respuestas.NewConfuseResponse();
        Random r = new Random();
        int random = r.Next(1, col.Count);
        return this.respuestas.ConfuseResponse[random];
    }

    public void CloseGame(string c)
    {
        if (c.Equals('x'))
        {
            Console.Beep();
        }
    }
}
