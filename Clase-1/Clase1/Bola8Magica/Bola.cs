using System.Diagnostics;

namespace Bola8Magica;

public class Bola
{
    private String[] respuestasPosibles = new String[] {};

    public Bola() {
        respuestasPosibles = cargarRespuestas();
    }

    private String[] cargarRespuestas()
    {
        return new string[] { "Es cierto.", "Es decididamente así.", "Sin lugar a dudas.", "Sí, definitivamente.", "Puedes confiar en ello.", "Como yo lo veo, sí.",
                              "Lo más probable.", "Perspectiva buena.", "Sí.", "Las señales apuntan a que sí.", "Respuesta confusa, vuelve a intentarlo.",
                              "Vuelve a preguntar más tarde.", "Mejor no decirte ahora.", "No se puede predecir ahora.", "Concéntrate y vuelve a preguntar.", "No cuentes con ello.",
                              "Mi respuesta es no.", "Mis fuentes dicen que no.", "Las perspectivas no son muy buenas.", "Muy dudoso."};
    }

    public string obtenerRespuesta()
    {
        var random = new Random();
        return respuestasPosibles[random.Next(0, respuestasPosibles.Length)];
    }
}