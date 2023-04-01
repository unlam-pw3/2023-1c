using System.Collections;

namespace Ejercicio01
{
    public class Bola
    {

        private static ArrayList respuestas = new ArrayList();


        public static string preguntar(string pregunta)
        {
            cargarRespuestas();

            Random random = new Random();
            int value = random.Next(0, 19);
            //return $"Su respuesta a la pregunta '{pregunta}' seria : {respuestas[value]}";
            return $"RESPUESTA: {respuestas[value]}";
        }

        public static void cargarRespuestas()
        {
            respuestas.Add("Es cierto.");
            respuestas.Add("Es decididamente así.");
            respuestas.Add("Sin lugar a dudas.");
            respuestas.Add("Sí, definitivamente.");
            respuestas.Add("Puedes confiar en ello.");
            respuestas.Add("Como yo lo veo, sí.");
            respuestas.Add("Lo más probable.");
            respuestas.Add("Perspectiva buena.");
            respuestas.Add("Sí.");
            respuestas.Add("Las señales apuntan a que sí.");
            respuestas.Add("Respuesta confusa, vuelve a intentarlo.");
            respuestas.Add("Vuelve a preguntar más tarde.");
            respuestas.Add("Mejor no decirte ahora.");
            respuestas.Add("No se puede predecir ahora.");
            respuestas.Add("Concéntrate y vuelve a preguntar.");
            respuestas.Add("No cuentes con ello.");
            respuestas.Add("Mi respuesta es no.");
            respuestas.Add("Mis fuentes dicen que no.");
            respuestas.Add("Las perspectivas no son muy buenas.");
            respuestas.Add("Muy dudoso.");
        }
        
    }
}