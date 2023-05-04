using Microsoft.AspNetCore.Mvc;

namespace Clase6.PasajeDeDatos.Web.Controllers
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
    public class JugadoresController : Controller
    {
        public IActionResult Index()
        {
            List<string> competencias = new List<string>();
            competencias.Add("Copa America Brasil 2021");
            competencias.Add("Mundial Qatar 2022");
            ViewBag.Competencias = competencias;

            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(new Jugador()
            {
                Id = 1,
                Nombre = "Julian",
                Apellido = "Alvarez"
            });

            jugadores.Add(new Jugador()
            {
                Id = 2,
                Nombre = "Leandro",
                Apellido = "Paredes"
            });

            ViewBag.Jugadores = jugadores;
            return View();
        }

        public IActionResult CalcularPromedioDeGol()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcularPromedioDeGol(double partidos, double goles)
        {
            ViewBag.Partidos = partidos;
            ViewBag.Goles = goles;
            ViewBag.PromedioDeGol = goles / partidos;
            return View();
        }

        public IActionResult IngresarUltimoTweetDeJugador()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult IngresarUltimoTweetDeJugador(string usuarioTwiter, string tweet)
        {
            TempData["UsuarioTwiter"] = usuarioTwiter;
            TempData["Tweet"] = tweet;
            return RedirectToAction("Index");
        }
    }
}
