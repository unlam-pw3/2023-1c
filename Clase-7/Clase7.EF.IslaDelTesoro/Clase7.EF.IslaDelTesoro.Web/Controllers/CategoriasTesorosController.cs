using Clase7.EF.IslaDelTesoro.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.IslaDelTesoro.Web.Controllers
{
    public class CategoriasTesorosController : Controller
    {
        private ICategoriaTesoroServicio _categoriaTesoroServicio;
        public CategoriasTesorosController(ICategoriaTesoroServicio categoriaTesoroServicio)
        {
            _categoriaTesoroServicio = categoriaTesoroServicio;
        }
        public IActionResult Index()
        {
            return View(_categoriaTesoroServicio.ObtenerTodos());
        }
    }
}
