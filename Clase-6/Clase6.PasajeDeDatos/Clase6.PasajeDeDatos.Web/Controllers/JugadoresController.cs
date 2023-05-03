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
    }
}
