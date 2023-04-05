using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase1.Logica.Ejercicios;

public class BolaOcho
{
    private readonly IList<string> posiblesRespuestas;

    public BolaOcho()
    {
        this.posiblesRespuestas = new List<string>(){
            "Puede ser que si.", "Puede ser que no.", "Es probable.", "No.", "Sabes que si.",
            "Es probable que no.", "Dios sabe.", "Quizas Si.", "No te puedo decir.", "Quizas si, quizas no."
        };
    }

    public string ContestarPregunta(string? pregunta)
    {
        this.ValidarPregunta(pregunta);

        return this.GetRandomRespuesta();
    }

    private void ValidarPregunta(string? pregunta)
    {
        if (string.IsNullOrWhiteSpace(pregunta) || pregunta.Any(char.IsDigit))
        {
            throw new ArgumentException("");
        }
    }

    private string GetRandomRespuesta()
    {
        Random random = new Random();

        int index = random.Next(this.posiblesRespuestas.Count);

        return this.posiblesRespuestas[index];
    }
}
