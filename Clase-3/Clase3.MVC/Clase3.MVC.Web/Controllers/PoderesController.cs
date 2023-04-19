using Clase3.MVC.Dominio.Entidades;
using Clase3.MVC.Dominio.Logica;
using Clase3.MVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.Web.Controllers
{
    public class PoderesController : Controller
    {
            IPoderesRepositorio _poderRepositorio;
            public PoderesController(IPoderesRepositorio poderRepositorio)
            {
                _poderRepositorio = poderRepositorio;
            }
            public IActionResult Index()
            {
                var classViewModel = new ClassViewModel();
                var poderes = _poderRepositorio.ObtenerTodos();
                classViewModel.poderes = poderes;
                return View(classViewModel);
            }

            [HttpGet]
            public IActionResult Agregar()
            {
                var classViewModel = new ClassViewModel();
                TipoPoderRepositorio tipoPoderRepositorio = new TipoPoderRepositorio();
                var tipopoderes = tipoPoderRepositorio.ObtenerTodos();
                classViewModel.tipoPoder = tipopoderes;

                return View(classViewModel);
            }

            [HttpGet]
            public IActionResult Ver()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Detalle(int id)
            {
            var classViewModel = new ClassViewModel();
            TipoPoderRepositorio tipoPoderRepositorio = new TipoPoderRepositorio();
            var tipopoderes = tipoPoderRepositorio.ObtenerTodos();
            var tipoPoder = _poderRepositorio.ObtenerEspecifico(id);
            classViewModel.tipoPoder = tipopoderes;
            classViewModel.poder = tipoPoder;

             return View(classViewModel);
            }

            [HttpPost]
            public IActionResult Agregar(Poder poder)
            {
                try
                {
                    _poderRepositorio.Agregar(poder);
                }
                catch (ArgumentException ex)
                {
                    ViewBag.Mensaje = $"El nombre de poder {poder.Nombre} ya existe";
                    return View(poder);
                }
                catch (Exception ex)
                {
                    ViewBag.Mensaje = ex.Message;
                    return View(poder);
                }

                return RedirectToAction("Index");
            }

            [HttpGet]
            public IActionResult Eliminar(int id)
            {
                 _poderRepositorio.Eliminar(id);
                return RedirectToAction("Index");
            }
    }
}
