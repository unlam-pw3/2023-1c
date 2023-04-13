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
    }
}
