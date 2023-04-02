using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bola8;

public class Respuesta
{
    public List<string> AffirmativeResponse;
    public List<string> ConfuseResponse;
    public List<string> NegativeResponse;

    public List<string> NewAffirmativeResponse()
    {
        return this.AffirmativeResponse = new List<string>
        {
            "Es cierto.",
            "Es decididamente así.",
            "Sí, definitivamente.",
            "Puedes confiar en ello.",
            "Como yo lo veo, sí.",
            "Lo más probable.",
            "Perspectiva buena.",
            "Sí.",
            "Las señales apuntan a que sí.",
        };
    }

    public List<string> NewConfuseResponse()
    {
        return this.ConfuseResponse = new List<string>
        {
            "Respuesta confusa, vuelve a intentarlo.",
            "Vuelve a preguntar más tarde.",
            "Mejor no decirte ahora.",
            "No se puede predecir ahora.",
            "Concéntrate y vuelve a preguntar.",
        };
    }

    public List<string> NewNegativeResponse()
    {
        return this.NegativeResponse = new List<string>
        {
            "No cuentes con ello.",
            "Mi respuesta es no.",
            "Mis fuentes dicen que no.",
            "Las perspectivas no son muy buenas.",
            "Muy dudoso.",
        };
    }
}
