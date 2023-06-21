using Microsoft.AspNetCore.Mvc;
using SistemaDeCadenasAlimenticias.Data.EF;
using SistemaDeCadenasAlimenticias.Servicios;

namespace SistemaDeCadenasAlimenticias.Web.Controllers
{
    public class SucursalesController : Controller
    {
        private ICadenasServicio _cadenasServicio;
        private ISucursalesServicio _sucursalesServicio;

        public SucursalesController(ICadenasServicio cadenasServicio, ISucursalesServicio sucursalesServicio)
        {
            _cadenasServicio = cadenasServicio;
            _sucursalesServicio = sucursalesServicio;
        }

        //Agregar Surcursal
        public IActionResult Agregar()
        {
            ViewBag.Cadenas = _cadenasServicio.Listar();
            return View(new Sucursal());
        }

        //Agregar Sucursal Post
        [HttpPost]
        public IActionResult Agregar(Sucursal sucursal)
        {
            _sucursalesServicio.Agregar(sucursal);
            return RedirectToAction("Listar");
        }

        //Listar
        public IActionResult Listar(int? idCadena)
        {
            ViewBag.Cadenas = _cadenasServicio.Listar();
            ViewBag.IdCadenaSeleccionada = idCadena;
            if (idCadena.HasValue)
            {
                return View(_sucursalesServicio.ObtenerPorCadena(idCadena.Value));
            }
            return View(_sucursalesServicio.Listar());
        }
    }
}
