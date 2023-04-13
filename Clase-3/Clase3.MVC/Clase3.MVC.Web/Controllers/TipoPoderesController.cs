using Clase3.MVC.Dominio.Entidades;
using Clase3.MVC.Dominio.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.Web.Controllers
{
    public class TipoPoderesController : Controller
    {
        ITipoPoderRepositorio _tipoPoderRepositorio;
        public TipoPoderesController(ITipoPoderRepositorio tipoPoderRepositorio)
        {
            _tipoPoderRepositorio = tipoPoderRepositorio;
        }
        public IActionResult Index()
        {
            var tiposPoderes = _tipoPoderRepositorio.ObtenerTodos();
            return View(tiposPoderes);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(TipoPoder tipoPoder)
        {
            try
            {
                _tipoPoderRepositorio.Agregar(tipoPoder);
            }
            catch (ArgumentException ex)
            {
               ViewBag.Mensaje = $"El nombre de poder {tipoPoder.Nombre} ya existe";
               return View(tipoPoder);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View(tipoPoder);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            _tipoPoderRepositorio.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
