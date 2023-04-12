using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoBola8
{
    public class Respuesta
    {
        private List<string> listRespuestas;

        public Respuesta()
        {
            this.listRespuestas = new List<string>();

            //afirmativas
            listRespuestas.Add("Es cierto");
            listRespuestas.Add("Es decididamente así");
            listRespuestas.Add("Sin lugar a dudas");
            listRespuestas.Add("Sí definitivamente");
            listRespuestas.Add("Puedes confiar en ello");
            listRespuestas.Add(" Como yo lo veo, sí");
            listRespuestas.Add("Lo más probable");
            listRespuestas.Add("Perspectiva buena");
            listRespuestas.Add("Sí");
            listRespuestas.Add("Las señales apuntan a que sí");
            //no comprometidas
            listRespuestas.Add("Respuesta confusa vuelve a intentarlo");
            listRespuestas.Add("Vuelve a preguntar más tarde");
            listRespuestas.Add("Mejor no decirte ahora");
            listRespuestas.Add("No se puede predecir ahora");
            listRespuestas.Add("Concéntrate y vuelve a preguntar");
            //negativas
            listRespuestas.Add("No cuentes con ello");
            listRespuestas.Add("Mi respuesta es no");
            listRespuestas.Add("Mis fuentes dicen que no");
            listRespuestas.Add("Las perspectivas no son muy buenas");
            listRespuestas.Add("Muy dudoso");

        }

        public string getRespuesta()
        {
            int valorResultante = this.calcularRespuestaRandom();
            return listRespuestas[valorResultante];
        }

        private int calcularRespuestaRandom()
        {
            int min = 1;
            int max = 20;

            Random rnd = new Random();

            return rnd.Next(min, max);
        }

    }
}
