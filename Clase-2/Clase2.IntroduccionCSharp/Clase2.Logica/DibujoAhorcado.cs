using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.Logica
{
    public class DibujoAhorcadoTradicional
    {
        private int IntentosRestantes = 6;
        public void DibujarAhorcado()
        {
            switch (IntentosRestantes)
            {
                case 6:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 5:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 4:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 3:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 2:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|\\");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 1:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|\\");
                    Console.WriteLine("|      /");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    break;
                case 0:
                    Console.WriteLine(" _______");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       O");
                    Console.WriteLine("|      /|\\");
                    Console.WriteLine("|      / \\");
                    Console.WriteLine("|");
                    Console.WriteLine("|________");
                    Console.ReadLine();
                    return;
            }
        }

        public void RestarIntento(int nivelIngresado)
        {
            if (nivelIngresado == 1)
            {
                IntentosRestantes--;
            }else if (nivelIngresado == 2)
            {
                IntentosRestantes -= 2;
            }
        }

        public bool QuedanIntentos()
        {
            return IntentosRestantes >= 0;
        }


        public int getIntentosRestantes
        {
            get { return IntentosRestantes; }
        }

        public int setIntentosRestantes
        {
            set { IntentosRestantes = value; }
        }

    }
}
