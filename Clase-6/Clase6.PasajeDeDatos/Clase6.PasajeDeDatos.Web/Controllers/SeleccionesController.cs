using Clase6.PasajeDeDatos.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.PasajeDeDatos.Web.Controllers
{
    public class SeleccionesController : Controller
    {
        public IActionResult Index()
        {
            var seleccionesSudamericanasEliminatorias2026 = new List<SeleccionViewModel>()
            {
                new SeleccionViewModel()
                {
                    Id = 1,
                    Nombre = "Argentina",
                    Apodo = "La Albiceleste"
                },
                new SeleccionViewModel()
                {
                    Id = 2,
                    Nombre = "Bolivia",
                    Apodo = "La Verde"
                },
                new SeleccionViewModel()
                {
                    Id = 3,
                    Nombre = "Brasil",
                    Apodo = "La Verdeamarela"
                },
                new SeleccionViewModel()
                {
                    Id = 4,
                    Nombre = "Chile",
                    Apodo = "La Roja"
                },
                new SeleccionViewModel()
                {
                    Id = 5,
                    Nombre = "Colombia",
                    Apodo = "Los Cafeteros"
                },
                new SeleccionViewModel()
                {
                    Id = 6,
                    Nombre = "Ecuador",
                    Apodo = "La Tri"
                },
                new SeleccionViewModel()
                {
                    Id = 7,
                    Nombre = "Paraguay",
                    Apodo = "La Albirroja"
                },
                new SeleccionViewModel()
                {
                    Id = 8,
                    Nombre = "Peru",
                    Apodo = "La Blanquirroja"
                },
                new SeleccionViewModel()
                {
                    Id = 9,
                    Nombre = "Uruguay",
                    Apodo = "La Celeste"
                },
                new SeleccionViewModel()
                {
                    Id = 10,
                    Nombre = "Venezuela",
                    Apodo = "La Vinotinto"
                }
            };
            return View(seleccionesSudamericanasEliminatorias2026);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string nombreBoton = form.Keys.FirstOrDefault(k => !string.IsNullOrEmpty(form[k]));
            if (!string.IsNullOrEmpty(nombreBoton))
                HttpContext.Session.SetString("SeleccionFavorita", nombreBoton);
            return RedirectToAction("Index");
        }
    }
}
