using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MagicBall
    {
        public static string GetResponse(string question)
        {
            List<string> defaultResponses = Response.PopulateResponsesForDefualt();
            
            if (!string.IsNullOrEmpty(question) && question.EndsWith('?'))
            {
                int target = new Random().Next(0, defaultResponses.Count());
                return $"Respuesta: {defaultResponses[target]}";
            }
            
            return "La pregunta no debe estar vacia y debe terminar con el signo de interrogacion (?)";
        }
    }
}
