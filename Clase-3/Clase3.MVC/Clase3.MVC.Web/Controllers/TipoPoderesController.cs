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
                ViewBag.Mensaje = "No puede estar vacio el nombre del tipo de poder";
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

        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            var tipoPoderEncontrado = _tipoPoderRepositorio.ObtenerTipoPoder(id);
            return View(tipoPoderEncontrado);
        }

        [HttpGet]
        public IActionResult FormularioEditarTipoPoder(int? id)
        {
            var tipoPoderEncontrado = _tipoPoderRepositorio.ObtenerTipoPoder(id);
            ViewBag.Mensaje = "El nombre de poder ya existe";
            return View(tipoPoderEncontrado);
        }

        [HttpPost]
        public IActionResult EditarTipoPoder(TipoPoder tipoPoder)
        {
            try
            {
                var poderExistente = _tipoPoderRepositorio.ObtenerTipoPoderPorNombre(tipoPoder.Nombre);
                if (poderExistente != null && poderExistente.Id != tipoPoder.Id)
                {
                    ViewBag.Mensaje = "El nombre de poder ya existe";
                    return View(tipoPoder);
                }
                else
                {
                   // ViewBag.Mensaje = "Su edición se ha hecho correctamente";
                    _tipoPoderRepositorio.Editar(tipoPoder);
                    return RedirectToAction("Index");
                }
            }
            catch (ArgumentException ex)
            {
                ViewBag.Mensaje = "El nombre de poder está vacío";
                return View(tipoPoder);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = $"Error al editar el tipo de poder: {ex.Message}";
                return View(tipoPoder);
            }
        }
    }
}
