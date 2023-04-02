using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

internal class Response
{
    public static List<string> PopulateResponsesForDefualt() 
    {
            StreamReader sr = new StreamReader("preguntas.txt");
            string line = sr.ReadLine();
            List<string> lines = new List<string>();

            while (line != null)
            {
                lines.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return lines;
        
    }
}
