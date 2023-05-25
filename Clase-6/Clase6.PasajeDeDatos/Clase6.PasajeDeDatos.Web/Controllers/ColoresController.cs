using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Text;

namespace Clase6.PasajeDeDatos.Web.Controllers
{
    public class ColoresController : Controller
    {
        public IActionResult Index()
        {
            List<string> colores = new List<string> { "red", "green", "blue", "yellow", "purple" };
            return View(colores);
        }
        [HttpPost]
        public IActionResult CambiarColorFondo(string color) {
            if (!string.IsNullOrEmpty(color))
            {
                HttpContext.Session.SetString("ColorFondo",color);
            }
            return RedirectToAction("Index");
        }
    }
}
