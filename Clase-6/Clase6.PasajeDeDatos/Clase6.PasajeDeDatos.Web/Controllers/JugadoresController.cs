using Microsoft.AspNetCore.Mvc;

namespace Clase6.PasajeDeDatos.Web.Controllers
{
    public class JugadoresController : Controller
    {
        public IActionResult Index()
        {
            List<string> jugadores = new List<string>();
            jugadores.Add("Leandro Paredes");
            jugadores.Add("Julian Alvarez");
      
            ViewBag.Jugadores = jugadores;
            return View();
        }
    }
}
